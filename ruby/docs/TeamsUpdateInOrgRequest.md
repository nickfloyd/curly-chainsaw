# OpenapiClient::TeamsUpdateInOrgRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **name** | **String** | The name of the team. | [optional] |
| **description** | **String** | The description of the team. | [optional] |
| **privacy** | **String** | The level of privacy this team should have. Editing teams without specifying this parameter leaves &#x60;privacy&#x60; intact. When a team is nested, the &#x60;privacy&#x60; for parent teams cannot be &#x60;secret&#x60;. The options are:   **For a non-nested team:**   \\* &#x60;secret&#x60; - only visible to organization owners and members of this team.   \\* &#x60;closed&#x60; - visible to all members of this organization.   **For a parent or child team:**   \\* &#x60;closed&#x60; - visible to all members of this organization. | [optional] |
| **permission** | **String** | **Deprecated**. The permission that new repositories will be added to the team with when none is specified. | [optional][default to &#39;pull&#39;] |
| **parent_team_id** | **Integer** | The ID of a team to set as the parent team. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::TeamsUpdateInOrgRequest.new(
  name: null,
  description: null,
  privacy: null,
  permission: null,
  parent_team_id: null
)
```

