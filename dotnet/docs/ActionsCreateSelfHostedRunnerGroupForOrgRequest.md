# Org.OpenAPITools.Model.ActionsCreateSelfHostedRunnerGroupForOrgRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the runner group. | 
**Visibility** | **string** | Visibility of a runner group. You can select all repositories, select individual repositories, or limit access to private repositories. | [optional] [default to VisibilityEnum.AllEnum]
**SelectedRepositoryIds** | **List<int?>** | List of repository IDs that can access the runner group. | [optional] 
**Runners** | **List<int?>** | List of runner IDs to add to the runner group. | [optional] 
**AllowsPublicRepositories** | **bool?** | Whether the runner group can be used by &#x60;public&#x60; repositories. | [optional] [default to false]
**RestrictedToWorkflows** | **bool?** | If &#x60;true&#x60;, the runner group will be restricted to running only the workflows specified in the &#x60;selected_workflows&#x60; array. | [optional] [default to false]
**SelectedWorkflows** | **List<string>** | List of workflows the runner group should be allowed to run. This setting will be ignored unless &#x60;restricted_to_workflows&#x60; is set to &#x60;true&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

