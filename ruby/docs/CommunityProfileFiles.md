# OpenapiClient::CommunityProfileFiles

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **code_of_conduct** | [**CodeOfConductSimple1**](CodeOfConductSimple1.md) |  |  |
| **code_of_conduct_file** | [**CommunityHealthFile**](CommunityHealthFile.md) |  |  |
| **license** | [**LicenseSimple**](LicenseSimple.md) |  |  |
| **contributing** | [**CommunityHealthFile**](CommunityHealthFile.md) |  |  |
| **readme** | [**CommunityHealthFile**](CommunityHealthFile.md) |  |  |
| **issue_template** | [**CommunityHealthFile**](CommunityHealthFile.md) |  |  |
| **pull_request_template** | [**CommunityHealthFile**](CommunityHealthFile.md) |  |  |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::CommunityProfileFiles.new(
  code_of_conduct: null,
  code_of_conduct_file: null,
  license: null,
  contributing: null,
  readme: null,
  issue_template: null,
  pull_request_template: null
)
```

