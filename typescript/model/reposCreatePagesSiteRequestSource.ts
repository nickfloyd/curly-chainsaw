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

/**
* The source branch and directory used to publish your Pages site.
*/
export class ReposCreatePagesSiteRequestSource {
    /**
    * The repository branch used to publish your site\'s source files.
    */
    'branch': string;
    /**
    * The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`. Default: `/`
    */
    'path'?: ReposCreatePagesSiteRequestSource.PathEnum = ReposCreatePagesSiteRequestSource.PathEnum.Slash;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "branch",
            "baseName": "branch",
            "type": "string"
        },
        {
            "name": "path",
            "baseName": "path",
            "type": "ReposCreatePagesSiteRequestSource.PathEnum"
        }    ];

    static getAttributeTypeMap() {
        return ReposCreatePagesSiteRequestSource.attributeTypeMap;
    }
}

export namespace ReposCreatePagesSiteRequestSource {
    export enum PathEnum {
        Slash = <any> '/',
        Docs = <any> '/docs'
    }
}
