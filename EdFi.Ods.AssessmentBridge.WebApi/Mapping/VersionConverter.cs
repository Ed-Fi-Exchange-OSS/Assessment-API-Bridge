// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.
 
using System;
using System.Configuration;
using System.Linq;

public static class VersionConverter
{
    private static readonly Lazy<Uri> _defaultV25Namespace = new Lazy<Uri>(
        () => new Uri(ConfigurationManager.AppSettings["DescriptorNamespacePrefix"] ?? "http://ed-fi.org/"));

    public static Uri DefaultV25NamespaceUri => _defaultV25Namespace.Value;

    public static string DescriptorV2ToV3(string descriptorName, string value)
    {
        try
        {
            if (!descriptorName.EndsWith("Descriptor"))
                throw new Exception("Check the argument order. Name provided is not a descriptor.");

            if (string.IsNullOrEmpty(value))
                return value;

            string upstreamValue, upstreamValueHost;

            int schemePos = value.IndexOf("://");

            // Is this a literal (non-fully qualified URI) value?
            if (schemePos < 0)
            {
                upstreamValue = value;
                upstreamValueHost = DefaultV25NamespaceUri.Host;
            }
            else
            {
                int hostStartPos = schemePos + "://".Length;
                int hostEndPos = value.IndexOf('/', hostStartPos);

                if (hostEndPos < 0)
                    throw new Exception("Unable to extract host from provided descriptor value.");

                upstreamValueHost = value.Substring(schemePos + "://".Length, hostEndPos - hostStartPos);

                // Look for the descriptor value expressed as a fully qualified name using the .xml convention
                int xmlPos = value.IndexOf(".xml/");

                // XML path convention is in use
                if (xmlPos >= 0)
                {
                    // Value is immediately after the ".xml" segment
                    upstreamValue = value.Substring(xmlPos + ".xml/".Length);
                }
                else
                {
                    int lastSlash = value.LastIndexOf('/');
					
                    if (lastSlash >= hostEndPos)
                    {
                        // Try using the final segment as the value (this won't work for descriptor code values that happen to include "/" in the value)
                        upstreamValue = value.Substring(value.LastIndexOf('/') + 1);
                    }
                    else 
                    {
                        throw new Exception($"Unable to convert '{descriptorName}' value of '{value}' to v3 because it does not use the expected format.");
                    }
                }
            }

            return $"uri://{upstreamValueHost}/{descriptorName}#{upstreamValue}";
        }
        catch (Exception ex)
        {
            throw new Exception($"Unable to convert '{descriptorName}' value of '{value}' from v2 to v3.", ex);
        }
    }

    public static string DescriptorV3ToV2(string descriptorName, string value)
    {
        if (!descriptorName.EndsWith("Descriptor"))
            throw new Exception("Check the argument order. Name provided is not a descriptor.");

        if (String.IsNullOrEmpty(value))
            return value;

        var parts = value.Split('#');

        if (parts.Length == 1)
            return value;

        string valueFragment = string.Join("#", parts.Skip(1));

        var valueUri = new Uri(parts[0]);

        // Should we convert this to just the value (using v2.5's "default namespace" convention)?
        if (valueUri.Host == DefaultV25NamespaceUri.Host)
        {
            // Just return the fragment portion as the value
            return valueFragment;
        }

        // Returned descriptor URI does not match the configured default namespace's host, so return a fully-qualified v2.5 URI value
        return $"{DefaultV25NamespaceUri.Scheme}://{valueUri.Host}/Descriptor/{descriptorName}.xml/{valueFragment}";
    }

    public static string DescriptorToType(string value)
    {
        if (String.IsNullOrEmpty(value))
            return value;
            
        return value.IndexOf('#') < 0 ? value : value.Substring(value.IndexOf('#') + 1);
    }

    public static string TypeToDescriptor(string value, string descriptorName)
    {
        if (!descriptorName.EndsWith("Descriptor"))
            throw new Exception("Check the argument order. Name provided is not a descriptor.");

        if (String.IsNullOrEmpty(value))
            return value;

        return $"uri://ed-fi.org/{descriptorName}#" + value;
    }

    public static string DescriptorNamespaceV3ToV2(string v3Namespace)
    {
        try
        {
            var namespaceUri = new Uri(v3Namespace);

            // Create idiomatic Ed-Fi ODS API v2.x formatted namespace
            return $"http://{namespaceUri.Host}/Descriptor/{namespaceUri.Segments.Last()}.xml";
        }
        catch (Exception ex)
        {
            throw new Exception($"V3 namespace of '{v3Namespace}' was not in the expected format.", ex);
        }
    }

    public static string DescriptorNamespaceV2ToV3(string v2Namespace, string knownDescriptorName)
    {
        try
        {
            var namespaceUri = new Uri(v2Namespace);

            return $"uri://{namespaceUri.Host}/{knownDescriptorName}";
        }
        catch (Exception ex)
        {
            throw new Exception($"V2 namespace of '{v2Namespace}' was not in the expected format.", ex);
        }
    }
    
    public static string ResourceNamespacePropertyV3ToV2(string v3Namespace)
    {
        try
        {
            var namespaceUri = new Uri(v3Namespace);

            // Create idiomatic Ed-Fi ODS API v3.x namespace value
            return "http://" + v3Namespace.Substring(v3Namespace.IndexOf("://") + "://".Length);
        }
        catch (Exception)
        {
            // Unable to parse as URI, just pass value as-is
            return v3Namespace;
        }
    }

    public static string ResourceNamespacePropertyV2ToV3(string v2Namespace)
    {
        try
        {
            var namespaceUri = new Uri(v2Namespace);

            // Create idiomatic Ed-Fi ODS API v3.x namespace value
            return "uri://" + v2Namespace.Substring(v2Namespace.IndexOf("://") + "://".Length);
        }
        catch (Exception)
        {
            // Unable to parse as URI, just pass value as-is
            return v2Namespace;
        }
    }
}

