# Org.OpenAPITools.Model.PendingDeployment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Environment** | [**PendingDeploymentEnvironment**](PendingDeploymentEnvironment.md) |  | 
**WaitTimer** | **int?** | The set duration of the wait timer | 
**WaitTimerStartedAt** | **DateTime?** | The time that the wait timer began. | 
**CurrentUserCanApprove** | **bool?** | Whether the currently authenticated user can approve the deployment | 
**Reviewers** | [**List<PendingDeploymentReviewersInner>**](PendingDeploymentReviewersInner.md) | The people or teams that may approve jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

