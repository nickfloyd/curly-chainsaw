# OpenapiClient::Deployment

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **url** | **String** |  |  |
| **id** | **Integer** | Unique identifier of the deployment |  |
| **node_id** | **String** |  |  |
| **sha** | **String** |  |  |
| **ref** | **String** | The ref to deploy. This can be a branch, tag, or sha. |  |
| **task** | **String** | Parameter to specify a task to execute |  |
| **payload** | [**DeploymentPayload**](DeploymentPayload.md) |  |  |
| **original_environment** | **String** |  | [optional] |
| **environment** | **String** | Name for the target deployment environment. |  |
| **description** | **String** |  |  |
| **creator** | [**SimpleUser**](SimpleUser.md) |  |  |
| **created_at** | **Time** |  |  |
| **updated_at** | **Time** |  |  |
| **statuses_url** | **String** |  |  |
| **repository_url** | **String** |  |  |
| **transient_environment** | **Boolean** | Specifies if the given environment is will no longer exist at some point in the future. Default: false. | [optional] |
| **production_environment** | **Boolean** | Specifies if the given environment is one that end-users directly interact with. Default: false. | [optional] |
| **performed_via_github_app** | [**GitHubApp1**](GitHubApp1.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::Deployment.new(
  url: https://api.github.com/repos/octocat/example/deployments/1,
  id: 42,
  node_id: MDEwOkRlcGxveW1lbnQx,
  sha: a84d88e7554fc1fa21bcbc4efae3c782a70d2b9d,
  ref: topic-branch,
  task: deploy,
  payload: null,
  original_environment: staging,
  environment: production,
  description: Deploy request from hubot,
  creator: null,
  created_at: 2012-07-20T01:19:13Z,
  updated_at: 2012-07-20T01:19:13Z,
  statuses_url: https://api.github.com/repos/octocat/example/deployments/1/statuses,
  repository_url: https://api.github.com/repos/octocat/example,
  transient_environment: true,
  production_environment: true,
  performed_via_github_app: null
)
```

