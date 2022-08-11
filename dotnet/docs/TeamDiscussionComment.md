# Org.OpenAPITools.Model.TeamDiscussionComment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Author** | [**SimpleUser**](SimpleUser.md) |  | 
**Body** | **string** | The main text of the comment. | 
**BodyHtml** | **string** |  | 
**BodyVersion** | **string** | The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server. | 
**CreatedAt** | **DateTime?** |  | 
**LastEditedAt** | **DateTime?** |  | 
**DiscussionUrl** | **string** |  | 
**HtmlUrl** | **string** |  | 
**NodeId** | **string** |  | 
**Number** | **int?** | The unique sequence number of a team discussion comment. | 
**UpdatedAt** | **DateTime?** |  | 
**Url** | **string** |  | 
**Reactions** | [**ReactionRollup**](ReactionRollup.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

