# Org.OpenAPITools.Model.ChecksUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the check. For example, \&quot;code-coverage\&quot;. | [optional] 
**DetailsUrl** | **string** | The URL of the integrator&#39;s site that has the full details of the check. | [optional] 
**ExternalId** | **string** | A reference for the run on the integrator&#39;s system. | [optional] 
**StartedAt** | **DateTime?** | This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
**Status** | **string** | The current status. | [optional] 
**Conclusion** | **string** | **Required if you provide &#x60;completed_at&#x60; or a &#x60;status&#x60; of &#x60;completed&#x60;**. The final conclusion of the check.  **Note:** Providing &#x60;conclusion&#x60; will automatically set the &#x60;status&#x60; parameter to &#x60;completed&#x60;. You cannot change a check run conclusion to &#x60;stale&#x60;, only GitHub can set this. | [optional] 
**CompletedAt** | **DateTime?** | The time the check completed. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
**Output** | [**ChecksUpdateRequestOutput**](ChecksUpdateRequestOutput.md) |  | [optional] 
**Actions** | [**List<ChecksCreateRequestActionsInner>**](ChecksCreateRequestActionsInner.md) | Possible further actions the integrator can perform, which a user may trigger. Each action includes a &#x60;label&#x60;, &#x60;identifier&#x60; and &#x60;description&#x60;. A maximum of three actions are accepted. See the [&#x60;actions&#x60; object](https://docs.github.com/rest/reference/checks#actions-object) description. To learn more about check runs and requested actions, see \&quot;[Check runs and requested actions](https://docs.github.com/rest/reference/checks#check-runs-and-requested-actions).\&quot; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

