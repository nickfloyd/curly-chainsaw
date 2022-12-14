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
import { AuthorizationApp } from './authorizationApp';
import { ScopedInstallation } from './scopedInstallation';
import { SimpleUser } from './simpleUser';

/**
* The authorization for an OAuth app, GitHub App, or a Personal Access Token.
*/
export class Authorization {
    'id': number;
    'url': string;
    /**
    * A list of scopes that this authorization is in.
    */
    'scopes': Array<string> | null;
    'token': string;
    'tokenLastEight': string | null;
    'hashedToken': string | null;
    'app': AuthorizationApp;
    'note': string | null;
    'noteUrl': string | null;
    'updatedAt': Date;
    'createdAt': Date;
    'fingerprint': string | null;
    'user'?: SimpleUser | null;
    'installation'?: ScopedInstallation | null;
    'expiresAt': Date | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "id",
            "baseName": "id",
            "type": "number"
        },
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "scopes",
            "baseName": "scopes",
            "type": "Array<string>"
        },
        {
            "name": "token",
            "baseName": "token",
            "type": "string"
        },
        {
            "name": "tokenLastEight",
            "baseName": "token_last_eight",
            "type": "string"
        },
        {
            "name": "hashedToken",
            "baseName": "hashed_token",
            "type": "string"
        },
        {
            "name": "app",
            "baseName": "app",
            "type": "AuthorizationApp"
        },
        {
            "name": "note",
            "baseName": "note",
            "type": "string"
        },
        {
            "name": "noteUrl",
            "baseName": "note_url",
            "type": "string"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "Date"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "Date"
        },
        {
            "name": "fingerprint",
            "baseName": "fingerprint",
            "type": "string"
        },
        {
            "name": "user",
            "baseName": "user",
            "type": "SimpleUser"
        },
        {
            "name": "installation",
            "baseName": "installation",
            "type": "ScopedInstallation"
        },
        {
            "name": "expiresAt",
            "baseName": "expires_at",
            "type": "Date"
        }    ];

    static getAttributeTypeMap() {
        return Authorization.attributeTypeMap;
    }
}

