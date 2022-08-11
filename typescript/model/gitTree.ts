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
import { GitTreeTreeInner } from './gitTreeTreeInner';

/**
* The hierarchy between files in a Git repository.
*/
export class GitTree {
    'sha': string;
    'url': string;
    'truncated': boolean;
    /**
    * Objects specifying a tree structure
    */
    'tree': Array<GitTreeTreeInner>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "sha",
            "baseName": "sha",
            "type": "string"
        },
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "truncated",
            "baseName": "truncated",
            "type": "boolean"
        },
        {
            "name": "tree",
            "baseName": "tree",
            "type": "Array<GitTreeTreeInner>"
        }    ];

    static getAttributeTypeMap() {
        return GitTree.attributeTypeMap;
    }
}
