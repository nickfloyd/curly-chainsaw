# Org.OpenAPITools.Api.LicensesApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LicensesGet**](LicensesApi.md#licensesget) | **GET** /licenses/{license} | Get a license
[**LicensesGetAllCommonlyUsed**](LicensesApi.md#licensesgetallcommonlyused) | **GET** /licenses | Get all commonly used licenses
[**LicensesGetForRepo**](LicensesApi.md#licensesgetforrepo) | **GET** /repos/{owner}/{repo}/license | Get the license for a repository


<a name="licensesget"></a>
# **LicensesGet**
> License LicensesGet (string license)

Get a license



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicensesGetExample
    {
        public void main()
        {
            var apiInstance = new LicensesApi();
            var license = "license_example";  // string | 

            try
            {
                // Get a license
                License result = apiInstance.LicensesGet(license);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicensesApi.LicensesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **license** | **string**|  | 

### Return type

[**License**](License.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="licensesgetallcommonlyused"></a>
# **LicensesGetAllCommonlyUsed**
> List<LicenseSimple1> LicensesGetAllCommonlyUsed (bool? featured, int? perPage, int? page)

Get all commonly used licenses



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicensesGetAllCommonlyUsedExample
    {
        public void main()
        {
            var apiInstance = new LicensesApi();
            var featured = true;  // bool? |  (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // Get all commonly used licenses
                List&lt;LicenseSimple1&gt; result = apiInstance.LicensesGetAllCommonlyUsed(featured, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicensesApi.LicensesGetAllCommonlyUsed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **featured** | **bool?**|  | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<LicenseSimple1>**](LicenseSimple1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="licensesgetforrepo"></a>
# **LicensesGetForRepo**
> LicenseContent LicensesGetForRepo (string owner, string repo)

Get the license for a repository

This method returns the contents of the repository's license file, if one is detected.  Similar to [Get repository content](https://docs.github.com/rest/reference/repos#get-repository-content), this method also supports [custom media types](https://docs.github.com/rest/overview/media-types) for retrieving the raw license content or rendered license HTML.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicensesGetForRepoExample
    {
        public void main()
        {
            var apiInstance = new LicensesApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.

            try
            {
                // Get the license for a repository
                LicenseContent result = apiInstance.LicensesGetForRepo(owner, repo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicensesApi.LicensesGetForRepo: " + e.Message );
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

[**LicenseContent**](LicenseContent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

