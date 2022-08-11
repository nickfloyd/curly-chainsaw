# Org.OpenAPITools.Model.ReposCreateOrUpdateFileContentsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **string** | The commit message. | 
**Content** | **string** | The new file content, using Base64 encoding. | 
**Sha** | **string** | **Required if you are updating a file**. The blob SHA of the file being replaced. | [optional] 
**Branch** | **string** | The branch name. Default: the repository’s default branch (usually &#x60;master&#x60;) | [optional] 
**Committer** | [**ReposCreateOrUpdateFileContentsRequestCommitter**](ReposCreateOrUpdateFileContentsRequestCommitter.md) |  | [optional] 
**Author** | [**ReposCreateOrUpdateFileContentsRequestAuthor**](ReposCreateOrUpdateFileContentsRequestAuthor.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

