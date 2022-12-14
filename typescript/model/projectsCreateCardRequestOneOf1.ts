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

export class ProjectsCreateCardRequestOneOf1 {
    /**
    * The unique identifier of the content associated with the card
    */
    'contentId': number;
    /**
    * The piece of content associated with the card
    */
    'contentType': string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "contentId",
            "baseName": "content_id",
            "type": "number"
        },
        {
            "name": "contentType",
            "baseName": "content_type",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return ProjectsCreateCardRequestOneOf1.attributeTypeMap;
    }
}

