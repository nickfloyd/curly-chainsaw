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
import { MinimalRepository } from './minimalRepository';
import { SimpleUser } from './simpleUser';

/**
* Repository invitations let you manage who you collaborate with.
*/
export class RepositoryInvitation {
    /**
    * Unique identifier of the repository invitation.
    */
    'id': number;
    'repository': MinimalRepository;
    'invitee': SimpleUser | null;
    'inviter': SimpleUser | null;
    /**
    * The permission associated with the invitation.
    */
    'permissions': RepositoryInvitation.PermissionsEnum;
    'createdAt': Date;
    /**
    * Whether or not the invitation has expired
    */
    'expired'?: boolean;
    /**
    * URL for the repository invitation
    */
    'url': string;
    'htmlUrl': string;
    'nodeId': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "id",
            "baseName": "id",
            "type": "number"
        },
        {
            "name": "repository",
            "baseName": "repository",
            "type": "MinimalRepository"
        },
        {
            "name": "invitee",
            "baseName": "invitee",
            "type": "SimpleUser"
        },
        {
            "name": "inviter",
            "baseName": "inviter",
            "type": "SimpleUser"
        },
        {
            "name": "permissions",
            "baseName": "permissions",
            "type": "RepositoryInvitation.PermissionsEnum"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "Date"
        },
        {
            "name": "expired",
            "baseName": "expired",
            "type": "boolean"
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
            "name": "nodeId",
            "baseName": "node_id",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return RepositoryInvitation.attributeTypeMap;
    }
}

export namespace RepositoryInvitation {
    export enum PermissionsEnum {
        Read = <any> 'read',
        Write = <any> 'write',
        Admin = <any> 'admin',
        Triage = <any> 'triage',
        Maintain = <any> 'maintain'
    }
}