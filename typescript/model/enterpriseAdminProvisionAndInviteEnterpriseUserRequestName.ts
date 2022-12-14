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

export class EnterpriseAdminProvisionAndInviteEnterpriseUserRequestName {
    /**
    * The first name of the user.
    */
    'givenName': string;
    /**
    * The last name of the user.
    */
    'familyName': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "givenName",
            "baseName": "givenName",
            "type": "string"
        },
        {
            "name": "familyName",
            "baseName": "familyName",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return EnterpriseAdminProvisionAndInviteEnterpriseUserRequestName.attributeTypeMap;
    }
}

