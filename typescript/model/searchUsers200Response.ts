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
import { UserSearchResultItem } from './userSearchResultItem';

export class SearchUsers200Response {
    'totalCount': number;
    'incompleteResults': boolean;
    'items': Array<UserSearchResultItem>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalCount",
            "baseName": "total_count",
            "type": "number"
        },
        {
            "name": "incompleteResults",
            "baseName": "incomplete_results",
            "type": "boolean"
        },
        {
            "name": "items",
            "baseName": "items",
            "type": "Array<UserSearchResultItem>"
        }    ];

    static getAttributeTypeMap() {
        return SearchUsers200Response.attributeTypeMap;
    }
}

