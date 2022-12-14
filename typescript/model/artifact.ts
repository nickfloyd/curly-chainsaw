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
import { ArtifactWorkflowRun } from './artifactWorkflowRun';

/**
* An artifact
*/
export class Artifact {
    'id': number;
    'nodeId': string;
    /**
    * The name of the artifact.
    */
    'name': string;
    /**
    * The size in bytes of the artifact.
    */
    'sizeInBytes': number;
    'url': string;
    'archiveDownloadUrl': string;
    /**
    * Whether or not the artifact has expired.
    */
    'expired': boolean;
    'createdAt': Date | null;
    'expiresAt': Date | null;
    'updatedAt': Date | null;
    'workflowRun'?: ArtifactWorkflowRun | null;

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
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "sizeInBytes",
            "baseName": "size_in_bytes",
            "type": "number"
        },
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "archiveDownloadUrl",
            "baseName": "archive_download_url",
            "type": "string"
        },
        {
            "name": "expired",
            "baseName": "expired",
            "type": "boolean"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "Date"
        },
        {
            "name": "expiresAt",
            "baseName": "expires_at",
            "type": "Date"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "Date"
        },
        {
            "name": "workflowRun",
            "baseName": "workflow_run",
            "type": "ArtifactWorkflowRun"
        }    ];

    static getAttributeTypeMap() {
        return Artifact.attributeTypeMap;
    }
}

