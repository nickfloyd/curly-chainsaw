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

export class TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner {
    /**
    * ID of the IdP group.
    */
    'groupId': string;
    /**
    * Name of the IdP group.
    */
    'groupName': string;
    /**
    * Description of the IdP group.
    */
    'groupDescription': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "groupId",
            "baseName": "group_id",
            "type": "string"
        },
        {
            "name": "groupName",
            "baseName": "group_name",
            "type": "string"
        },
        {
            "name": "groupDescription",
            "baseName": "group_description",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner.attributeTypeMap;
    }
}

