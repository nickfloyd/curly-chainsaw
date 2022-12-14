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

export class CodeScanningListAlertsForRepo200ResponseInnerRule {
    /**
    * A unique identifier for the rule used to detect the alert.
    */
    'id'?: string | null;
    /**
    * The name of the rule used to detect the alert.
    */
    'name'?: string;
    /**
    * A set of tags applicable for the rule.
    */
    'tags'?: Array<string> | null;
    /**
    * The severity of the alert.
    */
    'severity'?: CodeScanningListAlertsForRepo200ResponseInnerRule.SeverityEnum;
    /**
    * A short description of the rule used to detect the alert.
    */
    'description'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "id",
            "baseName": "id",
            "type": "string"
        },
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "tags",
            "baseName": "tags",
            "type": "Array<string>"
        },
        {
            "name": "severity",
            "baseName": "severity",
            "type": "CodeScanningListAlertsForRepo200ResponseInnerRule.SeverityEnum"
        },
        {
            "name": "description",
            "baseName": "description",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return CodeScanningListAlertsForRepo200ResponseInnerRule.attributeTypeMap;
    }
}

export namespace CodeScanningListAlertsForRepo200ResponseInnerRule {
    export enum SeverityEnum {
        None = <any> 'none',
        Note = <any> 'note',
        Warning = <any> 'warning',
        Error = <any> 'error'
    }
}
