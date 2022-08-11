# Org.OpenAPITools.Model.ChecksCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the check. For example, \&quot;code-coverage\&quot;. | 
**HeadSha** | **string** | The SHA of the commit. | 
**DetailsUrl** | **string** | The URL of the integrator&#39;s site that has the full details of the check. If the integrator does not provide this, then the homepage of the GitHub app is used. | [optional] 
**ExternalId** | **string** | A reference for the run on the integrator&#39;s system. | [optional] 
**Status** | **string** | The current status. | [optional] [default to StatusEnum.QueuedEnum]
**StartedAt** | **DateTime?** | The time that the check run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
**Conclusion** | **string** | **Required if you provide &#x60;completed_at&#x60; or a &#x60;status&#x60; of &#x60;completed&#x60;**. The final conclusion of the check.  **Note:** Providing &#x60;conclusion&#x60; will automatically set the &#x60;status&#x60; parameter to &#x60;completed&#x60;. You cannot change a check run conclusion to &#x60;stale&#x60;, only GitHub can set this. | [optional] 
**CompletedAt** | **DateTime?** | The time the check completed. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
**Output** | [**ChecksCreateRequestOutput**](ChecksCreateRequestOutput.md) |  | [optional] 
**Actions** | [**List<ChecksCreateRequestActionsInner>**](ChecksCreateRequestActionsInner.md) | Displays a button on GitHub that can be clicked to alert your app to do additional tasks. For example, a code linting app can display a button that automatically fixes detected errors. The button created in this object is displayed after the check run completes. When a user clicks the button, GitHub sends the [&#x60;check_run.requested_action&#x60; webhook](https://docs.github.com/webhooks/event-payloads/#check_run) to your app. Each action includes a &#x60;label&#x60;, &#x60;identifier&#x60; and &#x60;description&#x60;. A maximum of three actions are accepted. See the [&#x60;actions&#x60; object](https://docs.github.com/rest/reference/checks#actions-object) description. To learn more about check runs and requested actions, see \&quot;[Check runs and requested actions](https://docs.github.com/rest/reference/checks#check-runs-and-requested-actions).\&quot; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

