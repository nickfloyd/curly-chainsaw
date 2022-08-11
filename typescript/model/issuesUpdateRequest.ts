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
import { IssuesCreateRequestLabelsInner } from './issuesCreateRequestLabelsInner';
import { IssuesUpdateRequestMilestone } from './issuesUpdateRequestMilestone';
import { IssuesUpdateRequestTitle } from './issuesUpdateRequestTitle';

export class IssuesUpdateRequest {
    'title'?: IssuesUpdateRequestTitle | null;
    /**
    * The contents of the issue.
    */
    'body'?: string | null;
    /**
    * Login for the user that this issue should be assigned to. **This field is deprecated.**
    */
    'assignee'?: string | null;
    /**
    * State of the issue. Either `open` or `closed`.
    */
    'state'?: IssuesUpdateRequest.StateEnum;
    'milestone'?: IssuesUpdateRequestMilestone | null;
    /**
    * Labels to associate with this issue. Pass one or more Labels to _replace_ the set of Labels on this Issue. Send an empty array (`[]`) to clear all Labels from the Issue. _NOTE: Only users with push access can set labels for issues. Labels are silently dropped otherwise._
    */
    'labels'?: Array<IssuesCreateRequestLabelsInner>;
    /**
    * Logins for Users to assign to this issue. Pass one or more user logins to _replace_ the set of assignees on this Issue. Send an empty array (`[]`) to clear all assignees from the Issue. _NOTE: Only users with push access can set assignees for new issues. Assignees are silently dropped otherwise._
    */
    'assignees'?: Array<string>;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "title",
            "baseName": "title",
            "type": "IssuesUpdateRequestTitle"
        },
        {
            "name": "body",
            "baseName": "body",
            "type": "string"
        },
        {
            "name": "assignee",
            "baseName": "assignee",
            "type": "string"
        },
        {
            "name": "state",
            "baseName": "state",
            "type": "IssuesUpdateRequest.StateEnum"
        },
        {
            "name": "milestone",
            "baseName": "milestone",
            "type": "IssuesUpdateRequestMilestone"
        },
        {
            "name": "labels",
            "baseName": "labels",
            "type": "Array<IssuesCreateRequestLabelsInner>"
        },
        {
            "name": "assignees",
            "baseName": "assignees",
            "type": "Array<string>"
        }    ];

    static getAttributeTypeMap() {
        return IssuesUpdateRequest.attributeTypeMap;
    }
}

export namespace IssuesUpdateRequest {
    export enum StateEnum {
        Open = <any> 'open',
        Closed = <any> 'closed'
    }
}
