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
import { DependencyGraphDiffInnerVulnerabilitiesInner } from './dependencyGraphDiffInnerVulnerabilitiesInner';

export class DependencyGraphDiffInner {
    'changeType': DependencyGraphDiffInner.ChangeTypeEnum;
    'manifest': string;
    'ecosystem': string;
    'name': string;
    'version': string;
    'packageUrl': string | null;
    'license': string | null;
    'sourceRepositoryUrl': string | null;
    'vulnerabilities': Array<DependencyGraphDiffInnerVulnerabilitiesInner>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "changeType",
            "baseName": "change_type",
            "type": "DependencyGraphDiffInner.ChangeTypeEnum"
        },
        {
            "name": "manifest",
            "baseName": "manifest",
            "type": "string"
        },
        {
            "name": "ecosystem",
            "baseName": "ecosystem",
            "type": "string"
        },
        {
            "name": "name",
            "baseName": "name",
            "type": "string"
        },
        {
            "name": "version",
            "baseName": "version",
            "type": "string"
        },
        {
            "name": "packageUrl",
            "baseName": "package_url",
            "type": "string"
        },
        {
            "name": "license",
            "baseName": "license",
            "type": "string"
        },
        {
            "name": "sourceRepositoryUrl",
            "baseName": "source_repository_url",
            "type": "string"
        },
        {
            "name": "vulnerabilities",
            "baseName": "vulnerabilities",
            "type": "Array<DependencyGraphDiffInnerVulnerabilitiesInner>"
        }    ];

    static getAttributeTypeMap() {
        return DependencyGraphDiffInner.attributeTypeMap;
    }
}

export namespace DependencyGraphDiffInner {
    export enum ChangeTypeEnum {
        Added = <any> 'added',
        Removed = <any> 'removed'
    }
}
