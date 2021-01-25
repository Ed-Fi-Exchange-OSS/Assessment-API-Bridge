param($configLocation=".\install-config.json")

Import-Module WebAdministration

if (Get-Command AI_GetMsiProperty -ErrorAction SilentlyContinue) {
    $configLocation = AI_GetMsiProperty AI_INSTALLCONFIG.JSON
}

function Test-IISInstalled {
    $iisService = Get-Service w3svc -ErrorAction SilentlyContinue
    return $null -ne $iisService
}

function Test-DotNet462Installed {
    $releaseNumber = 394802 # .NET Framework 4.6.2 Version number taken from microsoft.com
    return Get-ChildItem 'HKLM:\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\' |  Get-ItemPropertyValue -Name Release | Foreach-Object { $_ -ge $releaseNumber }
}

function Show-PreReqWarningsIfMissing {
    $iisInstalled = Test-IISInstalled
    $dotNetInstalled = Test-DotNet462Installed

    if (!$iisInstalled) {
        $iisConfirmation = Read-Host "IIS couldn't be found on the system, and is required for an install. Press [Y] to continue and [N] to exit"
        if ($iisConfirmation -ne 'Y') {
            exit
        }
    }

    if (!$dotNetInstalled) {
        $dotNetConfirmation = Read-Host ".NET 4.6.2 couldn't be found on the system, and is required for install. Press [Y] to continue and [N] to exit"
        if ($dotNetConfirmation -ne 'Y') {
            exit
        }
    }
}

function Get-RandomAlphanumericString (
    $length = 8
) {
    return ( -join ((0x30..0x39) + ( 0x41..0x5A) + ( 0x61..0x7A) | Get-Random -Count $length | % { [char]$_ }) )
}

function New-Cert {
    
    $plainPassword = Get-RandomAlphanumericString 20

    $password = ConvertTo-SecureString $plainPassword -AsPlainText -Force 

    $certFile = "$PSScriptRoot\Ed-Fi-ODS-SelfSignedCertificate.pfx"

    $certParams = @{
        CertStoreLocation = 'Cert:\LocalMachine\My'
        Subject           = $env:computername
        DnsName           = $env:computername
        KeyExportPolicy   = 'Exportable'
        KeyAlgorithm      = 'RSA'
        KeyLength         = 2048
        FriendlyName      = "Ed-Fi-ODS"
    }

    $cert = (dir $certParams.CertStoreLocation | ? { $_.subject -like "*$($certParams.Subject)*" -and $_.FriendlyName -like $($certParams.FriendlyName) }) 
    if (!$cert) {
        Write-Host "Creating new self signed certificate: $($certParams.FriendlyName)"
        $rootcert = (dir cert:\LocalMachine\Root\ | ? { $_.subject -like "*$($certParams.Subject)*" -and $_.FriendlyName -like $($certParams.FriendlyName) }) 
        if ($rootcert) {
            $rootcert | Remove-Item
        }
        $cert = (New-SelfSignedCertificate @certParams)
    } else {
        Write-Warning "Using self signed certificate: $($certParams.FriendlyName), that already exists"
    }

    $exportCertParams = @{
        Cert     = "cert:\LocalMachine\My\$($cert.Thumbprint)"
        FilePath = $certFile
        Password = $password
    }
    $rootcert = (dir cert:\LocalMachine\Root\ | ? { $_.subject -like "*$($certParams.Subject)*" -and $_.FriendlyName -like $($certParams.FriendlyName) }) 
    if (!$rootcert) {
        Write-Host "Importing $($certParams.FriendlyName) to Trust Root Certifcate store"
        Export-PfxCertificate @exportCertParams | Out-Null
        Import-PfxCertificate -CertStoreLocation 'Cert:\LocalMachine\Root' -FilePath $certFile -Password $password | Out-Null
    }

    return $cert
}

function Set-Attribute (
    $filePath, 
    $xpath,
    $attribute,
    $value
) {

    [xml] $fileXml = Get-Content $filePath    
    $node = $fileXml.SelectSingleNode($xpath)
    if ($null -eq $node) {
        Write-Host "could not find node @ $xpath";
        return;
    }
   	$node.SetAttribute($attribute, $value)
    $fileXml.Save($filePath) 
}

function Set-AssessmentBridgeWebConfig (
    $installDirectory,
    $appConfig
) {
    $websitePhysicalPath = [IO.Path]::Combine($installDirectory, "AssessmentAPIBridge.WebApi")

    $webConfig = [IO.Path]::Combine($websitePhysicalPath, "Web.config")
    
    Set-Attribute $webConfig '/configuration/appSettings/add[@key="DescriptorNamespacePrefix"]' "value" $appConfig.descriptorNamespacePrefix
	Set-Attribute $webConfig '/configuration/appSettings/add[@key="IncludeSchoolYearInUpstreamRoute"]' "value" $appConfig.includeSchoolYearInUpstreamRoute
	Set-Attribute $webConfig '/configuration/appSettings/add[@key="UpstreamEdFiApiUrl"]' "value" $appConfig.upstreamEdFiApiUrl
}


function Get-WebsiteByName(
    $websiteName
) {
    $sitePath = ("IIS:\Sites\" + $websiteName)
    $site = Get-Item $sitePath -ErrorAction SilentlyContinue
    return $null -ne $site
}

function Get-AppPoolByName(
    $appPoolName
) {
    $appPoolPath = ("IIS:\AppPools\" + $appPoolName)
    return Get-Item $appPoolPath -ErrorAction SilentlyContinue
}

function New-AssessmentBridgeAppPool(
    $iisConfig
) {
    $apppool = Get-AppPoolByName "AssessmentAPIBridge"
    if (!$appPool) {
        Write-Host "Created new IIS Application Pool: AssessmentAPIBridge"

        $apppool = New-WebAppPool "AssessmentAPIBridge" -Force

        $apppool.startMode = "alwaysrunning"

        if ($iisConfig.appPoolUser) {
            $apppool.processModel.identityType = "SpecificUser"
            
            $domainPrefix = ""
            if ($iisConfig.appPoolUserDomain) {
                $domainPrefix = "$($iisConfig.appPoolUserDomain)\"
            }

            $apppool.processModel.userName = "$($domainPrefix)$($iisConfig.appPoolUser)"
            $apppool.processModel.password = $iisConfig.appPoolPassword
        }

        $apppool | Set-Item -Verbose
    } else {
        Write-Warning "Using IIS Application Pool: AssessmentAPIBridge, that already exists"
    }

    return $apppool
}

function New-AssessmentBridgeWebApplication (
    $siteName,
    $installationDirectory,
    $appPool,
    $webAppName
) {
    $physicalPath = [IO.Path]::Combine($installationDirectory, "AssessmentAPIBridge.WebApi")

    $webApp = Get-WebApplication -Site $siteName -Name $webAppName
    if (!$webApp) {
        New-WebApplication -Name $webAppName -Site $siteName -PhysicalPath $physicalPath -ApplicationPool $appPool.name
        Write-Host "Created new IIS Web Application: $webAppName"
    } else {
        Write-Warning "Using IIS Web Application: $webAppName, that already exists"
    }
}

function New-EdFiWebSite (
    $iisConfig,
    $installDirectory
) {
    Write-Host "Creating new IIS Website: Ed-Fi"

    $edfiapppool = Get-AppPoolByName "Ed-Fi"
    if ($edfiapppool) {
        Write-Warning "Using IIS Application Pool: Ed-Fi, that already exists"
    } else {
        Write-Host "Creating new IIS Application Pool: Ed-Fi"
    
        $edfiapppool = New-WebAppPool "Ed-Fi" -Force

        $edfiapppool.startMode = "alwaysrunning"
        if ($iisConfig.appPoolUser) {
            $edfiapppool.processModel.identityType = "SpecificUser"

            $domainPrefix = ""
            if ($iisConfig.appPoolUserDomain) {
                $domainPrefix = "$($iisConfig.appPoolUserDomain)\"
            }

            $edfiapppool.processModel.userName = "$($domainPrefix)$($iisConfig.appPoolUser)"
            $edfiapppool.processModel.password = $iisConfig.appPoolPassword
        }

        $edfiapppool | Set-Item -Verbose
    }

    $cert = New-Cert

    $physicalPath = [IO.Path]::Combine($installDirectory, "WebRoot")
    
    New-Website -Name "Ed-Fi" -PhysicalPath $physicalPath -ApplicationPool $edfiapppool.name -HostHeader "$env:computername" -Port $iisConfig.websitePort -Ssl
    $binding = Get-WebBinding -Name "Ed-Fi" -Protocol "https"
    $binding.AddSslCertificate($cert.GetCertHashString(), "my")
}

Show-PreReqWarningsIfMissing

$config = Get-Content $configLocation | ConvertFrom-Json

$websiteConfig = $config.webapi
$applicationConfig = $config.application
$iisConfig = $websiteConfig.iis
if([System.IO.Path]::IsPathRooted($websiteConfig.installationDirectory))
{
    $websiteInstallationDirectory = $websiteConfig.installationDirectory
}
else {
    $websiteInstallationDirectory = [System.IO.Path]::GetFullPath([IO.Path]::Combine($pwd, $websiteConfig.installationDirectory))
}

Set-AssessmentBridgeWebConfig $websiteInstallationDirectory $applicationConfig 

$appPool = New-AssessmentBridgeAppPool $iisConfig

$edfiWebSiteName = "Ed-Fi"

$edFiWebsite = Get-WebsiteByName $edfiWebSiteName

if ($edFiWebsite) {
    Write-Warning "Using IIS Website: Ed-Fi, that already exists"
    New-AssessmentBridgeWebApplication $edfiWebSiteName $websiteInstallationDirectory $appPool $iisconfig.webApplicationName
}
else {
    New-EdFiWebSite $iisConfig $websiteInstallationDirectory
    New-AssessmentBridgeWebApplication $edfiWebSiteName $websiteInstallationDirectory $appPool $iisconfig.webApplicationName
}