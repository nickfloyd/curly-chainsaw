# Org.OpenAPITools.Api.BillingApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BillingGetGithubActionsBillingGhe**](BillingApi.md#billinggetgithubactionsbillingghe) | **GET** /enterprises/{enterprise}/settings/billing/actions | Get GitHub Actions billing for an enterprise
[**BillingGetGithubActionsBillingOrg**](BillingApi.md#billinggetgithubactionsbillingorg) | **GET** /orgs/{org}/settings/billing/actions | Get GitHub Actions billing for an organization
[**BillingGetGithubActionsBillingUser**](BillingApi.md#billinggetgithubactionsbillinguser) | **GET** /users/{username}/settings/billing/actions | Get GitHub Actions billing for a user
[**BillingGetGithubAdvancedSecurityBillingGhe**](BillingApi.md#billinggetgithubadvancedsecuritybillingghe) | **GET** /enterprises/{enterprise}/settings/billing/advanced-security | Get GitHub Advanced Security active committers for an enterprise
[**BillingGetGithubAdvancedSecurityBillingOrg**](BillingApi.md#billinggetgithubadvancedsecuritybillingorg) | **GET** /orgs/{org}/settings/billing/advanced-security | Get GitHub Advanced Security active committers for an organization
[**BillingGetGithubPackagesBillingGhe**](BillingApi.md#billinggetgithubpackagesbillingghe) | **GET** /enterprises/{enterprise}/settings/billing/packages | Get GitHub Packages billing for an enterprise
[**BillingGetGithubPackagesBillingOrg**](BillingApi.md#billinggetgithubpackagesbillingorg) | **GET** /orgs/{org}/settings/billing/packages | Get GitHub Packages billing for an organization
[**BillingGetGithubPackagesBillingUser**](BillingApi.md#billinggetgithubpackagesbillinguser) | **GET** /users/{username}/settings/billing/packages | Get GitHub Packages billing for a user
[**BillingGetSharedStorageBillingGhe**](BillingApi.md#billinggetsharedstoragebillingghe) | **GET** /enterprises/{enterprise}/settings/billing/shared-storage | Get shared storage billing for an enterprise
[**BillingGetSharedStorageBillingOrg**](BillingApi.md#billinggetsharedstoragebillingorg) | **GET** /orgs/{org}/settings/billing/shared-storage | Get shared storage billing for an organization
[**BillingGetSharedStorageBillingUser**](BillingApi.md#billinggetsharedstoragebillinguser) | **GET** /users/{username}/settings/billing/shared-storage | Get shared storage billing for a user


<a name="billinggetgithubactionsbillingghe"></a>
# **BillingGetGithubActionsBillingGhe**
> BillingGetGithubActionsBillingGhe200Response BillingGetGithubActionsBillingGhe (string enterprise)

Get GitHub Actions billing for an enterprise

Gets the summary of the free and paid GitHub Actions minutes used.  Paid minutes only apply to workflows in private repositories that use GitHub-hosted runners. Minutes used is listed for each GitHub-hosted runner operating system. Any job re-runs are also included in the usage. The usage does not include the multiplier for macOS and Windows runners and is not rounded up to the nearest whole minute. For more information, see \"[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\".  The authenticated user must be an enterprise admin.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BillingGetGithubActionsBillingGheExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

            try
            {
                // Get GitHub Actions billing for an enterprise
                BillingGetGithubActionsBillingGhe200Response result = apiInstance.BillingGetGithubActionsBillingGhe(enterprise);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingGetGithubActionsBillingGhe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 

### Return type

[**BillingGetGithubActionsBillingGhe200Response**](BillingGetGithubActionsBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggetgithubactionsbillingorg"></a>
# **BillingGetGithubActionsBillingOrg**
> BillingGetGithubActionsBillingGhe200Response BillingGetGithubActionsBillingOrg (string org)

Get GitHub Actions billing for an organization

Gets the summary of the free and paid GitHub Actions minutes used.  Paid minutes only apply to workflows in private repositories that use GitHub-hosted runners. Minutes used is listed for each GitHub-hosted runner operating system. Any job re-runs are also included in the usage. The usage returned includes any minute multipliers for macOS and Windows runners, and is rounded up to the nearest whole minute. For more information, see \"[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\".  Access tokens must have the `repo` or `admin:org` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BillingGetGithubActionsBillingOrgExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get GitHub Actions billing for an organization
                BillingGetGithubActionsBillingGhe200Response result = apiInstance.BillingGetGithubActionsBillingOrg(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingGetGithubActionsBillingOrg: " + e.Message );
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

[**BillingGetGithubActionsBillingGhe200Response**](BillingGetGithubActionsBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggetgithubactionsbillinguser"></a>
# **BillingGetGithubActionsBillingUser**
> BillingGetGithubActionsBillingGhe200Response BillingGetGithubActionsBillingUser (string username)

Get GitHub Actions billing for a user

Gets the summary of the free and paid GitHub Actions minutes used.  Paid minutes only apply to workflows in private repositories that use GitHub-hosted runners. Minutes used is listed for each GitHub-hosted runner operating system. Any job re-runs are also included in the usage. The usage returned includes any minute multipliers for macOS and Windows runners, and is rounded up to the nearest whole minute. For more information, see \"[Managing billing for GitHub Actions](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-actions)\".  Access tokens must have the `user` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BillingGetGithubActionsBillingUserExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get GitHub Actions billing for a user
                BillingGetGithubActionsBillingGhe200Response result = apiInstance.BillingGetGithubActionsBillingUser(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingGetGithubActionsBillingUser: " + e.Message );
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

[**BillingGetGithubActionsBillingGhe200Response**](BillingGetGithubActionsBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggetgithubadvancedsecuritybillingghe"></a>
# **BillingGetGithubAdvancedSecurityBillingGhe**
> BillingGetGithubAdvancedSecurityBillingGhe200Response BillingGetGithubAdvancedSecurityBillingGhe (string enterprise, int? perPage, int? page)

Get GitHub Advanced Security active committers for an enterprise

Gets the GitHub Advanced Security active committers for an enterprise per repository.  Each distinct user login across all repositories is counted as a single Advanced Security seat, so the `total_advanced_security_committers` is not the sum of active_users for each repository.  The total number of repositories with committer information is tracked by the `total_count` field.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BillingGetGithubAdvancedSecurityBillingGheExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // Get GitHub Advanced Security active committers for an enterprise
                BillingGetGithubAdvancedSecurityBillingGhe200Response result = apiInstance.BillingGetGithubAdvancedSecurityBillingGhe(enterprise, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingGetGithubAdvancedSecurityBillingGhe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**BillingGetGithubAdvancedSecurityBillingGhe200Response**](BillingGetGithubAdvancedSecurityBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggetgithubadvancedsecuritybillingorg"></a>
# **BillingGetGithubAdvancedSecurityBillingOrg**
> BillingGetGithubAdvancedSecurityBillingGhe200Response BillingGetGithubAdvancedSecurityBillingOrg (string org, int? perPage, int? page)

Get GitHub Advanced Security active committers for an organization

Gets the GitHub Advanced Security active committers for an organization per repository.  Each distinct user login across all repositories is counted as a single Advanced Security seat, so the `total_advanced_security_committers` is not the sum of advanced_security_committers for each repository.  If this organization defers to an enterprise for billing, the `total_advanced_security_committers` returned from the organization API may include some users that are in more than one organization, so they will only consume a single Advanced Security seat at the enterprise level.  The total number of repositories with committer information is tracked by the `total_count` field.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BillingGetGithubAdvancedSecurityBillingOrgExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // Get GitHub Advanced Security active committers for an organization
                BillingGetGithubAdvancedSecurityBillingGhe200Response result = apiInstance.BillingGetGithubAdvancedSecurityBillingOrg(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingGetGithubAdvancedSecurityBillingOrg: " + e.Message );
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

[**BillingGetGithubAdvancedSecurityBillingGhe200Response**](BillingGetGithubAdvancedSecurityBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggetgithubpackagesbillingghe"></a>
# **BillingGetGithubPackagesBillingGhe**
> BillingGetGithubPackagesBillingGhe200Response BillingGetGithubPackagesBillingGhe (string enterprise)

Get GitHub Packages billing for an enterprise

Gets the free and paid storage used for GitHub Packages in gigabytes.  Paid minutes only apply to packages stored for private repositories. For more information, see \"[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\"  The authenticated user must be an enterprise admin.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BillingGetGithubPackagesBillingGheExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

            try
            {
                // Get GitHub Packages billing for an enterprise
                BillingGetGithubPackagesBillingGhe200Response result = apiInstance.BillingGetGithubPackagesBillingGhe(enterprise);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingGetGithubPackagesBillingGhe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 

### Return type

[**BillingGetGithubPackagesBillingGhe200Response**](BillingGetGithubPackagesBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggetgithubpackagesbillingorg"></a>
# **BillingGetGithubPackagesBillingOrg**
> BillingGetGithubPackagesBillingGhe200Response BillingGetGithubPackagesBillingOrg (string org)

Get GitHub Packages billing for an organization

Gets the free and paid storage used for GitHub Packages in gigabytes.  Paid minutes only apply to packages stored for private repositories. For more information, see \"[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\"  Access tokens must have the `repo` or `admin:org` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BillingGetGithubPackagesBillingOrgExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get GitHub Packages billing for an organization
                BillingGetGithubPackagesBillingGhe200Response result = apiInstance.BillingGetGithubPackagesBillingOrg(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingGetGithubPackagesBillingOrg: " + e.Message );
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

[**BillingGetGithubPackagesBillingGhe200Response**](BillingGetGithubPackagesBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggetgithubpackagesbillinguser"></a>
# **BillingGetGithubPackagesBillingUser**
> BillingGetGithubPackagesBillingGhe200Response BillingGetGithubPackagesBillingUser (string username)

Get GitHub Packages billing for a user

Gets the free and paid storage used for GitHub Packages in gigabytes.  Paid minutes only apply to packages stored for private repositories. For more information, see \"[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\"  Access tokens must have the `user` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BillingGetGithubPackagesBillingUserExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get GitHub Packages billing for a user
                BillingGetGithubPackagesBillingGhe200Response result = apiInstance.BillingGetGithubPackagesBillingUser(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingGetGithubPackagesBillingUser: " + e.Message );
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

[**BillingGetGithubPackagesBillingGhe200Response**](BillingGetGithubPackagesBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggetsharedstoragebillingghe"></a>
# **BillingGetSharedStorageBillingGhe**
> BillingGetSharedStorageBillingGhe200Response BillingGetSharedStorageBillingGhe (string enterprise)

Get shared storage billing for an enterprise

Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.  Paid minutes only apply to packages stored for private repositories. For more information, see \"[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\"  The authenticated user must be an enterprise admin.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BillingGetSharedStorageBillingGheExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

            try
            {
                // Get shared storage billing for an enterprise
                BillingGetSharedStorageBillingGhe200Response result = apiInstance.BillingGetSharedStorageBillingGhe(enterprise);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingGetSharedStorageBillingGhe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 

### Return type

[**BillingGetSharedStorageBillingGhe200Response**](BillingGetSharedStorageBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggetsharedstoragebillingorg"></a>
# **BillingGetSharedStorageBillingOrg**
> BillingGetSharedStorageBillingGhe200Response BillingGetSharedStorageBillingOrg (string org)

Get shared storage billing for an organization

Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.  Paid minutes only apply to packages stored for private repositories. For more information, see \"[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\"  Access tokens must have the `repo` or `admin:org` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BillingGetSharedStorageBillingOrgExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get shared storage billing for an organization
                BillingGetSharedStorageBillingGhe200Response result = apiInstance.BillingGetSharedStorageBillingOrg(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingGetSharedStorageBillingOrg: " + e.Message );
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

[**BillingGetSharedStorageBillingGhe200Response**](BillingGetSharedStorageBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="billinggetsharedstoragebillinguser"></a>
# **BillingGetSharedStorageBillingUser**
> BillingGetSharedStorageBillingGhe200Response BillingGetSharedStorageBillingUser (string username)

Get shared storage billing for a user

Gets the estimated paid and estimated total storage used for GitHub Actions and GitHub Packages.  Paid minutes only apply to packages stored for private repositories. For more information, see \"[Managing billing for GitHub Packages](https://docs.github.com/github/setting-up-and-managing-billing-and-payments-on-github/managing-billing-for-github-packages).\"  Access tokens must have the `user` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BillingGetSharedStorageBillingUserExample
    {
        public void main()
        {
            var apiInstance = new BillingApi();
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get shared storage billing for a user
                BillingGetSharedStorageBillingGhe200Response result = apiInstance.BillingGetSharedStorageBillingUser(username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BillingApi.BillingGetSharedStorageBillingUser: " + e.Message );
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

[**BillingGetSharedStorageBillingGhe200Response**](BillingGetSharedStorageBillingGhe200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

