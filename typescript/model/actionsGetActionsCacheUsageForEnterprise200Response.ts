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

export class ActionsGetActionsCacheUsageForEnterprise200Response {
    /**
    * The count of active caches across all repositories of an enterprise or an organization.
    */
    'totalActiveCachesCount': number;
    /**
    * The total size in bytes of all active cache items across all repositories of an enterprise or an organization.
    */
    'totalActiveCachesSizeInBytes': number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalActiveCachesCount",
            "baseName": "total_active_caches_count",
            "type": "number"
        },
        {
            "name": "totalActiveCachesSizeInBytes",
            "baseName": "total_active_caches_size_in_bytes",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return ActionsGetActionsCacheUsageForEnterprise200Response.attributeTypeMap;
    }
}

