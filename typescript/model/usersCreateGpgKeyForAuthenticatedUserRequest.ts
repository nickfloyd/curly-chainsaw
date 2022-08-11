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

export class UsersCreateGpgKeyForAuthenticatedUserRequest {
    /**
    * A descriptive name for the new key.
    */
    'name'?: string;
    /**
    * A GPG key in ASCII-armored format.
    */
    'armoredPublicKey': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "armoredPublicKey",
            "baseName": "armored_public_key",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return UsersCreateGpgKeyForAuthenticatedUserRequest.attributeTypeMap;
    }
}

