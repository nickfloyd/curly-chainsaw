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
import { SCIMUsersOperationsInnerValue } from './sCIMUsersOperationsInnerValue';

export class SCIMUsersOperationsInner {
    'op': SCIMUsersOperationsInner.OpEnum;
    'path'?: string;
    'value'?: SCIMUsersOperationsInnerValue;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "op",
            "baseName": "op",
            "type": "SCIMUsersOperationsInner.OpEnum"
        },
        {
            "name": "path",
            "baseName": "path",
            "type": "string"
        },
        {
            "name": "value",
            "baseName": "value",
            "type": "SCIMUsersOperationsInnerValue"
        }    ];

    static getAttributeTypeMap() {
        return SCIMUsersOperationsInner.attributeTypeMap;
    }
}

export namespace SCIMUsersOperationsInner {
    export enum OpEnum {
        Add = <any> 'add',
        Remove = <any> 'remove',
        Replace = <any> 'replace'
    }
}
