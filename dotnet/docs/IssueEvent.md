# Org.OpenAPITools.Model.IssueEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | 
**NodeId** | **string** |  | 
**Url** | **string** |  | 
**Actor** | [**SimpleUser**](SimpleUser.md) |  | 
**Event** | **string** |  | 
**CommitId** | **string** |  | 
**CommitUrl** | **string** |  | 
**CreatedAt** | **DateTime?** |  | 
**Issue** | [**Issue1**](Issue1.md) |  | [optional] 
**Label** | [**IssueEventLabel**](IssueEventLabel.md) |  | [optional] 
**Assignee** | [**SimpleUser**](SimpleUser.md) |  | [optional] 
**Assigner** | [**SimpleUser**](SimpleUser.md) |  | [optional] 
**ReviewRequester** | [**SimpleUser**](SimpleUser.md) |  | [optional] 
**RequestedReviewer** | [**SimpleUser**](SimpleUser.md) |  | [optional] 
**RequestedTeam** | [**Team**](Team.md) |  | [optional] 
**DismissedReview** | [**IssueEventDismissedReview**](IssueEventDismissedReview.md) |  | [optional] 
**Milestone** | [**IssueEventMilestone**](IssueEventMilestone.md) |  | [optional] 
**ProjectCard** | [**IssueEventProjectCard**](IssueEventProjectCard.md) |  | [optional] 
**Rename** | [**IssueEventRename**](IssueEventRename.md) |  | [optional] 
**AuthorAssociation** | **string** | How the author is associated with the repository. | [optional] 
**LockReason** | **string** |  | [optional] 
**PerformedViaGithubApp** | [**GitHubApp1**](GitHubApp1.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

