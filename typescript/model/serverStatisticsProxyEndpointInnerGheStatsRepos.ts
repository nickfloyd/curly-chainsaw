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

export class ServerStatisticsProxyEndpointInnerGheStatsRepos {
    'totalRepos'?: number;
    'rootRepos'?: number;
    'forkRepos'?: number;
    'orgRepos'?: number;
    'totalPushes'?: number;
    'totalWikis'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalRepos",
            "baseName": "total_repos",
            "type": "number"
        },
        {
            "name": "rootRepos",
            "baseName": "root_repos",
            "type": "number"
        },
        {
            "name": "forkRepos",
            "baseName": "fork_repos",
            "type": "number"
        },
        {
            "name": "orgRepos",
            "baseName": "org_repos",
            "type": "number"
        },
        {
            "name": "totalPushes",
            "baseName": "total_pushes",
            "type": "number"
        },
        {
            "name": "totalWikis",
            "baseName": "total_wikis",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return ServerStatisticsProxyEndpointInnerGheStatsRepos.attributeTypeMap;
    }
}
