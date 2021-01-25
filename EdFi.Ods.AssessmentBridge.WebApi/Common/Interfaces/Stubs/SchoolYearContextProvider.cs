// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.
 
using EdFi.Ods.Common.Context;

namespace EdFi.Ods.AssessmentBridge.WebApi.Common.Interfaces.Stubs
{
    public class SchoolYearContextProvider : ISchoolYearContextProvider
    {
        public int GetSchoolYear()
        {
            throw new System.NotImplementedException();
        }

        public void SetSchoolYear(int schoolYear)
        {
            throw new System.NotImplementedException();
        }
    }
}