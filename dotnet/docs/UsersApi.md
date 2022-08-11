# Org.OpenAPITools.Api.UsersApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersAddEmailForAuthenticatedUser**](UsersApi.md#usersaddemailforauthenticateduser) | **POST** /user/emails | Add an email address for the authenticated user
[**UsersBlock**](UsersApi.md#usersblock) | **PUT** /user/blocks/{username} | Block a user
[**UsersCheckBlocked**](UsersApi.md#userscheckblocked) | **GET** /user/blocks/{username} | Check if a user is blocked by the authenticated user
[**UsersCheckFollowingForUser**](UsersApi.md#userscheckfollowingforuser) | **GET** /users/{username}/following/{target_user} | Check if a user follows another user
[**UsersCheckPersonIsFollowedByAuthenticated**](UsersApi.md#userscheckpersonisfollowedbyauthenticated) | **GET** /user/following/{username} | Check if a person is followed by the authenticated user
[**UsersCreateGpgKeyForAuthenticatedUser**](UsersApi.md#userscreategpgkeyforauthenticateduser) | **POST** /user/gpg_keys | Create a GPG key for the authenticated user
[**UsersCreatePublicSshKeyForAuthenticatedUser**](UsersApi.md#userscreatepublicsshkeyforauthenticateduser) | **POST** /user/keys | Create a public SSH key for the authenticated user
[**UsersDeleteEmailForAuthenticatedUser**](UsersApi.md#usersdeleteemailforauthenticateduser) | **DELETE** /user/emails | Delete an email address for the authenticated user
[**UsersDeleteGpgKeyForAuthenticatedUser**](UsersApi.md#usersdeletegpgkeyforauthenticateduser) | **DELETE** /user/gpg_keys/{gpg_key_id} | Delete a GPG key for the authenticated user
[**UsersDeletePublicSshKeyForAuthenticatedUser**](UsersApi.md#usersdeletepublicsshkeyforauthenticateduser) | **DELETE** /user/keys/{key_id} | Delete a public SSH key for the authenticated user
[**UsersFollow**](UsersApi.md#usersfollow) | **PUT** /user/following/{username} | Follow a user
[**UsersGetAuthenticated**](UsersApi.md#usersgetauthenticated) | **GET** /user | Get the authenticated user
[**UsersGetByUsername**](UsersApi.md#usersgetbyusername) | **GET** /users/{username} | Get a user
[**UsersGetContextForUser**](UsersApi.md#usersgetcontextforuser) | **GET** /users/{username}/hovercard | Get contextual information for a user
[**UsersGetGpgKeyForAuthenticatedUser**](UsersApi.md#usersgetgpgkeyforauthenticateduser) | **GET** /user/gpg_keys/{gpg_key_id} | Get a GPG key for the authenticated user
[**UsersGetPublicSshKeyForAuthenticatedUser**](UsersApi.md#usersgetpublicsshkeyforauthenticateduser) | **GET** /user/keys/{key_id} | Get a public SSH key for the authenticated user
[**UsersList**](UsersApi.md#userslist) | **GET** /users | List users
[**UsersListBlockedByAuthenticatedUser**](UsersApi.md#userslistblockedbyauthenticateduser) | **GET** /user/blocks | List users blocked by the authenticated user
[**UsersListEmailsForAuthenticatedUser**](UsersApi.md#userslistemailsforauthenticateduser) | **GET** /user/emails | List email addresses for the authenticated user
[**UsersListFollowedByAuthenticatedUser**](UsersApi.md#userslistfollowedbyauthenticateduser) | **GET** /user/following | List the people the authenticated user follows
[**UsersListFollowersForAuthenticatedUser**](UsersApi.md#userslistfollowersforauthenticateduser) | **GET** /user/followers | List followers of the authenticated user
[**UsersListFollowersForUser**](UsersApi.md#userslistfollowersforuser) | **GET** /users/{username}/followers | List followers of a user
[**UsersListFollowingForUser**](UsersApi.md#userslistfollowingforuser) | **GET** /users/{username}/following | List the people a user follows
[**UsersListGpgKeysForAuthenticatedUser**](UsersApi.md#userslistgpgkeysforauthenticateduser) | **GET** /user/gpg_keys | List GPG keys for the authenticated user
[**UsersListGpgKeysForUser**](UsersApi.md#userslistgpgkeysforuser) | **GET** /users/{username}/gpg_keys | List GPG keys for a user
[**UsersListPublicEmailsForAuthenticatedUser**](UsersApi.md#userslistpublicemailsforauthenticateduser) | **GET** /user/public_emails | List public email addresses for the authenticated user
[**UsersListPublicKeysForUser**](UsersApi.md#userslistpublickeysforuser) | **GET** /users/{username}/keys | List public keys for a user
[**UsersListPublicSshKeysForAuthenticatedUser**](UsersApi.md#userslistpublicsshkeysforauthenticateduser) | **GET** /user/keys | List public SSH keys for the authenticated user
[**UsersSetPrimaryEmailVisibilityForAuthenticatedUser**](UsersApi.md#userssetprimaryemailvisibilityforauthenticateduser) | **PATCH** /user/email/visibility | Set primary email visibility for the authenticated user
[**UsersUnblock**](UsersApi.md#usersunblock) | **DELETE** /user/blocks/{username} | Unblock a user
[**UsersUnfollow**](UsersApi.md#usersunfollow) | **DELETE** /user/following/{username} | Unfollow a user
[**UsersUpdateAuthenticated**](UsersApi.md#usersupdateauthenticated) | **PATCH** /user | Update the authenticated user


<a name="usersaddemailforauthenticateduser"></a>
# **UsersAddEmailForAuthenticatedUser**
> List<Email> UsersAddEmailForAuthenticatedUser (UsersAddEmailForAuthenticatedUserRequest usersAddEmailForAuthenticatedUserRequest)

Add an email address for the authenticated user

This endpoint is accessible with the `user` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersAddEmailForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var usersAddEmailForAuthenticatedUserRequest = new UsersAddEmailForAuthenticatedUserRequest(); // UsersAddEmailForAuthenticatedUserRequest |  (optional) 

            try
            {
                // Add an email address for the authenticated user
                List&lt;Email&gt; result = apiInstance.UsersAddEmailForAuthenticatedUser(usersAddEmailForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersAddEmailForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usersAddEmailForAuthenticatedUserRequest** | [**UsersAddEmailForAuthenticatedUserRequest**](UsersAddEmailForAuthenticatedUserRequest.md)|  | [optional] 

### Return type

[**List<Email>**](Email.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersblock"></a>
# **UsersBlock**
> void UsersBlock (string username)

Block a user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersBlockExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Block a user
                apiInstance.UsersBlock(username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersBlock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userscheckblocked"></a>
# **UsersCheckBlocked**
> void UsersCheckBlocked (string username)

Check if a user is blocked by the authenticated user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersCheckBlockedExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Check if a user is blocked by the authenticated user
                apiInstance.UsersCheckBlocked(username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersCheckBlocked: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userscheckfollowingforuser"></a>
# **UsersCheckFollowingForUser**
> void UsersCheckFollowingForUser (string username, string targetUser)

Check if a user follows another user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersCheckFollowingForUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var targetUser = "targetUser_example";  // string | 

            try
            {
                // Check if a user follows another user
                apiInstance.UsersCheckFollowingForUser(username, targetUser);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersCheckFollowingForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **targetUser** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userscheckpersonisfollowedbyauthenticated"></a>
# **UsersCheckPersonIsFollowedByAuthenticated**
> void UsersCheckPersonIsFollowedByAuthenticated (string username)

Check if a person is followed by the authenticated user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersCheckPersonIsFollowedByAuthenticatedExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Check if a person is followed by the authenticated user
                apiInstance.UsersCheckPersonIsFollowedByAuthenticated(username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersCheckPersonIsFollowedByAuthenticated: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userscreategpgkeyforauthenticateduser"></a>
# **UsersCreateGpgKeyForAuthenticatedUser**
> GPGKey UsersCreateGpgKeyForAuthenticatedUser (UsersCreateGpgKeyForAuthenticatedUserRequest usersCreateGpgKeyForAuthenticatedUserRequest)

Create a GPG key for the authenticated user

Adds a GPG key to the authenticated user's GitHub account. Requires that you are authenticated via Basic Auth, or OAuth with at least `write:gpg_key` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersCreateGpgKeyForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var usersCreateGpgKeyForAuthenticatedUserRequest = new UsersCreateGpgKeyForAuthenticatedUserRequest(); // UsersCreateGpgKeyForAuthenticatedUserRequest | 

            try
            {
                // Create a GPG key for the authenticated user
                GPGKey result = apiInstance.UsersCreateGpgKeyForAuthenticatedUser(usersCreateGpgKeyForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersCreateGpgKeyForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usersCreateGpgKeyForAuthenticatedUserRequest** | [**UsersCreateGpgKeyForAuthenticatedUserRequest**](UsersCreateGpgKeyForAuthenticatedUserRequest.md)|  | 

### Return type

[**GPGKey**](GPGKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userscreatepublicsshkeyforauthenticateduser"></a>
# **UsersCreatePublicSshKeyForAuthenticatedUser**
> Key UsersCreatePublicSshKeyForAuthenticatedUser (UsersCreatePublicSshKeyForAuthenticatedUserRequest usersCreatePublicSshKeyForAuthenticatedUserRequest)

Create a public SSH key for the authenticated user

Adds a public SSH key to the authenticated user's GitHub account. Requires that you are authenticated via Basic Auth, or OAuth with at least `write:public_key` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersCreatePublicSshKeyForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var usersCreatePublicSshKeyForAuthenticatedUserRequest = new UsersCreatePublicSshKeyForAuthenticatedUserRequest(); // UsersCreatePublicSshKeyForAuthenticatedUserRequest | 

            try
            {
                // Create a public SSH key for the authenticated user
                Key result = apiInstance.UsersCreatePublicSshKeyForAuthenticatedUser(usersCreatePublicSshKeyForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersCreatePublicSshKeyForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usersCreatePublicSshKeyForAuthenticatedUserRequest** | [**UsersCreatePublicSshKeyForAuthenticatedUserRequest**](UsersCreatePublicSshKeyForAuthenticatedUserRequest.md)|  | 

### Return type

[**Key**](Key.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersdeleteemailforauthenticateduser"></a>
# **UsersDeleteEmailForAuthenticatedUser**
> void UsersDeleteEmailForAuthenticatedUser (UsersDeleteEmailForAuthenticatedUserRequest usersDeleteEmailForAuthenticatedUserRequest)

Delete an email address for the authenticated user

This endpoint is accessible with the `user` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersDeleteEmailForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var usersDeleteEmailForAuthenticatedUserRequest = new UsersDeleteEmailForAuthenticatedUserRequest(); // UsersDeleteEmailForAuthenticatedUserRequest |  (optional) 

            try
            {
                // Delete an email address for the authenticated user
                apiInstance.UsersDeleteEmailForAuthenticatedUser(usersDeleteEmailForAuthenticatedUserRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersDeleteEmailForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usersDeleteEmailForAuthenticatedUserRequest** | [**UsersDeleteEmailForAuthenticatedUserRequest**](UsersDeleteEmailForAuthenticatedUserRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersdeletegpgkeyforauthenticateduser"></a>
# **UsersDeleteGpgKeyForAuthenticatedUser**
> void UsersDeleteGpgKeyForAuthenticatedUser (int? gpgKeyId)

Delete a GPG key for the authenticated user

Removes a GPG key from the authenticated user's GitHub account. Requires that you are authenticated via Basic Auth or via OAuth with at least `admin:gpg_key` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersDeleteGpgKeyForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var gpgKeyId = 56;  // int? | The unique identifier of the GPG key.

            try
            {
                // Delete a GPG key for the authenticated user
                apiInstance.UsersDeleteGpgKeyForAuthenticatedUser(gpgKeyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersDeleteGpgKeyForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gpgKeyId** | **int?**| The unique identifier of the GPG key. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersdeletepublicsshkeyforauthenticateduser"></a>
# **UsersDeletePublicSshKeyForAuthenticatedUser**
> void UsersDeletePublicSshKeyForAuthenticatedUser (int? keyId)

Delete a public SSH key for the authenticated user

Removes a public SSH key from the authenticated user's GitHub account. Requires that you are authenticated via Basic Auth or via OAuth with at least `admin:public_key` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersDeletePublicSshKeyForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var keyId = 56;  // int? | The unique identifier of the key.

            try
            {
                // Delete a public SSH key for the authenticated user
                apiInstance.UsersDeletePublicSshKeyForAuthenticatedUser(keyId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersDeletePublicSshKeyForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyId** | **int?**| The unique identifier of the key. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersfollow"></a>
# **UsersFollow**
> void UsersFollow (string username)

Follow a user

Note that you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see \"[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\"  Following a user requires the user to be logged in and authenticated with basic auth or OAuth with the `user:follow` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersFollowExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Follow a user
                apiInstance.UsersFollow(username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersFollow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersgetauthenticated"></a>
# **UsersGetAuthenticated**
> UsersGetAuthenticated200Response UsersGetAuthenticated ()

Get the authenticated user

If the authenticated user is authenticated through basic authentication or OAuth with the `user` scope, then the response lists public and private profile information.  If the authenticated user is authenticated through OAuth without the `user` scope, then the response lists only public profile information.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersGetAuthenticatedExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();

            try
            {
                // Get the authenticated user
                UsersGetAuthenticated200Response result = apiInstance.UsersGetAuthenticated();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGetAuthenticated: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UsersGetAuthenticated200Response**](UsersGetAuthenticated200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersgetbyusername"></a>
# **UsersGetByUsername**
> UsersGetAuthenticated200Response UsersGetByUsername (string username)

Get a user

Provides publicly available information about someone with a GitHub account.  GitHub Apps with the `Plan` user permission can use this endpoint to retrieve information about a user's GitHub plan. The GitHub App must be authenticated as a user. See \"[Identifying and authorizing users for GitHub Apps](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/)\" for details about authentication. For an example response, see 'Response with GitHub plan information' below\"  The `email` key in the following response is the publicly visible email address from your GitHub [profile page](https://github.com/settings/profile). When setting up your profile, you can select a primary email address to be “public” which provides an email entry for this endpoint. If you do not set a public email address for `email`, then it will have a value of `null`. You only see publicly visible email addresses when authenticated with GitHub. For more information, see [Authentication](https://docs.github.com/rest/overview/resources-in-the-rest-api#authentication).  The Emails API enables you to list all of your email addresses, and toggle a primary email to be visible publicly. For more information, see \"[Emails API](https://docs.github.com/rest/reference/users#emails)\".

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersGetByUsernameExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get a user
                UsersGetAuthenticated200Response result = apiInstance.UsersGetByUsername(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGetByUsername: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

[**UsersGetAuthenticated200Response**](UsersGetAuthenticated200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersgetcontextforuser"></a>
# **UsersGetContextForUser**
> Hovercard UsersGetContextForUser (string username, string subjectType, string subjectId)

Get contextual information for a user

Provides hovercard information when authenticated through basic auth or OAuth with the `repo` scope. You can find out more about someone in relation to their pull requests, issues, repositories, and organizations.  The `subject_type` and `subject_id` parameters provide context for the person's hovercard, which returns more information than without the parameters. For example, if you wanted to find out more about `octocat` who owns the `Spoon-Knife` repository via cURL, it would look like this:  ```shell  curl -u username:token   https://api.github.com/users/octocat/hovercard?subject_type=repository&subject_id=1300192 ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersGetContextForUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var subjectType = "organization";  // string | Identifies which additional information you'd like to receive about the person's hovercard. Can be `organization`, `repository`, `issue`, `pull_request`. **Required** when using `subject_id`. (optional) 
            var subjectId = "subjectId_example";  // string | Uses the ID for the `subject_type` you specified. **Required** when using `subject_type`. (optional) 

            try
            {
                // Get contextual information for a user
                Hovercard result = apiInstance.UsersGetContextForUser(username, subjectType, subjectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGetContextForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **subjectType** | **string**| Identifies which additional information you&#39;d like to receive about the person&#39;s hovercard. Can be &#x60;organization&#x60;, &#x60;repository&#x60;, &#x60;issue&#x60;, &#x60;pull_request&#x60;. **Required** when using &#x60;subject_id&#x60;. | [optional] 
 **subjectId** | **string**| Uses the ID for the &#x60;subject_type&#x60; you specified. **Required** when using &#x60;subject_type&#x60;. | [optional] 

### Return type

[**Hovercard**](Hovercard.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersgetgpgkeyforauthenticateduser"></a>
# **UsersGetGpgKeyForAuthenticatedUser**
> GPGKey UsersGetGpgKeyForAuthenticatedUser (int? gpgKeyId)

Get a GPG key for the authenticated user

View extended details for a single GPG key. Requires that you are authenticated via Basic Auth or via OAuth with at least `read:gpg_key` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersGetGpgKeyForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var gpgKeyId = 56;  // int? | The unique identifier of the GPG key.

            try
            {
                // Get a GPG key for the authenticated user
                GPGKey result = apiInstance.UsersGetGpgKeyForAuthenticatedUser(gpgKeyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGetGpgKeyForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gpgKeyId** | **int?**| The unique identifier of the GPG key. | 

### Return type

[**GPGKey**](GPGKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersgetpublicsshkeyforauthenticateduser"></a>
# **UsersGetPublicSshKeyForAuthenticatedUser**
> Key UsersGetPublicSshKeyForAuthenticatedUser (int? keyId)

Get a public SSH key for the authenticated user

View extended details for a single public SSH key. Requires that you are authenticated via Basic Auth or via OAuth with at least `read:public_key` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersGetPublicSshKeyForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var keyId = 56;  // int? | The unique identifier of the key.

            try
            {
                // Get a public SSH key for the authenticated user
                Key result = apiInstance.UsersGetPublicSshKeyForAuthenticatedUser(keyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGetPublicSshKeyForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keyId** | **int?**| The unique identifier of the key. | 

### Return type

[**Key**](Key.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userslist"></a>
# **UsersList**
> List<SimpleUser1> UsersList (int? since, int? perPage)

List users

Lists all users, in the order that they signed up on GitHub. This list includes personal user accounts and organization accounts.  Note: Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header) to get the URL for the next page of users.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersListExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var since = 56;  // int? | A user ID. Only return users with an ID greater than this ID. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)

            try
            {
                // List users
                List&lt;SimpleUser1&gt; result = apiInstance.UsersList(since, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **int?**| A user ID. Only return users with an ID greater than this ID. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]

### Return type

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userslistblockedbyauthenticateduser"></a>
# **UsersListBlockedByAuthenticatedUser**
> List<SimpleUser1> UsersListBlockedByAuthenticatedUser ()

List users blocked by the authenticated user

List the users you've blocked on your personal account.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersListBlockedByAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();

            try
            {
                // List users blocked by the authenticated user
                List&lt;SimpleUser1&gt; result = apiInstance.UsersListBlockedByAuthenticatedUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersListBlockedByAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userslistemailsforauthenticateduser"></a>
# **UsersListEmailsForAuthenticatedUser**
> List<Email> UsersListEmailsForAuthenticatedUser (int? perPage, int? page)

List email addresses for the authenticated user

Lists all of your email addresses, and specifies which one is visible to the public. This endpoint is accessible with the `user:email` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersListEmailsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List email addresses for the authenticated user
                List&lt;Email&gt; result = apiInstance.UsersListEmailsForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersListEmailsForAuthenticatedUser: " + e.Message );
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

[**List<Email>**](Email.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userslistfollowedbyauthenticateduser"></a>
# **UsersListFollowedByAuthenticatedUser**
> List<SimpleUser1> UsersListFollowedByAuthenticatedUser (int? perPage, int? page)

List the people the authenticated user follows

Lists the people who the authenticated user follows.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersListFollowedByAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List the people the authenticated user follows
                List&lt;SimpleUser1&gt; result = apiInstance.UsersListFollowedByAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersListFollowedByAuthenticatedUser: " + e.Message );
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

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userslistfollowersforauthenticateduser"></a>
# **UsersListFollowersForAuthenticatedUser**
> List<SimpleUser1> UsersListFollowersForAuthenticatedUser (int? perPage, int? page)

List followers of the authenticated user

Lists the people following the authenticated user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersListFollowersForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List followers of the authenticated user
                List&lt;SimpleUser1&gt; result = apiInstance.UsersListFollowersForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersListFollowersForAuthenticatedUser: " + e.Message );
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

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userslistfollowersforuser"></a>
# **UsersListFollowersForUser**
> List<SimpleUser1> UsersListFollowersForUser (string username, int? perPage, int? page)

List followers of a user

Lists the people following the specified user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersListFollowersForUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List followers of a user
                List&lt;SimpleUser1&gt; result = apiInstance.UsersListFollowersForUser(username, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersListFollowersForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userslistfollowingforuser"></a>
# **UsersListFollowingForUser**
> List<SimpleUser1> UsersListFollowingForUser (string username, int? perPage, int? page)

List the people a user follows

Lists the people who the specified user follows.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersListFollowingForUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List the people a user follows
                List&lt;SimpleUser1&gt; result = apiInstance.UsersListFollowingForUser(username, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersListFollowingForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userslistgpgkeysforauthenticateduser"></a>
# **UsersListGpgKeysForAuthenticatedUser**
> List<GPGKey> UsersListGpgKeysForAuthenticatedUser (int? perPage, int? page)

List GPG keys for the authenticated user

Lists the current user's GPG keys. Requires that you are authenticated via Basic Auth or via OAuth with at least `read:gpg_key` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersListGpgKeysForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List GPG keys for the authenticated user
                List&lt;GPGKey&gt; result = apiInstance.UsersListGpgKeysForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersListGpgKeysForAuthenticatedUser: " + e.Message );
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

[**List<GPGKey>**](GPGKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userslistgpgkeysforuser"></a>
# **UsersListGpgKeysForUser**
> List<GPGKey> UsersListGpgKeysForUser (string username, int? perPage, int? page)

List GPG keys for a user

Lists the GPG keys for a user. This information is accessible by anyone.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersListGpgKeysForUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List GPG keys for a user
                List&lt;GPGKey&gt; result = apiInstance.UsersListGpgKeysForUser(username, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersListGpgKeysForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<GPGKey>**](GPGKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userslistpublicemailsforauthenticateduser"></a>
# **UsersListPublicEmailsForAuthenticatedUser**
> List<Email> UsersListPublicEmailsForAuthenticatedUser (int? perPage, int? page)

List public email addresses for the authenticated user

Lists your publicly visible email address, which you can set with the [Set primary email visibility for the authenticated user](https://docs.github.com/rest/reference/users#set-primary-email-visibility-for-the-authenticated-user) endpoint. This endpoint is accessible with the `user:email` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersListPublicEmailsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List public email addresses for the authenticated user
                List&lt;Email&gt; result = apiInstance.UsersListPublicEmailsForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersListPublicEmailsForAuthenticatedUser: " + e.Message );
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

[**List<Email>**](Email.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userslistpublickeysforuser"></a>
# **UsersListPublicKeysForUser**
> List<KeySimple> UsersListPublicKeysForUser (string username, int? perPage, int? page)

List public keys for a user

Lists the _verified_ public SSH keys for a user. This is accessible by anyone.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersListPublicKeysForUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List public keys for a user
                List&lt;KeySimple&gt; result = apiInstance.UsersListPublicKeysForUser(username, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersListPublicKeysForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<KeySimple>**](KeySimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userslistpublicsshkeysforauthenticateduser"></a>
# **UsersListPublicSshKeysForAuthenticatedUser**
> List<Key> UsersListPublicSshKeysForAuthenticatedUser (int? perPage, int? page)

List public SSH keys for the authenticated user

Lists the public SSH keys for the authenticated user's GitHub account. Requires that you are authenticated via Basic Auth or via OAuth with at least `read:public_key` [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersListPublicSshKeysForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List public SSH keys for the authenticated user
                List&lt;Key&gt; result = apiInstance.UsersListPublicSshKeysForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersListPublicSshKeysForAuthenticatedUser: " + e.Message );
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

[**List<Key>**](Key.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userssetprimaryemailvisibilityforauthenticateduser"></a>
# **UsersSetPrimaryEmailVisibilityForAuthenticatedUser**
> List<Email> UsersSetPrimaryEmailVisibilityForAuthenticatedUser (UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest)

Set primary email visibility for the authenticated user

Sets the visibility for your primary email addresses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersSetPrimaryEmailVisibilityForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest = new UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest(); // UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest | 

            try
            {
                // Set primary email visibility for the authenticated user
                List&lt;Email&gt; result = apiInstance.UsersSetPrimaryEmailVisibilityForAuthenticatedUser(usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersSetPrimaryEmailVisibilityForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest** | [**UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest**](UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest.md)|  | 

### Return type

[**List<Email>**](Email.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersunblock"></a>
# **UsersUnblock**
> void UsersUnblock (string username)

Unblock a user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersUnblockExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Unblock a user
                apiInstance.UsersUnblock(username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUnblock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersunfollow"></a>
# **UsersUnfollow**
> void UsersUnfollow (string username)

Unfollow a user

Unfollowing a user requires the user to be logged in and authenticated with basic auth or OAuth with the `user:follow` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersUnfollowExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Unfollow a user
                apiInstance.UsersUnfollow(username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUnfollow: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersupdateauthenticated"></a>
# **UsersUpdateAuthenticated**
> PrivateUser UsersUpdateAuthenticated (UsersUpdateAuthenticatedRequest usersUpdateAuthenticatedRequest)

Update the authenticated user

**Note:** If your email is set to private and you send an `email` parameter as part of this request to update your profile, your privacy settings are still enforced: the email address will not be displayed on your public profile or via the API.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersUpdateAuthenticatedExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var usersUpdateAuthenticatedRequest = new UsersUpdateAuthenticatedRequest(); // UsersUpdateAuthenticatedRequest |  (optional) 

            try
            {
                // Update the authenticated user
                PrivateUser result = apiInstance.UsersUpdateAuthenticated(usersUpdateAuthenticatedRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUpdateAuthenticated: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **usersUpdateAuthenticatedRequest** | [**UsersUpdateAuthenticatedRequest**](UsersUpdateAuthenticatedRequest.md)|  | [optional] 

### Return type

[**PrivateUser**](PrivateUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

