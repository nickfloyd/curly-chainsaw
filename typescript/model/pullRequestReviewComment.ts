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
import { PullRequestReviewCommentLinks } from './pullRequestReviewCommentLinks';
import { ReactionRollup } from './reactionRollup';
import { SimpleUser1 } from './simpleUser1';

/**
* Pull Request Review Comments are comments on a portion of the Pull Request\'s diff.
*/
export class PullRequestReviewComment {
    /**
    * URL for the pull request review comment
    */
    'url': string;
    /**
    * The ID of the pull request review to which the comment belongs.
    */
    'pullRequestReviewId': number | null;
    /**
    * The ID of the pull request review comment.
    */
    'id': number;
    /**
    * The node ID of the pull request review comment.
    */
    'nodeId': string;
    /**
    * The diff of the line that the comment refers to.
    */
    'diffHunk': string;
    /**
    * The relative path of the file to which the comment applies.
    */
    'path': string;
    /**
    * The line index in the diff to which the comment applies. This field is deprecated; use `line` instead.
    */
    'position': number;
    /**
    * The index of the original line in the diff to which the comment applies. This field is deprecated; use `original_line` instead.
    */
    'originalPosition': number;
    /**
    * The SHA of the commit to which the comment applies.
    */
    'commitId': string;
    /**
    * The SHA of the original commit to which the comment applies.
    */
    'originalCommitId': string;
    /**
    * The comment ID to reply to.
    */
    'inReplyToId'?: number;
    'user': SimpleUser1;
    /**
    * The text of the comment.
    */
    'body': string;
    'createdAt': Date;
    'updatedAt': Date;
    /**
    * HTML URL for the pull request review comment.
    */
    'htmlUrl': string;
    /**
    * URL for the pull request that the review comment belongs to.
    */
    'pullRequestUrl': string;
    /**
    * How the author is associated with the repository.
    */
    'authorAssociation': PullRequestReviewComment.AuthorAssociationEnum;
    'links': PullRequestReviewCommentLinks;
    /**
    * The first line of the range for a multi-line comment.
    */
    'startLine'?: number | null;
    /**
    * The first line of the range for a multi-line comment.
    */
    'originalStartLine'?: number | null;
    /**
    * The side of the first line of the range for a multi-line comment.
    */
    'startSide'?: PullRequestReviewComment.StartSideEnum = PullRequestReviewComment.StartSideEnum.Right;
    /**
    * The line of the blob to which the comment applies. The last line of the range for a multi-line comment
    */
    'line'?: number;
    /**
    * The line of the blob to which the comment applies. The last line of the range for a multi-line comment
    */
    'originalLine'?: number;
    /**
    * The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment
    */
    'side'?: PullRequestReviewComment.SideEnum = PullRequestReviewComment.SideEnum.Right;
    'reactions'?: ReactionRollup;
    'bodyHtml'?: string;
    'bodyText'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "pullRequestReviewId",
            "baseName": "pull_request_review_id",
            "type": "number"
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
            "name": "diffHunk",
            "baseName": "diff_hunk",
            "type": "string"
        },
        {
            "name": "path",
            "baseName": "path",
            "type": "string"
        },
        {
            "name": "position",
            "baseName": "position",
            "type": "number"
        },
        {
            "name": "originalPosition",
            "baseName": "original_position",
            "type": "number"
        },
        {
            "name": "commitId",
            "baseName": "commit_id",
            "type": "string"
        },
        {
            "name": "originalCommitId",
            "baseName": "original_commit_id",
            "type": "string"
        },
        {
            "name": "inReplyToId",
            "baseName": "in_reply_to_id",
            "type": "number"
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
            "name": "authorAssociation",
            "baseName": "author_association",
            "type": "PullRequestReviewComment.AuthorAssociationEnum"
        },
        {
            "name": "links",
            "baseName": "_links",
            "type": "PullRequestReviewCommentLinks"
        },
        {
            "name": "startLine",
            "baseName": "start_line",
            "type": "number"
        },
        {
            "name": "originalStartLine",
            "baseName": "original_start_line",
            "type": "number"
        },
        {
            "name": "startSide",
            "baseName": "start_side",
            "type": "PullRequestReviewComment.StartSideEnum"
        },
        {
            "name": "line",
            "baseName": "line",
            "type": "number"
        },
        {
            "name": "originalLine",
            "baseName": "original_line",
            "type": "number"
        },
        {
            "name": "side",
            "baseName": "side",
            "type": "PullRequestReviewComment.SideEnum"
        },
        {
            "name": "reactions",
            "baseName": "reactions",
            "type": "ReactionRollup"
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
        }    ];

    static getAttributeTypeMap() {
        return PullRequestReviewComment.attributeTypeMap;
    }
}

export namespace PullRequestReviewComment {
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
    export enum StartSideEnum {
        Left = <any> 'LEFT',
        Right = <any> 'RIGHT'
    }
    export enum SideEnum {
        Left = <any> 'LEFT',
        Right = <any> 'RIGHT'
    }
}
