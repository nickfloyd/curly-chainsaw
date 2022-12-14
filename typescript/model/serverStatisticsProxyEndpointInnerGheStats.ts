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
import { ServerStatisticsProxyEndpointInnerGheStatsComments } from './serverStatisticsProxyEndpointInnerGheStatsComments';
import { ServerStatisticsProxyEndpointInnerGheStatsGists } from './serverStatisticsProxyEndpointInnerGheStatsGists';
import { ServerStatisticsProxyEndpointInnerGheStatsHooks } from './serverStatisticsProxyEndpointInnerGheStatsHooks';
import { ServerStatisticsProxyEndpointInnerGheStatsIssues } from './serverStatisticsProxyEndpointInnerGheStatsIssues';
import { ServerStatisticsProxyEndpointInnerGheStatsMilestones } from './serverStatisticsProxyEndpointInnerGheStatsMilestones';
import { ServerStatisticsProxyEndpointInnerGheStatsOrgs } from './serverStatisticsProxyEndpointInnerGheStatsOrgs';
import { ServerStatisticsProxyEndpointInnerGheStatsPages } from './serverStatisticsProxyEndpointInnerGheStatsPages';
import { ServerStatisticsProxyEndpointInnerGheStatsPulls } from './serverStatisticsProxyEndpointInnerGheStatsPulls';
import { ServerStatisticsProxyEndpointInnerGheStatsRepos } from './serverStatisticsProxyEndpointInnerGheStatsRepos';
import { ServerStatisticsProxyEndpointInnerGheStatsUsers } from './serverStatisticsProxyEndpointInnerGheStatsUsers';

export class ServerStatisticsProxyEndpointInnerGheStats {
    'comments'?: ServerStatisticsProxyEndpointInnerGheStatsComments;
    'gists'?: ServerStatisticsProxyEndpointInnerGheStatsGists;
    'hooks'?: ServerStatisticsProxyEndpointInnerGheStatsHooks;
    'issues'?: ServerStatisticsProxyEndpointInnerGheStatsIssues;
    'milestones'?: ServerStatisticsProxyEndpointInnerGheStatsMilestones;
    'orgs'?: ServerStatisticsProxyEndpointInnerGheStatsOrgs;
    'pages'?: ServerStatisticsProxyEndpointInnerGheStatsPages;
    'pulls'?: ServerStatisticsProxyEndpointInnerGheStatsPulls;
    'repos'?: ServerStatisticsProxyEndpointInnerGheStatsRepos;
    'users'?: ServerStatisticsProxyEndpointInnerGheStatsUsers;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "comments",
            "baseName": "comments",
            "type": "ServerStatisticsProxyEndpointInnerGheStatsComments"
        },
        {
            "name": "gists",
            "baseName": "gists",
            "type": "ServerStatisticsProxyEndpointInnerGheStatsGists"
        },
        {
            "name": "hooks",
            "baseName": "hooks",
            "type": "ServerStatisticsProxyEndpointInnerGheStatsHooks"
        },
        {
            "name": "issues",
            "baseName": "issues",
            "type": "ServerStatisticsProxyEndpointInnerGheStatsIssues"
        },
        {
            "name": "milestones",
            "baseName": "milestones",
            "type": "ServerStatisticsProxyEndpointInnerGheStatsMilestones"
        },
        {
            "name": "orgs",
            "baseName": "orgs",
            "type": "ServerStatisticsProxyEndpointInnerGheStatsOrgs"
        },
        {
            "name": "pages",
            "baseName": "pages",
            "type": "ServerStatisticsProxyEndpointInnerGheStatsPages"
        },
        {
            "name": "pulls",
            "baseName": "pulls",
            "type": "ServerStatisticsProxyEndpointInnerGheStatsPulls"
        },
        {
            "name": "repos",
            "baseName": "repos",
            "type": "ServerStatisticsProxyEndpointInnerGheStatsRepos"
        },
        {
            "name": "users",
            "baseName": "users",
            "type": "ServerStatisticsProxyEndpointInnerGheStatsUsers"
        }    ];

    static getAttributeTypeMap() {
        return ServerStatisticsProxyEndpointInnerGheStats.attributeTypeMap;
    }
}

