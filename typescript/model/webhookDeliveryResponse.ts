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

export class WebhookDeliveryResponse {
    /**
    * The response headers received when the delivery was made.
    */
    'headers': { [key: string]: any; } | null;
    /**
    * The response payload received.
    */
    'payload': { [key: string]: any; } | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "headers",
            "baseName": "headers",
            "type": "{ [key: string]: any; }"
        },
        {
            "name": "payload",
            "baseName": "payload",
            "type": "{ [key: string]: any; }"
        }    ];

    static getAttributeTypeMap() {
        return WebhookDeliveryResponse.attributeTypeMap;
    }
}

