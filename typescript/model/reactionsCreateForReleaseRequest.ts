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

export class ReactionsCreateForReleaseRequest {
    /**
    * The [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types) to add to the release.
    */
    'content': ReactionsCreateForReleaseRequest.ContentEnum;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "content",
            "baseName": "content",
            "type": "ReactionsCreateForReleaseRequest.ContentEnum"
        }    ];

    static getAttributeTypeMap() {
        return ReactionsCreateForReleaseRequest.attributeTypeMap;
    }
}

export namespace ReactionsCreateForReleaseRequest {
    export enum ContentEnum {
        _1 = <any> '+1',
        Laugh = <any> 'laugh',
        Heart = <any> 'heart',
        Hooray = <any> 'hooray',
        Rocket = <any> 'rocket',
        Eyes = <any> 'eyes'
    }
}
