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

export class PullsMergeRequest {
    /**
    * Title for the automatic commit message.
    */
    'commitTitle'?: string;
    /**
    * Extra detail to append to automatic commit message.
    */
    'commitMessage'?: string;
    /**
    * SHA that pull request head must match to allow merge.
    */
    'sha'?: string;
    /**
    * Merge method to use. Possible values are `merge`, `squash` or `rebase`. Default is `merge`.
    */
    'mergeMethod'?: PullsMergeRequest.MergeMethodEnum;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "commitTitle",
            "baseName": "commit_title",
            "type": "string"
        },
        {
            "name": "commitMessage",
            "baseName": "commit_message",
            "type": "string"
        },
        {
            "name": "sha",
            "baseName": "sha",
            "type": "string"
        },
        {
            "name": "mergeMethod",
            "baseName": "merge_method",
            "type": "PullsMergeRequest.MergeMethodEnum"
        }    ];

    static getAttributeTypeMap() {
        return PullsMergeRequest.attributeTypeMap;
    }
}

export namespace PullsMergeRequest {
    export enum MergeMethodEnum {
        Merge = <any> 'merge',
        Squash = <any> 'squash',
        Rebase = <any> 'rebase'
    }
}
