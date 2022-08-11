# Org.OpenAPITools.Api.MarkdownApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MarkdownRender**](MarkdownApi.md#markdownrender) | **POST** /markdown | Render a Markdown document
[**MarkdownRenderRaw**](MarkdownApi.md#markdownrenderraw) | **POST** /markdown/raw | Render a Markdown document in raw mode


<a name="markdownrender"></a>
# **MarkdownRender**
> string MarkdownRender (MarkdownRenderRequest markdownRenderRequest)

Render a Markdown document



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MarkdownRenderExample
    {
        public void main()
        {
            var apiInstance = new MarkdownApi();
            var markdownRenderRequest = new MarkdownRenderRequest(); // MarkdownRenderRequest | 

            try
            {
                // Render a Markdown document
                string result = apiInstance.MarkdownRender(markdownRenderRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarkdownApi.MarkdownRender: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **markdownRenderRequest** | [**MarkdownRenderRequest**](MarkdownRenderRequest.md)|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="markdownrenderraw"></a>
# **MarkdownRenderRaw**
> string MarkdownRenderRaw (string body)

Render a Markdown document in raw mode

You must send Markdown as plain text (using a `Content-Type` header of `text/plain` or `text/x-markdown`) to this endpoint, rather than using JSON format. In raw mode, [GitHub Flavored Markdown](https://github.github.com/gfm/) is not supported and Markdown will be rendered in plain format like a README.md file. Markdown content must be 400 KB or less.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MarkdownRenderRawExample
    {
        public void main()
        {
            var apiInstance = new MarkdownApi();
            var body = "body_example";  // string |  (optional) 

            try
            {
                // Render a Markdown document in raw mode
                string result = apiInstance.MarkdownRenderRaw(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarkdownApi.MarkdownRenderRaw: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**|  | [optional] 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain, text/x-markdown
 - **Accept**: text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

