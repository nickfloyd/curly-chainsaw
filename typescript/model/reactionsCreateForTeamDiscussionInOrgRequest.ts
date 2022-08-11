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

export class ReactionsCreateForTeamDiscussionInOrgRequest {
    /**
    * The [reaction type](https://docs.github.com/rest/reference/reactions#reaction-types) to add to the team discussion.
    */
    'content': ReactionsCreateForTeamDiscussionInOrgRequest.ContentEnum;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "content",
            "baseName": "content",
            "type": "ReactionsCreateForTeamDiscussionInOrgRequest.ContentEnum"
        }    ];

    static getAttributeTypeMap() {
        return ReactionsCreateForTeamDiscussionInOrgRequest.attributeTypeMap;
    }
}

export namespace ReactionsCreateForTeamDiscussionInOrgRequest {
    export enum ContentEnum {
        _1 = <any> '+1',
        _1 = <any> '-1',
        Laugh = <any> 'laugh',
        Confused = <any> 'confused',
        Heart = <any> 'heart',
        Hooray = <any> 'hooray',
        Rocket = <any> 'rocket',
        Eyes = <any> 'eyes'
    }
}