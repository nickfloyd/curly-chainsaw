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
import { WebhookConfigurationInsecureSsl } from './webhookConfigurationInsecureSsl';

/**
* Key/value pairs to provide settings for this webhook. [These are defined below](https://docs.github.com/rest/reference/orgs#update-hook-config-params).
*/
export class OrgsUpdateWebhookRequestConfig {
    /**
    * The URL to which the payloads will be delivered.
    */
    'url': string;
    /**
    * The media type used to serialize the payloads. Supported values include `json` and `form`. The default is `form`.
    */
    'contentType'?: string;
    /**
    * If provided, the `secret` will be used as the `key` to generate the HMAC hex digest value for [delivery signature headers](https://docs.github.com/webhooks/event-payloads/#delivery-headers).
    */
    'secret'?: string;
    'insecureSsl'?: WebhookConfigurationInsecureSsl;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "contentType",
            "baseName": "content_type",
            "type": "string"
        },
        {
            "name": "secret",
            "baseName": "secret",
            "type": "string"
        },
        {
            "name": "insecureSsl",
            "baseName": "insecure_ssl",
            "type": "WebhookConfigurationInsecureSsl"
        }    ];

    static getAttributeTypeMap() {
        return OrgsUpdateWebhookRequestConfig.attributeTypeMap;
    }
}

