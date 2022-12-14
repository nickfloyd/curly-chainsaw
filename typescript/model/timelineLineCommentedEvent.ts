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
import { PullRequestReviewComment } from './pullRequestReviewComment';

/**
* Timeline Line Commented Event
*/
export class TimelineLineCommentedEvent {
    'event'?: string;
    'nodeId'?: string;
    'comments'?: Array<PullRequestReviewComment>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "event",
            "baseName": "event",
            "type": "string"
        },
        {
            "name": "nodeId",
            "baseName": "node_id",
            "type": "string"
        },
        {
            "name": "comments",
            "baseName": "comments",
            "type": "Array<PullRequestReviewComment>"
        }    ];

    static getAttributeTypeMap() {
        return TimelineLineCommentedEvent.attributeTypeMap;
    }
}

