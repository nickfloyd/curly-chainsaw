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
import { GitHubApp1 } from './gitHubApp1';
import { SimpleUser } from './simpleUser';

/**
* The status of a deployment.
*/
export class DeploymentStatus {
    'url': string;
    'id': number;
    'nodeId': string;
    /**
    * The state of the status.
    */
    'state': DeploymentStatus.StateEnum;
    'creator': SimpleUser | null;
    /**
    * A short description of the status.
    */
    'description': string = '';
    /**
    * The environment of the deployment that the status is for.
    */
    'environment'?: string = '';
    /**
    * Deprecated: the URL to associate with this status.
    */
    'targetUrl': string = '';
    'createdAt': Date;
    'updatedAt': Date;
    'deploymentUrl': string;
    'repositoryUrl': string;
    /**
    * The URL for accessing your environment.
    */
    'environmentUrl'?: string = '';
    /**
    * The URL to associate with this status.
    */
    'logUrl'?: string = '';
    'performedViaGithubApp'?: GitHubApp1 | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
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
            "name": "state",
            "baseName": "state",
            "type": "DeploymentStatus.StateEnum"
        },
        {
            "name": "creator",
            "baseName": "creator",
            "type": "SimpleUser"
        },
        {
            "name": "description",
            "baseName": "description",
            "type": "string"
        },
        {
            "name": "environment",
            "baseName": "environment",
            "type": "string"
        },
        {
            "name": "targetUrl",
            "baseName": "target_url",
            "type": "string"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "Date"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "Date"
        },
        {
            "name": "deploymentUrl",
            "baseName": "deployment_url",
            "type": "string"
        },
        {
            "name": "repositoryUrl",
            "baseName": "repository_url",
            "type": "string"
        },
        {
            "name": "environmentUrl",
            "baseName": "environment_url",
            "type": "string"
        },
        {
            "name": "logUrl",
            "baseName": "log_url",
            "type": "string"
        },
        {
            "name": "performedViaGithubApp",
            "baseName": "performed_via_github_app",
            "type": "GitHubApp1"
        }    ];

    static getAttributeTypeMap() {
        return DeploymentStatus.attributeTypeMap;
    }
}

export namespace DeploymentStatus {
    export enum StateEnum {
        Error = <any> 'error',
        Failure = <any> 'failure',
        Inactive = <any> 'inactive',
        Pending = <any> 'pending',
        Success = <any> 'success',
        Queued = <any> 'queued',
        InProgress = <any> 'in_progress'
    }
}
