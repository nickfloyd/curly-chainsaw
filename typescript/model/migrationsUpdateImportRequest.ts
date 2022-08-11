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

export class MigrationsUpdateImportRequest {
    /**
    * The username to provide to the originating repository.
    */
    'vcsUsername'?: string;
    /**
    * The password to provide to the originating repository.
    */
    'vcsPassword'?: string;
    /**
    * The type of version control system you are migrating from.
    */
    'vcs'?: MigrationsUpdateImportRequest.VcsEnum;
    /**
    * For a tfvc import, the name of the project that is being imported.
    */
    'tfvcProject'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "vcsUsername",
            "baseName": "vcs_username",
            "type": "string"
        },
        {
            "name": "vcsPassword",
            "baseName": "vcs_password",
            "type": "string"
        },
        {
            "name": "vcs",
            "baseName": "vcs",
            "type": "MigrationsUpdateImportRequest.VcsEnum"
        },
        {
            "name": "tfvcProject",
            "baseName": "tfvc_project",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return MigrationsUpdateImportRequest.attributeTypeMap;
    }
}

export namespace MigrationsUpdateImportRequest {
    export enum VcsEnum {
        Subversion = <any> 'subversion',
        Tfvc = <any> 'tfvc',
        Git = <any> 'git',
        Mercurial = <any> 'mercurial'
    }
}
