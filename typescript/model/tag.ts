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
import { ShortBranchCommit } from './shortBranchCommit';

/**
* Tag
*/
export class Tag {
    'name': string;
    'commit': ShortBranchCommit;
    'zipballUrl': string;
    'tarballUrl': string;
    'nodeId': string;

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
            "type": "ShortBranchCommit"
        },
        {
            "name": "zipballUrl",
            "baseName": "zipball_url",
            "type": "string"
        },
        {
            "name": "tarballUrl",
            "baseName": "tarball_url",
            "type": "string"
        },
        {
            "name": "nodeId",
            "baseName": "node_id",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return Tag.attributeTypeMap;
    }
}

