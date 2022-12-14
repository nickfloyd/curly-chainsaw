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
* Update the source for the repository. Must include the branch name and path.
*/
export class ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf {
    /**
    * The repository branch used to publish your site\'s source files.
    */
    'branch': string;
    /**
    * The repository directory that includes the source files for the Pages site. Allowed paths are `/` or `/docs`.
    */
    'path': ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf.PathEnum;

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
            "type": "ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf.PathEnum"
        }    ];

    static getAttributeTypeMap() {
        return ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf.attributeTypeMap;
    }
}

export namespace ReposUpdateInformationAboutPagesSiteRequestSourceAnyOf {
    export enum PathEnum {
        Slash = <any> '/',
        Docs = <any> '/docs'
    }
}
