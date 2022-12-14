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

export class EnterpriseAdminProvisionAndInviteEnterpriseUser201ResponseEmailsInner {
    'value'?: string;
    'type'?: string;
    'primary'?: boolean;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "value",
            "baseName": "value",
            "type": "string"
        },
        {
            "name": "type",
            "baseName": "type",
            "type": "string"
        },
        {
            "name": "primary",
            "baseName": "primary",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return EnterpriseAdminProvisionAndInviteEnterpriseUser201ResponseEmailsInner.attributeTypeMap;
    }
}

