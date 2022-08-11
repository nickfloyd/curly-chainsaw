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
    public interface IUsersApi
    {
        /// <summary>
        /// Add an email address for the authenticated user This endpoint is accessible with the &#x60;user&#x60; scope.
        /// </summary>
        /// <param name="usersAddEmailForAuthenticatedUserRequest"></param>
        /// <returns>List&lt;Email&gt;</returns>
        List<Email> UsersAddEmailForAuthenticatedUser (UsersAddEmailForAuthenticatedUserRequest usersAddEmailForAuthenticatedUserRequest);
        /// <summary>
        /// Block a user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void UsersBlock (string username);
        /// <summary>
        /// Check if a user is blocked by the authenticated user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void UsersCheckBlocked (string username);
        /// <summary>
        /// Check if a user follows another user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="targetUser"></param>
        /// <returns></returns>
        void UsersCheckFollowingForUser (string username, string targetUser);
        /// <summary>
        /// Check if a person is followed by the authenticated user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void UsersCheckPersonIsFollowedByAuthenticated (string username);
        /// <summary>
        /// Create a GPG key for the authenticated user Adds a GPG key to the authenticated user&#39;s GitHub account. Requires that you are authenticated via Basic Auth, or OAuth with at least &#x60;write:gpg_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="usersCreateGpgKeyForAuthenticatedUserRequest"></param>
        /// <returns>GPGKey</returns>
        GPGKey UsersCreateGpgKeyForAuthenticatedUser (UsersCreateGpgKeyForAuthenticatedUserRequest usersCreateGpgKeyForAuthenticatedUserRequest);
        /// <summary>
        /// Create a public SSH key for the authenticated user Adds a public SSH key to the authenticated user&#39;s GitHub account. Requires that you are authenticated via Basic Auth, or OAuth with at least &#x60;write:public_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="usersCreatePublicSshKeyForAuthenticatedUserRequest"></param>
        /// <returns>Key</returns>
        Key UsersCreatePublicSshKeyForAuthenticatedUser (UsersCreatePublicSshKeyForAuthenticatedUserRequest usersCreatePublicSshKeyForAuthenticatedUserRequest);
        /// <summary>
        /// Delete an email address for the authenticated user This endpoint is accessible with the &#x60;user&#x60; scope.
        /// </summary>
        /// <param name="usersDeleteEmailForAuthenticatedUserRequest"></param>
        /// <returns></returns>
        void UsersDeleteEmailForAuthenticatedUser (UsersDeleteEmailForAuthenticatedUserRequest usersDeleteEmailForAuthenticatedUserRequest);
        /// <summary>
        /// Delete a GPG key for the authenticated user Removes a GPG key from the authenticated user&#39;s GitHub account. Requires that you are authenticated via Basic Auth or via OAuth with at least &#x60;admin:gpg_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="gpgKeyId">The unique identifier of the GPG key.</param>
        /// <returns></returns>
        void UsersDeleteGpgKeyForAuthenticatedUser (int? gpgKeyId);
        /// <summary>
        /// Delete a public SSH key for the authenticated user Removes a public SSH key from the authenticated user&#39;s GitHub account. Requires that you are authenticated via Basic Auth or via OAuth with at least &#x60;admin:public_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="keyId">The unique identifier of the key.</param>
        /// <returns></returns>
        void UsersDeletePublicSshKeyForAuthenticatedUser (int? keyId);
        /// <summary>
        /// Follow a user Note that you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;  Following a user requires the user to be logged in and authenticated with basic auth or OAuth with the &#x60;user:follow&#x60; scope.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void UsersFollow (string username);
        /// <summary>
        /// Get the authenticated user If the authenticated user is authenticated through basic authentication or OAuth with the &#x60;user&#x60; scope, then the response lists public and private profile information.  If the authenticated user is authenticated through OAuth without the &#x60;user&#x60; scope, then the response lists only public profile information.
        /// </summary>
        /// <returns>UsersGetAuthenticated200Response</returns>
        UsersGetAuthenticated200Response UsersGetAuthenticated ();
        /// <summary>
        /// Get a user Provides publicly available information about someone with a GitHub account.  GitHub Apps with the &#x60;Plan&#x60; user permission can use this endpoint to retrieve information about a user&#39;s GitHub plan. The GitHub App must be authenticated as a user. See \&quot;[Identifying and authorizing users for GitHub Apps](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/)\&quot; for details about authentication. For an example response, see &#39;Response with GitHub plan information&#39; below\&quot;  The &#x60;email&#x60; key in the following response is the publicly visible email address from your GitHub [profile page](https://github.com/settings/profile). When setting up your profile, you can select a primary email address to be “public” which provides an email entry for this endpoint. If you do not set a public email address for &#x60;email&#x60;, then it will have a value of &#x60;null&#x60;. You only see publicly visible email addresses when authenticated with GitHub. For more information, see [Authentication](https://docs.github.com/rest/overview/resources-in-the-rest-api#authentication).  The Emails API enables you to list all of your email addresses, and toggle a primary email to be visible publicly. For more information, see \&quot;[Emails API](https://docs.github.com/rest/reference/users#emails)\&quot;.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>UsersGetAuthenticated200Response</returns>
        UsersGetAuthenticated200Response UsersGetByUsername (string username);
        /// <summary>
        /// Get contextual information for a user Provides hovercard information when authenticated through basic auth or OAuth with the &#x60;repo&#x60; scope. You can find out more about someone in relation to their pull requests, issues, repositories, and organizations.  The &#x60;subject_type&#x60; and &#x60;subject_id&#x60; parameters provide context for the person&#39;s hovercard, which returns more information than without the parameters. For example, if you wanted to find out more about &#x60;octocat&#x60; who owns the &#x60;Spoon-Knife&#x60; repository via cURL, it would look like this:  &#x60;&#x60;&#x60;shell  curl -u username:token   https://api.github.com/users/octocat/hovercard?subject_type&#x3D;repository&amp;subject_id&#x3D;1300192 &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="subjectType">Identifies which additional information you&#39;d like to receive about the person&#39;s hovercard. Can be &#x60;organization&#x60;, &#x60;repository&#x60;, &#x60;issue&#x60;, &#x60;pull_request&#x60;. **Required** when using &#x60;subject_id&#x60;.</param>
        /// <param name="subjectId">Uses the ID for the &#x60;subject_type&#x60; you specified. **Required** when using &#x60;subject_type&#x60;.</param>
        /// <returns>Hovercard</returns>
        Hovercard UsersGetContextForUser (string username, string subjectType, string subjectId);
        /// <summary>
        /// Get a GPG key for the authenticated user View extended details for a single GPG key. Requires that you are authenticated via Basic Auth or via OAuth with at least &#x60;read:gpg_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="gpgKeyId">The unique identifier of the GPG key.</param>
        /// <returns>GPGKey</returns>
        GPGKey UsersGetGpgKeyForAuthenticatedUser (int? gpgKeyId);
        /// <summary>
        /// Get a public SSH key for the authenticated user View extended details for a single public SSH key. Requires that you are authenticated via Basic Auth or via OAuth with at least &#x60;read:public_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="keyId">The unique identifier of the key.</param>
        /// <returns>Key</returns>
        Key UsersGetPublicSshKeyForAuthenticatedUser (int? keyId);
        /// <summary>
        /// List users Lists all users, in the order that they signed up on GitHub. This list includes personal user accounts and organization accounts.  Note: Pagination is powered exclusively by the &#x60;since&#x60; parameter. Use the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header) to get the URL for the next page of users.
        /// </summary>
        /// <param name="since">A user ID. Only return users with an ID greater than this ID.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> UsersList (int? since, int? perPage);
        /// <summary>
        /// List users blocked by the authenticated user List the users you&#39;ve blocked on your personal account.
        /// </summary>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> UsersListBlockedByAuthenticatedUser ();
        /// <summary>
        /// List email addresses for the authenticated user Lists all of your email addresses, and specifies which one is visible to the public. This endpoint is accessible with the &#x60;user:email&#x60; scope.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Email&gt;</returns>
        List<Email> UsersListEmailsForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// List the people the authenticated user follows Lists the people who the authenticated user follows.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> UsersListFollowedByAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// List followers of the authenticated user Lists the people following the authenticated user.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> UsersListFollowersForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// List followers of a user Lists the people following the specified user.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> UsersListFollowersForUser (string username, int? perPage, int? page);
        /// <summary>
        /// List the people a user follows Lists the people who the specified user follows.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> UsersListFollowingForUser (string username, int? perPage, int? page);
        /// <summary>
        /// List GPG keys for the authenticated user Lists the current user&#39;s GPG keys. Requires that you are authenticated via Basic Auth or via OAuth with at least &#x60;read:gpg_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;GPGKey&gt;</returns>
        List<GPGKey> UsersListGpgKeysForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// List GPG keys for a user Lists the GPG keys for a user. This information is accessible by anyone.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;GPGKey&gt;</returns>
        List<GPGKey> UsersListGpgKeysForUser (string username, int? perPage, int? page);
        /// <summary>
        /// List public email addresses for the authenticated user Lists your publicly visible email address, which you can set with the [Set primary email visibility for the authenticated user](https://docs.github.com/rest/reference/users#set-primary-email-visibility-for-the-authenticated-user) endpoint. This endpoint is accessible with the &#x60;user:email&#x60; scope.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Email&gt;</returns>
        List<Email> UsersListPublicEmailsForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// List public keys for a user Lists the _verified_ public SSH keys for a user. This is accessible by anyone.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;KeySimple&gt;</returns>
        List<KeySimple> UsersListPublicKeysForUser (string username, int? perPage, int? page);
        /// <summary>
        /// List public SSH keys for the authenticated user Lists the public SSH keys for the authenticated user&#39;s GitHub account. Requires that you are authenticated via Basic Auth or via OAuth with at least &#x60;read:public_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Key&gt;</returns>
        List<Key> UsersListPublicSshKeysForAuthenticatedUser (int? perPage, int? page);
        /// <summary>
        /// Set primary email visibility for the authenticated user Sets the visibility for your primary email addresses.
        /// </summary>
        /// <param name="usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest"></param>
        /// <returns>List&lt;Email&gt;</returns>
        List<Email> UsersSetPrimaryEmailVisibilityForAuthenticatedUser (UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest);
        /// <summary>
        /// Unblock a user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void UsersUnblock (string username);
        /// <summary>
        /// Unfollow a user Unfollowing a user requires the user to be logged in and authenticated with basic auth or OAuth with the &#x60;user:follow&#x60; scope.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void UsersUnfollow (string username);
        /// <summary>
        /// Update the authenticated user **Note:** If your email is set to private and you send an &#x60;email&#x60; parameter as part of this request to update your profile, your privacy settings are still enforced: the email address will not be displayed on your public profile or via the API.
        /// </summary>
        /// <param name="usersUpdateAuthenticatedRequest"></param>
        /// <returns>PrivateUser</returns>
        PrivateUser UsersUpdateAuthenticated (UsersUpdateAuthenticatedRequest usersUpdateAuthenticatedRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
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
        /// Add an email address for the authenticated user This endpoint is accessible with the &#x60;user&#x60; scope.
        /// </summary>
        /// <param name="usersAddEmailForAuthenticatedUserRequest"></param>
        /// <returns>List&lt;Email&gt;</returns>
        public List<Email> UsersAddEmailForAuthenticatedUser (UsersAddEmailForAuthenticatedUserRequest usersAddEmailForAuthenticatedUserRequest)
        {
            

            var path = "/user/emails";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(usersAddEmailForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersAddEmailForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersAddEmailForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Email>) ApiClient.Deserialize(response.Content, typeof(List<Email>), response.Headers);
        }

        /// <summary>
        /// Block a user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void UsersBlock (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersBlock");
            

            var path = "/user/blocks/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersBlock: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersBlock: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Check if a user is blocked by the authenticated user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void UsersCheckBlocked (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersCheckBlocked");
            

            var path = "/user/blocks/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCheckBlocked: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCheckBlocked: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Check if a user follows another user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="targetUser"></param>
        /// <returns></returns>
        public void UsersCheckFollowingForUser (string username, string targetUser)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersCheckFollowingForUser");
            
            // verify the required parameter 'targetUser' is set
            if (targetUser == null) throw new ApiException(400, "Missing required parameter 'targetUser' when calling UsersCheckFollowingForUser");
            

            var path = "/users/{username}/following/{target_user}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));
path = path.Replace("{" + "target_user" + "}", ApiClient.ParameterToString(targetUser));

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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCheckFollowingForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCheckFollowingForUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Check if a person is followed by the authenticated user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void UsersCheckPersonIsFollowedByAuthenticated (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersCheckPersonIsFollowedByAuthenticated");
            

            var path = "/user/following/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCheckPersonIsFollowedByAuthenticated: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCheckPersonIsFollowedByAuthenticated: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Create a GPG key for the authenticated user Adds a GPG key to the authenticated user&#39;s GitHub account. Requires that you are authenticated via Basic Auth, or OAuth with at least &#x60;write:gpg_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="usersCreateGpgKeyForAuthenticatedUserRequest"></param>
        /// <returns>GPGKey</returns>
        public GPGKey UsersCreateGpgKeyForAuthenticatedUser (UsersCreateGpgKeyForAuthenticatedUserRequest usersCreateGpgKeyForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'usersCreateGpgKeyForAuthenticatedUserRequest' is set
            if (usersCreateGpgKeyForAuthenticatedUserRequest == null) throw new ApiException(400, "Missing required parameter 'usersCreateGpgKeyForAuthenticatedUserRequest' when calling UsersCreateGpgKeyForAuthenticatedUser");
            

            var path = "/user/gpg_keys";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(usersCreateGpgKeyForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCreateGpgKeyForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCreateGpgKeyForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (GPGKey) ApiClient.Deserialize(response.Content, typeof(GPGKey), response.Headers);
        }

        /// <summary>
        /// Create a public SSH key for the authenticated user Adds a public SSH key to the authenticated user&#39;s GitHub account. Requires that you are authenticated via Basic Auth, or OAuth with at least &#x60;write:public_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="usersCreatePublicSshKeyForAuthenticatedUserRequest"></param>
        /// <returns>Key</returns>
        public Key UsersCreatePublicSshKeyForAuthenticatedUser (UsersCreatePublicSshKeyForAuthenticatedUserRequest usersCreatePublicSshKeyForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'usersCreatePublicSshKeyForAuthenticatedUserRequest' is set
            if (usersCreatePublicSshKeyForAuthenticatedUserRequest == null) throw new ApiException(400, "Missing required parameter 'usersCreatePublicSshKeyForAuthenticatedUserRequest' when calling UsersCreatePublicSshKeyForAuthenticatedUser");
            

            var path = "/user/keys";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(usersCreatePublicSshKeyForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCreatePublicSshKeyForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersCreatePublicSshKeyForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Key) ApiClient.Deserialize(response.Content, typeof(Key), response.Headers);
        }

        /// <summary>
        /// Delete an email address for the authenticated user This endpoint is accessible with the &#x60;user&#x60; scope.
        /// </summary>
        /// <param name="usersDeleteEmailForAuthenticatedUserRequest"></param>
        /// <returns></returns>
        public void UsersDeleteEmailForAuthenticatedUser (UsersDeleteEmailForAuthenticatedUserRequest usersDeleteEmailForAuthenticatedUserRequest)
        {
            

            var path = "/user/emails";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(usersDeleteEmailForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeleteEmailForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeleteEmailForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a GPG key for the authenticated user Removes a GPG key from the authenticated user&#39;s GitHub account. Requires that you are authenticated via Basic Auth or via OAuth with at least &#x60;admin:gpg_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="gpgKeyId">The unique identifier of the GPG key.</param>
        /// <returns></returns>
        public void UsersDeleteGpgKeyForAuthenticatedUser (int? gpgKeyId)
        {
            
            // verify the required parameter 'gpgKeyId' is set
            if (gpgKeyId == null) throw new ApiException(400, "Missing required parameter 'gpgKeyId' when calling UsersDeleteGpgKeyForAuthenticatedUser");
            

            var path = "/user/gpg_keys/{gpg_key_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gpg_key_id" + "}", ApiClient.ParameterToString(gpgKeyId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeleteGpgKeyForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeleteGpgKeyForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a public SSH key for the authenticated user Removes a public SSH key from the authenticated user&#39;s GitHub account. Requires that you are authenticated via Basic Auth or via OAuth with at least &#x60;admin:public_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="keyId">The unique identifier of the key.</param>
        /// <returns></returns>
        public void UsersDeletePublicSshKeyForAuthenticatedUser (int? keyId)
        {
            
            // verify the required parameter 'keyId' is set
            if (keyId == null) throw new ApiException(400, "Missing required parameter 'keyId' when calling UsersDeletePublicSshKeyForAuthenticatedUser");
            

            var path = "/user/keys/{key_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key_id" + "}", ApiClient.ParameterToString(keyId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeletePublicSshKeyForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersDeletePublicSshKeyForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Follow a user Note that you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;  Following a user requires the user to be logged in and authenticated with basic auth or OAuth with the &#x60;user:follow&#x60; scope.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void UsersFollow (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersFollow");
            

            var path = "/user/following/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersFollow: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersFollow: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get the authenticated user If the authenticated user is authenticated through basic authentication or OAuth with the &#x60;user&#x60; scope, then the response lists public and private profile information.  If the authenticated user is authenticated through OAuth without the &#x60;user&#x60; scope, then the response lists only public profile information.
        /// </summary>
        /// <returns>UsersGetAuthenticated200Response</returns>
        public UsersGetAuthenticated200Response UsersGetAuthenticated ()
        {
            

            var path = "/user";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetAuthenticated: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetAuthenticated: " + response.ErrorMessage, response.ErrorMessage);

            return (UsersGetAuthenticated200Response) ApiClient.Deserialize(response.Content, typeof(UsersGetAuthenticated200Response), response.Headers);
        }

        /// <summary>
        /// Get a user Provides publicly available information about someone with a GitHub account.  GitHub Apps with the &#x60;Plan&#x60; user permission can use this endpoint to retrieve information about a user&#39;s GitHub plan. The GitHub App must be authenticated as a user. See \&quot;[Identifying and authorizing users for GitHub Apps](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/)\&quot; for details about authentication. For an example response, see &#39;Response with GitHub plan information&#39; below\&quot;  The &#x60;email&#x60; key in the following response is the publicly visible email address from your GitHub [profile page](https://github.com/settings/profile). When setting up your profile, you can select a primary email address to be “public” which provides an email entry for this endpoint. If you do not set a public email address for &#x60;email&#x60;, then it will have a value of &#x60;null&#x60;. You only see publicly visible email addresses when authenticated with GitHub. For more information, see [Authentication](https://docs.github.com/rest/overview/resources-in-the-rest-api#authentication).  The Emails API enables you to list all of your email addresses, and toggle a primary email to be visible publicly. For more information, see \&quot;[Emails API](https://docs.github.com/rest/reference/users#emails)\&quot;.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>UsersGetAuthenticated200Response</returns>
        public UsersGetAuthenticated200Response UsersGetByUsername (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersGetByUsername");
            

            var path = "/users/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetByUsername: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetByUsername: " + response.ErrorMessage, response.ErrorMessage);

            return (UsersGetAuthenticated200Response) ApiClient.Deserialize(response.Content, typeof(UsersGetAuthenticated200Response), response.Headers);
        }

        /// <summary>
        /// Get contextual information for a user Provides hovercard information when authenticated through basic auth or OAuth with the &#x60;repo&#x60; scope. You can find out more about someone in relation to their pull requests, issues, repositories, and organizations.  The &#x60;subject_type&#x60; and &#x60;subject_id&#x60; parameters provide context for the person&#39;s hovercard, which returns more information than without the parameters. For example, if you wanted to find out more about &#x60;octocat&#x60; who owns the &#x60;Spoon-Knife&#x60; repository via cURL, it would look like this:  &#x60;&#x60;&#x60;shell  curl -u username:token   https://api.github.com/users/octocat/hovercard?subject_type&#x3D;repository&amp;subject_id&#x3D;1300192 &#x60;&#x60;&#x60;
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="subjectType">Identifies which additional information you&#39;d like to receive about the person&#39;s hovercard. Can be &#x60;organization&#x60;, &#x60;repository&#x60;, &#x60;issue&#x60;, &#x60;pull_request&#x60;. **Required** when using &#x60;subject_id&#x60;.</param>
        /// <param name="subjectId">Uses the ID for the &#x60;subject_type&#x60; you specified. **Required** when using &#x60;subject_type&#x60;.</param>
        /// <returns>Hovercard</returns>
        public Hovercard UsersGetContextForUser (string username, string subjectType, string subjectId)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersGetContextForUser");
            

            var path = "/users/{username}/hovercard";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (subjectType != null) queryParams.Add("subject_type", ApiClient.ParameterToString(subjectType)); // query parameter
 if (subjectId != null) queryParams.Add("subject_id", ApiClient.ParameterToString(subjectId)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetContextForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetContextForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Hovercard) ApiClient.Deserialize(response.Content, typeof(Hovercard), response.Headers);
        }

        /// <summary>
        /// Get a GPG key for the authenticated user View extended details for a single GPG key. Requires that you are authenticated via Basic Auth or via OAuth with at least &#x60;read:gpg_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="gpgKeyId">The unique identifier of the GPG key.</param>
        /// <returns>GPGKey</returns>
        public GPGKey UsersGetGpgKeyForAuthenticatedUser (int? gpgKeyId)
        {
            
            // verify the required parameter 'gpgKeyId' is set
            if (gpgKeyId == null) throw new ApiException(400, "Missing required parameter 'gpgKeyId' when calling UsersGetGpgKeyForAuthenticatedUser");
            

            var path = "/user/gpg_keys/{gpg_key_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gpg_key_id" + "}", ApiClient.ParameterToString(gpgKeyId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetGpgKeyForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetGpgKeyForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (GPGKey) ApiClient.Deserialize(response.Content, typeof(GPGKey), response.Headers);
        }

        /// <summary>
        /// Get a public SSH key for the authenticated user View extended details for a single public SSH key. Requires that you are authenticated via Basic Auth or via OAuth with at least &#x60;read:public_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="keyId">The unique identifier of the key.</param>
        /// <returns>Key</returns>
        public Key UsersGetPublicSshKeyForAuthenticatedUser (int? keyId)
        {
            
            // verify the required parameter 'keyId' is set
            if (keyId == null) throw new ApiException(400, "Missing required parameter 'keyId' when calling UsersGetPublicSshKeyForAuthenticatedUser");
            

            var path = "/user/keys/{key_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "key_id" + "}", ApiClient.ParameterToString(keyId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetPublicSshKeyForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersGetPublicSshKeyForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Key) ApiClient.Deserialize(response.Content, typeof(Key), response.Headers);
        }

        /// <summary>
        /// List users Lists all users, in the order that they signed up on GitHub. This list includes personal user accounts and organization accounts.  Note: Pagination is powered exclusively by the &#x60;since&#x60; parameter. Use the [Link header](https://docs.github.com/rest/overview/resources-in-the-rest-api#link-header) to get the URL for the next page of users.
        /// </summary>
        /// <param name="since">A user ID. Only return users with an ID greater than this ID.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> UsersList (int? since, int? perPage)
        {
            

            var path = "/users";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersList: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List users blocked by the authenticated user List the users you&#39;ve blocked on your personal account.
        /// </summary>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> UsersListBlockedByAuthenticatedUser ()
        {
            

            var path = "/user/blocks";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListBlockedByAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListBlockedByAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List email addresses for the authenticated user Lists all of your email addresses, and specifies which one is visible to the public. This endpoint is accessible with the &#x60;user:email&#x60; scope.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Email&gt;</returns>
        public List<Email> UsersListEmailsForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/emails";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListEmailsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListEmailsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Email>) ApiClient.Deserialize(response.Content, typeof(List<Email>), response.Headers);
        }

        /// <summary>
        /// List the people the authenticated user follows Lists the people who the authenticated user follows.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> UsersListFollowedByAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/following";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListFollowedByAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListFollowedByAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List followers of the authenticated user Lists the people following the authenticated user.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> UsersListFollowersForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/followers";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListFollowersForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListFollowersForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List followers of a user Lists the people following the specified user.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> UsersListFollowersForUser (string username, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersListFollowersForUser");
            

            var path = "/users/{username}/followers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListFollowersForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListFollowersForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List the people a user follows Lists the people who the specified user follows.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> UsersListFollowingForUser (string username, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersListFollowingForUser");
            

            var path = "/users/{username}/following";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListFollowingForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListFollowingForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List GPG keys for the authenticated user Lists the current user&#39;s GPG keys. Requires that you are authenticated via Basic Auth or via OAuth with at least &#x60;read:gpg_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;GPGKey&gt;</returns>
        public List<GPGKey> UsersListGpgKeysForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/gpg_keys";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListGpgKeysForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListGpgKeysForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GPGKey>) ApiClient.Deserialize(response.Content, typeof(List<GPGKey>), response.Headers);
        }

        /// <summary>
        /// List GPG keys for a user Lists the GPG keys for a user. This information is accessible by anyone.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;GPGKey&gt;</returns>
        public List<GPGKey> UsersListGpgKeysForUser (string username, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersListGpgKeysForUser");
            

            var path = "/users/{username}/gpg_keys";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListGpgKeysForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListGpgKeysForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GPGKey>) ApiClient.Deserialize(response.Content, typeof(List<GPGKey>), response.Headers);
        }

        /// <summary>
        /// List public email addresses for the authenticated user Lists your publicly visible email address, which you can set with the [Set primary email visibility for the authenticated user](https://docs.github.com/rest/reference/users#set-primary-email-visibility-for-the-authenticated-user) endpoint. This endpoint is accessible with the &#x60;user:email&#x60; scope.
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Email&gt;</returns>
        public List<Email> UsersListPublicEmailsForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/public_emails";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListPublicEmailsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListPublicEmailsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Email>) ApiClient.Deserialize(response.Content, typeof(List<Email>), response.Headers);
        }

        /// <summary>
        /// List public keys for a user Lists the _verified_ public SSH keys for a user. This is accessible by anyone.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;KeySimple&gt;</returns>
        public List<KeySimple> UsersListPublicKeysForUser (string username, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersListPublicKeysForUser");
            

            var path = "/users/{username}/keys";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListPublicKeysForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListPublicKeysForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<KeySimple>) ApiClient.Deserialize(response.Content, typeof(List<KeySimple>), response.Headers);
        }

        /// <summary>
        /// List public SSH keys for the authenticated user Lists the public SSH keys for the authenticated user&#39;s GitHub account. Requires that you are authenticated via Basic Auth or via OAuth with at least &#x60;read:public_key&#x60; [scope](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/).
        /// </summary>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Key&gt;</returns>
        public List<Key> UsersListPublicSshKeysForAuthenticatedUser (int? perPage, int? page)
        {
            

            var path = "/user/keys";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListPublicSshKeysForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersListPublicSshKeysForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Key>) ApiClient.Deserialize(response.Content, typeof(List<Key>), response.Headers);
        }

        /// <summary>
        /// Set primary email visibility for the authenticated user Sets the visibility for your primary email addresses.
        /// </summary>
        /// <param name="usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest"></param>
        /// <returns>List&lt;Email&gt;</returns>
        public List<Email> UsersSetPrimaryEmailVisibilityForAuthenticatedUser (UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest' is set
            if (usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest == null) throw new ApiException(400, "Missing required parameter 'usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest' when calling UsersSetPrimaryEmailVisibilityForAuthenticatedUser");
            

            var path = "/user/email/visibility";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(usersSetPrimaryEmailVisibilityForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersSetPrimaryEmailVisibilityForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersSetPrimaryEmailVisibilityForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Email>) ApiClient.Deserialize(response.Content, typeof(List<Email>), response.Headers);
        }

        /// <summary>
        /// Unblock a user 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void UsersUnblock (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersUnblock");
            

            var path = "/user/blocks/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUnblock: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUnblock: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Unfollow a user Unfollowing a user requires the user to be logged in and authenticated with basic auth or OAuth with the &#x60;user:follow&#x60; scope.
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void UsersUnfollow (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling UsersUnfollow");
            

            var path = "/user/following/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

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
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUnfollow: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUnfollow: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Update the authenticated user **Note:** If your email is set to private and you send an &#x60;email&#x60; parameter as part of this request to update your profile, your privacy settings are still enforced: the email address will not be displayed on your public profile or via the API.
        /// </summary>
        /// <param name="usersUpdateAuthenticatedRequest"></param>
        /// <returns>PrivateUser</returns>
        public PrivateUser UsersUpdateAuthenticated (UsersUpdateAuthenticatedRequest usersUpdateAuthenticatedRequest)
        {
            

            var path = "/user";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(usersUpdateAuthenticatedRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUpdateAuthenticated: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UsersUpdateAuthenticated: " + response.ErrorMessage, response.ErrorMessage);

            return (PrivateUser) ApiClient.Deserialize(response.Content, typeof(PrivateUser), response.Headers);
        }

    }
}
