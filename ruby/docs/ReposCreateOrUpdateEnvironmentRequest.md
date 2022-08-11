# OpenapiClient::ReposCreateOrUpdateEnvironmentRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **wait_timer** | **Integer** | The amount of time to delay a job after the job is initially triggered. The time (in minutes) must be an integer between 0 and 43,200 (30 days). | [optional] |
| **reviewers** | [**Array&lt;ReposCreateOrUpdateEnvironmentRequestReviewersInner&gt;**](ReposCreateOrUpdateEnvironmentRequestReviewersInner.md) | The people or teams that may review jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed. | [optional] |
| **deployment_branch_policy** | [**EnvironmentDeploymentBranchPolicy**](EnvironmentDeploymentBranchPolicy.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ReposCreateOrUpdateEnvironmentRequest.new(
  wait_timer: 30,
  reviewers: null,
  deployment_branch_policy: null
)
```

