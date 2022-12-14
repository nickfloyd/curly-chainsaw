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
* Scim Error
*/
export class ScimError {
    'message'?: string | null;
    'documentationUrl'?: string | null;
    'detail'?: string | null;
    'status'?: number;
    'scimType'?: string | null;
    'schemas'?: Array<string>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "message",
            "baseName": "message",
            "type": "string"
        },
        {
            "name": "documentationUrl",
            "baseName": "documentation_url",
            "type": "string"
        },
        {
            "name": "detail",
            "baseName": "detail",
            "type": "string"
        },
        {
            "name": "status",
            "baseName": "status",
            "type": "number"
        },
        {
            "name": "scimType",
            "baseName": "scimType",
            "type": "string"
        },
        {
            "name": "schemas",
            "baseName": "schemas",
            "type": "Array<string>"
        }    ];

    static getAttributeTypeMap() {
        return ScimError.attributeTypeMap;
    }
}

