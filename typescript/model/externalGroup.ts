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
import { ExternalGroupMembersInner } from './externalGroupMembersInner';
import { ExternalGroupTeamsInner } from './externalGroupTeamsInner';

/**
* Information about an external group\'s usage and its members
*/
export class ExternalGroup {
    /**
    * The internal ID of the group
    */
    'groupId': number;
    /**
    * The display name for the group
    */
    'groupName': string;
    /**
    * The date when the group was last updated_at
    */
    'updatedAt'?: string;
    /**
    * An array of teams linked to this group
    */
    'teams': Array<ExternalGroupTeamsInner>;
    /**
    * An array of external members linked to this group
    */
    'members': Array<ExternalGroupMembersInner>;

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
        },
        {
            "name": "teams",
            "baseName": "teams",
            "type": "Array<ExternalGroupTeamsInner>"
        },
        {
            "name": "members",
            "baseName": "members",
            "type": "Array<ExternalGroupMembersInner>"
        }    ];

    static getAttributeTypeMap() {
        return ExternalGroup.attributeTypeMap;
    }
}

