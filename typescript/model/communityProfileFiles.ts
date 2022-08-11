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
import { CodeOfConductSimple1 } from './codeOfConductSimple1';
import { CommunityHealthFile } from './communityHealthFile';
import { LicenseSimple } from './licenseSimple';

export class CommunityProfileFiles {
    'codeOfConduct': CodeOfConductSimple1 | null;
    'codeOfConductFile': CommunityHealthFile | null;
    'license': LicenseSimple | null;
    'contributing': CommunityHealthFile | null;
    'readme': CommunityHealthFile | null;
    'issueTemplate': CommunityHealthFile | null;
    'pullRequestTemplate': CommunityHealthFile | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "codeOfConduct",
            "baseName": "code_of_conduct",
            "type": "CodeOfConductSimple1"
        },
        {
            "name": "codeOfConductFile",
            "baseName": "code_of_conduct_file",
            "type": "CommunityHealthFile"
        },
        {
            "name": "license",
            "baseName": "license",
            "type": "LicenseSimple"
        },
        {
            "name": "contributing",
            "baseName": "contributing",
            "type": "CommunityHealthFile"
        },
        {
            "name": "readme",
            "baseName": "readme",
            "type": "CommunityHealthFile"
        },
        {
            "name": "issueTemplate",
            "baseName": "issue_template",
            "type": "CommunityHealthFile"
        },
        {
            "name": "pullRequestTemplate",
            "baseName": "pull_request_template",
            "type": "CommunityHealthFile"
        }    ];

    static getAttributeTypeMap() {
        return CommunityProfileFiles.attributeTypeMap;
    }
}
