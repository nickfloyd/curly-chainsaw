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
import { ReposCreateDeploymentRequestPayload } from './reposCreateDeploymentRequestPayload';

export class ReposCreateDeploymentRequest {
    /**
    * The ref to deploy. This can be a branch, tag, or SHA.
    */
    'ref': string;
    /**
    * Specifies a task to execute (e.g., `deploy` or `deploy:migrations`).
    */
    'task'?: string = 'deploy';
    /**
    * Attempts to automatically merge the default branch into the requested ref, if it\'s behind the default branch.
    */
    'autoMerge'?: boolean = true;
    /**
    * The [status](https://docs.github.com/rest/commits/statuses) contexts to verify against commit status checks. If you omit this parameter, GitHub verifies all unique contexts before creating a deployment. To bypass checking entirely, pass an empty array. Defaults to all unique contexts.
    */
    'requiredContexts'?: Array<string>;
    'payload'?: ReposCreateDeploymentRequestPayload;
    /**
    * Name for the target deployment environment (e.g., `production`, `staging`, `qa`).
    */
    'environment'?: string = 'production';
    /**
    * Short description of the deployment.
    */
    'description'?: string | null = '';
    /**
    * Specifies if the given environment is specific to the deployment and will no longer exist at some point in the future. Default: `false`
    */
    'transientEnvironment'?: boolean = false;
    /**
    * Specifies if the given environment is one that end-users directly interact with. Default: `true` when `environment` is `production` and `false` otherwise.
    */
    'productionEnvironment'?: boolean;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
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
            "name": "autoMerge",
            "baseName": "auto_merge",
            "type": "boolean"
        },
        {
            "name": "requiredContexts",
            "baseName": "required_contexts",
            "type": "Array<string>"
        },
        {
            "name": "payload",
            "baseName": "payload",
            "type": "ReposCreateDeploymentRequestPayload"
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
            "name": "transientEnvironment",
            "baseName": "transient_environment",
            "type": "boolean"
        },
        {
            "name": "productionEnvironment",
            "baseName": "production_environment",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return ReposCreateDeploymentRequest.attributeTypeMap;
    }
}
