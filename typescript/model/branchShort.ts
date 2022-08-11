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
import { BranchShortCommit } from './branchShortCommit';

/**
* Branch Short
*/
export class BranchShort {
    'name': string;
    'commit': BranchShortCommit;
    '_protected': boolean;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "commit",
            "baseName": "commit",
            "type": "BranchShortCommit"
        },
        {
            "name": "_protected",
            "baseName": "protected",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return BranchShort.attributeTypeMap;
    }
}

