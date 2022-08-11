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
import { EnvironmentProtectionRulesInnerAnyOf } from './environmentProtectionRulesInnerAnyOf';
import { EnvironmentProtectionRulesInnerAnyOf1 } from './environmentProtectionRulesInnerAnyOf1';
import { EnvironmentProtectionRulesInnerAnyOf2 } from './environmentProtectionRulesInnerAnyOf2';
import { PendingDeploymentReviewersInner } from './pendingDeploymentReviewersInner';

export class EnvironmentProtectionRulesInner {
    'id': number;
    'nodeId': string;
    'type': string;
    /**
    * The amount of time to delay a job after the job is initially triggered. The time (in minutes) must be an integer between 0 and 43,200 (30 days).
    */
    'waitTimer'?: number;
    /**
    * The people or teams that may approve jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.
    */
    'reviewers'?: Array<PendingDeploymentReviewersInner>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "id",
            "baseName": "id",
            "type": "number"
        },
        {
            "name": "nodeId",
            "baseName": "node_id",
            "type": "string"
        },
        {
            "name": "type",
            "baseName": "type",
            "type": "string"
        },
        {
            "name": "waitTimer",
            "baseName": "wait_timer",
            "type": "number"
        },
        {
            "name": "reviewers",
            "baseName": "reviewers",
            "type": "Array<PendingDeploymentReviewersInner>"
        }    ];

    static getAttributeTypeMap() {
        return EnvironmentProtectionRulesInner.attributeTypeMap;
    }
}

