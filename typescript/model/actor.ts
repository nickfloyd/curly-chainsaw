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
* Actor
*/
export class Actor {
    'id': number;
    'login': string;
    'displayLogin'?: string;
    'gravatarId': string | null;
    'url': string;
    'avatarUrl': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "id",
            "baseName": "id",
            "type": "number"
        },
        {
            "name": "login",
            "baseName": "login",
            "type": "string"
        },
        {
            "name": "displayLogin",
            "baseName": "display_login",
            "type": "string"
        },
        {
            "name": "gravatarId",
            "baseName": "gravatar_id",
            "type": "string"
        },
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "avatarUrl",
            "baseName": "avatar_url",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return Actor.attributeTypeMap;
    }
}

