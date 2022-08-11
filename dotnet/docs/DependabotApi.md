# Org.OpenAPITools.Api.DependabotApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DependabotAddSelectedRepoToOrgSecret**](DependabotApi.md#dependabotaddselectedrepotoorgsecret) | **PUT** /orgs/{org}/dependabot/secrets/{secret_name}/repositories/{repository_id} | Add selected repository to an organization secret
[**DependabotCreateOrUpdateOrgSecret**](DependabotApi.md#dependabotcreateorupdateorgsecret) | **PUT** /orgs/{org}/dependabot/secrets/{secret_name} | Create or update an organization secret
[**DependabotCreateOrUpdateRepoSecret**](DependabotApi.md#dependabotcreateorupdatereposecret) | **PUT** /repos/{owner}/{repo}/dependabot/secrets/{secret_name} | Create or update a repository secret
[**DependabotDeleteOrgSecret**](DependabotApi.md#dependabotdeleteorgsecret) | **DELETE** /orgs/{org}/dependabot/secrets/{secret_name} | Delete an organization secret
[**DependabotDeleteRepoSecret**](DependabotApi.md#dependabotdeletereposecret) | **DELETE** /repos/{owner}/{repo}/dependabot/secrets/{secret_name} | Delete a repository secret
[**DependabotGetOrgPublicKey**](DependabotApi.md#dependabotgetorgpublickey) | **GET** /orgs/{org}/dependabot/secrets/public-key | Get an organization public key
[**DependabotGetOrgSecret**](DependabotApi.md#dependabotgetorgsecret) | **GET** /orgs/{org}/dependabot/secrets/{secret_name} | Get an organization secret
[**DependabotGetRepoPublicKey**](DependabotApi.md#dependabotgetrepopublickey) | **GET** /repos/{owner}/{repo}/dependabot/secrets/public-key | Get a repository public key
[**DependabotGetRepoSecret**](DependabotApi.md#dependabotgetreposecret) | **GET** /repos/{owner}/{repo}/dependabot/secrets/{secret_name} | Get a repository secret
[**DependabotListOrgSecrets**](DependabotApi.md#dependabotlistorgsecrets) | **GET** /orgs/{org}/dependabot/secrets | List organization secrets
[**DependabotListRepoSecrets**](DependabotApi.md#dependabotlistreposecrets) | **GET** /repos/{owner}/{repo}/dependabot/secrets | List repository secrets
[**DependabotListSelectedReposForOrgSecret**](DependabotApi.md#dependabotlistselectedreposfororgsecret) | **GET** /orgs/{org}/dependabot/secrets/{secret_name}/repositories | List selected repositories for an organization secret
[**DependabotRemoveSelectedRepoFromOrgSecret**](DependabotApi.md#dependabotremoveselectedrepofromorgsecret) | **DELETE** /orgs/{org}/dependabot/secrets/{secret_name}/repositories/{repository_id} | Remove selected repository from an organization secret
[**DependabotSetSelectedReposForOrgSecret**](DependabotApi.md#dependabotsetselectedreposfororgsecret) | **PUT** /orgs/{org}/dependabot/secrets/{secret_name}/repositories | Set selected repositories for an organization secret


<a name="dependabotaddselectedrepotoorgsecret"></a>
# **DependabotAddSelectedRepoToOrgSecret**
> void DependabotAddSelectedRepoToOrgSecret (string org, string secretName, int? repositoryId)

Add selected repository to an organization secret

Adds a repository to an organization secret when the `visibility` for repository access is set to `selected`. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/dependabot#create-or-update-an-organization-secret). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotAddSelectedRepoToOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var repositoryId = 56;  // int? | 

            try
            {
                // Add selected repository to an organization secret
                apiInstance.DependabotAddSelectedRepoToOrgSecret(org, secretName, repositoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotAddSelectedRepoToOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 
 **repositoryId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependabotcreateorupdateorgsecret"></a>
# **DependabotCreateOrUpdateOrgSecret**
> Object DependabotCreateOrUpdateOrgSecret (string org, string secretName, DependabotCreateOrUpdateOrgSecretRequest dependabotCreateOrUpdateOrgSecretRequest)

Create or update an organization secret

Creates or updates an organization secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotCreateOrUpdateOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var dependabotCreateOrUpdateOrgSecretRequest = new DependabotCreateOrUpdateOrgSecretRequest(); // DependabotCreateOrUpdateOrgSecretRequest | 

            try
            {
                // Create or update an organization secret
                Object result = apiInstance.DependabotCreateOrUpdateOrgSecret(org, secretName, dependabotCreateOrUpdateOrgSecretRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotCreateOrUpdateOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 
 **dependabotCreateOrUpdateOrgSecretRequest** | [**DependabotCreateOrUpdateOrgSecretRequest**](DependabotCreateOrUpdateOrgSecretRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependabotcreateorupdatereposecret"></a>
# **DependabotCreateOrUpdateRepoSecret**
> Object DependabotCreateOrUpdateRepoSecret (string owner, string repo, string secretName, DependabotCreateOrUpdateRepoSecretRequest dependabotCreateOrUpdateRepoSecretRequest)

Create or update a repository secret

Creates or updates a repository secret with an encrypted value. Encrypt your secret using [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages). You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` repository permission to use this endpoint.  #### Example encrypting a secret using Node.js  Encrypt your secret using the [tweetsodium](https://github.com/github/tweetsodium) library.  ``` const sodium = require('tweetsodium');  const key = \"base64-encoded-public-key\"; const value = \"plain-text-secret\";  // Convert the message and key to Uint8Array's (Buffer implements that interface) const messageBytes = Buffer.from(value); const keyBytes = Buffer.from(key, 'base64');  // Encrypt using LibSodium. const encryptedBytes = sodium.seal(messageBytes, keyBytes);  // Base64 the encrypted secret const encrypted = Buffer.from(encryptedBytes).toString('base64');  console.log(encrypted); ```   #### Example encrypting a secret using Python  Encrypt your secret using [pynacl](https://pynacl.readthedocs.io/en/latest/public/#nacl-public-sealedbox) with Python 3.  ``` from base64 import b64encode from nacl import encoding, public  def encrypt(public_key: str, secret_value: str) -> str:   \"\"\"Encrypt a Unicode string using the public key.\"\"\"   public_key = public.PublicKey(public_key.encode(\"utf-8\"), encoding.Base64Encoder())   sealed_box = public.SealedBox(public_key)   encrypted = sealed_box.encrypt(secret_value.encode(\"utf-8\"))   return b64encode(encrypted).decode(\"utf-8\") ```  #### Example encrypting a secret using C#  Encrypt your secret using the [Sodium.Core](https://www.nuget.org/packages/Sodium.Core/) package.  ``` var secretValue = System.Text.Encoding.UTF8.GetBytes(\"mySecret\"); var publicKey = Convert.FromBase64String(\"2Sg8iYjAxxmI2LvUXpJjkYrMxURPc8r+dB7TJyvvcCU=\");  var sealedPublicKeyBox = Sodium.SealedPublicKeyBox.Create(secretValue, publicKey);  Console.WriteLine(Convert.ToBase64String(sealedPublicKeyBox)); ```  #### Example encrypting a secret using Ruby  Encrypt your secret using the [rbnacl](https://github.com/RubyCrypto/rbnacl) gem.  ```ruby require \"rbnacl\" require \"base64\"  key = Base64.decode64(\"+ZYvJDZMHUfBkJdyq5Zm9SKqeuBQ4sj+6sfjlH4CgG0=\") public_key = RbNaCl::PublicKey.new(key)  box = RbNaCl::Boxes::Sealed.from_public_key(public_key) encrypted_secret = box.encrypt(\"my_secret\")  # Print the base64 encoded secret puts Base64.strict_encode64(encrypted_secret) ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotCreateOrUpdateRepoSecretExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var dependabotCreateOrUpdateRepoSecretRequest = new DependabotCreateOrUpdateRepoSecretRequest(); // DependabotCreateOrUpdateRepoSecretRequest | 

            try
            {
                // Create or update a repository secret
                Object result = apiInstance.DependabotCreateOrUpdateRepoSecret(owner, repo, secretName, dependabotCreateOrUpdateRepoSecretRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotCreateOrUpdateRepoSecret: " + e.Message );
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
 **dependabotCreateOrUpdateRepoSecretRequest** | [**DependabotCreateOrUpdateRepoSecretRequest**](DependabotCreateOrUpdateRepoSecretRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependabotdeleteorgsecret"></a>
# **DependabotDeleteOrgSecret**
> void DependabotDeleteOrgSecret (string org, string secretName)

Delete an organization secret

Deletes a secret in an organization using the secret name. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotDeleteOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Delete an organization secret
                apiInstance.DependabotDeleteOrgSecret(org, secretName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotDeleteOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependabotdeletereposecret"></a>
# **DependabotDeleteRepoSecret**
> void DependabotDeleteRepoSecret (string owner, string repo, string secretName)

Delete a repository secret

Deletes a secret in a repository using the secret name. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotDeleteRepoSecretExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Delete a repository secret
                apiInstance.DependabotDeleteRepoSecret(owner, repo, secretName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotDeleteRepoSecret: " + e.Message );
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

<a name="dependabotgetorgpublickey"></a>
# **DependabotGetOrgPublicKey**
> DependabotPublicKey DependabotGetOrgPublicKey (string org)

Get an organization public key

Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotGetOrgPublicKeyExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get an organization public key
                DependabotPublicKey result = apiInstance.DependabotGetOrgPublicKey(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotGetOrgPublicKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 

### Return type

[**DependabotPublicKey**](DependabotPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependabotgetorgsecret"></a>
# **DependabotGetOrgSecret**
> DependabotSecretForAnOrganization DependabotGetOrgSecret (string org, string secretName)

Get an organization secret

Gets a single organization secret without revealing its encrypted value. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotGetOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Get an organization secret
                DependabotSecretForAnOrganization result = apiInstance.DependabotGetOrgSecret(org, secretName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotGetOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 

### Return type

[**DependabotSecretForAnOrganization**](DependabotSecretForAnOrganization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependabotgetrepopublickey"></a>
# **DependabotGetRepoPublicKey**
> DependabotPublicKey DependabotGetRepoPublicKey (string owner, string repo)

Get a repository public key

Gets your public key, which you need to encrypt secrets. You need to encrypt a secret before you can create or update secrets. Anyone with read access to the repository can use this endpoint. If the repository is private you must use an access token with the `repo` scope. GitHub Apps must have the `dependabot_secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotGetRepoPublicKeyExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get a repository public key
                DependabotPublicKey result = apiInstance.DependabotGetRepoPublicKey(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotGetRepoPublicKey: " + e.Message );
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

[**DependabotPublicKey**](DependabotPublicKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependabotgetreposecret"></a>
# **DependabotGetRepoSecret**
> DependabotSecret DependabotGetRepoSecret (string owner, string repo, string secretName)

Get a repository secret

Gets a single repository secret without revealing its encrypted value. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotGetRepoSecretExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.

            try
            {
                // Get a repository secret
                DependabotSecret result = apiInstance.DependabotGetRepoSecret(owner, repo, secretName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotGetRepoSecret: " + e.Message );
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

[**DependabotSecret**](DependabotSecret.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependabotlistorgsecrets"></a>
# **DependabotListOrgSecrets**
> DependabotListOrgSecrets200Response DependabotListOrgSecrets (string org, int? perPage, int? page)

List organization secrets

Lists all secrets available in an organization without revealing their encrypted values. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotListOrgSecretsExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organization secrets
                DependabotListOrgSecrets200Response result = apiInstance.DependabotListOrgSecrets(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotListOrgSecrets: " + e.Message );
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

[**DependabotListOrgSecrets200Response**](DependabotListOrgSecrets200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependabotlistreposecrets"></a>
# **DependabotListRepoSecrets**
> DependabotListRepoSecrets200Response DependabotListRepoSecrets (string owner, string repo, int? perPage, int? page)

List repository secrets

Lists all secrets available in a repository without revealing their encrypted values. You must authenticate using an access token with the `repo` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` repository permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotListRepoSecretsExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository secrets
                DependabotListRepoSecrets200Response result = apiInstance.DependabotListRepoSecrets(owner, repo, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotListRepoSecrets: " + e.Message );
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

[**DependabotListRepoSecrets200Response**](DependabotListRepoSecrets200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependabotlistselectedreposfororgsecret"></a>
# **DependabotListSelectedReposForOrgSecret**
> ActionsListSelectedReposForOrgSecret200Response DependabotListSelectedReposForOrgSecret (string org, string secretName, int? page, int? perPage)

List selected repositories for an organization secret

Lists all repositories that have been selected when the `visibility` for repository access to a secret is set to `selected`. You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotListSelectedReposForOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)

            try
            {
                // List selected repositories for an organization secret
                ActionsListSelectedReposForOrgSecret200Response result = apiInstance.DependabotListSelectedReposForOrgSecret(org, secretName, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotListSelectedReposForOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]

### Return type

[**ActionsListSelectedReposForOrgSecret200Response**](ActionsListSelectedReposForOrgSecret200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependabotremoveselectedrepofromorgsecret"></a>
# **DependabotRemoveSelectedRepoFromOrgSecret**
> void DependabotRemoveSelectedRepoFromOrgSecret (string org, string secretName, int? repositoryId)

Remove selected repository from an organization secret

Removes a repository from an organization secret when the `visibility` for repository access is set to `selected`. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/dependabot#create-or-update-an-organization-secret). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotRemoveSelectedRepoFromOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var repositoryId = 56;  // int? | 

            try
            {
                // Remove selected repository from an organization secret
                apiInstance.DependabotRemoveSelectedRepoFromOrgSecret(org, secretName, repositoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotRemoveSelectedRepoFromOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 
 **repositoryId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependabotsetselectedreposfororgsecret"></a>
# **DependabotSetSelectedReposForOrgSecret**
> void DependabotSetSelectedReposForOrgSecret (string org, string secretName, DependabotSetSelectedReposForOrgSecretRequest dependabotSetSelectedReposForOrgSecretRequest)

Set selected repositories for an organization secret

Replaces all repositories for an organization secret when the `visibility` for repository access is set to `selected`. The visibility is set when you [Create or update an organization secret](https://docs.github.com/rest/reference/dependabot#create-or-update-an-organization-secret). You must authenticate using an access token with the `admin:org` scope to use this endpoint. GitHub Apps must have the `dependabot_secrets` organization permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependabotSetSelectedReposForOrgSecretExample
    {
        public void main()
        {
            var apiInstance = new DependabotApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var secretName = "secretName_example";  // string | The name of the secret.
            var dependabotSetSelectedReposForOrgSecretRequest = new DependabotSetSelectedReposForOrgSecretRequest(); // DependabotSetSelectedReposForOrgSecretRequest | 

            try
            {
                // Set selected repositories for an organization secret
                apiInstance.DependabotSetSelectedReposForOrgSecret(org, secretName, dependabotSetSelectedReposForOrgSecretRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependabotApi.DependabotSetSelectedReposForOrgSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **secretName** | **string**| The name of the secret. | 
 **dependabotSetSelectedReposForOrgSecretRequest** | [**DependabotSetSelectedReposForOrgSecretRequest**](DependabotSetSelectedReposForOrgSecretRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

