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
import { AppPermissions } from './appPermissions';

export class AppsScopeTokenRequest {
    /**
    * The OAuth access token used to authenticate to the GitHub API.
    */
    'accessToken': string;
    /**
    * The name of the user or organization to scope the user-to-server access token to. **Required** unless `target_id` is specified.
    */
    'target'?: string;
    /**
    * The ID of the user or organization to scope the user-to-server access token to. **Required** unless `target` is specified.
    */
    'targetId'?: number;
    /**
    * The list of repository names to scope the user-to-server access token to. `repositories` may not be specified if `repository_ids` is specified.
    */
    'repositories'?: Array<string>;
    /**
    * The list of repository IDs to scope the user-to-server access token to. `repository_ids` may not be specified if `repositories` is specified.
    */
    'repositoryIds'?: Array<number>;
    'permissions'?: AppPermissions;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "accessToken",
            "baseName": "access_token",
            "type": "string"
        },
        {
            "name": "target",
            "baseName": "target",
            "type": "string"
        },
        {
            "name": "targetId",
            "baseName": "target_id",
            "type": "number"
        },
        {
            "name": "repositories",
            "baseName": "repositories",
            "type": "Array<string>"
        },
        {
            "name": "repositoryIds",
            "baseName": "repository_ids",
            "type": "Array<number>"
        },
        {
            "name": "permissions",
            "baseName": "permissions",
            "type": "AppPermissions"
        }    ];

    static getAttributeTypeMap() {
        return AppsScopeTokenRequest.attributeTypeMap;
    }
}
