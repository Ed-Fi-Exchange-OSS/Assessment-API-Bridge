# How To: Update Generated Artifacts for the Assessment API Bridge
The Ed-Fi ODS API uses code generation heavily for producing artifacts needed to implement the API for the Ed-Fi Standard (and extensions). The Assessment API Bridge makes use of a subset of these artifacts from the Ed-Fi ODS API v2.5 and v3.1 branches. 

However, when these artifacts (which were never designed to co-exist over multiple versions) are combined into a single AppDomain, namespace collisions and incompatibilities occur with the generated code.

The following Search/Replace operations must be performed (within Visual Studio using the "Replace in Files" feature) in order to enable the solution to compile.

## Assembly: EdFi.Ods.AssessmentBridge.Models.V3: (API v3.1)

|File:   | EntityMapper.generated.cs                               |
| ------ | ------------------------------------------------------- |
|Search: | (namespace EdFi\.Ods\.Entities\.Common)\.(EdFi //\.\w+) |
|Replace:| $1.V3.$2                                                |
|Options:| Regex                                                   |

|File:   | EntityInterfaces.generated.cs              |
|--------| ------------------------------------------ |
|Search: | namespace EdFi.Ods.Entities.Common.EdFi    |
|Replace:| namespace EdFi.Ods.Entities.Common.V3.EdFi |

|File:    |Resources.generated.cs  |
|---------|------------------------|
|Search:  |Entities.Common.EdFi    |
|Replace: |Entities.Common.V3.EdFi |

|File:    |Resources.generated.cs                     |
|---------|-------------------------------------------|
|Search:  |namespace EdFi.Ods.Api.Models.Resources.   |
|Replace: |namespace EdFi.Ods.Api.Models.Resources.V3.|

## Assembly: EdFi.Ods.AssessmentBridge.Models.V2: (API v2.5)

|File:    |Resources.generated.cs                    |
|---------|------------------------------------------|
|Search:  |namespace EdFi.Ods.Api.Models.Resources   |
|Replace: |namespace EdFi.Ods.Api.Models.Resources.V2|

|File:    |Requests.generated.cs            |
|---------|---------------------------------|
|Search:  |EdFi.Ods.Api.Models.Resources.   |
|Replace: |EdFi.Ods.Api.Models.Resources.V2.|

## Assembly: EdFi.Ods.AssessmentBridge.WebApi (API v2.5 Controllers)

|File:    |Controllers.generated.cs         |
|---------|---------------------------------|
|Search:  |EdFi.Ods.Api.Models.Resources.   |
|Replace: |EdFi.Ods.Api.Models.Resources.V2.|
