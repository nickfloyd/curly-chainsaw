# Org.OpenAPITools.Model.WebhookDelivery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier of the delivery. | 
**Guid** | **string** | Unique identifier for the event (shared with all deliveries for all webhooks that subscribe to this event). | 
**DeliveredAt** | **DateTime?** | Time when the delivery was delivered. | 
**Redelivery** | **bool?** | Whether the delivery is a redelivery. | 
**Duration** | **decimal?** | Time spent delivering. | 
**Status** | **string** | Description of the status of the attempted delivery | 
**StatusCode** | **int?** | Status code received when delivery was made. | 
**Event** | **string** | The event that triggered the delivery. | 
**Action** | **string** | The type of activity for the event that triggered the delivery. | 
**InstallationId** | **int?** | The id of the GitHub App installation associated with this event. | 
**RepositoryId** | **int?** | The id of the repository associated with this event. | 
**Url** | **string** | The URL target of the delivery. | [optional] 
**Request** | [**WebhookDeliveryRequest**](WebhookDeliveryRequest.md) |  | 
**Response** | [**WebhookDeliveryResponse**](WebhookDeliveryResponse.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

