# Org.OpenAPITools.Model.ActionsUpdateSelfHostedRunnerGroupForOrgRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the runner group. | 
**Visibility** | **string** | Visibility of a runner group. You can select all repositories, select individual repositories, or all private repositories. | [optional] 
**AllowsPublicRepositories** | **bool?** | Whether the runner group can be used by &#x60;public&#x60; repositories. | [optional] [default to false]
**RestrictedToWorkflows** | **bool?** | If &#x60;true&#x60;, the runner group will be restricted to running only the workflows specified in the &#x60;selected_workflows&#x60; array. | [optional] [default to false]
**SelectedWorkflows** | **List<string>** | List of workflows the runner group should be allowed to run. This setting will be ignored unless &#x60;restricted_to_workflows&#x60; is set to &#x60;true&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

