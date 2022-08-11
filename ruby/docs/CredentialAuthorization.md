# OpenapiClient::CredentialAuthorization

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **login** | **String** | User login that owns the underlying credential. |  |
| **credential_id** | **Integer** | Unique identifier for the credential. |  |
| **credential_type** | **String** | Human-readable description of the credential type. |  |
| **token_last_eight** | **String** | Last eight characters of the credential. Only included in responses with credential_type of personal access token. | [optional] |
| **credential_authorized_at** | **Time** | Date when the credential was authorized for use. |  |
| **scopes** | **Array&lt;String&gt;** | List of oauth scopes the token has been granted. | [optional] |
| **fingerprint** | **String** | Unique string to distinguish the credential. Only included in responses with credential_type of SSH Key. | [optional] |
| **credential_accessed_at** | **Time** | Date when the credential was last accessed. May be null if it was never accessed |  |
| **authorized_credential_id** | **Integer** |  |  |
| **authorized_credential_title** | **String** | The title given to the ssh key. This will only be present when the credential is an ssh key. | [optional] |
| **authorized_credential_note** | **String** | The note given to the token. This will only be present when the credential is a token. | [optional] |
| **authorized_credential_expires_at** | **Time** | The expiry for the token. This will only be present when the credential is a token. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::CredentialAuthorization.new(
  login: monalisa,
  credential_id: 1,
  credential_type: SSH Key,
  token_last_eight: 12345678,
  credential_authorized_at: 2011-01-26T19:06:43Z,
  scopes: [&quot;user&quot;,&quot;repo&quot;],
  fingerprint: jklmnop12345678,
  credential_accessed_at: 2011-01-26T19:06:43Z,
  authorized_credential_id: 12345678,
  authorized_credential_title: my ssh key,
  authorized_credential_note: my token,
  authorized_credential_expires_at: null
)
```

