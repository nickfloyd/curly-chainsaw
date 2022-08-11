# Org.OpenAPITools.Api.MetaApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MetaGet**](MetaApi.md#metaget) | **GET** /meta | Get GitHub meta information
[**MetaGetOctocat**](MetaApi.md#metagetoctocat) | **GET** /octocat | Get Octocat
[**MetaGetZen**](MetaApi.md#metagetzen) | **GET** /zen | Get the Zen of GitHub
[**MetaRoot**](MetaApi.md#metaroot) | **GET** / | GitHub API Root


<a name="metaget"></a>
# **MetaGet**
> ApiOverview MetaGet ()

Get GitHub meta information

Returns meta information about GitHub, including a list of GitHub's IP addresses. For more information, see \"[About GitHub's IP addresses](https://docs.github.com/articles/about-github-s-ip-addresses/).\"  **Note:** The IP addresses shown in the documentation's response are only example values. You must always query the API directly to get the latest list of IP addresses.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MetaGetExample
    {
        public void main()
        {
            var apiInstance = new MetaApi();

            try
            {
                // Get GitHub meta information
                ApiOverview result = apiInstance.MetaGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetaApi.MetaGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApiOverview**](ApiOverview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="metagetoctocat"></a>
# **MetaGetOctocat**
> string MetaGetOctocat (string s)

Get Octocat

Get the octocat as ASCII art

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MetaGetOctocatExample
    {
        public void main()
        {
            var apiInstance = new MetaApi();
            var s = "s_example";  // string | The words to show in Octocat's speech bubble (optional) 

            try
            {
                // Get Octocat
                string result = apiInstance.MetaGetOctocat(s);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetaApi.MetaGetOctocat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **s** | **string**| The words to show in Octocat&#39;s speech bubble | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octocat-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="metagetzen"></a>
# **MetaGetZen**
> string MetaGetZen ()

Get the Zen of GitHub

Get a random sentence from the Zen of GitHub

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MetaGetZenExample
    {
        public void main()
        {
            var apiInstance = new MetaApi();

            try
            {
                // Get the Zen of GitHub
                string result = apiInstance.MetaGetZen();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetaApi.MetaGetZen: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="metaroot"></a>
# **MetaRoot**
> MetaRoot200Response MetaRoot ()

GitHub API Root

Get Hypermedia links to resources accessible in GitHub's REST API

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MetaRootExample
    {
        public void main()
        {
            var apiInstance = new MetaApi();

            try
            {
                // GitHub API Root
                MetaRoot200Response result = apiInstance.MetaRoot();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetaApi.MetaRoot: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MetaRoot200Response**](MetaRoot200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

