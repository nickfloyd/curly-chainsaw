# Org.OpenAPITools.Model.PullRequestReviewComment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | URL for the pull request review comment | 
**PullRequestReviewId** | **int?** | The ID of the pull request review to which the comment belongs. | 
**Id** | **int?** | The ID of the pull request review comment. | 
**NodeId** | **string** | The node ID of the pull request review comment. | 
**DiffHunk** | **string** | The diff of the line that the comment refers to. | 
**Path** | **string** | The relative path of the file to which the comment applies. | 
**Position** | **int?** | The line index in the diff to which the comment applies. This field is deprecated; use &#x60;line&#x60; instead. | 
**OriginalPosition** | **int?** | The index of the original line in the diff to which the comment applies. This field is deprecated; use &#x60;original_line&#x60; instead. | 
**CommitId** | **string** | The SHA of the commit to which the comment applies. | 
**OriginalCommitId** | **string** | The SHA of the original commit to which the comment applies. | 
**InReplyToId** | **int?** | The comment ID to reply to. | [optional] 
**User** | [**SimpleUser1**](SimpleUser1.md) |  | 
**Body** | **string** | The text of the comment. | 
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**HtmlUrl** | **string** | HTML URL for the pull request review comment. | 
**PullRequestUrl** | **string** | URL for the pull request that the review comment belongs to. | 
**AuthorAssociation** | **string** | How the author is associated with the repository. | 
**Links** | [**PullRequestReviewCommentLinks**](PullRequestReviewCommentLinks.md) |  | 
**StartLine** | **int?** | The first line of the range for a multi-line comment. | [optional] 
**OriginalStartLine** | **int?** | The first line of the range for a multi-line comment. | [optional] 
**StartSide** | **string** | The side of the first line of the range for a multi-line comment. | [optional] [default to StartSideEnum.RIGHTEnum]
**Line** | **int?** | The line of the blob to which the comment applies. The last line of the range for a multi-line comment | [optional] 
**OriginalLine** | **int?** | The line of the blob to which the comment applies. The last line of the range for a multi-line comment | [optional] 
**Side** | **string** | The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment | [optional] [default to SideEnum.RIGHTEnum]
**Reactions** | [**ReactionRollup**](ReactionRollup.md) |  | [optional] 
**BodyHtml** | **string** |  | [optional] 
**BodyText** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

