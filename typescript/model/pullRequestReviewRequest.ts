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
import { SimpleUser1 } from './simpleUser1';
import { Team } from './team';

/**
* Pull Request Review Request
*/
export class PullRequestReviewRequest {
    'users': Array<SimpleUser1>;
    'teams': Array<Team>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "users",
            "baseName": "users",
            "type": "Array<SimpleUser1>"
        },
        {
            "name": "teams",
            "baseName": "teams",
            "type": "Array<Team>"
        }    ];

    static getAttributeTypeMap() {
        return PullRequestReviewRequest.attributeTypeMap;
    }
}
