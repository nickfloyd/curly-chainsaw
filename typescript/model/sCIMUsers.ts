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
import { SCIMUsersEmailsInner } from './sCIMUsersEmailsInner';
import { SCIMUsersGroupsInner } from './sCIMUsersGroupsInner';
import { SCIMUsersMeta } from './sCIMUsersMeta';
import { SCIMUsersName } from './sCIMUsersName';
import { SCIMUsersOperationsInner } from './sCIMUsersOperationsInner';

/**
* SCIM /Users provisioning endpoints
*/
export class SCIMUsers {
    /**
    * SCIM schema used.
    */
    'schemas': Array<string>;
    /**
    * Unique identifier of an external identity
    */
    'id': string;
    /**
    * The ID of the User.
    */
    'externalId': string | null;
    /**
    * Configured by the admin. Could be an email, login, or username
    */
    'userName': string | null;
    /**
    * The name of the user, suitable for display to end-users
    */
    'displayName'?: string | null;
    'name': SCIMUsersName;
    /**
    * user emails
    */
    'emails': Array<SCIMUsersEmailsInner>;
    /**
    * The active status of the User.
    */
    'active': boolean;
    'meta': SCIMUsersMeta;
    /**
    * The ID of the organization.
    */
    'organizationId'?: number;
    /**
    * Set of operations to be performed
    */
    'operations'?: Array<SCIMUsersOperationsInner>;
    /**
    * associated groups
    */
    'groups'?: Array<SCIMUsersGroupsInner>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "schemas",
            "baseName": "schemas",
            "type": "Array<string>"
        },
        {
            "name": "id",
            "baseName": "id",
            "type": "string"
        },
        {
            "name": "externalId",
            "baseName": "externalId",
            "type": "string"
        },
        {
            "name": "userName",
            "baseName": "userName",
            "type": "string"
        },
        {
            "name": "displayName",
            "baseName": "displayName",
            "type": "string"
        },
        {
            "name": "name",
            "baseName": "name",
            "type": "SCIMUsersName"
        },
        {
            "name": "emails",
            "baseName": "emails",
            "type": "Array<SCIMUsersEmailsInner>"
        },
        {
            "name": "active",
            "baseName": "active",
            "type": "boolean"
        },
        {
            "name": "meta",
            "baseName": "meta",
            "type": "SCIMUsersMeta"
        },
        {
            "name": "organizationId",
            "baseName": "organization_id",
            "type": "number"
        },
        {
            "name": "operations",
            "baseName": "operations",
            "type": "Array<SCIMUsersOperationsInner>"
        },
        {
            "name": "groups",
            "baseName": "groups",
            "type": "Array<SCIMUsersGroupsInner>"
        }    ];

    static getAttributeTypeMap() {
        return SCIMUsers.attributeTypeMap;
    }
}

