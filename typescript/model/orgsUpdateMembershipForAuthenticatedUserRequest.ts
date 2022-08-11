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

export class OrgsUpdateMembershipForAuthenticatedUserRequest {
    /**
    * The state that the membership should be in. Only `\"active\"` will be accepted.
    */
    'state': OrgsUpdateMembershipForAuthenticatedUserRequest.StateEnum;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "state",
            "baseName": "state",
            "type": "OrgsUpdateMembershipForAuthenticatedUserRequest.StateEnum"
        }    ];

    static getAttributeTypeMap() {
        return OrgsUpdateMembershipForAuthenticatedUserRequest.attributeTypeMap;
    }
}

export namespace OrgsUpdateMembershipForAuthenticatedUserRequest {
    export enum StateEnum {
        Active = <any> 'active'
    }
}
