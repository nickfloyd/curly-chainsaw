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

export class ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest {
    /**
    * List of repository IDs that can access the runner group.
    */
    'selectedRepositoryIds': Array<number>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "selectedRepositoryIds",
            "baseName": "selected_repository_ids",
            "type": "Array<number>"
        }    ];

    static getAttributeTypeMap() {
        return ActionsSetRepoAccessToSelfHostedRunnerGroupInOrgRequest.attributeTypeMap;
    }
}
