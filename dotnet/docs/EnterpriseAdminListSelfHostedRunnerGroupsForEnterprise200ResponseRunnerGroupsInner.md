# Org.OpenAPITools.Model.EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **decimal?** |  | 
**Name** | **string** |  | 
**Visibility** | **string** |  | 
**Default** | **bool?** |  | 
**SelectedOrganizationsUrl** | **string** |  | [optional] 
**RunnersUrl** | **string** |  | 
**AllowsPublicRepositories** | **bool?** |  | 
**WorkflowRestrictionsReadOnly** | **bool?** | If &#x60;true&#x60;, the &#x60;restricted_to_workflows&#x60; and &#x60;selected_workflows&#x60; fields cannot be modified. | [optional] [default to false]
**RestrictedToWorkflows** | **bool?** | If &#x60;true&#x60;, the runner group will be restricted to running only the workflows specified in the &#x60;selected_workflows&#x60; array. | [optional] [default to false]
**SelectedWorkflows** | **List<string>** | List of workflows the runner group should be allowed to run. This setting will be ignored unless &#x60;restricted_to_workflows&#x60; is set to &#x60;true&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

