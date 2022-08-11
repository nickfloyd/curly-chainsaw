# Org.OpenAPITools.Model.IssueSearchResultItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** |  | 
**RepositoryUrl** | **string** |  | 
**LabelsUrl** | **string** |  | 
**CommentsUrl** | **string** |  | 
**EventsUrl** | **string** |  | 
**HtmlUrl** | **string** |  | 
**Id** | **int?** |  | 
**NodeId** | **string** |  | 
**Number** | **int?** |  | 
**Title** | **string** |  | 
**Locked** | **bool?** |  | 
**ActiveLockReason** | **string** |  | [optional] 
**Assignees** | [**List<SimpleUser1>**](SimpleUser1.md) |  | [optional] 
**User** | [**SimpleUser**](SimpleUser.md) |  | 
**Labels** | [**List<IssueSearchResultItemLabelsInner>**](IssueSearchResultItemLabelsInner.md) |  | 
**State** | **string** |  | 
**StateReason** | **string** |  | [optional] 
**Assignee** | [**SimpleUser**](SimpleUser.md) |  | 
**Milestone** | [**Milestone**](Milestone.md) |  | 
**Comments** | **int?** |  | 
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**ClosedAt** | **DateTime?** |  | 
**TextMatches** | [**List<SearchResultTextMatchesInner>**](SearchResultTextMatchesInner.md) |  | [optional] 
**PullRequest** | [**IssuePullRequest**](IssuePullRequest.md) |  | [optional] 
**Body** | **string** |  | [optional] 
**Score** | **decimal?** |  | 
**AuthorAssociation** | **string** | How the author is associated with the repository. | 
**Draft** | **bool?** |  | [optional] 
**Repository** | [**Repository**](Repository.md) |  | [optional] 
**BodyHtml** | **string** |  | [optional] 
**BodyText** | **string** |  | [optional] 
**TimelineUrl** | **string** |  | [optional] 
**PerformedViaGithubApp** | [**GitHubApp1**](GitHubApp1.md) |  | [optional] 
**Reactions** | [**ReactionRollup**](ReactionRollup.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

