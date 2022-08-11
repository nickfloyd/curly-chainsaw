# Org.OpenAPITools.Api.ProjectsApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProjectsAddCollaborator**](ProjectsApi.md#projectsaddcollaborator) | **PUT** /projects/{project_id}/collaborators/{username} | Add project collaborator
[**ProjectsCreateCard**](ProjectsApi.md#projectscreatecard) | **POST** /projects/columns/{column_id}/cards | Create a project card
[**ProjectsCreateColumn**](ProjectsApi.md#projectscreatecolumn) | **POST** /projects/{project_id}/columns | Create a project column
[**ProjectsCreateForAuthenticatedUser**](ProjectsApi.md#projectscreateforauthenticateduser) | **POST** /user/projects | Create a user project
[**ProjectsCreateForOrg**](ProjectsApi.md#projectscreatefororg) | **POST** /orgs/{org}/projects | Create an organization project
[**ProjectsCreateForRepo**](ProjectsApi.md#projectscreateforrepo) | **POST** /repos/{owner}/{repo}/projects | Create a repository project
[**ProjectsDelete**](ProjectsApi.md#projectsdelete) | **DELETE** /projects/{project_id} | Delete a project
[**ProjectsDeleteCard**](ProjectsApi.md#projectsdeletecard) | **DELETE** /projects/columns/cards/{card_id} | Delete a project card
[**ProjectsDeleteColumn**](ProjectsApi.md#projectsdeletecolumn) | **DELETE** /projects/columns/{column_id} | Delete a project column
[**ProjectsGet**](ProjectsApi.md#projectsget) | **GET** /projects/{project_id} | Get a project
[**ProjectsGetCard**](ProjectsApi.md#projectsgetcard) | **GET** /projects/columns/cards/{card_id} | Get a project card
[**ProjectsGetColumn**](ProjectsApi.md#projectsgetcolumn) | **GET** /projects/columns/{column_id} | Get a project column
[**ProjectsGetPermissionForUser**](ProjectsApi.md#projectsgetpermissionforuser) | **GET** /projects/{project_id}/collaborators/{username}/permission | Get project permission for a user
[**ProjectsListCards**](ProjectsApi.md#projectslistcards) | **GET** /projects/columns/{column_id}/cards | List project cards
[**ProjectsListCollaborators**](ProjectsApi.md#projectslistcollaborators) | **GET** /projects/{project_id}/collaborators | List project collaborators
[**ProjectsListColumns**](ProjectsApi.md#projectslistcolumns) | **GET** /projects/{project_id}/columns | List project columns
[**ProjectsListForOrg**](ProjectsApi.md#projectslistfororg) | **GET** /orgs/{org}/projects | List organization projects
[**ProjectsListForRepo**](ProjectsApi.md#projectslistforrepo) | **GET** /repos/{owner}/{repo}/projects | List repository projects
[**ProjectsListForUser**](ProjectsApi.md#projectslistforuser) | **GET** /users/{username}/projects | List user projects
[**ProjectsMoveCard**](ProjectsApi.md#projectsmovecard) | **POST** /projects/columns/cards/{card_id}/moves | Move a project card
[**ProjectsMoveColumn**](ProjectsApi.md#projectsmovecolumn) | **POST** /projects/columns/{column_id}/moves | Move a project column
[**ProjectsRemoveCollaborator**](ProjectsApi.md#projectsremovecollaborator) | **DELETE** /projects/{project_id}/collaborators/{username} | Remove user as a collaborator
[**ProjectsUpdate**](ProjectsApi.md#projectsupdate) | **PATCH** /projects/{project_id} | Update a project
[**ProjectsUpdateCard**](ProjectsApi.md#projectsupdatecard) | **PATCH** /projects/columns/cards/{card_id} | Update an existing project card
[**ProjectsUpdateColumn**](ProjectsApi.md#projectsupdatecolumn) | **PATCH** /projects/columns/{column_id} | Update an existing project column


<a name="projectsaddcollaborator"></a>
# **ProjectsAddCollaborator**
> void ProjectsAddCollaborator (int? projectId, string username, ProjectsAddCollaboratorRequest projectsAddCollaboratorRequest)

Add project collaborator

Adds a collaborator to an organization project and sets their permission level. You must be an organization owner or a project `admin` to add a collaborator.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsAddCollaboratorExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectId = 56;  // int? | The unique identifier of the project.
            var username = "username_example";  // string | The handle for the GitHub user account.
            var projectsAddCollaboratorRequest = new ProjectsAddCollaboratorRequest(); // ProjectsAddCollaboratorRequest |  (optional) 

            try
            {
                // Add project collaborator
                apiInstance.ProjectsAddCollaborator(projectId, username, projectsAddCollaboratorRequest);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsAddCollaborator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **int?**| The unique identifier of the project. | 
 **username** | **string**| The handle for the GitHub user account. | 
 **projectsAddCollaboratorRequest** | [**ProjectsAddCollaboratorRequest**](ProjectsAddCollaboratorRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectscreatecard"></a>
# **ProjectsCreateCard**
> ProjectCard ProjectsCreateCard (int? columnId, ProjectsCreateCardRequest projectsCreateCardRequest)

Create a project card



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsCreateCardExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var columnId = 56;  // int? | The unique identifier of the column.
            var projectsCreateCardRequest = new ProjectsCreateCardRequest(); // ProjectsCreateCardRequest | 

            try
            {
                // Create a project card
                ProjectCard result = apiInstance.ProjectsCreateCard(columnId, projectsCreateCardRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsCreateCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **columnId** | **int?**| The unique identifier of the column. | 
 **projectsCreateCardRequest** | [**ProjectsCreateCardRequest**](ProjectsCreateCardRequest.md)|  | 

### Return type

[**ProjectCard**](ProjectCard.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectscreatecolumn"></a>
# **ProjectsCreateColumn**
> ProjectColumn ProjectsCreateColumn (int? projectId, ProjectsUpdateColumnRequest projectsUpdateColumnRequest)

Create a project column



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsCreateColumnExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectId = 56;  // int? | The unique identifier of the project.
            var projectsUpdateColumnRequest = new ProjectsUpdateColumnRequest(); // ProjectsUpdateColumnRequest | 

            try
            {
                // Create a project column
                ProjectColumn result = apiInstance.ProjectsCreateColumn(projectId, projectsUpdateColumnRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsCreateColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **int?**| The unique identifier of the project. | 
 **projectsUpdateColumnRequest** | [**ProjectsUpdateColumnRequest**](ProjectsUpdateColumnRequest.md)|  | 

### Return type

[**ProjectColumn**](ProjectColumn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectscreateforauthenticateduser"></a>
# **ProjectsCreateForAuthenticatedUser**
> Project ProjectsCreateForAuthenticatedUser (ProjectsCreateForAuthenticatedUserRequest projectsCreateForAuthenticatedUserRequest)

Create a user project

Creates a user project board. Returns a `410 Gone` status if the user does not have existing classic projects. If you do not have sufficient privileges to perform this action, a `401 Unauthorized` or `410 Gone` status is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsCreateForAuthenticatedUserExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectsCreateForAuthenticatedUserRequest = new ProjectsCreateForAuthenticatedUserRequest(); // ProjectsCreateForAuthenticatedUserRequest | 

            try
            {
                // Create a user project
                Project result = apiInstance.ProjectsCreateForAuthenticatedUser(projectsCreateForAuthenticatedUserRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsCreateForAuthenticatedUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectsCreateForAuthenticatedUserRequest** | [**ProjectsCreateForAuthenticatedUserRequest**](ProjectsCreateForAuthenticatedUserRequest.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectscreatefororg"></a>
# **ProjectsCreateForOrg**
> Project ProjectsCreateForOrg (string org, ProjectsCreateForOrgRequest projectsCreateForOrgRequest)

Create an organization project

Creates an organization project board. Returns a `410 Gone` status if projects are disabled in the organization or if the organization does not have existing classic projects. If you do not have sufficient privileges to perform this action, a `401 Unauthorized` or `410 Gone` status is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsCreateForOrgExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var projectsCreateForOrgRequest = new ProjectsCreateForOrgRequest(); // ProjectsCreateForOrgRequest | 

            try
            {
                // Create an organization project
                Project result = apiInstance.ProjectsCreateForOrg(org, projectsCreateForOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsCreateForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **projectsCreateForOrgRequest** | [**ProjectsCreateForOrgRequest**](ProjectsCreateForOrgRequest.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectscreateforrepo"></a>
# **ProjectsCreateForRepo**
> Project ProjectsCreateForRepo (string owner, string repo, ProjectsCreateForOrgRequest projectsCreateForOrgRequest)

Create a repository project

Creates a repository project board. Returns a `410 Gone` status if projects are disabled in the repository or if the repository does not have existing classic projects. If you do not have sufficient privileges to perform this action, a `401 Unauthorized` or `410 Gone` status is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsCreateForRepoExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var projectsCreateForOrgRequest = new ProjectsCreateForOrgRequest(); // ProjectsCreateForOrgRequest | 

            try
            {
                // Create a repository project
                Project result = apiInstance.ProjectsCreateForRepo(owner, repo, projectsCreateForOrgRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsCreateForRepo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **projectsCreateForOrgRequest** | [**ProjectsCreateForOrgRequest**](ProjectsCreateForOrgRequest.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsdelete"></a>
# **ProjectsDelete**
> void ProjectsDelete (int? projectId)

Delete a project

Deletes a project board. Returns a `404 Not Found` status if projects are disabled.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsDeleteExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectId = 56;  // int? | The unique identifier of the project.

            try
            {
                // Delete a project
                apiInstance.ProjectsDelete(projectId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **int?**| The unique identifier of the project. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsdeletecard"></a>
# **ProjectsDeleteCard**
> void ProjectsDeleteCard (int? cardId)

Delete a project card



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsDeleteCardExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var cardId = 56;  // int? | The unique identifier of the card.

            try
            {
                // Delete a project card
                apiInstance.ProjectsDeleteCard(cardId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsDeleteCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cardId** | **int?**| The unique identifier of the card. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsdeletecolumn"></a>
# **ProjectsDeleteColumn**
> void ProjectsDeleteColumn (int? columnId)

Delete a project column



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsDeleteColumnExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var columnId = 56;  // int? | The unique identifier of the column.

            try
            {
                // Delete a project column
                apiInstance.ProjectsDeleteColumn(columnId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsDeleteColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **columnId** | **int?**| The unique identifier of the column. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsget"></a>
# **ProjectsGet**
> Project ProjectsGet (int? projectId)

Get a project

Gets a project by its `id`. Returns a `404 Not Found` status if projects are disabled. If you do not have sufficient privileges to perform this action, a `401 Unauthorized` or `410 Gone` status is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsGetExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectId = 56;  // int? | The unique identifier of the project.

            try
            {
                // Get a project
                Project result = apiInstance.ProjectsGet(projectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **int?**| The unique identifier of the project. | 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsgetcard"></a>
# **ProjectsGetCard**
> ProjectCard ProjectsGetCard (int? cardId)

Get a project card



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsGetCardExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var cardId = 56;  // int? | The unique identifier of the card.

            try
            {
                // Get a project card
                ProjectCard result = apiInstance.ProjectsGetCard(cardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGetCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cardId** | **int?**| The unique identifier of the card. | 

### Return type

[**ProjectCard**](ProjectCard.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsgetcolumn"></a>
# **ProjectsGetColumn**
> ProjectColumn ProjectsGetColumn (int? columnId)

Get a project column



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsGetColumnExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var columnId = 56;  // int? | The unique identifier of the column.

            try
            {
                // Get a project column
                ProjectColumn result = apiInstance.ProjectsGetColumn(columnId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGetColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **columnId** | **int?**| The unique identifier of the column. | 

### Return type

[**ProjectColumn**](ProjectColumn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsgetpermissionforuser"></a>
# **ProjectsGetPermissionForUser**
> ProjectCollaboratorPermission ProjectsGetPermissionForUser (int? projectId, string username)

Get project permission for a user

Returns the collaborator's permission level for an organization project. Possible values for the `permission` key: `admin`, `write`, `read`, `none`. You must be an organization owner or a project `admin` to review a user's permission level.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsGetPermissionForUserExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectId = 56;  // int? | The unique identifier of the project.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Get project permission for a user
                ProjectCollaboratorPermission result = apiInstance.ProjectsGetPermissionForUser(projectId, username);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGetPermissionForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **int?**| The unique identifier of the project. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

[**ProjectCollaboratorPermission**](ProjectCollaboratorPermission.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectslistcards"></a>
# **ProjectsListCards**
> List<ProjectCard> ProjectsListCards (int? columnId, string archivedState, int? perPage, int? page)

List project cards



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsListCardsExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var columnId = 56;  // int? | The unique identifier of the column.
            var archivedState = "all";  // string | Filters the project cards that are returned by the card's state. (optional)  (default to not_archived)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List project cards
                List&lt;ProjectCard&gt; result = apiInstance.ProjectsListCards(columnId, archivedState, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsListCards: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **columnId** | **int?**| The unique identifier of the column. | 
 **archivedState** | **string**| Filters the project cards that are returned by the card&#39;s state. | [optional] [default to not_archived]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<ProjectCard>**](ProjectCard.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectslistcollaborators"></a>
# **ProjectsListCollaborators**
> List<SimpleUser1> ProjectsListCollaborators (int? projectId, string affiliation, int? perPage, int? page)

List project collaborators

Lists the collaborators for an organization project. For a project, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners. You must be an organization owner or a project `admin` to list collaborators.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsListCollaboratorsExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectId = 56;  // int? | The unique identifier of the project.
            var affiliation = "outside";  // string | Filters the collaborators by their affiliation. `outside` means outside collaborators of a project that are not a member of the project's organization. `direct` means collaborators with permissions to a project, regardless of organization membership status. `all` means all collaborators the authenticated user can see. (optional)  (default to all)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List project collaborators
                List&lt;SimpleUser1&gt; result = apiInstance.ProjectsListCollaborators(projectId, affiliation, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsListCollaborators: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **int?**| The unique identifier of the project. | 
 **affiliation** | **string**| Filters the collaborators by their affiliation. &#x60;outside&#x60; means outside collaborators of a project that are not a member of the project&#39;s organization. &#x60;direct&#x60; means collaborators with permissions to a project, regardless of organization membership status. &#x60;all&#x60; means all collaborators the authenticated user can see. | [optional] [default to all]
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

<a name="projectslistcolumns"></a>
# **ProjectsListColumns**
> List<ProjectColumn> ProjectsListColumns (int? projectId, int? perPage, int? page)

List project columns



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsListColumnsExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectId = 56;  // int? | The unique identifier of the project.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List project columns
                List&lt;ProjectColumn&gt; result = apiInstance.ProjectsListColumns(projectId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsListColumns: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **int?**| The unique identifier of the project. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<ProjectColumn>**](ProjectColumn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectslistfororg"></a>
# **ProjectsListForOrg**
> List<Project> ProjectsListForOrg (string org, string state, int? perPage, int? page)

List organization projects

Lists the projects in an organization. Returns a `404 Not Found` status if projects are disabled in the organization. If you do not have sufficient privileges to perform this action, a `401 Unauthorized` or `410 Gone` status is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsListForOrgExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var org = "org_example";  // string | The organization name. The name is not case sensitive.
            var state = "open";  // string | Indicates the state of the projects to return. Can be either `open`, `closed`, or `all`. (optional)  (default to open)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List organization projects
                List&lt;Project&gt; result = apiInstance.ProjectsListForOrg(org, state, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsListForOrg: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org** | **string**| The organization name. The name is not case sensitive. | 
 **state** | **string**| Indicates the state of the projects to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;. | [optional] [default to open]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Project>**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectslistforrepo"></a>
# **ProjectsListForRepo**
> List<Project> ProjectsListForRepo (string owner, string repo, string state, int? perPage, int? page)

List repository projects

Lists the projects in a repository. Returns a `404 Not Found` status if projects are disabled in the repository. If you do not have sufficient privileges to perform this action, a `401 Unauthorized` or `410 Gone` status is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsListForRepoExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var state = "open";  // string | Indicates the state of the projects to return. Can be either `open`, `closed`, or `all`. (optional)  (default to open)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List repository projects
                List&lt;Project&gt; result = apiInstance.ProjectsListForRepo(owner, repo, state, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsListForRepo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**| The account owner of the repository. The name is not case sensitive. | 
 **repo** | **string**| The name of the repository. The name is not case sensitive. | 
 **state** | **string**| Indicates the state of the projects to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;. | [optional] [default to open]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Project>**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectslistforuser"></a>
# **ProjectsListForUser**
> List<Project> ProjectsListForUser (string username, string state, int? perPage, int? page)

List user projects



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsListForUserExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var state = "open";  // string | Indicates the state of the projects to return. Can be either `open`, `closed`, or `all`. (optional)  (default to open)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List user projects
                List&lt;Project&gt; result = apiInstance.ProjectsListForUser(username, state, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsListForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **state** | **string**| Indicates the state of the projects to return. Can be either &#x60;open&#x60;, &#x60;closed&#x60;, or &#x60;all&#x60;. | [optional] [default to open]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<Project>**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsmovecard"></a>
# **ProjectsMoveCard**
> Object ProjectsMoveCard (int? cardId, ProjectsMoveCardRequest projectsMoveCardRequest)

Move a project card



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsMoveCardExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var cardId = 56;  // int? | The unique identifier of the card.
            var projectsMoveCardRequest = new ProjectsMoveCardRequest(); // ProjectsMoveCardRequest | 

            try
            {
                // Move a project card
                Object result = apiInstance.ProjectsMoveCard(cardId, projectsMoveCardRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsMoveCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cardId** | **int?**| The unique identifier of the card. | 
 **projectsMoveCardRequest** | [**ProjectsMoveCardRequest**](ProjectsMoveCardRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsmovecolumn"></a>
# **ProjectsMoveColumn**
> Object ProjectsMoveColumn (int? columnId, ProjectsMoveColumnRequest projectsMoveColumnRequest)

Move a project column



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsMoveColumnExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var columnId = 56;  // int? | The unique identifier of the column.
            var projectsMoveColumnRequest = new ProjectsMoveColumnRequest(); // ProjectsMoveColumnRequest | 

            try
            {
                // Move a project column
                Object result = apiInstance.ProjectsMoveColumn(columnId, projectsMoveColumnRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsMoveColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **columnId** | **int?**| The unique identifier of the column. | 
 **projectsMoveColumnRequest** | [**ProjectsMoveColumnRequest**](ProjectsMoveColumnRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsremovecollaborator"></a>
# **ProjectsRemoveCollaborator**
> void ProjectsRemoveCollaborator (int? projectId, string username)

Remove user as a collaborator

Removes a collaborator from an organization project. You must be an organization owner or a project `admin` to remove a collaborator.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsRemoveCollaboratorExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectId = 56;  // int? | The unique identifier of the project.
            var username = "username_example";  // string | The handle for the GitHub user account.

            try
            {
                // Remove user as a collaborator
                apiInstance.ProjectsRemoveCollaborator(projectId, username);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsRemoveCollaborator: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **int?**| The unique identifier of the project. | 
 **username** | **string**| The handle for the GitHub user account. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsupdate"></a>
# **ProjectsUpdate**
> Project ProjectsUpdate (int? projectId, ProjectsUpdateRequest projectsUpdateRequest)

Update a project

Updates a project board's information. Returns a `404 Not Found` status if projects are disabled. If you do not have sufficient privileges to perform this action, a `401 Unauthorized` or `410 Gone` status is returned.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsUpdateExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectId = 56;  // int? | The unique identifier of the project.
            var projectsUpdateRequest = new ProjectsUpdateRequest(); // ProjectsUpdateRequest |  (optional) 

            try
            {
                // Update a project
                Project result = apiInstance.ProjectsUpdate(projectId, projectsUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **int?**| The unique identifier of the project. | 
 **projectsUpdateRequest** | [**ProjectsUpdateRequest**](ProjectsUpdateRequest.md)|  | [optional] 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsupdatecard"></a>
# **ProjectsUpdateCard**
> ProjectCard ProjectsUpdateCard (int? cardId, ProjectsUpdateCardRequest projectsUpdateCardRequest)

Update an existing project card



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsUpdateCardExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var cardId = 56;  // int? | The unique identifier of the card.
            var projectsUpdateCardRequest = new ProjectsUpdateCardRequest(); // ProjectsUpdateCardRequest |  (optional) 

            try
            {
                // Update an existing project card
                ProjectCard result = apiInstance.ProjectsUpdateCard(cardId, projectsUpdateCardRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsUpdateCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cardId** | **int?**| The unique identifier of the card. | 
 **projectsUpdateCardRequest** | [**ProjectsUpdateCardRequest**](ProjectsUpdateCardRequest.md)|  | [optional] 

### Return type

[**ProjectCard**](ProjectCard.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsupdatecolumn"></a>
# **ProjectsUpdateColumn**
> ProjectColumn ProjectsUpdateColumn (int? columnId, ProjectsUpdateColumnRequest projectsUpdateColumnRequest)

Update an existing project column



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ProjectsUpdateColumnExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var columnId = 56;  // int? | The unique identifier of the column.
            var projectsUpdateColumnRequest = new ProjectsUpdateColumnRequest(); // ProjectsUpdateColumnRequest | 

            try
            {
                // Update an existing project column
                ProjectColumn result = apiInstance.ProjectsUpdateColumn(columnId, projectsUpdateColumnRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsUpdateColumn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **columnId** | **int?**| The unique identifier of the column. | 
 **projectsUpdateColumnRequest** | [**ProjectsUpdateColumnRequest**](ProjectsUpdateColumnRequest.md)|  | 

### Return type

[**ProjectColumn**](ProjectColumn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

