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
import { ContentTreeEntriesInnerLinks } from './contentTreeEntriesInnerLinks';

/**
* An object describing a symlink
*/
export class SymlinkContent {
    'type': string;
    'target': string;
    'size': number;
    'name': string;
    'path': string;
    'sha': string;
    'url': string;
    'gitUrl': string | null;
    'htmlUrl': string | null;
    'downloadUrl': string | null;
    'links': ContentTreeEntriesInnerLinks;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "type",
            "baseName": "type",
            "type": "string"
        },
        {
            "name": "target",
            "baseName": "target",
            "type": "string"
        },
        {
            "name": "size",
            "baseName": "size",
            "type": "number"
        },
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "path",
            "baseName": "path",
            "type": "string"
        },
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
            "name": "gitUrl",
            "baseName": "git_url",
            "type": "string"
        },
        {
            "name": "htmlUrl",
            "baseName": "html_url",
            "type": "string"
        },
        {
            "name": "downloadUrl",
            "baseName": "download_url",
            "type": "string"
        },
        {
            "name": "links",
            "baseName": "_links",
            "type": "ContentTreeEntriesInnerLinks"
        }    ];

    static getAttributeTypeMap() {
        return SymlinkContent.attributeTypeMap;
    }
}

