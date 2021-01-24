Import-Module WebAdministration

$websiteName = "AssessmentAPIBridge"
$appPoolName = "AssessmentAPIBridge"

$diWebApp = Get-WebApplication -Name $websiteName -Site "Ed-Fi"
if ($null -ne $diWebApp) {
    Remove-WebApplication -Name $websiteName -Site "Ed-Fi"    
}

$diAppPool = get-childitem ("IIS:\AppPools\" + $appPoolName) -ErrorAction SilentlyContinue
if ($null -ne $diAppPool){
    Remove-WebAppPool -Name $appPoolName
}

# Only remove the Ed-Fi website if it isn't being used by another Ed-Fi Application
$edFiWebApps = Get-WebApplication -Site 'Ed-Fi'
$edFiWebSite = Get-Website -name 'Ed-fi'
if ($null -eq $edFiWebApps -and $null -ne $edFiWebSite){
    Remove-Website -name 'Ed-Fi'
    Remove-WebAppPool -name 'Ed-Fi'
}

if (Get-Command AI_GetMsiProperty -ErrorAction SilentlyContinue) {
    $filelocation = AI_GetMsiProperty AI_INSTALLCONFIG.JSON
    Remove-Item -Path $filelocation
}
