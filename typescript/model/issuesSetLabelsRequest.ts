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
import { IssuesSetLabelsRequestOneOf } from './issuesSetLabelsRequestOneOf';
import { IssuesSetLabelsRequestOneOf1 } from './issuesSetLabelsRequestOneOf1';
import { IssuesSetLabelsRequestOneOf1LabelsInner } from './issuesSetLabelsRequestOneOf1LabelsInner';

export class IssuesSetLabelsRequest {
    'labels'?: Array<IssuesSetLabelsRequestOneOf1LabelsInner>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "labels",
            "baseName": "labels",
            "type": "Array<IssuesSetLabelsRequestOneOf1LabelsInner>"
        }    ];

    static getAttributeTypeMap() {
        return IssuesSetLabelsRequest.attributeTypeMap;
    }
}

