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
import { CheckSuite } from './checkSuite';

export class ChecksListSuitesForRef200Response {
    'totalCount': number;
    'checkSuites': Array<CheckSuite>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "totalCount",
            "baseName": "total_count",
            "type": "number"
        },
        {
            "name": "checkSuites",
            "baseName": "check_suites",
            "type": "Array<CheckSuite>"
        }    ];

    static getAttributeTypeMap() {
        return ChecksListSuitesForRef200Response.attributeTypeMap;
    }
}

