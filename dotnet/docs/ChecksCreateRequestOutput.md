# Org.OpenAPITools.Model.ChecksCreateRequestOutput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The title of the check run. | 
**Summary** | **string** | The summary of the check run. This parameter supports Markdown. | 
**Text** | **string** | The details of the check run. This parameter supports Markdown. | [optional] 
**Annotations** | [**List<ChecksCreateRequestOutputAnnotationsInner>**](ChecksCreateRequestOutputAnnotationsInner.md) | Adds information from your analysis to specific lines of code. Annotations are visible on GitHub in the **Checks** and **Files changed** tab of the pull request. The Checks API limits the number of annotations to a maximum of 50 per API request. To create more than 50 annotations, you have to make multiple requests to the [Update a check run](https://docs.github.com/rest/reference/checks#update-a-check-run) endpoint. Each time you update the check run, annotations are appended to the list of annotations that already exist for the check run. For details about how you can view annotations on GitHub, see \&quot;[About status checks](https://docs.github.com/articles/about-status-checks#checks)\&quot;. See the [&#x60;annotations&#x60; object](https://docs.github.com/rest/reference/checks#annotations-object) description for details about how to use this parameter. | [optional] 
**Images** | [**List<ChecksCreateRequestOutputImagesInner>**](ChecksCreateRequestOutputImagesInner.md) | Adds images to the output displayed in the GitHub pull request UI. See the [&#x60;images&#x60; object](https://docs.github.com/rest/reference/checks#images-object) description for details. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

