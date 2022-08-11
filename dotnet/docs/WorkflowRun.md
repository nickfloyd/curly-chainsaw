# Org.OpenAPITools.Model.WorkflowRun

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | The ID of the workflow run. | 
**Name** | **string** | The name of the workflow run. | [optional] 
**NodeId** | **string** |  | 
**CheckSuiteId** | **int?** | The ID of the associated check suite. | [optional] 
**CheckSuiteNodeId** | **string** | The node ID of the associated check suite. | [optional] 
**HeadBranch** | **string** |  | 
**HeadSha** | **string** | The SHA of the head commit that points to the version of the workflow being run. | 
**Path** | **string** | The full path of the workflow | 
**RunNumber** | **int?** | The auto incrementing run number for the workflow run. | 
**RunAttempt** | **int?** | Attempt number of the run, 1 for first attempt and higher if the workflow was re-run. | [optional] 
**ReferencedWorkflows** | [**List<ReferencedWorkflow>**](ReferencedWorkflow.md) |  | [optional] 
**Event** | **string** |  | 
**Status** | **string** |  | 
**Conclusion** | **string** |  | 
**WorkflowId** | **int?** | The ID of the parent workflow. | 
**Url** | **string** | The URL to the workflow run. | 
**HtmlUrl** | **string** |  | 
**PullRequests** | [**List<PullRequestMinimal>**](PullRequestMinimal.md) |  | 
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**Actor** | [**SimpleUser1**](SimpleUser1.md) |  | [optional] 
**TriggeringActor** | [**SimpleUser1**](SimpleUser1.md) |  | [optional] 
**RunStartedAt** | **DateTime?** | The start time of the latest run. Resets on re-run. | [optional] 
**JobsUrl** | **string** | The URL to the jobs for the workflow run. | 
**LogsUrl** | **string** | The URL to download the logs for the workflow run. | 
**CheckSuiteUrl** | **string** | The URL to the associated check suite. | 
**ArtifactsUrl** | **string** | The URL to the artifacts for the workflow run. | 
**CancelUrl** | **string** | The URL to cancel the workflow run. | 
**RerunUrl** | **string** | The URL to rerun the workflow run. | 
**PreviousAttemptUrl** | **string** | The URL to the previous attempted run of this workflow, if one exists. | [optional] 
**WorkflowUrl** | **string** | The URL to the workflow. | 
**HeadCommit** | [**SimpleCommit**](SimpleCommit.md) |  | 
**Repository** | [**MinimalRepository**](MinimalRepository.md) |  | 
**HeadRepository** | [**MinimalRepository**](MinimalRepository.md) |  | 
**HeadRepositoryId** | **int?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

