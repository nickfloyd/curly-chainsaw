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

/**
* Marketplace Listing Plan
*/
export class MarketplaceListingPlan {
    'url': string;
    'accountsUrl': string;
    'id': number;
    'number': number;
    'name': string;
    'description': string;
    'monthlyPriceInCents': number;
    'yearlyPriceInCents': number;
    'priceModel': string;
    'hasFreeTrial': boolean;
    'unitName': string | null;
    'state': string;
    'bullets': Array<string>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "accountsUrl",
            "baseName": "accounts_url",
            "type": "string"
        },
        {
            "name": "id",
            "baseName": "id",
            "type": "number"
        },
        {
            "name": "number",
            "baseName": "number",
            "type": "number"
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
            "name": "monthlyPriceInCents",
            "baseName": "monthly_price_in_cents",
            "type": "number"
        },
        {
            "name": "yearlyPriceInCents",
            "baseName": "yearly_price_in_cents",
            "type": "number"
        },
        {
            "name": "priceModel",
            "baseName": "price_model",
            "type": "string"
        },
        {
            "name": "hasFreeTrial",
            "baseName": "has_free_trial",
            "type": "boolean"
        },
        {
            "name": "unitName",
            "baseName": "unit_name",
            "type": "string"
        },
        {
            "name": "state",
            "baseName": "state",
            "type": "string"
        },
        {
            "name": "bullets",
            "baseName": "bullets",
            "type": "Array<string>"
        }    ];

    static getAttributeTypeMap() {
        return MarketplaceListingPlan.attributeTypeMap;
    }
}

