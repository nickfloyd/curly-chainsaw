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
import { CodespacesSecret1 } from './codespacesSecret1';

export class CodespacesListSecretsForAuthenticatedUser200Response {
    'totalCount': number;
    'secrets': Array<CodespacesSecret1>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalCount",
            "baseName": "total_count",
            "type": "number"
        },
        {
            "name": "secrets",
            "baseName": "secrets",
            "type": "Array<CodespacesSecret1>"
        }    ];

    static getAttributeTypeMap() {
        return CodespacesListSecretsForAuthenticatedUser200Response.attributeTypeMap;
    }
}

