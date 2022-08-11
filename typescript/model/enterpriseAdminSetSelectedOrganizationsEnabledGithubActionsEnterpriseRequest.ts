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

export class EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest {
    /**
    * List of organization IDs to enable for GitHub Actions.
    */
    'selectedOrganizationIds': Array<number>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "selectedOrganizationIds",
            "baseName": "selected_organization_ids",
            "type": "Array<number>"
        }    ];

    static getAttributeTypeMap() {
        return EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest.attributeTypeMap;
    }
}

