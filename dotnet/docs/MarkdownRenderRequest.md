# Org.OpenAPITools.Model.MarkdownRenderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Text** | **string** | The Markdown text to render in HTML. | 
**Mode** | **string** | The rendering mode. Can be either &#x60;markdown&#x60; or &#x60;gfm&#x60;. | [optional] [default to ModeEnum.MarkdownEnum]
**Context** | **string** | The repository context to use when creating references in &#x60;gfm&#x60; mode.  For example, setting &#x60;context&#x60; to &#x60;octo-org/octo-repo&#x60; will change the text &#x60;#42&#x60; into an HTML link to issue 42 in the &#x60;octo-org/octo-repo&#x60; repository. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

