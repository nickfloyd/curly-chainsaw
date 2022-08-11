# Org.OpenAPITools.Model.LegacyReviewComment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** |  | 
**PullRequestReviewId** | **int?** |  | 
**Id** | **int?** |  | 
**NodeId** | **string** |  | 
**DiffHunk** | **string** |  | 
**Path** | **string** |  | 
**Position** | **int?** |  | 
**OriginalPosition** | **int?** |  | 
**CommitId** | **string** |  | 
**OriginalCommitId** | **string** |  | 
**InReplyToId** | **int?** |  | [optional] 
**User** | [**SimpleUser**](SimpleUser.md) |  | 
**Body** | **string** |  | 
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**HtmlUrl** | **string** |  | 
**PullRequestUrl** | **string** |  | 
**AuthorAssociation** | **string** | How the author is associated with the repository. | 
**Links** | [**LegacyReviewCommentLinks**](LegacyReviewCommentLinks.md) |  | 
**BodyText** | **string** |  | [optional] 
**BodyHtml** | **string** |  | [optional] 
**Reactions** | [**ReactionRollup**](ReactionRollup.md) |  | [optional] 
**Side** | **string** | The side of the first line of the range for a multi-line comment. | [optional] [default to SideEnum.RIGHTEnum]
**StartSide** | **string** | The side of the first line of the range for a multi-line comment. | [optional] [default to StartSideEnum.RIGHTEnum]
**Line** | **int?** | The line of the blob to which the comment applies. The last line of the range for a multi-line comment | [optional] 
**OriginalLine** | **int?** | The original line of the blob to which the comment applies. The last line of the range for a multi-line comment | [optional] 
**StartLine** | **int?** | The first line of the range for a multi-line comment. | [optional] 
**OriginalStartLine** | **int?** | The original first line of the range for a multi-line comment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

