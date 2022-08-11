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

export class ReposCreateCommitCommentRequest {
    /**
    * The contents of the comment.
    */
    'body': string;
    /**
    * Relative path of the file to comment on.
    */
    'path'?: string;
    /**
    * Line index in the diff to comment on.
    */
    'position'?: number;
    /**
    * **Deprecated**. Use **position** parameter instead. Line number in the file to comment on.
    */
    'line'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "body",
            "baseName": "body",
            "type": "string"
        },
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
            "name": "line",
            "baseName": "line",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return ReposCreateCommitCommentRequest.attributeTypeMap;
    }
}

