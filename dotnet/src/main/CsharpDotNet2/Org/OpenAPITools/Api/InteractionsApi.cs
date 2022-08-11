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
    public interface IInteractionsApi
    {
        /// <summary>
        /// Get interaction restrictions for your public repositories Shows which type of GitHub user can interact with your public repositories and when the restriction expires.
        /// </summary>
        /// <returns>InteractionsGetRestrictionsForOrg200Response</returns>
        InteractionsGetRestrictionsForOrg200Response InteractionsGetRestrictionsForAuthenticatedUser ();
        /// <summary>
        /// Get interaction restrictions for an organization Shows which type of GitHub user can interact with this organization and when the restriction expires. If there is no restrictions, you will see an empty response.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>InteractionsGetRestrictionsForOrg200Response</returns>
        InteractionsGetRestrictionsForOrg200Response InteractionsGetRestrictionsForOrg (string org);
        /// <summary>
        /// Get interaction restrictions for a repository Shows which type of GitHub user can interact with this repository and when the restriction expires. If there are no restrictions, you will see an empty response.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>InteractionsGetRestrictionsForOrg200Response</returns>
        InteractionsGetRestrictionsForOrg200Response InteractionsGetRestrictionsForRepo (string owner, string repo);
        /// <summary>
        /// Remove interaction restrictions from your public repositories Removes any interaction restrictions from your public repositories.
        /// </summary>
        /// <returns></returns>
        void InteractionsRemoveRestrictionsForAuthenticatedUser ();
        /// <summary>
        /// Remove interaction restrictions for an organization Removes all interaction restrictions from public repositories in the given organization. You must be an organization owner to remove restrictions.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns></returns>
        void InteractionsRemoveRestrictionsForOrg (string org);
        /// <summary>
        /// Remove interaction restrictions for a repository Removes all interaction restrictions from the given repository. You must have owner or admin access to remove restrictions. If the interaction limit is set for the user or organization that owns this repository, you will receive a &#x60;409 Conflict&#x60; response and will not be able to use this endpoint to change the interaction limit for a single repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        void InteractionsRemoveRestrictionsForRepo (string owner, string repo);
        /// <summary>
        /// Set interaction restrictions for your public repositories Temporarily restricts which type of GitHub user can interact with your public repositories. Setting the interaction limit at the user level will overwrite any interaction limits that are set for individual repositories owned by the user.
        /// </summary>
        /// <param name="interactionRestrictions"></param>
        /// <returns>InteractionLimits</returns>
        InteractionLimits InteractionsSetRestrictionsForAuthenticatedUser (InteractionRestrictions interactionRestrictions);
        /// <summary>
        /// Set interaction restrictions for an organization Temporarily restricts interactions to a certain type of GitHub user in any public repository in the given organization. You must be an organization owner to set these restrictions. Setting the interaction limit at the organization level will overwrite any interaction limits that are set for individual repositories owned by the organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="interactionRestrictions"></param>
        /// <returns>InteractionLimits</returns>
        InteractionLimits InteractionsSetRestrictionsForOrg (string org, InteractionRestrictions interactionRestrictions);
        /// <summary>
        /// Set interaction restrictions for a repository Temporarily restricts interactions to a certain type of GitHub user within the given repository. You must have owner or admin access to set these restrictions. If an interaction limit is set for the user or organization that owns this repository, you will receive a &#x60;409 Conflict&#x60; response and will not be able to use this endpoint to change the interaction limit for a single repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="interactionRestrictions"></param>
        /// <returns>InteractionLimits</returns>
        InteractionLimits InteractionsSetRestrictionsForRepo (string owner, string repo, InteractionRestrictions interactionRestrictions);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InteractionsApi : IInteractionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InteractionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InteractionsApi(String basePath)
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
        /// Get interaction restrictions for your public repositories Shows which type of GitHub user can interact with your public repositories and when the restriction expires.
        /// </summary>
        /// <returns>InteractionsGetRestrictionsForOrg200Response</returns>
        public InteractionsGetRestrictionsForOrg200Response InteractionsGetRestrictionsForAuthenticatedUser ()
        {
            

            var path = "/user/interaction-limits";
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
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsGetRestrictionsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsGetRestrictionsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (InteractionsGetRestrictionsForOrg200Response) ApiClient.Deserialize(response.Content, typeof(InteractionsGetRestrictionsForOrg200Response), response.Headers);
        }

        /// <summary>
        /// Get interaction restrictions for an organization Shows which type of GitHub user can interact with this organization and when the restriction expires. If there is no restrictions, you will see an empty response.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns>InteractionsGetRestrictionsForOrg200Response</returns>
        public InteractionsGetRestrictionsForOrg200Response InteractionsGetRestrictionsForOrg (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling InteractionsGetRestrictionsForOrg");
            

            var path = "/orgs/{org}/interaction-limits";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

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
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsGetRestrictionsForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsGetRestrictionsForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (InteractionsGetRestrictionsForOrg200Response) ApiClient.Deserialize(response.Content, typeof(InteractionsGetRestrictionsForOrg200Response), response.Headers);
        }

        /// <summary>
        /// Get interaction restrictions for a repository Shows which type of GitHub user can interact with this repository and when the restriction expires. If there are no restrictions, you will see an empty response.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns>InteractionsGetRestrictionsForOrg200Response</returns>
        public InteractionsGetRestrictionsForOrg200Response InteractionsGetRestrictionsForRepo (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling InteractionsGetRestrictionsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling InteractionsGetRestrictionsForRepo");
            

            var path = "/repos/{owner}/{repo}/interaction-limits";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

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
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsGetRestrictionsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsGetRestrictionsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (InteractionsGetRestrictionsForOrg200Response) ApiClient.Deserialize(response.Content, typeof(InteractionsGetRestrictionsForOrg200Response), response.Headers);
        }

        /// <summary>
        /// Remove interaction restrictions from your public repositories Removes any interaction restrictions from your public repositories.
        /// </summary>
        /// <returns></returns>
        public void InteractionsRemoveRestrictionsForAuthenticatedUser ()
        {
            

            var path = "/user/interaction-limits";
            path = path.Replace("{format}", "json");
            
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
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsRemoveRestrictionsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsRemoveRestrictionsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove interaction restrictions for an organization Removes all interaction restrictions from public repositories in the given organization. You must be an organization owner to remove restrictions.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <returns></returns>
        public void InteractionsRemoveRestrictionsForOrg (string org)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling InteractionsRemoveRestrictionsForOrg");
            

            var path = "/orgs/{org}/interaction-limits";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

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
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsRemoveRestrictionsForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsRemoveRestrictionsForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Remove interaction restrictions for a repository Removes all interaction restrictions from the given repository. You must have owner or admin access to remove restrictions. If the interaction limit is set for the user or organization that owns this repository, you will receive a &#x60;409 Conflict&#x60; response and will not be able to use this endpoint to change the interaction limit for a single repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <returns></returns>
        public void InteractionsRemoveRestrictionsForRepo (string owner, string repo)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling InteractionsRemoveRestrictionsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling InteractionsRemoveRestrictionsForRepo");
            

            var path = "/repos/{owner}/{repo}/interaction-limits";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

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
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsRemoveRestrictionsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsRemoveRestrictionsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set interaction restrictions for your public repositories Temporarily restricts which type of GitHub user can interact with your public repositories. Setting the interaction limit at the user level will overwrite any interaction limits that are set for individual repositories owned by the user.
        /// </summary>
        /// <param name="interactionRestrictions"></param>
        /// <returns>InteractionLimits</returns>
        public InteractionLimits InteractionsSetRestrictionsForAuthenticatedUser (InteractionRestrictions interactionRestrictions)
        {
            
            // verify the required parameter 'interactionRestrictions' is set
            if (interactionRestrictions == null) throw new ApiException(400, "Missing required parameter 'interactionRestrictions' when calling InteractionsSetRestrictionsForAuthenticatedUser");
            

            var path = "/user/interaction-limits";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(interactionRestrictions); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsSetRestrictionsForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsSetRestrictionsForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (InteractionLimits) ApiClient.Deserialize(response.Content, typeof(InteractionLimits), response.Headers);
        }

        /// <summary>
        /// Set interaction restrictions for an organization Temporarily restricts interactions to a certain type of GitHub user in any public repository in the given organization. You must be an organization owner to set these restrictions. Setting the interaction limit at the organization level will overwrite any interaction limits that are set for individual repositories owned by the organization.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="interactionRestrictions"></param>
        /// <returns>InteractionLimits</returns>
        public InteractionLimits InteractionsSetRestrictionsForOrg (string org, InteractionRestrictions interactionRestrictions)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling InteractionsSetRestrictionsForOrg");
            
            // verify the required parameter 'interactionRestrictions' is set
            if (interactionRestrictions == null) throw new ApiException(400, "Missing required parameter 'interactionRestrictions' when calling InteractionsSetRestrictionsForOrg");
            

            var path = "/orgs/{org}/interaction-limits";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(interactionRestrictions); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsSetRestrictionsForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsSetRestrictionsForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (InteractionLimits) ApiClient.Deserialize(response.Content, typeof(InteractionLimits), response.Headers);
        }

        /// <summary>
        /// Set interaction restrictions for a repository Temporarily restricts interactions to a certain type of GitHub user within the given repository. You must have owner or admin access to set these restrictions. If an interaction limit is set for the user or organization that owns this repository, you will receive a &#x60;409 Conflict&#x60; response and will not be able to use this endpoint to change the interaction limit for a single repository.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="interactionRestrictions"></param>
        /// <returns>InteractionLimits</returns>
        public InteractionLimits InteractionsSetRestrictionsForRepo (string owner, string repo, InteractionRestrictions interactionRestrictions)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling InteractionsSetRestrictionsForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling InteractionsSetRestrictionsForRepo");
            
            // verify the required parameter 'interactionRestrictions' is set
            if (interactionRestrictions == null) throw new ApiException(400, "Missing required parameter 'interactionRestrictions' when calling InteractionsSetRestrictionsForRepo");
            

            var path = "/repos/{owner}/{repo}/interaction-limits";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(interactionRestrictions); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsSetRestrictionsForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionsSetRestrictionsForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (InteractionLimits) ApiClient.Deserialize(response.Content, typeof(InteractionLimits), response.Headers);
        }

    }
}
