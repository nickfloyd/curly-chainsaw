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

export class ChecksCreateRequestOneOf1 extends null<String, any> {
    'status'?: ChecksCreateRequestOneOf1.StatusEnum;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "status",
            "baseName": "status",
            "type": "ChecksCreateRequestOneOf1.StatusEnum"
        }    ];

    static getAttributeTypeMap() {
        return super.getAttributeTypeMap().concat(ChecksCreateRequestOneOf1.attributeTypeMap);
    }
}

export namespace ChecksCreateRequestOneOf1 {
    export enum StatusEnum {
        Queued = <any> 'queued',
        InProgress = <any> 'in_progress'
    }
}
