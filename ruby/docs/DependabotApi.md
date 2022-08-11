# OpenapiClient::DependabotApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**dependabot_add_selected_repo_to_org_secret**](DependabotApi.md#dependabot_add_selected_repo_to_org_secret) | **PUT** /orgs/{org}/dependabot/secrets/{secret_name}/repositories/{repository_id} | Add selected repository to an organization secret |
| [**dependabot_create_or_update_org_secret**](DependabotApi.md#dependabot_create_or_update_org_secret) | **PUT** /orgs/{org}/dependabot/secrets/{secret_name} | Create or update an organization secret |
| [**dependabot_create_or_update_repo_secret**](DependabotApi.md#dependabot_create_or_update_repo_secret) | **PUT** /repos/{owner}/{repo}/dependabot/secrets/{secret_name} | Create or update a repository secret |
| [**dependabot_delete_org_secret**](DependabotApi.md#dependabot_delete_org_secret) | **DELETE** /orgs/{org}/dependabot/secrets/{secret_name} | Delete an organization secret |
| [**dependabot_delete_repo_secret**](DependabotApi.md#dependabot_delete_repo_secret) | **DELETE** /repos/{owner}/{repo}/dependabot/secrets/{secret_name} | Delete a repository secret |
| [**dependabot_get_org_public_key**](DependabotApi.md#dependabot_get_org_public_key) | **GET** /orgs/{org}/dependabot/secrets/public-key | Get an organization public key |
| [**dependabot_get_org_secret**](DependabotApi.md#dependabot_get_org_secret) | **GET** /orgs/{org}/dependabot/secrets/{secret_name} | Get an organization secret |
| [**dependabot_get_repo_public_key**](DependabotApi.md#dependabot_get_repo_public_key) | **GET** /repos/{owner}/{repo}/dependabot/secrets/public-key | Get a repository public key |
| [**dependabot_get_repo_secret**](DependabotApi.md#dependabot_get_repo_secret) | **GET** /repos/{owner}/{repo}/dependabot/secrets/{secret_name} | Get a repository secret |
| [**dependabot_list_org_secrets**](DependabotApi.md#dependabot_list_org_secrets) | **GET** /orgs/{org}/dependabot/secrets | List organization secrets |
| [**dependabot_list_repo_secrets**](DependabotApi.md#dependabot_list_repo_secrets) | **GET** /repos/{owner}/{repo}/dependabot/secrets | List repository secrets |
| [**dependabot_list_selected_repos_for_org_secret**](DependabotApi.md#dependabot_list_selected_repos_for_org_secret) | **GET** /orgs/{org}/dependabot/secrets/{secret_name}/repositories | List selected repositories for an organization secret |
| [**dependabot_remove_selected_repo_from_org_secret**](DependabotApi.md#dependabot_remove_selected_repo_from_org_secret) | **DELETE** /orgs/{org}/dependabot/secrets/{secret_name}/repositories/{repository_id} | Remove selected repository from an organization secret |
| [**dependabot_set_selected_repos_for_org_secret**](DependabotApi.md#dependabot_set_selected_repos_for_org_secret) | **PUT** /orgs/{org}/dependabot/secrets/{secret_name}/repositories | Set selected repositories for an organization secret |


## dependabot_add_selected_repo_to_org_secret

> dependabot_add_selected_repo_to_org_secret(org, secret_name, repository_id)

Add selected repository to an organization secret

Adds a repository to an organization secret when the `visibility` for repository access is set to `selected`. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/dependabot#create-or-update-an-organization-secret). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
repository_id = 56 # Integer | 

begin
  # Add selected repository to an organization secret
  api_instance.dependabot_add_selected_repo_to_org_secret(org, secret_name, repository_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_add_selected_repo_to_org_secret: #{e}"
end
```

#### Using the dependabot_add_selected_repo_to_org_secret_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> dependabot_add_selected_repo_to_org_secret_with_http_info(org, secret_name, repository_id)

```ruby
begin
  # Add selected repository to an organization secret
  data, status_code, headers = api_instance.dependabot_add_selected_repo_to_org_secret_with_http_info(org, secret_name, repository_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_add_selected_repo_to_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **repository_id** | **Integer** |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## dependabot_create_or_update_org_secret

> Object dependabot_create_or_update_org_secret(org, secret_name, dependabot_create_or_update_org_secret_request)

Create or update an organization secret

Creates or updates an organization secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
dependabot_create_or_update_org_secret_request = OpenapiClient::DependabotCreateOrUpdateOrgSecretRequest.new({visibility: 'all'}) # DependabotCreateOrUpdateOrgSecretRequest | 

begin
  # Create or update an organization secret
  result = api_instance.dependabot_create_or_update_org_secret(org, secret_name, dependabot_create_or_update_org_secret_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_create_or_update_org_secret: #{e}"
end
```

#### Using the dependabot_create_or_update_org_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> dependabot_create_or_update_org_secret_with_http_info(org, secret_name, dependabot_create_or_update_org_secret_request)

```ruby
begin
  # Create or update an organization secret
  data, status_code, headers = api_instance.dependabot_create_or_update_org_secret_with_http_info(org, secret_name, dependabot_create_or_update_org_secret_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_create_or_update_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **dependabot_create_or_update_org_secret_request** | [**DependabotCreateOrUpdateOrgSecretRequest**](DependabotCreateOrUpdateOrgSecretRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## dependabot_create_or_update_repo_secret

> Object dependabot_create_or_update_repo_secret(owner, repo, secret_name, dependabot_create_or_update_repo_secret_request)

Create or update a repository secret

Creates or updates a repository secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` repository permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
dependabot_create_or_update_repo_secret_request = OpenapiClient::DependabotCreateOrUpdateRepoSecretRequest.new # DependabotCreateOrUpdateRepoSecretRequest | 

begin
  # Create or update a repository secret
  result = api_instance.dependabot_create_or_update_repo_secret(owner, repo, secret_name, dependabot_create_or_update_repo_secret_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_create_or_update_repo_secret: #{e}"
end
```

#### Using the dependabot_create_or_update_repo_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> dependabot_create_or_update_repo_secret_with_http_info(owner, repo, secret_name, dependabot_create_or_update_repo_secret_request)

```ruby
begin
  # Create or update a repository secret
  data, status_code, headers = api_instance.dependabot_create_or_update_repo_secret_with_http_info(owner, repo, secret_name, dependabot_create_or_update_repo_secret_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_create_or_update_repo_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **dependabot_create_or_update_repo_secret_request** | [**DependabotCreateOrUpdateRepoSecretRequest**](DependabotCreateOrUpdateRepoSecretRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## dependabot_delete_org_secret

> dependabot_delete_org_secret(org, secret_name)

Delete an organization secret

Deletes a secret in an organization using the secret name. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Delete an organization secret
  api_instance.dependabot_delete_org_secret(org, secret_name)
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_delete_org_secret: #{e}"
end
```

#### Using the dependabot_delete_org_secret_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> dependabot_delete_org_secret_with_http_info(org, secret_name)

```ruby
begin
  # Delete an organization secret
  data, status_code, headers = api_instance.dependabot_delete_org_secret_with_http_info(org, secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_delete_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## dependabot_delete_repo_secret

> dependabot_delete_repo_secret(owner, repo, secret_name)

Delete a repository secret

Deletes a secret in a repository using the secret name. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Delete a repository secret
  api_instance.dependabot_delete_repo_secret(owner, repo, secret_name)
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_delete_repo_secret: #{e}"
end
```

#### Using the dependabot_delete_repo_secret_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> dependabot_delete_repo_secret_with_http_info(owner, repo, secret_name)

```ruby
begin
  # Delete a repository secret
  data, status_code, headers = api_instance.dependabot_delete_repo_secret_with_http_info(owner, repo, secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_delete_repo_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## dependabot_get_org_public_key

> <DependabotPublicKey> dependabot_get_org_public_key(org)

Get an organization public key

Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.

begin
  # Get an organization public key
  result = api_instance.dependabot_get_org_public_key(org)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_get_org_public_key: #{e}"
end
```

#### Using the dependabot_get_org_public_key_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<DependabotPublicKey>, Integer, Hash)> dependabot_get_org_public_key_with_http_info(org)

```ruby
begin
  # Get an organization public key
  data, status_code, headers = api_instance.dependabot_get_org_public_key_with_http_info(org)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <DependabotPublicKey>
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_get_org_public_key_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |

### Return type

[**DependabotPublicKey**](DependabotPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## dependabot_get_org_secret

> <DependabotSecretForAnOrganization> dependabot_get_org_secret(org, secret_name)

Get an organization secret

Gets a single organization secret without revealing its encrypted value. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Get an organization secret
  result = api_instance.dependabot_get_org_secret(org, secret_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_get_org_secret: #{e}"
end
```

#### Using the dependabot_get_org_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<DependabotSecretForAnOrganization>, Integer, Hash)> dependabot_get_org_secret_with_http_info(org, secret_name)

```ruby
begin
  # Get an organization secret
  data, status_code, headers = api_instance.dependabot_get_org_secret_with_http_info(org, secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <DependabotSecretForAnOrganization>
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_get_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

[**DependabotSecretForAnOrganization**](DependabotSecretForAnOrganization.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## dependabot_get_repo_public_key

> <DependabotPublicKey> dependabot_get_repo_public_key(owner, repo)

Get a repository public key

Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `dependabot_secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get a repository public key
  result = api_instance.dependabot_get_repo_public_key(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_get_repo_public_key: #{e}"
end
```

#### Using the dependabot_get_repo_public_key_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<DependabotPublicKey>, Integer, Hash)> dependabot_get_repo_public_key_with_http_info(owner, repo)

```ruby
begin
  # Get a repository public key
  data, status_code, headers = api_instance.dependabot_get_repo_public_key_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <DependabotPublicKey>
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_get_repo_public_key_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**DependabotPublicKey**](DependabotPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## dependabot_get_repo_secret

> <DependabotSecret> dependabot_get_repo_secret(owner, repo, secret_name)

Get a repository secret

Gets a single repository secret without revealing its encrypted value. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Get a repository secret
  result = api_instance.dependabot_get_repo_secret(owner, repo, secret_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_get_repo_secret: #{e}"
end
```

#### Using the dependabot_get_repo_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<DependabotSecret>, Integer, Hash)> dependabot_get_repo_secret_with_http_info(owner, repo, secret_name)

```ruby
begin
  # Get a repository secret
  data, status_code, headers = api_instance.dependabot_get_repo_secret_with_http_info(owner, repo, secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <DependabotSecret>
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_get_repo_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

[**DependabotSecret**](DependabotSecret.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## dependabot_list_org_secrets

> <DependabotListOrgSecrets200Response> dependabot_list_org_secrets(org, opts)

List organization secrets

Lists all secrets available in an organization without revealing their encrypted values. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List organization secrets
  result = api_instance.dependabot_list_org_secrets(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_list_org_secrets: #{e}"
end
```

#### Using the dependabot_list_org_secrets_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<DependabotListOrgSecrets200Response>, Integer, Hash)> dependabot_list_org_secrets_with_http_info(org, opts)

```ruby
begin
  # List organization secrets
  data, status_code, headers = api_instance.dependabot_list_org_secrets_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <DependabotListOrgSecrets200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_list_org_secrets_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**DependabotListOrgSecrets200Response**](DependabotListOrgSecrets200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## dependabot_list_repo_secrets

> <DependabotListRepoSecrets200Response> dependabot_list_repo_secrets(owner, repo, opts)

List repository secrets

Lists all secrets available in a repository without revealing their encrypted values. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repository secrets
  result = api_instance.dependabot_list_repo_secrets(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_list_repo_secrets: #{e}"
end
```

#### Using the dependabot_list_repo_secrets_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<DependabotListRepoSecrets200Response>, Integer, Hash)> dependabot_list_repo_secrets_with_http_info(owner, repo, opts)

```ruby
begin
  # List repository secrets
  data, status_code, headers = api_instance.dependabot_list_repo_secrets_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <DependabotListRepoSecrets200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_list_repo_secrets_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**DependabotListRepoSecrets200Response**](DependabotListRepoSecrets200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## dependabot_list_selected_repos_for_org_secret

> <ActionsListSelectedReposForOrgSecret200Response> dependabot_list_selected_repos_for_org_secret(org, secret_name, opts)

List selected repositories for an organization secret

Lists all repositories that have been selected when the `visibility` for repository access to a secret is set to `selected`. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
opts = {
  page: 56, # Integer | Page number of the results to fetch.
  per_page: 56 # Integer | The number of results per page (max 100).
}

begin
  # List selected repositories for an organization secret
  result = api_instance.dependabot_list_selected_repos_for_org_secret(org, secret_name, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_list_selected_repos_for_org_secret: #{e}"
end
```

#### Using the dependabot_list_selected_repos_for_org_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListSelectedReposForOrgSecret200Response>, Integer, Hash)> dependabot_list_selected_repos_for_org_secret_with_http_info(org, secret_name, opts)

```ruby
begin
  # List selected repositories for an organization secret
  data, status_code, headers = api_instance.dependabot_list_selected_repos_for_org_secret_with_http_info(org, secret_name, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListSelectedReposForOrgSecret200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_list_selected_repos_for_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |

### Return type

[**ActionsListSelectedReposForOrgSecret200Response**](ActionsListSelectedReposForOrgSecret200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## dependabot_remove_selected_repo_from_org_secret

> dependabot_remove_selected_repo_from_org_secret(org, secret_name, repository_id)

Remove selected repository from an organization secret

Removes a repository from an organization secret when the `visibility` for repository access is set to `selected`. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/dependabot#create-or-update-an-organization-secret). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
repository_id = 56 # Integer | 

begin
  # Remove selected repository from an organization secret
  api_instance.dependabot_remove_selected_repo_from_org_secret(org, secret_name, repository_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_remove_selected_repo_from_org_secret: #{e}"
end
```

#### Using the dependabot_remove_selected_repo_from_org_secret_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> dependabot_remove_selected_repo_from_org_secret_with_http_info(org, secret_name, repository_id)

```ruby
begin
  # Remove selected repository from an organization secret
  data, status_code, headers = api_instance.dependabot_remove_selected_repo_from_org_secret_with_http_info(org, secret_name, repository_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_remove_selected_repo_from_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **repository_id** | **Integer** |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## dependabot_set_selected_repos_for_org_secret

> dependabot_set_selected_repos_for_org_secret(org, secret_name, dependabot_set_selected_repos_for_org_secret_request)

Set selected repositories for an organization secret

Replaces all repositories for an organization secret when the `visibility` for repository access is set to `selected`. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/dependabot#create-or-update-an-organization-secret). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::DependabotApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
dependabot_set_selected_repos_for_org_secret_request = OpenapiClient::DependabotSetSelectedReposForOrgSecretRequest.new({selected_repository_ids: [37]}) # DependabotSetSelectedReposForOrgSecretRequest | 

begin
  # Set selected repositories for an organization secret
  api_instance.dependabot_set_selected_repos_for_org_secret(org, secret_name, dependabot_set_selected_repos_for_org_secret_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_set_selected_repos_for_org_secret: #{e}"
end
```

#### Using the dependabot_set_selected_repos_for_org_secret_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> dependabot_set_selected_repos_for_org_secret_with_http_info(org, secret_name, dependabot_set_selected_repos_for_org_secret_request)

```ruby
begin
  # Set selected repositories for an organization secret
  data, status_code, headers = api_instance.dependabot_set_selected_repos_for_org_secret_with_http_info(org, secret_name, dependabot_set_selected_repos_for_org_secret_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling DependabotApi->dependabot_set_selected_repos_for_org_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **dependabot_set_selected_repos_for_org_secret_request** | [**DependabotSetSelectedReposForOrgSecretRequest**](DependabotSetSelectedReposForOrgSecretRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

