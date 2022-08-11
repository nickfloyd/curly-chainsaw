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

export class GPGKeySubkeysInner {
    'id'?: number;
    'primaryKeyId'?: number;
    'keyId'?: string;
    'publicKey'?: string;
    'emails'?: Array<any>;
    'subkeys'?: Array<any>;
    'canSign'?: boolean;
    'canEncryptComms'?: boolean;
    'canEncryptStorage'?: boolean;
    'canCertify'?: boolean;
    'createdAt'?: string;
    'expiresAt'?: string | null;
    'rawKey'?: string | null;
    'revoked'?: boolean;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "id",
            "baseName": "id",
            "type": "number"
        },
        {
            "name": "primaryKeyId",
            "baseName": "primary_key_id",
            "type": "number"
        },
        {
            "name": "keyId",
            "baseName": "key_id",
            "type": "string"
        },
        {
            "name": "publicKey",
            "baseName": "public_key",
            "type": "string"
        },
        {
            "name": "emails",
            "baseName": "emails",
            "type": "Array<any>"
        },
        {
            "name": "subkeys",
            "baseName": "subkeys",
            "type": "Array<any>"
        },
        {
            "name": "canSign",
            "baseName": "can_sign",
            "type": "boolean"
        },
        {
            "name": "canEncryptComms",
            "baseName": "can_encrypt_comms",
            "type": "boolean"
        },
        {
            "name": "canEncryptStorage",
            "baseName": "can_encrypt_storage",
            "type": "boolean"
        },
        {
            "name": "canCertify",
            "baseName": "can_certify",
            "type": "boolean"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "string"
        },
        {
            "name": "expiresAt",
            "baseName": "expires_at",
            "type": "string"
        },
        {
            "name": "rawKey",
            "baseName": "raw_key",
            "type": "string"
        },
        {
            "name": "revoked",
            "baseName": "revoked",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return GPGKeySubkeysInner.attributeTypeMap;
    }
}

