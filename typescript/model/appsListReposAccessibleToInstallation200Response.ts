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
import { Repository } from './repository';

export class AppsListReposAccessibleToInstallation200Response {
    'totalCount': number;
    'repositories': Array<Repository>;
    'repositorySelection'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalCount",
            "baseName": "total_count",
            "type": "number"
        },
        {
            "name": "repositories",
            "baseName": "repositories",
            "type": "Array<Repository>"
        },
        {
            "name": "repositorySelection",
            "baseName": "repository_selection",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return AppsListReposAccessibleToInstallation200Response.attributeTypeMap;
    }
}

