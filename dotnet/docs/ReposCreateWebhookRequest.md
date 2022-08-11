# Org.OpenAPITools.Model.ReposCreateWebhookRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Use &#x60;web&#x60; to create a webhook. Default: &#x60;web&#x60;. This parameter only accepts the value &#x60;web&#x60;. | [optional] 
**Config** | [**ReposCreateWebhookRequestConfig**](ReposCreateWebhookRequestConfig.md) |  | [optional] 
**Events** | **List<string>** | Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. | [optional] 
**Active** | **bool?** | Determines if notifications are sent when the webhook is triggered. Set to &#x60;true&#x60; to send notifications. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

