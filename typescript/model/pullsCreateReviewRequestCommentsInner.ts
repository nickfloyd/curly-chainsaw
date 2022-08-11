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

export class PullsCreateReviewRequestCommentsInner {
    /**
    * The relative path to the file that necessitates a review comment.
    */
    'path': string;
    /**
    * The position in the diff where you want to add a review comment. Note this value is not the same as the line number in the file. For help finding the position value, read the note below.
    */
    'position'?: number;
    /**
    * Text of the review comment.
    */
    'body': string;
    'line'?: number;
    'side'?: string;
    'startLine'?: number;
    'startSide'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "path",
            "baseName": "path",
            "type": "string"
        },
        {
            "name": "position",
            "baseName": "position",
            "type": "number"
        },
        {
            "name": "body",
            "baseName": "body",
            "type": "string"
        },
        {
            "name": "line",
            "baseName": "line",
            "type": "number"
        },
        {
            "name": "side",
            "baseName": "side",
            "type": "string"
        },
        {
            "name": "startLine",
            "baseName": "start_line",
            "type": "number"
        },
        {
            "name": "startSide",
            "baseName": "start_side",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return PullsCreateReviewRequestCommentsInner.attributeTypeMap;
    }
}

