# OpenapiClient::CodespacesApi

All URIs are relative to *https://api.github.com*

| Method | HTTP request | Description |
| ------ | ------------ | ----------- |
| [**codespaces_add_repository_for_secret_for_authenticated_user**](CodespacesApi.md#codespaces_add_repository_for_secret_for_authenticated_user) | **PUT** /user/codespaces/secrets/{secret_name}/repositories/{repository_id} | Add a selected repository to a user secret |
| [**codespaces_codespace_machines_for_authenticated_user**](CodespacesApi.md#codespaces_codespace_machines_for_authenticated_user) | **GET** /user/codespaces/{codespace_name}/machines | List machine types for a codespace |
| [**codespaces_create_for_authenticated_user**](CodespacesApi.md#codespaces_create_for_authenticated_user) | **POST** /user/codespaces | Create a codespace for the authenticated user |
| [**codespaces_create_or_update_repo_secret**](CodespacesApi.md#codespaces_create_or_update_repo_secret) | **PUT** /repos/{owner}/{repo}/codespaces/secrets/{secret_name} | Create or update a repository secret |
| [**codespaces_create_or_update_secret_for_authenticated_user**](CodespacesApi.md#codespaces_create_or_update_secret_for_authenticated_user) | **PUT** /user/codespaces/secrets/{secret_name} | Create or update a secret for the authenticated user |
| [**codespaces_create_with_pr_for_authenticated_user**](CodespacesApi.md#codespaces_create_with_pr_for_authenticated_user) | **POST** /repos/{owner}/{repo}/pulls/{pull_number}/codespaces | Create a codespace from a pull request |
| [**codespaces_create_with_repo_for_authenticated_user**](CodespacesApi.md#codespaces_create_with_repo_for_authenticated_user) | **POST** /repos/{owner}/{repo}/codespaces | Create a codespace in a repository |
| [**codespaces_delete_for_authenticated_user**](CodespacesApi.md#codespaces_delete_for_authenticated_user) | **DELETE** /user/codespaces/{codespace_name} | Delete a codespace for the authenticated user |
| [**codespaces_delete_from_organization**](CodespacesApi.md#codespaces_delete_from_organization) | **DELETE** /orgs/{org}/members/{username}/codespaces/{codespace_name} | Delete a codespace from the organization |
| [**codespaces_delete_repo_secret**](CodespacesApi.md#codespaces_delete_repo_secret) | **DELETE** /repos/{owner}/{repo}/codespaces/secrets/{secret_name} | Delete a repository secret |
| [**codespaces_delete_secret_for_authenticated_user**](CodespacesApi.md#codespaces_delete_secret_for_authenticated_user) | **DELETE** /user/codespaces/secrets/{secret_name} | Delete a secret for the authenticated user |
| [**codespaces_export_for_authenticated_user**](CodespacesApi.md#codespaces_export_for_authenticated_user) | **POST** /user/codespaces/{codespace_name}/exports | Export a codespace for the authenticated user |
| [**codespaces_get_export_details_for_authenticated_user**](CodespacesApi.md#codespaces_get_export_details_for_authenticated_user) | **GET** /user/codespaces/{codespace_name}/exports/{export_id} | Get details about a codespace export |
| [**codespaces_get_for_authenticated_user**](CodespacesApi.md#codespaces_get_for_authenticated_user) | **GET** /user/codespaces/{codespace_name} | Get a codespace for the authenticated user |
| [**codespaces_get_public_key_for_authenticated_user**](CodespacesApi.md#codespaces_get_public_key_for_authenticated_user) | **GET** /user/codespaces/secrets/public-key | Get public key for the authenticated user |
| [**codespaces_get_repo_public_key**](CodespacesApi.md#codespaces_get_repo_public_key) | **GET** /repos/{owner}/{repo}/codespaces/secrets/public-key | Get a repository public key |
| [**codespaces_get_repo_secret**](CodespacesApi.md#codespaces_get_repo_secret) | **GET** /repos/{owner}/{repo}/codespaces/secrets/{secret_name} | Get a repository secret |
| [**codespaces_get_secret_for_authenticated_user**](CodespacesApi.md#codespaces_get_secret_for_authenticated_user) | **GET** /user/codespaces/secrets/{secret_name} | Get a secret for the authenticated user |
| [**codespaces_list_devcontainers_in_repository_for_authenticated_user**](CodespacesApi.md#codespaces_list_devcontainers_in_repository_for_authenticated_user) | **GET** /repos/{owner}/{repo}/codespaces/devcontainers | List devcontainer configurations in a repository for the authenticated user |
| [**codespaces_list_for_authenticated_user**](CodespacesApi.md#codespaces_list_for_authenticated_user) | **GET** /user/codespaces | List codespaces for the authenticated user |
| [**codespaces_list_in_organization**](CodespacesApi.md#codespaces_list_in_organization) | **GET** /orgs/{org}/codespaces | List codespaces for the organization |
| [**codespaces_list_in_repository_for_authenticated_user**](CodespacesApi.md#codespaces_list_in_repository_for_authenticated_user) | **GET** /repos/{owner}/{repo}/codespaces | List codespaces in a repository for the authenticated user |
| [**codespaces_list_repo_secrets**](CodespacesApi.md#codespaces_list_repo_secrets) | **GET** /repos/{owner}/{repo}/codespaces/secrets | List repository secrets |
| [**codespaces_list_repositories_for_secret_for_authenticated_user**](CodespacesApi.md#codespaces_list_repositories_for_secret_for_authenticated_user) | **GET** /user/codespaces/secrets/{secret_name}/repositories | List selected repositories for a user secret |
| [**codespaces_list_secrets_for_authenticated_user**](CodespacesApi.md#codespaces_list_secrets_for_authenticated_user) | **GET** /user/codespaces/secrets | List secrets for the authenticated user |
| [**codespaces_pre_flight_with_repo_for_authenticated_user**](CodespacesApi.md#codespaces_pre_flight_with_repo_for_authenticated_user) | **GET** /repos/{owner}/{repo}/codespaces/new | Get default attributes for a codespace |
| [**codespaces_remove_repository_for_secret_for_authenticated_user**](CodespacesApi.md#codespaces_remove_repository_for_secret_for_authenticated_user) | **DELETE** /user/codespaces/secrets/{secret_name}/repositories/{repository_id} | Remove a selected repository from a user secret |
| [**codespaces_repo_machines_for_authenticated_user**](CodespacesApi.md#codespaces_repo_machines_for_authenticated_user) | **GET** /repos/{owner}/{repo}/codespaces/machines | List available machine types for a repository |
| [**codespaces_set_repositories_for_secret_for_authenticated_user**](CodespacesApi.md#codespaces_set_repositories_for_secret_for_authenticated_user) | **PUT** /user/codespaces/secrets/{secret_name}/repositories | Set selected repositories for a user secret |
| [**codespaces_start_for_authenticated_user**](CodespacesApi.md#codespaces_start_for_authenticated_user) | **POST** /user/codespaces/{codespace_name}/start | Start a codespace for the authenticated user |
| [**codespaces_stop_for_authenticated_user**](CodespacesApi.md#codespaces_stop_for_authenticated_user) | **POST** /user/codespaces/{codespace_name}/stop | Stop a codespace for the authenticated user |
| [**codespaces_stop_in_organization**](CodespacesApi.md#codespaces_stop_in_organization) | **POST** /orgs/{org}/members/{username}/codespaces/{codespace_name}/stop | Stop a codespace for an organization user |
| [**codespaces_update_for_authenticated_user**](CodespacesApi.md#codespaces_update_for_authenticated_user) | **PATCH** /user/codespaces/{codespace_name} | Update a codespace for the authenticated user |


## codespaces_add_repository_for_secret_for_authenticated_user

> codespaces_add_repository_for_secret_for_authenticated_user(secret_name, repository_id)

Add a selected repository to a user secret

Adds a repository to the selected repositories for a user's codespace secret. You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint. GitHub Apps must have write access to the `codespaces_user_secrets` user permission and write access to the `codespaces_secrets` repository permission on the referenced repository to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
secret_name = 'secret_name_example' # String | The name of the secret.
repository_id = 56 # Integer | 

begin
  # Add a selected repository to a user secret
  api_instance.codespaces_add_repository_for_secret_for_authenticated_user(secret_name, repository_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_add_repository_for_secret_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_add_repository_for_secret_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> codespaces_add_repository_for_secret_for_authenticated_user_with_http_info(secret_name, repository_id)

```ruby
begin
  # Add a selected repository to a user secret
  data, status_code, headers = api_instance.codespaces_add_repository_for_secret_for_authenticated_user_with_http_info(secret_name, repository_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_add_repository_for_secret_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **secret_name** | **String** | The name of the secret. |  |
| **repository_id** | **Integer** |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_codespace_machines_for_authenticated_user

> <CodespacesRepoMachinesForAuthenticatedUser200Response> codespaces_codespace_machines_for_authenticated_user(codespace_name)

List machine types for a codespace

List the machine types a codespace can transition to use.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have read access to the `codespaces_metadata` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
codespace_name = 'codespace_name_example' # String | The name of the codespace.

begin
  # List machine types for a codespace
  result = api_instance.codespaces_codespace_machines_for_authenticated_user(codespace_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_codespace_machines_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_codespace_machines_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesRepoMachinesForAuthenticatedUser200Response>, Integer, Hash)> codespaces_codespace_machines_for_authenticated_user_with_http_info(codespace_name)

```ruby
begin
  # List machine types for a codespace
  data, status_code, headers = api_instance.codespaces_codespace_machines_for_authenticated_user_with_http_info(codespace_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesRepoMachinesForAuthenticatedUser200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_codespace_machines_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **codespace_name** | **String** | The name of the codespace. |  |

### Return type

[**CodespacesRepoMachinesForAuthenticatedUser200Response**](CodespacesRepoMachinesForAuthenticatedUser200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_create_for_authenticated_user

> <Codespace> codespaces_create_for_authenticated_user(codespaces_create_for_authenticated_user_request)

Create a codespace for the authenticated user

Creates a new codespace, owned by the authenticated user.  This endpoint requires either a `repository_id` OR a `pull_request` but not both.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
codespaces_create_for_authenticated_user_request = OpenapiClient::CodespacesCreateForAuthenticatedUserRequestOneOf.new({repository_id: 37}) # CodespacesCreateForAuthenticatedUserRequest | 

begin
  # Create a codespace for the authenticated user
  result = api_instance.codespaces_create_for_authenticated_user(codespaces_create_for_authenticated_user_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_create_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_create_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Codespace>, Integer, Hash)> codespaces_create_for_authenticated_user_with_http_info(codespaces_create_for_authenticated_user_request)

```ruby
begin
  # Create a codespace for the authenticated user
  data, status_code, headers = api_instance.codespaces_create_for_authenticated_user_with_http_info(codespaces_create_for_authenticated_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Codespace>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_create_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **codespaces_create_for_authenticated_user_request** | [**CodespacesCreateForAuthenticatedUserRequest**](CodespacesCreateForAuthenticatedUserRequest.md) |  |  |

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## codespaces_create_or_update_repo_secret

> Object codespaces_create_or_update_repo_secret(owner, repo, secret_name, codespaces_create_or_update_repo_secret_request)

Create or update a repository secret

Creates or updates a repository secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `codespaces_secrets` repository permission to use this endpoint.  #### Example of encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example of encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example of encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example of encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.
codespaces_create_or_update_repo_secret_request = OpenapiClient::CodespacesCreateOrUpdateRepoSecretRequest.new # CodespacesCreateOrUpdateRepoSecretRequest | 

begin
  # Create or update a repository secret
  result = api_instance.codespaces_create_or_update_repo_secret(owner, repo, secret_name, codespaces_create_or_update_repo_secret_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_create_or_update_repo_secret: #{e}"
end
```

#### Using the codespaces_create_or_update_repo_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> codespaces_create_or_update_repo_secret_with_http_info(owner, repo, secret_name, codespaces_create_or_update_repo_secret_request)

```ruby
begin
  # Create or update a repository secret
  data, status_code, headers = api_instance.codespaces_create_or_update_repo_secret_with_http_info(owner, repo, secret_name, codespaces_create_or_update_repo_secret_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_create_or_update_repo_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |
| **codespaces_create_or_update_repo_secret_request** | [**CodespacesCreateOrUpdateRepoSecretRequest**](CodespacesCreateOrUpdateRepoSecretRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## codespaces_create_or_update_secret_for_authenticated_user

> Object codespaces_create_or_update_secret_for_authenticated_user(secret_name, codespaces_create_or_update_secret_for_authenticated_user_request)

Create or update a secret for the authenticated user

Creates or updates a secret for a user's codespace with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages).  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must also have Codespaces access to use this endpoint.  GitHub Apps must have read access to the `codespaces_user_secrets` user permission and `codespaces_secrets` repository permission on all referenced repositories to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
secret_name = 'secret_name_example' # String | The name of the secret.
codespaces_create_or_update_secret_for_authenticated_user_request = OpenapiClient::CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest.new({key_id: 'key_id_example'}) # CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest | 

begin
  # Create or update a secret for the authenticated user
  result = api_instance.codespaces_create_or_update_secret_for_authenticated_user(secret_name, codespaces_create_or_update_secret_for_authenticated_user_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_create_or_update_secret_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_create_or_update_secret_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> codespaces_create_or_update_secret_for_authenticated_user_with_http_info(secret_name, codespaces_create_or_update_secret_for_authenticated_user_request)

```ruby
begin
  # Create or update a secret for the authenticated user
  data, status_code, headers = api_instance.codespaces_create_or_update_secret_for_authenticated_user_with_http_info(secret_name, codespaces_create_or_update_secret_for_authenticated_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_create_or_update_secret_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **secret_name** | **String** | The name of the secret. |  |
| **codespaces_create_or_update_secret_for_authenticated_user_request** | [**CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest**](CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest.md) |  |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## codespaces_create_with_pr_for_authenticated_user

> <Codespace> codespaces_create_with_pr_for_authenticated_user(owner, repo, pull_number, codespaces_create_with_pr_for_authenticated_user_request)

Create a codespace from a pull request

Creates a codespace owned by the authenticated user for the specified pull request.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
pull_number = 56 # Integer | The number that identifies the pull request.
codespaces_create_with_pr_for_authenticated_user_request = OpenapiClient::CodespacesCreateWithPrForAuthenticatedUserRequest.new # CodespacesCreateWithPrForAuthenticatedUserRequest | 

begin
  # Create a codespace from a pull request
  result = api_instance.codespaces_create_with_pr_for_authenticated_user(owner, repo, pull_number, codespaces_create_with_pr_for_authenticated_user_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_create_with_pr_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_create_with_pr_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Codespace>, Integer, Hash)> codespaces_create_with_pr_for_authenticated_user_with_http_info(owner, repo, pull_number, codespaces_create_with_pr_for_authenticated_user_request)

```ruby
begin
  # Create a codespace from a pull request
  data, status_code, headers = api_instance.codespaces_create_with_pr_for_authenticated_user_with_http_info(owner, repo, pull_number, codespaces_create_with_pr_for_authenticated_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Codespace>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_create_with_pr_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **pull_number** | **Integer** | The number that identifies the pull request. |  |
| **codespaces_create_with_pr_for_authenticated_user_request** | [**CodespacesCreateWithPrForAuthenticatedUserRequest**](CodespacesCreateWithPrForAuthenticatedUserRequest.md) |  |  |

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## codespaces_create_with_repo_for_authenticated_user

> <Codespace> codespaces_create_with_repo_for_authenticated_user(owner, repo, codespaces_create_with_repo_for_authenticated_user_request)

Create a codespace in a repository

Creates a codespace owned by the authenticated user in the specified repository.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
codespaces_create_with_repo_for_authenticated_user_request = OpenapiClient::CodespacesCreateWithRepoForAuthenticatedUserRequest.new # CodespacesCreateWithRepoForAuthenticatedUserRequest | 

begin
  # Create a codespace in a repository
  result = api_instance.codespaces_create_with_repo_for_authenticated_user(owner, repo, codespaces_create_with_repo_for_authenticated_user_request)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_create_with_repo_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_create_with_repo_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Codespace>, Integer, Hash)> codespaces_create_with_repo_for_authenticated_user_with_http_info(owner, repo, codespaces_create_with_repo_for_authenticated_user_request)

```ruby
begin
  # Create a codespace in a repository
  data, status_code, headers = api_instance.codespaces_create_with_repo_for_authenticated_user_with_http_info(owner, repo, codespaces_create_with_repo_for_authenticated_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Codespace>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_create_with_repo_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **codespaces_create_with_repo_for_authenticated_user_request** | [**CodespacesCreateWithRepoForAuthenticatedUserRequest**](CodespacesCreateWithRepoForAuthenticatedUserRequest.md) |  |  |

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## codespaces_delete_for_authenticated_user

> Object codespaces_delete_for_authenticated_user(codespace_name)

Delete a codespace for the authenticated user

Deletes a user's codespace.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
codespace_name = 'codespace_name_example' # String | The name of the codespace.

begin
  # Delete a codespace for the authenticated user
  result = api_instance.codespaces_delete_for_authenticated_user(codespace_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_delete_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_delete_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> codespaces_delete_for_authenticated_user_with_http_info(codespace_name)

```ruby
begin
  # Delete a codespace for the authenticated user
  data, status_code, headers = api_instance.codespaces_delete_for_authenticated_user_with_http_info(codespace_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_delete_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **codespace_name** | **String** | The name of the codespace. |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_delete_from_organization

> Object codespaces_delete_from_organization(org, username, codespace_name)

Delete a codespace from the organization

Deletes a user's codespace.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.
codespace_name = 'codespace_name_example' # String | The name of the codespace.

begin
  # Delete a codespace from the organization
  result = api_instance.codespaces_delete_from_organization(org, username, codespace_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_delete_from_organization: #{e}"
end
```

#### Using the codespaces_delete_from_organization_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(Object, Integer, Hash)> codespaces_delete_from_organization_with_http_info(org, username, codespace_name)

```ruby
begin
  # Delete a codespace from the organization
  data, status_code, headers = api_instance.codespaces_delete_from_organization_with_http_info(org, username, codespace_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => Object
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_delete_from_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |
| **codespace_name** | **String** | The name of the codespace. |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_delete_repo_secret

> codespaces_delete_repo_secret(owner, repo, secret_name)

Delete a repository secret

Deletes a secret in a repository using the secret name. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `codespaces_secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Delete a repository secret
  api_instance.codespaces_delete_repo_secret(owner, repo, secret_name)
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_delete_repo_secret: #{e}"
end
```

#### Using the codespaces_delete_repo_secret_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> codespaces_delete_repo_secret_with_http_info(owner, repo, secret_name)

```ruby
begin
  # Delete a repository secret
  data, status_code, headers = api_instance.codespaces_delete_repo_secret_with_http_info(owner, repo, secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_delete_repo_secret_with_http_info: #{e}"
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


## codespaces_delete_secret_for_authenticated_user

> codespaces_delete_secret_for_authenticated_user(secret_name)

Delete a secret for the authenticated user

Deletes a secret from a user's codespaces using the secret name. Deleting the secret will remove access from all codespaces that were allowed to access the secret.  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have write access to the `codespaces_user_secrets` user permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Delete a secret for the authenticated user
  api_instance.codespaces_delete_secret_for_authenticated_user(secret_name)
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_delete_secret_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_delete_secret_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> codespaces_delete_secret_for_authenticated_user_with_http_info(secret_name)

```ruby
begin
  # Delete a secret for the authenticated user
  data, status_code, headers = api_instance.codespaces_delete_secret_for_authenticated_user_with_http_info(secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_delete_secret_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## codespaces_export_for_authenticated_user

> <FetchesInformationAboutAnExportOfACodespace> codespaces_export_for_authenticated_user(codespace_name)

Export a codespace for the authenticated user

Triggers an export of the specified codespace and returns a URL and ID where the status of the export can be monitored.  You must authenticate using a personal access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces_lifecycle_admin` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
codespace_name = 'codespace_name_example' # String | The name of the codespace.

begin
  # Export a codespace for the authenticated user
  result = api_instance.codespaces_export_for_authenticated_user(codespace_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_export_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_export_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<FetchesInformationAboutAnExportOfACodespace>, Integer, Hash)> codespaces_export_for_authenticated_user_with_http_info(codespace_name)

```ruby
begin
  # Export a codespace for the authenticated user
  data, status_code, headers = api_instance.codespaces_export_for_authenticated_user_with_http_info(codespace_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <FetchesInformationAboutAnExportOfACodespace>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_export_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **codespace_name** | **String** | The name of the codespace. |  |

### Return type

[**FetchesInformationAboutAnExportOfACodespace**](FetchesInformationAboutAnExportOfACodespace.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_get_export_details_for_authenticated_user

> <FetchesInformationAboutAnExportOfACodespace> codespaces_get_export_details_for_authenticated_user(codespace_name, export_id)

Get details about a codespace export

Gets information about an export of a codespace.  You must authenticate using a personal access token with the `codespace` scope to use this endpoint.  GitHub Apps must have read access to the `codespaces_lifecycle_admin` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
codespace_name = 'codespace_name_example' # String | The name of the codespace.
export_id = 'export_id_example' # String | The ID of the export operation, or `latest`. Currently only `latest` is currently supported.

begin
  # Get details about a codespace export
  result = api_instance.codespaces_get_export_details_for_authenticated_user(codespace_name, export_id)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_get_export_details_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_get_export_details_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<FetchesInformationAboutAnExportOfACodespace>, Integer, Hash)> codespaces_get_export_details_for_authenticated_user_with_http_info(codespace_name, export_id)

```ruby
begin
  # Get details about a codespace export
  data, status_code, headers = api_instance.codespaces_get_export_details_for_authenticated_user_with_http_info(codespace_name, export_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <FetchesInformationAboutAnExportOfACodespace>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_get_export_details_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **codespace_name** | **String** | The name of the codespace. |  |
| **export_id** | **String** | The ID of the export operation, or &#x60;latest&#x60;. Currently only &#x60;latest&#x60; is currently supported. |  |

### Return type

[**FetchesInformationAboutAnExportOfACodespace**](FetchesInformationAboutAnExportOfACodespace.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_get_for_authenticated_user

> <Codespace> codespaces_get_for_authenticated_user(codespace_name)

Get a codespace for the authenticated user

Gets information about a user's codespace.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have read access to the `codespaces` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
codespace_name = 'codespace_name_example' # String | The name of the codespace.

begin
  # Get a codespace for the authenticated user
  result = api_instance.codespaces_get_for_authenticated_user(codespace_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_get_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_get_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Codespace>, Integer, Hash)> codespaces_get_for_authenticated_user_with_http_info(codespace_name)

```ruby
begin
  # Get a codespace for the authenticated user
  data, status_code, headers = api_instance.codespaces_get_for_authenticated_user_with_http_info(codespace_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Codespace>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_get_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **codespace_name** | **String** | The name of the codespace. |  |

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_get_public_key_for_authenticated_user

> <CodespacesUserPublicKey> codespaces_get_public_key_for_authenticated_user

Get public key for the authenticated user

Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets.  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the `codespaces_user_secrets` user permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new

begin
  # Get public key for the authenticated user
  result = api_instance.codespaces_get_public_key_for_authenticated_user
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_get_public_key_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_get_public_key_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesUserPublicKey>, Integer, Hash)> codespaces_get_public_key_for_authenticated_user_with_http_info

```ruby
begin
  # Get public key for the authenticated user
  data, status_code, headers = api_instance.codespaces_get_public_key_for_authenticated_user_with_http_info
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesUserPublicKey>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_get_public_key_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**CodespacesUserPublicKey**](CodespacesUserPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_get_repo_public_key

> <CodespacesPublicKey> codespaces_get_repo_public_key(owner, repo)

Get a repository public key

Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `codespaces_secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.

begin
  # Get a repository public key
  result = api_instance.codespaces_get_repo_public_key(owner, repo)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_get_repo_public_key: #{e}"
end
```

#### Using the codespaces_get_repo_public_key_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesPublicKey>, Integer, Hash)> codespaces_get_repo_public_key_with_http_info(owner, repo)

```ruby
begin
  # Get a repository public key
  data, status_code, headers = api_instance.codespaces_get_repo_public_key_with_http_info(owner, repo)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesPublicKey>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_get_repo_public_key_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |

### Return type

[**CodespacesPublicKey**](CodespacesPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_get_repo_secret

> <CodespacesSecret> codespaces_get_repo_secret(owner, repo, secret_name)

Get a repository secret

Gets a single repository secret without revealing its encrypted value. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `codespaces_secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Get a repository secret
  result = api_instance.codespaces_get_repo_secret(owner, repo, secret_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_get_repo_secret: #{e}"
end
```

#### Using the codespaces_get_repo_secret_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesSecret>, Integer, Hash)> codespaces_get_repo_secret_with_http_info(owner, repo, secret_name)

```ruby
begin
  # Get a repository secret
  data, status_code, headers = api_instance.codespaces_get_repo_secret_with_http_info(owner, repo, secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesSecret>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_get_repo_secret_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

[**CodespacesSecret**](CodespacesSecret.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_get_secret_for_authenticated_user

> <CodespacesSecret1> codespaces_get_secret_for_authenticated_user(secret_name)

Get a secret for the authenticated user

Gets a secret available to a user's codespaces without revealing its encrypted value.  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the `codespaces_user_secrets` user permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # Get a secret for the authenticated user
  result = api_instance.codespaces_get_secret_for_authenticated_user(secret_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_get_secret_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_get_secret_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesSecret1>, Integer, Hash)> codespaces_get_secret_for_authenticated_user_with_http_info(secret_name)

```ruby
begin
  # Get a secret for the authenticated user
  data, status_code, headers = api_instance.codespaces_get_secret_for_authenticated_user_with_http_info(secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesSecret1>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_get_secret_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

[**CodespacesSecret1**](CodespacesSecret1.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_list_devcontainers_in_repository_for_authenticated_user

> <CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response> codespaces_list_devcontainers_in_repository_for_authenticated_user(owner, repo, opts)

List devcontainer configurations in a repository for the authenticated user

Lists the devcontainer.json files associated with a specified repository and the authenticated user. These files specify launchpoint configurations for codespaces created within the repository.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have read access to the `codespaces_metadata` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List devcontainer configurations in a repository for the authenticated user
  result = api_instance.codespaces_list_devcontainers_in_repository_for_authenticated_user(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_devcontainers_in_repository_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_list_devcontainers_in_repository_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response>, Integer, Hash)> codespaces_list_devcontainers_in_repository_for_authenticated_user_with_http_info(owner, repo, opts)

```ruby
begin
  # List devcontainer configurations in a repository for the authenticated user
  data, status_code, headers = api_instance.codespaces_list_devcontainers_in_repository_for_authenticated_user_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_devcontainers_in_repository_for_authenticated_user_with_http_info: #{e}"
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

[**CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response**](CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## codespaces_list_for_authenticated_user

> <CodespacesListInOrganization200Response> codespaces_list_for_authenticated_user(opts)

List codespaces for the authenticated user

Lists the authenticated user's codespaces.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have read access to the `codespaces` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56, # Integer | Page number of the results to fetch.
  repository_id: 56 # Integer | ID of the Repository to filter on
}

begin
  # List codespaces for the authenticated user
  result = api_instance.codespaces_list_for_authenticated_user(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_list_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesListInOrganization200Response>, Integer, Hash)> codespaces_list_for_authenticated_user_with_http_info(opts)

```ruby
begin
  # List codespaces for the authenticated user
  data, status_code, headers = api_instance.codespaces_list_for_authenticated_user_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesListInOrganization200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |
| **repository_id** | **Integer** | ID of the Repository to filter on | [optional] |

### Return type

[**CodespacesListInOrganization200Response**](CodespacesListInOrganization200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_list_in_organization

> <CodespacesListInOrganization200Response> codespaces_list_in_organization(org, opts)

List codespaces for the organization

Lists the codespaces associated to a specified organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List codespaces for the organization
  result = api_instance.codespaces_list_in_organization(org, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_in_organization: #{e}"
end
```

#### Using the codespaces_list_in_organization_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesListInOrganization200Response>, Integer, Hash)> codespaces_list_in_organization_with_http_info(org, opts)

```ruby
begin
  # List codespaces for the organization
  data, status_code, headers = api_instance.codespaces_list_in_organization_with_http_info(org, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesListInOrganization200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_in_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**CodespacesListInOrganization200Response**](CodespacesListInOrganization200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_list_in_repository_for_authenticated_user

> <CodespacesListInOrganization200Response> codespaces_list_in_repository_for_authenticated_user(owner, repo, opts)

List codespaces in a repository for the authenticated user

Lists the codespaces associated to a specified repository and the authenticated user.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have read access to the `codespaces` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List codespaces in a repository for the authenticated user
  result = api_instance.codespaces_list_in_repository_for_authenticated_user(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_in_repository_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_list_in_repository_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesListInOrganization200Response>, Integer, Hash)> codespaces_list_in_repository_for_authenticated_user_with_http_info(owner, repo, opts)

```ruby
begin
  # List codespaces in a repository for the authenticated user
  data, status_code, headers = api_instance.codespaces_list_in_repository_for_authenticated_user_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesListInOrganization200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_in_repository_for_authenticated_user_with_http_info: #{e}"
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

[**CodespacesListInOrganization200Response**](CodespacesListInOrganization200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_list_repo_secrets

> <CodespacesListRepoSecrets200Response> codespaces_list_repo_secrets(owner, repo, opts)

List repository secrets

Lists all secrets available in a repository without revealing their encrypted values. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `codespaces_secrets` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List repository secrets
  result = api_instance.codespaces_list_repo_secrets(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_repo_secrets: #{e}"
end
```

#### Using the codespaces_list_repo_secrets_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesListRepoSecrets200Response>, Integer, Hash)> codespaces_list_repo_secrets_with_http_info(owner, repo, opts)

```ruby
begin
  # List repository secrets
  data, status_code, headers = api_instance.codespaces_list_repo_secrets_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesListRepoSecrets200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_repo_secrets_with_http_info: #{e}"
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

[**CodespacesListRepoSecrets200Response**](CodespacesListRepoSecrets200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_list_repositories_for_secret_for_authenticated_user

> <ActionsListSelectedReposForOrgSecret200Response> codespaces_list_repositories_for_secret_for_authenticated_user(secret_name)

List selected repositories for a user secret

List the repositories that have been granted the ability to use a user's codespace secret.  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the `codespaces_user_secrets` user permission and write access to the `codespaces_secrets` repository permission on all referenced repositories to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
secret_name = 'secret_name_example' # String | The name of the secret.

begin
  # List selected repositories for a user secret
  result = api_instance.codespaces_list_repositories_for_secret_for_authenticated_user(secret_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_repositories_for_secret_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_list_repositories_for_secret_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<ActionsListSelectedReposForOrgSecret200Response>, Integer, Hash)> codespaces_list_repositories_for_secret_for_authenticated_user_with_http_info(secret_name)

```ruby
begin
  # List selected repositories for a user secret
  data, status_code, headers = api_instance.codespaces_list_repositories_for_secret_for_authenticated_user_with_http_info(secret_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <ActionsListSelectedReposForOrgSecret200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_repositories_for_secret_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **secret_name** | **String** | The name of the secret. |  |

### Return type

[**ActionsListSelectedReposForOrgSecret200Response**](ActionsListSelectedReposForOrgSecret200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_list_secrets_for_authenticated_user

> <CodespacesListSecretsForAuthenticatedUser200Response> codespaces_list_secrets_for_authenticated_user(opts)

List secrets for the authenticated user

Lists all secrets available for a user's Codespaces without revealing their encrypted values.  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the `codespaces_user_secrets` user permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
opts = {
  per_page: 56, # Integer | The number of results per page (max 100).
  page: 56 # Integer | Page number of the results to fetch.
}

begin
  # List secrets for the authenticated user
  result = api_instance.codespaces_list_secrets_for_authenticated_user(opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_secrets_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_list_secrets_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesListSecretsForAuthenticatedUser200Response>, Integer, Hash)> codespaces_list_secrets_for_authenticated_user_with_http_info(opts)

```ruby
begin
  # List secrets for the authenticated user
  data, status_code, headers = api_instance.codespaces_list_secrets_for_authenticated_user_with_http_info(opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesListSecretsForAuthenticatedUser200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_list_secrets_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **per_page** | **Integer** | The number of results per page (max 100). | [optional][default to 30] |
| **page** | **Integer** | Page number of the results to fetch. | [optional][default to 1] |

### Return type

[**CodespacesListSecretsForAuthenticatedUser200Response**](CodespacesListSecretsForAuthenticatedUser200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_pre_flight_with_repo_for_authenticated_user

> <CodespacesPreFlightWithRepoForAuthenticatedUser200Response> codespaces_pre_flight_with_repo_for_authenticated_user(owner, repo, opts)

Get default attributes for a codespace

Gets the default attributes for codespaces created by the user with the repository.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  ref: 'main', # String | The branch or commit to check for a default devcontainer path. If not specified, the default branch will be checked.
  client_ip: '1.2.3.4' # String | An alternative IP for default location auto-detection, such as when proxying a request.
}

begin
  # Get default attributes for a codespace
  result = api_instance.codespaces_pre_flight_with_repo_for_authenticated_user(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_pre_flight_with_repo_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_pre_flight_with_repo_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesPreFlightWithRepoForAuthenticatedUser200Response>, Integer, Hash)> codespaces_pre_flight_with_repo_for_authenticated_user_with_http_info(owner, repo, opts)

```ruby
begin
  # Get default attributes for a codespace
  data, status_code, headers = api_instance.codespaces_pre_flight_with_repo_for_authenticated_user_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesPreFlightWithRepoForAuthenticatedUser200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_pre_flight_with_repo_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **ref** | **String** | The branch or commit to check for a default devcontainer path. If not specified, the default branch will be checked. | [optional] |
| **client_ip** | **String** | An alternative IP for default location auto-detection, such as when proxying a request. | [optional] |

### Return type

[**CodespacesPreFlightWithRepoForAuthenticatedUser200Response**](CodespacesPreFlightWithRepoForAuthenticatedUser200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_remove_repository_for_secret_for_authenticated_user

> codespaces_remove_repository_for_secret_for_authenticated_user(secret_name, repository_id)

Remove a selected repository from a user secret

Removes a repository from the selected repositories for a user's codespace secret. You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint. GitHub Apps must have write access to the `codespaces_user_secrets` user permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
secret_name = 'secret_name_example' # String | The name of the secret.
repository_id = 56 # Integer | 

begin
  # Remove a selected repository from a user secret
  api_instance.codespaces_remove_repository_for_secret_for_authenticated_user(secret_name, repository_id)
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_remove_repository_for_secret_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_remove_repository_for_secret_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> codespaces_remove_repository_for_secret_for_authenticated_user_with_http_info(secret_name, repository_id)

```ruby
begin
  # Remove a selected repository from a user secret
  data, status_code, headers = api_instance.codespaces_remove_repository_for_secret_for_authenticated_user_with_http_info(secret_name, repository_id)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_remove_repository_for_secret_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **secret_name** | **String** | The name of the secret. |  |
| **repository_id** | **Integer** |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_repo_machines_for_authenticated_user

> <CodespacesRepoMachinesForAuthenticatedUser200Response> codespaces_repo_machines_for_authenticated_user(owner, repo, opts)

List available machine types for a repository

List the machine types available for a given repository based on its configuration.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces_metadata` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
owner = 'owner_example' # String | The account owner of the repository. The name is not case sensitive.
repo = 'repo_example' # String | The name of the repository. The name is not case sensitive.
opts = {
  location: 'WestUs2', # String | The location to check for available machines. Assigned by IP if not provided.
  client_ip: 'client_ip_example' # String | IP for location auto-detection when proxying a request
}

begin
  # List available machine types for a repository
  result = api_instance.codespaces_repo_machines_for_authenticated_user(owner, repo, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_repo_machines_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_repo_machines_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<CodespacesRepoMachinesForAuthenticatedUser200Response>, Integer, Hash)> codespaces_repo_machines_for_authenticated_user_with_http_info(owner, repo, opts)

```ruby
begin
  # List available machine types for a repository
  data, status_code, headers = api_instance.codespaces_repo_machines_for_authenticated_user_with_http_info(owner, repo, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <CodespacesRepoMachinesForAuthenticatedUser200Response>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_repo_machines_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **owner** | **String** | The account owner of the repository. The name is not case sensitive. |  |
| **repo** | **String** | The name of the repository. The name is not case sensitive. |  |
| **location** | **String** | The location to check for available machines. Assigned by IP if not provided. | [optional] |
| **client_ip** | **String** | IP for location auto-detection when proxying a request | [optional] |

### Return type

[**CodespacesRepoMachinesForAuthenticatedUser200Response**](CodespacesRepoMachinesForAuthenticatedUser200Response.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_set_repositories_for_secret_for_authenticated_user

> codespaces_set_repositories_for_secret_for_authenticated_user(secret_name, codespaces_set_repositories_for_secret_for_authenticated_user_request)

Set selected repositories for a user secret

Select the repositories that will use a user's codespace secret.  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have write access to the `codespaces_user_secrets` user permission and write access to the `codespaces_secrets` repository permission on all referenced repositories to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
secret_name = 'secret_name_example' # String | The name of the secret.
codespaces_set_repositories_for_secret_for_authenticated_user_request = OpenapiClient::CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest.new({selected_repository_ids: [37]}) # CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest | 

begin
  # Set selected repositories for a user secret
  api_instance.codespaces_set_repositories_for_secret_for_authenticated_user(secret_name, codespaces_set_repositories_for_secret_for_authenticated_user_request)
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_set_repositories_for_secret_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_set_repositories_for_secret_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data (`nil` in this case), status code and headers.

> <Array(nil, Integer, Hash)> codespaces_set_repositories_for_secret_for_authenticated_user_with_http_info(secret_name, codespaces_set_repositories_for_secret_for_authenticated_user_request)

```ruby
begin
  # Set selected repositories for a user secret
  data, status_code, headers = api_instance.codespaces_set_repositories_for_secret_for_authenticated_user_with_http_info(secret_name, codespaces_set_repositories_for_secret_for_authenticated_user_request)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => nil
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_set_repositories_for_secret_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **secret_name** | **String** | The name of the secret. |  |
| **codespaces_set_repositories_for_secret_for_authenticated_user_request** | [**CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest**](CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest.md) |  |  |

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## codespaces_start_for_authenticated_user

> <Codespace> codespaces_start_for_authenticated_user(codespace_name)

Start a codespace for the authenticated user

Starts a user's codespace.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces_lifecycle_admin` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
codespace_name = 'codespace_name_example' # String | The name of the codespace.

begin
  # Start a codespace for the authenticated user
  result = api_instance.codespaces_start_for_authenticated_user(codespace_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_start_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_start_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Codespace>, Integer, Hash)> codespaces_start_for_authenticated_user_with_http_info(codespace_name)

```ruby
begin
  # Start a codespace for the authenticated user
  data, status_code, headers = api_instance.codespaces_start_for_authenticated_user_with_http_info(codespace_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Codespace>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_start_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **codespace_name** | **String** | The name of the codespace. |  |

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/scim+json


## codespaces_stop_for_authenticated_user

> <Codespace> codespaces_stop_for_authenticated_user(codespace_name)

Stop a codespace for the authenticated user

Stops a user's codespace.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces_lifecycle_admin` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
codespace_name = 'codespace_name_example' # String | The name of the codespace.

begin
  # Stop a codespace for the authenticated user
  result = api_instance.codespaces_stop_for_authenticated_user(codespace_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_stop_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_stop_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Codespace>, Integer, Hash)> codespaces_stop_for_authenticated_user_with_http_info(codespace_name)

```ruby
begin
  # Stop a codespace for the authenticated user
  data, status_code, headers = api_instance.codespaces_stop_for_authenticated_user_with_http_info(codespace_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Codespace>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_stop_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **codespace_name** | **String** | The name of the codespace. |  |

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_stop_in_organization

> <Codespace> codespaces_stop_in_organization(org, username, codespace_name)

Stop a codespace for an organization user

Stops a user's codespace.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
org = 'org_example' # String | The organization name. The name is not case sensitive.
username = 'username_example' # String | The handle for the GitHub user account.
codespace_name = 'codespace_name_example' # String | The name of the codespace.

begin
  # Stop a codespace for an organization user
  result = api_instance.codespaces_stop_in_organization(org, username, codespace_name)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_stop_in_organization: #{e}"
end
```

#### Using the codespaces_stop_in_organization_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Codespace>, Integer, Hash)> codespaces_stop_in_organization_with_http_info(org, username, codespace_name)

```ruby
begin
  # Stop a codespace for an organization user
  data, status_code, headers = api_instance.codespaces_stop_in_organization_with_http_info(org, username, codespace_name)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Codespace>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_stop_in_organization_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **org** | **String** | The organization name. The name is not case sensitive. |  |
| **username** | **String** | The handle for the GitHub user account. |  |
| **codespace_name** | **String** | The name of the codespace. |  |

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


## codespaces_update_for_authenticated_user

> <Codespace> codespaces_update_for_authenticated_user(codespace_name, opts)

Update a codespace for the authenticated user

Updates a codespace owned by the authenticated user. Currently only the codespace's machine type and recent folders can be modified using this endpoint.  If you specify a new machine type it will be applied the next time your codespace is started.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.

### Examples

```ruby
require 'time'
require 'openapi_client'

api_instance = OpenapiClient::CodespacesApi.new
codespace_name = 'codespace_name_example' # String | The name of the codespace.
opts = {
  codespaces_update_for_authenticated_user_request: OpenapiClient::CodespacesUpdateForAuthenticatedUserRequest.new # CodespacesUpdateForAuthenticatedUserRequest | 
}

begin
  # Update a codespace for the authenticated user
  result = api_instance.codespaces_update_for_authenticated_user(codespace_name, opts)
  p result
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_update_for_authenticated_user: #{e}"
end
```

#### Using the codespaces_update_for_authenticated_user_with_http_info variant

This returns an Array which contains the response data, status code and headers.

> <Array(<Codespace>, Integer, Hash)> codespaces_update_for_authenticated_user_with_http_info(codespace_name, opts)

```ruby
begin
  # Update a codespace for the authenticated user
  data, status_code, headers = api_instance.codespaces_update_for_authenticated_user_with_http_info(codespace_name, opts)
  p status_code # => 2xx
  p headers # => { ... }
  p data # => <Codespace>
rescue OpenapiClient::ApiError => e
  puts "Error when calling CodespacesApi->codespaces_update_for_authenticated_user_with_http_info: #{e}"
end
```

### Parameters

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **codespace_name** | **String** | The name of the codespace. |  |
| **codespaces_update_for_authenticated_user_request** | [**CodespacesUpdateForAuthenticatedUserRequest**](CodespacesUpdateForAuthenticatedUserRequest.md) |  | [optional] |

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

