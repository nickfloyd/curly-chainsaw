# Org.OpenAPITools.Model.ReposUpdateReleaseRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TagName** | **string** | The name of the tag. | [optional] 
**TargetCommitish** | **string** | Specifies the commitish value that determines where the Git tag is created from. Can be any branch or commit SHA. Unused if the Git tag already exists. Default: the repository&#39;s default branch (usually &#x60;master&#x60;). | [optional] 
**Name** | **string** | The name of the release. | [optional] 
**Body** | **string** | Text describing the contents of the tag. | [optional] 
**Draft** | **bool?** | &#x60;true&#x60; makes the release a draft, and &#x60;false&#x60; publishes the release. | [optional] 
**Prerelease** | **bool?** | &#x60;true&#x60; to identify the release as a prerelease, &#x60;false&#x60; to identify the release as a full release. | [optional] 
**DiscussionCategoryName** | **string** | If specified, a discussion of the specified category is created and linked to the release. The value must be a category that already exists in the repository. If there is already a discussion linked to the release, this parameter is ignored. For more information, see \&quot;[Managing categories for discussions in your repository](https://docs.github.com/discussions/managing-discussions-for-your-community/managing-categories-for-discussions-in-your-repository).\&quot; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

