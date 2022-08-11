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
import { FeedLinks } from './feedLinks';

/**
* Feed
*/
export class Feed {
    'timelineUrl': string;
    'userUrl': string;
    'currentUserPublicUrl'?: string;
    'currentUserUrl'?: string;
    'currentUserActorUrl'?: string;
    'currentUserOrganizationUrl'?: string;
    'currentUserOrganizationUrls'?: Array<string>;
    'securityAdvisoriesUrl'?: string;
    'links': FeedLinks;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "timelineUrl",
            "baseName": "timeline_url",
            "type": "string"
        },
        {
            "name": "userUrl",
            "baseName": "user_url",
            "type": "string"
        },
        {
            "name": "currentUserPublicUrl",
            "baseName": "current_user_public_url",
            "type": "string"
        },
        {
            "name": "currentUserUrl",
            "baseName": "current_user_url",
            "type": "string"
        },
        {
            "name": "currentUserActorUrl",
            "baseName": "current_user_actor_url",
            "type": "string"
        },
        {
            "name": "currentUserOrganizationUrl",
            "baseName": "current_user_organization_url",
            "type": "string"
        },
        {
            "name": "currentUserOrganizationUrls",
            "baseName": "current_user_organization_urls",
            "type": "Array<string>"
        },
        {
            "name": "securityAdvisoriesUrl",
            "baseName": "security_advisories_url",
            "type": "string"
        },
        {
            "name": "links",
            "baseName": "_links",
            "type": "FeedLinks"
        }    ];

    static getAttributeTypeMap() {
        return Feed.attributeTypeMap;
    }
}

