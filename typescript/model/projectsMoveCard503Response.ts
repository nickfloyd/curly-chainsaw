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
import { ProjectsMoveCard503ResponseErrorsInner } from './projectsMoveCard503ResponseErrorsInner';

export class ProjectsMoveCard503Response {
    'code'?: string;
    'message'?: string;
    'documentationUrl'?: string;
    'errors'?: Array<ProjectsMoveCard503ResponseErrorsInner>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "code",
            "baseName": "code",
            "type": "string"
        },
        {
            "name": "message",
            "baseName": "message",
            "type": "string"
        },
        {
            "name": "documentationUrl",
            "baseName": "documentation_url",
            "type": "string"
        },
        {
            "name": "errors",
            "baseName": "errors",
            "type": "Array<ProjectsMoveCard503ResponseErrorsInner>"
        }    ];

    static getAttributeTypeMap() {
        return ProjectsMoveCard503Response.attributeTypeMap;
    }
}

