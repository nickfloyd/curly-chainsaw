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
import { EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMembersInner } from './enterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMembersInner';
import { EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta } from './enterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta';

export class EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner {
    'schemas': Array<string>;
    'id': string;
    'externalId'?: string | null;
    'displayName'?: string;
    'members'?: Array<EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMembersInner>;
    'meta'?: EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta;

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
            "name": "displayName",
            "baseName": "displayName",
            "type": "string"
        },
        {
            "name": "members",
            "baseName": "members",
            "type": "Array<EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMembersInner>"
        },
        {
            "name": "meta",
            "baseName": "meta",
            "type": "EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta"
        }    ];

    static getAttributeTypeMap() {
        return EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner.attributeTypeMap;
    }
}
