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

export class ServerStatisticsProxyEndpointInnerGheStatsPulls {
    'totalPulls'?: number;
    'mergedPulls'?: number;
    'mergeablePulls'?: number;
    'unmergeablePulls'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalPulls",
            "baseName": "total_pulls",
            "type": "number"
        },
        {
            "name": "mergedPulls",
            "baseName": "merged_pulls",
            "type": "number"
        },
        {
            "name": "mergeablePulls",
            "baseName": "mergeable_pulls",
            "type": "number"
        },
        {
            "name": "unmergeablePulls",
            "baseName": "unmergeable_pulls",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return ServerStatisticsProxyEndpointInnerGheStatsPulls.attributeTypeMap;
    }
}

