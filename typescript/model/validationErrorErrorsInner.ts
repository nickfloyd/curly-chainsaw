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
import { ValidationErrorErrorsInnerValue } from './validationErrorErrorsInnerValue';

export class ValidationErrorErrorsInner {
    'resource'?: string;
    'field'?: string;
    'message'?: string;
    'code': string;
    'index'?: number;
    'value'?: ValidationErrorErrorsInnerValue;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "resource",
            "baseName": "resource",
            "type": "string"
        },
        {
            "name": "field",
            "baseName": "field",
            "type": "string"
        },
        {
            "name": "message",
            "baseName": "message",
            "type": "string"
        },
        {
            "name": "code",
            "baseName": "code",
            "type": "string"
        },
        {
            "name": "index",
            "baseName": "index",
            "type": "number"
        },
        {
            "name": "value",
            "baseName": "value",
            "type": "ValidationErrorErrorsInnerValue"
        }    ];

    static getAttributeTypeMap() {
        return ValidationErrorErrorsInner.attributeTypeMap;
    }
}

