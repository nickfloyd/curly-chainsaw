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
import { CommunityProfileFiles } from './communityProfileFiles';

/**
* Community Profile
*/
export class CommunityProfile {
    'healthPercentage': number;
    'description': string | null;
    'documentation': string | null;
    'files': CommunityProfileFiles;
    'updatedAt': Date | null;
    'contentReportsEnabled'?: boolean;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "healthPercentage",
            "baseName": "health_percentage",
            "type": "number"
        },
        {
            "name": "description",
            "baseName": "description",
            "type": "string"
        },
        {
            "name": "documentation",
            "baseName": "documentation",
            "type": "string"
        },
        {
            "name": "files",
            "baseName": "files",
            "type": "CommunityProfileFiles"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "Date"
        },
        {
            "name": "contentReportsEnabled",
            "baseName": "content_reports_enabled",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return CommunityProfile.attributeTypeMap;
    }
}

