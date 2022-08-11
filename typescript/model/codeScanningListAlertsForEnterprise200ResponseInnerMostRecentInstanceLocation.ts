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
* Describe a region within a file for the alert.
*/
export class CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceLocation {
    'path'?: string;
    'startLine'?: number;
    'endLine'?: number;
    'startColumn'?: number;
    'endColumn'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "path",
            "baseName": "path",
            "type": "string"
        },
        {
            "name": "startLine",
            "baseName": "start_line",
            "type": "number"
        },
        {
            "name": "endLine",
            "baseName": "end_line",
            "type": "number"
        },
        {
            "name": "startColumn",
            "baseName": "start_column",
            "type": "number"
        },
        {
            "name": "endColumn",
            "baseName": "end_column",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstanceLocation.attributeTypeMap;
    }
}
