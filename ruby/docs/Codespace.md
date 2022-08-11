# OpenapiClient::Codespace

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **id** | **Integer** |  |  |
| **name** | **String** | Automatically generated name of this codespace. |  |
| **display_name** | **String** | Display name for this codespace. | [optional] |
| **environment_id** | **String** | UUID identifying this codespace&#39;s environment. |  |
| **owner** | [**SimpleUser1**](SimpleUser1.md) |  |  |
| **billable_owner** | [**SimpleUser1**](SimpleUser1.md) |  |  |
| **repository** | [**MinimalRepository**](MinimalRepository.md) |  |  |
| **machine** | [**CodespaceMachine**](CodespaceMachine.md) |  |  |
| **devcontainer_path** | **String** | Path to devcontainer.json from repo root used to create Codespace. | [optional] |
| **prebuild** | **Boolean** | Whether the codespace was created from a prebuild. |  |
| **created_at** | **Time** |  |  |
| **updated_at** | **Time** |  |  |
| **last_used_at** | **Time** | Last known time this codespace was started. |  |
| **state** | **String** | State of this codespace. |  |
| **url** | **String** | API URL for this codespace. |  |
| **git_status** | [**CodespaceGitStatus**](CodespaceGitStatus.md) |  |  |
| **location** | **String** | The Azure region where this codespace is located. |  |
| **idle_timeout_minutes** | **Integer** | The number of minutes of inactivity after which this codespace will be automatically stopped. |  |
| **web_url** | **String** | URL to access this codespace on the web. |  |
| **machines_url** | **String** | API URL to access available alternate machine types for this codespace. |  |
| **start_url** | **String** | API URL to start this codespace. |  |
| **stop_url** | **String** | API URL to stop this codespace. |  |
| **pulls_url** | **String** | API URL for the Pull Request associated with this codespace, if any. |  |
| **recent_folders** | **Array&lt;String&gt;** |  |  |
| **runtime_constraints** | [**CodespaceRuntimeConstraints**](CodespaceRuntimeConstraints.md) |  | [optional] |
| **pending_operation** | **Boolean** | Whether or not a codespace has a pending async operation. This would mean that the codespace is temporarily unavailable. The only thing that you can do with a codespace in this state is delete it. | [optional] |
| **pending_operation_disabled_reason** | **String** | Text to show user when codespace is disabled by a pending operation | [optional] |
| **idle_timeout_notice** | **String** | Text to show user when codespace idle timeout minutes has been overriden by an organization policy | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::Codespace.new(
  id: 1,
  name: monalisa-octocat-hello-world-g4wpq6h95q,
  display_name: bookish space pancake,
  environment_id: 26a7c758-7299-4a73-b978-5a92a7ae98a0,
  owner: null,
  billable_owner: null,
  repository: null,
  machine: null,
  devcontainer_path: .devcontainer/example/devcontainer.json,
  prebuild: false,
  created_at: 2011-01-26T19:01:12Z,
  updated_at: 2011-01-26T19:01:12Z,
  last_used_at: 2011-01-26T19:01:12Z,
  state: Available,
  url: null,
  git_status: null,
  location: WestUs2,
  idle_timeout_minutes: 60,
  web_url: null,
  machines_url: null,
  start_url: null,
  stop_url: null,
  pulls_url: null,
  recent_folders: null,
  runtime_constraints: null,
  pending_operation: null,
  pending_operation_disabled_reason: null,
  idle_timeout_notice: null
)
```

