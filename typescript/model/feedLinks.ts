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
import { LinkWithType } from './linkWithType';

export class FeedLinks {
    'timeline': LinkWithType;
    'user': LinkWithType;
    'securityAdvisories'?: LinkWithType;
    'currentUser'?: LinkWithType;
    'currentUserPublic'?: LinkWithType;
    'currentUserActor'?: LinkWithType;
    'currentUserOrganization'?: LinkWithType;
    'currentUserOrganizations'?: Array<LinkWithType>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "timeline",
            "baseName": "timeline",
            "type": "LinkWithType"
        },
        {
            "name": "user",
            "baseName": "user",
            "type": "LinkWithType"
        },
        {
            "name": "securityAdvisories",
            "baseName": "security_advisories",
            "type": "LinkWithType"
        },
        {
            "name": "currentUser",
            "baseName": "current_user",
            "type": "LinkWithType"
        },
        {
            "name": "currentUserPublic",
            "baseName": "current_user_public",
            "type": "LinkWithType"
        },
        {
            "name": "currentUserActor",
            "baseName": "current_user_actor",
            "type": "LinkWithType"
        },
        {
            "name": "currentUserOrganization",
            "baseName": "current_user_organization",
            "type": "LinkWithType"
        },
        {
            "name": "currentUserOrganizations",
            "baseName": "current_user_organizations",
            "type": "Array<LinkWithType>"
        }    ];

    static getAttributeTypeMap() {
        return FeedLinks.attributeTypeMap;
    }
}
