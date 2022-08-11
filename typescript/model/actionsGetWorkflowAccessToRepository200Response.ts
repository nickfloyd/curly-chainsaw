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

export class ActionsGetWorkflowAccessToRepository200Response {
    /**
    * Defines the level of access that workflows outside of the repository have to actions and reusable workflows within the repository. `none` means access is only possible from workflows in this repository.
    */
    'accessLevel': ActionsGetWorkflowAccessToRepository200Response.AccessLevelEnum;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "accessLevel",
            "baseName": "access_level",
            "type": "ActionsGetWorkflowAccessToRepository200Response.AccessLevelEnum"
        }    ];

    static getAttributeTypeMap() {
        return ActionsGetWorkflowAccessToRepository200Response.attributeTypeMap;
    }
}

export namespace ActionsGetWorkflowAccessToRepository200Response {
    export enum AccessLevelEnum {
        None = <any> 'none',
        User = <any> 'user',
        Organization = <any> 'organization',
        Enterprise = <any> 'enterprise'
    }
}