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

export class PullsRequestReviewersRequest {
    /**
    * An array of user `login`s that will be requested.
    */
    'reviewers'?: Array<string>;
    /**
    * An array of team `slug`s that will be requested.
    */
    'teamReviewers'?: Array<string>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "reviewers",
            "baseName": "reviewers",
            "type": "Array<string>"
        },
        {
            "name": "teamReviewers",
            "baseName": "team_reviewers",
            "type": "Array<string>"
        }    ];

    static getAttributeTypeMap() {
        return PullsRequestReviewersRequest.attributeTypeMap;
    }
}

