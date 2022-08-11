# Org.OpenAPITools.Api.ScimApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ScimDeleteUserFromOrg**](ScimApi.md#scimdeleteuserfromorg) | **DELETE** /scim/v2/organizations/{org}/Users/{scim_user_id} | Delete a SCIM user from an organization
[**ScimGetProvisioningInformationForUser**](ScimApi.md#scimgetprovisioninginformationforuser) | **GET** /scim/v2/organizations/{org}/Users/{scim_user_id} | Get SCIM provisioning information for a user
[**ScimListProvisionedIdentities**](ScimApi.md#scimlistprovisionedidentities) | **GET** /scim/v2/organizations/{org}/Users | List SCIM provisioned identities
[**ScimProvisionAndInviteUser**](ScimApi.md#scimprovisionandinviteuser) | **POST** /scim/v2/organizations/{org}/Users | Provision and invite a SCIM user
[**ScimSetInformationForProvisionedUser**](ScimApi.md#scimsetinformationforprovisioneduser) | **PUT** /scim/v2/organizations/{org}/Users/{scim_user_id} | Update a provisioned organization membership
[**ScimUpdateAttributeForUser**](ScimApi.md#scimupdateattributeforuser) | **PATCH** /scim/v2/organizations/{org}/Users/{scim_user_id} | Update an attribute for a SCIM user


<a name="scimdeleteuserfromorg"></a>
# **ScimDeleteUserFromOrg**
> void ScimDeleteUserFromOrg (string org, string scimUserId)

Delete a SCIM user from an organization



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScimDeleteUserFromOrgExample
    {
        public void main()
        {
            var apiInstance = new ScimApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var scimUserId = "scimUserId_example";  // string | The unique identifier of the SCIM user.

            try
            {
                // Delete a SCIM user from an organization
                apiInstance.ScimDeleteUserFromOrg(org, scimUserId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScimApi.ScimDeleteUserFromOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **scimUserId** | **string**| The unique identifier of the SCIM user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scimgetprovisioninginformationforuser"></a>
# **ScimGetProvisioningInformationForUser**
> SCIMUsers ScimGetProvisioningInformationForUser (string org, string scimUserId)

Get SCIM provisioning information for a user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScimGetProvisioningInformationForUserExample
    {
        public void main()
        {
            var apiInstance = new ScimApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var scimUserId = "scimUserId_example";  // string | The unique identifier of the SCIM user.

            try
            {
                // Get SCIM provisioning information for a user
                SCIMUsers result = apiInstance.ScimGetProvisioningInformationForUser(org, scimUserId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScimApi.ScimGetProvisioningInformationForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **scimUserId** | **string**| The unique identifier of the SCIM user. | 

### Return type

[**SCIMUsers**](SCIMUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/scim+json, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scimlistprovisionedidentities"></a>
# **ScimListProvisionedIdentities**
> SCIMUserList ScimListProvisionedIdentities (string org, int? startIndex, int? count, string filter)

List SCIM provisioned identities

Retrieves a paginated list of all provisioned organization members, including pending invitations. If you provide the `filter` parameter, the resources for all matching provisions members are returned.  When a user with a SAML-provisioned external identity leaves (or is removed from) an organization, the account's metadata is immediately removed. However, the returned list of user accounts might not always match the organization or enterprise member list you see on GitHub. This can happen in certain cases where an external identity associated with an organization will not match an organization member:   - When a user with a SCIM-provisioned external identity is removed from an organization, the account's metadata is preserved to allow the user to re-join the organization in the future.   - When inviting a user to join an organization, you can expect to see their external identity in the results before they accept the invitation, or if the invitation is cancelled (or never accepted).   - When a user is invited over SCIM, an external identity is created that matches with the invitee's email address. However, this identity is only linked to a user account when the user accepts the invitation by going through SAML SSO.  The returned list of external identities can include an entry for a `null` user. These are unlinked SAML identities that are created when a user goes through the following Single Sign-On (SSO) process but does not sign in to their GitHub account after completing SSO:  1. The user is granted access by the IdP and is not a member of the GitHub organization.  1. The user attempts to access the GitHub organization and initiates the SAML SSO process, and is not currently signed in to their GitHub account.  1. After successfully authenticating with the SAML SSO IdP, the `null` external identity entry is created and the user is prompted to sign in to their GitHub account:    - If the user signs in, their GitHub account is linked to this entry.    - If the user does not sign in (or does not create a new account when prompted), they are not added to the GitHub organization, and the external identity `null` entry remains in place.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScimListProvisionedIdentitiesExample
    {
        public void main()
        {
            var apiInstance = new ScimApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var startIndex = 56;  // int? | Used for pagination: the index of the first result to return. (optional) 
            var count = 56;  // int? | Used for pagination: the number of results to return. (optional) 
            var filter = "filter_example";  // string | Filters results using the equals query parameter operator (`eq`). You can filter results that are equal to `id`, `userName`, `emails`, and `external_id`. For example, to search for an identity with the `userName` Octocat, you would use this query:  `?filter=userName%20eq%20\\\"Octocat\\\"`.  To filter results for the identity with the email `octocat@github.com`, you would use this query:  `?filter=emails%20eq%20\\\"octocat@github.com\\\"`. (optional) 

            try
            {
                // List SCIM provisioned identities
                SCIMUserList result = apiInstance.ScimListProvisionedIdentities(org, startIndex, count, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScimApi.ScimListProvisionedIdentities: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **startIndex** | **int?**| Used for pagination: the index of the first result to return. | [optional] 
 **count** | **int?**| Used for pagination: the number of results to return. | [optional] 
 **filter** | **string**| Filters results using the equals query parameter operator (&#x60;eq&#x60;). You can filter results that are equal to &#x60;id&#x60;, &#x60;userName&#x60;, &#x60;emails&#x60;, and &#x60;external_id&#x60;. For example, to search for an identity with the &#x60;userName&#x60; Octocat, you would use this query:  &#x60;?filter&#x3D;userName%20eq%20\\\&quot;Octocat\\\&quot;&#x60;.  To filter results for the identity with the email &#x60;octocat@github.com&#x60;, you would use this query:  &#x60;?filter&#x3D;emails%20eq%20\\\&quot;octocat@github.com\\\&quot;&#x60;. | [optional] 

### Return type

[**SCIMUserList**](SCIMUserList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/scim+json, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scimprovisionandinviteuser"></a>
# **ScimProvisionAndInviteUser**
> SCIMUsers ScimProvisionAndInviteUser (string org, ScimProvisionAndInviteUserRequest scimProvisionAndInviteUserRequest)

Provision and invite a SCIM user

Provision organization membership for a user, and send an activation email to the email address.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScimProvisionAndInviteUserExample
    {
        public void main()
        {
            var apiInstance = new ScimApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var scimProvisionAndInviteUserRequest = new ScimProvisionAndInviteUserRequest(); // ScimProvisionAndInviteUserRequest | 

            try
            {
                // Provision and invite a SCIM user
                SCIMUsers result = apiInstance.ScimProvisionAndInviteUser(org, scimProvisionAndInviteUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScimApi.ScimProvisionAndInviteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **scimProvisionAndInviteUserRequest** | [**ScimProvisionAndInviteUserRequest**](ScimProvisionAndInviteUserRequest.md)|  | 

### Return type

[**SCIMUsers**](SCIMUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/scim+json, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scimsetinformationforprovisioneduser"></a>
# **ScimSetInformationForProvisionedUser**
> SCIMUsers ScimSetInformationForProvisionedUser (string org, string scimUserId, ScimSetInformationForProvisionedUserRequest scimSetInformationForProvisionedUserRequest)

Update a provisioned organization membership

Replaces an existing provisioned user's information. You must provide all the information required for the user as if you were provisioning them for the first time. Any existing user information that you don't provide will be removed. If you want to only update a specific attribute, use the [Update an attribute for a SCIM user](https://docs.github.com/rest/reference/scim#update-an-attribute-for-a-scim-user) endpoint instead.  You must at least provide the required values for the user: `userName`, `name`, and `emails`.  **Warning:** Setting `active: false` removes the user from the organization, deletes the external identity, and deletes the associated `{scim_user_id}`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScimSetInformationForProvisionedUserExample
    {
        public void main()
        {
            var apiInstance = new ScimApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var scimUserId = "scimUserId_example";  // string | The unique identifier of the SCIM user.
            var scimSetInformationForProvisionedUserRequest = new ScimSetInformationForProvisionedUserRequest(); // ScimSetInformationForProvisionedUserRequest | 

            try
            {
                // Update a provisioned organization membership
                SCIMUsers result = apiInstance.ScimSetInformationForProvisionedUser(org, scimUserId, scimSetInformationForProvisionedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScimApi.ScimSetInformationForProvisionedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **scimUserId** | **string**| The unique identifier of the SCIM user. | 
 **scimSetInformationForProvisionedUserRequest** | [**ScimSetInformationForProvisionedUserRequest**](ScimSetInformationForProvisionedUserRequest.md)|  | 

### Return type

[**SCIMUsers**](SCIMUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/scim+json, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scimupdateattributeforuser"></a>
# **ScimUpdateAttributeForUser**
> SCIMUsers ScimUpdateAttributeForUser (string org, string scimUserId, ScimUpdateAttributeForUserRequest scimUpdateAttributeForUserRequest)

Update an attribute for a SCIM user

Allows you to change a provisioned user's individual attributes. To change a user's values, you must provide a specific `Operations` JSON format that contains at least one of the `add`, `remove`, or `replace` operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).  **Note:** Complicated SCIM `path` selectors that include filters are not supported. For example, a `path` selector defined as `\"path\": \"emails[type eq \\\"work\\\"]\"` will not work.  **Warning:** If you set `active:false` using the `replace` operation (as shown in the JSON example below), it removes the user from the organization, deletes the external identity, and deletes the associated `:scim_user_id`.  ``` {   \"Operations\":[{     \"op\":\"replace\",     \"value\":{       \"active\":false     }   }] } ```

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScimUpdateAttributeForUserExample
    {
        public void main()
        {
            var apiInstance = new ScimApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var scimUserId = "scimUserId_example";  // string | The unique identifier of the SCIM user.
            var scimUpdateAttributeForUserRequest = new ScimUpdateAttributeForUserRequest(); // ScimUpdateAttributeForUserRequest | 

            try
            {
                // Update an attribute for a SCIM user
                SCIMUsers result = apiInstance.ScimUpdateAttributeForUser(org, scimUserId, scimUpdateAttributeForUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScimApi.ScimUpdateAttributeForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **scimUserId** | **string**| The unique identifier of the SCIM user. | 
 **scimUpdateAttributeForUserRequest** | [**ScimUpdateAttributeForUserRequest**](ScimUpdateAttributeForUserRequest.md)|  | 

### Return type

[**SCIMUsers**](SCIMUsers.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/scim+json, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

