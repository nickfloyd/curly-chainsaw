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
import { PageBuildError } from './pageBuildError';
import { SimpleUser } from './simpleUser';

/**
* Page Build
*/
export class PageBuild {
    'url': string;
    'status': string;
    'error': PageBuildError;
    'pusher': SimpleUser | null;
    'commit': string;
    'duration': number;
    'createdAt': Date;
    'updatedAt': Date;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "status",
            "baseName": "status",
            "type": "string"
        },
        {
            "name": "error",
            "baseName": "error",
            "type": "PageBuildError"
        },
        {
            "name": "pusher",
            "baseName": "pusher",
            "type": "SimpleUser"
        },
        {
            "name": "commit",
            "baseName": "commit",
            "type": "string"
        },
        {
            "name": "duration",
            "baseName": "duration",
            "type": "number"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "Date"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "Date"
        }    ];

    static getAttributeTypeMap() {
        return PageBuild.attributeTypeMap;
    }
}

