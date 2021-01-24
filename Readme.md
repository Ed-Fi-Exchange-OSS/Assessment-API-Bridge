# Ed-Fi Assessment API Bridge

## Overview

The Ed-Fi Assessment API Bridge allows Assessment API clients to interact with it as though they are interacting with Ed-Fi ODS/API v2.5 or v2.6 and lands the data in Ed-Fi ODS/API v3.x.


## Installing Assessment API Bridge
See [Ed-Fi Assessment API Bridge Installer Documentation](Installer/docs/Ed-Fi_AssessmentAPIBridgeInstaller.md) for details on install/uninstall instructions.

## Verifying your Installation 
Once you have successfully installed Ed-Fi Assessment API Bridge, you can test the installation using the sample Postman collection provided in this repository.
* Download the sample [collection](V3%20Assessment%20Bridge.postman_collection.json) and [environment](Assessment%20Bridge%20(api.ed-fi.org%20v3%20API).postman_environment.json).
* Import the downloaded files to your [Postman](https://www.getpostman.com/downloads/) App.
* In Postman, update the environment to connect to your deployed Assessment API Bridge.  
  * ```ApiRootV25``` should be set to the root URL of the deployed Assessment API Bridge.
  * The provided values for the ```Key``` and the ```Secret``` are for the [Ed-Fi ODS / API public sandbox](https://api.ed-fi.org/v3.2.0/api/). You may need to update them if your Assessment API Bridge is configured for a different ```upstreamEdFiApiUrl```. See [Ed-Fi Assessment API Bridge configuration](Installer/install-config.json).
* In Postman, set the above environment as the active environment and run the Postman collection. 

## Known Issues
Student ID to Identification Code Translation feature of [Ed-Fi ODS / API v2.6](https://techdocs.ed-fi.org/display/ODSAPI26/What%27s+New+in+v2.6) is not supported by the Assessment API Bridge.

## Support

The Alliance welcomes feedback on improvements or changes for Assessment API Bridge. Feedback is best shared by raising a ticket on the Ed-Fi Tracker [Ed-Fi Alliance Project](https://tracker.ed-fi.org/projects/EDFI) using component ```Assessment Bridge```.

## Contributing

Community contributions to this application will keep it healthy and active.  We strongly welcome pull requests with new feature enhancements and bug fixes.


## Legal Information

Copyright (c) 2020 Ed-Fi Alliance, LLC and contributors.

Licensed under the [Apache License, Version 2.0](LICENSE) (the "License").

Unless required by applicable law or agreed to in writing, software distributed
under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
CONDITIONS OF ANY KIND, either express or implied. See the License for the
specific language governing permissions and limitations under the License.

See [NOTICES](NOTICES.md) for additional copyright and license notifications.
