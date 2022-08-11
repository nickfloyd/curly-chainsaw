# Org.OpenAPITools.Model.WebhookConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** |  | [optional] 
**Password** | **string** |  | [optional] 
**Room** | **string** |  | [optional] 
**Subdomain** | **string** |  | [optional] 
**Url** | **string** | The URL to which the payloads will be delivered. | [optional] 
**InsecureSsl** | [**WebhookConfigurationInsecureSsl**](WebhookConfigurationInsecureSsl.md) |  | [optional] 
**ContentType** | **string** | The media type used to serialize the payloads. Supported values include &#x60;json&#x60; and &#x60;form&#x60;. The default is &#x60;form&#x60;. | [optional] 
**Digest** | **string** |  | [optional] 
**Secret** | **string** | If provided, the &#x60;secret&#x60; will be used as the &#x60;key&#x60; to generate the HMAC hex digest value for [delivery signature headers](https://docs.github.com/webhooks/event-payloads/#delivery-headers). | [optional] 
**Token** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

