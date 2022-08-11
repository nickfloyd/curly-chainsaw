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

export class GitUpdateRefRequest {
    /**
    * The SHA1 value to set this reference to
    */
    'sha': string;
    /**
    * Indicates whether to force the update or to make sure the update is a fast-forward update. Leaving this out or setting it to `false` will make sure you\'re not overwriting work.
    */
    'force'?: boolean = false;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "sha",
            "baseName": "sha",
            "type": "string"
        },
        {
            "name": "force",
            "baseName": "force",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return GitUpdateRefRequest.attributeTypeMap;
    }
}

