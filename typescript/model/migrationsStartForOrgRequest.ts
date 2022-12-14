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

export class MigrationsStartForOrgRequest {
    /**
    * A list of arrays indicating which repositories should be migrated.
    */
    'repositories': Array<string>;
    /**
    * Indicates whether repositories should be locked (to prevent manipulation) while migrating data.
    */
    'lockRepositories'?: boolean = false;
    /**
    * Indicates whether metadata should be excluded and only git source should be included for the migration.
    */
    'excludeMetadata'?: boolean = false;
    /**
    * Indicates whether the repository git data should be excluded from the migration.
    */
    'excludeGitData'?: boolean = false;
    /**
    * Indicates whether attachments should be excluded from the migration (to reduce migration archive file size).
    */
    'excludeAttachments'?: boolean = false;
    /**
    * Indicates whether releases should be excluded from the migration (to reduce migration archive file size).
    */
    'excludeReleases'?: boolean = false;
    /**
    * Indicates whether projects owned by the organization or users should be excluded. from the migration.
    */
    'excludeOwnerProjects'?: boolean = false;
    /**
    * Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).
    */
    'orgMetadataOnly'?: boolean = false;
    /**
    * Exclude related items from being returned in the response in order to improve performance of the request. The array can include any of: `\"repositories\"`.
    */
    'exclude'?: Array<MigrationsStartForOrgRequest.ExcludeEnum>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "repositories",
            "baseName": "repositories",
            "type": "Array<string>"
        },
        {
            "name": "lockRepositories",
            "baseName": "lock_repositories",
            "type": "boolean"
        },
        {
            "name": "excludeMetadata",
            "baseName": "exclude_metadata",
            "type": "boolean"
        },
        {
            "name": "excludeGitData",
            "baseName": "exclude_git_data",
            "type": "boolean"
        },
        {
            "name": "excludeAttachments",
            "baseName": "exclude_attachments",
            "type": "boolean"
        },
        {
            "name": "excludeReleases",
            "baseName": "exclude_releases",
            "type": "boolean"
        },
        {
            "name": "excludeOwnerProjects",
            "baseName": "exclude_owner_projects",
            "type": "boolean"
        },
        {
            "name": "orgMetadataOnly",
            "baseName": "org_metadata_only",
            "type": "boolean"
        },
        {
            "name": "exclude",
            "baseName": "exclude",
            "type": "Array<MigrationsStartForOrgRequest.ExcludeEnum>"
        }    ];

    static getAttributeTypeMap() {
        return MigrationsStartForOrgRequest.attributeTypeMap;
    }
}

export namespace MigrationsStartForOrgRequest {
    export enum ExcludeEnum {
        Repositories = <any> 'repositories'
    }
}
