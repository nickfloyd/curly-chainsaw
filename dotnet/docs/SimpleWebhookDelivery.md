# Org.OpenAPITools.Model.SimpleWebhookDelivery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier of the webhook delivery. | 
**Guid** | **string** | Unique identifier for the event (shared with all deliveries for all webhooks that subscribe to this event). | 
**DeliveredAt** | **DateTime?** | Time when the webhook delivery occurred. | 
**Redelivery** | **bool?** | Whether the webhook delivery is a redelivery. | 
**Duration** | **decimal?** | Time spent delivering. | 
**Status** | **string** | Describes the response returned after attempting the delivery. | 
**StatusCode** | **int?** | Status code received when delivery was made. | 
**Event** | **string** | The event that triggered the delivery. | 
**Action** | **string** | The type of activity for the event that triggered the delivery. | 
**InstallationId** | **int?** | The id of the GitHub App installation associated with this event. | 
**RepositoryId** | **int?** | The id of the repository associated with this event. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

