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

export class EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta {
    'resourceType'?: string;
    'created'?: string;
    'lastModified'?: string;
    'location'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "resourceType",
            "baseName": "resourceType",
            "type": "string"
        },
        {
            "name": "created",
            "baseName": "created",
            "type": "string"
        },
        {
            "name": "lastModified",
            "baseName": "lastModified",
            "type": "string"
        },
        {
            "name": "location",
            "baseName": "location",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta.attributeTypeMap;
    }
}

