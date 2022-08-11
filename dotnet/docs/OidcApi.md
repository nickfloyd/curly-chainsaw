# Org.OpenAPITools.Api.OidcApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OidcGetOidcCustomSubTemplateForOrg**](OidcApi.md#oidcgetoidccustomsubtemplatefororg) | **GET** /orgs/{org}/actions/oidc/customization/sub | Get the customization template for an OIDC subject claim for an organization
[**OidcUpdateOidcCustomSubTemplateForOrg**](OidcApi.md#oidcupdateoidccustomsubtemplatefororg) | **PUT** /orgs/{org}/actions/oidc/customization/sub | Set the customization template for an OIDC subject claim for an organization


<a name="oidcgetoidccustomsubtemplatefororg"></a>
# **OidcGetOidcCustomSubTemplateForOrg**
> ActionsOIDCSubjectCustomization OidcGetOidcCustomSubTemplateForOrg (string org)

Get the customization template for an OIDC subject claim for an organization

Gets the customization template for an OpenID Connect (OIDC) subject claim. You must authenticate using an access token with the `read:org` scope to use this endpoint. GitHub Apps must have the `organization_administration:write` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OidcGetOidcCustomSubTemplateForOrgExample
    {
        public void main()
        {
            var apiInstance = new OidcApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get the customization template for an OIDC subject claim for an organization
                ActionsOIDCSubjectCustomization result = apiInstance.OidcGetOidcCustomSubTemplateForOrg(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OidcApi.OidcGetOidcCustomSubTemplateForOrg: " + e.Message );
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

[**ActionsOIDCSubjectCustomization**](ActionsOIDCSubjectCustomization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="oidcupdateoidccustomsubtemplatefororg"></a>
# **OidcUpdateOidcCustomSubTemplateForOrg**
> Object OidcUpdateOidcCustomSubTemplateForOrg (string org, ActionsOIDCSubjectCustomization actionsOIDCSubjectCustomization)

Set the customization template for an OIDC subject claim for an organization

Creates or updates the customization template for an OpenID Connect (OIDC) subject claim. You must authenticate using an access token with the `write:org` scope to use this endpoint. GitHub Apps must have the `admin:org` permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OidcUpdateOidcCustomSubTemplateForOrgExample
    {
        public void main()
        {
            var apiInstance = new OidcApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var actionsOIDCSubjectCustomization = new ActionsOIDCSubjectCustomization(); // ActionsOIDCSubjectCustomization | 

            try
            {
                // Set the customization template for an OIDC subject claim for an organization
                Object result = apiInstance.OidcUpdateOidcCustomSubTemplateForOrg(org, actionsOIDCSubjectCustomization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OidcApi.OidcUpdateOidcCustomSubTemplateForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **actionsOIDCSubjectCustomization** | [**ActionsOIDCSubjectCustomization**](ActionsOIDCSubjectCustomization.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

