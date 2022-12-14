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
import { PullRequestHeadRepo } from './pullRequestHeadRepo';
import { PullRequestHeadRepoOwner } from './pullRequestHeadRepoOwner';

export class PullRequestHead {
    'label': string;
    'ref': string;
    'repo': PullRequestHeadRepo | null;
    'sha': string;
    'user': PullRequestHeadRepoOwner;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "label",
            "baseName": "label",
            "type": "string"
        },
        {
            "name": "ref",
            "baseName": "ref",
            "type": "string"
        },
        {
            "name": "repo",
            "baseName": "repo",
            "type": "PullRequestHeadRepo"
        },
        {
            "name": "sha",
            "baseName": "sha",
            "type": "string"
        },
        {
            "name": "user",
            "baseName": "user",
            "type": "PullRequestHeadRepoOwner"
        }    ];

    static getAttributeTypeMap() {
        return PullRequestHead.attributeTypeMap;
    }
}

