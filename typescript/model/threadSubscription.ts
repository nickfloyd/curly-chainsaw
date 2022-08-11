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
* Thread Subscription
*/
export class ThreadSubscription {
    'subscribed': boolean;
    'ignored': boolean;
    'reason': string | null;
    'createdAt': Date | null;
    'url': string;
    'threadUrl'?: string;
    'repositoryUrl'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "subscribed",
            "baseName": "subscribed",
            "type": "boolean"
        },
        {
            "name": "ignored",
            "baseName": "ignored",
            "type": "boolean"
        },
        {
            "name": "reason",
            "baseName": "reason",
            "type": "string"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "Date"
        },
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "threadUrl",
            "baseName": "thread_url",
            "type": "string"
        },
        {
            "name": "repositoryUrl",
            "baseName": "repository_url",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return ThreadSubscription.attributeTypeMap;
    }
}
