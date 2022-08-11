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

export class ServerStatisticsProxyEndpointInnerGheStatsUsers {
    'totalUsers'?: number;
    'adminUsers'?: number;
    'suspendedUsers'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalUsers",
            "baseName": "total_users",
            "type": "number"
        },
        {
            "name": "adminUsers",
            "baseName": "admin_users",
            "type": "number"
        },
        {
            "name": "suspendedUsers",
            "baseName": "suspended_users",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return ServerStatisticsProxyEndpointInnerGheStatsUsers.attributeTypeMap;
    }
}
