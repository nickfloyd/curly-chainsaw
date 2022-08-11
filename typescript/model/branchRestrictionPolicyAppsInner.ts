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
import { BranchRestrictionPolicyAppsInnerOwner } from './branchRestrictionPolicyAppsInnerOwner';
import { BranchRestrictionPolicyAppsInnerPermissions } from './branchRestrictionPolicyAppsInnerPermissions';

export class BranchRestrictionPolicyAppsInner {
    'id'?: number;
    'slug'?: string;
    'nodeId'?: string;
    'owner'?: BranchRestrictionPolicyAppsInnerOwner;
    'name'?: string;
    'description'?: string;
    'externalUrl'?: string;
    'htmlUrl'?: string;
    'createdAt'?: string;
    'updatedAt'?: string;
    'permissions'?: BranchRestrictionPolicyAppsInnerPermissions;
    'events'?: Array<string>;

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
            "type": "BranchRestrictionPolicyAppsInnerOwner"
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
            "type": "string"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "string"
        },
        {
            "name": "permissions",
            "baseName": "permissions",
            "type": "BranchRestrictionPolicyAppsInnerPermissions"
        },
        {
            "name": "events",
            "baseName": "events",
            "type": "Array<string>"
        }    ];

    static getAttributeTypeMap() {
        return BranchRestrictionPolicyAppsInner.attributeTypeMap;
    }
}
