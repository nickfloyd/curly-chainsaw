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
import { PagesHealthCheckStatusAltDomain } from './pagesHealthCheckStatusAltDomain';
import { PagesHealthCheckStatusDomain } from './pagesHealthCheckStatusDomain';

/**
* Pages Health Check Status
*/
export class PagesHealthCheckStatus {
    'domain'?: PagesHealthCheckStatusDomain;
    'altDomain'?: PagesHealthCheckStatusAltDomain | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "domain",
            "baseName": "domain",
            "type": "PagesHealthCheckStatusDomain"
        },
        {
            "name": "altDomain",
            "baseName": "alt_domain",
            "type": "PagesHealthCheckStatusAltDomain"
        }    ];

    static getAttributeTypeMap() {
        return PagesHealthCheckStatus.attributeTypeMap;
    }
}
