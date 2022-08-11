# Org.OpenAPITools.Model.Job

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | The id of the job. | 
**RunId** | **int?** | The id of the associated workflow run. | 
**RunUrl** | **string** |  | 
**RunAttempt** | **int?** | Attempt number of the associated workflow run, 1 for first attempt and higher if the workflow was re-run. | [optional] 
**NodeId** | **string** |  | 
**HeadSha** | **string** | The SHA of the commit that is being run. | 
**Url** | **string** |  | 
**HtmlUrl** | **string** |  | 
**Status** | **string** | The phase of the lifecycle that the job is currently in. | 
**Conclusion** | **string** | The outcome of the job. | 
**StartedAt** | **DateTime?** | The time that the job started, in ISO 8601 format. | 
**CompletedAt** | **DateTime?** | The time that the job finished, in ISO 8601 format. | 
**Name** | **string** | The name of the job. | 
**Steps** | [**List<JobStepsInner>**](JobStepsInner.md) | Steps in this job. | [optional] 
**CheckRunUrl** | **string** |  | 
**Labels** | **List<string>** | Labels for the workflow job. Specified by the \&quot;runs_on\&quot; attribute in the action&#39;s workflow file. | 
**RunnerId** | **int?** | The ID of the runner to which this job has been assigned. (If a runner hasn&#39;t yet been assigned, this will be null.) | 
**RunnerName** | **string** | The name of the runner to which this job has been assigned. (If a runner hasn&#39;t yet been assigned, this will be null.) | 
**RunnerGroupId** | **int?** | The ID of the runner group to which this job has been assigned. (If a runner hasn&#39;t yet been assigned, this will be null.) | 
**RunnerGroupName** | **string** | The name of the runner group to which this job has been assigned. (If a runner hasn&#39;t yet been assigned, this will be null.) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

