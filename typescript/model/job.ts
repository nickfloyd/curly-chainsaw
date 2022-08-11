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
import { JobStepsInner } from './jobStepsInner';

/**
* Information of a job execution in a workflow run
*/
export class Job {
    /**
    * The id of the job.
    */
    'id': number;
    /**
    * The id of the associated workflow run.
    */
    'runId': number;
    'runUrl': string;
    /**
    * Attempt number of the associated workflow run, 1 for first attempt and higher if the workflow was re-run.
    */
    'runAttempt'?: number;
    'nodeId': string;
    /**
    * The SHA of the commit that is being run.
    */
    'headSha': string;
    'url': string;
    'htmlUrl': string | null;
    /**
    * The phase of the lifecycle that the job is currently in.
    */
    'status': Job.StatusEnum;
    /**
    * The outcome of the job.
    */
    'conclusion': string | null;
    /**
    * The time that the job started, in ISO 8601 format.
    */
    'startedAt': Date;
    /**
    * The time that the job finished, in ISO 8601 format.
    */
    'completedAt': Date | null;
    /**
    * The name of the job.
    */
    'name': string;
    /**
    * Steps in this job.
    */
    'steps'?: Array<JobStepsInner>;
    'checkRunUrl': string;
    /**
    * Labels for the workflow job. Specified by the \"runs_on\" attribute in the action\'s workflow file.
    */
    'labels': Array<string>;
    /**
    * The ID of the runner to which this job has been assigned. (If a runner hasn\'t yet been assigned, this will be null.)
    */
    'runnerId': number | null;
    /**
    * The name of the runner to which this job has been assigned. (If a runner hasn\'t yet been assigned, this will be null.)
    */
    'runnerName': string | null;
    /**
    * The ID of the runner group to which this job has been assigned. (If a runner hasn\'t yet been assigned, this will be null.)
    */
    'runnerGroupId': number | null;
    /**
    * The name of the runner group to which this job has been assigned. (If a runner hasn\'t yet been assigned, this will be null.)
    */
    'runnerGroupName': string | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "id",
            "baseName": "id",
            "type": "number"
        },
        {
            "name": "runId",
            "baseName": "run_id",
            "type": "number"
        },
        {
            "name": "runUrl",
            "baseName": "run_url",
            "type": "string"
        },
        {
            "name": "runAttempt",
            "baseName": "run_attempt",
            "type": "number"
        },
        {
            "name": "nodeId",
            "baseName": "node_id",
            "type": "string"
        },
        {
            "name": "headSha",
            "baseName": "head_sha",
            "type": "string"
        },
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "htmlUrl",
            "baseName": "html_url",
            "type": "string"
        },
        {
            "name": "status",
            "baseName": "status",
            "type": "Job.StatusEnum"
        },
        {
            "name": "conclusion",
            "baseName": "conclusion",
            "type": "string"
        },
        {
            "name": "startedAt",
            "baseName": "started_at",
            "type": "Date"
        },
        {
            "name": "completedAt",
            "baseName": "completed_at",
            "type": "Date"
        },
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "steps",
            "baseName": "steps",
            "type": "Array<JobStepsInner>"
        },
        {
            "name": "checkRunUrl",
            "baseName": "check_run_url",
            "type": "string"
        },
        {
            "name": "labels",
            "baseName": "labels",
            "type": "Array<string>"
        },
        {
            "name": "runnerId",
            "baseName": "runner_id",
            "type": "number"
        },
        {
            "name": "runnerName",
            "baseName": "runner_name",
            "type": "string"
        },
        {
            "name": "runnerGroupId",
            "baseName": "runner_group_id",
            "type": "number"
        },
        {
            "name": "runnerGroupName",
            "baseName": "runner_group_name",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return Job.attributeTypeMap;
    }
}

export namespace Job {
    export enum StatusEnum {
        Queued = <any> 'queued',
        InProgress = <any> 'in_progress',
        Completed = <any> 'completed'
    }
}