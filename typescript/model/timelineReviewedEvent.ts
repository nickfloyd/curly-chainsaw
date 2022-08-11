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
import { SimpleUser1 } from './simpleUser1';
import { TimelineReviewedEventLinks } from './timelineReviewedEventLinks';

/**
* Timeline Reviewed Event
*/
export class TimelineReviewedEvent {
    'event': string;
    /**
    * Unique identifier of the review
    */
    'id': number;
    'nodeId': string;
    'user': SimpleUser1;
    /**
    * The text of the review.
    */
    'body': string | null;
    'state': string;
    'htmlUrl': string;
    'pullRequestUrl': string;
    'links': TimelineReviewedEventLinks;
    'submittedAt'?: Date;
    /**
    * A commit SHA for the review.
    */
    'commitId': string;
    'bodyHtml'?: string;
    'bodyText'?: string;
    /**
    * How the author is associated with the repository.
    */
    'authorAssociation': TimelineReviewedEvent.AuthorAssociationEnum;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "event",
            "baseName": "event",
            "type": "string"
        },
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
            "name": "user",
            "baseName": "user",
            "type": "SimpleUser1"
        },
        {
            "name": "body",
            "baseName": "body",
            "type": "string"
        },
        {
            "name": "state",
            "baseName": "state",
            "type": "string"
        },
        {
            "name": "htmlUrl",
            "baseName": "html_url",
            "type": "string"
        },
        {
            "name": "pullRequestUrl",
            "baseName": "pull_request_url",
            "type": "string"
        },
        {
            "name": "links",
            "baseName": "_links",
            "type": "TimelineReviewedEventLinks"
        },
        {
            "name": "submittedAt",
            "baseName": "submitted_at",
            "type": "Date"
        },
        {
            "name": "commitId",
            "baseName": "commit_id",
            "type": "string"
        },
        {
            "name": "bodyHtml",
            "baseName": "body_html",
            "type": "string"
        },
        {
            "name": "bodyText",
            "baseName": "body_text",
            "type": "string"
        },
        {
            "name": "authorAssociation",
            "baseName": "author_association",
            "type": "TimelineReviewedEvent.AuthorAssociationEnum"
        }    ];

    static getAttributeTypeMap() {
        return TimelineReviewedEvent.attributeTypeMap;
    }
}

export namespace TimelineReviewedEvent {
    export enum AuthorAssociationEnum {
        Collaborator = <any> 'COLLABORATOR',
        Contributor = <any> 'CONTRIBUTOR',
        FirstTimer = <any> 'FIRST_TIMER',
        FirstTimeContributor = <any> 'FIRST_TIME_CONTRIBUTOR',
        Mannequin = <any> 'MANNEQUIN',
        Member = <any> 'MEMBER',
        None = <any> 'NONE',
        Owner = <any> 'OWNER'
    }
}
