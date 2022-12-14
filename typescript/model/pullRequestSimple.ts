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
import { AutoMerge } from './autoMerge';
import { Milestone } from './milestone';
import { PullRequestSimpleHead } from './pullRequestSimpleHead';
import { PullRequestSimpleLabelsInner } from './pullRequestSimpleLabelsInner';
import { PullRequestSimpleLinks } from './pullRequestSimpleLinks';
import { SimpleUser } from './simpleUser';
import { SimpleUser1 } from './simpleUser1';
import { Team } from './team';

/**
* Pull Request Simple
*/
export class PullRequestSimple {
    'url': string;
    'id': number;
    'nodeId': string;
    'htmlUrl': string;
    'diffUrl': string;
    'patchUrl': string;
    'issueUrl': string;
    'commitsUrl': string;
    'reviewCommentsUrl': string;
    'reviewCommentUrl': string;
    'commentsUrl': string;
    'statusesUrl': string;
    'number': number;
    'state': string;
    'locked': boolean;
    'title': string;
    'user': SimpleUser | null;
    'body': string | null;
    'labels': Array<PullRequestSimpleLabelsInner>;
    'milestone': Milestone | null;
    'activeLockReason'?: string | null;
    'createdAt': Date;
    'updatedAt': Date;
    'closedAt': Date | null;
    'mergedAt': Date | null;
    'mergeCommitSha': string | null;
    'assignee': SimpleUser | null;
    'assignees'?: Array<SimpleUser1> | null;
    'requestedReviewers'?: Array<SimpleUser1> | null;
    'requestedTeams'?: Array<Team> | null;
    'head': PullRequestSimpleHead;
    'base': PullRequestSimpleHead;
    'links': PullRequestSimpleLinks;
    /**
    * How the author is associated with the repository.
    */
    'authorAssociation': PullRequestSimple.AuthorAssociationEnum;
    'autoMerge': AutoMerge | null;
    /**
    * Indicates whether or not the pull request is a draft.
    */
    'draft'?: boolean;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "url",
            "baseName": "url",
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
            "name": "htmlUrl",
            "baseName": "html_url",
            "type": "string"
        },
        {
            "name": "diffUrl",
            "baseName": "diff_url",
            "type": "string"
        },
        {
            "name": "patchUrl",
            "baseName": "patch_url",
            "type": "string"
        },
        {
            "name": "issueUrl",
            "baseName": "issue_url",
            "type": "string"
        },
        {
            "name": "commitsUrl",
            "baseName": "commits_url",
            "type": "string"
        },
        {
            "name": "reviewCommentsUrl",
            "baseName": "review_comments_url",
            "type": "string"
        },
        {
            "name": "reviewCommentUrl",
            "baseName": "review_comment_url",
            "type": "string"
        },
        {
            "name": "commentsUrl",
            "baseName": "comments_url",
            "type": "string"
        },
        {
            "name": "statusesUrl",
            "baseName": "statuses_url",
            "type": "string"
        },
        {
            "name": "number",
            "baseName": "number",
            "type": "number"
        },
        {
            "name": "state",
            "baseName": "state",
            "type": "string"
        },
        {
            "name": "locked",
            "baseName": "locked",
            "type": "boolean"
        },
        {
            "name": "title",
            "baseName": "title",
            "type": "string"
        },
        {
            "name": "user",
            "baseName": "user",
            "type": "SimpleUser"
        },
        {
            "name": "body",
            "baseName": "body",
            "type": "string"
        },
        {
            "name": "labels",
            "baseName": "labels",
            "type": "Array<PullRequestSimpleLabelsInner>"
        },
        {
            "name": "milestone",
            "baseName": "milestone",
            "type": "Milestone"
        },
        {
            "name": "activeLockReason",
            "baseName": "active_lock_reason",
            "type": "string"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "Date"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "Date"
        },
        {
            "name": "closedAt",
            "baseName": "closed_at",
            "type": "Date"
        },
        {
            "name": "mergedAt",
            "baseName": "merged_at",
            "type": "Date"
        },
        {
            "name": "mergeCommitSha",
            "baseName": "merge_commit_sha",
            "type": "string"
        },
        {
            "name": "assignee",
            "baseName": "assignee",
            "type": "SimpleUser"
        },
        {
            "name": "assignees",
            "baseName": "assignees",
            "type": "Array<SimpleUser1>"
        },
        {
            "name": "requestedReviewers",
            "baseName": "requested_reviewers",
            "type": "Array<SimpleUser1>"
        },
        {
            "name": "requestedTeams",
            "baseName": "requested_teams",
            "type": "Array<Team>"
        },
        {
            "name": "head",
            "baseName": "head",
            "type": "PullRequestSimpleHead"
        },
        {
            "name": "base",
            "baseName": "base",
            "type": "PullRequestSimpleHead"
        },
        {
            "name": "links",
            "baseName": "_links",
            "type": "PullRequestSimpleLinks"
        },
        {
            "name": "authorAssociation",
            "baseName": "author_association",
            "type": "PullRequestSimple.AuthorAssociationEnum"
        },
        {
            "name": "autoMerge",
            "baseName": "auto_merge",
            "type": "AutoMerge"
        },
        {
            "name": "draft",
            "baseName": "draft",
            "type": "boolean"
        }    ];

    static getAttributeTypeMap() {
        return PullRequestSimple.attributeTypeMap;
    }
}

export namespace PullRequestSimple {
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
