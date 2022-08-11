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
import { DeploymentPayload } from './deploymentPayload';
import { GitHubApp1 } from './gitHubApp1';
import { SimpleUser } from './simpleUser';

/**
* A request for a specific ref(branch,sha,tag) to be deployed
*/
export class Deployment {
    'url': string;
    /**
    * Unique identifier of the deployment
    */
    'id': number;
    'nodeId': string;
    'sha': string;
    /**
    * The ref to deploy. This can be a branch, tag, or sha.
    */
    'ref': string;
    /**
    * Parameter to specify a task to execute
    */
    'task': string;
    'payload': DeploymentPayload;
    'originalEnvironment'?: string;
    /**
    * Name for the target deployment environment.
    */
    'environment': string;
    'description': string | null;
    'creator': SimpleUser | null;
    'createdAt': Date;
    'updatedAt': Date;
    'statusesUrl': string;
    'repositoryUrl': string;
    /**
    * Specifies if the given environment is will no longer exist at some point in the future. Default: false.
    */
    'transientEnvironment'?: boolean;
    /**
    * Specifies if the given environment is one that end-users directly interact with. Default: false.
    */
    'productionEnvironment'?: boolean;
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
            "name": "sha",
            "baseName": "sha",
            "type": "string"
        },
        {
            "name": "ref",
            "baseName": "ref",
            "type": "string"
        },
        {
            "name": "task",
            "baseName": "task",
            "type": "string"
        },
        {
            "name": "payload",
            "baseName": "payload",
            "type": "DeploymentPayload"
        },
        {
            "name": "originalEnvironment",
            "baseName": "original_environment",
            "type": "string"
        },
        {
            "name": "environment",
            "baseName": "environment",
            "type": "string"
        },
        {
            "name": "description",
            "baseName": "description",
            "type": "string"
        },
        {
            "name": "creator",
            "baseName": "creator",
            "type": "SimpleUser"
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
            "name": "statusesUrl",
            "baseName": "statuses_url",
            "type": "string"
        },
        {
            "name": "repositoryUrl",
            "baseName": "repository_url",
            "type": "string"
        },
        {
            "name": "transientEnvironment",
            "baseName": "transient_environment",
            "type": "boolean"
        },
        {
            "name": "productionEnvironment",
            "baseName": "production_environment",
            "type": "boolean"
        },
        {
            "name": "performedViaGithubApp",
            "baseName": "performed_via_github_app",
            "type": "GitHubApp1"
        }    ];

    static getAttributeTypeMap() {
        return Deployment.attributeTypeMap;
    }
}
