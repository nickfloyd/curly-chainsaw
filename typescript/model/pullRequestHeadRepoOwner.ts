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

export class PullRequestHeadRepoOwner {
    'avatarUrl': string;
    'eventsUrl': string;
    'followersUrl': string;
    'followingUrl': string;
    'gistsUrl': string;
    'gravatarId': string | null;
    'htmlUrl': string;
    'id': number;
    'nodeId': string;
    'login': string;
    'organizationsUrl': string;
    'receivedEventsUrl': string;
    'reposUrl': string;
    'siteAdmin': boolean;
    'starredUrl': string;
    'subscriptionsUrl': string;
    'type': string;
    'url': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "avatarUrl",
            "baseName": "avatar_url",
            "type": "string"
        },
        {
            "name": "eventsUrl",
            "baseName": "events_url",
            "type": "string"
        },
        {
            "name": "followersUrl",
            "baseName": "followers_url",
            "type": "string"
        },
        {
            "name": "followingUrl",
            "baseName": "following_url",
            "type": "string"
        },
        {
            "name": "gistsUrl",
            "baseName": "gists_url",
            "type": "string"
        },
        {
            "name": "gravatarId",
            "baseName": "gravatar_id",
            "type": "string"
        },
        {
            "name": "htmlUrl",
            "baseName": "html_url",
            "type": "string"
        },
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
            "name": "login",
            "baseName": "login",
            "type": "string"
        },
        {
            "name": "organizationsUrl",
            "baseName": "organizations_url",
            "type": "string"
        },
        {
            "name": "receivedEventsUrl",
            "baseName": "received_events_url",
            "type": "string"
        },
        {
            "name": "reposUrl",
            "baseName": "repos_url",
            "type": "string"
        },
        {
            "name": "siteAdmin",
            "baseName": "site_admin",
            "type": "boolean"
        },
        {
            "name": "starredUrl",
            "baseName": "starred_url",
            "type": "string"
        },
        {
            "name": "subscriptionsUrl",
            "baseName": "subscriptions_url",
            "type": "string"
        },
        {
            "name": "type",
            "baseName": "type",
            "type": "string"
        },
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return PullRequestHeadRepoOwner.attributeTypeMap;
    }
}

