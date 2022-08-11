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
import { PublicUserPlan } from './publicUserPlan';

/**
* Private User
*/
export class PrivateUser {
    'login': string;
    'id': number;
    'nodeId': string;
    'avatarUrl': string;
    'gravatarId': string | null;
    'url': string;
    'htmlUrl': string;
    'followersUrl': string;
    'followingUrl': string;
    'gistsUrl': string;
    'starredUrl': string;
    'subscriptionsUrl': string;
    'organizationsUrl': string;
    'reposUrl': string;
    'eventsUrl': string;
    'receivedEventsUrl': string;
    'type': string;
    'siteAdmin': boolean;
    'name': string | null;
    'company': string | null;
    'blog': string | null;
    'location': string | null;
    'email': string | null;
    'hireable': boolean | null;
    'bio': string | null;
    'twitterUsername'?: string | null;
    'publicRepos': number;
    'publicGists': number;
    'followers': number;
    'following': number;
    'createdAt': Date;
    'updatedAt': Date;
    'privateGists': number;
    'totalPrivateRepos': number;
    'ownedPrivateRepos': number;
    'diskUsage': number;
    'collaborators': number;
    'twoFactorAuthentication': boolean;
    'plan'?: PublicUserPlan;
    'suspendedAt'?: Date | null;
    'businessPlus'?: boolean;
    'ldapDn'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "login",
            "baseName": "login",
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
            "name": "avatarUrl",
            "baseName": "avatar_url",
            "type": "string"
        },
        {
            "name": "gravatarId",
            "baseName": "gravatar_id",
            "type": "string"
        },
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "htmlUrl",
            "baseName": "html_url",
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
            "name": "organizationsUrl",
            "baseName": "organizations_url",
            "type": "string"
        },
        {
            "name": "reposUrl",
            "baseName": "repos_url",
            "type": "string"
        },
        {
            "name": "eventsUrl",
            "baseName": "events_url",
            "type": "string"
        },
        {
            "name": "receivedEventsUrl",
            "baseName": "received_events_url",
            "type": "string"
        },
        {
            "name": "type",
            "baseName": "type",
            "type": "string"
        },
        {
            "name": "siteAdmin",
            "baseName": "site_admin",
            "type": "boolean"
        },
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "company",
            "baseName": "company",
            "type": "string"
        },
        {
            "name": "blog",
            "baseName": "blog",
            "type": "string"
        },
        {
            "name": "location",
            "baseName": "location",
            "type": "string"
        },
        {
            "name": "email",
            "baseName": "email",
            "type": "string"
        },
        {
            "name": "hireable",
            "baseName": "hireable",
            "type": "boolean"
        },
        {
            "name": "bio",
            "baseName": "bio",
            "type": "string"
        },
        {
            "name": "twitterUsername",
            "baseName": "twitter_username",
            "type": "string"
        },
        {
            "name": "publicRepos",
            "baseName": "public_repos",
            "type": "number"
        },
        {
            "name": "publicGists",
            "baseName": "public_gists",
            "type": "number"
        },
        {
            "name": "followers",
            "baseName": "followers",
            "type": "number"
        },
        {
            "name": "following",
            "baseName": "following",
            "type": "number"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "Date"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "Date"
        },
        {
            "name": "privateGists",
            "baseName": "private_gists",
            "type": "number"
        },
        {
            "name": "totalPrivateRepos",
            "baseName": "total_private_repos",
            "type": "number"
        },
        {
            "name": "ownedPrivateRepos",
            "baseName": "owned_private_repos",
            "type": "number"
        },
        {
            "name": "diskUsage",
            "baseName": "disk_usage",
            "type": "number"
        },
        {
            "name": "collaborators",
            "baseName": "collaborators",
            "type": "number"
        },
        {
            "name": "twoFactorAuthentication",
            "baseName": "two_factor_authentication",
            "type": "boolean"
        },
        {
            "name": "plan",
            "baseName": "plan",
            "type": "PublicUserPlan"
        },
        {
            "name": "suspendedAt",
            "baseName": "suspended_at",
            "type": "Date"
        },
        {
            "name": "businessPlus",
            "baseName": "business_plus",
            "type": "boolean"
        },
        {
            "name": "ldapDn",
            "baseName": "ldap_dn",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return PrivateUser.attributeTypeMap;
    }
}

