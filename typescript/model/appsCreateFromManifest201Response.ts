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
import { AppsCreateFromManifest201ResponseAllOf } from './appsCreateFromManifest201ResponseAllOf';
import { GitHubApp } from './gitHubApp';
import { GitHubAppPermissions } from './gitHubAppPermissions';
import { SimpleUser } from './simpleUser';

export class AppsCreateFromManifest201Response {
    /**
    * Unique identifier of the GitHub app
    */
    'id': number;
    /**
    * The slug name of the GitHub app
    */
    'slug'?: string;
    'nodeId': string;
    'owner': SimpleUser | null;
    /**
    * The name of the GitHub app
    */
    'name': string;
    'description': string | null;
    'externalUrl': string;
    'htmlUrl': string;
    'createdAt': Date;
    'updatedAt': Date;
    'permissions': GitHubAppPermissions;
    /**
    * The list of events for the GitHub app
    */
    'events': Array<string>;
    /**
    * The number of installations associated with the GitHub app
    */
    'installationsCount'?: number;
    'clientId': string;
    'clientSecret': string;
    'webhookSecret': string | null;
    'pem': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "id",
            "baseName": "id",
            "type": "number"
        },
        {
            "name": "slug",
            "baseName": "slug",
            "type": "string"
        },
        {
            "name": "nodeId",
            "baseName": "node_id",
            "type": "string"
        },
        {
            "name": "owner",
            "baseName": "owner",
            "type": "SimpleUser"
        },
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "description",
            "baseName": "description",
            "type": "string"
        },
        {
            "name": "externalUrl",
            "baseName": "external_url",
            "type": "string"
        },
        {
            "name": "htmlUrl",
            "baseName": "html_url",
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
        },
        {
            "name": "permissions",
            "baseName": "permissions",
            "type": "GitHubAppPermissions"
        },
        {
            "name": "events",
            "baseName": "events",
            "type": "Array<string>"
        },
        {
            "name": "installationsCount",
            "baseName": "installations_count",
            "type": "number"
        },
        {
            "name": "clientId",
            "baseName": "client_id",
            "type": "string"
        },
        {
            "name": "clientSecret",
            "baseName": "client_secret",
            "type": "string"
        },
        {
            "name": "webhookSecret",
            "baseName": "webhook_secret",
            "type": "string"
        },
        {
            "name": "pem",
            "baseName": "pem",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return AppsCreateFromManifest201Response.attributeTypeMap;
    }
}

