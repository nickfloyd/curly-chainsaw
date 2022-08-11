# Org.OpenAPITools.Model.ReposUpdateWebhookRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | [**ReposUpdateWebhookRequestConfig**](ReposUpdateWebhookRequestConfig.md) |  | [optional] 
**Events** | **List<string>** | Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. This replaces the entire array of events. | [optional] 
**AddEvents** | **List<string>** | Determines a list of events to be added to the list of events that the Hook triggers for. | [optional] 
**RemoveEvents** | **List<string>** | Determines a list of events to be removed from the list of events that the Hook triggers for. | [optional] 
**Active** | **bool?** | Determines if notifications are sent when the webhook is triggered. Set to &#x60;true&#x60; to send notifications. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

