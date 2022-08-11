# Org.OpenAPITools.Model.Release

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** |  | 
**HtmlUrl** | **string** |  | 
**AssetsUrl** | **string** |  | 
**UploadUrl** | **string** |  | 
**TarballUrl** | **string** |  | 
**ZipballUrl** | **string** |  | 
**Id** | **int?** |  | 
**NodeId** | **string** |  | 
**TagName** | **string** | The name of the tag. | 
**TargetCommitish** | **string** | Specifies the commitish value that determines where the Git tag is created from. | 
**Name** | **string** |  | 
**Body** | **string** |  | [optional] 
**Draft** | **bool?** | true to create a draft (unpublished) release, false to create a published one. | 
**Prerelease** | **bool?** | Whether to identify the release as a prerelease or a full release. | 
**CreatedAt** | **DateTime?** |  | 
**PublishedAt** | **DateTime?** |  | 
**Author** | [**SimpleUser1**](SimpleUser1.md) |  | 
**Assets** | [**List<ReleaseAsset>**](ReleaseAsset.md) |  | 
**BodyHtml** | **string** |  | [optional] 
**BodyText** | **string** |  | [optional] 
**MentionsCount** | **int?** |  | [optional] 
**DiscussionUrl** | **string** | The URL of the release discussion. | [optional] 
**Reactions** | [**ReactionRollup**](ReactionRollup.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

