# Org.OpenAPITools.Api.CodespacesApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CodespacesAddRepositoryForSecretForAuthenticatedUser**](CodespacesApi.md#codespacesaddrepositoryforsecretforauthenticateduser) | **PUT** /user/codespaces/secrets/{secret_name}/repositories/{repository_id} | Add a selected repository to a user secret
[**CodespacesCodespaceMachinesForAuthenticatedUser**](CodespacesApi.md#codespacescodespacemachinesforauthenticateduser) | **GET** /user/codespaces/{codespace_name}/machines | List machine types for a codespace
[**CodespacesCreateForAuthenticatedUser**](CodespacesApi.md#codespacescreateforauthenticateduser) | **POST** /user/codespaces | Create a codespace for the authenticated user
[**CodespacesCreateOrUpdateRepoSecret**](CodespacesApi.md#codespacescreateorupdatereposecret) | **PUT** /repos/{owner}/{repo}/codespaces/secrets/{secret_name} | Create or update a repository secret
[**CodespacesCreateOrUpdateSecretForAuthenticatedUser**](CodespacesApi.md#codespacescreateorupdatesecretforauthenticateduser) | **PUT** /user/codespaces/secrets/{secret_name} | Create or update a secret for the authenticated user
[**CodespacesCreateWithPrForAuthenticatedUser**](CodespacesApi.md#codespacescreatewithprforauthenticateduser) | **POST** /repos/{owner}/{repo}/pulls/{pull_number}/codespaces | Create a codespace from a pull request
[**CodespacesCreateWithRepoForAuthenticatedUser**](CodespacesApi.md#codespacescreatewithrepoforauthenticateduser) | **POST** /repos/{owner}/{repo}/codespaces | Create a codespace in a repository
[**CodespacesDeleteForAuthenticatedUser**](CodespacesApi.md#codespacesdeleteforauthenticateduser) | **DELETE** /user/codespaces/{codespace_name} | Delete a codespace for the authenticated user
[**CodespacesDeleteFromOrganization**](CodespacesApi.md#codespacesdeletefromorganization) | **DELETE** /orgs/{org}/members/{username}/codespaces/{codespace_name} | Delete a codespace from the organization
[**CodespacesDeleteRepoSecret**](CodespacesApi.md#codespacesdeletereposecret) | **DELETE** /repos/{owner}/{repo}/codespaces/secrets/{secret_name} | Delete a repository secret
[**CodespacesDeleteSecretForAuthenticatedUser**](CodespacesApi.md#codespacesdeletesecretforauthenticateduser) | **DELETE** /user/codespaces/secrets/{secret_name} | Delete a secret for the authenticated user
[**CodespacesExportForAuthenticatedUser**](CodespacesApi.md#codespacesexportforauthenticateduser) | **POST** /user/codespaces/{codespace_name}/exports | Export a codespace for the authenticated user
[**CodespacesGetExportDetailsForAuthenticatedUser**](CodespacesApi.md#codespacesgetexportdetailsforauthenticateduser) | **GET** /user/codespaces/{codespace_name}/exports/{export_id} | Get details about a codespace export
[**CodespacesGetForAuthenticatedUser**](CodespacesApi.md#codespacesgetforauthenticateduser) | **GET** /user/codespaces/{codespace_name} | Get a codespace for the authenticated user
[**CodespacesGetPublicKeyForAuthenticatedUser**](CodespacesApi.md#codespacesgetpublickeyforauthenticateduser) | **GET** /user/codespaces/secrets/public-key | Get public key for the authenticated user
[**CodespacesGetRepoPublicKey**](CodespacesApi.md#codespacesgetrepopublickey) | **GET** /repos/{owner}/{repo}/codespaces/secrets/public-key | Get a repository public key
[**CodespacesGetRepoSecret**](CodespacesApi.md#codespacesgetreposecret) | **GET** /repos/{owner}/{repo}/codespaces/secrets/{secret_name} | Get a repository secret
[**CodespacesGetSecretForAuthenticatedUser**](CodespacesApi.md#codespacesgetsecretforauthenticateduser) | **GET** /user/codespaces/secrets/{secret_name} | Get a secret for the authenticated user
[**CodespacesListDevcontainersInRepositoryForAuthenticatedUser**](CodespacesApi.md#codespaceslistdevcontainersinrepositoryforauthenticateduser) | **GET** /repos/{owner}/{repo}/codespaces/devcontainers | List devcontainer configurations in a repository for the authenticated user
[**CodespacesListForAuthenticatedUser**](CodespacesApi.md#codespaceslistforauthenticateduser) | **GET** /user/codespaces | List codespaces for the authenticated user
[**CodespacesListInOrganization**](CodespacesApi.md#codespaceslistinorganization) | **GET** /orgs/{org}/codespaces | List codespaces for the organization
[**CodespacesListInRepositoryForAuthenticatedUser**](CodespacesApi.md#codespaceslistinrepositoryforauthenticateduser) | **GET** /repos/{owner}/{repo}/codespaces | List codespaces in a repository for the authenticated user
[**CodespacesListRepoSecrets**](CodespacesApi.md#codespaceslistreposecrets) | **GET** /repos/{owner}/{repo}/codespaces/secrets | List repository secrets
[**CodespacesListRepositoriesForSecretForAuthenticatedUser**](CodespacesApi.md#codespaceslistrepositoriesforsecretforauthenticateduser) | **GET** /user/codespaces/secrets/{secret_name}/repositories | List selected repositories for a user secret
[**CodespacesListSecretsForAuthenticatedUser**](CodespacesApi.md#codespaceslistsecretsforauthenticateduser) | **GET** /user/codespaces/secrets | List secrets for the authenticated user
[**CodespacesPreFlightWithRepoForAuthenticatedUser**](CodespacesApi.md#codespacespreflightwithrepoforauthenticateduser) | **GET** /repos/{owner}/{repo}/codespaces/new | Get default attributes for a codespace
[**CodespacesRemoveRepositoryForSecretForAuthenticatedUser**](CodespacesApi.md#codespacesremoverepositoryforsecretforauthenticateduser) | **DELETE** /user/codespaces/secrets/{secret_name}/repositories/{repository_id} | Remove a selected repository from a user secret
[**CodespacesRepoMachinesForAuthenticatedUser**](CodespacesApi.md#codespacesrepomachinesforauthenticateduser) | **GET** /repos/{owner}/{repo}/codespaces/machines | List available machine types for a repository
[**CodespacesSetRepositoriesForSecretForAuthenticatedUser**](CodespacesApi.md#codespacessetrepositoriesforsecretforauthenticateduser) | **PUT** /user/codespaces/secrets/{secret_name}/repositories | Set selected repositories for a user secret
[**CodespacesStartForAuthenticatedUser**](CodespacesApi.md#codespacesstartforauthenticateduser) | **POST** /user/codespaces/{codespace_name}/start | Start a codespace for the authenticated user
[**CodespacesStopForAuthenticatedUser**](CodespacesApi.md#codespacesstopforauthenticateduser) | **POST** /user/codespaces/{codespace_name}/stop | Stop a codespace for the authenticated user
[**CodespacesStopInOrganization**](CodespacesApi.md#codespacesstopinorganization) | **POST** /orgs/{org}/members/{username}/codespaces/{codespace_name}/stop | Stop a codespace for an organization user
[**CodespacesUpdateForAuthenticatedUser**](CodespacesApi.md#codespacesupdateforauthenticateduser) | **PATCH** /user/codespaces/{codespace_name} | Update a codespace for the authenticated user


<a name="codespacesaddrepositoryforsecretforauthenticateduser"></a>
# **CodespacesAddRepositoryForSecretForAuthenticatedUser**
> void CodespacesAddRepositoryForSecretForAuthenticatedUser (string secretName, int? repositoryId)

Add a selected repository to a user secret

Adds a repository to the selected repositories for a user's codespace secret. You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint. GitHub Apps must have write access to the `codespaces_user_secrets` user permission and write access to the `codespaces_secrets` repository permission on the referenced repository to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesAddRepositoryForSecretForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var secretName = "secretName_example";  // string | The name of the secret.
            var repositoryId = 56;  // int? | 

            try
            {
                // Add a selected repository to a user secret
                apiInstance.CodespacesAddRepositoryForSecretForAuthenticatedUser(secretName, repositoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesAddRepositoryForSecretForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **secretName** | **string**| The name of the secret. | 
 **repositoryId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacescodespacemachinesforauthenticateduser"></a>
# **CodespacesCodespaceMachinesForAuthenticatedUser**
> CodespacesRepoMachinesForAuthenticatedUser200Response CodespacesCodespaceMachinesForAuthenticatedUser (string codespaceName)

List machine types for a codespace

List the machine types a codespace can transition to use.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have read access to the `codespaces_metadata` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesCodespaceMachinesForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var codespaceName = "codespaceName_example";  // string | The name of the codespace.

            try
            {
                // List machine types for a codespace
                CodespacesRepoMachinesForAuthenticatedUser200Response result = apiInstance.CodespacesCodespaceMachinesForAuthenticatedUser(codespaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesCodespaceMachinesForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codespaceName** | **string**| The name of the codespace. | 

### Return type

[**CodespacesRepoMachinesForAuthenticatedUser200Response**](CodespacesRepoMachinesForAuthenticatedUser200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacescreateforauthenticateduser"></a>
# **CodespacesCreateForAuthenticatedUser**
> Codespace CodespacesCreateForAuthenticatedUser (CodespacesCreateForAuthenticatedUserRequest codespacesCreateForAuthenticatedUserRequest)

Create a codespace for the authenticated user

Creates a new codespace, owned by the authenticated user.  This endpoint requires either a `repository_id` OR a `pull_request` but not both.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesCreateForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var codespacesCreateForAuthenticatedUserRequest = new CodespacesCreateForAuthenticatedUserRequest(); // CodespacesCreateForAuthenticatedUserRequest | 

            try
            {
                // Create a codespace for the authenticated user
                Codespace result = apiInstance.CodespacesCreateForAuthenticatedUser(codespacesCreateForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesCreateForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codespacesCreateForAuthenticatedUserRequest** | [**CodespacesCreateForAuthenticatedUserRequest**](CodespacesCreateForAuthenticatedUserRequest.md)|  | 

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacescreateorupdatereposecret"></a>
# **CodespacesCreateOrUpdateRepoSecret**
> Object CodespacesCreateOrUpdateRepoSecret (string owner, string repo, string secretName, CodespacesCreateOrUpdateRepoSecretRequest codespacesCreateOrUpdateRepoSecretRequest)

Create or update a repository secret

Creates or updates a repository secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `codespaces_secrets` repository permission to use this endpoint.  #### Example of encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example of encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example of encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example of encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesCreateOrUpdateRepoSecretExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var codespacesCreateOrUpdateRepoSecretRequest = new CodespacesCreateOrUpdateRepoSecretRequest(); // CodespacesCreateOrUpdateRepoSecretRequest | 

            try
            {
                // Create or update a repository secret
                Object result = apiInstance.CodespacesCreateOrUpdateRepoSecret(owner, repo, secretName, codespacesCreateOrUpdateRepoSecretRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesCreateOrUpdateRepoSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 
 **codespacesCreateOrUpdateRepoSecretRequest** | [**CodespacesCreateOrUpdateRepoSecretRequest**](CodespacesCreateOrUpdateRepoSecretRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacescreateorupdatesecretforauthenticateduser"></a>
# **CodespacesCreateOrUpdateSecretForAuthenticatedUser**
> Object CodespacesCreateOrUpdateSecretForAuthenticatedUser (string secretName, CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest codespacesCreateOrUpdateSecretForAuthenticatedUserRequest)

Create or update a secret for the authenticated user

Creates or updates a secret for a user's codespace with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages).  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must also have Codespaces access to use this endpoint.  GitHub Apps must have read access to the `codespaces_user_secrets` user permission and `codespaces_secrets` repository permission on all referenced repositories to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesCreateOrUpdateSecretForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var secretName = "secretName_example";  // string | The name of the secret.
            var codespacesCreateOrUpdateSecretForAuthenticatedUserRequest = new CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest(); // CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest | 

            try
            {
                // Create or update a secret for the authenticated user
                Object result = apiInstance.CodespacesCreateOrUpdateSecretForAuthenticatedUser(secretName, codespacesCreateOrUpdateSecretForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesCreateOrUpdateSecretForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **secretName** | **string**| The name of the secret. | 
 **codespacesCreateOrUpdateSecretForAuthenticatedUserRequest** | [**CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest**](CodespacesCreateOrUpdateSecretForAuthenticatedUserRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacescreatewithprforauthenticateduser"></a>
# **CodespacesCreateWithPrForAuthenticatedUser**
> Codespace CodespacesCreateWithPrForAuthenticatedUser (string owner, string repo, int? pullNumber, CodespacesCreateWithPrForAuthenticatedUserRequest codespacesCreateWithPrForAuthenticatedUserRequest)

Create a codespace from a pull request

Creates a codespace owned by the authenticated user for the specified pull request.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesCreateWithPrForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var pullNumber = 56;  // int? | The number that identifies the pull request.
            var codespacesCreateWithPrForAuthenticatedUserRequest = new CodespacesCreateWithPrForAuthenticatedUserRequest(); // CodespacesCreateWithPrForAuthenticatedUserRequest | 

            try
            {
                // Create a codespace from a pull request
                Codespace result = apiInstance.CodespacesCreateWithPrForAuthenticatedUser(owner, repo, pullNumber, codespacesCreateWithPrForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesCreateWithPrForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **pullNumber** | **int?**| The number that identifies the pull request. | 
 **codespacesCreateWithPrForAuthenticatedUserRequest** | [**CodespacesCreateWithPrForAuthenticatedUserRequest**](CodespacesCreateWithPrForAuthenticatedUserRequest.md)|  | 

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacescreatewithrepoforauthenticateduser"></a>
# **CodespacesCreateWithRepoForAuthenticatedUser**
> Codespace CodespacesCreateWithRepoForAuthenticatedUser (string owner, string repo, CodespacesCreateWithRepoForAuthenticatedUserRequest codespacesCreateWithRepoForAuthenticatedUserRequest)

Create a codespace in a repository

Creates a codespace owned by the authenticated user in the specified repository.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesCreateWithRepoForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var codespacesCreateWithRepoForAuthenticatedUserRequest = new CodespacesCreateWithRepoForAuthenticatedUserRequest(); // CodespacesCreateWithRepoForAuthenticatedUserRequest | 

            try
            {
                // Create a codespace in a repository
                Codespace result = apiInstance.CodespacesCreateWithRepoForAuthenticatedUser(owner, repo, codespacesCreateWithRepoForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesCreateWithRepoForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **codespacesCreateWithRepoForAuthenticatedUserRequest** | [**CodespacesCreateWithRepoForAuthenticatedUserRequest**](CodespacesCreateWithRepoForAuthenticatedUserRequest.md)|  | 

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesdeleteforauthenticateduser"></a>
# **CodespacesDeleteForAuthenticatedUser**
> Object CodespacesDeleteForAuthenticatedUser (string codespaceName)

Delete a codespace for the authenticated user

Deletes a user's codespace.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesDeleteForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var codespaceName = "codespaceName_example";  // string | The name of the codespace.

            try
            {
                // Delete a codespace for the authenticated user
                Object result = apiInstance.CodespacesDeleteForAuthenticatedUser(codespaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesDeleteForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codespaceName** | **string**| The name of the codespace. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesdeletefromorganization"></a>
# **CodespacesDeleteFromOrganization**
> Object CodespacesDeleteFromOrganization (string org, string username, string codespaceName)

Delete a codespace from the organization

Deletes a user's codespace.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesDeleteFromOrganizationExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.
            var codespaceName = "codespaceName_example";  // string | The name of the codespace.

            try
            {
                // Delete a codespace from the organization
                Object result = apiInstance.CodespacesDeleteFromOrganization(org, username, codespaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesDeleteFromOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 
 **codespaceName** | **string**| The name of the codespace. | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesdeletereposecret"></a>
# **CodespacesDeleteRepoSecret**
> void CodespacesDeleteRepoSecret (string owner, string repo, string secretName)

Delete a repository secret

Deletes a secret in a repository using the secret name. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `codespaces_secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesDeleteRepoSecretExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Delete a repository secret
                apiInstance.CodespacesDeleteRepoSecret(owner, repo, secretName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesDeleteRepoSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesdeletesecretforauthenticateduser"></a>
# **CodespacesDeleteSecretForAuthenticatedUser**
> void CodespacesDeleteSecretForAuthenticatedUser (string secretName)

Delete a secret for the authenticated user

Deletes a secret from a user's codespaces using the secret name. Deleting the secret will remove access from all codespaces that were allowed to access the secret.  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have write access to the `codespaces_user_secrets` user permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesDeleteSecretForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Delete a secret for the authenticated user
                apiInstance.CodespacesDeleteSecretForAuthenticatedUser(secretName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesDeleteSecretForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **secretName** | **string**| The name of the secret. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesexportforauthenticateduser"></a>
# **CodespacesExportForAuthenticatedUser**
> FetchesInformationAboutAnExportOfACodespace CodespacesExportForAuthenticatedUser (string codespaceName)

Export a codespace for the authenticated user

Triggers an export of the specified codespace and returns a URL and ID where the status of the export can be monitored.  You must authenticate using a personal access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces_lifecycle_admin` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesExportForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var codespaceName = "codespaceName_example";  // string | The name of the codespace.

            try
            {
                // Export a codespace for the authenticated user
                FetchesInformationAboutAnExportOfACodespace result = apiInstance.CodespacesExportForAuthenticatedUser(codespaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesExportForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codespaceName** | **string**| The name of the codespace. | 

### Return type

[**FetchesInformationAboutAnExportOfACodespace**](FetchesInformationAboutAnExportOfACodespace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesgetexportdetailsforauthenticateduser"></a>
# **CodespacesGetExportDetailsForAuthenticatedUser**
> FetchesInformationAboutAnExportOfACodespace CodespacesGetExportDetailsForAuthenticatedUser (string codespaceName, string exportId)

Get details about a codespace export

Gets information about an export of a codespace.  You must authenticate using a personal access token with the `codespace` scope to use this endpoint.  GitHub Apps must have read access to the `codespaces_lifecycle_admin` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesGetExportDetailsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var codespaceName = "codespaceName_example";  // string | The name of the codespace.
            var exportId = "exportId_example";  // string | The ID of the export operation, or `latest`. Currently only `latest` is currently supported.

            try
            {
                // Get details about a codespace export
                FetchesInformationAboutAnExportOfACodespace result = apiInstance.CodespacesGetExportDetailsForAuthenticatedUser(codespaceName, exportId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesGetExportDetailsForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codespaceName** | **string**| The name of the codespace. | 
 **exportId** | **string**| The ID of the export operation, or &#x60;latest&#x60;. Currently only &#x60;latest&#x60; is currently supported. | 

### Return type

[**FetchesInformationAboutAnExportOfACodespace**](FetchesInformationAboutAnExportOfACodespace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesgetforauthenticateduser"></a>
# **CodespacesGetForAuthenticatedUser**
> Codespace CodespacesGetForAuthenticatedUser (string codespaceName)

Get a codespace for the authenticated user

Gets information about a user's codespace.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have read access to the `codespaces` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesGetForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var codespaceName = "codespaceName_example";  // string | The name of the codespace.

            try
            {
                // Get a codespace for the authenticated user
                Codespace result = apiInstance.CodespacesGetForAuthenticatedUser(codespaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesGetForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codespaceName** | **string**| The name of the codespace. | 

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesgetpublickeyforauthenticateduser"></a>
# **CodespacesGetPublicKeyForAuthenticatedUser**
> CodespacesUserPublicKey CodespacesGetPublicKeyForAuthenticatedUser ()

Get public key for the authenticated user

Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets.  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the `codespaces_user_secrets` user permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesGetPublicKeyForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();

            try
            {
                // Get public key for the authenticated user
                CodespacesUserPublicKey result = apiInstance.CodespacesGetPublicKeyForAuthenticatedUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesGetPublicKeyForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesgetrepopublickey"></a>
# **CodespacesGetRepoPublicKey**
> CodespacesPublicKey CodespacesGetRepoPublicKey (string owner, string repo)

Get a repository public key

Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `codespaces_secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesGetRepoPublicKeyExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get a repository public key
                CodespacesPublicKey result = apiInstance.CodespacesGetRepoPublicKey(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesGetRepoPublicKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 

### Return type

[**CodespacesPublicKey**](CodespacesPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesgetreposecret"></a>
# **CodespacesGetRepoSecret**
> CodespacesSecret CodespacesGetRepoSecret (string owner, string repo, string secretName)

Get a repository secret

Gets a single repository secret without revealing its encrypted value. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `codespaces_secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesGetRepoSecretExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Get a repository secret
                CodespacesSecret result = apiInstance.CodespacesGetRepoSecret(owner, repo, secretName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesGetRepoSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 

### Return type

[**CodespacesSecret**](CodespacesSecret.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesgetsecretforauthenticateduser"></a>
# **CodespacesGetSecretForAuthenticatedUser**
> CodespacesSecret1 CodespacesGetSecretForAuthenticatedUser (string secretName)

Get a secret for the authenticated user

Gets a secret available to a user's codespaces without revealing its encrypted value.  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the `codespaces_user_secrets` user permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesGetSecretForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Get a secret for the authenticated user
                CodespacesSecret1 result = apiInstance.CodespacesGetSecretForAuthenticatedUser(secretName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesGetSecretForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **secretName** | **string**| The name of the secret. | 

### Return type

[**CodespacesSecret1**](CodespacesSecret1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespaceslistdevcontainersinrepositoryforauthenticateduser"></a>
# **CodespacesListDevcontainersInRepositoryForAuthenticatedUser**
> CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response CodespacesListDevcontainersInRepositoryForAuthenticatedUser (string owner, string repo, int? perPage, int? page)

List devcontainer configurations in a repository for the authenticated user

Lists the devcontainer.json files associated with a specified repository and the authenticated user. These files specify launchpoint configurations for codespaces created within the repository.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have read access to the `codespaces_metadata` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesListDevcontainersInRepositoryForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List devcontainer configurations in a repository for the authenticated user
                CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response result = apiInstance.CodespacesListDevcontainersInRepositoryForAuthenticatedUser(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesListDevcontainersInRepositoryForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response**](CodespacesListDevcontainersInRepositoryForAuthenticatedUser200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespaceslistforauthenticateduser"></a>
# **CodespacesListForAuthenticatedUser**
> CodespacesListInOrganization200Response CodespacesListForAuthenticatedUser (int? perPage, int? page, int? repositoryId)

List codespaces for the authenticated user

Lists the authenticated user's codespaces.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have read access to the `codespaces` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesListForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var repositoryId = 56;  // int? | ID of the Repository to filter on (optional) 

            try
            {
                // List codespaces for the authenticated user
                CodespacesListInOrganization200Response result = apiInstance.CodespacesListForAuthenticatedUser(perPage, page, repositoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesListForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **repositoryId** | **int?**| ID of the Repository to filter on | [optional] 

### Return type

[**CodespacesListInOrganization200Response**](CodespacesListInOrganization200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespaceslistinorganization"></a>
# **CodespacesListInOrganization**
> CodespacesListInOrganization200Response CodespacesListInOrganization (string org, int? perPage, int? page)

List codespaces for the organization

Lists the codespaces associated to a specified organization.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesListInOrganizationExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List codespaces for the organization
                CodespacesListInOrganization200Response result = apiInstance.CodespacesListInOrganization(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesListInOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**CodespacesListInOrganization200Response**](CodespacesListInOrganization200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespaceslistinrepositoryforauthenticateduser"></a>
# **CodespacesListInRepositoryForAuthenticatedUser**
> CodespacesListInOrganization200Response CodespacesListInRepositoryForAuthenticatedUser (string owner, string repo, int? perPage, int? page)

List codespaces in a repository for the authenticated user

Lists the codespaces associated to a specified repository and the authenticated user.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have read access to the `codespaces` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesListInRepositoryForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List codespaces in a repository for the authenticated user
                CodespacesListInOrganization200Response result = apiInstance.CodespacesListInRepositoryForAuthenticatedUser(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesListInRepositoryForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**CodespacesListInOrganization200Response**](CodespacesListInOrganization200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespaceslistreposecrets"></a>
# **CodespacesListRepoSecrets**
> CodespacesListRepoSecrets200Response CodespacesListRepoSecrets (string owner, string repo, int? perPage, int? page)

List repository secrets

Lists all secrets available in a repository without revealing their encrypted values. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `codespaces_secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesListRepoSecretsExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository secrets
                CodespacesListRepoSecrets200Response result = apiInstance.CodespacesListRepoSecrets(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesListRepoSecrets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**CodespacesListRepoSecrets200Response**](CodespacesListRepoSecrets200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespaceslistrepositoriesforsecretforauthenticateduser"></a>
# **CodespacesListRepositoriesForSecretForAuthenticatedUser**
> ActionsListSelectedReposForOrgSecret200Response CodespacesListRepositoriesForSecretForAuthenticatedUser (string secretName)

List selected repositories for a user secret

List the repositories that have been granted the ability to use a user's codespace secret.  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the `codespaces_user_secrets` user permission and write access to the `codespaces_secrets` repository permission on all referenced repositories to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesListRepositoriesForSecretForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // List selected repositories for a user secret
                ActionsListSelectedReposForOrgSecret200Response result = apiInstance.CodespacesListRepositoriesForSecretForAuthenticatedUser(secretName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesListRepositoriesForSecretForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **secretName** | **string**| The name of the secret. | 

### Return type

[**ActionsListSelectedReposForOrgSecret200Response**](ActionsListSelectedReposForOrgSecret200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespaceslistsecretsforauthenticateduser"></a>
# **CodespacesListSecretsForAuthenticatedUser**
> CodespacesListSecretsForAuthenticatedUser200Response CodespacesListSecretsForAuthenticatedUser (int? perPage, int? page)

List secrets for the authenticated user

Lists all secrets available for a user's Codespaces without revealing their encrypted values.  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have read access to the `codespaces_user_secrets` user permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesListSecretsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List secrets for the authenticated user
                CodespacesListSecretsForAuthenticatedUser200Response result = apiInstance.CodespacesListSecretsForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesListSecretsForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**CodespacesListSecretsForAuthenticatedUser200Response**](CodespacesListSecretsForAuthenticatedUser200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacespreflightwithrepoforauthenticateduser"></a>
# **CodespacesPreFlightWithRepoForAuthenticatedUser**
> CodespacesPreFlightWithRepoForAuthenticatedUser200Response CodespacesPreFlightWithRepoForAuthenticatedUser (string owner, string repo, string _ref, string clientIp)

Get default attributes for a codespace

Gets the default attributes for codespaces created by the user with the repository.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesPreFlightWithRepoForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = main;  // string | The branch or commit to check for a default devcontainer path. If not specified, the default branch will be checked. (optional) 
            var clientIp = 1.2.3.4;  // string | An alternative IP for default location auto-detection, such as when proxying a request. (optional) 

            try
            {
                // Get default attributes for a codespace
                CodespacesPreFlightWithRepoForAuthenticatedUser200Response result = apiInstance.CodespacesPreFlightWithRepoForAuthenticatedUser(owner, repo, _ref, clientIp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesPreFlightWithRepoForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **_ref** | **string**| The branch or commit to check for a default devcontainer path. If not specified, the default branch will be checked. | [optional] 
 **clientIp** | **string**| An alternative IP for default location auto-detection, such as when proxying a request. | [optional] 

### Return type

[**CodespacesPreFlightWithRepoForAuthenticatedUser200Response**](CodespacesPreFlightWithRepoForAuthenticatedUser200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesremoverepositoryforsecretforauthenticateduser"></a>
# **CodespacesRemoveRepositoryForSecretForAuthenticatedUser**
> void CodespacesRemoveRepositoryForSecretForAuthenticatedUser (string secretName, int? repositoryId)

Remove a selected repository from a user secret

Removes a repository from the selected repositories for a user's codespace secret. You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint. GitHub Apps must have write access to the `codespaces_user_secrets` user permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesRemoveRepositoryForSecretForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var secretName = "secretName_example";  // string | The name of the secret.
            var repositoryId = 56;  // int? | 

            try
            {
                // Remove a selected repository from a user secret
                apiInstance.CodespacesRemoveRepositoryForSecretForAuthenticatedUser(secretName, repositoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesRemoveRepositoryForSecretForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **secretName** | **string**| The name of the secret. | 
 **repositoryId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesrepomachinesforauthenticateduser"></a>
# **CodespacesRepoMachinesForAuthenticatedUser**
> CodespacesRepoMachinesForAuthenticatedUser200Response CodespacesRepoMachinesForAuthenticatedUser (string owner, string repo, string location, string clientIp)

List available machine types for a repository

List the machine types available for a given repository based on its configuration.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces_metadata` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesRepoMachinesForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var location = WestUs2;  // string | The location to check for available machines. Assigned by IP if not provided. (optional) 
            var clientIp = "clientIp_example";  // string | IP for location auto-detection when proxying a request (optional) 

            try
            {
                // List available machine types for a repository
                CodespacesRepoMachinesForAuthenticatedUser200Response result = apiInstance.CodespacesRepoMachinesForAuthenticatedUser(owner, repo, location, clientIp);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesRepoMachinesForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **location** | **string**| The location to check for available machines. Assigned by IP if not provided. | [optional] 
 **clientIp** | **string**| IP for location auto-detection when proxying a request | [optional] 

### Return type

[**CodespacesRepoMachinesForAuthenticatedUser200Response**](CodespacesRepoMachinesForAuthenticatedUser200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacessetrepositoriesforsecretforauthenticateduser"></a>
# **CodespacesSetRepositoriesForSecretForAuthenticatedUser**
> void CodespacesSetRepositoriesForSecretForAuthenticatedUser (string secretName, CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest codespacesSetRepositoriesForSecretForAuthenticatedUserRequest)

Set selected repositories for a user secret

Select the repositories that will use a user's codespace secret.  You must authenticate using an access token with the `codespace` or `codespace:secrets` scope to use this endpoint. User must have Codespaces access to use this endpoint.  GitHub Apps must have write access to the `codespaces_user_secrets` user permission and write access to the `codespaces_secrets` repository permission on all referenced repositories to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesSetRepositoriesForSecretForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var secretName = "secretName_example";  // string | The name of the secret.
            var codespacesSetRepositoriesForSecretForAuthenticatedUserRequest = new CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest(); // CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest | 

            try
            {
                // Set selected repositories for a user secret
                apiInstance.CodespacesSetRepositoriesForSecretForAuthenticatedUser(secretName, codespacesSetRepositoriesForSecretForAuthenticatedUserRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesSetRepositoriesForSecretForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **secretName** | **string**| The name of the secret. | 
 **codespacesSetRepositoriesForSecretForAuthenticatedUserRequest** | [**CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest**](CodespacesSetRepositoriesForSecretForAuthenticatedUserRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesstartforauthenticateduser"></a>
# **CodespacesStartForAuthenticatedUser**
> Codespace CodespacesStartForAuthenticatedUser (string codespaceName)

Start a codespace for the authenticated user

Starts a user's codespace.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces_lifecycle_admin` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesStartForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var codespaceName = "codespaceName_example";  // string | The name of the codespace.

            try
            {
                // Start a codespace for the authenticated user
                Codespace result = apiInstance.CodespacesStartForAuthenticatedUser(codespaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesStartForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codespaceName** | **string**| The name of the codespace. | 

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesstopforauthenticateduser"></a>
# **CodespacesStopForAuthenticatedUser**
> Codespace CodespacesStopForAuthenticatedUser (string codespaceName)

Stop a codespace for the authenticated user

Stops a user's codespace.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces_lifecycle_admin` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesStopForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var codespaceName = "codespaceName_example";  // string | The name of the codespace.

            try
            {
                // Stop a codespace for the authenticated user
                Codespace result = apiInstance.CodespacesStopForAuthenticatedUser(codespaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesStopForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codespaceName** | **string**| The name of the codespace. | 

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesstopinorganization"></a>
# **CodespacesStopInOrganization**
> Codespace CodespacesStopInOrganization (string org, string username, string codespaceName)

Stop a codespace for an organization user

Stops a user's codespace.  You must authenticate using an access token with the `admin:org` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesStopInOrganizationExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.
            var codespaceName = "codespaceName_example";  // string | The name of the codespace.

            try
            {
                // Stop a codespace for an organization user
                Codespace result = apiInstance.CodespacesStopInOrganization(org, username, codespaceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesStopInOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 
 **codespaceName** | **string**| The name of the codespace. | 

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codespacesupdateforauthenticateduser"></a>
# **CodespacesUpdateForAuthenticatedUser**
> Codespace CodespacesUpdateForAuthenticatedUser (string codespaceName, CodespacesUpdateForAuthenticatedUserRequest codespacesUpdateForAuthenticatedUserRequest)

Update a codespace for the authenticated user

Updates a codespace owned by the authenticated user. Currently only the codespace's machine type and recent folders can be modified using this endpoint.  If you specify a new machine type it will be applied the next time your codespace is started.  You must authenticate using an access token with the `codespace` scope to use this endpoint.  GitHub Apps must have write access to the `codespaces` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodespacesUpdateForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new CodespacesApi();
            var codespaceName = "codespaceName_example";  // string | The name of the codespace.
            var codespacesUpdateForAuthenticatedUserRequest = new CodespacesUpdateForAuthenticatedUserRequest(); // CodespacesUpdateForAuthenticatedUserRequest |  (optional) 

            try
            {
                // Update a codespace for the authenticated user
                Codespace result = apiInstance.CodespacesUpdateForAuthenticatedUser(codespaceName, codespacesUpdateForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodespacesApi.CodespacesUpdateForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codespaceName** | **string**| The name of the codespace. | 
 **codespacesUpdateForAuthenticatedUserRequest** | [**CodespacesUpdateForAuthenticatedUserRequest**](CodespacesUpdateForAuthenticatedUserRequest.md)|  | [optional] 

### Return type

[**Codespace**](Codespace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

