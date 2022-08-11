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

/**
* The public key used for setting Dependabot Secrets.
*/
export class DependabotPublicKey {
    /**
    * The identifier for the key.
    */
    'keyId': string;
    /**
    * The Base64 encoded public key.
    */
    'key': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "keyId",
            "baseName": "key_id",
            "type": "string"
        },
        {
            "name": "key",
            "baseName": "key",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return DependabotPublicKey.attributeTypeMap;
    }
}
