# Org.OpenAPITools.Api.AppsApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AppsAddRepoToInstallationForAuthenticatedUser**](AppsApi.md#appsaddrepotoinstallationforauthenticateduser) | **PUT** /user/installations/{installation_id}/repositories/{repository_id} | Add a repository to an app installation
[**AppsCheckToken**](AppsApi.md#appschecktoken) | **POST** /applications/{client_id}/token | Check a token
[**AppsCreateFromManifest**](AppsApi.md#appscreatefrommanifest) | **POST** /app-manifests/{code}/conversions | Create a GitHub App from a manifest
[**AppsCreateInstallationAccessToken**](AppsApi.md#appscreateinstallationaccesstoken) | **POST** /app/installations/{installation_id}/access_tokens | Create an installation access token for an app
[**AppsDeleteAuthorization**](AppsApi.md#appsdeleteauthorization) | **DELETE** /applications/{client_id}/grant | Delete an app authorization
[**AppsDeleteInstallation**](AppsApi.md#appsdeleteinstallation) | **DELETE** /app/installations/{installation_id} | Delete an installation for the authenticated app
[**AppsDeleteToken**](AppsApi.md#appsdeletetoken) | **DELETE** /applications/{client_id}/token | Delete an app token
[**AppsGetAuthenticated**](AppsApi.md#appsgetauthenticated) | **GET** /app | Get the authenticated app
[**AppsGetBySlug**](AppsApi.md#appsgetbyslug) | **GET** /apps/{app_slug} | Get an app
[**AppsGetInstallation**](AppsApi.md#appsgetinstallation) | **GET** /app/installations/{installation_id} | Get an installation for the authenticated app
[**AppsGetOrgInstallation**](AppsApi.md#appsgetorginstallation) | **GET** /orgs/{org}/installation | Get an organization installation for the authenticated app
[**AppsGetRepoInstallation**](AppsApi.md#appsgetrepoinstallation) | **GET** /repos/{owner}/{repo}/installation | Get a repository installation for the authenticated app
[**AppsGetSubscriptionPlanForAccount**](AppsApi.md#appsgetsubscriptionplanforaccount) | **GET** /marketplace_listing/accounts/{account_id} | Get a subscription plan for an account
[**AppsGetSubscriptionPlanForAccountStubbed**](AppsApi.md#appsgetsubscriptionplanforaccountstubbed) | **GET** /marketplace_listing/stubbed/accounts/{account_id} | Get a subscription plan for an account (stubbed)
[**AppsGetUserInstallation**](AppsApi.md#appsgetuserinstallation) | **GET** /users/{username}/installation | Get a user installation for the authenticated app
[**AppsGetWebhookConfigForApp**](AppsApi.md#appsgetwebhookconfigforapp) | **GET** /app/hook/config | Get a webhook configuration for an app
[**AppsGetWebhookDelivery**](AppsApi.md#appsgetwebhookdelivery) | **GET** /app/hook/deliveries/{delivery_id} | Get a delivery for an app webhook
[**AppsListAccountsForPlan**](AppsApi.md#appslistaccountsforplan) | **GET** /marketplace_listing/plans/{plan_id}/accounts | List accounts for a plan
[**AppsListAccountsForPlanStubbed**](AppsApi.md#appslistaccountsforplanstubbed) | **GET** /marketplace_listing/stubbed/plans/{plan_id}/accounts | List accounts for a plan (stubbed)
[**AppsListInstallationReposForAuthenticatedUser**](AppsApi.md#appslistinstallationreposforauthenticateduser) | **GET** /user/installations/{installation_id}/repositories | List repositories accessible to the user access token
[**AppsListInstallations**](AppsApi.md#appslistinstallations) | **GET** /app/installations | List installations for the authenticated app
[**AppsListInstallationsForAuthenticatedUser**](AppsApi.md#appslistinstallationsforauthenticateduser) | **GET** /user/installations | List app installations accessible to the user access token
[**AppsListPlans**](AppsApi.md#appslistplans) | **GET** /marketplace_listing/plans | List plans
[**AppsListPlansStubbed**](AppsApi.md#appslistplansstubbed) | **GET** /marketplace_listing/stubbed/plans | List plans (stubbed)
[**AppsListReposAccessibleToInstallation**](AppsApi.md#appslistreposaccessibletoinstallation) | **GET** /installation/repositories | List repositories accessible to the app installation
[**AppsListSubscriptionsForAuthenticatedUser**](AppsApi.md#appslistsubscriptionsforauthenticateduser) | **GET** /user/marketplace_purchases | List subscriptions for the authenticated user
[**AppsListSubscriptionsForAuthenticatedUserStubbed**](AppsApi.md#appslistsubscriptionsforauthenticateduserstubbed) | **GET** /user/marketplace_purchases/stubbed | List subscriptions for the authenticated user (stubbed)
[**AppsListWebhookDeliveries**](AppsApi.md#appslistwebhookdeliveries) | **GET** /app/hook/deliveries | List deliveries for an app webhook
[**AppsRedeliverWebhookDelivery**](AppsApi.md#appsredeliverwebhookdelivery) | **POST** /app/hook/deliveries/{delivery_id}/attempts | Redeliver a delivery for an app webhook
[**AppsRemoveRepoFromInstallationForAuthenticatedUser**](AppsApi.md#appsremoverepofrominstallationforauthenticateduser) | **DELETE** /user/installations/{installation_id}/repositories/{repository_id} | Remove a repository from an app installation
[**AppsResetToken**](AppsApi.md#appsresettoken) | **PATCH** /applications/{client_id}/token | Reset a token
[**AppsRevokeInstallationAccessToken**](AppsApi.md#appsrevokeinstallationaccesstoken) | **DELETE** /installation/token | Revoke an installation access token
[**AppsScopeToken**](AppsApi.md#appsscopetoken) | **POST** /applications/{client_id}/token/scoped | Create a scoped access token
[**AppsSuspendInstallation**](AppsApi.md#appssuspendinstallation) | **PUT** /app/installations/{installation_id}/suspended | Suspend an app installation
[**AppsUnsuspendInstallation**](AppsApi.md#appsunsuspendinstallation) | **DELETE** /app/installations/{installation_id}/suspended | Unsuspend an app installation
[**AppsUpdateWebhookConfigForApp**](AppsApi.md#appsupdatewebhookconfigforapp) | **PATCH** /app/hook/config | Update a webhook configuration for an app


<a name="appsaddrepotoinstallationforauthenticateduser"></a>
# **AppsAddRepoToInstallationForAuthenticatedUser**
> void AppsAddRepoToInstallationForAuthenticatedUser (int? installationId, int? repositoryId)

Add a repository to an app installation

Add a single repository to an installation. The authenticated user must have admin access to the repository.  You must use a personal access token (which you can create via the [command line](https://docs.github.com/github/authenticating-to-github/creating-a-personal-access-token) or [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication)) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsAddRepoToInstallationForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var installationId = 1;  // int? | The unique identifier of the installation.
            var repositoryId = 56;  // int? | The unique identifier of the repository.

            try
            {
                // Add a repository to an app installation
                apiInstance.AppsAddRepoToInstallationForAuthenticatedUser(installationId, repositoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsAddRepoToInstallationForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **installationId** | **int?**| The unique identifier of the installation. | 
 **repositoryId** | **int?**| The unique identifier of the repository. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appschecktoken"></a>
# **AppsCheckToken**
> Authorization AppsCheckToken (string clientId, AppsCheckTokenRequest appsCheckTokenRequest)

Check a token

OAuth applications can use a special API method for checking OAuth token validity without exceeding the normal rate limits for failed login attempts. Authentication works differently with this particular endpoint. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) to use this endpoint, where the username is the OAuth application `client_id` and the password is its `client_secret`. Invalid tokens will return `404 NOT FOUND`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsCheckTokenExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var clientId = Iv1.8a61f9b3a7aba766;  // string | The client ID of the GitHub app.
            var appsCheckTokenRequest = new AppsCheckTokenRequest(); // AppsCheckTokenRequest | 

            try
            {
                // Check a token
                Authorization result = apiInstance.AppsCheckToken(clientId, appsCheckTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsCheckToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| The client ID of the GitHub app. | 
 **appsCheckTokenRequest** | [**AppsCheckTokenRequest**](AppsCheckTokenRequest.md)|  | 

### Return type

[**Authorization**](Authorization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appscreatefrommanifest"></a>
# **AppsCreateFromManifest**
> AppsCreateFromManifest201Response AppsCreateFromManifest (string code)

Create a GitHub App from a manifest

Use this endpoint to complete the handshake necessary when implementing the [GitHub App Manifest flow](https://docs.github.com/apps/building-github-apps/creating-github-apps-from-a-manifest/). When you create a GitHub App with the manifest flow, you receive a temporary `code` used to retrieve the GitHub App's `id`, `pem` (private key), and `webhook_secret`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsCreateFromManifestExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var code = "code_example";  // string | 

            try
            {
                // Create a GitHub App from a manifest
                AppsCreateFromManifest201Response result = apiInstance.AppsCreateFromManifest(code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsCreateFromManifest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**|  | 

### Return type

[**AppsCreateFromManifest201Response**](AppsCreateFromManifest201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appscreateinstallationaccesstoken"></a>
# **AppsCreateInstallationAccessToken**
> InstallationToken AppsCreateInstallationAccessToken (int? installationId, AppsCreateInstallationAccessTokenRequest appsCreateInstallationAccessTokenRequest)

Create an installation access token for an app

Creates an installation access token that enables a GitHub App to make authenticated API requests for the app's installation on an organization or individual account. Installation tokens expire one hour from the time you create them. Using an expired token produces a status code of `401 - Unauthorized`, and requires creating a new installation token. By default the installation token has access to all repositories that the installation can access. To restrict the access to specific repositories, you can provide the `repository_ids` when creating the token. When you omit `repository_ids`, the response does not contain the `repositories` key.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsCreateInstallationAccessTokenExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var installationId = 1;  // int? | The unique identifier of the installation.
            var appsCreateInstallationAccessTokenRequest = new AppsCreateInstallationAccessTokenRequest(); // AppsCreateInstallationAccessTokenRequest |  (optional) 

            try
            {
                // Create an installation access token for an app
                InstallationToken result = apiInstance.AppsCreateInstallationAccessToken(installationId, appsCreateInstallationAccessTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsCreateInstallationAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **installationId** | **int?**| The unique identifier of the installation. | 
 **appsCreateInstallationAccessTokenRequest** | [**AppsCreateInstallationAccessTokenRequest**](AppsCreateInstallationAccessTokenRequest.md)|  | [optional] 

### Return type

[**InstallationToken**](InstallationToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsdeleteauthorization"></a>
# **AppsDeleteAuthorization**
> void AppsDeleteAuthorization (string clientId, AppsDeleteAuthorizationRequest appsDeleteAuthorizationRequest)

Delete an app authorization

OAuth application owners can revoke a grant for their OAuth application and a specific user. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application's `client_id` and `client_secret` as the username and password. You must also provide a valid OAuth `access_token` as an input parameter and the grant for the token's owner will be deleted. Deleting an OAuth application's grant will also delete all OAuth tokens associated with the application for the user. Once deleted, the application will have no access to the user's account and will no longer be listed on [the application authorizations settings screen within GitHub](https://github.com/settings/applications#authorized).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsDeleteAuthorizationExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var clientId = Iv1.8a61f9b3a7aba766;  // string | The client ID of the GitHub app.
            var appsDeleteAuthorizationRequest = new AppsDeleteAuthorizationRequest(); // AppsDeleteAuthorizationRequest | 

            try
            {
                // Delete an app authorization
                apiInstance.AppsDeleteAuthorization(clientId, appsDeleteAuthorizationRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsDeleteAuthorization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| The client ID of the GitHub app. | 
 **appsDeleteAuthorizationRequest** | [**AppsDeleteAuthorizationRequest**](AppsDeleteAuthorizationRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsdeleteinstallation"></a>
# **AppsDeleteInstallation**
> void AppsDeleteInstallation (int? installationId)

Delete an installation for the authenticated app

Uninstalls a GitHub App on a user, organization, or business account. If you prefer to temporarily suspend an app's access to your account's resources, then we recommend the \"[Suspend an app installation](https://docs.github.com/rest/reference/apps/#suspend-an-app-installation)\" endpoint.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsDeleteInstallationExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var installationId = 1;  // int? | The unique identifier of the installation.

            try
            {
                // Delete an installation for the authenticated app
                apiInstance.AppsDeleteInstallation(installationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsDeleteInstallation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **installationId** | **int?**| The unique identifier of the installation. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsdeletetoken"></a>
# **AppsDeleteToken**
> void AppsDeleteToken (string clientId, AppsDeleteAuthorizationRequest appsDeleteAuthorizationRequest)

Delete an app token

OAuth application owners can revoke a single token for an OAuth application. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application's `client_id` and `client_secret` as the username and password.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsDeleteTokenExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var clientId = Iv1.8a61f9b3a7aba766;  // string | The client ID of the GitHub app.
            var appsDeleteAuthorizationRequest = new AppsDeleteAuthorizationRequest(); // AppsDeleteAuthorizationRequest | 

            try
            {
                // Delete an app token
                apiInstance.AppsDeleteToken(clientId, appsDeleteAuthorizationRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsDeleteToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| The client ID of the GitHub app. | 
 **appsDeleteAuthorizationRequest** | [**AppsDeleteAuthorizationRequest**](AppsDeleteAuthorizationRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetauthenticated"></a>
# **AppsGetAuthenticated**
> GitHubApp AppsGetAuthenticated ()

Get the authenticated app

Returns the GitHub App associated with the authentication credentials used. To see how many app installations are associated with this GitHub App, see the `installations_count` in the response. For more details about your app's installations, see the \"[List installations for the authenticated app](https://docs.github.com/rest/reference/apps#list-installations-for-the-authenticated-app)\" endpoint.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsGetAuthenticatedExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();

            try
            {
                // Get the authenticated app
                GitHubApp result = apiInstance.AppsGetAuthenticated();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetAuthenticated: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GitHubApp**](GitHubApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetbyslug"></a>
# **AppsGetBySlug**
> GitHubApp AppsGetBySlug (string appSlug)

Get an app

**Note**: The `:app_slug` is just the URL-friendly name of your GitHub App. You can find this on the settings page for your GitHub App (e.g., `https://github.com/settings/apps/:app_slug`).  If the GitHub App you specify is public, you can access this endpoint without authenticating. If the GitHub App you specify is private, you must authenticate with a [personal access token](https://docs.github.com/articles/creating-a-personal-access-token-for-the-command-line/) or an [installation access token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-an-installation) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsGetBySlugExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var appSlug = "appSlug_example";  // string | 

            try
            {
                // Get an app
                GitHubApp result = apiInstance.AppsGetBySlug(appSlug);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetBySlug: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appSlug** | **string**|  | 

### Return type

[**GitHubApp**](GitHubApp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetinstallation"></a>
# **AppsGetInstallation**
> Installation AppsGetInstallation (int? installationId)

Get an installation for the authenticated app

Enables an authenticated GitHub App to find an installation's information using the installation id.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsGetInstallationExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var installationId = 1;  // int? | The unique identifier of the installation.

            try
            {
                // Get an installation for the authenticated app
                Installation result = apiInstance.AppsGetInstallation(installationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetInstallation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **installationId** | **int?**| The unique identifier of the installation. | 

### Return type

[**Installation**](Installation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetorginstallation"></a>
# **AppsGetOrgInstallation**
> Installation AppsGetOrgInstallation (string org)

Get an organization installation for the authenticated app

Enables an authenticated GitHub App to find the organization's installation information.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsGetOrgInstallationExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get an organization installation for the authenticated app
                Installation result = apiInstance.AppsGetOrgInstallation(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetOrgInstallation: " + e.Message );
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

[**Installation**](Installation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetrepoinstallation"></a>
# **AppsGetRepoInstallation**
> Installation AppsGetRepoInstallation (string owner, string repo)

Get a repository installation for the authenticated app

Enables an authenticated GitHub App to find the repository's installation information. The installation's account type will be either an organization or a user account, depending which account the repository belongs to.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsGetRepoInstallationExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get a repository installation for the authenticated app
                Installation result = apiInstance.AppsGetRepoInstallation(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetRepoInstallation: " + e.Message );
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

[**Installation**](Installation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetsubscriptionplanforaccount"></a>
# **AppsGetSubscriptionPlanForAccount**
> MarketplacePurchase AppsGetSubscriptionPlanForAccount (int? accountId)

Get a subscription plan for an account

Shows whether the user or organization account actively subscribes to a plan listed by the authenticated GitHub App. When someone submits a plan change that won't be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsGetSubscriptionPlanForAccountExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var accountId = 56;  // int? | account_id parameter

            try
            {
                // Get a subscription plan for an account
                MarketplacePurchase result = apiInstance.AppsGetSubscriptionPlanForAccount(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetSubscriptionPlanForAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| account_id parameter | 

### Return type

[**MarketplacePurchase**](MarketplacePurchase.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetsubscriptionplanforaccountstubbed"></a>
# **AppsGetSubscriptionPlanForAccountStubbed**
> MarketplacePurchase AppsGetSubscriptionPlanForAccountStubbed (int? accountId)

Get a subscription plan for an account (stubbed)

Shows whether the user or organization account actively subscribes to a plan listed by the authenticated GitHub App. When someone submits a plan change that won't be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsGetSubscriptionPlanForAccountStubbedExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var accountId = 56;  // int? | account_id parameter

            try
            {
                // Get a subscription plan for an account (stubbed)
                MarketplacePurchase result = apiInstance.AppsGetSubscriptionPlanForAccountStubbed(accountId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetSubscriptionPlanForAccountStubbed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **int?**| account_id parameter | 

### Return type

[**MarketplacePurchase**](MarketplacePurchase.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetuserinstallation"></a>
# **AppsGetUserInstallation**
> Installation AppsGetUserInstallation (string username)

Get a user installation for the authenticated app

Enables an authenticated GitHub App to find the user’s installation information.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsGetUserInstallationExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get a user installation for the authenticated app
                Installation result = apiInstance.AppsGetUserInstallation(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetUserInstallation: " + e.Message );
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

[**Installation**](Installation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetwebhookconfigforapp"></a>
# **AppsGetWebhookConfigForApp**
> WebhookConfiguration AppsGetWebhookConfigForApp ()

Get a webhook configuration for an app

Returns the webhook configuration for a GitHub App. For more information about configuring a webhook for your app, see \"[Creating a GitHub App](/developers/apps/creating-a-github-app).\"  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsGetWebhookConfigForAppExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();

            try
            {
                // Get a webhook configuration for an app
                WebhookConfiguration result = apiInstance.AppsGetWebhookConfigForApp();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetWebhookConfigForApp: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**WebhookConfiguration**](WebhookConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsgetwebhookdelivery"></a>
# **AppsGetWebhookDelivery**
> WebhookDelivery AppsGetWebhookDelivery (int? deliveryId)

Get a delivery for an app webhook

Returns a delivery for the webhook configured for a GitHub App.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsGetWebhookDeliveryExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var deliveryId = 56;  // int? | 

            try
            {
                // Get a delivery for an app webhook
                WebhookDelivery result = apiInstance.AppsGetWebhookDelivery(deliveryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsGetWebhookDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deliveryId** | **int?**|  | 

### Return type

[**WebhookDelivery**](WebhookDelivery.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appslistaccountsforplan"></a>
# **AppsListAccountsForPlan**
> List<MarketplacePurchase> AppsListAccountsForPlan (int? planId, string sort, string direction, int? perPage, int? page)

List accounts for a plan

Returns user and organization accounts associated with the specified plan, including free plans. For per-seat pricing, you see the list of accounts that have purchased the plan, including the number of seats purchased. When someone submits a plan change that won't be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsListAccountsForPlanExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var planId = 56;  // int? | The unique identifier of the plan.
            var sort = "created";  // string | The property to sort the results by. `created` means when the repository was starred. `updated` means when the repository was last pushed to. (optional)  (default to created)
            var direction = "asc";  // string | To return the oldest accounts first, set to `asc`. Ignored without the `sort` parameter. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List accounts for a plan
                List&lt;MarketplacePurchase&gt; result = apiInstance.AppsListAccountsForPlan(planId, sort, direction, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsListAccountsForPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **planId** | **int?**| The unique identifier of the plan. | 
 **sort** | **string**| The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to. | [optional] [default to created]
 **direction** | **string**| To return the oldest accounts first, set to &#x60;asc&#x60;. Ignored without the &#x60;sort&#x60; parameter. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<MarketplacePurchase>**](MarketplacePurchase.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appslistaccountsforplanstubbed"></a>
# **AppsListAccountsForPlanStubbed**
> List<MarketplacePurchase> AppsListAccountsForPlanStubbed (int? planId, string sort, string direction, int? perPage, int? page)

List accounts for a plan (stubbed)

Returns repository and organization accounts associated with the specified plan, including free plans. For per-seat pricing, you see the list of accounts that have purchased the plan, including the number of seats purchased. When someone submits a plan change that won't be processed until the end of their billing cycle, you will also see the upcoming pending change.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsListAccountsForPlanStubbedExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var planId = 56;  // int? | The unique identifier of the plan.
            var sort = "created";  // string | The property to sort the results by. `created` means when the repository was starred. `updated` means when the repository was last pushed to. (optional)  (default to created)
            var direction = "asc";  // string | To return the oldest accounts first, set to `asc`. Ignored without the `sort` parameter. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List accounts for a plan (stubbed)
                List&lt;MarketplacePurchase&gt; result = apiInstance.AppsListAccountsForPlanStubbed(planId, sort, direction, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsListAccountsForPlanStubbed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **planId** | **int?**| The unique identifier of the plan. | 
 **sort** | **string**| The property to sort the results by. &#x60;created&#x60; means when the repository was starred. &#x60;updated&#x60; means when the repository was last pushed to. | [optional] [default to created]
 **direction** | **string**| To return the oldest accounts first, set to &#x60;asc&#x60;. Ignored without the &#x60;sort&#x60; parameter. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<MarketplacePurchase>**](MarketplacePurchase.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appslistinstallationreposforauthenticateduser"></a>
# **AppsListInstallationReposForAuthenticatedUser**
> AppsListInstallationReposForAuthenticatedUser200Response AppsListInstallationReposForAuthenticatedUser (int? installationId, int? perPage, int? page)

List repositories accessible to the user access token

List repositories that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access for an installation.  The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.  You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint.  The access the user has to each repository is included in the hash under the `permissions` key.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsListInstallationReposForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var installationId = 1;  // int? | The unique identifier of the installation.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repositories accessible to the user access token
                AppsListInstallationReposForAuthenticatedUser200Response result = apiInstance.AppsListInstallationReposForAuthenticatedUser(installationId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsListInstallationReposForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **installationId** | **int?**| The unique identifier of the installation. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**AppsListInstallationReposForAuthenticatedUser200Response**](AppsListInstallationReposForAuthenticatedUser200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appslistinstallations"></a>
# **AppsListInstallations**
> List<Installation> AppsListInstallations (int? perPage, int? page, DateTime? since, string outdated)

List installations for the authenticated app

You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.  The permissions the installation has are included under the `permissions` key.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsListInstallationsExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var outdated = "outdated_example";  // string |  (optional) 

            try
            {
                // List installations for the authenticated app
                List&lt;Installation&gt; result = apiInstance.AppsListInstallations(perPage, page, since, outdated);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsListInstallations: " + e.Message );
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
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **outdated** | **string**|  | [optional] 

### Return type

[**List<Installation>**](Installation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appslistinstallationsforauthenticateduser"></a>
# **AppsListInstallationsForAuthenticatedUser**
> OrgsListAppInstallations200Response AppsListInstallationsForAuthenticatedUser (int? perPage, int? page)

List app installations accessible to the user access token

Lists installations of your GitHub App that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access.  You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint.  The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.  You can find the permissions for the installation under the `permissions` key.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsListInstallationsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List app installations accessible to the user access token
                OrgsListAppInstallations200Response result = apiInstance.AppsListInstallationsForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsListInstallationsForAuthenticatedUser: " + e.Message );
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

[**OrgsListAppInstallations200Response**](OrgsListAppInstallations200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appslistplans"></a>
# **AppsListPlans**
> List<MarketplaceListingPlan> AppsListPlans (int? perPage, int? page)

List plans

Lists all plans that are part of your GitHub Marketplace listing.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsListPlansExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List plans
                List&lt;MarketplaceListingPlan&gt; result = apiInstance.AppsListPlans(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsListPlans: " + e.Message );
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

[**List<MarketplaceListingPlan>**](MarketplaceListingPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appslistplansstubbed"></a>
# **AppsListPlansStubbed**
> List<MarketplaceListingPlan> AppsListPlansStubbed (int? perPage, int? page)

List plans (stubbed)

Lists all plans that are part of your GitHub Marketplace listing.  GitHub Apps must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint. OAuth Apps must use [basic authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) with their client ID and client secret to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsListPlansStubbedExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List plans (stubbed)
                List&lt;MarketplaceListingPlan&gt; result = apiInstance.AppsListPlansStubbed(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsListPlansStubbed: " + e.Message );
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

[**List<MarketplaceListingPlan>**](MarketplaceListingPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appslistreposaccessibletoinstallation"></a>
# **AppsListReposAccessibleToInstallation**
> AppsListReposAccessibleToInstallation200Response AppsListReposAccessibleToInstallation (int? perPage, int? page)

List repositories accessible to the app installation

List repositories that an app installation can access.  You must use an [installation access token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-an-installation) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsListReposAccessibleToInstallationExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repositories accessible to the app installation
                AppsListReposAccessibleToInstallation200Response result = apiInstance.AppsListReposAccessibleToInstallation(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsListReposAccessibleToInstallation: " + e.Message );
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

[**AppsListReposAccessibleToInstallation200Response**](AppsListReposAccessibleToInstallation200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appslistsubscriptionsforauthenticateduser"></a>
# **AppsListSubscriptionsForAuthenticatedUser**
> List<UserMarketplacePurchase> AppsListSubscriptionsForAuthenticatedUser (int? perPage, int? page)

List subscriptions for the authenticated user

Lists the active subscriptions for the authenticated user. You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint. . OAuth Apps must authenticate using an [OAuth token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsListSubscriptionsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List subscriptions for the authenticated user
                List&lt;UserMarketplacePurchase&gt; result = apiInstance.AppsListSubscriptionsForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsListSubscriptionsForAuthenticatedUser: " + e.Message );
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

[**List<UserMarketplacePurchase>**](UserMarketplacePurchase.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appslistsubscriptionsforauthenticateduserstubbed"></a>
# **AppsListSubscriptionsForAuthenticatedUserStubbed**
> List<UserMarketplacePurchase> AppsListSubscriptionsForAuthenticatedUserStubbed (int? perPage, int? page)

List subscriptions for the authenticated user (stubbed)

Lists the active subscriptions for the authenticated user. You must use a [user-to-server OAuth access token](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/#identifying-users-on-your-site), created for a user who has authorized your GitHub App, to access this endpoint. . OAuth Apps must authenticate using an [OAuth token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsListSubscriptionsForAuthenticatedUserStubbedExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List subscriptions for the authenticated user (stubbed)
                List&lt;UserMarketplacePurchase&gt; result = apiInstance.AppsListSubscriptionsForAuthenticatedUserStubbed(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsListSubscriptionsForAuthenticatedUserStubbed: " + e.Message );
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

[**List<UserMarketplacePurchase>**](UserMarketplacePurchase.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appslistwebhookdeliveries"></a>
# **AppsListWebhookDeliveries**
> List<SimpleWebhookDelivery> AppsListWebhookDeliveries (int? perPage, string cursor)

List deliveries for an app webhook

Returns a list of webhook deliveries for the webhook configured for a GitHub App.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsListWebhookDeliveriesExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var cursor = "cursor_example";  // string | Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the `link` header for the next and previous page cursors. (optional) 

            try
            {
                // List deliveries for an app webhook
                List&lt;SimpleWebhookDelivery&gt; result = apiInstance.AppsListWebhookDeliveries(perPage, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsListWebhookDeliveries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **cursor** | **string**| Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the &#x60;link&#x60; header for the next and previous page cursors. | [optional] 

### Return type

[**List<SimpleWebhookDelivery>**](SimpleWebhookDelivery.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsredeliverwebhookdelivery"></a>
# **AppsRedeliverWebhookDelivery**
> Object AppsRedeliverWebhookDelivery (int? deliveryId)

Redeliver a delivery for an app webhook

Redeliver a delivery for the webhook configured for a GitHub App.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsRedeliverWebhookDeliveryExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var deliveryId = 56;  // int? | 

            try
            {
                // Redeliver a delivery for an app webhook
                Object result = apiInstance.AppsRedeliverWebhookDelivery(deliveryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsRedeliverWebhookDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deliveryId** | **int?**|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsremoverepofrominstallationforauthenticateduser"></a>
# **AppsRemoveRepoFromInstallationForAuthenticatedUser**
> void AppsRemoveRepoFromInstallationForAuthenticatedUser (int? installationId, int? repositoryId)

Remove a repository from an app installation

Remove a single repository from an installation. The authenticated user must have admin access to the repository.  You must use a personal access token (which you can create via the [command line](https://docs.github.com/github/authenticating-to-github/creating-a-personal-access-token) or [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication)) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsRemoveRepoFromInstallationForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var installationId = 1;  // int? | The unique identifier of the installation.
            var repositoryId = 56;  // int? | The unique identifier of the repository.

            try
            {
                // Remove a repository from an app installation
                apiInstance.AppsRemoveRepoFromInstallationForAuthenticatedUser(installationId, repositoryId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsRemoveRepoFromInstallationForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **installationId** | **int?**| The unique identifier of the installation. | 
 **repositoryId** | **int?**| The unique identifier of the repository. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsresettoken"></a>
# **AppsResetToken**
> Authorization AppsResetToken (string clientId, AppsCheckTokenRequest appsCheckTokenRequest)

Reset a token

OAuth applications can use this API method to reset a valid OAuth token without end-user involvement. Applications must save the \"token\" property in the response because changes take effect immediately. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application's `client_id` and `client_secret` as the username and password. Invalid tokens will return `404 NOT FOUND`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsResetTokenExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var clientId = Iv1.8a61f9b3a7aba766;  // string | The client ID of the GitHub app.
            var appsCheckTokenRequest = new AppsCheckTokenRequest(); // AppsCheckTokenRequest | 

            try
            {
                // Reset a token
                Authorization result = apiInstance.AppsResetToken(clientId, appsCheckTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsResetToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| The client ID of the GitHub app. | 
 **appsCheckTokenRequest** | [**AppsCheckTokenRequest**](AppsCheckTokenRequest.md)|  | 

### Return type

[**Authorization**](Authorization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsrevokeinstallationaccesstoken"></a>
# **AppsRevokeInstallationAccessToken**
> void AppsRevokeInstallationAccessToken ()

Revoke an installation access token

Revokes the installation token you're using to authenticate as an installation and access this endpoint.  Once an installation token is revoked, the token is invalidated and cannot be used. Other endpoints that require the revoked installation token must have a new installation token to work. You can create a new token using the \"[Create an installation access token for an app](https://docs.github.com/rest/reference/apps#create-an-installation-access-token-for-an-app)\" endpoint.  You must use an [installation access token](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-an-installation) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsRevokeInstallationAccessTokenExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();

            try
            {
                // Revoke an installation access token
                apiInstance.AppsRevokeInstallationAccessToken();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsRevokeInstallationAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsscopetoken"></a>
# **AppsScopeToken**
> Authorization AppsScopeToken (string clientId, AppsScopeTokenRequest appsScopeTokenRequest)

Create a scoped access token

Use a non-scoped user-to-server OAuth access token to create a repository scoped and/or permission scoped user-to-server OAuth access token. You can specify which repositories the token can access and which permissions are granted to the token. You must use [Basic Authentication](https://docs.github.com/rest/overview/other-authentication-methods#basic-authentication) when accessing this endpoint, using the OAuth application's `client_id` and `client_secret` as the username and password. Invalid tokens will return `404 NOT FOUND`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsScopeTokenExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var clientId = Iv1.8a61f9b3a7aba766;  // string | The client ID of the GitHub app.
            var appsScopeTokenRequest = new AppsScopeTokenRequest(); // AppsScopeTokenRequest | 

            try
            {
                // Create a scoped access token
                Authorization result = apiInstance.AppsScopeToken(clientId, appsScopeTokenRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsScopeToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**| The client ID of the GitHub app. | 
 **appsScopeTokenRequest** | [**AppsScopeTokenRequest**](AppsScopeTokenRequest.md)|  | 

### Return type

[**Authorization**](Authorization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appssuspendinstallation"></a>
# **AppsSuspendInstallation**
> void AppsSuspendInstallation (int? installationId)

Suspend an app installation

Suspends a GitHub App on a user, organization, or business account, which blocks the app from accessing the account's resources. When a GitHub App is suspended, the app's access to the GitHub API or webhook events is blocked for that account.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsSuspendInstallationExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var installationId = 1;  // int? | The unique identifier of the installation.

            try
            {
                // Suspend an app installation
                apiInstance.AppsSuspendInstallation(installationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsSuspendInstallation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **installationId** | **int?**| The unique identifier of the installation. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsunsuspendinstallation"></a>
# **AppsUnsuspendInstallation**
> void AppsUnsuspendInstallation (int? installationId)

Unsuspend an app installation

Removes a GitHub App installation suspension.  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsUnsuspendInstallationExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var installationId = 1;  // int? | The unique identifier of the installation.

            try
            {
                // Unsuspend an app installation
                apiInstance.AppsUnsuspendInstallation(installationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsUnsuspendInstallation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **installationId** | **int?**| The unique identifier of the installation. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="appsupdatewebhookconfigforapp"></a>
# **AppsUpdateWebhookConfigForApp**
> WebhookConfiguration AppsUpdateWebhookConfigForApp (AppsUpdateWebhookConfigForAppRequest appsUpdateWebhookConfigForAppRequest)

Update a webhook configuration for an app

Updates the webhook configuration for a GitHub App. For more information about configuring a webhook for your app, see \"[Creating a GitHub App](/developers/apps/creating-a-github-app).\"  You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AppsUpdateWebhookConfigForAppExample
    {
        public void main()
        {
            var apiInstance = new AppsApi();
            var appsUpdateWebhookConfigForAppRequest = new AppsUpdateWebhookConfigForAppRequest(); // AppsUpdateWebhookConfigForAppRequest | 

            try
            {
                // Update a webhook configuration for an app
                WebhookConfiguration result = apiInstance.AppsUpdateWebhookConfigForApp(appsUpdateWebhookConfigForAppRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppsApi.AppsUpdateWebhookConfigForApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appsUpdateWebhookConfigForAppRequest** | [**AppsUpdateWebhookConfigForAppRequest**](AppsUpdateWebhookConfigForAppRequest.md)|  | 

### Return type

[**WebhookConfiguration**](WebhookConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

