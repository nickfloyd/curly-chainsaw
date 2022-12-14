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

export class TeamsAddOrUpdateRepoPermissionsInOrgRequest {
    /**
    * The permission to grant the team on this repository. In addition to the enumerated values, you can also specify a custom repository role name, if the owning organization has defined any. If no permission is specified, the team\'s `permission` attribute will be used to determine what permission to grant the team on this repository.
    */
    'permission'?: TeamsAddOrUpdateRepoPermissionsInOrgRequest.PermissionEnum = TeamsAddOrUpdateRepoPermissionsInOrgRequest.PermissionEnum.Push;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "permission",
            "baseName": "permission",
            "type": "TeamsAddOrUpdateRepoPermissionsInOrgRequest.PermissionEnum"
        }    ];

    static getAttributeTypeMap() {
        return TeamsAddOrUpdateRepoPermissionsInOrgRequest.attributeTypeMap;
    }
}

export namespace TeamsAddOrUpdateRepoPermissionsInOrgRequest {
    export enum PermissionEnum {
        Pull = <any> 'pull',
        Push = <any> 'push',
        Admin = <any> 'admin',
        Maintain = <any> 'maintain',
        Triage = <any> 'triage'
    }
}
