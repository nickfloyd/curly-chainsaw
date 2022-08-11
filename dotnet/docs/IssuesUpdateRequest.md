# Org.OpenAPITools.Model.IssuesUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | [**IssuesUpdateRequestTitle**](IssuesUpdateRequestTitle.md) |  | [optional] 
**Body** | **string** | The contents of the issue. | [optional] 
**Assignee** | **string** | Login for the user that this issue should be assigned to. **This field is deprecated.** | [optional] 
**State** | **string** | State of the issue. Either &#x60;open&#x60; or &#x60;closed&#x60;. | [optional] 
**Milestone** | [**IssuesUpdateRequestMilestone**](IssuesUpdateRequestMilestone.md) |  | [optional] 
**Labels** | [**List<IssuesCreateRequestLabelsInner>**](IssuesCreateRequestLabelsInner.md) | Labels to associate with this issue. Pass one or more Labels to _replace_ the set of Labels on this Issue. Send an empty array (&#x60;[]&#x60;) to clear all Labels from the Issue. _NOTE: Only users with push access can set labels for issues. Labels are silently dropped otherwise._ | [optional] 
**Assignees** | **List<string>** | Logins for Users to assign to this issue. Pass one or more user logins to _replace_ the set of assignees on this Issue. Send an empty array (&#x60;[]&#x60;) to clear all assignees from the Issue. _NOTE: Only users with push access can set assignees for new issues. Assignees are silently dropped otherwise._ | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

