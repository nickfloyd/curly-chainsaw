# Org.OpenAPITools.Api.CodesOfConductApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CodesOfConductGetAllCodesOfConduct**](CodesOfConductApi.md#codesofconductgetallcodesofconduct) | **GET** /codes_of_conduct | Get all codes of conduct
[**CodesOfConductGetConductCode**](CodesOfConductApi.md#codesofconductgetconductcode) | **GET** /codes_of_conduct/{key} | Get a code of conduct


<a name="codesofconductgetallcodesofconduct"></a>
# **CodesOfConductGetAllCodesOfConduct**
> List<CodeOfConduct> CodesOfConductGetAllCodesOfConduct ()

Get all codes of conduct



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodesOfConductGetAllCodesOfConductExample
    {
        public void main()
        {
            var apiInstance = new CodesOfConductApi();

            try
            {
                // Get all codes of conduct
                List&lt;CodeOfConduct&gt; result = apiInstance.CodesOfConductGetAllCodesOfConduct();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodesOfConductApi.CodesOfConductGetAllCodesOfConduct: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<CodeOfConduct>**](CodeOfConduct.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="codesofconductgetconductcode"></a>
# **CodesOfConductGetConductCode**
> CodeOfConduct CodesOfConductGetConductCode (string key)

Get a code of conduct



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CodesOfConductGetConductCodeExample
    {
        public void main()
        {
            var apiInstance = new CodesOfConductApi();
            var key = "key_example";  // string | 

            try
            {
                // Get a code of conduct
                CodeOfConduct result = apiInstance.CodesOfConductGetConductCode(key);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CodesOfConductApi.CodesOfConductGetConductCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**|  | 

### Return type

[**CodeOfConduct**](CodeOfConduct.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

