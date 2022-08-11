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

export class ProtectedBranchRequiredStatusCheckChecksInner {
    'context': string;
    'appId': number | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "context",
            "baseName": "context",
            "type": "string"
        },
        {
            "name": "appId",
            "baseName": "app_id",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return ProtectedBranchRequiredStatusCheckChecksInner.attributeTypeMap;
    }
}
