# Org.OpenAPITools.Model.SecretScanningListAlertsForEnterprise200ResponseInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Number** | **int?** | The security alert number. | [optional] [readonly] 
**CreatedAt** | **DateTime?** | The time that the alert was created in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] [readonly] 
**UpdatedAt** | **DateTime?** | The time that the alert was last updated in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] [readonly] 
**Url** | **string** | The REST API URL of the alert resource. | [optional] [readonly] 
**HtmlUrl** | **string** | The GitHub URL of the alert resource. | [optional] [readonly] 
**LocationsUrl** | **string** | The REST API URL of the code locations for this alert. | [optional] 
**State** | **string** | Sets the state of the secret scanning alert. Can be either &#x60;open&#x60; or &#x60;resolved&#x60;. You must provide &#x60;resolution&#x60; when you set the state to &#x60;resolved&#x60;. | [optional] 
**Resolution** | **string** | **Required when the &#x60;state&#x60; is &#x60;resolved&#x60;.** The reason for resolving the alert. | [optional] 
**ResolvedAt** | **DateTime?** | The time that the alert was resolved in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
**ResolvedBy** | [**SimpleUser**](SimpleUser.md) |  | [optional] 
**SecretType** | **string** | The type of secret that secret scanning detected. | [optional] 
**SecretTypeDisplayName** | **string** | User-friendly name for the detected secret, matching the &#x60;secret_type&#x60;. For a list of built-in patterns, see \&quot;[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security).\&quot; | [optional] 
**Secret** | **string** | The secret that was detected. | [optional] 
**Repository** | [**SimpleRepository**](SimpleRepository.md) |  | [optional] 
**PushProtectionBypassed** | **bool?** | Whether push protection was bypassed for the detected secret. | [optional] 
**PushProtectionBypassedBy** | [**SimpleUser**](SimpleUser.md) |  | [optional] 
**PushProtectionBypassedAt** | **DateTime?** | The time that push protection was bypassed in ISO 8601 format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

