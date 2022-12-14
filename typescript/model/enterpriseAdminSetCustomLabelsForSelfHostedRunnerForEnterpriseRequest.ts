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

export class EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest {
    /**
    * The names of the custom labels to set for the runner. You can pass an empty array to remove all custom labels.
    */
    'labels': Array<string>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "labels",
            "baseName": "labels",
            "type": "Array<string>"
        }    ];

    static getAttributeTypeMap() {
        return EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest.attributeTypeMap;
    }
}

