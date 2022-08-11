# Org.OpenAPITools.Model.Webhook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**Id** | **int?** | Unique identifier of the webhook. | 
**Name** | **string** | The name of a valid service, use &#39;web&#39; for a webhook. | 
**Active** | **bool?** | Determines whether the hook is actually triggered on pushes. | 
**Events** | **List<string>** | Determines what events the hook is triggered for. Default: [&#39;push&#39;]. | 
**Config** | [**WebhookConfig**](WebhookConfig.md) |  | 
**UpdatedAt** | **DateTime?** |  | 
**CreatedAt** | **DateTime?** |  | 
**Url** | **string** |  | 
**TestUrl** | **string** |  | 
**PingUrl** | **string** |  | 
**DeliveriesUrl** | **string** |  | [optional] 
**LastResponse** | [**HookResponse**](HookResponse.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

