# Org.OpenAPITools.Api.EnterpriseAdminApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterprise**](EnterpriseAdminApi.md#enterpriseadminaddcustomlabelstoselfhostedrunnerforenterprise) | **POST** /enterprises/{enterprise}/actions/runners/{runner_id}/labels | Add custom labels to a self-hosted runner for an enterprise
[**EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterprise**](EnterpriseAdminApi.md#enterpriseadminaddorgaccesstoselfhostedrunnergroupinenterprise) | **PUT** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/organizations/{org_id} | Add organization access to a self-hosted runner group in an enterprise
[**EnterpriseAdminAddSelfHostedRunnerToGroupForEnterprise**](EnterpriseAdminApi.md#enterpriseadminaddselfhostedrunnertogroupforenterprise) | **PUT** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/runners/{runner_id} | Add a self-hosted runner to a group for an enterprise
[**EnterpriseAdminCreateRegistrationTokenForEnterprise**](EnterpriseAdminApi.md#enterpriseadmincreateregistrationtokenforenterprise) | **POST** /enterprises/{enterprise}/actions/runners/registration-token | Create a registration token for an enterprise
[**EnterpriseAdminCreateRemoveTokenForEnterprise**](EnterpriseAdminApi.md#enterpriseadmincreateremovetokenforenterprise) | **POST** /enterprises/{enterprise}/actions/runners/remove-token | Create a remove token for an enterprise
[**EnterpriseAdminCreateSelfHostedRunnerGroupForEnterprise**](EnterpriseAdminApi.md#enterpriseadmincreateselfhostedrunnergroupforenterprise) | **POST** /enterprises/{enterprise}/actions/runner-groups | Create a self-hosted runner group for an enterprise
[**EnterpriseAdminDeleteScimGroupFromEnterprise**](EnterpriseAdminApi.md#enterpriseadmindeletescimgroupfromenterprise) | **DELETE** /scim/v2/enterprises/{enterprise}/Groups/{scim_group_id} | Delete a SCIM group from an enterprise
[**EnterpriseAdminDeleteSelfHostedRunnerFromEnterprise**](EnterpriseAdminApi.md#enterpriseadmindeleteselfhostedrunnerfromenterprise) | **DELETE** /enterprises/{enterprise}/actions/runners/{runner_id} | Delete a self-hosted runner from an enterprise
[**EnterpriseAdminDeleteSelfHostedRunnerGroupFromEnterprise**](EnterpriseAdminApi.md#enterpriseadmindeleteselfhostedrunnergroupfromenterprise) | **DELETE** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id} | Delete a self-hosted runner group from an enterprise
[**EnterpriseAdminDeleteUserFromEnterprise**](EnterpriseAdminApi.md#enterpriseadmindeleteuserfromenterprise) | **DELETE** /scim/v2/enterprises/{enterprise}/Users/{scim_user_id} | Delete a SCIM user from an enterprise
[**EnterpriseAdminDisableSelectedOrganizationGithubActionsEnterprise**](EnterpriseAdminApi.md#enterpriseadmindisableselectedorganizationgithubactionsenterprise) | **DELETE** /enterprises/{enterprise}/actions/permissions/organizations/{org_id} | Disable a selected organization for GitHub Actions in an enterprise
[**EnterpriseAdminEnableSelectedOrganizationGithubActionsEnterprise**](EnterpriseAdminApi.md#enterpriseadminenableselectedorganizationgithubactionsenterprise) | **PUT** /enterprises/{enterprise}/actions/permissions/organizations/{org_id} | Enable a selected organization for GitHub Actions in an enterprise
[**EnterpriseAdminGetAllowedActionsEnterprise**](EnterpriseAdminApi.md#enterpriseadmingetallowedactionsenterprise) | **GET** /enterprises/{enterprise}/actions/permissions/selected-actions | Get allowed actions and reusable workflows for an enterprise
[**EnterpriseAdminGetAuditLog**](EnterpriseAdminApi.md#enterpriseadmingetauditlog) | **GET** /enterprises/{enterprise}/audit-log | Get the audit log for an enterprise
[**EnterpriseAdminGetGithubActionsPermissionsEnterprise**](EnterpriseAdminApi.md#enterpriseadmingetgithubactionspermissionsenterprise) | **GET** /enterprises/{enterprise}/actions/permissions | Get GitHub Actions permissions for an enterprise
[**EnterpriseAdminGetProvisioningInformationForEnterpriseGroup**](EnterpriseAdminApi.md#enterpriseadmingetprovisioninginformationforenterprisegroup) | **GET** /scim/v2/enterprises/{enterprise}/Groups/{scim_group_id} | Get SCIM provisioning information for an enterprise group
[**EnterpriseAdminGetProvisioningInformationForEnterpriseUser**](EnterpriseAdminApi.md#enterpriseadmingetprovisioninginformationforenterpriseuser) | **GET** /scim/v2/enterprises/{enterprise}/Users/{scim_user_id} | Get SCIM provisioning information for an enterprise user
[**EnterpriseAdminGetSelfHostedRunnerForEnterprise**](EnterpriseAdminApi.md#enterpriseadmingetselfhostedrunnerforenterprise) | **GET** /enterprises/{enterprise}/actions/runners/{runner_id} | Get a self-hosted runner for an enterprise
[**EnterpriseAdminGetSelfHostedRunnerGroupForEnterprise**](EnterpriseAdminApi.md#enterpriseadmingetselfhostedrunnergroupforenterprise) | **GET** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id} | Get a self-hosted runner group for an enterprise
[**EnterpriseAdminGetServerStatistics**](EnterpriseAdminApi.md#enterpriseadmingetserverstatistics) | **GET** /enterprise-installation/{enterprise_or_org}/server-statistics | Get GitHub Enterprise Server statistics
[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise**](EnterpriseAdminApi.md#enterpriseadminlistlabelsforselfhostedrunnerforenterprise) | **GET** /enterprises/{enterprise}/actions/runners/{runner_id}/labels | List labels for a self-hosted runner for an enterprise
[**EnterpriseAdminListOrgAccessToSelfHostedRunnerGroupInEnterprise**](EnterpriseAdminApi.md#enterpriseadminlistorgaccesstoselfhostedrunnergroupinenterprise) | **GET** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/organizations | List organization access to a self-hosted runner group in an enterprise
[**EnterpriseAdminListProvisionedGroupsEnterprise**](EnterpriseAdminApi.md#enterpriseadminlistprovisionedgroupsenterprise) | **GET** /scim/v2/enterprises/{enterprise}/Groups | List provisioned SCIM groups for an enterprise
[**EnterpriseAdminListProvisionedIdentitiesEnterprise**](EnterpriseAdminApi.md#enterpriseadminlistprovisionedidentitiesenterprise) | **GET** /scim/v2/enterprises/{enterprise}/Users | List SCIM provisioned identities for an enterprise
[**EnterpriseAdminListRunnerApplicationsForEnterprise**](EnterpriseAdminApi.md#enterpriseadminlistrunnerapplicationsforenterprise) | **GET** /enterprises/{enterprise}/actions/runners/downloads | List runner applications for an enterprise
[**EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise**](EnterpriseAdminApi.md#enterpriseadminlistselectedorganizationsenabledgithubactionsenterprise) | **GET** /enterprises/{enterprise}/actions/permissions/organizations | List selected organizations enabled for GitHub Actions in an enterprise
[**EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise**](EnterpriseAdminApi.md#enterpriseadminlistselfhostedrunnergroupsforenterprise) | **GET** /enterprises/{enterprise}/actions/runner-groups | List self-hosted runner groups for an enterprise
[**EnterpriseAdminListSelfHostedRunnersForEnterprise**](EnterpriseAdminApi.md#enterpriseadminlistselfhostedrunnersforenterprise) | **GET** /enterprises/{enterprise}/actions/runners | List self-hosted runners for an enterprise
[**EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise**](EnterpriseAdminApi.md#enterpriseadminlistselfhostedrunnersingroupforenterprise) | **GET** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/runners | List self-hosted runners in a group for an enterprise
[**EnterpriseAdminProvisionAndInviteEnterpriseGroup**](EnterpriseAdminApi.md#enterpriseadminprovisionandinviteenterprisegroup) | **POST** /scim/v2/enterprises/{enterprise}/Groups | Provision a SCIM enterprise group and invite users
[**EnterpriseAdminProvisionAndInviteEnterpriseUser**](EnterpriseAdminApi.md#enterpriseadminprovisionandinviteenterpriseuser) | **POST** /scim/v2/enterprises/{enterprise}/Users | Provision and invite a SCIM enterprise user
[**EnterpriseAdminRemoveAllCustomLabelsFromSelfHostedRunnerForEnterprise**](EnterpriseAdminApi.md#enterpriseadminremoveallcustomlabelsfromselfhostedrunnerforenterprise) | **DELETE** /enterprises/{enterprise}/actions/runners/{runner_id}/labels | Remove all custom labels from a self-hosted runner for an enterprise
[**EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterprise**](EnterpriseAdminApi.md#enterpriseadminremovecustomlabelfromselfhostedrunnerforenterprise) | **DELETE** /enterprises/{enterprise}/actions/runners/{runner_id}/labels/{name} | Remove a custom label from a self-hosted runner for an enterprise
[**EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterprise**](EnterpriseAdminApi.md#enterpriseadminremoveorgaccesstoselfhostedrunnergroupinenterprise) | **DELETE** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/organizations/{org_id} | Remove organization access to a self-hosted runner group in an enterprise
[**EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterprise**](EnterpriseAdminApi.md#enterpriseadminremoveselfhostedrunnerfromgroupforenterprise) | **DELETE** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/runners/{runner_id} | Remove a self-hosted runner from a group for an enterprise
[**EnterpriseAdminSetAllowedActionsEnterprise**](EnterpriseAdminApi.md#enterpriseadminsetallowedactionsenterprise) | **PUT** /enterprises/{enterprise}/actions/permissions/selected-actions | Set allowed actions and reusable workflows for an enterprise
[**EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterprise**](EnterpriseAdminApi.md#enterpriseadminsetcustomlabelsforselfhostedrunnerforenterprise) | **PUT** /enterprises/{enterprise}/actions/runners/{runner_id}/labels | Set custom labels for a self-hosted runner for an enterprise
[**EnterpriseAdminSetGithubActionsPermissionsEnterprise**](EnterpriseAdminApi.md#enterpriseadminsetgithubactionspermissionsenterprise) | **PUT** /enterprises/{enterprise}/actions/permissions | Set GitHub Actions permissions for an enterprise
[**EnterpriseAdminSetInformationForProvisionedEnterpriseGroup**](EnterpriseAdminApi.md#enterpriseadminsetinformationforprovisionedenterprisegroup) | **PUT** /scim/v2/enterprises/{enterprise}/Groups/{scim_group_id} | Set SCIM information for a provisioned enterprise group
[**EnterpriseAdminSetInformationForProvisionedEnterpriseUser**](EnterpriseAdminApi.md#enterpriseadminsetinformationforprovisionedenterpriseuser) | **PUT** /scim/v2/enterprises/{enterprise}/Users/{scim_user_id} | Set SCIM information for a provisioned enterprise user
[**EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterprise**](EnterpriseAdminApi.md#enterpriseadminsetorgaccesstoselfhostedrunnergroupinenterprise) | **PUT** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/organizations | Set organization access for a self-hosted runner group in an enterprise
[**EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterprise**](EnterpriseAdminApi.md#enterpriseadminsetselectedorganizationsenabledgithubactionsenterprise) | **PUT** /enterprises/{enterprise}/actions/permissions/organizations | Set selected organizations enabled for GitHub Actions in an enterprise
[**EnterpriseAdminSetSelfHostedRunnersInGroupForEnterprise**](EnterpriseAdminApi.md#enterpriseadminsetselfhostedrunnersingroupforenterprise) | **PUT** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id}/runners | Set self-hosted runners in a group for an enterprise
[**EnterpriseAdminUpdateAttributeForEnterpriseGroup**](EnterpriseAdminApi.md#enterpriseadminupdateattributeforenterprisegroup) | **PATCH** /scim/v2/enterprises/{enterprise}/Groups/{scim_group_id} | Update an attribute for a SCIM enterprise group
[**EnterpriseAdminUpdateAttributeForEnterpriseUser**](EnterpriseAdminApi.md#enterpriseadminupdateattributeforenterpriseuser) | **PATCH** /scim/v2/enterprises/{enterprise}/Users/{scim_user_id} | Update an attribute for a SCIM enterprise user
[**EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterprise**](EnterpriseAdminApi.md#enterpriseadminupdateselfhostedrunnergroupforenterprise) | **PATCH** /enterprises/{enterprise}/actions/runner-groups/{runner_group_id} | Update a self-hosted runner group for an enterprise


<a name="enterpriseadminaddcustomlabelstoselfhostedrunnerforenterprise"></a>
# **EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterprise**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterprise (string enterprise, int? runnerId, EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest)

Add custom labels to a self-hosted runner for an enterprise

Add custom labels to a self-hosted runner configured in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.
            var enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest = new EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest(); // EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest | 

            try
            {
                // Add custom labels to a self-hosted runner for an enterprise
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterprise(enterprise, runnerId, enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 
 **enterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest** | [**EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest**](EnterpriseAdminAddCustomLabelsToSelfHostedRunnerForEnterpriseRequest.md)|  | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminaddorgaccesstoselfhostedrunnergroupinenterprise"></a>
# **EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterprise**
> void EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterprise (string enterprise, int? runnerGroupId, int? orgId)

Add organization access to a self-hosted runner group in an enterprise

Adds an organization to the list of selected organizations that can access a self-hosted runner group. The runner group must have `visibility` set to `selected`. For more information, see \"[Create a self-hosted runner group for an enterprise](#create-a-self-hosted-runner-group-for-an-enterprise).\"  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var orgId = 56;  // int? | The unique identifier of the organization.

            try
            {
                // Add organization access to a self-hosted runner group in an enterprise
                apiInstance.EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterprise(enterprise, runnerGroupId, orgId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminAddOrgAccessToSelfHostedRunnerGroupInEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **orgId** | **int?**| The unique identifier of the organization. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminaddselfhostedrunnertogroupforenterprise"></a>
# **EnterpriseAdminAddSelfHostedRunnerToGroupForEnterprise**
> void EnterpriseAdminAddSelfHostedRunnerToGroupForEnterprise (string enterprise, int? runnerGroupId, int? runnerId)

Add a self-hosted runner to a group for an enterprise

Adds a self-hosted runner to a runner group configured in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminAddSelfHostedRunnerToGroupForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Add a self-hosted runner to a group for an enterprise
                apiInstance.EnterpriseAdminAddSelfHostedRunnerToGroupForEnterprise(enterprise, runnerGroupId, runnerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminAddSelfHostedRunnerToGroupForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmincreateregistrationtokenforenterprise"></a>
# **EnterpriseAdminCreateRegistrationTokenForEnterprise**
> AuthenticationToken EnterpriseAdminCreateRegistrationTokenForEnterprise (string enterprise)

Create a registration token for an enterprise

Returns a token that you can pass to the `config` script. The token expires after one hour.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.  #### Example using registration token  Configure your self-hosted runner, replacing `TOKEN` with the registration token provided by this endpoint.  ``` ./config.sh - -url https://github.com/enterprises/octo-enterprise - -token TOKEN ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminCreateRegistrationTokenForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

            try
            {
                // Create a registration token for an enterprise
                AuthenticationToken result = apiInstance.EnterpriseAdminCreateRegistrationTokenForEnterprise(enterprise);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminCreateRegistrationTokenForEnterprise: " + e.Message );
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

[**AuthenticationToken**](AuthenticationToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmincreateremovetokenforenterprise"></a>
# **EnterpriseAdminCreateRemoveTokenForEnterprise**
> AuthenticationToken EnterpriseAdminCreateRemoveTokenForEnterprise (string enterprise)

Create a remove token for an enterprise

Returns a token that you can pass to the `config` script to remove a self-hosted runner from an enterprise. The token expires after one hour.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.  #### Example using remove token  To remove your self-hosted runner from an enterprise, replace `TOKEN` with the remove token provided by this endpoint.  ``` ./config.sh remove - -token TOKEN ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminCreateRemoveTokenForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

            try
            {
                // Create a remove token for an enterprise
                AuthenticationToken result = apiInstance.EnterpriseAdminCreateRemoveTokenForEnterprise(enterprise);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminCreateRemoveTokenForEnterprise: " + e.Message );
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

[**AuthenticationToken**](AuthenticationToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmincreateselfhostedrunnergroupforenterprise"></a>
# **EnterpriseAdminCreateSelfHostedRunnerGroupForEnterprise**
> EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner EnterpriseAdminCreateSelfHostedRunnerGroupForEnterprise (string enterprise, EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest)

Create a self-hosted runner group for an enterprise

Creates a new self-hosted runner group for an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest = new EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest(); // EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest | 

            try
            {
                // Create a self-hosted runner group for an enterprise
                EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner result = apiInstance.EnterpriseAdminCreateSelfHostedRunnerGroupForEnterprise(enterprise, enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminCreateSelfHostedRunnerGroupForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **enterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest** | [**EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest**](EnterpriseAdminCreateSelfHostedRunnerGroupForEnterpriseRequest.md)|  | 

### Return type

[**EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner**](EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmindeletescimgroupfromenterprise"></a>
# **EnterpriseAdminDeleteScimGroupFromEnterprise**
> void EnterpriseAdminDeleteScimGroupFromEnterprise (string enterprise, string scimGroupId)

Delete a SCIM group from an enterprise

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminDeleteScimGroupFromEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var scimGroupId = "scimGroupId_example";  // string | Identifier generated by the GitHub SCIM endpoint.

            try
            {
                // Delete a SCIM group from an enterprise
                apiInstance.EnterpriseAdminDeleteScimGroupFromEnterprise(enterprise, scimGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminDeleteScimGroupFromEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **scimGroupId** | **string**| Identifier generated by the GitHub SCIM endpoint. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmindeleteselfhostedrunnerfromenterprise"></a>
# **EnterpriseAdminDeleteSelfHostedRunnerFromEnterprise**
> void EnterpriseAdminDeleteSelfHostedRunnerFromEnterprise (string enterprise, int? runnerId)

Delete a self-hosted runner from an enterprise

Forces the removal of a self-hosted runner from an enterprise. You can use this endpoint to completely remove the runner when the machine you were using no longer exists.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminDeleteSelfHostedRunnerFromEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Delete a self-hosted runner from an enterprise
                apiInstance.EnterpriseAdminDeleteSelfHostedRunnerFromEnterprise(enterprise, runnerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminDeleteSelfHostedRunnerFromEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmindeleteselfhostedrunnergroupfromenterprise"></a>
# **EnterpriseAdminDeleteSelfHostedRunnerGroupFromEnterprise**
> void EnterpriseAdminDeleteSelfHostedRunnerGroupFromEnterprise (string enterprise, int? runnerGroupId)

Delete a self-hosted runner group from an enterprise

Deletes a self-hosted runner group for an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminDeleteSelfHostedRunnerGroupFromEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.

            try
            {
                // Delete a self-hosted runner group from an enterprise
                apiInstance.EnterpriseAdminDeleteSelfHostedRunnerGroupFromEnterprise(enterprise, runnerGroupId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminDeleteSelfHostedRunnerGroupFromEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmindeleteuserfromenterprise"></a>
# **EnterpriseAdminDeleteUserFromEnterprise**
> void EnterpriseAdminDeleteUserFromEnterprise (string enterprise, string scimUserId)

Delete a SCIM user from an enterprise

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminDeleteUserFromEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var scimUserId = "scimUserId_example";  // string | The unique identifier of the SCIM user.

            try
            {
                // Delete a SCIM user from an enterprise
                apiInstance.EnterpriseAdminDeleteUserFromEnterprise(enterprise, scimUserId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminDeleteUserFromEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **scimUserId** | **string**| The unique identifier of the SCIM user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmindisableselectedorganizationgithubactionsenterprise"></a>
# **EnterpriseAdminDisableSelectedOrganizationGithubActionsEnterprise**
> void EnterpriseAdminDisableSelectedOrganizationGithubActionsEnterprise (string enterprise, int? orgId)

Disable a selected organization for GitHub Actions in an enterprise

Removes an organization from the list of selected organizations that are enabled for GitHub Actions in an enterprise. To use this endpoint, the enterprise permission policy for `enabled_organizations` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminDisableSelectedOrganizationGithubActionsEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var orgId = 56;  // int? | The unique identifier of the organization.

            try
            {
                // Disable a selected organization for GitHub Actions in an enterprise
                apiInstance.EnterpriseAdminDisableSelectedOrganizationGithubActionsEnterprise(enterprise, orgId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminDisableSelectedOrganizationGithubActionsEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **orgId** | **int?**| The unique identifier of the organization. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminenableselectedorganizationgithubactionsenterprise"></a>
# **EnterpriseAdminEnableSelectedOrganizationGithubActionsEnterprise**
> void EnterpriseAdminEnableSelectedOrganizationGithubActionsEnterprise (string enterprise, int? orgId)

Enable a selected organization for GitHub Actions in an enterprise

Adds an organization to the list of selected organizations that are enabled for GitHub Actions in an enterprise. To use this endpoint, the enterprise permission policy for `enabled_organizations` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminEnableSelectedOrganizationGithubActionsEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var orgId = 56;  // int? | The unique identifier of the organization.

            try
            {
                // Enable a selected organization for GitHub Actions in an enterprise
                apiInstance.EnterpriseAdminEnableSelectedOrganizationGithubActionsEnterprise(enterprise, orgId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminEnableSelectedOrganizationGithubActionsEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **orgId** | **int?**| The unique identifier of the organization. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmingetallowedactionsenterprise"></a>
# **EnterpriseAdminGetAllowedActionsEnterprise**
> EnterpriseAdminGetAllowedActionsEnterprise200Response EnterpriseAdminGetAllowedActionsEnterprise (string enterprise)

Get allowed actions and reusable workflows for an enterprise

Gets the selected actions and reusable workflows that are allowed in an enterprise. To use this endpoint, the enterprise permission policy for `allowed_actions` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminGetAllowedActionsEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

            try
            {
                // Get allowed actions and reusable workflows for an enterprise
                EnterpriseAdminGetAllowedActionsEnterprise200Response result = apiInstance.EnterpriseAdminGetAllowedActionsEnterprise(enterprise);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminGetAllowedActionsEnterprise: " + e.Message );
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

[**EnterpriseAdminGetAllowedActionsEnterprise200Response**](EnterpriseAdminGetAllowedActionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmingetauditlog"></a>
# **EnterpriseAdminGetAuditLog**
> List<EnterpriseAdminGetAuditLog200ResponseInner> EnterpriseAdminGetAuditLog (string enterprise, string phrase, string include, string after, string before, string order, int? page, int? perPage)

Get the audit log for an enterprise

Gets the audit log for an enterprise. To use this endpoint, you must be an enterprise admin, and you must use an access token with the `admin:enterprise` scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminGetAuditLogExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var phrase = "phrase_example";  // string | A search phrase. For more information, see [Searching the audit log](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log). (optional) 
            var include = "web";  // string | The event types to include:  - `web` - returns web (non-Git) events. - `git` - returns Git events. - `all` - returns both web and Git events.  The default is `web`. (optional) 
            var after = "after_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. (optional) 
            var before = "before_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. (optional) 
            var order = "desc";  // string | The order of audit log events. To list newest events first, specify `desc`. To list oldest events first, specify `asc`.  The default is `desc`. (optional) 
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)

            try
            {
                // Get the audit log for an enterprise
                List&lt;EnterpriseAdminGetAuditLog200ResponseInner&gt; result = apiInstance.EnterpriseAdminGetAuditLog(enterprise, phrase, include, after, before, order, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminGetAuditLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **phrase** | **string**| A search phrase. For more information, see [Searching the audit log](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log). | [optional] 
 **include** | **string**| The event types to include:  - &#x60;web&#x60; - returns web (non-Git) events. - &#x60;git&#x60; - returns Git events. - &#x60;all&#x60; - returns both web and Git events.  The default is &#x60;web&#x60;. | [optional] 
 **after** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. | [optional] 
 **before** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. | [optional] 
 **order** | **string**| The order of audit log events. To list newest events first, specify &#x60;desc&#x60;. To list oldest events first, specify &#x60;asc&#x60;.  The default is &#x60;desc&#x60;. | [optional] 
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]

### Return type

[**List<EnterpriseAdminGetAuditLog200ResponseInner>**](EnterpriseAdminGetAuditLog200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmingetgithubactionspermissionsenterprise"></a>
# **EnterpriseAdminGetGithubActionsPermissionsEnterprise**
> EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response EnterpriseAdminGetGithubActionsPermissionsEnterprise (string enterprise)

Get GitHub Actions permissions for an enterprise

Gets the GitHub Actions permissions policy for organizations and allowed actions and reusable workflows in an enterprise.  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminGetGithubActionsPermissionsEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

            try
            {
                // Get GitHub Actions permissions for an enterprise
                EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response result = apiInstance.EnterpriseAdminGetGithubActionsPermissionsEnterprise(enterprise);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminGetGithubActionsPermissionsEnterprise: " + e.Message );
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

[**EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response**](EnterpriseAdminGetGithubActionsPermissionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmingetprovisioninginformationforenterprisegroup"></a>
# **EnterpriseAdminGetProvisioningInformationForEnterpriseGroup**
> EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner EnterpriseAdminGetProvisioningInformationForEnterpriseGroup (string enterprise, string scimGroupId, string excludedAttributes)

Get SCIM provisioning information for an enterprise group

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminGetProvisioningInformationForEnterpriseGroupExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var scimGroupId = "scimGroupId_example";  // string | Identifier generated by the GitHub SCIM endpoint.
            var excludedAttributes = "excludedAttributes_example";  // string | Attributes to exclude. (optional) 

            try
            {
                // Get SCIM provisioning information for an enterprise group
                EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner result = apiInstance.EnterpriseAdminGetProvisioningInformationForEnterpriseGroup(enterprise, scimGroupId, excludedAttributes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminGetProvisioningInformationForEnterpriseGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **scimGroupId** | **string**| Identifier generated by the GitHub SCIM endpoint. | 
 **excludedAttributes** | **string**| Attributes to exclude. | [optional] 

### Return type

[**EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner**](EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmingetprovisioninginformationforenterpriseuser"></a>
# **EnterpriseAdminGetProvisioningInformationForEnterpriseUser**
> EnterpriseAdminProvisionAndInviteEnterpriseUser201Response EnterpriseAdminGetProvisioningInformationForEnterpriseUser (string enterprise, string scimUserId)

Get SCIM provisioning information for an enterprise user

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminGetProvisioningInformationForEnterpriseUserExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var scimUserId = "scimUserId_example";  // string | The unique identifier of the SCIM user.

            try
            {
                // Get SCIM provisioning information for an enterprise user
                EnterpriseAdminProvisionAndInviteEnterpriseUser201Response result = apiInstance.EnterpriseAdminGetProvisioningInformationForEnterpriseUser(enterprise, scimUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminGetProvisioningInformationForEnterpriseUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **scimUserId** | **string**| The unique identifier of the SCIM user. | 

### Return type

[**EnterpriseAdminProvisionAndInviteEnterpriseUser201Response**](EnterpriseAdminProvisionAndInviteEnterpriseUser201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmingetselfhostedrunnerforenterprise"></a>
# **EnterpriseAdminGetSelfHostedRunnerForEnterprise**
> SelfHostedRunners EnterpriseAdminGetSelfHostedRunnerForEnterprise (string enterprise, int? runnerId)

Get a self-hosted runner for an enterprise

Gets a specific self-hosted runner configured in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminGetSelfHostedRunnerForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Get a self-hosted runner for an enterprise
                SelfHostedRunners result = apiInstance.EnterpriseAdminGetSelfHostedRunnerForEnterprise(enterprise, runnerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminGetSelfHostedRunnerForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

[**SelfHostedRunners**](SelfHostedRunners.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadmingetselfhostedrunnergroupforenterprise"></a>
# **EnterpriseAdminGetSelfHostedRunnerGroupForEnterprise**
> EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner EnterpriseAdminGetSelfHostedRunnerGroupForEnterprise (string enterprise, int? runnerGroupId)

Get a self-hosted runner group for an enterprise

Gets a specific self-hosted runner group for an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminGetSelfHostedRunnerGroupForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.

            try
            {
                // Get a self-hosted runner group for an enterprise
                EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner result = apiInstance.EnterpriseAdminGetSelfHostedRunnerGroupForEnterprise(enterprise, runnerGroupId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminGetSelfHostedRunnerGroupForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 

### Return type

[**EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner**](EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            var apiInstance = new EnterpriseAdminApi();
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
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminGetServerStatistics: " + e.Message );
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

<a name="enterpriseadminlistlabelsforselfhostedrunnerforenterprise"></a>
# **EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise (string enterprise, int? runnerId)

List labels for a self-hosted runner for an enterprise

Lists all labels for a self-hosted runner configured in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminListLabelsForSelfHostedRunnerForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // List labels for a self-hosted runner for an enterprise
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise(enterprise, runnerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminlistorgaccesstoselfhostedrunnergroupinenterprise"></a>
# **EnterpriseAdminListOrgAccessToSelfHostedRunnerGroupInEnterprise**
> EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response EnterpriseAdminListOrgAccessToSelfHostedRunnerGroupInEnterprise (string enterprise, int? runnerGroupId, int? perPage, int? page)

List organization access to a self-hosted runner group in an enterprise

Lists the organizations with access to a self-hosted runner group.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminListOrgAccessToSelfHostedRunnerGroupInEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organization access to a self-hosted runner group in an enterprise
                EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response result = apiInstance.EnterpriseAdminListOrgAccessToSelfHostedRunnerGroupInEnterprise(enterprise, runnerGroupId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminListOrgAccessToSelfHostedRunnerGroupInEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response**](EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminlistprovisionedgroupsenterprise"></a>
# **EnterpriseAdminListProvisionedGroupsEnterprise**
> EnterpriseAdminListProvisionedGroupsEnterprise200Response EnterpriseAdminListProvisionedGroupsEnterprise (string enterprise, int? startIndex, int? count, string filter, string excludedAttributes)

List provisioned SCIM groups for an enterprise

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminListProvisionedGroupsEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var startIndex = 56;  // int? | Used for pagination: the index of the first result to return. (optional) 
            var count = 56;  // int? | Used for pagination: the number of results to return. (optional) 
            var filter = "filter_example";  // string | filter results (optional) 
            var excludedAttributes = "excludedAttributes_example";  // string | attributes to exclude (optional) 

            try
            {
                // List provisioned SCIM groups for an enterprise
                EnterpriseAdminListProvisionedGroupsEnterprise200Response result = apiInstance.EnterpriseAdminListProvisionedGroupsEnterprise(enterprise, startIndex, count, filter, excludedAttributes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminListProvisionedGroupsEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **startIndex** | **int?**| Used for pagination: the index of the first result to return. | [optional] 
 **count** | **int?**| Used for pagination: the number of results to return. | [optional] 
 **filter** | **string**| filter results | [optional] 
 **excludedAttributes** | **string**| attributes to exclude | [optional] 

### Return type

[**EnterpriseAdminListProvisionedGroupsEnterprise200Response**](EnterpriseAdminListProvisionedGroupsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminlistprovisionedidentitiesenterprise"></a>
# **EnterpriseAdminListProvisionedIdentitiesEnterprise**
> EnterpriseAdminListProvisionedIdentitiesEnterprise200Response EnterpriseAdminListProvisionedIdentitiesEnterprise (string enterprise, int? startIndex, int? count, string filter)

List SCIM provisioned identities for an enterprise

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Retrieves a paginated list of all provisioned enterprise members, including pending invitations.  When a user with a SAML-provisioned external identity leaves (or is removed from) an enterprise, the account's metadata is immediately removed. However, the returned list of user accounts might not always match the organization or enterprise member list you see on GitHub. This can happen in certain cases where an external identity associated with an organization will not match an organization member:   - When a user with a SCIM-provisioned external identity is removed from an enterprise, the account's metadata is preserved to allow the user to re-join the organization in the future.   - When inviting a user to join an organization, you can expect to see their external identity in the results before they accept the invitation, or if the invitation is cancelled (or never accepted).   - When a user is invited over SCIM, an external identity is created that matches with the invitee's email address. However, this identity is only linked to a user account when the user accepts the invitation by going through SAML SSO.  The returned list of external identities can include an entry for a `null` user. These are unlinked SAML identities that are created when a user goes through the following Single Sign-On (SSO) process but does not sign in to their GitHub account after completing SSO:  1. The user is granted access by the IdP and is not a member of the GitHub enterprise.  1. The user attempts to access the GitHub enterprise and initiates the SAML SSO process, and is not currently signed in to their GitHub account.  1. After successfully authenticating with the SAML SSO IdP, the `null` external identity entry is created and the user is prompted to sign in to their GitHub account:    - If the user signs in, their GitHub account is linked to this entry.    - If the user does not sign in (or does not create a new account when prompted), they are not added to the GitHub enterprise, and the external identity `null` entry remains in place.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminListProvisionedIdentitiesEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var startIndex = 56;  // int? | Used for pagination: the index of the first result to return. (optional) 
            var count = 56;  // int? | Used for pagination: the number of results to return. (optional) 
            var filter = "filter_example";  // string | filter results (optional) 

            try
            {
                // List SCIM provisioned identities for an enterprise
                EnterpriseAdminListProvisionedIdentitiesEnterprise200Response result = apiInstance.EnterpriseAdminListProvisionedIdentitiesEnterprise(enterprise, startIndex, count, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminListProvisionedIdentitiesEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **startIndex** | **int?**| Used for pagination: the index of the first result to return. | [optional] 
 **count** | **int?**| Used for pagination: the number of results to return. | [optional] 
 **filter** | **string**| filter results | [optional] 

### Return type

[**EnterpriseAdminListProvisionedIdentitiesEnterprise200Response**](EnterpriseAdminListProvisionedIdentitiesEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminlistrunnerapplicationsforenterprise"></a>
# **EnterpriseAdminListRunnerApplicationsForEnterprise**
> List<RunnerApplication> EnterpriseAdminListRunnerApplicationsForEnterprise (string enterprise)

List runner applications for an enterprise

Lists binaries for the runner application that you can download and run.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminListRunnerApplicationsForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.

            try
            {
                // List runner applications for an enterprise
                List&lt;RunnerApplication&gt; result = apiInstance.EnterpriseAdminListRunnerApplicationsForEnterprise(enterprise);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminListRunnerApplicationsForEnterprise: " + e.Message );
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

[**List<RunnerApplication>**](RunnerApplication.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminlistselectedorganizationsenabledgithubactionsenterprise"></a>
# **EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise**
> EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise (string enterprise, int? perPage, int? page)

List selected organizations enabled for GitHub Actions in an enterprise

Lists the organizations that are selected to have GitHub Actions enabled in an enterprise. To use this endpoint, the enterprise permission policy for `enabled_organizations` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List selected organizations enabled for GitHub Actions in an enterprise
                EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response result = apiInstance.EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise(enterprise, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise: " + e.Message );
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

[**EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response**](EnterpriseAdminListSelectedOrganizationsEnabledGithubActionsEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminlistselfhostedrunnergroupsforenterprise"></a>
# **EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise**
> EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise (string enterprise, int? perPage, int? page, string visibleToOrganization)

List self-hosted runner groups for an enterprise

Lists all self-hosted runner groups for an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminListSelfHostedRunnerGroupsForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)
            var visibleToOrganization = "visibleToOrganization_example";  // string | Only return runner groups that are allowed to be used by this organization. (optional) 

            try
            {
                // List self-hosted runner groups for an enterprise
                EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response result = apiInstance.EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise(enterprise, perPage, page, visibleToOrganization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise: " + e.Message );
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
 **visibleToOrganization** | **string**| Only return runner groups that are allowed to be used by this organization. | [optional] 

### Return type

[**EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response**](EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminlistselfhostedrunnersforenterprise"></a>
# **EnterpriseAdminListSelfHostedRunnersForEnterprise**
> EnterpriseAdminListSelfHostedRunnersForEnterprise200Response EnterpriseAdminListSelfHostedRunnersForEnterprise (string enterprise, int? perPage, int? page)

List self-hosted runners for an enterprise

Lists all self-hosted runners configured for an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminListSelfHostedRunnersForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List self-hosted runners for an enterprise
                EnterpriseAdminListSelfHostedRunnersForEnterprise200Response result = apiInstance.EnterpriseAdminListSelfHostedRunnersForEnterprise(enterprise, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminListSelfHostedRunnersForEnterprise: " + e.Message );
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

[**EnterpriseAdminListSelfHostedRunnersForEnterprise200Response**](EnterpriseAdminListSelfHostedRunnersForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminlistselfhostedrunnersingroupforenterprise"></a>
# **EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise**
> EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise (string enterprise, int? runnerGroupId, int? perPage, int? page)

List self-hosted runners in a group for an enterprise

Lists the self-hosted runners that are in a specific enterprise group.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminListSelfHostedRunnersInGroupForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List self-hosted runners in a group for an enterprise
                EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response result = apiInstance.EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise(enterprise, runnerGroupId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response**](EnterpriseAdminListSelfHostedRunnersInGroupForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminprovisionandinviteenterprisegroup"></a>
# **EnterpriseAdminProvisionAndInviteEnterpriseGroup**
> EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner EnterpriseAdminProvisionAndInviteEnterpriseGroup (string enterprise, EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest enterpriseAdminProvisionAndInviteEnterpriseGroupRequest)

Provision a SCIM enterprise group and invite users

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Provision an enterprise group, and invite users to the group. This sends invitation emails to the email address of the invited users to join the GitHub organization that the SCIM group corresponds to.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminProvisionAndInviteEnterpriseGroupExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var enterpriseAdminProvisionAndInviteEnterpriseGroupRequest = new EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest(); // EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest | 

            try
            {
                // Provision a SCIM enterprise group and invite users
                EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner result = apiInstance.EnterpriseAdminProvisionAndInviteEnterpriseGroup(enterprise, enterpriseAdminProvisionAndInviteEnterpriseGroupRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminProvisionAndInviteEnterpriseGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **enterpriseAdminProvisionAndInviteEnterpriseGroupRequest** | [**EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest**](EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest.md)|  | 

### Return type

[**EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner**](EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminprovisionandinviteenterpriseuser"></a>
# **EnterpriseAdminProvisionAndInviteEnterpriseUser**
> EnterpriseAdminProvisionAndInviteEnterpriseUser201Response EnterpriseAdminProvisionAndInviteEnterpriseUser (string enterprise, EnterpriseAdminProvisionAndInviteEnterpriseUserRequest enterpriseAdminProvisionAndInviteEnterpriseUserRequest)

Provision and invite a SCIM enterprise user

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Provision enterprise membership for a user, and send organization invitation emails to the email address.  You can optionally include the groups a user will be invited to join. If you do not provide a list of `groups`, the user is provisioned for the enterprise, but no organization invitation emails will be sent.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminProvisionAndInviteEnterpriseUserExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var enterpriseAdminProvisionAndInviteEnterpriseUserRequest = new EnterpriseAdminProvisionAndInviteEnterpriseUserRequest(); // EnterpriseAdminProvisionAndInviteEnterpriseUserRequest | 

            try
            {
                // Provision and invite a SCIM enterprise user
                EnterpriseAdminProvisionAndInviteEnterpriseUser201Response result = apiInstance.EnterpriseAdminProvisionAndInviteEnterpriseUser(enterprise, enterpriseAdminProvisionAndInviteEnterpriseUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminProvisionAndInviteEnterpriseUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **enterpriseAdminProvisionAndInviteEnterpriseUserRequest** | [**EnterpriseAdminProvisionAndInviteEnterpriseUserRequest**](EnterpriseAdminProvisionAndInviteEnterpriseUserRequest.md)|  | 

### Return type

[**EnterpriseAdminProvisionAndInviteEnterpriseUser201Response**](EnterpriseAdminProvisionAndInviteEnterpriseUser201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminremoveallcustomlabelsfromselfhostedrunnerforenterprise"></a>
# **EnterpriseAdminRemoveAllCustomLabelsFromSelfHostedRunnerForEnterprise**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminRemoveAllCustomLabelsFromSelfHostedRunnerForEnterprise (string enterprise, int? runnerId)

Remove all custom labels from a self-hosted runner for an enterprise

Remove all custom labels from a self-hosted runner configured in an enterprise. Returns the remaining read-only labels from the runner.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminRemoveAllCustomLabelsFromSelfHostedRunnerForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Remove all custom labels from a self-hosted runner for an enterprise
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.EnterpriseAdminRemoveAllCustomLabelsFromSelfHostedRunnerForEnterprise(enterprise, runnerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminRemoveAllCustomLabelsFromSelfHostedRunnerForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminremovecustomlabelfromselfhostedrunnerforenterprise"></a>
# **EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterprise**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterprise (string enterprise, int? runnerId, string name)

Remove a custom label from a self-hosted runner for an enterprise

Remove a custom label from a self-hosted runner configured in an enterprise. Returns the remaining labels from the runner.  This endpoint returns a `404 Not Found` status if the custom label is not present on the runner.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.
            var name = "name_example";  // string | The name of a self-hosted runner's custom label.

            try
            {
                // Remove a custom label from a self-hosted runner for an enterprise
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterprise(enterprise, runnerId, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminRemoveCustomLabelFromSelfHostedRunnerForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 
 **name** | **string**| The name of a self-hosted runner&#39;s custom label. | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminremoveorgaccesstoselfhostedrunnergroupinenterprise"></a>
# **EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterprise**
> void EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterprise (string enterprise, int? runnerGroupId, int? orgId)

Remove organization access to a self-hosted runner group in an enterprise

Removes an organization from the list of selected organizations that can access a self-hosted runner group. The runner group must have `visibility` set to `selected`. For more information, see \"[Create a self-hosted runner group for an enterprise](#create-a-self-hosted-runner-group-for-an-enterprise).\"  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var orgId = 56;  // int? | The unique identifier of the organization.

            try
            {
                // Remove organization access to a self-hosted runner group in an enterprise
                apiInstance.EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterprise(enterprise, runnerGroupId, orgId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminRemoveOrgAccessToSelfHostedRunnerGroupInEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **orgId** | **int?**| The unique identifier of the organization. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminremoveselfhostedrunnerfromgroupforenterprise"></a>
# **EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterprise**
> void EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterprise (string enterprise, int? runnerGroupId, int? runnerId)

Remove a self-hosted runner from a group for an enterprise

Removes a self-hosted runner from a group configured in an enterprise. The runner is then returned to the default group.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.

            try
            {
                // Remove a self-hosted runner from a group for an enterprise
                apiInstance.EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterprise(enterprise, runnerGroupId, runnerId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminRemoveSelfHostedRunnerFromGroupForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminsetallowedactionsenterprise"></a>
# **EnterpriseAdminSetAllowedActionsEnterprise**
> void EnterpriseAdminSetAllowedActionsEnterprise (string enterprise, EnterpriseAdminGetAllowedActionsEnterprise200Response enterpriseAdminGetAllowedActionsEnterprise200Response)

Set allowed actions and reusable workflows for an enterprise

Sets the actions and reusable workflows that are allowed in an enterprise. To use this endpoint, the enterprise permission policy for `allowed_actions` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminSetAllowedActionsEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var enterpriseAdminGetAllowedActionsEnterprise200Response = new EnterpriseAdminGetAllowedActionsEnterprise200Response(); // EnterpriseAdminGetAllowedActionsEnterprise200Response | 

            try
            {
                // Set allowed actions and reusable workflows for an enterprise
                apiInstance.EnterpriseAdminSetAllowedActionsEnterprise(enterprise, enterpriseAdminGetAllowedActionsEnterprise200Response);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminSetAllowedActionsEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **enterpriseAdminGetAllowedActionsEnterprise200Response** | [**EnterpriseAdminGetAllowedActionsEnterprise200Response**](EnterpriseAdminGetAllowedActionsEnterprise200Response.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminsetcustomlabelsforselfhostedrunnerforenterprise"></a>
# **EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterprise**
> EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterprise (string enterprise, int? runnerId, EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest)

Set custom labels for a self-hosted runner for an enterprise

Remove all previous custom labels and set the new custom labels for a specific self-hosted runner configured in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerId = 56;  // int? | Unique identifier of the self-hosted runner.
            var enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest = new EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest(); // EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest | 

            try
            {
                // Set custom labels for a self-hosted runner for an enterprise
                EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response result = apiInstance.EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterprise(enterprise, runnerId, enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerId** | **int?**| Unique identifier of the self-hosted runner. | 
 **enterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest** | [**EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest**](EnterpriseAdminSetCustomLabelsForSelfHostedRunnerForEnterpriseRequest.md)|  | 

### Return type

[**EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response**](EnterpriseAdminListLabelsForSelfHostedRunnerForEnterprise200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminsetgithubactionspermissionsenterprise"></a>
# **EnterpriseAdminSetGithubActionsPermissionsEnterprise**
> void EnterpriseAdminSetGithubActionsPermissionsEnterprise (string enterprise, EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest)

Set GitHub Actions permissions for an enterprise

Sets the GitHub Actions permissions policy for organizations and allowed actions and reusable workflows in an enterprise.  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminSetGithubActionsPermissionsEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest = new EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest(); // EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest | 

            try
            {
                // Set GitHub Actions permissions for an enterprise
                apiInstance.EnterpriseAdminSetGithubActionsPermissionsEnterprise(enterprise, enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminSetGithubActionsPermissionsEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **enterpriseAdminSetGithubActionsPermissionsEnterpriseRequest** | [**EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest**](EnterpriseAdminSetGithubActionsPermissionsEnterpriseRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminsetinformationforprovisionedenterprisegroup"></a>
# **EnterpriseAdminSetInformationForProvisionedEnterpriseGroup**
> EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner EnterpriseAdminSetInformationForProvisionedEnterpriseGroup (string enterprise, string scimGroupId, EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest enterpriseAdminProvisionAndInviteEnterpriseGroupRequest)

Set SCIM information for a provisioned enterprise group

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Replaces an existing provisioned group’s information. You must provide all the information required for the group as if you were provisioning it for the first time. Any existing group information that you don't provide will be removed, including group membership. If you want to only update a specific attribute, use the [Update an attribute for a SCIM enterprise group](#update-an-attribute-for-a-scim-enterprise-group) endpoint instead.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminSetInformationForProvisionedEnterpriseGroupExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var scimGroupId = "scimGroupId_example";  // string | Identifier generated by the GitHub SCIM endpoint.
            var enterpriseAdminProvisionAndInviteEnterpriseGroupRequest = new EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest(); // EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest | 

            try
            {
                // Set SCIM information for a provisioned enterprise group
                EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner result = apiInstance.EnterpriseAdminSetInformationForProvisionedEnterpriseGroup(enterprise, scimGroupId, enterpriseAdminProvisionAndInviteEnterpriseGroupRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminSetInformationForProvisionedEnterpriseGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **scimGroupId** | **string**| Identifier generated by the GitHub SCIM endpoint. | 
 **enterpriseAdminProvisionAndInviteEnterpriseGroupRequest** | [**EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest**](EnterpriseAdminProvisionAndInviteEnterpriseGroupRequest.md)|  | 

### Return type

[**EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner**](EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminsetinformationforprovisionedenterpriseuser"></a>
# **EnterpriseAdminSetInformationForProvisionedEnterpriseUser**
> EnterpriseAdminProvisionAndInviteEnterpriseUser201Response EnterpriseAdminSetInformationForProvisionedEnterpriseUser (string enterprise, string scimUserId, EnterpriseAdminProvisionAndInviteEnterpriseUserRequest enterpriseAdminProvisionAndInviteEnterpriseUserRequest)

Set SCIM information for a provisioned enterprise user

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Replaces an existing provisioned user's information. You must provide all the information required for the user as if you were provisioning them for the first time. Any existing user information that you don't provide will be removed. If you want to only update a specific attribute, use the [Update an attribute for a SCIM user](#update-an-attribute-for-an-enterprise-scim-user) endpoint instead.  You must at least provide the required values for the user: `userName`, `name`, and `emails`.  **Warning:** Setting `active: false` removes the user from the enterprise, deletes the external identity, and deletes the associated `{scim_user_id}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminSetInformationForProvisionedEnterpriseUserExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var scimUserId = "scimUserId_example";  // string | The unique identifier of the SCIM user.
            var enterpriseAdminProvisionAndInviteEnterpriseUserRequest = new EnterpriseAdminProvisionAndInviteEnterpriseUserRequest(); // EnterpriseAdminProvisionAndInviteEnterpriseUserRequest | 

            try
            {
                // Set SCIM information for a provisioned enterprise user
                EnterpriseAdminProvisionAndInviteEnterpriseUser201Response result = apiInstance.EnterpriseAdminSetInformationForProvisionedEnterpriseUser(enterprise, scimUserId, enterpriseAdminProvisionAndInviteEnterpriseUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminSetInformationForProvisionedEnterpriseUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **scimUserId** | **string**| The unique identifier of the SCIM user. | 
 **enterpriseAdminProvisionAndInviteEnterpriseUserRequest** | [**EnterpriseAdminProvisionAndInviteEnterpriseUserRequest**](EnterpriseAdminProvisionAndInviteEnterpriseUserRequest.md)|  | 

### Return type

[**EnterpriseAdminProvisionAndInviteEnterpriseUser201Response**](EnterpriseAdminProvisionAndInviteEnterpriseUser201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminsetorgaccesstoselfhostedrunnergroupinenterprise"></a>
# **EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterprise**
> void EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterprise (string enterprise, int? runnerGroupId, EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest)

Set organization access for a self-hosted runner group in an enterprise

Replaces the list of organizations that have access to a self-hosted runner configured in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest = new EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest(); // EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest | 

            try
            {
                // Set organization access for a self-hosted runner group in an enterprise
                apiInstance.EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterprise(enterprise, runnerGroupId, enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **enterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest** | [**EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest**](EnterpriseAdminSetOrgAccessToSelfHostedRunnerGroupInEnterpriseRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminsetselectedorganizationsenabledgithubactionsenterprise"></a>
# **EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterprise**
> void EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterprise (string enterprise, EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest)

Set selected organizations enabled for GitHub Actions in an enterprise

Replaces the list of selected organizations that are enabled for GitHub Actions in an enterprise. To use this endpoint, the enterprise permission policy for `enabled_organizations` must be configured to `selected`. For more information, see \"[Set GitHub Actions permissions for an enterprise](#set-github-actions-permissions-for-an-enterprise).\"  You must authenticate using an access token with the `admin:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest = new EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest(); // EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest | 

            try
            {
                // Set selected organizations enabled for GitHub Actions in an enterprise
                apiInstance.EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterprise(enterprise, enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **enterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest** | [**EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest**](EnterpriseAdminSetSelectedOrganizationsEnabledGithubActionsEnterpriseRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminsetselfhostedrunnersingroupforenterprise"></a>
# **EnterpriseAdminSetSelfHostedRunnersInGroupForEnterprise**
> void EnterpriseAdminSetSelfHostedRunnersInGroupForEnterprise (string enterprise, int? runnerGroupId, EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest)

Set self-hosted runners in a group for an enterprise

Replaces the list of self-hosted runners that are part of an enterprise runner group.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest = new EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest(); // EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest | 

            try
            {
                // Set self-hosted runners in a group for an enterprise
                apiInstance.EnterpriseAdminSetSelfHostedRunnersInGroupForEnterprise(enterprise, runnerGroupId, enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminSetSelfHostedRunnersInGroupForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **enterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest** | [**EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest**](EnterpriseAdminSetSelfHostedRunnersInGroupForEnterpriseRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminupdateattributeforenterprisegroup"></a>
# **EnterpriseAdminUpdateAttributeForEnterpriseGroup**
> EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner EnterpriseAdminUpdateAttributeForEnterpriseGroup (string enterprise, string scimGroupId, EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest enterpriseAdminUpdateAttributeForEnterpriseGroupRequest)

Update an attribute for a SCIM enterprise group

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Allows you to change a provisioned group’s individual attributes. To change a group’s values, you must provide a specific Operations JSON format that contains at least one of the add, remove, or replace operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminUpdateAttributeForEnterpriseGroupExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var scimGroupId = "scimGroupId_example";  // string | Identifier generated by the GitHub SCIM endpoint.
            var enterpriseAdminUpdateAttributeForEnterpriseGroupRequest = new EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest(); // EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest | 

            try
            {
                // Update an attribute for a SCIM enterprise group
                EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner result = apiInstance.EnterpriseAdminUpdateAttributeForEnterpriseGroup(enterprise, scimGroupId, enterpriseAdminUpdateAttributeForEnterpriseGroupRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminUpdateAttributeForEnterpriseGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **scimGroupId** | **string**| Identifier generated by the GitHub SCIM endpoint. | 
 **enterpriseAdminUpdateAttributeForEnterpriseGroupRequest** | [**EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest**](EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest.md)|  | 

### Return type

[**EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner**](EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminupdateattributeforenterpriseuser"></a>
# **EnterpriseAdminUpdateAttributeForEnterpriseUser**
> EnterpriseAdminProvisionAndInviteEnterpriseUser201Response EnterpriseAdminUpdateAttributeForEnterpriseUser (string enterprise, string scimUserId, EnterpriseAdminUpdateAttributeForEnterpriseUserRequest enterpriseAdminUpdateAttributeForEnterpriseUserRequest)

Update an attribute for a SCIM enterprise user

**Note:** The SCIM API endpoints for enterprise accounts are currently in beta and are subject to change.  Allows you to change a provisioned user's individual attributes. To change a user's values, you must provide a specific `Operations` JSON format that contains at least one of the `add`, `remove`, or `replace` operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).  **Note:** Complicated SCIM `path` selectors that include filters are not supported. For example, a `path` selector defined as `\"path\": \"emails[type eq \\\"work\\\"]\"` will not work.  **Warning:** If you set `active:false` using the `replace` operation (as shown in the JSON example below), it removes the user from the enterprise, deletes the external identity, and deletes the associated `:scim_user_id`.  ``` {   \"Operations\":[{     \"op\":\"replace\",     \"value\":{       \"active\":false     }   }] } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminUpdateAttributeForEnterpriseUserExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var scimUserId = "scimUserId_example";  // string | The unique identifier of the SCIM user.
            var enterpriseAdminUpdateAttributeForEnterpriseUserRequest = new EnterpriseAdminUpdateAttributeForEnterpriseUserRequest(); // EnterpriseAdminUpdateAttributeForEnterpriseUserRequest | 

            try
            {
                // Update an attribute for a SCIM enterprise user
                EnterpriseAdminProvisionAndInviteEnterpriseUser201Response result = apiInstance.EnterpriseAdminUpdateAttributeForEnterpriseUser(enterprise, scimUserId, enterpriseAdminUpdateAttributeForEnterpriseUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminUpdateAttributeForEnterpriseUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **scimUserId** | **string**| The unique identifier of the SCIM user. | 
 **enterpriseAdminUpdateAttributeForEnterpriseUserRequest** | [**EnterpriseAdminUpdateAttributeForEnterpriseUserRequest**](EnterpriseAdminUpdateAttributeForEnterpriseUserRequest.md)|  | 

### Return type

[**EnterpriseAdminProvisionAndInviteEnterpriseUser201Response**](EnterpriseAdminProvisionAndInviteEnterpriseUser201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enterpriseadminupdateselfhostedrunnergroupforenterprise"></a>
# **EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterprise**
> EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterprise (string enterprise, int? runnerGroupId, EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest enterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest)

Update a self-hosted runner group for an enterprise

Updates the `name` and `visibility` of a self-hosted runner group in an enterprise.  You must authenticate using an access token with the `manage_runners:enterprise` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseExample
    {
        public void main()
        {
            var apiInstance = new EnterpriseAdminApi();
            var enterprise = "enterprise_example";  // string | The slug version of the enterprise name. You can also substitute this value with the enterprise id.
            var runnerGroupId = 56;  // int? | Unique identifier of the self-hosted runner group.
            var enterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest = new EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest(); // EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest |  (optional) 

            try
            {
                // Update a self-hosted runner group for an enterprise
                EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner result = apiInstance.EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterprise(enterprise, runnerGroupId, enterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EnterpriseAdminApi.EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterprise: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **enterprise** | **string**| The slug version of the enterprise name. You can also substitute this value with the enterprise id. | 
 **runnerGroupId** | **int?**| Unique identifier of the self-hosted runner group. | 
 **enterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest** | [**EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest**](EnterpriseAdminUpdateSelfHostedRunnerGroupForEnterpriseRequest.md)|  | [optional] 

### Return type

[**EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner**](EnterpriseAdminListSelfHostedRunnerGroupsForEnterprise200ResponseRunnerGroupsInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

