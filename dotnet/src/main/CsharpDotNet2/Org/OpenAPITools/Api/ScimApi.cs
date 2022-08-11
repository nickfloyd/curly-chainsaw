using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScimApi
    {
        /// <summary>
        /// Delete a SCIM user from an organization 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <returns></returns>
        void ScimDeleteUserFromOrg (string org, string scimUserId);
        /// <summary>
        /// Get SCIM provisioning information for a user 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <returns>SCIMUsers</returns>
        SCIMUsers ScimGetProvisioningInformationForUser (string org, string scimUserId);
        /// <summary>
        /// List SCIM provisioned identities Retrieves a paginated list of all provisioned organization members, including pending invitations. If you provide the &#x60;filter&#x60; parameter, the resources for all matching provisions members are returned.  When a user with a SAML-provisioned external identity leaves (or is removed from) an organization, the account&#39;s metadata is immediately removed. However, the returned list of user accounts might not always match the organization or enterprise member list you see on GitHub. This can happen in certain cases where an external identity associated with an organization will not match an organization member:   - When a user with a SCIM-provisioned external identity is removed from an organization, the account&#39;s metadata is preserved to allow the user to re-join the organization in the future.   - When inviting a user to join an organization, you can expect to see their external identity in the results before they accept the invitation, or if the invitation is cancelled (or never accepted).   - When a user is invited over SCIM, an external identity is created that matches with the invitee&#39;s email address. However, this identity is only linked to a user account when the user accepts the invitation by going through SAML SSO.  The returned list of external identities can include an entry for a &#x60;null&#x60; user. These are unlinked SAML identities that are created when a user goes through the following Single Sign-On (SSO) process but does not sign in to their GitHub account after completing SSO:  1. The user is granted access by the IdP and is not a member of the GitHub organization.  1. The user attempts to access the GitHub organization and initiates the SAML SSO process, and is not currently signed in to their GitHub account.  1. After successfully authenticating with the SAML SSO IdP, the &#x60;null&#x60; external identity entry is created and the user is prompted to sign in to their GitHub account:    - If the user signs in, their GitHub account is linked to this entry.    - If the user does not sign in (or does not create a new account when prompted), they are not added to the GitHub organization, and the external identity &#x60;null&#x60; entry remains in place.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="startIndex">Used for pagination: the index of the first result to return.</param>
        /// <param name="count">Used for pagination: the number of results to return.</param>
        /// <param name="filter">Filters results using the equals query parameter operator (&#x60;eq&#x60;). You can filter results that are equal to &#x60;id&#x60;, &#x60;userName&#x60;, &#x60;emails&#x60;, and &#x60;external_id&#x60;. For example, to search for an identity with the &#x60;userName&#x60; Octocat, you would use this query:  &#x60;?filter&#x3D;userName%20eq%20\\\&quot;Octocat\\\&quot;&#x60;.  To filter results for the identity with the email &#x60;octocat@github.com&#x60;, you would use this query:  &#x60;?filter&#x3D;emails%20eq%20\\\&quot;octocat@github.com\\\&quot;&#x60;.</param>
        /// <returns>SCIMUserList</returns>
        SCIMUserList ScimListProvisionedIdentities (string org, int? startIndex, int? count, string filter);
        /// <summary>
        /// Provision and invite a SCIM user Provision organization membership for a user, and send an activation email to the email address.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="scimProvisionAndInviteUserRequest"></param>
        /// <returns>SCIMUsers</returns>
        SCIMUsers ScimProvisionAndInviteUser (string org, ScimProvisionAndInviteUserRequest scimProvisionAndInviteUserRequest);
        /// <summary>
        /// Update a provisioned organization membership Replaces an existing provisioned user&#39;s information. You must provide all the information required for the user as if you were provisioning them for the first time. Any existing user information that you don&#39;t provide will be removed. If you want to only update a specific attribute, use the [Update an attribute for a SCIM user](https://docs.github.com/rest/reference/scim#update-an-attribute-for-a-scim-user) endpoint instead.  You must at least provide the required values for the user: &#x60;userName&#x60;, &#x60;name&#x60;, and &#x60;emails&#x60;.  **Warning:** Setting &#x60;active: false&#x60; removes the user from the organization, deletes the external identity, and deletes the associated &#x60;{scim_user_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <param name="scimSetInformationForProvisionedUserRequest"></param>
        /// <returns>SCIMUsers</returns>
        SCIMUsers ScimSetInformationForProvisionedUser (string org, string scimUserId, ScimSetInformationForProvisionedUserRequest scimSetInformationForProvisionedUserRequest);
        /// <summary>
        /// Update an attribute for a SCIM user Allows you to change a provisioned user&#39;s individual attributes. To change a user&#39;s values, you must provide a specific &#x60;Operations&#x60; JSON format that contains at least one of the &#x60;add&#x60;, &#x60;remove&#x60;, or &#x60;replace&#x60; operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).  **Note:** Complicated SCIM &#x60;path&#x60; selectors that include filters are not supported. For example, a &#x60;path&#x60; selector defined as &#x60;\&quot;path\&quot;: \&quot;emails[type eq \\\&quot;work\\\&quot;]\&quot;&#x60; will not work.  **Warning:** If you set &#x60;active:false&#x60; using the &#x60;replace&#x60; operation (as shown in the JSON example below), it removes the user from the organization, deletes the external identity, and deletes the associated &#x60;:scim_user_id&#x60;.  &#x60;&#x60;&#x60; {   \&quot;Operations\&quot;:[{     \&quot;op\&quot;:\&quot;replace\&quot;,     \&quot;value\&quot;:{       \&quot;active\&quot;:false     }   }] } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <param name="scimUpdateAttributeForUserRequest"></param>
        /// <returns>SCIMUsers</returns>
        SCIMUsers ScimUpdateAttributeForUser (string org, string scimUserId, ScimUpdateAttributeForUserRequest scimUpdateAttributeForUserRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ScimApi : IScimApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScimApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ScimApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScimApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}

        /// <summary>
        /// Delete a SCIM user from an organization 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <returns></returns>
        public void ScimDeleteUserFromOrg (string org, string scimUserId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ScimDeleteUserFromOrg");
            
            // verify the required parameter 'scimUserId' is set
            if (scimUserId == null) throw new ApiException(400, "Missing required parameter 'scimUserId' when calling ScimDeleteUserFromOrg");
            

            var path = "/scim/v2/organizations/{org}/Users/{scim_user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "scim_user_id" + "}", ApiClient.ParameterToString(scimUserId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScimDeleteUserFromOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScimDeleteUserFromOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get SCIM provisioning information for a user 
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <returns>SCIMUsers</returns>
        public SCIMUsers ScimGetProvisioningInformationForUser (string org, string scimUserId)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ScimGetProvisioningInformationForUser");
            
            // verify the required parameter 'scimUserId' is set
            if (scimUserId == null) throw new ApiException(400, "Missing required parameter 'scimUserId' when calling ScimGetProvisioningInformationForUser");
            

            var path = "/scim/v2/organizations/{org}/Users/{scim_user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "scim_user_id" + "}", ApiClient.ParameterToString(scimUserId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScimGetProvisioningInformationForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScimGetProvisioningInformationForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (SCIMUsers) ApiClient.Deserialize(response.Content, typeof(SCIMUsers), response.Headers);
        }

        /// <summary>
        /// List SCIM provisioned identities Retrieves a paginated list of all provisioned organization members, including pending invitations. If you provide the &#x60;filter&#x60; parameter, the resources for all matching provisions members are returned.  When a user with a SAML-provisioned external identity leaves (or is removed from) an organization, the account&#39;s metadata is immediately removed. However, the returned list of user accounts might not always match the organization or enterprise member list you see on GitHub. This can happen in certain cases where an external identity associated with an organization will not match an organization member:   - When a user with a SCIM-provisioned external identity is removed from an organization, the account&#39;s metadata is preserved to allow the user to re-join the organization in the future.   - When inviting a user to join an organization, you can expect to see their external identity in the results before they accept the invitation, or if the invitation is cancelled (or never accepted).   - When a user is invited over SCIM, an external identity is created that matches with the invitee&#39;s email address. However, this identity is only linked to a user account when the user accepts the invitation by going through SAML SSO.  The returned list of external identities can include an entry for a &#x60;null&#x60; user. These are unlinked SAML identities that are created when a user goes through the following Single Sign-On (SSO) process but does not sign in to their GitHub account after completing SSO:  1. The user is granted access by the IdP and is not a member of the GitHub organization.  1. The user attempts to access the GitHub organization and initiates the SAML SSO process, and is not currently signed in to their GitHub account.  1. After successfully authenticating with the SAML SSO IdP, the &#x60;null&#x60; external identity entry is created and the user is prompted to sign in to their GitHub account:    - If the user signs in, their GitHub account is linked to this entry.    - If the user does not sign in (or does not create a new account when prompted), they are not added to the GitHub organization, and the external identity &#x60;null&#x60; entry remains in place.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="startIndex">Used for pagination: the index of the first result to return.</param>
        /// <param name="count">Used for pagination: the number of results to return.</param>
        /// <param name="filter">Filters results using the equals query parameter operator (&#x60;eq&#x60;). You can filter results that are equal to &#x60;id&#x60;, &#x60;userName&#x60;, &#x60;emails&#x60;, and &#x60;external_id&#x60;. For example, to search for an identity with the &#x60;userName&#x60; Octocat, you would use this query:  &#x60;?filter&#x3D;userName%20eq%20\\\&quot;Octocat\\\&quot;&#x60;.  To filter results for the identity with the email &#x60;octocat@github.com&#x60;, you would use this query:  &#x60;?filter&#x3D;emails%20eq%20\\\&quot;octocat@github.com\\\&quot;&#x60;.</param>
        /// <returns>SCIMUserList</returns>
        public SCIMUserList ScimListProvisionedIdentities (string org, int? startIndex, int? count, string filter)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ScimListProvisionedIdentities");
            

            var path = "/scim/v2/organizations/{org}/Users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (startIndex != null) queryParams.Add("startIndex", ApiClient.ParameterToString(startIndex)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScimListProvisionedIdentities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScimListProvisionedIdentities: " + response.ErrorMessage, response.ErrorMessage);

            return (SCIMUserList) ApiClient.Deserialize(response.Content, typeof(SCIMUserList), response.Headers);
        }

        /// <summary>
        /// Provision and invite a SCIM user Provision organization membership for a user, and send an activation email to the email address.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="scimProvisionAndInviteUserRequest"></param>
        /// <returns>SCIMUsers</returns>
        public SCIMUsers ScimProvisionAndInviteUser (string org, ScimProvisionAndInviteUserRequest scimProvisionAndInviteUserRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ScimProvisionAndInviteUser");
            
            // verify the required parameter 'scimProvisionAndInviteUserRequest' is set
            if (scimProvisionAndInviteUserRequest == null) throw new ApiException(400, "Missing required parameter 'scimProvisionAndInviteUserRequest' when calling ScimProvisionAndInviteUser");
            

            var path = "/scim/v2/organizations/{org}/Users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(scimProvisionAndInviteUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScimProvisionAndInviteUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScimProvisionAndInviteUser: " + response.ErrorMessage, response.ErrorMessage);

            return (SCIMUsers) ApiClient.Deserialize(response.Content, typeof(SCIMUsers), response.Headers);
        }

        /// <summary>
        /// Update a provisioned organization membership Replaces an existing provisioned user&#39;s information. You must provide all the information required for the user as if you were provisioning them for the first time. Any existing user information that you don&#39;t provide will be removed. If you want to only update a specific attribute, use the [Update an attribute for a SCIM user](https://docs.github.com/rest/reference/scim#update-an-attribute-for-a-scim-user) endpoint instead.  You must at least provide the required values for the user: &#x60;userName&#x60;, &#x60;name&#x60;, and &#x60;emails&#x60;.  **Warning:** Setting &#x60;active: false&#x60; removes the user from the organization, deletes the external identity, and deletes the associated &#x60;{scim_user_id}&#x60;.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <param name="scimSetInformationForProvisionedUserRequest"></param>
        /// <returns>SCIMUsers</returns>
        public SCIMUsers ScimSetInformationForProvisionedUser (string org, string scimUserId, ScimSetInformationForProvisionedUserRequest scimSetInformationForProvisionedUserRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ScimSetInformationForProvisionedUser");
            
            // verify the required parameter 'scimUserId' is set
            if (scimUserId == null) throw new ApiException(400, "Missing required parameter 'scimUserId' when calling ScimSetInformationForProvisionedUser");
            
            // verify the required parameter 'scimSetInformationForProvisionedUserRequest' is set
            if (scimSetInformationForProvisionedUserRequest == null) throw new ApiException(400, "Missing required parameter 'scimSetInformationForProvisionedUserRequest' when calling ScimSetInformationForProvisionedUser");
            

            var path = "/scim/v2/organizations/{org}/Users/{scim_user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "scim_user_id" + "}", ApiClient.ParameterToString(scimUserId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(scimSetInformationForProvisionedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScimSetInformationForProvisionedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScimSetInformationForProvisionedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (SCIMUsers) ApiClient.Deserialize(response.Content, typeof(SCIMUsers), response.Headers);
        }

        /// <summary>
        /// Update an attribute for a SCIM user Allows you to change a provisioned user&#39;s individual attributes. To change a user&#39;s values, you must provide a specific &#x60;Operations&#x60; JSON format that contains at least one of the &#x60;add&#x60;, &#x60;remove&#x60;, or &#x60;replace&#x60; operations. For examples and more information on the SCIM operations format, see the [SCIM specification](https://tools.ietf.org/html/rfc7644#section-3.5.2).  **Note:** Complicated SCIM &#x60;path&#x60; selectors that include filters are not supported. For example, a &#x60;path&#x60; selector defined as &#x60;\&quot;path\&quot;: \&quot;emails[type eq \\\&quot;work\\\&quot;]\&quot;&#x60; will not work.  **Warning:** If you set &#x60;active:false&#x60; using the &#x60;replace&#x60; operation (as shown in the JSON example below), it removes the user from the organization, deletes the external identity, and deletes the associated &#x60;:scim_user_id&#x60;.  &#x60;&#x60;&#x60; {   \&quot;Operations\&quot;:[{     \&quot;op\&quot;:\&quot;replace\&quot;,     \&quot;value\&quot;:{       \&quot;active\&quot;:false     }   }] } &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="scimUserId">The unique identifier of the SCIM user.</param>
        /// <param name="scimUpdateAttributeForUserRequest"></param>
        /// <returns>SCIMUsers</returns>
        public SCIMUsers ScimUpdateAttributeForUser (string org, string scimUserId, ScimUpdateAttributeForUserRequest scimUpdateAttributeForUserRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ScimUpdateAttributeForUser");
            
            // verify the required parameter 'scimUserId' is set
            if (scimUserId == null) throw new ApiException(400, "Missing required parameter 'scimUserId' when calling ScimUpdateAttributeForUser");
            
            // verify the required parameter 'scimUpdateAttributeForUserRequest' is set
            if (scimUpdateAttributeForUserRequest == null) throw new ApiException(400, "Missing required parameter 'scimUpdateAttributeForUserRequest' when calling ScimUpdateAttributeForUser");
            

            var path = "/scim/v2/organizations/{org}/Users/{scim_user_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));
path = path.Replace("{" + "scim_user_id" + "}", ApiClient.ParameterToString(scimUserId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(scimUpdateAttributeForUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScimUpdateAttributeForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScimUpdateAttributeForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (SCIMUsers) ApiClient.Deserialize(response.Content, typeof(SCIMUsers), response.Headers);
        }

    }
}
