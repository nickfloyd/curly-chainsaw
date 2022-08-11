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

export class ReposCreateOrUpdateEnvironmentRequestReviewersInner {
    /**
    * The type of reviewer.
    */
    'type'?: ReposCreateOrUpdateEnvironmentRequestReviewersInner.TypeEnum;
    /**
    * The id of the user or team who can review the deployment
    */
    'id'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "type",
            "baseName": "type",
            "type": "ReposCreateOrUpdateEnvironmentRequestReviewersInner.TypeEnum"
        },
        {
            "name": "id",
            "baseName": "id",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return ReposCreateOrUpdateEnvironmentRequestReviewersInner.attributeTypeMap;
    }
}

export namespace ReposCreateOrUpdateEnvironmentRequestReviewersInner {
    export enum TypeEnum {
        User = <any> 'User',
        Team = <any> 'Team'
    }
}
