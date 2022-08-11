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
import { TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner } from './teamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner';

export class TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest {
    /**
    * The IdP groups you want to connect to a GitHub team. When updating, the new `groups` object will replace the original one. You must include any existing groups that you don\'t want to remove.
    */
    'groups'?: Array<TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "groups",
            "baseName": "groups",
            "type": "Array<TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequestGroupsInner>"
        }    ];

    static getAttributeTypeMap() {
        return TeamsCreateOrUpdateIdpGroupConnectionsInOrgRequest.attributeTypeMap;
    }
}
