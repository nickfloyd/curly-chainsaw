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

export class ServerStatisticsProxyEndpointInnerGheStatsComments {
    'totalCommitComments'?: number;
    'totalGistComments'?: number;
    'totalIssueComments'?: number;
    'totalPullRequestComments'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalCommitComments",
            "baseName": "total_commit_comments",
            "type": "number"
        },
        {
            "name": "totalGistComments",
            "baseName": "total_gist_comments",
            "type": "number"
        },
        {
            "name": "totalIssueComments",
            "baseName": "total_issue_comments",
            "type": "number"
        },
        {
            "name": "totalPullRequestComments",
            "baseName": "total_pull_request_comments",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return ServerStatisticsProxyEndpointInnerGheStatsComments.attributeTypeMap;
    }
}
