# OpenapiClient::DependabotCreateOrUpdateRepoSecretRequest

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **encrypted_value** | **String** | Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get a repository public key](https://docs.github.com/rest/reference/dependabot#get-a-repository-public-key) endpoint. | [optional] |
| **key_id** | **String** | ID of the key you used to encrypt the secret. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::DependabotCreateOrUpdateRepoSecretRequest.new(
  encrypted_value: null,
  key_id: null
)
```

