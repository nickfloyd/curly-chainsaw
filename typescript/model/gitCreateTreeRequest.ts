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
import { GitCreateTreeRequestTreeInner } from './gitCreateTreeRequestTreeInner';

export class GitCreateTreeRequest {
    /**
    * Objects (of `path`, `mode`, `type`, and `sha`) specifying a tree structure.
    */
    'tree': Array<GitCreateTreeRequestTreeInner>;
    /**
    * The SHA1 of an existing Git tree object which will be used as the base for the new tree. If provided, a new Git tree object will be created from entries in the Git tree object pointed to by `base_tree` and entries defined in the `tree` parameter. Entries defined in the `tree` parameter will overwrite items from `base_tree` with the same `path`. If you\'re creating new changes on a branch, then normally you\'d set `base_tree` to the SHA1 of the Git tree object of the current latest commit on the branch you\'re working on. If not provided, GitHub will create a new Git tree object from only the entries defined in the `tree` parameter. If you create a new commit pointing to such a tree, then all files which were a part of the parent commit\'s tree and were not defined in the `tree` parameter will be listed as deleted by the new commit. 
    */
    'baseTree'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "tree",
            "baseName": "tree",
            "type": "Array<GitCreateTreeRequestTreeInner>"
        },
        {
            "name": "baseTree",
            "baseName": "base_tree",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return GitCreateTreeRequest.attributeTypeMap;
    }
}

