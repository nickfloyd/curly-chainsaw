# Org.OpenAPITools.Model.ChecksUpdateRequestOutput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | **Required**. | [optional] 
**Summary** | **string** | Can contain Markdown. | 
**Text** | **string** | Can contain Markdown. | [optional] 
**Annotations** | [**List<ChecksCreateRequestOutputAnnotationsInner>**](ChecksCreateRequestOutputAnnotationsInner.md) | Adds information from your analysis to specific lines of code. Annotations are visible in GitHub&#39;s pull request UI. Annotations are visible in GitHub&#39;s pull request UI. The Checks API limits the number of annotations to a maximum of 50 per API request. To create more than 50 annotations, you have to make multiple requests to the [Update a check run](https://docs.github.com/rest/reference/checks#update-a-check-run) endpoint. Each time you update the check run, annotations are appended to the list of annotations that already exist for the check run. For details about annotations in the UI, see \&quot;[About status checks](https://docs.github.com/articles/about-status-checks#checks)\&quot;. See the [&#x60;annotations&#x60; object](https://docs.github.com/rest/reference/checks#annotations-object-1) description for details. | [optional] 
**Images** | [**List<ChecksCreateRequestOutputImagesInner>**](ChecksCreateRequestOutputImagesInner.md) | Adds images to the output displayed in the GitHub pull request UI. See the [&#x60;images&#x60; object](https://docs.github.com/rest/reference/checks#annotations-object-1) description for details. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

