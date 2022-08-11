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
import { BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner } from './billingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner';

export class BillingGetGithubAdvancedSecurityBillingGhe200Response {
    'totalAdvancedSecurityCommitters'?: number;
    'totalCount'?: number;
    'repositories': Array<BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalAdvancedSecurityCommitters",
            "baseName": "total_advanced_security_committers",
            "type": "number"
        },
        {
            "name": "totalCount",
            "baseName": "total_count",
            "type": "number"
        },
        {
            "name": "repositories",
            "baseName": "repositories",
            "type": "Array<BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner>"
        }    ];

    static getAttributeTypeMap() {
        return BillingGetGithubAdvancedSecurityBillingGhe200Response.attributeTypeMap;
    }
}
