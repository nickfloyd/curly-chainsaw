# OpenapiClient::SnapshotJob

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **id** | **String** | The external ID of the job. |  |
| **correlator** | **String** | Correlator provides a key that is used to group snapshots submitted over time. Only the \&quot;latest\&quot; submitted snapshot for a given combination of &#x60;job.correlator&#x60; and &#x60;detector.name&#x60; will be considered when calculating a repository&#39;s current dependencies. Correlator should be as unique as it takes to distinguish all detection runs for a given \&quot;wave\&quot; of CI workflow you run. If you&#39;re using GitHub Actions, a good default value for this could be the environment variables GITHUB_WORKFLOW and GITHUB_JOB concatenated together. If you&#39;re using a build matrix, then you&#39;ll also need to add additional key(s) to distinguish between each submission inside a matrix variation. |  |
| **html_url** | **String** | The url for the job. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::SnapshotJob.new(
  id: 5622a2b0-63f6-4732-8c34-a1ab27e102a11,
  correlator: yourworkflowname_yourjobname,
  html_url: http://example.com/build
)
```

