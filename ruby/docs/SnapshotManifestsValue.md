# OpenapiClient::SnapshotManifestsValue

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **name** | **String** | The name of the manifest. |  |
| **file** | [**SnapshotManifestsValueFile**](SnapshotManifestsValueFile.md) |  | [optional] |
| **metadata** | [**Hash&lt;String, Metadata&gt;**](Metadata.md) | User-defined metadata to store domain-specific information limited to 8 keys with scalar values. | [optional] |
| **resolved** | [**Hash&lt;String, SnapshotManifestsValueResolvedValue&gt;**](SnapshotManifestsValueResolvedValue.md) |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::SnapshotManifestsValue.new(
  name: package-lock.json,
  file: null,
  metadata: null,
  resolved: null
)
```

