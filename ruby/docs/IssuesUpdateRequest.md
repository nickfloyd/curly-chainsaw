# OpenapiClient::IssuesUpdateRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **title** | [**IssuesUpdateRequestTitle**](IssuesUpdateRequestTitle.md) |  | [optional] |
| **body** | **String** | The contents of the issue. | [optional] |
| **assignee** | **String** | Login for the user that this issue should be assigned to. **This field is deprecated.** | [optional] |
| **state** | **String** | State of the issue. Either &#x60;open&#x60; or &#x60;closed&#x60;. | [optional] |
| **milestone** | [**IssuesUpdateRequestMilestone**](IssuesUpdateRequestMilestone.md) |  | [optional] |
| **labels** | [**Array&lt;IssuesCreateRequestLabelsInner&gt;**](IssuesCreateRequestLabelsInner.md) | Labels to associate with this issue. Pass one or more Labels to _replace_ the set of Labels on this Issue. Send an empty array (&#x60;[]&#x60;) to clear all Labels from the Issue. _NOTE: Only users with push access can set labels for issues. Labels are silently dropped otherwise._ | [optional] |
| **assignees** | **Array&lt;String&gt;** | Logins for Users to assign to this issue. Pass one or more user logins to _replace_ the set of assignees on this Issue. Send an empty array (&#x60;[]&#x60;) to clear all assignees from the Issue. _NOTE: Only users with push access can set assignees for new issues. Assignees are silently dropped otherwise._ | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::IssuesUpdateRequest.new(
  title: null,
  body: null,
  assignee: null,
  state: null,
  milestone: null,
  labels: null,
  assignees: null
)
```

