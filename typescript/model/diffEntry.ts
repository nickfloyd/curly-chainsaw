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
* Diff Entry
*/
export class DiffEntry {
    'sha': string;
    'filename': string;
    'status': DiffEntry.StatusEnum;
    'additions': number;
    'deletions': number;
    'changes': number;
    'blobUrl': string;
    'rawUrl': string;
    'contentsUrl': string;
    'patch'?: string;
    'previousFilename'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "sha",
            "baseName": "sha",
            "type": "string"
        },
        {
            "name": "filename",
            "baseName": "filename",
            "type": "string"
        },
        {
            "name": "status",
            "baseName": "status",
            "type": "DiffEntry.StatusEnum"
        },
        {
            "name": "additions",
            "baseName": "additions",
            "type": "number"
        },
        {
            "name": "deletions",
            "baseName": "deletions",
            "type": "number"
        },
        {
            "name": "changes",
            "baseName": "changes",
            "type": "number"
        },
        {
            "name": "blobUrl",
            "baseName": "blob_url",
            "type": "string"
        },
        {
            "name": "rawUrl",
            "baseName": "raw_url",
            "type": "string"
        },
        {
            "name": "contentsUrl",
            "baseName": "contents_url",
            "type": "string"
        },
        {
            "name": "patch",
            "baseName": "patch",
            "type": "string"
        },
        {
            "name": "previousFilename",
            "baseName": "previous_filename",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return DiffEntry.attributeTypeMap;
    }
}

export namespace DiffEntry {
    export enum StatusEnum {
        Added = <any> 'added',
        Removed = <any> 'removed',
        Modified = <any> 'modified',
        Renamed = <any> 'renamed',
        Copied = <any> 'copied',
        Changed = <any> 'changed',
        Unchanged = <any> 'unchanged'
    }
}
