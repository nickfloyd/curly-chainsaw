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

export class EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest {
    /**
    * The policy that controls the organizations in the enterprise that are allowed to run GitHub Actions.
    */
    'enabledOrganizations': EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.EnabledOrganizationsEnum;
    /**
    * The permissions policy that controls the actions and reusable workflows that are allowed to run.
    */
    'allowedActions'?: EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.AllowedActionsEnum;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "enabledOrganizations",
            "baseName": "enabled_organizations",
            "type": "EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.EnabledOrganizationsEnum"
        },
        {
            "name": "allowedActions",
            "baseName": "allowed_actions",
            "type": "EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.AllowedActionsEnum"
        }    ];

    static getAttributeTypeMap() {
        return EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.attributeTypeMap;
    }
}

export namespace EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest {
    export enum EnabledOrganizationsEnum {
        All = <any> 'all',
        None = <any> 'none',
        Selected = <any> 'selected'
    }
    export enum AllowedActionsEnum {
        All = <any> 'all',
        LocalOnly = <any> 'local_only',
        Selected = <any> 'selected'
    }
}
