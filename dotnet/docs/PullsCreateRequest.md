# Org.OpenAPITools.Model.PullsCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The title of the new pull request. Required unless &#x60;issue&#x60; is specified. | [optional] 
**Head** | **string** | The name of the branch where your changes are implemented. For cross-repository pull requests in the same network, namespace &#x60;head&#x60; with a user like this: &#x60;username:branch&#x60;. | 
**Base** | **string** | The name of the branch you want the changes pulled into. This should be an existing branch on the current repository. You cannot submit a pull request to one repository that requests a merge to a base of another repository. | 
**Body** | **string** | The contents of the pull request. | [optional] 
**MaintainerCanModify** | **bool?** | Indicates whether [maintainers can modify](https://docs.github.com/articles/allowing-changes-to-a-pull-request-branch-created-from-a-fork/) the pull request. | [optional] 
**Draft** | **bool?** | Indicates whether the pull request is a draft. See \&quot;[Draft Pull Requests](https://docs.github.com/en/articles/about-pull-requests#draft-pull-requests)\&quot; in the GitHub Help documentation to learn more. | [optional] 
**Issue** | **int?** | An issue in the repository to convert to a pull request. The issue title, body, and comments will become the title, body, and comments on the new pull request. Required unless &#x60;title&#x60; is specified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

