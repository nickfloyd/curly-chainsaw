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

export class CodeScanningListAlertsForEnterprise200ResponseInnerTool {
    /**
    * The name of the tool used to generate the code scanning analysis.
    */
    'name'?: string;
    /**
    * The version of the tool used to generate the code scanning analysis.
    */
    'version'?: string | null;
    /**
    * The GUID of the tool used to generate the code scanning analysis, if provided in the uploaded SARIF data.
    */
    'guid'?: string | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "version",
            "baseName": "version",
            "type": "string"
        },
        {
            "name": "guid",
            "baseName": "guid",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return CodeScanningListAlertsForEnterprise200ResponseInnerTool.attributeTypeMap;
    }
}

