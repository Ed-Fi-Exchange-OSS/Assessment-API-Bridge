// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.
 
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EdFi.Ods.AssessmentBridge.WebApi.Common
{
    public class AppConfigValueProvider
    {
        /// <summary>
        /// Gets the specified appSettings value by name.
        /// </summary>
        /// <param name="name">The name of the appSettings value to be retrieved.</param>
        /// <returns>The value of appSettings entry.</returns>
        public static string GetValue(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }

        /// <summary>
        /// Gets the specific appSettings value by name as a boolean, returning false if it does not exist.
        /// </summary>
        /// <param name="name">The name of the appSettings value to be retrieved.</param>
        /// <returns>The value of appSettings entry.</returns>
        public static bool GetBool(string name)
        {
            bool.TryParse(GetValue(name), out bool configValue);
            return configValue;
        }
    }
}