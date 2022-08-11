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
import { AddedToProjectIssueEvent } from './addedToProjectIssueEvent';
import { AddedToProjectIssueEventProjectCard } from './addedToProjectIssueEventProjectCard';
import { CommitComment } from './commitComment';
import { ConvertedNoteToIssueIssueEvent } from './convertedNoteToIssueIssueEvent';
import { DemilestonedIssueEvent } from './demilestonedIssueEvent';
import { GitCommitAuthor } from './gitCommitAuthor';
import { GitCommitParentsInner } from './gitCommitParentsInner';
import { GitCommitTree } from './gitCommitTree';
import { GitCommitVerification } from './gitCommitVerification';
import { GitHubApp1 } from './gitHubApp1';
import { LabeledIssueEvent } from './labeledIssueEvent';
import { LabeledIssueEventLabel } from './labeledIssueEventLabel';
import { LockedIssueEvent } from './lockedIssueEvent';
import { MilestonedIssueEvent } from './milestonedIssueEvent';
import { MilestonedIssueEventMilestone } from './milestonedIssueEventMilestone';
import { MovedColumnInProjectIssueEvent } from './movedColumnInProjectIssueEvent';
import { ReactionRollup } from './reactionRollup';
import { RemovedFromProjectIssueEvent } from './removedFromProjectIssueEvent';
import { RenamedIssueEvent } from './renamedIssueEvent';
import { RenamedIssueEventRename } from './renamedIssueEventRename';
import { ReviewDismissedIssueEvent } from './reviewDismissedIssueEvent';
import { ReviewDismissedIssueEventDismissedReview } from './reviewDismissedIssueEventDismissedReview';
import { ReviewRequestRemovedIssueEvent } from './reviewRequestRemovedIssueEvent';
import { ReviewRequestedIssueEvent } from './reviewRequestedIssueEvent';
import { SimpleUser1 } from './simpleUser1';
import { StateChangeIssueEvent } from './stateChangeIssueEvent';
import { Team } from './team';
import { TimelineAssignedIssueEvent } from './timelineAssignedIssueEvent';
import { TimelineCommentEvent } from './timelineCommentEvent';
import { TimelineCommitCommentedEvent } from './timelineCommitCommentedEvent';
import { TimelineCommittedEvent } from './timelineCommittedEvent';
import { TimelineCrossReferencedEvent } from './timelineCrossReferencedEvent';
import { TimelineCrossReferencedEventSource } from './timelineCrossReferencedEventSource';
import { TimelineLineCommentedEvent } from './timelineLineCommentedEvent';
import { TimelineReviewedEvent } from './timelineReviewedEvent';
import { TimelineReviewedEventLinks } from './timelineReviewedEventLinks';
import { TimelineUnassignedIssueEvent } from './timelineUnassignedIssueEvent';
import { UnlabeledIssueEvent } from './unlabeledIssueEvent';

/**
* Timeline Event
*/
export class TimelineEvent {
    'id': number;
    'nodeId': string;
    'url': string;
    'actor': SimpleUser1;
    'event': string;
    'commitId': string | null;
    'commitUrl': string | null;
    'createdAt': string;
    'performedViaGithubApp': GitHubApp1 | null;
    'label': LabeledIssueEventLabel;
    'milestone': MilestonedIssueEventMilestone;
    'rename': RenamedIssueEventRename;
    'reviewRequester': SimpleUser1;
    'requestedTeam'?: Team;
    'requestedReviewer'?: SimpleUser1;
    'dismissedReview': ReviewDismissedIssueEventDismissedReview;
    'lockReason': string | null;
    'projectCard'?: AddedToProjectIssueEventProjectCard;
    /**
    * The text of the review.
    */
    'body': string | null;
    'bodyText'?: string;
    'bodyHtml'?: string;
    'htmlUrl': string;
    'user': SimpleUser1;
    'updatedAt': Date;
    'issueUrl': string;
    /**
    * How the author is associated with the repository.
    */
    'authorAssociation': TimelineEvent.AuthorAssociationEnum;
    'reactions'?: ReactionRollup;
    'source': TimelineCrossReferencedEventSource;
    /**
    * SHA for the commit
    */
    'sha': string;
    'author': GitCommitAuthor;
    'committer': GitCommitAuthor;
    /**
    * Message describing the purpose of the commit
    */
    'message': string;
    'tree': GitCommitTree;
    'parents': Array<GitCommitParentsInner>;
    'verification': GitCommitVerification;
    'state': string;
    'pullRequestUrl': string;
    'links': TimelineReviewedEventLinks;
    'submittedAt'?: Date;
    'comments'?: Array<CommitComment>;
    'assignee': SimpleUser1;
    'stateReason'?: string | null;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
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
            "name": "url",
            "baseName": "url",
            "type": "string"
        },
        {
            "name": "actor",
            "baseName": "actor",
            "type": "SimpleUser1"
        },
        {
            "name": "event",
            "baseName": "event",
            "type": "string"
        },
        {
            "name": "commitId",
            "baseName": "commit_id",
            "type": "string"
        },
        {
            "name": "commitUrl",
            "baseName": "commit_url",
            "type": "string"
        },
        {
            "name": "createdAt",
            "baseName": "created_at",
            "type": "string"
        },
        {
            "name": "performedViaGithubApp",
            "baseName": "performed_via_github_app",
            "type": "GitHubApp1"
        },
        {
            "name": "label",
            "baseName": "label",
            "type": "LabeledIssueEventLabel"
        },
        {
            "name": "milestone",
            "baseName": "milestone",
            "type": "MilestonedIssueEventMilestone"
        },
        {
            "name": "rename",
            "baseName": "rename",
            "type": "RenamedIssueEventRename"
        },
        {
            "name": "reviewRequester",
            "baseName": "review_requester",
            "type": "SimpleUser1"
        },
        {
            "name": "requestedTeam",
            "baseName": "requested_team",
            "type": "Team"
        },
        {
            "name": "requestedReviewer",
            "baseName": "requested_reviewer",
            "type": "SimpleUser1"
        },
        {
            "name": "dismissedReview",
            "baseName": "dismissed_review",
            "type": "ReviewDismissedIssueEventDismissedReview"
        },
        {
            "name": "lockReason",
            "baseName": "lock_reason",
            "type": "string"
        },
        {
            "name": "projectCard",
            "baseName": "project_card",
            "type": "AddedToProjectIssueEventProjectCard"
        },
        {
            "name": "body",
            "baseName": "body",
            "type": "string"
        },
        {
            "name": "bodyText",
            "baseName": "body_text",
            "type": "string"
        },
        {
            "name": "bodyHtml",
            "baseName": "body_html",
            "type": "string"
        },
        {
            "name": "htmlUrl",
            "baseName": "html_url",
            "type": "string"
        },
        {
            "name": "user",
            "baseName": "user",
            "type": "SimpleUser1"
        },
        {
            "name": "updatedAt",
            "baseName": "updated_at",
            "type": "Date"
        },
        {
            "name": "issueUrl",
            "baseName": "issue_url",
            "type": "string"
        },
        {
            "name": "authorAssociation",
            "baseName": "author_association",
            "type": "TimelineEvent.AuthorAssociationEnum"
        },
        {
            "name": "reactions",
            "baseName": "reactions",
            "type": "ReactionRollup"
        },
        {
            "name": "source",
            "baseName": "source",
            "type": "TimelineCrossReferencedEventSource"
        },
        {
            "name": "sha",
            "baseName": "sha",
            "type": "string"
        },
        {
            "name": "author",
            "baseName": "author",
            "type": "GitCommitAuthor"
        },
        {
            "name": "committer",
            "baseName": "committer",
            "type": "GitCommitAuthor"
        },
        {
            "name": "message",
            "baseName": "message",
            "type": "string"
        },
        {
            "name": "tree",
            "baseName": "tree",
            "type": "GitCommitTree"
        },
        {
            "name": "parents",
            "baseName": "parents",
            "type": "Array<GitCommitParentsInner>"
        },
        {
            "name": "verification",
            "baseName": "verification",
            "type": "GitCommitVerification"
        },
        {
            "name": "state",
            "baseName": "state",
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
            "name": "comments",
            "baseName": "comments",
            "type": "Array<CommitComment>"
        },
        {
            "name": "assignee",
            "baseName": "assignee",
            "type": "SimpleUser1"
        },
        {
            "name": "stateReason",
            "baseName": "state_reason",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return TimelineEvent.attributeTypeMap;
    }
}

export namespace TimelineEvent {
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
