# Org.OpenAPITools.Model.PullRequestReview

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier of the review | 
**NodeId** | **string** |  | 
**User** | [**SimpleUser**](SimpleUser.md) |  | 
**Body** | **string** | The text of the review. | 
**State** | **string** |  | 
**HtmlUrl** | **string** |  | 
**PullRequestUrl** | **string** |  | 
**Links** | [**TimelineReviewedEventLinks**](TimelineReviewedEventLinks.md) |  | 
**SubmittedAt** | **DateTime?** |  | [optional] 
**CommitId** | **string** | A commit SHA for the review. | 
**BodyHtml** | **string** |  | [optional] 
**BodyText** | **string** |  | [optional] 
**AuthorAssociation** | **string** | How the author is associated with the repository. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

