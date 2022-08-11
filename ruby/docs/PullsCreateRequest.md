# OpenapiClient::PullsCreateRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **title** | **String** | The title of the new pull request. Required unless &#x60;issue&#x60; is specified. | [optional] |
| **head** | **String** | The name of the branch where your changes are implemented. For cross-repository pull requests in the same network, namespace &#x60;head&#x60; with a user like this: &#x60;username:branch&#x60;. |  |
| **base** | **String** | The name of the branch you want the changes pulled into. This should be an existing branch on the current repository. You cannot submit a pull request to one repository that requests a merge to a base of another repository. |  |
| **body** | **String** | The contents of the pull request. | [optional] |
| **maintainer_can_modify** | **Boolean** | Indicates whether [maintainers can modify](https://docs.github.com/articles/allowing-changes-to-a-pull-request-branch-created-from-a-fork/) the pull request. | [optional] |
| **draft** | **Boolean** | Indicates whether the pull request is a draft. See \&quot;[Draft Pull Requests](https://docs.github.com/en/articles/about-pull-requests#draft-pull-requests)\&quot; in the GitHub Help documentation to learn more. | [optional] |
| **issue** | **Integer** | An issue in the repository to convert to a pull request. The issue title, body, and comments will become the title, body, and comments on the new pull request. Required unless &#x60;title&#x60; is specified. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::PullsCreateRequest.new(
  title: null,
  head: null,
  base: null,
  body: null,
  maintainer_can_modify: null,
  draft: null,
  issue: 1
)
```

