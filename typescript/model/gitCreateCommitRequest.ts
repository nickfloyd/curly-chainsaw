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
import { GitCreateCommitRequestAuthor } from './gitCreateCommitRequestAuthor';
import { GitCreateCommitRequestCommitter } from './gitCreateCommitRequestCommitter';

export class GitCreateCommitRequest {
    /**
    * The commit message
    */
    'message': string;
    /**
    * The SHA of the tree object this commit points to
    */
    'tree': string;
    /**
    * The SHAs of the commits that were the parents of this commit. If omitted or empty, the commit will be written as a root commit. For a single parent, an array of one SHA should be provided; for a merge commit, an array of more than one should be provided.
    */
    'parents'?: Array<string>;
    'author'?: GitCreateCommitRequestAuthor;
    'committer'?: GitCreateCommitRequestCommitter;
    /**
    * The [PGP signature](https://en.wikipedia.org/wiki/Pretty_Good_Privacy) of the commit. GitHub adds the signature to the `gpgsig` header of the created commit. For a commit signature to be verifiable by Git or GitHub, it must be an ASCII-armored detached PGP signature over the string commit as it would be written to the object database. To pass a `signature` parameter, you need to first manually create a valid PGP signature, which can be complicated. You may find it easier to [use the command line](https://git-scm.com/book/id/v2/Git-Tools-Signing-Your-Work) to create signed commits.
    */
    'signature'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "message",
            "baseName": "message",
            "type": "string"
        },
        {
            "name": "tree",
            "baseName": "tree",
            "type": "string"
        },
        {
            "name": "parents",
            "baseName": "parents",
            "type": "Array<string>"
        },
        {
            "name": "author",
            "baseName": "author",
            "type": "GitCreateCommitRequestAuthor"
        },
        {
            "name": "committer",
            "baseName": "committer",
            "type": "GitCreateCommitRequestCommitter"
        },
        {
            "name": "signature",
            "baseName": "signature",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return GitCreateCommitRequest.attributeTypeMap;
    }
}
