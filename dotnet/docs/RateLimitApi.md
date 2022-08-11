# Org.OpenAPITools.Api.RateLimitApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RateLimitGet**](RateLimitApi.md#ratelimitget) | **GET** /rate_limit | Get rate limit status for the authenticated user


<a name="ratelimitget"></a>
# **RateLimitGet**
> RateLimitOverview RateLimitGet ()

Get rate limit status for the authenticated user

**Note:** Accessing this endpoint does not count against your REST API rate limit.  **Note:** The `rate` object is deprecated. If you're writing new API client code or updating existing code, you should use the `core` object instead of the `rate` object. The `core` object contains the same information that is present in the `rate` object.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RateLimitGetExample
    {
        public void main()
        {
            var apiInstance = new RateLimitApi();

            try
            {
                // Get rate limit status for the authenticated user
                RateLimitOverview result = apiInstance.RateLimitGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RateLimitApi.RateLimitGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RateLimitOverview**](RateLimitOverview.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

