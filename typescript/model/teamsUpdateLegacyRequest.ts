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

export class TeamsUpdateLegacyRequest {
    /**
    * The name of the team.
    */
    'name': string;
    /**
    * The description of the team.
    */
    'description'?: string;
    /**
    * The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. The options are:   **For a non-nested team:**   \\* `secret` - only visible to organization owners and members of this team.   \\* `closed` - visible to all members of this organization.   **For a parent or child team:**   \\* `closed` - visible to all members of this organization.
    */
    'privacy'?: TeamsUpdateLegacyRequest.PrivacyEnum;
    /**
    * **Deprecated**. The permission that new repositories will be added to the team with when none is specified.
    */
    'permission'?: TeamsUpdateLegacyRequest.PermissionEnum = TeamsUpdateLegacyRequest.PermissionEnum.Pull;
    /**
    * The ID of a team to set as the parent team.
    */
    'parentTeamId'?: number | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "description",
            "baseName": "description",
            "type": "string"
        },
        {
            "name": "privacy",
            "baseName": "privacy",
            "type": "TeamsUpdateLegacyRequest.PrivacyEnum"
        },
        {
            "name": "permission",
            "baseName": "permission",
            "type": "TeamsUpdateLegacyRequest.PermissionEnum"
        },
        {
            "name": "parentTeamId",
            "baseName": "parent_team_id",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return TeamsUpdateLegacyRequest.attributeTypeMap;
    }
}

export namespace TeamsUpdateLegacyRequest {
    export enum PrivacyEnum {
        Secret = <any> 'secret',
        Closed = <any> 'closed'
    }
    export enum PermissionEnum {
        Pull = <any> 'pull',
        Push = <any> 'push',
        Admin = <any> 'admin'
    }
}
