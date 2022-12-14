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
import { Enterprise } from './enterprise';
import { SimpleUser1 } from './simpleUser1';

export class InstallationAccount {
    /**
    * The name of the enterprise.
    */
    'name': string;
    'email'?: string | null;
    'login': string;
    /**
    * Unique identifier of the enterprise
    */
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
    'starredAt'?: string;
    /**
    * A short description of the enterprise.
    */
    'description'?: string | null;
    /**
    * The enterprise\'s website URL.
    */
    'websiteUrl'?: string | null;
    /**
    * The slug url identifier for the enterprise.
    */
    'slug': string;
    'createdAt': Date | null;
    'updatedAt': Date | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "email",
            "baseName": "email",
            "type": "string"
        },
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
            "name": "starredAt",
            "baseName": "starred_at",
            "type": "string"
        },
        {
            "name": "description",
            "baseName": "description",
            "type": "string"
        },
        {
            "name": "websiteUrl",
            "baseName": "website_url",
            "type": "string"
        },
        {
            "name": "slug",
            "baseName": "slug",
            "type": "string"
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
        }    ];

    static getAttributeTypeMap() {
        return InstallationAccount.attributeTypeMap;
    }
}

