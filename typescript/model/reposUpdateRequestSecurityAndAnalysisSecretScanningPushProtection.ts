/**
 * GitHub v3 REST API
 * GitHub\'s v3 REST API.
 *
 * The version of the OpenAPI document: 1.1.4
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { RequestFile } from './models';

/**
* Use the `status` property to enable or disable secret scanning push protection for this repository. For more information, see \"[Protecting pushes with secret scanning](/code-security/secret-scanning/protecting-pushes-with-secret-scanning).\"
*/
export class ReposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection {
    /**
    * Can be `enabled` or `disabled`.
    */
    'status'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "status",
            "baseName": "status",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return ReposUpdateRequestSecurityAndAnalysisSecretScanningPushProtection.attributeTypeMap;
    }
}
