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
import { Gist } from './gist';
import { GistHistory } from './gistHistory';
import { GistSimpleFilesValue } from './gistSimpleFilesValue';
import { GistSimpleForksInner } from './gistSimpleForksInner';
import { SimpleUser1 } from './simpleUser1';

/**
* Gist Simple
*/
export class GistSimple {
    'forks'?: Array<GistSimpleForksInner> | null;
    'history'?: Array<GistHistory> | null;
    'forkOf'?: Gist | null;
    'url'?: string;
    'forksUrl'?: string;
    'commitsUrl'?: string;
    'id'?: string;
    'nodeId'?: string;
    'gitPullUrl'?: string;
    'gitPushUrl'?: string;
    'htmlUrl'?: string;
    'files'?: { [key: string]: GistSimpleFilesValue; };
    '_public'?: boolean;
    'createdAt'?: string;
    'updatedAt'?: string;
    'description'?: string | null;
    'comments'?: number;
    'user'?: string | null;
    'commentsUrl'?: string;
    'owner'?: SimpleUser1;
    'truncated'?: boolean;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "forks",
            "baseName": "forks",
            "type": "Array<GistSimpleForksInner>"
        },
        {
            "name": "history",
            "baseName": "history",
            "type": "Array<GistHistory>"
        },
        {
            "name": "forkOf",
            "baseName": "fork_of",
            "type": "Gist"
        },
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "forksUrl",
            "baseName": "forks_url",
            "type": "string"
        },
        {
            "name": "commitsUrl",
            "baseName": "commits_url",
            "type": "string"
        },
        {
            "name": "id",
            "baseName": "id",
            "type": "string"
        },
        {
            "name": "nodeId",
            "baseName": "node_id",
            "type": "string"
        },
        {
            "name": "gitPullUrl",
            "baseName": "git_pull_url",
            "type": "string"
        },
        {
            "name": "gitPushUrl",
            "baseName": "git_push_url",
            "type": "string"
        },
        {
            "name": "htmlUrl",
            "baseName": "html_url",
            "type": "string"
        },
        {
            "name": "files",
            "baseName": "files",
            "type": "{ [key: string]: GistSimpleFilesValue; }"
        },
        {
            "name": "_public",
            "baseName": "public",
            "type": "boolean"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "string"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "string"
        },
        {
            "name": "description",
            "baseName": "description",
            "type": "string"
        },
        {
            "name": "comments",
            "baseName": "comments",
            "type": "number"
        },
        {
            "name": "user",
            "baseName": "user",
            "type": "string"
        },
        {
            "name": "commentsUrl",
            "baseName": "comments_url",
            "type": "string"
        },
        {
            "name": "owner",
            "baseName": "owner",
            "type": "SimpleUser1"
        },
        {
            "name": "truncated",
            "baseName": "truncated",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return GistSimple.attributeTypeMap;
    }
}

