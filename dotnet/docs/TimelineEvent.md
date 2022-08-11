# Org.OpenAPITools.Model.TimelineEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | 
**NodeId** | **string** |  | 
**Url** | **string** |  | 
**Actor** | [**SimpleUser1**](SimpleUser1.md) |  | 
**Event** | **string** |  | 
**CommitId** | **string** |  | 
**CommitUrl** | **string** |  | 
**CreatedAt** | **string** |  | 
**PerformedViaGithubApp** | [**GitHubApp1**](GitHubApp1.md) |  | 
**Label** | [**LabeledIssueEventLabel**](LabeledIssueEventLabel.md) |  | 
**Milestone** | [**MilestonedIssueEventMilestone**](MilestonedIssueEventMilestone.md) |  | 
**Rename** | [**RenamedIssueEventRename**](RenamedIssueEventRename.md) |  | 
**ReviewRequester** | [**SimpleUser1**](SimpleUser1.md) |  | 
**RequestedTeam** | [**Team**](Team.md) |  | [optional] 
**RequestedReviewer** | [**SimpleUser1**](SimpleUser1.md) |  | [optional] 
**DismissedReview** | [**ReviewDismissedIssueEventDismissedReview**](ReviewDismissedIssueEventDismissedReview.md) |  | 
**LockReason** | **string** |  | 
**ProjectCard** | [**AddedToProjectIssueEventProjectCard**](AddedToProjectIssueEventProjectCard.md) |  | [optional] 
**Body** | **string** | The text of the review. | 
**BodyText** | **string** |  | [optional] 
**BodyHtml** | **string** |  | [optional] 
**HtmlUrl** | **string** |  | 
**User** | [**SimpleUser1**](SimpleUser1.md) |  | 
**UpdatedAt** | **DateTime?** |  | 
**IssueUrl** | **string** |  | 
**AuthorAssociation** | **string** | How the author is associated with the repository. | 
**Reactions** | [**ReactionRollup**](ReactionRollup.md) |  | [optional] 
**Source** | [**TimelineCrossReferencedEventSource**](TimelineCrossReferencedEventSource.md) |  | 
**Sha** | **string** | SHA for the commit | 
**Author** | [**GitCommitAuthor**](GitCommitAuthor.md) |  | 
**Committer** | [**GitCommitAuthor**](GitCommitAuthor.md) |  | 
**Message** | **string** | Message describing the purpose of the commit | 
**Tree** | [**GitCommitTree**](GitCommitTree.md) |  | 
**Parents** | [**List<GitCommitParentsInner>**](GitCommitParentsInner.md) |  | 
**Verification** | [**GitCommitVerification**](GitCommitVerification.md) |  | 
**State** | **string** |  | 
**PullRequestUrl** | **string** |  | 
**Links** | [**TimelineReviewedEventLinks**](TimelineReviewedEventLinks.md) |  | 
**SubmittedAt** | **DateTime?** |  | [optional] 
**Comments** | [**List<CommitComment>**](CommitComment.md) |  | [optional] 
**Assignee** | [**SimpleUser1**](SimpleUser1.md) |  | 
**StateReason** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

