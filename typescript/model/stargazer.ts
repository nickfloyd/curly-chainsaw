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
import { SimpleUser } from './simpleUser';

/**
* Stargazer
*/
export class Stargazer {
    'starredAt': Date;
    'user': SimpleUser | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "starredAt",
            "baseName": "starred_at",
            "type": "Date"
        },
        {
            "name": "user",
            "baseName": "user",
            "type": "SimpleUser"
        }    ];

    static getAttributeTypeMap() {
        return Stargazer.attributeTypeMap;
    }
}

