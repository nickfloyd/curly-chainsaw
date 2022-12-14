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

export class ProjectsCreateCardRequestOneOf {
    /**
    * The project card\'s note
    */
    'note': string | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "note",
            "baseName": "note",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return ProjectsCreateCardRequestOneOf.attributeTypeMap;
    }
}

