# Org.OpenAPITools.Api.GistsApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GistsCheckIsStarred**](GistsApi.md#gistscheckisstarred) | **GET** /gists/{gist_id}/star | Check if a gist is starred
[**GistsCreate**](GistsApi.md#gistscreate) | **POST** /gists | Create a gist
[**GistsCreateComment**](GistsApi.md#gistscreatecomment) | **POST** /gists/{gist_id}/comments | Create a gist comment
[**GistsDelete**](GistsApi.md#gistsdelete) | **DELETE** /gists/{gist_id} | Delete a gist
[**GistsDeleteComment**](GistsApi.md#gistsdeletecomment) | **DELETE** /gists/{gist_id}/comments/{comment_id} | Delete a gist comment
[**GistsFork**](GistsApi.md#gistsfork) | **POST** /gists/{gist_id}/forks | Fork a gist
[**GistsGet**](GistsApi.md#gistsget) | **GET** /gists/{gist_id} | Get a gist
[**GistsGetComment**](GistsApi.md#gistsgetcomment) | **GET** /gists/{gist_id}/comments/{comment_id} | Get a gist comment
[**GistsGetRevision**](GistsApi.md#gistsgetrevision) | **GET** /gists/{gist_id}/{sha} | Get a gist revision
[**GistsList**](GistsApi.md#gistslist) | **GET** /gists | List gists for the authenticated user
[**GistsListComments**](GistsApi.md#gistslistcomments) | **GET** /gists/{gist_id}/comments | List gist comments
[**GistsListCommits**](GistsApi.md#gistslistcommits) | **GET** /gists/{gist_id}/commits | List gist commits
[**GistsListForUser**](GistsApi.md#gistslistforuser) | **GET** /users/{username}/gists | List gists for a user
[**GistsListForks**](GistsApi.md#gistslistforks) | **GET** /gists/{gist_id}/forks | List gist forks
[**GistsListPublic**](GistsApi.md#gistslistpublic) | **GET** /gists/public | List public gists
[**GistsListStarred**](GistsApi.md#gistsliststarred) | **GET** /gists/starred | List starred gists
[**GistsStar**](GistsApi.md#gistsstar) | **PUT** /gists/{gist_id}/star | Star a gist
[**GistsUnstar**](GistsApi.md#gistsunstar) | **DELETE** /gists/{gist_id}/star | Unstar a gist
[**GistsUpdate**](GistsApi.md#gistsupdate) | **PATCH** /gists/{gist_id} | Update a gist
[**GistsUpdateComment**](GistsApi.md#gistsupdatecomment) | **PATCH** /gists/{gist_id}/comments/{comment_id} | Update a gist comment


<a name="gistscheckisstarred"></a>
# **GistsCheckIsStarred**
> void GistsCheckIsStarred (string gistId)

Check if a gist is starred



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsCheckIsStarredExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.

            try
            {
                // Check if a gist is starred
                apiInstance.GistsCheckIsStarred(gistId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsCheckIsStarred: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistscreate"></a>
# **GistsCreate**
> GistSimple GistsCreate (GistsCreateRequest gistsCreateRequest)

Create a gist

Allows you to add a new gist with one or more files.  **Note:** Don't name your files \"gistfile\" with a numerical suffix. This is the format of the automatic naming scheme that Gist uses internally.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsCreateExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistsCreateRequest = new GistsCreateRequest(); // GistsCreateRequest | 

            try
            {
                // Create a gist
                GistSimple result = apiInstance.GistsCreate(gistsCreateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistsCreateRequest** | [**GistsCreateRequest**](GistsCreateRequest.md)|  | 

### Return type

[**GistSimple**](GistSimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistscreatecomment"></a>
# **GistsCreateComment**
> GistComment GistsCreateComment (string gistId, GistsCreateCommentRequest gistsCreateCommentRequest)

Create a gist comment



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsCreateCommentExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.
            var gistsCreateCommentRequest = new GistsCreateCommentRequest(); // GistsCreateCommentRequest | 

            try
            {
                // Create a gist comment
                GistComment result = apiInstance.GistsCreateComment(gistId, gistsCreateCommentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsCreateComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 
 **gistsCreateCommentRequest** | [**GistsCreateCommentRequest**](GistsCreateCommentRequest.md)|  | 

### Return type

[**GistComment**](GistComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistsdelete"></a>
# **GistsDelete**
> void GistsDelete (string gistId)

Delete a gist



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsDeleteExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.

            try
            {
                // Delete a gist
                apiInstance.GistsDelete(gistId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistsdeletecomment"></a>
# **GistsDeleteComment**
> void GistsDeleteComment (string gistId, int? commentId)

Delete a gist comment



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsDeleteCommentExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.
            var commentId = 56;  // int? | The unique identifier of the comment.

            try
            {
                // Delete a gist comment
                apiInstance.GistsDeleteComment(gistId, commentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsDeleteComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 
 **commentId** | **int?**| The unique identifier of the comment. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistsfork"></a>
# **GistsFork**
> BaseGist GistsFork (string gistId)

Fork a gist



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsForkExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.

            try
            {
                // Fork a gist
                BaseGist result = apiInstance.GistsFork(gistId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsFork: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 

### Return type

[**BaseGist**](BaseGist.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistsget"></a>
# **GistsGet**
> GistSimple GistsGet (string gistId)

Get a gist



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsGetExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.

            try
            {
                // Get a gist
                GistSimple result = apiInstance.GistsGet(gistId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 

### Return type

[**GistSimple**](GistSimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistsgetcomment"></a>
# **GistsGetComment**
> GistComment GistsGetComment (string gistId, int? commentId)

Get a gist comment



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsGetCommentExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.
            var commentId = 56;  // int? | The unique identifier of the comment.

            try
            {
                // Get a gist comment
                GistComment result = apiInstance.GistsGetComment(gistId, commentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsGetComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 
 **commentId** | **int?**| The unique identifier of the comment. | 

### Return type

[**GistComment**](GistComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistsgetrevision"></a>
# **GistsGetRevision**
> GistSimple GistsGetRevision (string gistId, string sha)

Get a gist revision



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsGetRevisionExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.
            var sha = "sha_example";  // string | 

            try
            {
                // Get a gist revision
                GistSimple result = apiInstance.GistsGetRevision(gistId, sha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsGetRevision: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 
 **sha** | **string**|  | 

### Return type

[**GistSimple**](GistSimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistslist"></a>
# **GistsList**
> List<BaseGist> GistsList (DateTime? since, int? perPage, int? page)

List gists for the authenticated user

Lists the authenticated user's gists or if called anonymously, this endpoint returns all public gists:

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsListExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List gists for the authenticated user
                List&lt;BaseGist&gt; result = apiInstance.GistsList(since, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<BaseGist>**](BaseGist.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistslistcomments"></a>
# **GistsListComments**
> List<GistComment> GistsListComments (string gistId, int? perPage, int? page)

List gist comments



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsListCommentsExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List gist comments
                List&lt;GistComment&gt; result = apiInstance.GistsListComments(gistId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsListComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<GistComment>**](GistComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistslistcommits"></a>
# **GistsListCommits**
> List<GistCommit> GistsListCommits (string gistId, int? perPage, int? page)

List gist commits



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsListCommitsExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List gist commits
                List&lt;GistCommit&gt; result = apiInstance.GistsListCommits(gistId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsListCommits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<GistCommit>**](GistCommit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistslistforuser"></a>
# **GistsListForUser**
> List<BaseGist> GistsListForUser (string username, DateTime? since, int? perPage, int? page)

List gists for a user

Lists public gists for the specified user:

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsListForUserExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var username = "username_example";  // string | The handle for the GitHub user account.
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List gists for a user
                List&lt;BaseGist&gt; result = apiInstance.GistsListForUser(username, since, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsListForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **username** | **string**| The handle for the GitHub user account. | 
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<BaseGist>**](BaseGist.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistslistforks"></a>
# **GistsListForks**
> List<GistSimple> GistsListForks (string gistId, int? perPage, int? page)

List gist forks



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsListForksExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List gist forks
                List&lt;GistSimple&gt; result = apiInstance.GistsListForks(gistId, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsListForks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<GistSimple>**](GistSimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistslistpublic"></a>
# **GistsListPublic**
> List<BaseGist> GistsListPublic (DateTime? since, int? perPage, int? page)

List public gists

List public gists sorted by most recently updated to least recently updated.  Note: With [pagination](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination), you can fetch up to 3000 gists. For example, you can fetch 100 pages with 30 gists per page or 30 pages with 100 gists per page.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsListPublicExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List public gists
                List&lt;BaseGist&gt; result = apiInstance.GistsListPublic(since, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsListPublic: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<BaseGist>**](BaseGist.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistsliststarred"></a>
# **GistsListStarred**
> List<BaseGist> GistsListStarred (DateTime? since, int? perPage, int? page)

List starred gists

List the authenticated user's starred gists:

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsListStarredExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. (optional) 
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // List starred gists
                List&lt;BaseGist&gt; result = apiInstance.GistsListStarred(since, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsListStarred: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **since** | **DateTime?**| Only show notifications updated after the given time. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: &#x60;YYYY-MM-DDTHH:MM:SSZ&#x60;. | [optional] 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**List<BaseGist>**](BaseGist.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistsstar"></a>
# **GistsStar**
> void GistsStar (string gistId)

Star a gist

Note that you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see \"[HTTP verbs](https://docs.github.com/rest/overview/resources-in-the-rest-api#http-verbs).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsStarExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.

            try
            {
                // Star a gist
                apiInstance.GistsStar(gistId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsStar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistsunstar"></a>
# **GistsUnstar**
> void GistsUnstar (string gistId)

Unstar a gist



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsUnstarExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.

            try
            {
                // Unstar a gist
                apiInstance.GistsUnstar(gistId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsUnstar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistsupdate"></a>
# **GistsUpdate**
> GistSimple GistsUpdate (string gistId, GistsUpdateRequest gistsUpdateRequest)

Update a gist

Allows you to update or delete a gist file and rename gist files. Files from the previous version of the gist that aren't explicitly changed during an edit are unchanged.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsUpdateExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.
            var gistsUpdateRequest = new GistsUpdateRequest(); // GistsUpdateRequest | 

            try
            {
                // Update a gist
                GistSimple result = apiInstance.GistsUpdate(gistId, gistsUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 
 **gistsUpdateRequest** | [**GistsUpdateRequest**](GistsUpdateRequest.md)|  | 

### Return type

[**GistSimple**](GistSimple.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gistsupdatecomment"></a>
# **GistsUpdateComment**
> GistComment GistsUpdateComment (string gistId, int? commentId, GistsCreateCommentRequest gistsCreateCommentRequest)

Update a gist comment



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GistsUpdateCommentExample
    {
        public void main()
        {
            var apiInstance = new GistsApi();
            var gistId = "gistId_example";  // string | The unique identifier of the gist.
            var commentId = 56;  // int? | The unique identifier of the comment.
            var gistsCreateCommentRequest = new GistsCreateCommentRequest(); // GistsCreateCommentRequest | 

            try
            {
                // Update a gist comment
                GistComment result = apiInstance.GistsUpdateComment(gistId, commentId, gistsCreateCommentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GistsApi.GistsUpdateComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **gistId** | **string**| The unique identifier of the gist. | 
 **commentId** | **int?**| The unique identifier of the comment. | 
 **gistsCreateCommentRequest** | [**GistsCreateCommentRequest**](GistsCreateCommentRequest.md)|  | 

### Return type

[**GistComment**](GistComment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

