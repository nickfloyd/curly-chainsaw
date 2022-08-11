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
import { GitHubApp1 } from './gitHubApp1';
import { SimpleUser1 } from './simpleUser1';
import { Team } from './team';

/**
* Review Requested Issue Event
*/
export class ReviewRequestedIssueEvent {
    'id': number;
    'nodeId': string;
    'url': string;
    'actor': SimpleUser1;
    'event': string;
    'commitId': string | null;
    'commitUrl': string | null;
    'createdAt': string;
    'performedViaGithubApp': GitHubApp1 | null;
    'reviewRequester': SimpleUser1;
    'requestedTeam'?: Team;
    'requestedReviewer'?: SimpleUser1;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "id",
            "baseName": "id",
            "type": "number"
        },
        {
            "name": "nodeId",
            "baseName": "node_id",
            "type": "string"
        },
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "actor",
            "baseName": "actor",
            "type": "SimpleUser1"
        },
        {
            "name": "event",
            "baseName": "event",
            "type": "string"
        },
        {
            "name": "commitId",
            "baseName": "commit_id",
            "type": "string"
        },
        {
            "name": "commitUrl",
            "baseName": "commit_url",
            "type": "string"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "string"
        },
        {
            "name": "performedViaGithubApp",
            "baseName": "performed_via_github_app",
            "type": "GitHubApp1"
        },
        {
            "name": "reviewRequester",
            "baseName": "review_requester",
            "type": "SimpleUser1"
        },
        {
            "name": "requestedTeam",
            "baseName": "requested_team",
            "type": "Team"
        },
        {
            "name": "requestedReviewer",
            "baseName": "requested_reviewer",
            "type": "SimpleUser1"
        }    ];

    static getAttributeTypeMap() {
        return ReviewRequestedIssueEvent.attributeTypeMap;
    }
}

