# Org.OpenAPITools.Api.SearchApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchCode**](SearchApi.md#searchcode) | **GET** /search/code | Search code
[**SearchCommits**](SearchApi.md#searchcommits) | **GET** /search/commits | Search commits
[**SearchIssuesAndPullRequests**](SearchApi.md#searchissuesandpullrequests) | **GET** /search/issues | Search issues and pull requests
[**SearchLabels**](SearchApi.md#searchlabels) | **GET** /search/labels | Search labels
[**SearchRepos**](SearchApi.md#searchrepos) | **GET** /search/repositories | Search repositories
[**SearchTopics**](SearchApi.md#searchtopics) | **GET** /search/topics | Search topics
[**SearchUsers**](SearchApi.md#searchusers) | **GET** /search/users | Search users


<a name="searchcode"></a>
# **SearchCode**
> SearchCode200Response SearchCode (string q, string sort, string order, int? perPage, int? page)

Search code

Searches for query terms inside of a file. This method returns up to 100 results [per page](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination).  When searching for code, you can get text match metadata for the file **content** and file **path** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/reference/search#text-match-metadata).  For example, if you want to find the definition of the `addClass` function inside [jQuery](https://github.com/jquery/jquery) repository, your query would look something like this:  `q=addClass+in:file+language:js+repo:jquery/jquery`  This query searches for the keyword `addClass` within a file's contents. The query limits the search to files where the language is JavaScript in the `jquery/jquery` repository.  #### Considerations for code search  Due to the complexity of searching code, there are a few restrictions on how searches are performed:  *   Only the _default branch_ is considered. In most cases, this will be the `master` branch. *   Only files smaller than 384 KB are searchable. *   You must always include at least one search term when searching source code. For example, searching for [`language:go`](https://github.com/search?utf8=%E2%9C%93&q=language%3Ago&type=Code) is not valid, while [`amazing language:go`](https://github.com/search?utf8=%E2%9C%93&q=amazing+language%3Ago&type=Code) is.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchCodeExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var q = "q_example";  // string | The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query). See \"[Searching code](https://docs.github.com/search-github/searching-on-github/searching-code)\" for a detailed list of qualifiers.
            var sort = "indexed";  // string | Sorts the results of your query. Can only be `indexed`, which indicates how recently a file has been indexed by the GitHub search infrastructure. Default: [best match](https://docs.github.com/rest/reference/search#ranking-search-results) (optional) 
            var order = "desc";  // string | Determines whether the first search result returned is the highest number of matches (`desc`) or lowest number of matches (`asc`). This parameter is ignored unless you provide `sort`. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // Search code
                SearchCode200Response result = apiInstance.SearchCode(q, sort, order, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query). See \&quot;[Searching code](https://docs.github.com/search-github/searching-on-github/searching-code)\&quot; for a detailed list of qualifiers. | 
 **sort** | **string**| Sorts the results of your query. Can only be &#x60;indexed&#x60;, which indicates how recently a file has been indexed by the GitHub search infrastructure. Default: [best match](https://docs.github.com/rest/reference/search#ranking-search-results) | [optional] 
 **order** | **string**| Determines whether the first search result returned is the highest number of matches (&#x60;desc&#x60;) or lowest number of matches (&#x60;asc&#x60;). This parameter is ignored unless you provide &#x60;sort&#x60;. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**SearchCode200Response**](SearchCode200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcommits"></a>
# **SearchCommits**
> SearchCommits200Response SearchCommits (string q, string sort, string order, int? perPage, int? page)

Search commits

Find commits via various criteria on the default branch (usually `master`). This method returns up to 100 results [per page](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination).  When searching for commits, you can get text match metadata for the **message** field when you provide the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/reference/search#text-match-metadata).  For example, if you want to find commits related to CSS in the [octocat/Spoon-Knife](https://github.com/octocat/Spoon-Knife) repository. Your query would look something like this:  `q=repo:octocat/Spoon-Knife+css`

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchCommitsExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var q = "q_example";  // string | The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query). See \"[Searching commits](https://docs.github.com/search-github/searching-on-github/searching-commits)\" for a detailed list of qualifiers.
            var sort = "author-date";  // string | Sorts the results of your query by `author-date` or `committer-date`. Default: [best match](https://docs.github.com/rest/reference/search#ranking-search-results) (optional) 
            var order = "desc";  // string | Determines whether the first search result returned is the highest number of matches (`desc`) or lowest number of matches (`asc`). This parameter is ignored unless you provide `sort`. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // Search commits
                SearchCommits200Response result = apiInstance.SearchCommits(q, sort, order, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchCommits: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query). See \&quot;[Searching commits](https://docs.github.com/search-github/searching-on-github/searching-commits)\&quot; for a detailed list of qualifiers. | 
 **sort** | **string**| Sorts the results of your query by &#x60;author-date&#x60; or &#x60;committer-date&#x60;. Default: [best match](https://docs.github.com/rest/reference/search#ranking-search-results) | [optional] 
 **order** | **string**| Determines whether the first search result returned is the highest number of matches (&#x60;desc&#x60;) or lowest number of matches (&#x60;asc&#x60;). This parameter is ignored unless you provide &#x60;sort&#x60;. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**SearchCommits200Response**](SearchCommits200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchissuesandpullrequests"></a>
# **SearchIssuesAndPullRequests**
> SearchIssuesAndPullRequests200Response SearchIssuesAndPullRequests (string q, string sort, string order, int? perPage, int? page)

Search issues and pull requests

Find issues by state and keyword. This method returns up to 100 results [per page](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination).  When searching for issues, you can get text match metadata for the issue **title**, issue **body**, and issue **comment body** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/reference/search#text-match-metadata).  For example, if you want to find the oldest unresolved Python bugs on Windows. Your query might look something like this.  `q=windows+label:bug+language:python+state:open&sort=created&order=asc`  This query searches for the keyword `windows`, within any open issue that is labeled as `bug`. The search runs across repositories whose primary language is Python. The results are sorted by creation date in ascending order, which means the oldest issues appear first in the search results.  **Note:** For [user-to-server](https://docs.github.com/developers/apps/identifying-and-authorizing-users-for-github-apps#user-to-server-requests) GitHub App requests, you can't retrieve a combination of issues and pull requests in a single query. Requests that don't include the `is:issue` or `is:pull-request` qualifier will receive an HTTP `422 Unprocessable Entity` response. To get results for both issues and pull requests, you must send separate queries for issues and pull requests. For more information about the `is` qualifier, see \"[Searching only issues or pull requests](https://docs.github.com/github/searching-for-information-on-github/searching-issues-and-pull-requests#search-only-issues-or-pull-requests).\"

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchIssuesAndPullRequestsExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var q = "q_example";  // string | The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query). See \"[Searching issues and pull requests](https://docs.github.com/search-github/searching-on-github/searching-issues-and-pull-requests)\" for a detailed list of qualifiers.
            var sort = "comments";  // string | Sorts the results of your query by the number of `comments`, `reactions`, `reactions-+1`, `reactions- -1`, `reactions-smile`, `reactions-thinking_face`, `reactions-heart`, `reactions-tada`, or `interactions`. You can also sort results by how recently the items were `created` or `updated`, Default: [best match](https://docs.github.com/rest/reference/search#ranking-search-results) (optional) 
            var order = "desc";  // string | Determines whether the first search result returned is the highest number of matches (`desc`) or lowest number of matches (`asc`). This parameter is ignored unless you provide `sort`. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // Search issues and pull requests
                SearchIssuesAndPullRequests200Response result = apiInstance.SearchIssuesAndPullRequests(q, sort, order, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchIssuesAndPullRequests: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query). See \&quot;[Searching issues and pull requests](https://docs.github.com/search-github/searching-on-github/searching-issues-and-pull-requests)\&quot; for a detailed list of qualifiers. | 
 **sort** | **string**| Sorts the results of your query by the number of &#x60;comments&#x60;, &#x60;reactions&#x60;, &#x60;reactions-+1&#x60;, &#x60;reactions- -1&#x60;, &#x60;reactions-smile&#x60;, &#x60;reactions-thinking_face&#x60;, &#x60;reactions-heart&#x60;, &#x60;reactions-tada&#x60;, or &#x60;interactions&#x60;. You can also sort results by how recently the items were &#x60;created&#x60; or &#x60;updated&#x60;, Default: [best match](https://docs.github.com/rest/reference/search#ranking-search-results) | [optional] 
 **order** | **string**| Determines whether the first search result returned is the highest number of matches (&#x60;desc&#x60;) or lowest number of matches (&#x60;asc&#x60;). This parameter is ignored unless you provide &#x60;sort&#x60;. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**SearchIssuesAndPullRequests200Response**](SearchIssuesAndPullRequests200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchlabels"></a>
# **SearchLabels**
> SearchLabels200Response SearchLabels (int? repositoryId, string q, string sort, string order, int? perPage, int? page)

Search labels

Find labels in a repository with names or descriptions that match search keywords. Returns up to 100 results [per page](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination).  When searching for labels, you can get text match metadata for the label **name** and **description** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/reference/search#text-match-metadata).  For example, if you want to find labels in the `linguist` repository that match `bug`, `defect`, or `enhancement`. Your query might look like this:  `q=bug+defect+enhancement&repository_id=64778136`  The labels that best match the query appear first in the search results.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchLabelsExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var repositoryId = 56;  // int? | The id of the repository.
            var q = "q_example";  // string | The search keywords. This endpoint does not accept qualifiers in the query. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query).
            var sort = "created";  // string | Sorts the results of your query by when the label was `created` or `updated`. Default: [best match](https://docs.github.com/rest/reference/search#ranking-search-results) (optional) 
            var order = "desc";  // string | Determines whether the first search result returned is the highest number of matches (`desc`) or lowest number of matches (`asc`). This parameter is ignored unless you provide `sort`. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // Search labels
                SearchLabels200Response result = apiInstance.SearchLabels(repositoryId, q, sort, order, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **repositoryId** | **int?**| The id of the repository. | 
 **q** | **string**| The search keywords. This endpoint does not accept qualifiers in the query. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query). | 
 **sort** | **string**| Sorts the results of your query by when the label was &#x60;created&#x60; or &#x60;updated&#x60;. Default: [best match](https://docs.github.com/rest/reference/search#ranking-search-results) | [optional] 
 **order** | **string**| Determines whether the first search result returned is the highest number of matches (&#x60;desc&#x60;) or lowest number of matches (&#x60;asc&#x60;). This parameter is ignored unless you provide &#x60;sort&#x60;. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**SearchLabels200Response**](SearchLabels200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchrepos"></a>
# **SearchRepos**
> SearchRepos200Response SearchRepos (string q, string sort, string order, int? perPage, int? page)

Search repositories

Find repositories via various criteria. This method returns up to 100 results [per page](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination).  When searching for repositories, you can get text match metadata for the **name** and **description** fields when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/reference/search#text-match-metadata).  For example, if you want to search for popular Tetris repositories written in assembly code, your query might look like this:  `q=tetris+language:assembly&sort=stars&order=desc`  This query searches for repositories with the word `tetris` in the name, the description, or the README. The results are limited to repositories where the primary language is assembly. The results are sorted by stars in descending order, so that the most popular repositories appear first in the search results.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchReposExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var q = "q_example";  // string | The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query). See \"[Searching for repositories](https://docs.github.com/articles/searching-for-repositories/)\" for a detailed list of qualifiers.
            var sort = "stars";  // string | Sorts the results of your query by number of `stars`, `forks`, or `help-wanted-issues` or how recently the items were `updated`. Default: [best match](https://docs.github.com/rest/reference/search#ranking-search-results) (optional) 
            var order = "desc";  // string | Determines whether the first search result returned is the highest number of matches (`desc`) or lowest number of matches (`asc`). This parameter is ignored unless you provide `sort`. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // Search repositories
                SearchRepos200Response result = apiInstance.SearchRepos(q, sort, order, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchRepos: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query). See \&quot;[Searching for repositories](https://docs.github.com/articles/searching-for-repositories/)\&quot; for a detailed list of qualifiers. | 
 **sort** | **string**| Sorts the results of your query by number of &#x60;stars&#x60;, &#x60;forks&#x60;, or &#x60;help-wanted-issues&#x60; or how recently the items were &#x60;updated&#x60;. Default: [best match](https://docs.github.com/rest/reference/search#ranking-search-results) | [optional] 
 **order** | **string**| Determines whether the first search result returned is the highest number of matches (&#x60;desc&#x60;) or lowest number of matches (&#x60;asc&#x60;). This parameter is ignored unless you provide &#x60;sort&#x60;. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**SearchRepos200Response**](SearchRepos200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchtopics"></a>
# **SearchTopics**
> SearchTopics200Response SearchTopics (string q, int? perPage, int? page)

Search topics

Find topics via various criteria. Results are sorted by best match. This method returns up to 100 results [per page](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination). See \"[Searching topics](https://docs.github.com/articles/searching-topics/)\" for a detailed list of qualifiers.  When searching for topics, you can get text match metadata for the topic's **short\\_description**, **description**, **name**, or **display\\_name** field when you pass the `text-match` media type. For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/reference/search#text-match-metadata).  For example, if you want to search for topics related to Ruby that are featured on https://github.com/topics. Your query might look like this:  `q=ruby+is:featured`  This query searches for topics with the keyword `ruby` and limits the results to find only topics that are featured. The topics that are the best match for the query appear first in the search results.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchTopicsExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var q = "q_example";  // string | The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query).
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // Search topics
                SearchTopics200Response result = apiInstance.SearchTopics(q, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchTopics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query). | 
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**SearchTopics200Response**](SearchTopics200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchusers"></a>
# **SearchUsers**
> SearchUsers200Response SearchUsers (string q, string sort, string order, int? perPage, int? page)

Search users

Find users via various criteria. This method returns up to 100 results [per page](https://docs.github.com/rest/overview/resources-in-the-rest-api#pagination).  When searching for users, you can get text match metadata for the issue **login**, public **email**, and **name** fields when you pass the `text-match` media type. For more details about highlighting search results, see [Text match metadata](https://docs.github.com/rest/reference/search#text-match-metadata). For more details about how to receive highlighted search results, see [Text match metadata](https://docs.github.com/rest/reference/search#text-match-metadata).  For example, if you're looking for a list of popular users, you might try this query:  `q=tom+repos:%3E42+followers:%3E1000`  This query searches for users with the name `tom`. The results are restricted to users with more than 42 repositories and over 1,000 followers.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SearchUsersExample
    {
        public void main()
        {
            var apiInstance = new SearchApi();
            var q = "q_example";  // string | The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query). See \"[Searching users](https://docs.github.com/search-github/searching-on-github/searching-users)\" for a detailed list of qualifiers.
            var sort = "followers";  // string | Sorts the results of your query by number of `followers` or `repositories`, or when the person `joined` GitHub. Default: [best match](https://docs.github.com/rest/reference/search#ranking-search-results) (optional) 
            var order = "desc";  // string | Determines whether the first search result returned is the highest number of matches (`desc`) or lowest number of matches (`asc`). This parameter is ignored unless you provide `sort`. (optional)  (default to desc)
            var perPage = 30;  // int? | The number of results per page (max 100). (optional)  (default to 30)
            var page = 1;  // int? | Page number of the results to fetch. (optional)  (default to 1)

            try
            {
                // Search users
                SearchUsers200Response result = apiInstance.SearchUsers(q, sort, order, perPage, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| The query contains one or more search keywords and qualifiers. Qualifiers allow you to limit your search to specific areas of GitHub. The REST API supports the same qualifiers as the web interface for GitHub. To learn more about the format of the query, see [Constructing a search query](https://docs.github.com/rest/reference/search#constructing-a-search-query). See \&quot;[Searching users](https://docs.github.com/search-github/searching-on-github/searching-users)\&quot; for a detailed list of qualifiers. | 
 **sort** | **string**| Sorts the results of your query by number of &#x60;followers&#x60; or &#x60;repositories&#x60;, or when the person &#x60;joined&#x60; GitHub. Default: [best match](https://docs.github.com/rest/reference/search#ranking-search-results) | [optional] 
 **order** | **string**| Determines whether the first search result returned is the highest number of matches (&#x60;desc&#x60;) or lowest number of matches (&#x60;asc&#x60;). This parameter is ignored unless you provide &#x60;sort&#x60;. | [optional] [default to desc]
 **perPage** | **int?**| The number of results per page (max 100). | [optional] [default to 30]
 **page** | **int?**| Page number of the results to fetch. | [optional] [default to 1]

### Return type

[**SearchUsers200Response**](SearchUsers200Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

