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
import { EnterpriseAdminGetAuditLog200ResponseInnerActorLocation } from './enterpriseAdminGetAuditLog200ResponseInnerActorLocation';

export class EnterpriseAdminGetAuditLog200ResponseInner {
    /**
    * The time the audit log event occurred, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time).
    */
    'timestamp'?: number;
    /**
    * The name of the action that was performed, for example `user.login` or `repo.create`.
    */
    'action'?: string;
    'active'?: boolean;
    'activeWas'?: boolean;
    /**
    * The actor who performed the action.
    */
    'actor'?: string;
    /**
    * The id of the actor who performed the action.
    */
    'actorId'?: number;
    'actorLocation'?: EnterpriseAdminGetAuditLog200ResponseInnerActorLocation;
    'data'?: { [key: string]: any; };
    'orgId'?: number;
    /**
    * The username of the account being blocked.
    */
    'blockedUser'?: string;
    'business'?: string;
    'config'?: Array<object>;
    'configWas'?: Array<object>;
    'contentType'?: string;
    /**
    * The time the audit log event was recorded, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time).
    */
    'createdAt'?: number;
    'deployKeyFingerprint'?: string;
    /**
    * A unique identifier for an audit event.
    */
    'documentId'?: string;
    'emoji'?: string;
    'events'?: Array<object>;
    'eventsWere'?: Array<object>;
    'explanation'?: string;
    'fingerprint'?: string;
    'hookId'?: number;
    'limitedAvailability'?: boolean;
    'message'?: string;
    'name'?: string;
    'oldUser'?: string;
    'opensshPublicKey'?: string;
    'org'?: string;
    'previousVisibility'?: string;
    'readOnly'?: boolean;
    /**
    * The name of the repository.
    */
    'repo'?: string;
    /**
    * The name of the repository.
    */
    'repository'?: string;
    'repositoryPublic'?: boolean;
    'targetLogin'?: string;
    'team'?: string;
    /**
    * The type of protocol (for example, HTTP or SSH) used to transfer Git data.
    */
    'transportProtocol'?: number;
    /**
    * A human readable name for the protocol (for example, HTTP or SSH) used to transfer Git data.
    */
    'transportProtocolName'?: string;
    /**
    * The user that was affected by the action performed (if available).
    */
    'user'?: string;
    /**
    * The repository visibility, for example `public` or `private`.
    */
    'visibility'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "timestamp",
            "baseName": "@timestamp",
            "type": "number"
        },
        {
            "name": "action",
            "baseName": "action",
            "type": "string"
        },
        {
            "name": "active",
            "baseName": "active",
            "type": "boolean"
        },
        {
            "name": "activeWas",
            "baseName": "active_was",
            "type": "boolean"
        },
        {
            "name": "actor",
            "baseName": "actor",
            "type": "string"
        },
        {
            "name": "actorId",
            "baseName": "actor_id",
            "type": "number"
        },
        {
            "name": "actorLocation",
            "baseName": "actor_location",
            "type": "EnterpriseAdminGetAuditLog200ResponseInnerActorLocation"
        },
        {
            "name": "data",
            "baseName": "data",
            "type": "{ [key: string]: any; }"
        },
        {
            "name": "orgId",
            "baseName": "org_id",
            "type": "number"
        },
        {
            "name": "blockedUser",
            "baseName": "blocked_user",
            "type": "string"
        },
        {
            "name": "business",
            "baseName": "business",
            "type": "string"
        },
        {
            "name": "config",
            "baseName": "config",
            "type": "Array<object>"
        },
        {
            "name": "configWas",
            "baseName": "config_was",
            "type": "Array<object>"
        },
        {
            "name": "contentType",
            "baseName": "content_type",
            "type": "string"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "number"
        },
        {
            "name": "deployKeyFingerprint",
            "baseName": "deploy_key_fingerprint",
            "type": "string"
        },
        {
            "name": "documentId",
            "baseName": "_document_id",
            "type": "string"
        },
        {
            "name": "emoji",
            "baseName": "emoji",
            "type": "string"
        },
        {
            "name": "events",
            "baseName": "events",
            "type": "Array<object>"
        },
        {
            "name": "eventsWere",
            "baseName": "events_were",
            "type": "Array<object>"
        },
        {
            "name": "explanation",
            "baseName": "explanation",
            "type": "string"
        },
        {
            "name": "fingerprint",
            "baseName": "fingerprint",
            "type": "string"
        },
        {
            "name": "hookId",
            "baseName": "hook_id",
            "type": "number"
        },
        {
            "name": "limitedAvailability",
            "baseName": "limited_availability",
            "type": "boolean"
        },
        {
            "name": "message",
            "baseName": "message",
            "type": "string"
        },
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "oldUser",
            "baseName": "old_user",
            "type": "string"
        },
        {
            "name": "opensshPublicKey",
            "baseName": "openssh_public_key",
            "type": "string"
        },
        {
            "name": "org",
            "baseName": "org",
            "type": "string"
        },
        {
            "name": "previousVisibility",
            "baseName": "previous_visibility",
            "type": "string"
        },
        {
            "name": "readOnly",
            "baseName": "read_only",
            "type": "boolean"
        },
        {
            "name": "repo",
            "baseName": "repo",
            "type": "string"
        },
        {
            "name": "repository",
            "baseName": "repository",
            "type": "string"
        },
        {
            "name": "repositoryPublic",
            "baseName": "repository_public",
            "type": "boolean"
        },
        {
            "name": "targetLogin",
            "baseName": "target_login",
            "type": "string"
        },
        {
            "name": "team",
            "baseName": "team",
            "type": "string"
        },
        {
            "name": "transportProtocol",
            "baseName": "transport_protocol",
            "type": "number"
        },
        {
            "name": "transportProtocolName",
            "baseName": "transport_protocol_name",
            "type": "string"
        },
        {
            "name": "user",
            "baseName": "user",
            "type": "string"
        },
        {
            "name": "visibility",
            "baseName": "visibility",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return EnterpriseAdminGetAuditLog200ResponseInner.attributeTypeMap;
    }
}

