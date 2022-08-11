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
import { ScimUpdateAttributeForUserRequestOperationsInnerValue } from './scimUpdateAttributeForUserRequestOperationsInnerValue';

export class ScimUpdateAttributeForUserRequestOperationsInner {
    'op': ScimUpdateAttributeForUserRequestOperationsInner.OpEnum;
    'path'?: string;
    'value'?: ScimUpdateAttributeForUserRequestOperationsInnerValue;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "op",
            "baseName": "op",
            "type": "ScimUpdateAttributeForUserRequestOperationsInner.OpEnum"
        },
        {
            "name": "path",
            "baseName": "path",
            "type": "string"
        },
        {
            "name": "value",
            "baseName": "value",
            "type": "ScimUpdateAttributeForUserRequestOperationsInnerValue"
        }    ];

    static getAttributeTypeMap() {
        return ScimUpdateAttributeForUserRequestOperationsInner.attributeTypeMap;
    }
}

export namespace ScimUpdateAttributeForUserRequestOperationsInner {
    export enum OpEnum {
        Add = <any> 'add',
        Remove = <any> 'remove',
        Replace = <any> 'replace'
    }
}