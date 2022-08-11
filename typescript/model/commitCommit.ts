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
import { CommitCommitTree } from './commitCommitTree';
import { GitUser } from './gitUser';
import { Verification } from './verification';

export class CommitCommit {
    'url': string;
    'author': GitUser | null;
    'committer': GitUser | null;
    'message': string;
    'commentCount': number;
    'tree': CommitCommitTree;
    'verification'?: Verification;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "author",
            "baseName": "author",
            "type": "GitUser"
        },
        {
            "name": "committer",
            "baseName": "committer",
            "type": "GitUser"
        },
        {
            "name": "message",
            "baseName": "message",
            "type": "string"
        },
        {
            "name": "commentCount",
            "baseName": "comment_count",
            "type": "number"
        },
        {
            "name": "tree",
            "baseName": "tree",
            "type": "CommitCommitTree"
        },
        {
            "name": "verification",
            "baseName": "verification",
            "type": "Verification"
        }    ];

    static getAttributeTypeMap() {
        return CommitCommit.attributeTypeMap;
    }
}
