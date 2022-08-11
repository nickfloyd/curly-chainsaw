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

export class CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest {
    /**
    * Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get the public key for the authenticated user](https://docs.github.com/rest/reference/codespaces#get-the-public-key-for-the-authenticated-user) endpoint.
    */
    'encryptedValue'?: string;
    /**
    * ID of the key you used to encrypt the secret.
    */
    'keyId': string;
    /**
    * An array of repository ids that can access the user secret. You can manage the list of selected repositories using the [List selected repositories for a user secret](https://docs.github.com/rest/reference/codespaces#list-selected-repositories-for-a-user-secret), [Set selected repositories for a user secret](https://docs.github.com/rest/reference/codespaces#set-selected-repositories-for-a-user-secret), and [Remove a selected repository from a user secret](https://docs.github.com/rest/reference/codespaces#remove-a-selected-repository-from-a-user-secret) endpoints.
    */
    'selectedRepositoryIds'?: Array<string>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "encryptedValue",
            "baseName": "encrypted_value",
            "type": "string"
        },
        {
            "name": "keyId",
            "baseName": "key_id",
            "type": "string"
        },
        {
            "name": "selectedRepositoryIds",
            "baseName": "selected_repository_ids",
            "type": "Array<string>"
        }    ];

    static getAttributeTypeMap() {
        return CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest.attributeTypeMap;
    }
}
