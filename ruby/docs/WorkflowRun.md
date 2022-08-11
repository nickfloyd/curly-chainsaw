# OpenapiClient::WorkflowRun

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **id** | **Integer** | The ID of the workflow run. |  |
| **name** | **String** | The name of the workflow run. | [optional] |
| **node_id** | **String** |  |  |
| **check_suite_id** | **Integer** | The ID of the associated check suite. | [optional] |
| **check_suite_node_id** | **String** | The node ID of the associated check suite. | [optional] |
| **head_branch** | **String** |  |  |
| **head_sha** | **String** | The SHA of the head commit that points to the version of the workflow being run. |  |
| **path** | **String** | The full path of the workflow |  |
| **run_number** | **Integer** | The auto incrementing run number for the workflow run. |  |
| **run_attempt** | **Integer** | Attempt number of the run, 1 for first attempt and higher if the workflow was re-run. | [optional] |
| **referenced_workflows** | [**Array&lt;ReferencedWorkflow&gt;**](ReferencedWorkflow.md) |  | [optional] |
| **event** | **String** |  |  |
| **status** | **String** |  |  |
| **conclusion** | **String** |  |  |
| **workflow_id** | **Integer** | The ID of the parent workflow. |  |
| **url** | **String** | The URL to the workflow run. |  |
| **html_url** | **String** |  |  |
| **pull_requests** | [**Array&lt;PullRequestMinimal&gt;**](PullRequestMinimal.md) |  |  |
| **created_at** | **Time** |  |  |
| **updated_at** | **Time** |  |  |
| **actor** | [**SimpleUser1**](SimpleUser1.md) |  | [optional] |
| **triggering_actor** | [**SimpleUser1**](SimpleUser1.md) |  | [optional] |
| **run_started_at** | **Time** | The start time of the latest run. Resets on re-run. | [optional] |
| **jobs_url** | **String** | The URL to the jobs for the workflow run. |  |
| **logs_url** | **String** | The URL to download the logs for the workflow run. |  |
| **check_suite_url** | **String** | The URL to the associated check suite. |  |
| **artifacts_url** | **String** | The URL to the artifacts for the workflow run. |  |
| **cancel_url** | **String** | The URL to cancel the workflow run. |  |
| **rerun_url** | **String** | The URL to rerun the workflow run. |  |
| **previous_attempt_url** | **String** | The URL to the previous attempted run of this workflow, if one exists. | [optional] |
| **workflow_url** | **String** | The URL to the workflow. |  |
| **head_commit** | [**SimpleCommit**](SimpleCommit.md) |  |  |
| **repository** | [**MinimalRepository**](MinimalRepository.md) |  |  |
| **head_repository** | [**MinimalRepository**](MinimalRepository.md) |  |  |
| **head_repository_id** | **Integer** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::WorkflowRun.new(
  id: 5,
  name: Build,
  node_id: MDEwOkNoZWNrU3VpdGU1,
  check_suite_id: 42,
  check_suite_node_id: MDEwOkNoZWNrU3VpdGU0Mg&#x3D;&#x3D;,
  head_branch: master,
  head_sha: 009b8a3a9ccbb128af87f9b1c0f4c62e8a304f6d,
  path: octocat/octo-repo/.github/workflows/ci.yml@main,
  run_number: 106,
  run_attempt: 1,
  referenced_workflows: null,
  event: push,
  status: completed,
  conclusion: neutral,
  workflow_id: 5,
  url: https://api.github.com/repos/github/hello-world/actions/runs/5,
  html_url: https://github.com/github/hello-world/suites/4,
  pull_requests: null,
  created_at: null,
  updated_at: null,
  actor: null,
  triggering_actor: null,
  run_started_at: null,
  jobs_url: https://api.github.com/repos/github/hello-world/actions/runs/5/jobs,
  logs_url: https://api.github.com/repos/github/hello-world/actions/runs/5/logs,
  check_suite_url: https://api.github.com/repos/github/hello-world/check-suites/12,
  artifacts_url: https://api.github.com/repos/github/hello-world/actions/runs/5/rerun/artifacts,
  cancel_url: https://api.github.com/repos/github/hello-world/actions/runs/5/cancel,
  rerun_url: https://api.github.com/repos/github/hello-world/actions/runs/5/rerun,
  previous_attempt_url: https://api.github.com/repos/github/hello-world/actions/runs/5/attempts/3,
  workflow_url: https://api.github.com/repos/github/hello-world/actions/workflows/main.yaml,
  head_commit: null,
  repository: null,
  head_repository: null,
  head_repository_id: 5
)
```

