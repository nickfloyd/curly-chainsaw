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

export class ExternalGroupsGroupsInner {
    /**
    * The internal ID of the group
    */
    'groupId': number;
    /**
    * The display name of the group
    */
    'groupName': string;
    /**
    * The time of the last update for this group
    */
    'updatedAt': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "groupId",
            "baseName": "group_id",
            "type": "number"
        },
        {
            "name": "groupName",
            "baseName": "group_name",
            "type": "string"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return ExternalGroupsGroupsInner.attributeTypeMap;
    }
}
