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

export class PullsSubmitReviewRequest {
    /**
    * The body text of the pull request review
    */
    'body'?: string;
    /**
    * The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. When you leave this blank, the API returns _HTTP 422 (Unrecognizable entity)_ and sets the review action state to `PENDING`, which means you will need to re-submit the pull request review using a review action.
    */
    'event': PullsSubmitReviewRequest.EventEnum;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "body",
            "baseName": "body",
            "type": "string"
        },
        {
            "name": "event",
            "baseName": "event",
            "type": "PullsSubmitReviewRequest.EventEnum"
        }    ];

    static getAttributeTypeMap() {
        return PullsSubmitReviewRequest.attributeTypeMap;
    }
}

export namespace PullsSubmitReviewRequest {
    export enum EventEnum {
        Approve = <any> 'APPROVE',
        RequestChanges = <any> 'REQUEST_CHANGES',
        Comment = <any> 'COMMENT'
    }
}
