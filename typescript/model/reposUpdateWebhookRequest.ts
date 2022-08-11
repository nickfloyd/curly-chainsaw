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
import { ReposUpdateWebhookRequestConfig } from './reposUpdateWebhookRequestConfig';

export class ReposUpdateWebhookRequest {
    'config'?: ReposUpdateWebhookRequestConfig;
    /**
    * Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. This replaces the entire array of events.
    */
    'events'?: Array<string>;
    /**
    * Determines a list of events to be added to the list of events that the Hook triggers for.
    */
    'addEvents'?: Array<string>;
    /**
    * Determines a list of events to be removed from the list of events that the Hook triggers for.
    */
    'removeEvents'?: Array<string>;
    /**
    * Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.
    */
    'active'?: boolean = true;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "config",
            "baseName": "config",
            "type": "ReposUpdateWebhookRequestConfig"
        },
        {
            "name": "events",
            "baseName": "events",
            "type": "Array<string>"
        },
        {
            "name": "addEvents",
            "baseName": "add_events",
            "type": "Array<string>"
        },
        {
            "name": "removeEvents",
            "baseName": "remove_events",
            "type": "Array<string>"
        },
        {
            "name": "active",
            "baseName": "active",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return ReposUpdateWebhookRequest.attributeTypeMap;
    }
}
