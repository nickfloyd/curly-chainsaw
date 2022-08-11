# Org.OpenAPITools.Model.IssuesCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | [**IssuesCreateRequestTitle**](IssuesCreateRequestTitle.md) |  | 
**Body** | **string** | The contents of the issue. | [optional] 
**Assignee** | **string** | Login for the user that this issue should be assigned to. _NOTE: Only users with push access can set the assignee for new issues. The assignee is silently dropped otherwise. **This field is deprecated.**_ | [optional] 
**Milestone** | [**IssuesCreateRequestMilestone**](IssuesCreateRequestMilestone.md) |  | [optional] 
**Labels** | [**List<IssuesCreateRequestLabelsInner>**](IssuesCreateRequestLabelsInner.md) | Labels to associate with this issue. _NOTE: Only users with push access can set labels for new issues. Labels are silently dropped otherwise._ | [optional] 
**Assignees** | **List<string>** | Logins for Users to assign to this issue. _NOTE: Only users with push access can set assignees for new issues. Assignees are silently dropped otherwise._ | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

