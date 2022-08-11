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
    public interface IGistsApi
    {
        /// <summary>
        /// Check if a gist is starred 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <returns></returns>
        void GistsCheckIsStarred (string gistId);
        /// <summary>
        /// Create a gist Allows you to add a new gist with one or more files.  **Note:** Don&#39;t name your files \&quot;gistfile\&quot; with a numerical suffix. This is the format of the automatic naming scheme that Gist uses internally.
        /// </summary>
        /// <param name="gistsCreateRequest"></param>
        /// <returns>GistSimple</returns>
        GistSimple GistsCreate (GistsCreateRequest gistsCreateRequest);
        /// <summary>
        /// Create a gist comment 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="gistsCreateCommentRequest"></param>
        /// <returns>GistComment</returns>
        GistComment GistsCreateComment (string gistId, GistsCreateCommentRequest gistsCreateCommentRequest);
        /// <summary>
        /// Delete a gist 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <returns></returns>
        void GistsDelete (string gistId);
        /// <summary>
        /// Delete a gist comment 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns></returns>
        void GistsDeleteComment (string gistId, int? commentId);
        /// <summary>
        /// Fork a gist 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <returns>BaseGist</returns>
        BaseGist GistsFork (string gistId);
        /// <summary>
        /// Get a gist 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <returns>GistSimple</returns>
        GistSimple GistsGet (string gistId);
        /// <summary>
        /// Get a gist comment 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns>GistComment</returns>
        GistComment GistsGetComment (string gistId, int? commentId);
        /// <summary>
        /// Get a gist revision 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="sha"></param>
        /// <returns>GistSimple</returns>
        GistSimple GistsGetRevision (string gistId, string sha);
        /// <summary>
        /// List gists for the authenticated user Lists the authenticated user&#39;s gists or if called anonymously, this endpoint returns all public gists:
        /// </summary>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;BaseGist&gt;</returns>
        List<BaseGist> GistsList (DateTime? since, int? perPage, int? page);
        /// <summary>
        /// List gist comments 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;GistComment&gt;</returns>
        List<GistComment> GistsListComments (string gistId, int? perPage, int? page);
        /// <summary>
        /// List gist commits 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;GistCommit&gt;</returns>
        List<GistCommit> GistsListCommits (string gistId, int? perPage, int? page);
        /// <summary>
        /// List gists for a user Lists public gists for the specified user:
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;BaseGist&gt;</returns>
        List<BaseGist> GistsListForUser (string username, DateTime? since, int? perPage, int? page);
        /// <summary>
        /// List gist forks 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;GistSimple&gt;</returns>
        List<GistSimple> GistsListForks (string gistId, int? perPage, int? page);
        /// <summary>
        /// List public gists List public gists sorted by most recently updated to least recently updated.  Note: With [pagination](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination), you can fetch up to 3000 gists. For example, you can fetch 100 pages with 30 gists per page or 30 pages with 100 gists per page.
        /// </summary>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;BaseGist&gt;</returns>
        List<BaseGist> GistsListPublic (DateTime? since, int? perPage, int? page);
        /// <summary>
        /// List starred gists List the authenticated user&#39;s starred gists:
        /// </summary>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;BaseGist&gt;</returns>
        List<BaseGist> GistsListStarred (DateTime? since, int? perPage, int? page);
        /// <summary>
        /// Star a gist Note that you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <returns></returns>
        void GistsStar (string gistId);
        /// <summary>
        /// Unstar a gist 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <returns></returns>
        void GistsUnstar (string gistId);
        /// <summary>
        /// Update a gist Allows you to update or delete a gist file and rename gist files. Files from the previous version of the gist that aren&#39;t explicitly changed during an edit are unchanged.
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="gistsUpdateRequest"></param>
        /// <returns>GistSimple</returns>
        GistSimple GistsUpdate (string gistId, GistsUpdateRequest gistsUpdateRequest);
        /// <summary>
        /// Update a gist comment 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="gistsCreateCommentRequest"></param>
        /// <returns>GistComment</returns>
        GistComment GistsUpdateComment (string gistId, int? commentId, GistsCreateCommentRequest gistsCreateCommentRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GistsApi : IGistsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GistsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GistsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GistsApi(String basePath)
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
        /// Check if a gist is starred 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <returns></returns>
        public void GistsCheckIsStarred (string gistId)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsCheckIsStarred");
            

            var path = "/gists/{gist_id}/star";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling GistsCheckIsStarred: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsCheckIsStarred: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Create a gist Allows you to add a new gist with one or more files.  **Note:** Don&#39;t name your files \&quot;gistfile\&quot; with a numerical suffix. This is the format of the automatic naming scheme that Gist uses internally.
        /// </summary>
        /// <param name="gistsCreateRequest"></param>
        /// <returns>GistSimple</returns>
        public GistSimple GistsCreate (GistsCreateRequest gistsCreateRequest)
        {
            
            // verify the required parameter 'gistsCreateRequest' is set
            if (gistsCreateRequest == null) throw new ApiException(400, "Missing required parameter 'gistsCreateRequest' when calling GistsCreate");
            

            var path = "/gists";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(gistsCreateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsCreate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsCreate: " + response.ErrorMessage, response.ErrorMessage);

            return (GistSimple) ApiClient.Deserialize(response.Content, typeof(GistSimple), response.Headers);
        }

        /// <summary>
        /// Create a gist comment 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="gistsCreateCommentRequest"></param>
        /// <returns>GistComment</returns>
        public GistComment GistsCreateComment (string gistId, GistsCreateCommentRequest gistsCreateCommentRequest)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsCreateComment");
            
            // verify the required parameter 'gistsCreateCommentRequest' is set
            if (gistsCreateCommentRequest == null) throw new ApiException(400, "Missing required parameter 'gistsCreateCommentRequest' when calling GistsCreateComment");
            

            var path = "/gists/{gist_id}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(gistsCreateCommentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsCreateComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsCreateComment: " + response.ErrorMessage, response.ErrorMessage);

            return (GistComment) ApiClient.Deserialize(response.Content, typeof(GistComment), response.Headers);
        }

        /// <summary>
        /// Delete a gist 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <returns></returns>
        public void GistsDelete (string gistId)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsDelete");
            

            var path = "/gists/{gist_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling GistsDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsDelete: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a gist comment 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns></returns>
        public void GistsDeleteComment (string gistId, int? commentId)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsDeleteComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling GistsDeleteComment");
            

            var path = "/gists/{gist_id}/comments/{comment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling GistsDeleteComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsDeleteComment: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Fork a gist 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <returns>BaseGist</returns>
        public BaseGist GistsFork (string gistId)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsFork");
            

            var path = "/gists/{gist_id}/forks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsFork: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsFork: " + response.ErrorMessage, response.ErrorMessage);

            return (BaseGist) ApiClient.Deserialize(response.Content, typeof(BaseGist), response.Headers);
        }

        /// <summary>
        /// Get a gist 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <returns>GistSimple</returns>
        public GistSimple GistsGet (string gistId)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsGet");
            

            var path = "/gists/{gist_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling GistsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsGet: " + response.ErrorMessage, response.ErrorMessage);

            return (GistSimple) ApiClient.Deserialize(response.Content, typeof(GistSimple), response.Headers);
        }

        /// <summary>
        /// Get a gist comment 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <returns>GistComment</returns>
        public GistComment GistsGetComment (string gistId, int? commentId)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsGetComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling GistsGetComment");
            

            var path = "/gists/{gist_id}/comments/{comment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling GistsGetComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsGetComment: " + response.ErrorMessage, response.ErrorMessage);

            return (GistComment) ApiClient.Deserialize(response.Content, typeof(GistComment), response.Headers);
        }

        /// <summary>
        /// Get a gist revision 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="sha"></param>
        /// <returns>GistSimple</returns>
        public GistSimple GistsGetRevision (string gistId, string sha)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsGetRevision");
            
            // verify the required parameter 'sha' is set
            if (sha == null) throw new ApiException(400, "Missing required parameter 'sha' when calling GistsGetRevision");
            

            var path = "/gists/{gist_id}/{sha}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));
path = path.Replace("{" + "sha" + "}", ApiClient.ParameterToString(sha));

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
                throw new ApiException ((int)response.StatusCode, "Error calling GistsGetRevision: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsGetRevision: " + response.ErrorMessage, response.ErrorMessage);

            return (GistSimple) ApiClient.Deserialize(response.Content, typeof(GistSimple), response.Headers);
        }

        /// <summary>
        /// List gists for the authenticated user Lists the authenticated user&#39;s gists or if called anonymously, this endpoint returns all public gists:
        /// </summary>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;BaseGist&gt;</returns>
        public List<BaseGist> GistsList (DateTime? since, int? perPage, int? page)
        {
            

            var path = "/gists";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsList: " + response.ErrorMessage, response.ErrorMessage);

            return (List<BaseGist>) ApiClient.Deserialize(response.Content, typeof(List<BaseGist>), response.Headers);
        }

        /// <summary>
        /// List gist comments 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;GistComment&gt;</returns>
        public List<GistComment> GistsListComments (string gistId, int? perPage, int? page)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsListComments");
            

            var path = "/gists/{gist_id}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling GistsListComments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsListComments: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GistComment>) ApiClient.Deserialize(response.Content, typeof(List<GistComment>), response.Headers);
        }

        /// <summary>
        /// List gist commits 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;GistCommit&gt;</returns>
        public List<GistCommit> GistsListCommits (string gistId, int? perPage, int? page)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsListCommits");
            

            var path = "/gists/{gist_id}/commits";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling GistsListCommits: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsListCommits: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GistCommit>) ApiClient.Deserialize(response.Content, typeof(List<GistCommit>), response.Headers);
        }

        /// <summary>
        /// List gists for a user Lists public gists for the specified user:
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;BaseGist&gt;</returns>
        public List<BaseGist> GistsListForUser (string username, DateTime? since, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling GistsListForUser");
            

            var path = "/users/{username}/gists";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsListForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsListForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<BaseGist>) ApiClient.Deserialize(response.Content, typeof(List<BaseGist>), response.Headers);
        }

        /// <summary>
        /// List gist forks 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;GistSimple&gt;</returns>
        public List<GistSimple> GistsListForks (string gistId, int? perPage, int? page)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsListForks");
            

            var path = "/gists/{gist_id}/forks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling GistsListForks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsListForks: " + response.ErrorMessage, response.ErrorMessage);

            return (List<GistSimple>) ApiClient.Deserialize(response.Content, typeof(List<GistSimple>), response.Headers);
        }

        /// <summary>
        /// List public gists List public gists sorted by most recently updated to least recently updated.  Note: With [pagination](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination), you can fetch up to 3000 gists. For example, you can fetch 100 pages with 30 gists per page or 30 pages with 100 gists per page.
        /// </summary>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;BaseGist&gt;</returns>
        public List<BaseGist> GistsListPublic (DateTime? since, int? perPage, int? page)
        {
            

            var path = "/gists/public";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsListPublic: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsListPublic: " + response.ErrorMessage, response.ErrorMessage);

            return (List<BaseGist>) ApiClient.Deserialize(response.Content, typeof(List<BaseGist>), response.Headers);
        }

        /// <summary>
        /// List starred gists List the authenticated user&#39;s starred gists:
        /// </summary>
        /// <param name="since">Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;BaseGist&gt;</returns>
        public List<BaseGist> GistsListStarred (DateTime? since, int? perPage, int? page)
        {
            

            var path = "/gists/starred";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsListStarred: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsListStarred: " + response.ErrorMessage, response.ErrorMessage);

            return (List<BaseGist>) ApiClient.Deserialize(response.Content, typeof(List<BaseGist>), response.Headers);
        }

        /// <summary>
        /// Star a gist Note that you&#39;ll need to set &#x60;Content-Length&#x60; to zero when calling out to this endpoint. For more information, see \&quot;[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\&quot;
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <returns></returns>
        public void GistsStar (string gistId)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsStar");
            

            var path = "/gists/{gist_id}/star";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling GistsStar: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsStar: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Unstar a gist 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <returns></returns>
        public void GistsUnstar (string gistId)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsUnstar");
            

            var path = "/gists/{gist_id}/star";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling GistsUnstar: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsUnstar: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Update a gist Allows you to update or delete a gist file and rename gist files. Files from the previous version of the gist that aren&#39;t explicitly changed during an edit are unchanged.
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="gistsUpdateRequest"></param>
        /// <returns>GistSimple</returns>
        public GistSimple GistsUpdate (string gistId, GistsUpdateRequest gistsUpdateRequest)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsUpdate");
            
            // verify the required parameter 'gistsUpdateRequest' is set
            if (gistsUpdateRequest == null) throw new ApiException(400, "Missing required parameter 'gistsUpdateRequest' when calling GistsUpdate");
            

            var path = "/gists/{gist_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(gistsUpdateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsUpdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsUpdate: " + response.ErrorMessage, response.ErrorMessage);

            return (GistSimple) ApiClient.Deserialize(response.Content, typeof(GistSimple), response.Headers);
        }

        /// <summary>
        /// Update a gist comment 
        /// </summary>
        /// <param name="gistId">The unique identifier of the gist.</param>
        /// <param name="commentId">The unique identifier of the comment.</param>
        /// <param name="gistsCreateCommentRequest"></param>
        /// <returns>GistComment</returns>
        public GistComment GistsUpdateComment (string gistId, int? commentId, GistsCreateCommentRequest gistsCreateCommentRequest)
        {
            
            // verify the required parameter 'gistId' is set
            if (gistId == null) throw new ApiException(400, "Missing required parameter 'gistId' when calling GistsUpdateComment");
            
            // verify the required parameter 'commentId' is set
            if (commentId == null) throw new ApiException(400, "Missing required parameter 'commentId' when calling GistsUpdateComment");
            
            // verify the required parameter 'gistsCreateCommentRequest' is set
            if (gistsCreateCommentRequest == null) throw new ApiException(400, "Missing required parameter 'gistsCreateCommentRequest' when calling GistsUpdateComment");
            

            var path = "/gists/{gist_id}/comments/{comment_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "gist_id" + "}", ApiClient.ParameterToString(gistId));
path = path.Replace("{" + "comment_id" + "}", ApiClient.ParameterToString(commentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(gistsCreateCommentRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsUpdateComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GistsUpdateComment: " + response.ErrorMessage, response.ErrorMessage);

            return (GistComment) ApiClient.Deserialize(response.Content, typeof(GistComment), response.Headers);
        }

    }
}
