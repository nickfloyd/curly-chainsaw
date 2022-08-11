# Org.OpenAPITools.Api.InteractionsApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InteractionsGetRestrictionsForAuthenticatedUser**](InteractionsApi.md#interactionsgetrestrictionsforauthenticateduser) | **GET** /user/interaction-limits | Get interaction restrictions for your public repositories
[**InteractionsGetRestrictionsForOrg**](InteractionsApi.md#interactionsgetrestrictionsfororg) | **GET** /orgs/{org}/interaction-limits | Get interaction restrictions for an organization
[**InteractionsGetRestrictionsForRepo**](InteractionsApi.md#interactionsgetrestrictionsforrepo) | **GET** /repos/{owner}/{repo}/interaction-limits | Get interaction restrictions for a repository
[**InteractionsRemoveRestrictionsForAuthenticatedUser**](InteractionsApi.md#interactionsremoverestrictionsforauthenticateduser) | **DELETE** /user/interaction-limits | Remove interaction restrictions from your public repositories
[**InteractionsRemoveRestrictionsForOrg**](InteractionsApi.md#interactionsremoverestrictionsfororg) | **DELETE** /orgs/{org}/interaction-limits | Remove interaction restrictions for an organization
[**InteractionsRemoveRestrictionsForRepo**](InteractionsApi.md#interactionsremoverestrictionsforrepo) | **DELETE** /repos/{owner}/{repo}/interaction-limits | Remove interaction restrictions for a repository
[**InteractionsSetRestrictionsForAuthenticatedUser**](InteractionsApi.md#interactionssetrestrictionsforauthenticateduser) | **PUT** /user/interaction-limits | Set interaction restrictions for your public repositories
[**InteractionsSetRestrictionsForOrg**](InteractionsApi.md#interactionssetrestrictionsfororg) | **PUT** /orgs/{org}/interaction-limits | Set interaction restrictions for an organization
[**InteractionsSetRestrictionsForRepo**](InteractionsApi.md#interactionssetrestrictionsforrepo) | **PUT** /repos/{owner}/{repo}/interaction-limits | Set interaction restrictions for a repository


<a name="interactionsgetrestrictionsforauthenticateduser"></a>
# **InteractionsGetRestrictionsForAuthenticatedUser**
> InteractionsGetRestrictionsForOrg200Response InteractionsGetRestrictionsForAuthenticatedUser ()

Get interaction restrictions for your public repositories

Shows which type of GitHub user can interact with your public repositories and when the restriction expires.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionsGetRestrictionsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new InteractionsApi();

            try
            {
                // Get interaction restrictions for your public repositories
                InteractionsGetRestrictionsForOrg200Response result = apiInstance.InteractionsGetRestrictionsForAuthenticatedUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionsApi.InteractionsGetRestrictionsForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InteractionsGetRestrictionsForOrg200Response**](InteractionsGetRestrictionsForOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionsgetrestrictionsfororg"></a>
# **InteractionsGetRestrictionsForOrg**
> InteractionsGetRestrictionsForOrg200Response InteractionsGetRestrictionsForOrg (string org)

Get interaction restrictions for an organization

Shows which type of GitHub user can interact with this organization and when the restriction expires. If there is no restrictions, you will see an empty response.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionsGetRestrictionsForOrgExample
    {
        public void main()
        {
            var apiInstance = new InteractionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get interaction restrictions for an organization
                InteractionsGetRestrictionsForOrg200Response result = apiInstance.InteractionsGetRestrictionsForOrg(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionsApi.InteractionsGetRestrictionsForOrg: " + e.Message );
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

[**InteractionsGetRestrictionsForOrg200Response**](InteractionsGetRestrictionsForOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionsgetrestrictionsforrepo"></a>
# **InteractionsGetRestrictionsForRepo**
> InteractionsGetRestrictionsForOrg200Response InteractionsGetRestrictionsForRepo (string owner, string repo)

Get interaction restrictions for a repository

Shows which type of GitHub user can interact with this repository and when the restriction expires. If there are no restrictions, you will see an empty response.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionsGetRestrictionsForRepoExample
    {
        public void main()
        {
            var apiInstance = new InteractionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get interaction restrictions for a repository
                InteractionsGetRestrictionsForOrg200Response result = apiInstance.InteractionsGetRestrictionsForRepo(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionsApi.InteractionsGetRestrictionsForRepo: " + e.Message );
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

[**InteractionsGetRestrictionsForOrg200Response**](InteractionsGetRestrictionsForOrg200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionsremoverestrictionsforauthenticateduser"></a>
# **InteractionsRemoveRestrictionsForAuthenticatedUser**
> void InteractionsRemoveRestrictionsForAuthenticatedUser ()

Remove interaction restrictions from your public repositories

Removes any interaction restrictions from your public repositories.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionsRemoveRestrictionsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new InteractionsApi();

            try
            {
                // Remove interaction restrictions from your public repositories
                apiInstance.InteractionsRemoveRestrictionsForAuthenticatedUser();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionsApi.InteractionsRemoveRestrictionsForAuthenticatedUser: " + e.Message );
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

<a name="interactionsremoverestrictionsfororg"></a>
# **InteractionsRemoveRestrictionsForOrg**
> void InteractionsRemoveRestrictionsForOrg (string org)

Remove interaction restrictions for an organization

Removes all interaction restrictions from public repositories in the given organization. You must be an organization owner to remove restrictions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionsRemoveRestrictionsForOrgExample
    {
        public void main()
        {
            var apiInstance = new InteractionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Remove interaction restrictions for an organization
                apiInstance.InteractionsRemoveRestrictionsForOrg(org);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionsApi.InteractionsRemoveRestrictionsForOrg: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionsremoverestrictionsforrepo"></a>
# **InteractionsRemoveRestrictionsForRepo**
> void InteractionsRemoveRestrictionsForRepo (string owner, string repo)

Remove interaction restrictions for a repository

Removes all interaction restrictions from the given repository. You must have owner or admin access to remove restrictions. If the interaction limit is set for the user or organization that owns this repository, you will receive a `409 Conflict` response and will not be able to use this endpoint to change the interaction limit for a single repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionsRemoveRestrictionsForRepoExample
    {
        public void main()
        {
            var apiInstance = new InteractionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Remove interaction restrictions for a repository
                apiInstance.InteractionsRemoveRestrictionsForRepo(owner, repo);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionsApi.InteractionsRemoveRestrictionsForRepo: " + e.Message );
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionssetrestrictionsforauthenticateduser"></a>
# **InteractionsSetRestrictionsForAuthenticatedUser**
> InteractionLimits InteractionsSetRestrictionsForAuthenticatedUser (InteractionRestrictions interactionRestrictions)

Set interaction restrictions for your public repositories

Temporarily restricts which type of GitHub user can interact with your public repositories. Setting the interaction limit at the user level will overwrite any interaction limits that are set for individual repositories owned by the user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionsSetRestrictionsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new InteractionsApi();
            var interactionRestrictions = new InteractionRestrictions(); // InteractionRestrictions | 

            try
            {
                // Set interaction restrictions for your public repositories
                InteractionLimits result = apiInstance.InteractionsSetRestrictionsForAuthenticatedUser(interactionRestrictions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionsApi.InteractionsSetRestrictionsForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionRestrictions** | [**InteractionRestrictions**](InteractionRestrictions.md)|  | 

### Return type

[**InteractionLimits**](InteractionLimits.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionssetrestrictionsfororg"></a>
# **InteractionsSetRestrictionsForOrg**
> InteractionLimits InteractionsSetRestrictionsForOrg (string org, InteractionRestrictions interactionRestrictions)

Set interaction restrictions for an organization

Temporarily restricts interactions to a certain type of GitHub user in any public repository in the given organization. You must be an organization owner to set these restrictions. Setting the interaction limit at the organization level will overwrite any interaction limits that are set for individual repositories owned by the organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionsSetRestrictionsForOrgExample
    {
        public void main()
        {
            var apiInstance = new InteractionsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var interactionRestrictions = new InteractionRestrictions(); // InteractionRestrictions | 

            try
            {
                // Set interaction restrictions for an organization
                InteractionLimits result = apiInstance.InteractionsSetRestrictionsForOrg(org, interactionRestrictions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionsApi.InteractionsSetRestrictionsForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **interactionRestrictions** | [**InteractionRestrictions**](InteractionRestrictions.md)|  | 

### Return type

[**InteractionLimits**](InteractionLimits.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionssetrestrictionsforrepo"></a>
# **InteractionsSetRestrictionsForRepo**
> InteractionLimits InteractionsSetRestrictionsForRepo (string owner, string repo, InteractionRestrictions interactionRestrictions)

Set interaction restrictions for a repository

Temporarily restricts interactions to a certain type of GitHub user within the given repository. You must have owner or admin access to set these restrictions. If an interaction limit is set for the user or organization that owns this repository, you will receive a `409 Conflict` response and will not be able to use this endpoint to change the interaction limit for a single repository.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionsSetRestrictionsForRepoExample
    {
        public void main()
        {
            var apiInstance = new InteractionsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var interactionRestrictions = new InteractionRestrictions(); // InteractionRestrictions | 

            try
            {
                // Set interaction restrictions for a repository
                InteractionLimits result = apiInstance.InteractionsSetRestrictionsForRepo(owner, repo, interactionRestrictions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionsApi.InteractionsSetRestrictionsForRepo: " + e.Message );
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
 **interactionRestrictions** | [**InteractionRestrictions**](InteractionRestrictions.md)|  | 

### Return type

[**InteractionLimits**](InteractionLimits.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

