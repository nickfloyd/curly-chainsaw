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

export class ServerStatisticsProxyEndpointInnerGheStatsPages {
    'totalPages'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalPages",
            "baseName": "total_pages",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return ServerStatisticsProxyEndpointInnerGheStatsPages.attributeTypeMap;
    }
}

