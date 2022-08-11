# Org.OpenAPITools.Model.PullRequestSimple

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
**Number** | **int?** |  | 
**State** | **string** |  | 
**Locked** | **bool?** |  | 
**Title** | **string** |  | 
**User** | [**SimpleUser**](SimpleUser.md) |  | 
**Body** | **string** |  | 
**Labels** | [**List<PullRequestSimpleLabelsInner>**](PullRequestSimpleLabelsInner.md) |  | 
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
**RequestedTeams** | [**List<Team>**](Team.md) |  | [optional] 
**Head** | [**PullRequestSimpleHead**](PullRequestSimpleHead.md) |  | 
**Base** | [**PullRequestSimpleHead**](PullRequestSimpleHead.md) |  | 
**Links** | [**PullRequestSimpleLinks**](PullRequestSimpleLinks.md) |  | 
**AuthorAssociation** | **string** | How the author is associated with the repository. | 
**AutoMerge** | [**AutoMerge**](AutoMerge.md) |  | 
**Draft** | **bool?** | Indicates whether or not the pull request is a draft. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

