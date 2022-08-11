# Org.OpenAPITools.Api.ServerStatisticsApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EnterpriseAdminGetServerStatistics**](ServerStatisticsApi.md#enterpriseadmingetserverstatistics) | **GET** /enterprise-installation/{enterprise_or_org}/server-statistics | Get GitHub Enterprise Server statistics


<a name="enterpriseadmingetserverstatistics"></a>
# **EnterpriseAdminGetServerStatistics**
> List<ServerStatisticsProxyEndpointInner> EnterpriseAdminGetServerStatistics (string enterpriseOrOrg, string dateStart, string dateEnd)

Get GitHub Enterprise Server statistics

Returns aggregate usage metrics for your GitHub Enterprise Server 3.5+ instance for a specified time period up to 365 days.  To use this endpoint, your GitHub Enterprise Server instance must be connected to GitHub Enterprise Cloud using GitHub Connect. You must enable Server Statistics, and for the API request provide your enterprise account name or organization name connected to the GitHub Enterprise Server. For more information, see \"[Enabling Server Statistics for your enterprise](/admin/configuration/configuring-github-connect/enabling-server-statistics-for-your-enterprise)\" in the GitHub Enterprise Server documentation.  You'll need to use a personal access token:   - If you connected your GitHub Enterprise Server to an enterprise account and enabled Server Statistics, you'll need a personal access token with the `read:enterprise` permission.   - If you connected your GitHub Enterprise Server to an organization account and enabled Server Statistics, you'll need a personal access token with the `read:org` permission.  For more information on creating a personal access token, see \"[Creating a personal access token](/authentication/keeping-your-account-and-data-secure/creating-a-personal-access-token).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminGetServerStatisticsExample
    {
        public void main()
        {
            var apiInstance = new ServerStatisticsApi();
            var enterpriseOrOrg = "enterpriseOrOrg_example";  // string | The slug version of the enterprise name or the login of an organization.
            var dateStart = "dateStart_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. (optional) 
            var dateEnd = "dateEnd_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. (optional) 

            try
            {
                // Get GitHub Enterprise Server statistics
                List&lt;ServerStatisticsProxyEndpointInner&gt; result = apiInstance.EnterpriseAdminGetServerStatistics(enterpriseOrOrg, dateStart, dateEnd);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServerStatisticsApi.EnterpriseAdminGetServerStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterpriseOrOrg** | **string**| The slug version of the enterprise name or the login of an organization. | 
 **dateStart** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. | [optional] 
 **dateEnd** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. | [optional] 

### Return type

[**List<ServerStatisticsProxyEndpointInner>**](ServerStatisticsProxyEndpointInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

