# OpenapiClient::ReposGetContent200Response

## Class instance methods

### `openapi_one_of`

Returns the list of classes defined in oneOf.

#### Example

```ruby
require 'openapi_client'

OpenapiClient::ReposGetContent200Response.openapi_one_of
# =>
# [
#   :'Array<ContentTreeEntriesInner>',
#   :'ContentFile',
#   :'SymlinkContent',
#   :'SymlinkContent1'
# ]
```

### build

Find the appropriate object from the `openapi_one_of` list and casts the data into it.

#### Example

```ruby
require 'openapi_client'

OpenapiClient::ReposGetContent200Response.build(data)
# => #<Array<ContentTreeEntriesInner>:0x00007fdd4aab02a0>

OpenapiClient::ReposGetContent200Response.build(data_that_doesnt_match)
# => nil
```

#### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| **data** | **Mixed** | data to be matched against the list of oneOf items |

#### Return type

- `Array<ContentTreeEntriesInner>`
- `ContentFile`
- `SymlinkContent`
- `SymlinkContent1`
- `nil` (if no type matches)

