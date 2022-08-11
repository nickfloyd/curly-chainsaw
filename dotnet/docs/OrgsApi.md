# Org.OpenAPITools.Api.OrgsApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrgsAddSecurityManagerTeam**](OrgsApi.md#orgsaddsecuritymanagerteam) | **PUT** /orgs/{org}/security-managers/teams/{team_slug} | Add a security manager team
[**OrgsBlockUser**](OrgsApi.md#orgsblockuser) | **PUT** /orgs/{org}/blocks/{username} | Block a user from an organization
[**OrgsCancelInvitation**](OrgsApi.md#orgscancelinvitation) | **DELETE** /orgs/{org}/invitations/{invitation_id} | Cancel an organization invitation
[**OrgsCheckBlockedUser**](OrgsApi.md#orgscheckblockeduser) | **GET** /orgs/{org}/blocks/{username} | Check if a user is blocked by an organization
[**OrgsCheckMembershipForUser**](OrgsApi.md#orgscheckmembershipforuser) | **GET** /orgs/{org}/members/{username} | Check organization membership for a user
[**OrgsCheckPublicMembershipForUser**](OrgsApi.md#orgscheckpublicmembershipforuser) | **GET** /orgs/{org}/public_members/{username} | Check public organization membership for a user
[**OrgsConvertMemberToOutsideCollaborator**](OrgsApi.md#orgsconvertmembertooutsidecollaborator) | **PUT** /orgs/{org}/outside_collaborators/{username} | Convert an organization member to outside collaborator
[**OrgsCreateInvitation**](OrgsApi.md#orgscreateinvitation) | **POST** /orgs/{org}/invitations | Create an organization invitation
[**OrgsCreateWebhook**](OrgsApi.md#orgscreatewebhook) | **POST** /orgs/{org}/hooks | Create an organization webhook
[**OrgsDeleteWebhook**](OrgsApi.md#orgsdeletewebhook) | **DELETE** /orgs/{org}/hooks/{hook_id} | Delete an organization webhook
[**OrgsGet**](OrgsApi.md#orgsget) | **GET** /orgs/{org} | Get an organization
[**OrgsGetAuditLog**](OrgsApi.md#orgsgetauditlog) | **GET** /orgs/{org}/audit-log | Get the audit log for an organization
[**OrgsGetMembershipForAuthenticatedUser**](OrgsApi.md#orgsgetmembershipforauthenticateduser) | **GET** /user/memberships/orgs/{org} | Get an organization membership for the authenticated user
[**OrgsGetMembershipForUser**](OrgsApi.md#orgsgetmembershipforuser) | **GET** /orgs/{org}/memberships/{username} | Get organization membership for a user
[**OrgsGetWebhook**](OrgsApi.md#orgsgetwebhook) | **GET** /orgs/{org}/hooks/{hook_id} | Get an organization webhook
[**OrgsGetWebhookConfigForOrg**](OrgsApi.md#orgsgetwebhookconfigfororg) | **GET** /orgs/{org}/hooks/{hook_id}/config | Get a webhook configuration for an organization
[**OrgsGetWebhookDelivery**](OrgsApi.md#orgsgetwebhookdelivery) | **GET** /orgs/{org}/hooks/{hook_id}/deliveries/{delivery_id} | Get a webhook delivery for an organization webhook
[**OrgsList**](OrgsApi.md#orgslist) | **GET** /organizations | List organizations
[**OrgsListAppInstallations**](OrgsApi.md#orgslistappinstallations) | **GET** /orgs/{org}/installations | List app installations for an organization
[**OrgsListBlockedUsers**](OrgsApi.md#orgslistblockedusers) | **GET** /orgs/{org}/blocks | List users blocked by an organization
[**OrgsListCustomRoles**](OrgsApi.md#orgslistcustomroles) | **GET** /organizations/{organization_id}/custom_roles | List custom repository roles in an organization
[**OrgsListFailedInvitations**](OrgsApi.md#orgslistfailedinvitations) | **GET** /orgs/{org}/failed_invitations | List failed organization invitations
[**OrgsListForAuthenticatedUser**](OrgsApi.md#orgslistforauthenticateduser) | **GET** /user/orgs | List organizations for the authenticated user
[**OrgsListForUser**](OrgsApi.md#orgslistforuser) | **GET** /users/{username}/orgs | List organizations for a user
[**OrgsListInvitationTeams**](OrgsApi.md#orgslistinvitationteams) | **GET** /orgs/{org}/invitations/{invitation_id}/teams | List organization invitation teams
[**OrgsListMembers**](OrgsApi.md#orgslistmembers) | **GET** /orgs/{org}/members | List organization members
[**OrgsListMembershipsForAuthenticatedUser**](OrgsApi.md#orgslistmembershipsforauthenticateduser) | **GET** /user/memberships/orgs | List organization memberships for the authenticated user
[**OrgsListOutsideCollaborators**](OrgsApi.md#orgslistoutsidecollaborators) | **GET** /orgs/{org}/outside_collaborators | List outside collaborators for an organization
[**OrgsListPendingInvitations**](OrgsApi.md#orgslistpendinginvitations) | **GET** /orgs/{org}/invitations | List pending organization invitations
[**OrgsListPublicMembers**](OrgsApi.md#orgslistpublicmembers) | **GET** /orgs/{org}/public_members | List public organization members
[**OrgsListSamlSsoAuthorizations**](OrgsApi.md#orgslistsamlssoauthorizations) | **GET** /orgs/{org}/credential-authorizations | List SAML SSO authorizations for an organization
[**OrgsListSecurityManagerTeams**](OrgsApi.md#orgslistsecuritymanagerteams) | **GET** /orgs/{org}/security-managers | List security manager teams
[**OrgsListWebhookDeliveries**](OrgsApi.md#orgslistwebhookdeliveries) | **GET** /orgs/{org}/hooks/{hook_id}/deliveries | List deliveries for an organization webhook
[**OrgsListWebhooks**](OrgsApi.md#orgslistwebhooks) | **GET** /orgs/{org}/hooks | List organization webhooks
[**OrgsPingWebhook**](OrgsApi.md#orgspingwebhook) | **POST** /orgs/{org}/hooks/{hook_id}/pings | Ping an organization webhook
[**OrgsRedeliverWebhookDelivery**](OrgsApi.md#orgsredeliverwebhookdelivery) | **POST** /orgs/{org}/hooks/{hook_id}/deliveries/{delivery_id}/attempts | Redeliver a delivery for an organization webhook
[**OrgsRemoveMember**](OrgsApi.md#orgsremovemember) | **DELETE** /orgs/{org}/members/{username} | Remove an organization member
[**OrgsRemoveMembershipForUser**](OrgsApi.md#orgsremovemembershipforuser) | **DELETE** /orgs/{org}/memberships/{username} | Remove organization membership for a user
[**OrgsRemoveOutsideCollaborator**](OrgsApi.md#orgsremoveoutsidecollaborator) | **DELETE** /orgs/{org}/outside_collaborators/{username} | Remove outside collaborator from an organization
[**OrgsRemovePublicMembershipForAuthenticatedUser**](OrgsApi.md#orgsremovepublicmembershipforauthenticateduser) | **DELETE** /orgs/{org}/public_members/{username} | Remove public organization membership for the authenticated user
[**OrgsRemoveSamlSsoAuthorization**](OrgsApi.md#orgsremovesamlssoauthorization) | **DELETE** /orgs/{org}/credential-authorizations/{credential_id} | Remove a SAML SSO authorization for an organization
[**OrgsRemoveSecurityManagerTeam**](OrgsApi.md#orgsremovesecuritymanagerteam) | **DELETE** /orgs/{org}/security-managers/teams/{team_slug} | Remove a security manager team
[**OrgsSetMembershipForUser**](OrgsApi.md#orgssetmembershipforuser) | **PUT** /orgs/{org}/memberships/{username} | Set organization membership for a user
[**OrgsSetPublicMembershipForAuthenticatedUser**](OrgsApi.md#orgssetpublicmembershipforauthenticateduser) | **PUT** /orgs/{org}/public_members/{username} | Set public organization membership for the authenticated user
[**OrgsUnblockUser**](OrgsApi.md#orgsunblockuser) | **DELETE** /orgs/{org}/blocks/{username} | Unblock a user from an organization
[**OrgsUpdate**](OrgsApi.md#orgsupdate) | **PATCH** /orgs/{org} | Update an organization
[**OrgsUpdateMembershipForAuthenticatedUser**](OrgsApi.md#orgsupdatemembershipforauthenticateduser) | **PATCH** /user/memberships/orgs/{org} | Update an organization membership for the authenticated user
[**OrgsUpdateWebhook**](OrgsApi.md#orgsupdatewebhook) | **PATCH** /orgs/{org}/hooks/{hook_id} | Update an organization webhook
[**OrgsUpdateWebhookConfigForOrg**](OrgsApi.md#orgsupdatewebhookconfigfororg) | **PATCH** /orgs/{org}/hooks/{hook_id}/config | Update a webhook configuration for an organization


<a name="orgsaddsecuritymanagerteam"></a>
# **OrgsAddSecurityManagerTeam**
> void OrgsAddSecurityManagerTeam (string org, string teamSlug)

Add a security manager team

Adds a team as a security manager for an organization. For more information, see \"[Managing security for an organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization) for an organization.\"  To use this endpoint, you must be an administrator for the organization, and you must use an access token with the `write:org` scope.  GitHub Apps must have the `administration` organization read-write permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsAddSecurityManagerTeamExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.

            try
            {
                // Add a security manager team
                apiInstance.OrgsAddSecurityManagerTeam(org, teamSlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsAddSecurityManagerTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **teamSlug** | **string**| The slug of the team name. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsblockuser"></a>
# **OrgsBlockUser**
> void OrgsBlockUser (string org, string username)

Block a user from an organization



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsBlockUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Block a user from an organization
                apiInstance.OrgsBlockUser(org, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsBlockUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgscancelinvitation"></a>
# **OrgsCancelInvitation**
> void OrgsCancelInvitation (string org, int? invitationId)

Cancel an organization invitation

Cancel an organization invitation. In order to cancel an organization invitation, the authenticated user must be an organization owner.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsCancelInvitationExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var invitationId = 56;  // int? | The unique identifier of the invitation.

            try
            {
                // Cancel an organization invitation
                apiInstance.OrgsCancelInvitation(org, invitationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsCancelInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **invitationId** | **int?**| The unique identifier of the invitation. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgscheckblockeduser"></a>
# **OrgsCheckBlockedUser**
> void OrgsCheckBlockedUser (string org, string username)

Check if a user is blocked by an organization



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsCheckBlockedUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Check if a user is blocked by an organization
                apiInstance.OrgsCheckBlockedUser(org, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsCheckBlockedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgscheckmembershipforuser"></a>
# **OrgsCheckMembershipForUser**
> void OrgsCheckMembershipForUser (string org, string username)

Check organization membership for a user

Check if a user is, publicly or privately, a member of the organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsCheckMembershipForUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Check organization membership for a user
                apiInstance.OrgsCheckMembershipForUser(org, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsCheckMembershipForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgscheckpublicmembershipforuser"></a>
# **OrgsCheckPublicMembershipForUser**
> void OrgsCheckPublicMembershipForUser (string org, string username)

Check public organization membership for a user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsCheckPublicMembershipForUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Check public organization membership for a user
                apiInstance.OrgsCheckPublicMembershipForUser(org, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsCheckPublicMembershipForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsconvertmembertooutsidecollaborator"></a>
# **OrgsConvertMemberToOutsideCollaborator**
> Object OrgsConvertMemberToOutsideCollaborator (string org, string username, OrgsConvertMemberToOutsideCollaboratorRequest orgsConvertMemberToOutsideCollaboratorRequest)

Convert an organization member to outside collaborator

When an organization member is converted to an outside collaborator, they'll only have access to the repositories that their current team membership allows. The user will no longer be a member of the organization. For more information, see \"[Converting an organization member to an outside collaborator](https://docs.github.com/articles/converting-an-organization-member-to-an-outside-collaborator/)\". Converting an organization member to an outside collaborator may be restricted by enterprise administrators. For more information, see \"[Enforcing repository management policies in your enterprise](https://docs.github.com/enterprise-cloud@latest/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsConvertMemberToOutsideCollaboratorExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.
            var orgsConvertMemberToOutsideCollaboratorRequest = new OrgsConvertMemberToOutsideCollaboratorRequest(); // OrgsConvertMemberToOutsideCollaboratorRequest |  (optional) 

            try
            {
                // Convert an organization member to outside collaborator
                Object result = apiInstance.OrgsConvertMemberToOutsideCollaborator(org, username, orgsConvertMemberToOutsideCollaboratorRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsConvertMemberToOutsideCollaborator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 
 **orgsConvertMemberToOutsideCollaboratorRequest** | [**OrgsConvertMemberToOutsideCollaboratorRequest**](OrgsConvertMemberToOutsideCollaboratorRequest.md)|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgscreateinvitation"></a>
# **OrgsCreateInvitation**
> OrganizationInvitation OrgsCreateInvitation (string org, OrgsCreateInvitationRequest orgsCreateInvitationRequest)

Create an organization invitation

Invite people to an organization by using their GitHub user ID or their email address. In order to create invitations in an organization, the authenticated user must be an organization owner.  This endpoint triggers [notifications](https://docs.github.com/en/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. See \"[Secondary rate limits](https://docs.github.com/rest/overview/resources-in-the-rest-api#secondary-rate-limits)\" and \"[Dealing with secondary rate limits](https://docs.github.com/rest/guides/best-practices-for-integrators#dealing-with-secondary-rate-limits)\" for details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsCreateInvitationExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var orgsCreateInvitationRequest = new OrgsCreateInvitationRequest(); // OrgsCreateInvitationRequest |  (optional) 

            try
            {
                // Create an organization invitation
                OrganizationInvitation result = apiInstance.OrgsCreateInvitation(org, orgsCreateInvitationRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsCreateInvitation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **orgsCreateInvitationRequest** | [**OrgsCreateInvitationRequest**](OrgsCreateInvitationRequest.md)|  | [optional] 

### Return type

[**OrganizationInvitation**](OrganizationInvitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgscreatewebhook"></a>
# **OrgsCreateWebhook**
> OrgHook OrgsCreateWebhook (string org, OrgsCreateWebhookRequest orgsCreateWebhookRequest)

Create an organization webhook

Here's how you can create a hook that posts payloads in JSON format:

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsCreateWebhookExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var orgsCreateWebhookRequest = new OrgsCreateWebhookRequest(); // OrgsCreateWebhookRequest | 

            try
            {
                // Create an organization webhook
                OrgHook result = apiInstance.OrgsCreateWebhook(org, orgsCreateWebhookRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsCreateWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **orgsCreateWebhookRequest** | [**OrgsCreateWebhookRequest**](OrgsCreateWebhookRequest.md)|  | 

### Return type

[**OrgHook**](OrgHook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsdeletewebhook"></a>
# **OrgsDeleteWebhook**
> void OrgsDeleteWebhook (string org, int? hookId)

Delete an organization webhook



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsDeleteWebhookExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.

            try
            {
                // Delete an organization webhook
                apiInstance.OrgsDeleteWebhook(org, hookId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsDeleteWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **hookId** | **int?**| The unique identifier of the hook. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsget"></a>
# **OrgsGet**
> OrganizationFull OrgsGet (string org)

Get an organization

To see many of the organization response values, you need to be an authenticated organization owner with the `admin:org` scope. When the value of `two_factor_requirement_enabled` is `true`, the organization requires all members, billing managers, and outside collaborators to enable [two-factor authentication](https://docs.github.com/articles/securing-your-account-with-two-factor-authentication-2fa/).  GitHub Apps with the `Organization plan` permission can use this endpoint to retrieve information about an organization's GitHub plan. See \"[Authenticating with GitHub Apps](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/)\" for details. For an example response, see 'Response with GitHub plan information' below.\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsGetExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get an organization
                OrganizationFull result = apiInstance.OrgsGet(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsGet: " + e.Message );
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

[**OrganizationFull**](OrganizationFull.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsgetauditlog"></a>
# **OrgsGetAuditLog**
> List<EnterpriseAdminGetAuditLog200ResponseInner> OrgsGetAuditLog (string org, string phrase, string include, string after, string before, string order, int? perPage)

Get the audit log for an organization

Gets the audit log for an organization. For more information, see \"[Reviewing the audit log for your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization).\"  This endpoint is available for organizations on GitHub Enterprise Cloud. To use this endpoint, you must be an organization owner, and you must use an access token with the `admin:org` scope. GitHub Apps must have the `organization_administration` read permission to use this endpoint.  By default, the response includes up to 30 events from the past three months. Use the `phrase` parameter to filter results and retrieve older events. For example, use the `phrase` parameter with the `created` qualifier to filter events based on when the events occurred. For more information, see \"[Reviewing the audit log for your organization](https://docs.github.com/organizations/keeping-your-organization-secure/managing-security-settings-for-your-organization/reviewing-the-audit-log-for-your-organization#searching-the-audit-log).\"  Use pagination to retrieve fewer or more than 30 events. For more information, see \"[Resources in the REST API](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsGetAuditLogExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var phrase = "phrase_example";  // string | A search phrase. For more information, see [Searching the audit log](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log). (optional) 
            var include = "web";  // string | The event types to include:  - `web` - returns web (non-Git) events. - `git` - returns Git events. - `all` - returns both web and Git events.  The default is `web`. (optional) 
            var after = "after_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. (optional) 
            var before = "before_example";  // string | A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. (optional) 
            var order = "desc";  // string | The order of audit log events. To list newest events first, specify `desc`. To list oldest events first, specify `asc`.  The default is `desc`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)

            try
            {
                // Get the audit log for an organization
                List&lt;EnterpriseAdminGetAuditLog200ResponseInner&gt; result = apiInstance.OrgsGetAuditLog(org, phrase, include, after, before, order, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsGetAuditLog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **phrase** | **string**| A search phrase. For more information, see [Searching the audit log](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/reviewing-the-audit-log-for-your-organization#searching-the-audit-log). | [optional] 
 **include** | **string**| The event types to include:  - &#x60;web&#x60; - returns web (non-Git) events. - &#x60;git&#x60; - returns Git events. - &#x60;all&#x60; - returns both web and Git events.  The default is &#x60;web&#x60;. | [optional] 
 **after** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events after this cursor. | [optional] 
 **before** | **string**| A cursor, as given in the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header). If specified, the query only searches for events before this cursor. | [optional] 
 **order** | **string**| The order of audit log events. To list newest events first, specify &#x60;desc&#x60;. To list oldest events first, specify &#x60;asc&#x60;.  The default is &#x60;desc&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]

### Return type

[**List<EnterpriseAdminGetAuditLog200ResponseInner>**](EnterpriseAdminGetAuditLog200ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsgetmembershipforauthenticateduser"></a>
# **OrgsGetMembershipForAuthenticatedUser**
> OrgMembership OrgsGetMembershipForAuthenticatedUser (string org)

Get an organization membership for the authenticated user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsGetMembershipForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // Get an organization membership for the authenticated user
                OrgMembership result = apiInstance.OrgsGetMembershipForAuthenticatedUser(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsGetMembershipForAuthenticatedUser: " + e.Message );
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

[**OrgMembership**](OrgMembership.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsgetmembershipforuser"></a>
# **OrgsGetMembershipForUser**
> OrgMembership OrgsGetMembershipForUser (string org, string username)

Get organization membership for a user

In order to get a user's membership with an organization, the authenticated user must be an organization member. The `state` parameter in the response can be used to identify the user's membership status.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsGetMembershipForUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get organization membership for a user
                OrgMembership result = apiInstance.OrgsGetMembershipForUser(org, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsGetMembershipForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

[**OrgMembership**](OrgMembership.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsgetwebhook"></a>
# **OrgsGetWebhook**
> OrgHook OrgsGetWebhook (string org, int? hookId)

Get an organization webhook

Returns a webhook configured in an organization. To get only the webhook `config` properties, see \"[Get a webhook configuration for an organization](/rest/reference/orgs#get-a-webhook-configuration-for-an-organization).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsGetWebhookExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.

            try
            {
                // Get an organization webhook
                OrgHook result = apiInstance.OrgsGetWebhook(org, hookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsGetWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **hookId** | **int?**| The unique identifier of the hook. | 

### Return type

[**OrgHook**](OrgHook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsgetwebhookconfigfororg"></a>
# **OrgsGetWebhookConfigForOrg**
> WebhookConfiguration OrgsGetWebhookConfigForOrg (string org, int? hookId)

Get a webhook configuration for an organization

Returns the webhook configuration for an organization. To get more information about the webhook, including the `active` state and `events`, use \"[Get an organization webhook ](/rest/reference/orgs#get-an-organization-webhook).\"  Access tokens must have the `admin:org_hook` scope, and GitHub Apps must have the `organization_hooks:read` permission.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsGetWebhookConfigForOrgExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.

            try
            {
                // Get a webhook configuration for an organization
                WebhookConfiguration result = apiInstance.OrgsGetWebhookConfigForOrg(org, hookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsGetWebhookConfigForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **hookId** | **int?**| The unique identifier of the hook. | 

### Return type

[**WebhookConfiguration**](WebhookConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsgetwebhookdelivery"></a>
# **OrgsGetWebhookDelivery**
> WebhookDelivery OrgsGetWebhookDelivery (string org, int? hookId, int? deliveryId)

Get a webhook delivery for an organization webhook

Returns a delivery for a webhook configured in an organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsGetWebhookDeliveryExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.
            var deliveryId = 56;  // int? | 

            try
            {
                // Get a webhook delivery for an organization webhook
                WebhookDelivery result = apiInstance.OrgsGetWebhookDelivery(org, hookId, deliveryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsGetWebhookDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **hookId** | **int?**| The unique identifier of the hook. | 
 **deliveryId** | **int?**|  | 

### Return type

[**WebhookDelivery**](WebhookDelivery.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslist"></a>
# **OrgsList**
> List<OrganizationSimple> OrgsList (int? since, int? perPage)

List organizations

Lists all organizations, in the order that they were created on GitHub.  **Note:** Pagination is powered exclusively by the `since` parameter. Use the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header) to get the URL for the next page of organizations.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var since = 56;  // int? | An organization ID. Only return organizations with an ID greater than this ID. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)

            try
            {
                // List organizations
                List&lt;OrganizationSimple&gt; result = apiInstance.OrgsList(since, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **int?**| An organization ID. Only return organizations with an ID greater than this ID. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]

### Return type

[**List<OrganizationSimple>**](OrganizationSimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistappinstallations"></a>
# **OrgsListAppInstallations**
> OrgsListAppInstallations200Response OrgsListAppInstallations (string org, int? perPage, int? page)

List app installations for an organization

Lists all GitHub Apps in an organization. The installation count includes all GitHub Apps installed on repositories in the organization. You must be an organization owner with `admin:read` scope to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListAppInstallationsExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List app installations for an organization
                OrgsListAppInstallations200Response result = apiInstance.OrgsListAppInstallations(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListAppInstallations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**OrgsListAppInstallations200Response**](OrgsListAppInstallations200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistblockedusers"></a>
# **OrgsListBlockedUsers**
> List<SimpleUser1> OrgsListBlockedUsers (string org)

List users blocked by an organization

List the users blocked by an organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListBlockedUsersExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // List users blocked by an organization
                List&lt;SimpleUser1&gt; result = apiInstance.OrgsListBlockedUsers(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListBlockedUsers: " + e.Message );
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

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistcustomroles"></a>
# **OrgsListCustomRoles**
> OrgsListCustomRoles200Response OrgsListCustomRoles (string organizationId)

List custom repository roles in an organization

List the custom repository roles available in this organization. In order to see custom repository roles in an organization, the authenticated user must be an organization owner.  For more information on custom repository roles, see \"[Managing custom repository roles for an organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-custom-repository-roles-for-an-organization)\".

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListCustomRolesExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var organizationId = "organizationId_example";  // string | 

            try
            {
                // List custom repository roles in an organization
                OrgsListCustomRoles200Response result = apiInstance.OrgsListCustomRoles(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListCustomRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 

### Return type

[**OrgsListCustomRoles200Response**](OrgsListCustomRoles200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistfailedinvitations"></a>
# **OrgsListFailedInvitations**
> List<OrganizationInvitation> OrgsListFailedInvitations (string org, int? perPage, int? page)

List failed organization invitations

The return hash contains `failed_at` and `failed_reason` fields which represent the time at which the invitation failed and the reason for the failure.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListFailedInvitationsExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List failed organization invitations
                List&lt;OrganizationInvitation&gt; result = apiInstance.OrgsListFailedInvitations(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListFailedInvitations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<OrganizationInvitation>**](OrganizationInvitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistforauthenticateduser"></a>
# **OrgsListForAuthenticatedUser**
> List<OrganizationSimple> OrgsListForAuthenticatedUser (int? perPage, int? page)

List organizations for the authenticated user

List organizations for the authenticated user.  **OAuth scope requirements**  This only lists organizations that your authorization allows you to operate on in some way (e.g., you can list teams with `read:org` scope, you can publicize your organization membership with `user` scope, etc.). Therefore, this API requires at least `user` or `read:org` scope. OAuth requests with insufficient scope receive a `403 Forbidden` response.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organizations for the authenticated user
                List&lt;OrganizationSimple&gt; result = apiInstance.OrgsListForAuthenticatedUser(perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<OrganizationSimple>**](OrganizationSimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistforuser"></a>
# **OrgsListForUser**
> List<OrganizationSimple> OrgsListForUser (string username, int? perPage, int? page)

List organizations for a user

List [public organization memberships](https://docs.github.com/articles/publicizing-or-concealing-organization-membership) for the specified user.  This method only lists _public_ memberships, regardless of authentication. If you need to fetch all of the organization memberships (public and private) for the authenticated user, use the [List organizations for the authenticated user](https://docs.github.com/rest/reference/orgs#list-organizations-for-the-authenticated-user) API instead.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListForUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organizations for a user
                List&lt;OrganizationSimple&gt; result = apiInstance.OrgsListForUser(username, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<OrganizationSimple>**](OrganizationSimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistinvitationteams"></a>
# **OrgsListInvitationTeams**
> List<Team> OrgsListInvitationTeams (string org, int? invitationId, int? perPage, int? page)

List organization invitation teams

List all teams associated with an invitation. In order to see invitations in an organization, the authenticated user must be an organization owner.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListInvitationTeamsExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var invitationId = 56;  // int? | The unique identifier of the invitation.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organization invitation teams
                List&lt;Team&gt; result = apiInstance.OrgsListInvitationTeams(org, invitationId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListInvitationTeams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **invitationId** | **int?**| The unique identifier of the invitation. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Team>**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistmembers"></a>
# **OrgsListMembers**
> List<SimpleUser1> OrgsListMembers (string org, string filter, string role, int? perPage, int? page)

List organization members

List all users who are members of an organization. If the authenticated user is also a member of this organization then both concealed and public members will be returned.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListMembersExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var filter = "2fa_disabled";  // string | Filter members returned in the list. `2fa_disabled` means that only members without [two-factor authentication](https://github.com/blog/1614-two-factor-authentication) enabled will be returned. This options is only available for organization owners. (optional)  (default to all)
            var role = "all";  // string | Filter members returned by their role. (optional)  (default to all)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organization members
                List&lt;SimpleUser1&gt; result = apiInstance.OrgsListMembers(org, filter, role, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **filter** | **string**| Filter members returned in the list. &#x60;2fa_disabled&#x60; means that only members without [two-factor authentication](https://github.com/blog/1614-two-factor-authentication) enabled will be returned. This options is only available for organization owners. | [optional] [default to all]
 **role** | **string**| Filter members returned by their role. | [optional] [default to all]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistmembershipsforauthenticateduser"></a>
# **OrgsListMembershipsForAuthenticatedUser**
> List<OrgMembership> OrgsListMembershipsForAuthenticatedUser (string state, int? perPage, int? page)

List organization memberships for the authenticated user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListMembershipsForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var state = "active";  // string | Indicates the state of the memberships to return. Can be either `active` or `pending`. If not specified, the API returns both active and pending memberships. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organization memberships for the authenticated user
                List&lt;OrgMembership&gt; result = apiInstance.OrgsListMembershipsForAuthenticatedUser(state, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListMembershipsForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **state** | **string**| Indicates the state of the memberships to return. Can be either &#x60;active&#x60; or &#x60;pending&#x60;. If not specified, the API returns both active and pending memberships. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<OrgMembership>**](OrgMembership.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistoutsidecollaborators"></a>
# **OrgsListOutsideCollaborators**
> List<SimpleUser1> OrgsListOutsideCollaborators (string org, string filter, int? perPage, int? page)

List outside collaborators for an organization

List all users who are outside collaborators of an organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListOutsideCollaboratorsExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var filter = "2fa_disabled";  // string | Filter the list of outside collaborators. `2fa_disabled` means that only outside collaborators without [two-factor authentication](https://github.com/blog/1614-two-factor-authentication) enabled will be returned. (optional)  (default to all)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List outside collaborators for an organization
                List&lt;SimpleUser1&gt; result = apiInstance.OrgsListOutsideCollaborators(org, filter, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListOutsideCollaborators: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **filter** | **string**| Filter the list of outside collaborators. &#x60;2fa_disabled&#x60; means that only outside collaborators without [two-factor authentication](https://github.com/blog/1614-two-factor-authentication) enabled will be returned. | [optional] [default to all]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistpendinginvitations"></a>
# **OrgsListPendingInvitations**
> List<OrganizationInvitation> OrgsListPendingInvitations (string org, int? perPage, int? page)

List pending organization invitations

The return hash contains a `role` field which refers to the Organization Invitation role and will be one of the following values: `direct_member`, `admin`, `billing_manager`, `hiring_manager`, or `reinstate`. If the invitee is not a GitHub member, the `login` field in the return hash will be `null`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListPendingInvitationsExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List pending organization invitations
                List&lt;OrganizationInvitation&gt; result = apiInstance.OrgsListPendingInvitations(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListPendingInvitations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<OrganizationInvitation>**](OrganizationInvitation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistpublicmembers"></a>
# **OrgsListPublicMembers**
> List<SimpleUser1> OrgsListPublicMembers (string org, int? perPage, int? page)

List public organization members

Members of an organization can choose to have their membership publicized or not.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListPublicMembersExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List public organization members
                List&lt;SimpleUser1&gt; result = apiInstance.OrgsListPublicMembers(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListPublicMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<SimpleUser1>**](SimpleUser1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistsamlssoauthorizations"></a>
# **OrgsListSamlSsoAuthorizations**
> List<CredentialAuthorization> OrgsListSamlSsoAuthorizations (string org, int? perPage, int? page, string login)

List SAML SSO authorizations for an organization

Listing and deleting credential authorizations is available to organizations with GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).  An authenticated organization owner with the `read:org` scope can list all credential authorizations for an organization that uses SAML single sign-on (SSO). The credentials are either personal access tokens or SSH keys that organization members have authorized for the organization. For more information, see [About authentication with SAML single sign-on](https://docs.github.com/en/articles/about-authentication-with-saml-single-sign-on).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListSamlSsoAuthorizationsExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 56;  // int? | Page token (optional) 
            var login = "login_example";  // string | Limits the list of credentials authorizations for an organization to a specific login (optional) 

            try
            {
                // List SAML SSO authorizations for an organization
                List&lt;CredentialAuthorization&gt; result = apiInstance.OrgsListSamlSsoAuthorizations(org, perPage, page, login);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListSamlSsoAuthorizations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page token | [optional] 
 **login** | **string**| Limits the list of credentials authorizations for an organization to a specific login | [optional] 

### Return type

[**List<CredentialAuthorization>**](CredentialAuthorization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistsecuritymanagerteams"></a>
# **OrgsListSecurityManagerTeams**
> List<TeamSimple1> OrgsListSecurityManagerTeams (string org)

List security manager teams

Lists teams that are security managers for an organization. For more information, see \"[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).\"  To use this endpoint, you must be an administrator or security manager for the organization, and you must use an access token with the `read:org` scope.  GitHub Apps must have the `administration` organization read permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListSecurityManagerTeamsExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.

            try
            {
                // List security manager teams
                List&lt;TeamSimple1&gt; result = apiInstance.OrgsListSecurityManagerTeams(org);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListSecurityManagerTeams: " + e.Message );
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

[**List<TeamSimple1>**](TeamSimple1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistwebhookdeliveries"></a>
# **OrgsListWebhookDeliveries**
> List<SimpleWebhookDelivery> OrgsListWebhookDeliveries (string org, int? hookId, int? perPage, string cursor)

List deliveries for an organization webhook

Returns a list of webhook deliveries for a webhook configured in an organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListWebhookDeliveriesExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var cursor = "cursor_example";  // string | Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the `link` header for the next and previous page cursors. (optional) 

            try
            {
                // List deliveries for an organization webhook
                List&lt;SimpleWebhookDelivery&gt; result = apiInstance.OrgsListWebhookDeliveries(org, hookId, perPage, cursor);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListWebhookDeliveries: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **hookId** | **int?**| The unique identifier of the hook. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **cursor** | **string**| Used for pagination: the starting delivery from which the page of deliveries is fetched. Refer to the &#x60;link&#x60; header for the next and previous page cursors. | [optional] 

### Return type

[**List<SimpleWebhookDelivery>**](SimpleWebhookDelivery.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgslistwebhooks"></a>
# **OrgsListWebhooks**
> List<OrgHook> OrgsListWebhooks (string org, int? perPage, int? page)

List organization webhooks



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsListWebhooksExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organization webhooks
                List&lt;OrgHook&gt; result = apiInstance.OrgsListWebhooks(org, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsListWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<OrgHook>**](OrgHook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgspingwebhook"></a>
# **OrgsPingWebhook**
> void OrgsPingWebhook (string org, int? hookId)

Ping an organization webhook

This will trigger a [ping event](https://docs.github.com/webhooks/#ping-event) to be sent to the hook.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsPingWebhookExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.

            try
            {
                // Ping an organization webhook
                apiInstance.OrgsPingWebhook(org, hookId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsPingWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **hookId** | **int?**| The unique identifier of the hook. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsredeliverwebhookdelivery"></a>
# **OrgsRedeliverWebhookDelivery**
> Object OrgsRedeliverWebhookDelivery (string org, int? hookId, int? deliveryId)

Redeliver a delivery for an organization webhook

Redeliver a delivery for a webhook configured in an organization.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsRedeliverWebhookDeliveryExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.
            var deliveryId = 56;  // int? | 

            try
            {
                // Redeliver a delivery for an organization webhook
                Object result = apiInstance.OrgsRedeliverWebhookDelivery(org, hookId, deliveryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsRedeliverWebhookDelivery: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **hookId** | **int?**| The unique identifier of the hook. | 
 **deliveryId** | **int?**|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/scim+json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsremovemember"></a>
# **OrgsRemoveMember**
> void OrgsRemoveMember (string org, string username)

Remove an organization member

Removing a user from this list will remove them from all teams and they will no longer have any access to the organization's repositories.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsRemoveMemberExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Remove an organization member
                apiInstance.OrgsRemoveMember(org, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsRemoveMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsremovemembershipforuser"></a>
# **OrgsRemoveMembershipForUser**
> void OrgsRemoveMembershipForUser (string org, string username)

Remove organization membership for a user

In order to remove a user's membership with an organization, the authenticated user must be an organization owner.  If the specified user is an active member of the organization, this will remove them from the organization. If the specified user has been invited to the organization, this will cancel their invitation. The specified user will receive an email notification in both cases.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsRemoveMembershipForUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Remove organization membership for a user
                apiInstance.OrgsRemoveMembershipForUser(org, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsRemoveMembershipForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsremoveoutsidecollaborator"></a>
# **OrgsRemoveOutsideCollaborator**
> void OrgsRemoveOutsideCollaborator (string org, string username)

Remove outside collaborator from an organization

Removing a user from this list will remove them from all the organization's repositories.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsRemoveOutsideCollaboratorExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Remove outside collaborator from an organization
                apiInstance.OrgsRemoveOutsideCollaborator(org, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsRemoveOutsideCollaborator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsremovepublicmembershipforauthenticateduser"></a>
# **OrgsRemovePublicMembershipForAuthenticatedUser**
> void OrgsRemovePublicMembershipForAuthenticatedUser (string org, string username)

Remove public organization membership for the authenticated user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsRemovePublicMembershipForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Remove public organization membership for the authenticated user
                apiInstance.OrgsRemovePublicMembershipForAuthenticatedUser(org, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsRemovePublicMembershipForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsremovesamlssoauthorization"></a>
# **OrgsRemoveSamlSsoAuthorization**
> void OrgsRemoveSamlSsoAuthorization (string org, int? credentialId)

Remove a SAML SSO authorization for an organization

Listing and deleting credential authorizations is available to organizations with GitHub Enterprise Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products).  An authenticated organization owner with the `admin:org` scope can remove a credential authorization for an organization that uses SAML SSO. Once you remove someone's credential authorization, they will need to create a new personal access token or SSH key and authorize it for the organization they want to access.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsRemoveSamlSsoAuthorizationExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var credentialId = 56;  // int? | 

            try
            {
                // Remove a SAML SSO authorization for an organization
                apiInstance.OrgsRemoveSamlSsoAuthorization(org, credentialId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsRemoveSamlSsoAuthorization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **credentialId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsremovesecuritymanagerteam"></a>
# **OrgsRemoveSecurityManagerTeam**
> void OrgsRemoveSecurityManagerTeam (string org, string teamSlug)

Remove a security manager team

Removes the security manager role from a team for an organization. For more information, see \"[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization) team from an organization.\"  To use this endpoint, you must be an administrator for the organization, and you must use an access token with the `admin:org` scope.  GitHub Apps must have the `administration` organization read-write permission to use this endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsRemoveSecurityManagerTeamExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var teamSlug = "teamSlug_example";  // string | The slug of the team name.

            try
            {
                // Remove a security manager team
                apiInstance.OrgsRemoveSecurityManagerTeam(org, teamSlug);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsRemoveSecurityManagerTeam: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **teamSlug** | **string**| The slug of the team name. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgssetmembershipforuser"></a>
# **OrgsSetMembershipForUser**
> OrgMembership OrgsSetMembershipForUser (string org, string username, OrgsSetMembershipForUserRequest orgsSetMembershipForUserRequest)

Set organization membership for a user

Only authenticated organization owners can add a member to the organization or update the member's role.  *   If the authenticated user is _adding_ a member to the organization, the invited user will receive an email inviting them to the organization. The user's [membership status](https://docs.github.com/rest/reference/orgs#get-organization-membership-for-a-user) will be `pending` until they accept the invitation.      *   Authenticated users can _update_ a user's membership by passing the `role` parameter. If the authenticated user changes a member's role to `admin`, the affected user will receive an email notifying them that they've been made an organization owner. If the authenticated user changes an owner's role to `member`, no email will be sent.  **Rate limits**  To prevent abuse, the authenticated user is limited to 50 organization invitations per 24 hour period. If the organization is more than one month old or on a paid plan, the limit is 500 invitations per 24 hour period.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsSetMembershipForUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.
            var orgsSetMembershipForUserRequest = new OrgsSetMembershipForUserRequest(); // OrgsSetMembershipForUserRequest |  (optional) 

            try
            {
                // Set organization membership for a user
                OrgMembership result = apiInstance.OrgsSetMembershipForUser(org, username, orgsSetMembershipForUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsSetMembershipForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 
 **orgsSetMembershipForUserRequest** | [**OrgsSetMembershipForUserRequest**](OrgsSetMembershipForUserRequest.md)|  | [optional] 

### Return type

[**OrgMembership**](OrgMembership.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgssetpublicmembershipforauthenticateduser"></a>
# **OrgsSetPublicMembershipForAuthenticatedUser**
> void OrgsSetPublicMembershipForAuthenticatedUser (string org, string username)

Set public organization membership for the authenticated user

The user can publicize their own membership. (A user cannot publicize the membership for another user.)  Note that you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see \"[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsSetPublicMembershipForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Set public organization membership for the authenticated user
                apiInstance.OrgsSetPublicMembershipForAuthenticatedUser(org, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsSetPublicMembershipForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsunblockuser"></a>
# **OrgsUnblockUser**
> void OrgsUnblockUser (string org, string username)

Unblock a user from an organization



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsUnblockUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Unblock a user from an organization
                apiInstance.OrgsUnblockUser(org, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsUnblockUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsupdate"></a>
# **OrgsUpdate**
> OrganizationFull OrgsUpdate (string org, OrgsUpdateRequest orgsUpdateRequest)

Update an organization

**Parameter Deprecation Notice:** GitHub will replace and discontinue `members_allowed_repository_creation_type` in favor of more granular permissions. The new input parameters are `members_can_create_public_repositories`, `members_can_create_private_repositories` for all organizations and `members_can_create_internal_repositories` for organizations associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see the [blog post](https://developer.github.com/changes/2019-12-03-internal-visibility-changes).  Enables an authenticated organization owner with the `admin:org` scope to update the organization's profile and member privileges.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsUpdateExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var orgsUpdateRequest = new OrgsUpdateRequest(); // OrgsUpdateRequest |  (optional) 

            try
            {
                // Update an organization
                OrganizationFull result = apiInstance.OrgsUpdate(org, orgsUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **orgsUpdateRequest** | [**OrgsUpdateRequest**](OrgsUpdateRequest.md)|  | [optional] 

### Return type

[**OrganizationFull**](OrganizationFull.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsupdatemembershipforauthenticateduser"></a>
# **OrgsUpdateMembershipForAuthenticatedUser**
> OrgMembership OrgsUpdateMembershipForAuthenticatedUser (string org, OrgsUpdateMembershipForAuthenticatedUserRequest orgsUpdateMembershipForAuthenticatedUserRequest)

Update an organization membership for the authenticated user



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsUpdateMembershipForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var orgsUpdateMembershipForAuthenticatedUserRequest = new OrgsUpdateMembershipForAuthenticatedUserRequest(); // OrgsUpdateMembershipForAuthenticatedUserRequest | 

            try
            {
                // Update an organization membership for the authenticated user
                OrgMembership result = apiInstance.OrgsUpdateMembershipForAuthenticatedUser(org, orgsUpdateMembershipForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsUpdateMembershipForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **orgsUpdateMembershipForAuthenticatedUserRequest** | [**OrgsUpdateMembershipForAuthenticatedUserRequest**](OrgsUpdateMembershipForAuthenticatedUserRequest.md)|  | 

### Return type

[**OrgMembership**](OrgMembership.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsupdatewebhook"></a>
# **OrgsUpdateWebhook**
> OrgHook OrgsUpdateWebhook (string org, int? hookId, OrgsUpdateWebhookRequest orgsUpdateWebhookRequest)

Update an organization webhook

Updates a webhook configured in an organization. When you update a webhook, the `secret` will be overwritten. If you previously had a `secret` set, you must provide the same `secret` or set a new `secret` or the secret will be removed. If you are only updating individual webhook `config` properties, use \"[Update a webhook configuration for an organization](/rest/reference/orgs#update-a-webhook-configuration-for-an-organization).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsUpdateWebhookExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.
            var orgsUpdateWebhookRequest = new OrgsUpdateWebhookRequest(); // OrgsUpdateWebhookRequest |  (optional) 

            try
            {
                // Update an organization webhook
                OrgHook result = apiInstance.OrgsUpdateWebhook(org, hookId, orgsUpdateWebhookRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsUpdateWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **hookId** | **int?**| The unique identifier of the hook. | 
 **orgsUpdateWebhookRequest** | [**OrgsUpdateWebhookRequest**](OrgsUpdateWebhookRequest.md)|  | [optional] 

### Return type

[**OrgHook**](OrgHook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orgsupdatewebhookconfigfororg"></a>
# **OrgsUpdateWebhookConfigForOrg**
> WebhookConfiguration OrgsUpdateWebhookConfigForOrg (string org, int? hookId, AppsUpdateWebhookConfigForAppRequest appsUpdateWebhookConfigForAppRequest)

Update a webhook configuration for an organization

Updates the webhook configuration for an organization. To update more information about the webhook, including the `active` state and `events`, use \"[Update an organization webhook ](/rest/reference/orgs#update-an-organization-webhook).\"  Access tokens must have the `admin:org_hook` scope, and GitHub Apps must have the `organization_hooks:write` permission.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OrgsUpdateWebhookConfigForOrgExample
    {
        public void main()
        {
            var apiInstance = new OrgsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var hookId = 56;  // int? | The unique identifier of the hook.
            var appsUpdateWebhookConfigForAppRequest = new AppsUpdateWebhookConfigForAppRequest(); // AppsUpdateWebhookConfigForAppRequest |  (optional) 

            try
            {
                // Update a webhook configuration for an organization
                WebhookConfiguration result = apiInstance.OrgsUpdateWebhookConfigForOrg(org, hookId, appsUpdateWebhookConfigForAppRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrgsApi.OrgsUpdateWebhookConfigForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **hookId** | **int?**| The unique identifier of the hook. | 
 **appsUpdateWebhookConfigForAppRequest** | [**AppsUpdateWebhookConfigForAppRequest**](AppsUpdateWebhookConfigForAppRequest.md)|  | [optional] 

### Return type

[**WebhookConfiguration**](WebhookConfiguration.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

