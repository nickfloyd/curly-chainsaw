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
    public interface IProjectsApi
    {
        /// <summary>
        /// Add project collaborator Adds a collaborator to an organization project and sets their permission level. You must be an organization owner or a project &#x60;admin&#x60; to add a collaborator.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="projectsAddCollaboratorRequest"></param>
        /// <returns></returns>
        void ProjectsAddCollaborator (int? projectId, string username, ProjectsAddCollaboratorRequest projectsAddCollaboratorRequest);
        /// <summary>
        /// Create a project card 
        /// </summary>
        /// <param name="columnId">The unique identifier of the column.</param>
        /// <param name="projectsCreateCardRequest"></param>
        /// <returns>ProjectCard</returns>
        ProjectCard ProjectsCreateCard (int? columnId, ProjectsCreateCardRequest projectsCreateCardRequest);
        /// <summary>
        /// Create a project column 
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="projectsUpdateColumnRequest"></param>
        /// <returns>ProjectColumn</returns>
        ProjectColumn ProjectsCreateColumn (int? projectId, ProjectsUpdateColumnRequest projectsUpdateColumnRequest);
        /// <summary>
        /// Create a user project Creates a user project board. Returns a &#x60;410 Gone&#x60; status if the user does not have existing classic projects. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="projectsCreateForAuthenticatedUserRequest"></param>
        /// <returns>Project</returns>
        Project ProjectsCreateForAuthenticatedUser (ProjectsCreateForAuthenticatedUserRequest projectsCreateForAuthenticatedUserRequest);
        /// <summary>
        /// Create an organization project Creates an organization project board. Returns a &#x60;410 Gone&#x60; status if projects are disabled in the organization or if the organization does not have existing classic projects. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="projectsCreateForOrgRequest"></param>
        /// <returns>Project</returns>
        Project ProjectsCreateForOrg (string org, ProjectsCreateForOrgRequest projectsCreateForOrgRequest);
        /// <summary>
        /// Create a repository project Creates a repository project board. Returns a &#x60;410 Gone&#x60; status if projects are disabled in the repository or if the repository does not have existing classic projects. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="projectsCreateForOrgRequest"></param>
        /// <returns>Project</returns>
        Project ProjectsCreateForRepo (string owner, string repo, ProjectsCreateForOrgRequest projectsCreateForOrgRequest);
        /// <summary>
        /// Delete a project Deletes a project board. Returns a &#x60;404 Not Found&#x60; status if projects are disabled.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <returns></returns>
        void ProjectsDelete (int? projectId);
        /// <summary>
        /// Delete a project card 
        /// </summary>
        /// <param name="cardId">The unique identifier of the card.</param>
        /// <returns></returns>
        void ProjectsDeleteCard (int? cardId);
        /// <summary>
        /// Delete a project column 
        /// </summary>
        /// <param name="columnId">The unique identifier of the column.</param>
        /// <returns></returns>
        void ProjectsDeleteColumn (int? columnId);
        /// <summary>
        /// Get a project Gets a project by its &#x60;id&#x60;. Returns a &#x60;404 Not Found&#x60; status if projects are disabled. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <returns>Project</returns>
        Project ProjectsGet (int? projectId);
        /// <summary>
        /// Get a project card 
        /// </summary>
        /// <param name="cardId">The unique identifier of the card.</param>
        /// <returns>ProjectCard</returns>
        ProjectCard ProjectsGetCard (int? cardId);
        /// <summary>
        /// Get a project column 
        /// </summary>
        /// <param name="columnId">The unique identifier of the column.</param>
        /// <returns>ProjectColumn</returns>
        ProjectColumn ProjectsGetColumn (int? columnId);
        /// <summary>
        /// Get project permission for a user Returns the collaborator&#39;s permission level for an organization project. Possible values for the &#x60;permission&#x60; key: &#x60;admin&#x60;, &#x60;write&#x60;, &#x60;read&#x60;, &#x60;none&#x60;. You must be an organization owner or a project &#x60;admin&#x60; to review a user&#39;s permission level.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>ProjectCollaboratorPermission</returns>
        ProjectCollaboratorPermission ProjectsGetPermissionForUser (int? projectId, string username);
        /// <summary>
        /// List project cards 
        /// </summary>
        /// <param name="columnId">The unique identifier of the column.</param>
        /// <param name="archivedState">Filters the project cards that are returned by the card&#39;s state.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;ProjectCard&gt;</returns>
        List<ProjectCard> ProjectsListCards (int? columnId, string archivedState, int? perPage, int? page);
        /// <summary>
        /// List project collaborators Lists the collaborators for an organization project. For a project, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners. You must be an organization owner or a project &#x60;admin&#x60; to list collaborators.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="affiliation">Filters the collaborators by their affiliation. &#x60;outside&#x60; means outside collaborators of a project that are not a member of the project&#39;s organization. &#x60;direct&#x60; means collaborators with permissions to a project, regardless of organization membership status. &#x60;all&#x60; means all collaborators the authenticated user can see.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        List<SimpleUser1> ProjectsListCollaborators (int? projectId, string affiliation, int? perPage, int? page);
        /// <summary>
        /// List project columns 
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;ProjectColumn&gt;</returns>
        List<ProjectColumn> ProjectsListColumns (int? projectId, int? perPage, int? page);
        /// <summary>
        /// List organization projects Lists the projects in an organization. Returns a &#x60;404 Not Found&#x60; status if projects are disabled in the organization. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="state">Indicates the state of the projects to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Project&gt;</returns>
        List<Project> ProjectsListForOrg (string org, string state, int? perPage, int? page);
        /// <summary>
        /// List repository projects Lists the projects in a repository. Returns a &#x60;404 Not Found&#x60; status if projects are disabled in the repository. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="state">Indicates the state of the projects to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Project&gt;</returns>
        List<Project> ProjectsListForRepo (string owner, string repo, string state, int? perPage, int? page);
        /// <summary>
        /// List user projects 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="state">Indicates the state of the projects to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Project&gt;</returns>
        List<Project> ProjectsListForUser (string username, string state, int? perPage, int? page);
        /// <summary>
        /// Move a project card 
        /// </summary>
        /// <param name="cardId">The unique identifier of the card.</param>
        /// <param name="projectsMoveCardRequest"></param>
        /// <returns>Object</returns>
        Object ProjectsMoveCard (int? cardId, ProjectsMoveCardRequest projectsMoveCardRequest);
        /// <summary>
        /// Move a project column 
        /// </summary>
        /// <param name="columnId">The unique identifier of the column.</param>
        /// <param name="projectsMoveColumnRequest"></param>
        /// <returns>Object</returns>
        Object ProjectsMoveColumn (int? columnId, ProjectsMoveColumnRequest projectsMoveColumnRequest);
        /// <summary>
        /// Remove user as a collaborator Removes a collaborator from an organization project. You must be an organization owner or a project &#x60;admin&#x60; to remove a collaborator.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        void ProjectsRemoveCollaborator (int? projectId, string username);
        /// <summary>
        /// Update a project Updates a project board&#39;s information. Returns a &#x60;404 Not Found&#x60; status if projects are disabled. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="projectsUpdateRequest"></param>
        /// <returns>Project</returns>
        Project ProjectsUpdate (int? projectId, ProjectsUpdateRequest projectsUpdateRequest);
        /// <summary>
        /// Update an existing project card 
        /// </summary>
        /// <param name="cardId">The unique identifier of the card.</param>
        /// <param name="projectsUpdateCardRequest"></param>
        /// <returns>ProjectCard</returns>
        ProjectCard ProjectsUpdateCard (int? cardId, ProjectsUpdateCardRequest projectsUpdateCardRequest);
        /// <summary>
        /// Update an existing project column 
        /// </summary>
        /// <param name="columnId">The unique identifier of the column.</param>
        /// <param name="projectsUpdateColumnRequest"></param>
        /// <returns>ProjectColumn</returns>
        ProjectColumn ProjectsUpdateColumn (int? columnId, ProjectsUpdateColumnRequest projectsUpdateColumnRequest);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProjectsApi : IProjectsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProjectsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient;
            else
                this.ApiClient = apiClient;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProjectsApi(String basePath)
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
        /// Add project collaborator Adds a collaborator to an organization project and sets their permission level. You must be an organization owner or a project &#x60;admin&#x60; to add a collaborator.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="projectsAddCollaboratorRequest"></param>
        /// <returns></returns>
        public void ProjectsAddCollaborator (int? projectId, string username, ProjectsAddCollaboratorRequest projectsAddCollaboratorRequest)
        {
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling ProjectsAddCollaborator");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ProjectsAddCollaborator");
            

            var path = "/projects/{project_id}/collaborators/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));
path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(projectsAddCollaboratorRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsAddCollaborator: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsAddCollaborator: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Create a project card 
        /// </summary>
        /// <param name="columnId">The unique identifier of the column.</param>
        /// <param name="projectsCreateCardRequest"></param>
        /// <returns>ProjectCard</returns>
        public ProjectCard ProjectsCreateCard (int? columnId, ProjectsCreateCardRequest projectsCreateCardRequest)
        {
            
            // verify the required parameter 'columnId' is set
            if (columnId == null) throw new ApiException(400, "Missing required parameter 'columnId' when calling ProjectsCreateCard");
            
            // verify the required parameter 'projectsCreateCardRequest' is set
            if (projectsCreateCardRequest == null) throw new ApiException(400, "Missing required parameter 'projectsCreateCardRequest' when calling ProjectsCreateCard");
            

            var path = "/projects/columns/{column_id}/cards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "column_id" + "}", ApiClient.ParameterToString(columnId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(projectsCreateCardRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsCreateCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsCreateCard: " + response.ErrorMessage, response.ErrorMessage);

            return (ProjectCard) ApiClient.Deserialize(response.Content, typeof(ProjectCard), response.Headers);
        }

        /// <summary>
        /// Create a project column 
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="projectsUpdateColumnRequest"></param>
        /// <returns>ProjectColumn</returns>
        public ProjectColumn ProjectsCreateColumn (int? projectId, ProjectsUpdateColumnRequest projectsUpdateColumnRequest)
        {
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling ProjectsCreateColumn");
            
            // verify the required parameter 'projectsUpdateColumnRequest' is set
            if (projectsUpdateColumnRequest == null) throw new ApiException(400, "Missing required parameter 'projectsUpdateColumnRequest' when calling ProjectsCreateColumn");
            

            var path = "/projects/{project_id}/columns";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(projectsUpdateColumnRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsCreateColumn: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsCreateColumn: " + response.ErrorMessage, response.ErrorMessage);

            return (ProjectColumn) ApiClient.Deserialize(response.Content, typeof(ProjectColumn), response.Headers);
        }

        /// <summary>
        /// Create a user project Creates a user project board. Returns a &#x60;410 Gone&#x60; status if the user does not have existing classic projects. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="projectsCreateForAuthenticatedUserRequest"></param>
        /// <returns>Project</returns>
        public Project ProjectsCreateForAuthenticatedUser (ProjectsCreateForAuthenticatedUserRequest projectsCreateForAuthenticatedUserRequest)
        {
            
            // verify the required parameter 'projectsCreateForAuthenticatedUserRequest' is set
            if (projectsCreateForAuthenticatedUserRequest == null) throw new ApiException(400, "Missing required parameter 'projectsCreateForAuthenticatedUserRequest' when calling ProjectsCreateForAuthenticatedUser");
            

            var path = "/user/projects";
            path = path.Replace("{format}", "json");
            
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(projectsCreateForAuthenticatedUserRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsCreateForAuthenticatedUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsCreateForAuthenticatedUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Project) ApiClient.Deserialize(response.Content, typeof(Project), response.Headers);
        }

        /// <summary>
        /// Create an organization project Creates an organization project board. Returns a &#x60;410 Gone&#x60; status if projects are disabled in the organization or if the organization does not have existing classic projects. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="projectsCreateForOrgRequest"></param>
        /// <returns>Project</returns>
        public Project ProjectsCreateForOrg (string org, ProjectsCreateForOrgRequest projectsCreateForOrgRequest)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ProjectsCreateForOrg");
            
            // verify the required parameter 'projectsCreateForOrgRequest' is set
            if (projectsCreateForOrgRequest == null) throw new ApiException(400, "Missing required parameter 'projectsCreateForOrgRequest' when calling ProjectsCreateForOrg");
            

            var path = "/orgs/{org}/projects";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(projectsCreateForOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsCreateForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsCreateForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (Project) ApiClient.Deserialize(response.Content, typeof(Project), response.Headers);
        }

        /// <summary>
        /// Create a repository project Creates a repository project board. Returns a &#x60;410 Gone&#x60; status if projects are disabled in the repository or if the repository does not have existing classic projects. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="projectsCreateForOrgRequest"></param>
        /// <returns>Project</returns>
        public Project ProjectsCreateForRepo (string owner, string repo, ProjectsCreateForOrgRequest projectsCreateForOrgRequest)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ProjectsCreateForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ProjectsCreateForRepo");
            
            // verify the required parameter 'projectsCreateForOrgRequest' is set
            if (projectsCreateForOrgRequest == null) throw new ApiException(400, "Missing required parameter 'projectsCreateForOrgRequest' when calling ProjectsCreateForRepo");
            

            var path = "/repos/{owner}/{repo}/projects";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(projectsCreateForOrgRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsCreateForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsCreateForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (Project) ApiClient.Deserialize(response.Content, typeof(Project), response.Headers);
        }

        /// <summary>
        /// Delete a project Deletes a project board. Returns a &#x60;404 Not Found&#x60; status if projects are disabled.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <returns></returns>
        public void ProjectsDelete (int? projectId)
        {
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling ProjectsDelete");
            

            var path = "/projects/{project_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsDelete: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a project card 
        /// </summary>
        /// <param name="cardId">The unique identifier of the card.</param>
        /// <returns></returns>
        public void ProjectsDeleteCard (int? cardId)
        {
            
            // verify the required parameter 'cardId' is set
            if (cardId == null) throw new ApiException(400, "Missing required parameter 'cardId' when calling ProjectsDeleteCard");
            

            var path = "/projects/columns/cards/{card_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "card_id" + "}", ApiClient.ParameterToString(cardId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsDeleteCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsDeleteCard: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Delete a project column 
        /// </summary>
        /// <param name="columnId">The unique identifier of the column.</param>
        /// <returns></returns>
        public void ProjectsDeleteColumn (int? columnId)
        {
            
            // verify the required parameter 'columnId' is set
            if (columnId == null) throw new ApiException(400, "Missing required parameter 'columnId' when calling ProjectsDeleteColumn");
            

            var path = "/projects/columns/{column_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "column_id" + "}", ApiClient.ParameterToString(columnId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsDeleteColumn: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsDeleteColumn: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Get a project Gets a project by its &#x60;id&#x60;. Returns a &#x60;404 Not Found&#x60; status if projects are disabled. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <returns>Project</returns>
        public Project ProjectsGet (int? projectId)
        {
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling ProjectsGet");
            

            var path = "/projects/{project_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsGet: " + response.ErrorMessage, response.ErrorMessage);

            return (Project) ApiClient.Deserialize(response.Content, typeof(Project), response.Headers);
        }

        /// <summary>
        /// Get a project card 
        /// </summary>
        /// <param name="cardId">The unique identifier of the card.</param>
        /// <returns>ProjectCard</returns>
        public ProjectCard ProjectsGetCard (int? cardId)
        {
            
            // verify the required parameter 'cardId' is set
            if (cardId == null) throw new ApiException(400, "Missing required parameter 'cardId' when calling ProjectsGetCard");
            

            var path = "/projects/columns/cards/{card_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "card_id" + "}", ApiClient.ParameterToString(cardId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsGetCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsGetCard: " + response.ErrorMessage, response.ErrorMessage);

            return (ProjectCard) ApiClient.Deserialize(response.Content, typeof(ProjectCard), response.Headers);
        }

        /// <summary>
        /// Get a project column 
        /// </summary>
        /// <param name="columnId">The unique identifier of the column.</param>
        /// <returns>ProjectColumn</returns>
        public ProjectColumn ProjectsGetColumn (int? columnId)
        {
            
            // verify the required parameter 'columnId' is set
            if (columnId == null) throw new ApiException(400, "Missing required parameter 'columnId' when calling ProjectsGetColumn");
            

            var path = "/projects/columns/{column_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "column_id" + "}", ApiClient.ParameterToString(columnId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsGetColumn: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsGetColumn: " + response.ErrorMessage, response.ErrorMessage);

            return (ProjectColumn) ApiClient.Deserialize(response.Content, typeof(ProjectColumn), response.Headers);
        }

        /// <summary>
        /// Get project permission for a user Returns the collaborator&#39;s permission level for an organization project. Possible values for the &#x60;permission&#x60; key: &#x60;admin&#x60;, &#x60;write&#x60;, &#x60;read&#x60;, &#x60;none&#x60;. You must be an organization owner or a project &#x60;admin&#x60; to review a user&#39;s permission level.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns>ProjectCollaboratorPermission</returns>
        public ProjectCollaboratorPermission ProjectsGetPermissionForUser (int? projectId, string username)
        {
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling ProjectsGetPermissionForUser");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ProjectsGetPermissionForUser");
            

            var path = "/projects/{project_id}/collaborators/{username}/permission";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsGetPermissionForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsGetPermissionForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (ProjectCollaboratorPermission) ApiClient.Deserialize(response.Content, typeof(ProjectCollaboratorPermission), response.Headers);
        }

        /// <summary>
        /// List project cards 
        /// </summary>
        /// <param name="columnId">The unique identifier of the column.</param>
        /// <param name="archivedState">Filters the project cards that are returned by the card&#39;s state.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;ProjectCard&gt;</returns>
        public List<ProjectCard> ProjectsListCards (int? columnId, string archivedState, int? perPage, int? page)
        {
            
            // verify the required parameter 'columnId' is set
            if (columnId == null) throw new ApiException(400, "Missing required parameter 'columnId' when calling ProjectsListCards");
            

            var path = "/projects/columns/{column_id}/cards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "column_id" + "}", ApiClient.ParameterToString(columnId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (archivedState != null) queryParams.Add("archived_state", ApiClient.ParameterToString(archivedState)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsListCards: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsListCards: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ProjectCard>) ApiClient.Deserialize(response.Content, typeof(List<ProjectCard>), response.Headers);
        }

        /// <summary>
        /// List project collaborators Lists the collaborators for an organization project. For a project, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners. You must be an organization owner or a project &#x60;admin&#x60; to list collaborators.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="affiliation">Filters the collaborators by their affiliation. &#x60;outside&#x60; means outside collaborators of a project that are not a member of the project&#39;s organization. &#x60;direct&#x60; means collaborators with permissions to a project, regardless of organization membership status. &#x60;all&#x60; means all collaborators the authenticated user can see.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;SimpleUser1&gt;</returns>
        public List<SimpleUser1> ProjectsListCollaborators (int? projectId, string affiliation, int? perPage, int? page)
        {
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling ProjectsListCollaborators");
            

            var path = "/projects/{project_id}/collaborators";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (affiliation != null) queryParams.Add("affiliation", ApiClient.ParameterToString(affiliation)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsListCollaborators: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsListCollaborators: " + response.ErrorMessage, response.ErrorMessage);

            return (List<SimpleUser1>) ApiClient.Deserialize(response.Content, typeof(List<SimpleUser1>), response.Headers);
        }

        /// <summary>
        /// List project columns 
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;ProjectColumn&gt;</returns>
        public List<ProjectColumn> ProjectsListColumns (int? projectId, int? perPage, int? page)
        {
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling ProjectsListColumns");
            

            var path = "/projects/{project_id}/columns";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));

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
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsListColumns: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsListColumns: " + response.ErrorMessage, response.ErrorMessage);

            return (List<ProjectColumn>) ApiClient.Deserialize(response.Content, typeof(List<ProjectColumn>), response.Headers);
        }

        /// <summary>
        /// List organization projects Lists the projects in an organization. Returns a &#x60;404 Not Found&#x60; status if projects are disabled in the organization. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="org">The organization name. The name is not case sensitive.</param>
        /// <param name="state">Indicates the state of the projects to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Project&gt;</returns>
        public List<Project> ProjectsListForOrg (string org, string state, int? perPage, int? page)
        {
            
            // verify the required parameter 'org' is set
            if (org == null) throw new ApiException(400, "Missing required parameter 'org' when calling ProjectsListForOrg");
            

            var path = "/orgs/{org}/projects";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "org" + "}", ApiClient.ParameterToString(org));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsListForOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsListForOrg: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Project>) ApiClient.Deserialize(response.Content, typeof(List<Project>), response.Headers);
        }

        /// <summary>
        /// List repository projects Lists the projects in a repository. Returns a &#x60;404 Not Found&#x60; status if projects are disabled in the repository. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="owner">The account owner of the repository. The name is not case sensitive.</param>
        /// <param name="repo">The name of the repository. The name is not case sensitive.</param>
        /// <param name="state">Indicates the state of the projects to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Project&gt;</returns>
        public List<Project> ProjectsListForRepo (string owner, string repo, string state, int? perPage, int? page)
        {
            
            // verify the required parameter 'owner' is set
            if (owner == null) throw new ApiException(400, "Missing required parameter 'owner' when calling ProjectsListForRepo");
            
            // verify the required parameter 'repo' is set
            if (repo == null) throw new ApiException(400, "Missing required parameter 'repo' when calling ProjectsListForRepo");
            

            var path = "/repos/{owner}/{repo}/projects";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "owner" + "}", ApiClient.ParameterToString(owner));
path = path.Replace("{" + "repo" + "}", ApiClient.ParameterToString(repo));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsListForRepo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsListForRepo: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Project>) ApiClient.Deserialize(response.Content, typeof(List<Project>), response.Headers);
        }

        /// <summary>
        /// List user projects 
        /// </summary>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <param name="state">Indicates the state of the projects to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;.</param>
        /// <param name="perPage">The number of results per page (max 100).</param>
        /// <param name="page">Page number of the results to fetch.</param>
        /// <returns>List&lt;Project&gt;</returns>
        public List<Project> ProjectsListForUser (string username, string state, int? perPage, int? page)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ProjectsListForUser");
            

            var path = "/users/{username}/projects";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "username" + "}", ApiClient.ParameterToString(username));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

             if (state != null) queryParams.Add("state", ApiClient.ParameterToString(state)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsListForUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsListForUser: " + response.ErrorMessage, response.ErrorMessage);

            return (List<Project>) ApiClient.Deserialize(response.Content, typeof(List<Project>), response.Headers);
        }

        /// <summary>
        /// Move a project card 
        /// </summary>
        /// <param name="cardId">The unique identifier of the card.</param>
        /// <param name="projectsMoveCardRequest"></param>
        /// <returns>Object</returns>
        public Object ProjectsMoveCard (int? cardId, ProjectsMoveCardRequest projectsMoveCardRequest)
        {
            
            // verify the required parameter 'cardId' is set
            if (cardId == null) throw new ApiException(400, "Missing required parameter 'cardId' when calling ProjectsMoveCard");
            
            // verify the required parameter 'projectsMoveCardRequest' is set
            if (projectsMoveCardRequest == null) throw new ApiException(400, "Missing required parameter 'projectsMoveCardRequest' when calling ProjectsMoveCard");
            

            var path = "/projects/columns/cards/{card_id}/moves";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "card_id" + "}", ApiClient.ParameterToString(cardId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(projectsMoveCardRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsMoveCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsMoveCard: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Move a project column 
        /// </summary>
        /// <param name="columnId">The unique identifier of the column.</param>
        /// <param name="projectsMoveColumnRequest"></param>
        /// <returns>Object</returns>
        public Object ProjectsMoveColumn (int? columnId, ProjectsMoveColumnRequest projectsMoveColumnRequest)
        {
            
            // verify the required parameter 'columnId' is set
            if (columnId == null) throw new ApiException(400, "Missing required parameter 'columnId' when calling ProjectsMoveColumn");
            
            // verify the required parameter 'projectsMoveColumnRequest' is set
            if (projectsMoveColumnRequest == null) throw new ApiException(400, "Missing required parameter 'projectsMoveColumnRequest' when calling ProjectsMoveColumn");
            

            var path = "/projects/columns/{column_id}/moves";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "column_id" + "}", ApiClient.ParameterToString(columnId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(projectsMoveColumnRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsMoveColumn: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsMoveColumn: " + response.ErrorMessage, response.ErrorMessage);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }

        /// <summary>
        /// Remove user as a collaborator Removes a collaborator from an organization project. You must be an organization owner or a project &#x60;admin&#x60; to remove a collaborator.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="username">The handle for the GitHub user account.</param>
        /// <returns></returns>
        public void ProjectsRemoveCollaborator (int? projectId, string username)
        {
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling ProjectsRemoveCollaborator");
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling ProjectsRemoveCollaborator");
            

            var path = "/projects/{project_id}/collaborators/{username}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsRemoveCollaborator: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsRemoveCollaborator: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Update a project Updates a project board&#39;s information. Returns a &#x60;404 Not Found&#x60; status if projects are disabled. If you do not have sufficient privileges to perform this action, a &#x60;401 Unauthorized&#x60; or &#x60;410 Gone&#x60; status is returned.
        /// </summary>
        /// <param name="projectId">The unique identifier of the project.</param>
        /// <param name="projectsUpdateRequest"></param>
        /// <returns>Project</returns>
        public Project ProjectsUpdate (int? projectId, ProjectsUpdateRequest projectsUpdateRequest)
        {
            
            // verify the required parameter 'projectId' is set
            if (projectId == null) throw new ApiException(400, "Missing required parameter 'projectId' when calling ProjectsUpdate");
            

            var path = "/projects/{project_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "project_id" + "}", ApiClient.ParameterToString(projectId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(projectsUpdateRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsUpdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsUpdate: " + response.ErrorMessage, response.ErrorMessage);

            return (Project) ApiClient.Deserialize(response.Content, typeof(Project), response.Headers);
        }

        /// <summary>
        /// Update an existing project card 
        /// </summary>
        /// <param name="cardId">The unique identifier of the card.</param>
        /// <param name="projectsUpdateCardRequest"></param>
        /// <returns>ProjectCard</returns>
        public ProjectCard ProjectsUpdateCard (int? cardId, ProjectsUpdateCardRequest projectsUpdateCardRequest)
        {
            
            // verify the required parameter 'cardId' is set
            if (cardId == null) throw new ApiException(400, "Missing required parameter 'cardId' when calling ProjectsUpdateCard");
            

            var path = "/projects/columns/cards/{card_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "card_id" + "}", ApiClient.ParameterToString(cardId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(projectsUpdateCardRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsUpdateCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsUpdateCard: " + response.ErrorMessage, response.ErrorMessage);

            return (ProjectCard) ApiClient.Deserialize(response.Content, typeof(ProjectCard), response.Headers);
        }

        /// <summary>
        /// Update an existing project column 
        /// </summary>
        /// <param name="columnId">The unique identifier of the column.</param>
        /// <param name="projectsUpdateColumnRequest"></param>
        /// <returns>ProjectColumn</returns>
        public ProjectColumn ProjectsUpdateColumn (int? columnId, ProjectsUpdateColumnRequest projectsUpdateColumnRequest)
        {
            
            // verify the required parameter 'columnId' is set
            if (columnId == null) throw new ApiException(400, "Missing required parameter 'columnId' when calling ProjectsUpdateColumn");
            
            // verify the required parameter 'projectsUpdateColumnRequest' is set
            if (projectsUpdateColumnRequest == null) throw new ApiException(400, "Missing required parameter 'projectsUpdateColumnRequest' when calling ProjectsUpdateColumn");
            

            var path = "/projects/columns/{column_id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "column_id" + "}", ApiClient.ParameterToString(columnId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

                                                postBody = ApiClient.Serialize(projectsUpdateColumnRequest); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };

            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsUpdateColumn: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ProjectsUpdateColumn: " + response.ErrorMessage, response.ErrorMessage);

            return (ProjectColumn) ApiClient.Deserialize(response.Content, typeof(ProjectColumn), response.Headers);
        }

    }
}
