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

/**
* An object with information about the individual creating the tag.
*/
export class GitCreateTagRequestTagger {
    /**
    * The name of the author of the tag
    */
    'name': string;
    /**
    * The email of the author of the tag
    */
    'email': string;
    /**
    * When this object was tagged. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
    */
    'date'?: Date;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "email",
            "baseName": "email",
            "type": "string"
        },
        {
            "name": "date",
            "baseName": "date",
            "type": "Date"
        }    ];

    static getAttributeTypeMap() {
        return GitCreateTagRequestTagger.attributeTypeMap;
    }
}

