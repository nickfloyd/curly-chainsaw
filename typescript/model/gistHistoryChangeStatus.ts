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

export class GistHistoryChangeStatus {
    'total'?: number;
    'additions'?: number;
    'deletions'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "total",
            "baseName": "total",
            "type": "number"
        },
        {
            "name": "additions",
            "baseName": "additions",
            "type": "number"
        },
        {
            "name": "deletions",
            "baseName": "deletions",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return GistHistoryChangeStatus.attributeTypeMap;
    }
}

