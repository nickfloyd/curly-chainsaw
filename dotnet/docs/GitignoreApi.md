# Org.OpenAPITools.Api.GitignoreApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GitignoreGetAllTemplates**](GitignoreApi.md#gitignoregetalltemplates) | **GET** /gitignore/templates | Get all gitignore templates
[**GitignoreGetTemplate**](GitignoreApi.md#gitignoregettemplate) | **GET** /gitignore/templates/{name} | Get a gitignore template


<a name="gitignoregetalltemplates"></a>
# **GitignoreGetAllTemplates**
> List<string> GitignoreGetAllTemplates ()

Get all gitignore templates

List all templates available to pass as an option when [creating a repository](https://docs.github.com/rest/reference/repos#create-a-repository-for-the-authenticated-user).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitignoreGetAllTemplatesExample
    {
        public void main()
        {
            var apiInstance = new GitignoreApi();

            try
            {
                // Get all gitignore templates
                List&lt;string&gt; result = apiInstance.GitignoreGetAllTemplates();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitignoreApi.GitignoreGetAllTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitignoregettemplate"></a>
# **GitignoreGetTemplate**
> GitignoreTemplate GitignoreGetTemplate (string name)

Get a gitignore template

The API also allows fetching the source of a single template. Use the raw [media type](https://docs.github.com/rest/overview/media-types/) to get the raw contents.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitignoreGetTemplateExample
    {
        public void main()
        {
            var apiInstance = new GitignoreApi();
            var name = "name_example";  // string | 

            try
            {
                // Get a gitignore template
                GitignoreTemplate result = apiInstance.GitignoreGetTemplate(name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitignoreApi.GitignoreGetTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 

### Return type

[**GitignoreTemplate**](GitignoreTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

