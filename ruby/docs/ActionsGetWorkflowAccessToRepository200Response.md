# OpenapiClient::ActionsGetWorkflowAccessToRepository200Response

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **access_level** | **String** | Defines the level of access that workflows outside of the repository have to actions and reusable workflows within the repository. &#x60;none&#x60; means access is only possible from workflows in this repository. |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ActionsGetWorkflowAccessToRepository200Response.new(
  access_level: null
)
```

