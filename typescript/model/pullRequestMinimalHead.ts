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
import { PullRequestMinimalHeadRepo } from './pullRequestMinimalHeadRepo';

export class PullRequestMinimalHead {
    'ref': string;
    'sha': string;
    'repo': PullRequestMinimalHeadRepo;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "ref",
            "baseName": "ref",
            "type": "string"
        },
        {
            "name": "sha",
            "baseName": "sha",
            "type": "string"
        },
        {
            "name": "repo",
            "baseName": "repo",
            "type": "PullRequestMinimalHeadRepo"
        }    ];

    static getAttributeTypeMap() {
        return PullRequestMinimalHead.attributeTypeMap;
    }
}

