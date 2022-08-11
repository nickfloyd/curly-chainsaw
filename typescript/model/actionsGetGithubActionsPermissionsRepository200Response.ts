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

export class ActionsGetGithubActionsPermissionsRepository200Response {
    /**
    * Whether GitHub Actions is enabled on the repository.
    */
    'enabled': boolean;
    /**
    * The permissions policy that controls the actions and reusable workflows that are allowed to run.
    */
    'allowedActions'?: ActionsGetGithubActionsPermissionsRepository200Response.AllowedActionsEnum;
    /**
    * The API URL to use to get or set the actions and reusable workflows that are allowed to run, when `allowed_actions` is set to `selected`.
    */
    'selectedActionsUrl'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "enabled",
            "baseName": "enabled",
            "type": "boolean"
        },
        {
            "name": "allowedActions",
            "baseName": "allowed_actions",
            "type": "ActionsGetGithubActionsPermissionsRepository200Response.AllowedActionsEnum"
        },
        {
            "name": "selectedActionsUrl",
            "baseName": "selected_actions_url",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return ActionsGetGithubActionsPermissionsRepository200Response.attributeTypeMap;
    }
}

export namespace ActionsGetGithubActionsPermissionsRepository200Response {
    export enum AllowedActionsEnum {
        All = <any> 'all',
        LocalOnly = <any> 'local_only',
        Selected = <any> 'selected'
    }
}