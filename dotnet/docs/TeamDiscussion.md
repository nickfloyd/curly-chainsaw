# Org.OpenAPITools.Model.TeamDiscussion

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Author** | [**SimpleUser**](SimpleUser.md) |  | 
**Body** | **string** | The main text of the discussion. | 
**BodyHtml** | **string** |  | 
**BodyVersion** | **string** | The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server. | 
**CommentsCount** | **int?** |  | 
**CommentsUrl** | **string** |  | 
**CreatedAt** | **DateTime?** |  | 
**LastEditedAt** | **DateTime?** |  | 
**HtmlUrl** | **string** |  | 
**NodeId** | **string** |  | 
**Number** | **int?** | The unique sequence number of a team discussion. | 
**Pinned** | **bool?** | Whether or not this discussion should be pinned for easy retrieval. | 
**Private** | **bool?** | Whether or not this discussion should be restricted to team members and organization administrators. | 
**TeamUrl** | **string** |  | 
**Title** | **string** | The title of the discussion. | 
**UpdatedAt** | **DateTime?** |  | 
**Url** | **string** |  | 
**Reactions** | [**ReactionRollup**](ReactionRollup.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

