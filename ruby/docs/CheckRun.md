# OpenapiClient::CheckRun

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **id** | **Integer** | The id of the check. |  |
| **head_sha** | **String** | The SHA of the commit that is being checked. |  |
| **node_id** | **String** |  |  |
| **external_id** | **String** |  |  |
| **url** | **String** |  |  |
| **html_url** | **String** |  |  |
| **details_url** | **String** |  |  |
| **status** | **String** | The phase of the lifecycle that the check is currently in. |  |
| **conclusion** | **String** |  |  |
| **started_at** | **Time** |  |  |
| **completed_at** | **Time** |  |  |
| **output** | [**CheckRunOutput**](CheckRunOutput.md) |  |  |
| **name** | **String** | The name of the check. |  |
| **check_suite** | [**CheckRunCheckSuite**](CheckRunCheckSuite.md) |  |  |
| **app** | [**GitHubApp1**](GitHubApp1.md) |  |  |
| **pull_requests** | [**Array&lt;PullRequestMinimal&gt;**](PullRequestMinimal.md) |  |  |
| **deployment** | [**Deployment1**](Deployment1.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::CheckRun.new(
  id: 21,
  head_sha: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d,
  node_id: MDg6Q2hlY2tSdW40,
  external_id: 42,
  url: https://api.github.com/repos/github/hello-world/check-runs/4,
  html_url: https://github.com/github/hello-world/runs/4,
  details_url: https://example.com,
  status: queued,
  conclusion: neutral,
  started_at: 2018-05-04T01:14:52Z,
  completed_at: 2018-05-04T01:14:52Z,
  output: null,
  name: test-coverage,
  check_suite: null,
  app: null,
  pull_requests: null,
  deployment: null
)
```

