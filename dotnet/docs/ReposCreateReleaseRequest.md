# Org.OpenAPITools.Model.ReposCreateReleaseRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TagName** | **string** | The name of the tag. | 
**TargetCommitish** | **string** | Specifies the commitish value that determines where the Git tag is created from. Can be any branch or commit SHA. Unused if the Git tag already exists. Default: the repository&#39;s default branch (usually &#x60;master&#x60;). | [optional] 
**Name** | **string** | The name of the release. | [optional] 
**Body** | **string** | Text describing the contents of the tag. | [optional] 
**Draft** | **bool?** | &#x60;true&#x60; to create a draft (unpublished) release, &#x60;false&#x60; to create a published one. | [optional] [default to false]
**Prerelease** | **bool?** | &#x60;true&#x60; to identify the release as a prerelease. &#x60;false&#x60; to identify the release as a full release. | [optional] [default to false]
**DiscussionCategoryName** | **string** | If specified, a discussion of the specified category is created and linked to the release. The value must be a category that already exists in the repository. For more information, see \&quot;[Managing categories for discussions in your repository](https://docs.github.com/discussions/managing-discussions-for-your-community/managing-categories-for-discussions-in-your-repository).\&quot; | [optional] 
**GenerateReleaseNotes** | **bool?** | Whether to automatically generate the name and body for this release. If &#x60;name&#x60; is specified, the specified name will be used; otherwise, a name will be automatically generated. If &#x60;body&#x60; is specified, the body will be pre-pended to the automatically generated notes. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

