# Org.OpenAPITools.Api.EmojisApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmojisGet**](EmojisApi.md#emojisget) | **GET** /emojis | Get emojis


<a name="emojisget"></a>
# **EmojisGet**
> Dictionary<string, string> EmojisGet ()

Get emojis

Lists all the emojis available to use on GitHub.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EmojisGetExample
    {
        public void main()
        {
            var apiInstance = new EmojisApi();

            try
            {
                // Get emojis
                Dictionary&lt;string, string&gt; result = apiInstance.EmojisGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmojisApi.EmojisGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Dictionary<string, string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

