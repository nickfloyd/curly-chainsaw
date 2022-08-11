# Org.OpenAPITools.Model.ChecksCreateRequestOutputAnnotationsInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The path of the file to add an annotation to. For example, &#x60;assets/css/main.css&#x60;. | 
**StartLine** | **int?** | The start line of the annotation. | 
**EndLine** | **int?** | The end line of the annotation. | 
**StartColumn** | **int?** | The start column of the annotation. Annotations only support &#x60;start_column&#x60; and &#x60;end_column&#x60; on the same line. Omit this parameter if &#x60;start_line&#x60; and &#x60;end_line&#x60; have different values. | [optional] 
**EndColumn** | **int?** | The end column of the annotation. Annotations only support &#x60;start_column&#x60; and &#x60;end_column&#x60; on the same line. Omit this parameter if &#x60;start_line&#x60; and &#x60;end_line&#x60; have different values. | [optional] 
**AnnotationLevel** | **string** | The level of the annotation. | 
**Message** | **string** | A short description of the feedback for these lines of code. The maximum size is 64 KB. | 
**Title** | **string** | The title that represents the annotation. The maximum size is 255 characters. | [optional] 
**RawDetails** | **string** | Details about this annotation. The maximum size is 64 KB. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

