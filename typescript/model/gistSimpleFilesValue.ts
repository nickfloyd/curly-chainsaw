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

export class GistSimpleFilesValue {
    'filename'?: string;
    'type'?: string;
    'language'?: string;
    'rawUrl'?: string;
    'size'?: number;
    'truncated'?: boolean;
    'content'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "filename",
            "baseName": "filename",
            "type": "string"
        },
        {
            "name": "type",
            "baseName": "type",
            "type": "string"
        },
        {
            "name": "language",
            "baseName": "language",
            "type": "string"
        },
        {
            "name": "rawUrl",
            "baseName": "raw_url",
            "type": "string"
        },
        {
            "name": "size",
            "baseName": "size",
            "type": "number"
        },
        {
            "name": "truncated",
            "baseName": "truncated",
            "type": "boolean"
        },
        {
            "name": "content",
            "baseName": "content",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return GistSimpleFilesValue.attributeTypeMap;
    }
}
