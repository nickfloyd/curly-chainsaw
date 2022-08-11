# OpenapiClient::DependencyGraphDiffInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **change_type** | **String** |  |  |
| **manifest** | **String** |  |  |
| **ecosystem** | **String** |  |  |
| **name** | **String** |  |  |
| **version** | **String** |  |  |
| **package_url** | **String** |  |  |
| **license** | **String** |  |  |
| **source_repository_url** | **String** |  |  |
| **vulnerabilities** | [**Array&lt;DependencyGraphDiffInnerVulnerabilitiesInner&gt;**](DependencyGraphDiffInnerVulnerabilitiesInner.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::DependencyGraphDiffInner.new(
  change_type: null,
  manifest: path/to/package-lock.json,
  ecosystem: npm,
  name: @actions/core,
  version: 1.0.0,
  package_url: pkg:/npm/%40actions/core@1.1.0,
  license: MIT,
  source_repository_url: https://github.com/github/actions,
  vulnerabilities: null
)
```

