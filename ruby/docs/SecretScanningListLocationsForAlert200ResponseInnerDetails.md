# OpenapiClient::SecretScanningListLocationsForAlert200ResponseInnerDetails

## Class instance methods

### `openapi_one_of`

Returns the list of classes defined in oneOf.

#### Example

```ruby
require 'openapi_client'

OpenapiClient::SecretScanningListLocationsForAlert200ResponseInnerDetails.openapi_one_of
# =>
# [
#   :'SecretScanningListLocationsForAlert200ResponseInnerDetailsOneOf'
# ]
```

### build

Find the appropriate object from the `openapi_one_of` list and casts the data into it.

#### Example

```ruby
require 'openapi_client'

OpenapiClient::SecretScanningListLocationsForAlert200ResponseInnerDetails.build(data)
# => #<SecretScanningListLocationsForAlert200ResponseInnerDetailsOneOf:0x00007fdd4aab02a0>

OpenapiClient::SecretScanningListLocationsForAlert200ResponseInnerDetails.build(data_that_doesnt_match)
# => nil
```

#### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| **data** | **Mixed** | data to be matched against the list of oneOf items |

#### Return type

- `SecretScanningListLocationsForAlert200ResponseInnerDetailsOneOf`
- `nil` (if no type matches)

