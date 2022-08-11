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
import { WorkflowUsageBillableUBUNTU } from './workflowUsageBillableUBUNTU';

export class WorkflowUsageBillable {
    'uBUNTU'?: WorkflowUsageBillableUBUNTU;
    'mACOS'?: WorkflowUsageBillableUBUNTU;
    'wINDOWS'?: WorkflowUsageBillableUBUNTU;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "uBUNTU",
            "baseName": "UBUNTU",
            "type": "WorkflowUsageBillableUBUNTU"
        },
        {
            "name": "mACOS",
            "baseName": "MACOS",
            "type": "WorkflowUsageBillableUBUNTU"
        },
        {
            "name": "wINDOWS",
            "baseName": "WINDOWS",
            "type": "WorkflowUsageBillableUBUNTU"
        }    ];

    static getAttributeTypeMap() {
        return WorkflowUsageBillable.attributeTypeMap;
    }
}
