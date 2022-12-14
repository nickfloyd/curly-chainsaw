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
import { MarketplaceListingPlan } from './marketplaceListingPlan';

export class MarketplacePurchaseMarketplacePurchase {
    'billingCycle'?: string;
    'nextBillingDate'?: string | null;
    'isInstalled'?: boolean;
    'unitCount'?: number | null;
    'onFreeTrial'?: boolean;
    'freeTrialEndsOn'?: string | null;
    'updatedAt'?: string;
    'plan'?: MarketplaceListingPlan;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "billingCycle",
            "baseName": "billing_cycle",
            "type": "string"
        },
        {
            "name": "nextBillingDate",
            "baseName": "next_billing_date",
            "type": "string"
        },
        {
            "name": "isInstalled",
            "baseName": "is_installed",
            "type": "boolean"
        },
        {
            "name": "unitCount",
            "baseName": "unit_count",
            "type": "number"
        },
        {
            "name": "onFreeTrial",
            "baseName": "on_free_trial",
            "type": "boolean"
        },
        {
            "name": "freeTrialEndsOn",
            "baseName": "free_trial_ends_on",
            "type": "string"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "string"
        },
        {
            "name": "plan",
            "baseName": "plan",
            "type": "MarketplaceListingPlan"
        }    ];

    static getAttributeTypeMap() {
        return MarketplacePurchaseMarketplacePurchase.attributeTypeMap;
    }
}

