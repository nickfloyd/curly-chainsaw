# Org.OpenAPITools.Model.Issue1

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | 
**NodeId** | **string** |  | 
**Url** | **string** | URL for the issue | 
**RepositoryUrl** | **string** |  | 
**LabelsUrl** | **string** |  | 
**CommentsUrl** | **string** |  | 
**EventsUrl** | **string** |  | 
**HtmlUrl** | **string** |  | 
**Number** | **int?** | Number uniquely identifying the issue within its repository | 
**State** | **string** | State of the issue; either &#39;open&#39; or &#39;closed&#39; | 
**StateReason** | **string** | The reason for the current state | [optional] 
**Title** | **string** | Title of the issue | 
**Body** | **string** | Contents of the issue | [optional] 
**User** | [**SimpleUser**](SimpleUser.md) |  | 
**Labels** | [**List<IssueLabelsInner>**](IssueLabelsInner.md) | Labels to associate with this issue; pass one or more label names to replace the set of labels on this issue; send an empty array to clear all labels from the issue; note that the labels are silently dropped for users without push access to the repository | 
**Assignee** | [**SimpleUser**](SimpleUser.md) |  | 
**Assignees** | [**List<SimpleUser1>**](SimpleUser1.md) |  | [optional] 
**Milestone** | [**Milestone**](Milestone.md) |  | 
**Locked** | **bool?** |  | 
**ActiveLockReason** | **string** |  | [optional] 
**Comments** | **int?** |  | 
**PullRequest** | [**IssuePullRequest**](IssuePullRequest.md) |  | [optional] 
**ClosedAt** | **DateTime?** |  | 
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**Draft** | **bool?** |  | [optional] 
**ClosedBy** | [**SimpleUser**](SimpleUser.md) |  | [optional] 
**BodyHtml** | **string** |  | [optional] 
**BodyText** | **string** |  | [optional] 
**TimelineUrl** | **string** |  | [optional] 
**Repository** | [**Repository**](Repository.md) |  | [optional] 
**PerformedViaGithubApp** | [**GitHubApp1**](GitHubApp1.md) |  | [optional] 
**AuthorAssociation** | **string** | How the author is associated with the repository. | 
**Reactions** | [**ReactionRollup**](ReactionRollup.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

