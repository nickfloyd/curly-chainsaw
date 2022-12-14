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
import { BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner } from './billingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner';

export class BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner {
    'name': string;
    'advancedSecurityCommitters': number;
    'advancedSecurityCommittersBreakdown': Array<BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "advancedSecurityCommitters",
            "baseName": "advanced_security_committers",
            "type": "number"
        },
        {
            "name": "advancedSecurityCommittersBreakdown",
            "baseName": "advanced_security_committers_breakdown",
            "type": "Array<BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInnerAdvancedSecurityCommittersBreakdownInner>"
        }    ];

    static getAttributeTypeMap() {
        return BillingGetGithubAdvancedSecurityBillingGhe200ResponseRepositoriesInner.attributeTypeMap;
    }
}

