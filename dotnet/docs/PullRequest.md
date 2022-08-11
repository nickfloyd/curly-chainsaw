# Org.OpenAPITools.Model.PullRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** |  | 
**Id** | **int?** |  | 
**NodeId** | **string** |  | 
**HtmlUrl** | **string** |  | 
**DiffUrl** | **string** |  | 
**PatchUrl** | **string** |  | 
**IssueUrl** | **string** |  | 
**CommitsUrl** | **string** |  | 
**ReviewCommentsUrl** | **string** |  | 
**ReviewCommentUrl** | **string** |  | 
**CommentsUrl** | **string** |  | 
**StatusesUrl** | **string** |  | 
**Number** | **int?** | Number uniquely identifying the pull request within its repository. | 
**State** | **string** | State of this Pull Request. Either &#x60;open&#x60; or &#x60;closed&#x60;. | 
**Locked** | **bool?** |  | 
**Title** | **string** | The title of the pull request. | 
**User** | [**SimpleUser**](SimpleUser.md) |  | 
**Body** | **string** |  | 
**Labels** | [**List<PullRequestLabelsInner>**](PullRequestLabelsInner.md) |  | 
**Milestone** | [**Milestone**](Milestone.md) |  | 
**ActiveLockReason** | **string** |  | [optional] 
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**ClosedAt** | **DateTime?** |  | 
**MergedAt** | **DateTime?** |  | 
**MergeCommitSha** | **string** |  | 
**Assignee** | [**SimpleUser**](SimpleUser.md) |  | 
**Assignees** | [**List<SimpleUser1>**](SimpleUser1.md) |  | [optional] 
**RequestedReviewers** | [**List<SimpleUser1>**](SimpleUser1.md) |  | [optional] 
**RequestedTeams** | [**List<TeamSimple1>**](TeamSimple1.md) |  | [optional] 
**Head** | [**PullRequestHead**](PullRequestHead.md) |  | 
**Base** | [**PullRequestBase**](PullRequestBase.md) |  | 
**Links** | [**PullRequestSimpleLinks**](PullRequestSimpleLinks.md) |  | 
**AuthorAssociation** | **string** | How the author is associated with the repository. | 
**AutoMerge** | [**AutoMerge**](AutoMerge.md) |  | 
**Draft** | **bool?** | Indicates whether or not the pull request is a draft. | [optional] 
**Merged** | **bool?** |  | 
**Mergeable** | **bool?** |  | 
**Rebaseable** | **bool?** |  | [optional] 
**MergeableState** | **string** |  | 
**MergedBy** | [**SimpleUser**](SimpleUser.md) |  | 
**Comments** | **int?** |  | 
**ReviewComments** | **int?** |  | 
**MaintainerCanModify** | **bool?** | Indicates whether maintainers can modify the pull request. | 
**Commits** | **int?** |  | 
**Additions** | **int?** |  | 
**Deletions** | **int?** |  | 
**ChangedFiles** | **int?** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

