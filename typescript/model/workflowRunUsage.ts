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
import { WorkflowRunUsageBillable } from './workflowRunUsageBillable';

/**
* Workflow Run Usage
*/
export class WorkflowRunUsage {
    'billable': WorkflowRunUsageBillable;
    'runDurationMs'?: number;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "billable",
            "baseName": "billable",
            "type": "WorkflowRunUsageBillable"
        },
        {
            "name": "runDurationMs",
            "baseName": "run_duration_ms",
            "type": "number"
        }    ];

    static getAttributeTypeMap() {
        return WorkflowRunUsage.attributeTypeMap;
    }
}
