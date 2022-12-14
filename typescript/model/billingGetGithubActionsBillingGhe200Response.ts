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
import { BillingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown } from './billingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown';

export class BillingGetGithubActionsBillingGhe200Response {
    /**
    * The sum of the free and paid GitHub Actions minutes used.
    */
    'totalMinutesUsed': number;
    /**
    * The total paid GitHub Actions minutes used.
    */
    'totalPaidMinutesUsed': number;
    /**
    * The amount of free GitHub Actions minutes available.
    */
    'includedMinutes': number;
    'minutesUsedBreakdown': BillingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalMinutesUsed",
            "baseName": "total_minutes_used",
            "type": "number"
        },
        {
            "name": "totalPaidMinutesUsed",
            "baseName": "total_paid_minutes_used",
            "type": "number"
        },
        {
            "name": "includedMinutes",
            "baseName": "included_minutes",
            "type": "number"
        },
        {
            "name": "minutesUsedBreakdown",
            "baseName": "minutes_used_breakdown",
            "type": "BillingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown"
        }    ];

    static getAttributeTypeMap() {
        return BillingGetGithubActionsBillingGhe200Response.attributeTypeMap;
    }
}

