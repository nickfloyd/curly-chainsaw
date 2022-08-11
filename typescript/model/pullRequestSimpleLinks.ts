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
import { Link } from './link';

export class PullRequestSimpleLinks {
    'comments': Link;
    'commits': Link;
    'statuses': Link;
    'html': Link;
    'issue': Link;
    'reviewComments': Link;
    'reviewComment': Link;
    'self': Link;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "comments",
            "baseName": "comments",
            "type": "Link"
        },
        {
            "name": "commits",
            "baseName": "commits",
            "type": "Link"
        },
        {
            "name": "statuses",
            "baseName": "statuses",
            "type": "Link"
        },
        {
            "name": "html",
            "baseName": "html",
            "type": "Link"
        },
        {
            "name": "issue",
            "baseName": "issue",
            "type": "Link"
        },
        {
            "name": "reviewComments",
            "baseName": "review_comments",
            "type": "Link"
        },
        {
            "name": "reviewComment",
            "baseName": "review_comment",
            "type": "Link"
        },
        {
            "name": "self",
            "baseName": "self",
            "type": "Link"
        }    ];

    static getAttributeTypeMap() {
        return PullRequestSimpleLinks.attributeTypeMap;
    }
}
