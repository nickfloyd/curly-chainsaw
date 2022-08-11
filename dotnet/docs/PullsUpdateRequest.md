# Org.OpenAPITools.Model.PullsUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The title of the pull request. | [optional] 
**Body** | **string** | The contents of the pull request. | [optional] 
**State** | **string** | State of this Pull Request. Either &#x60;open&#x60; or &#x60;closed&#x60;. | [optional] 
**Base** | **string** | The name of the branch you want your changes pulled into. This should be an existing branch on the current repository. You cannot update the base branch on a pull request to point to another repository. | [optional] 
**MaintainerCanModify** | **bool?** | Indicates whether [maintainers can modify](https://docs.github.com/articles/allowing-changes-to-a-pull-request-branch-created-from-a-fork/) the pull request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

