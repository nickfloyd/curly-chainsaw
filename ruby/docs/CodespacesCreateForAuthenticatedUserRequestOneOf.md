# OpenapiClient::CodespacesCreateForAuthenticatedUserRequestOneOf

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **repository_id** | **Integer** | Repository id for this codespace |  |
| **ref** | **String** | Git ref (typically a branch name) for this codespace | [optional] |
| **location** | **String** | Location for this codespace. Assigned by IP if not provided | [optional] |
| **client_ip** | **String** | IP for location auto-detection when proxying a request | [optional] |
| **machine** | **String** | Machine type to use for this codespace | [optional] |
| **devcontainer_path** | **String** | Path to devcontainer.json config to use for this codespace | [optional] |
| **multi_repo_permissions_opt_out** | **Boolean** | Whether to authorize requested permissions from devcontainer.json | [optional] |
| **working_directory** | **String** | Working directory for this codespace | [optional] |
| **idle_timeout_minutes** | **Integer** | Time in minutes before codespace stops from inactivity | [optional] |
| **display_name** | **String** | Display name for this codespace | [optional] |
| **retention_period_minutes** | **Integer** | Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days). | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::CodespacesCreateForAuthenticatedUserRequestOneOf.new(
  repository_id: null,
  ref: null,
  location: null,
  client_ip: null,
  machine: null,
  devcontainer_path: null,
  multi_repo_permissions_opt_out: null,
  working_directory: null,
  idle_timeout_minutes: null,
  display_name: null,
  retention_period_minutes: null
)
```

