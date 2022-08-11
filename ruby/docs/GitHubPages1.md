# OpenapiClient::GitHubPages1

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **status_url** | **String** | The URI to monitor GitHub Pages deployment status. |  |
| **page_url** | **String** | The URI to the deployed GitHub Pages. |  |
| **preview_url** | **String** | The URI to the deployed GitHub Pages preview. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::GitHubPages1.new(
  status_url: https://api.github.com/repos/github/hello-world/pages/deployments/4fd754f7e594640989b406850d0bc8f06a121251/status,
  page_url: hello-world.github.io,
  preview_url: monalisa-1231a2312sa32-23sda74.drafts.github.io
)
```

