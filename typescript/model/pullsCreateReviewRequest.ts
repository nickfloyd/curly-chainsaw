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
import { PullsCreateReviewRequestCommentsInner } from './pullsCreateReviewRequestCommentsInner';

export class PullsCreateReviewRequest {
    /**
    * The SHA of the commit that needs a review. Not using the latest commit SHA may render your review comment outdated if a subsequent commit modifies the line you specify as the `position`. Defaults to the most recent commit in the pull request when you do not specify a value.
    */
    'commitId'?: string;
    /**
    * **Required** when using `REQUEST_CHANGES` or `COMMENT` for the `event` parameter. The body text of the pull request review.
    */
    'body'?: string;
    /**
    * The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. By leaving this blank, you set the review action state to `PENDING`, which means you will need to [submit the pull request review](https://docs.github.com/rest/pulls#submit-a-review-for-a-pull-request) when you are ready.
    */
    'event'?: PullsCreateReviewRequest.EventEnum;
    /**
    * Use the following table to specify the location, destination, and contents of the draft review comment.
    */
    'comments'?: Array<PullsCreateReviewRequestCommentsInner>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "commitId",
            "baseName": "commit_id",
            "type": "string"
        },
        {
            "name": "body",
            "baseName": "body",
            "type": "string"
        },
        {
            "name": "event",
            "baseName": "event",
            "type": "PullsCreateReviewRequest.EventEnum"
        },
        {
            "name": "comments",
            "baseName": "comments",
            "type": "Array<PullsCreateReviewRequestCommentsInner>"
        }    ];

    static getAttributeTypeMap() {
        return PullsCreateReviewRequest.attributeTypeMap;
    }
}

export namespace PullsCreateReviewRequest {
    export enum EventEnum {
        Approve = <any> 'APPROVE',
        RequestChanges = <any> 'REQUEST_CHANGES',
        Comment = <any> 'COMMENT'
    }
}