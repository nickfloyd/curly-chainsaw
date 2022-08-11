# Org.OpenAPITools.Api.DependencyGraphApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DependencyGraphCreateRepositorySnapshot**](DependencyGraphApi.md#dependencygraphcreaterepositorysnapshot) | **POST** /repos/{owner}/{repo}/dependency-graph/snapshots | Create a snapshot of dependencies for a repository
[**DependencyGraphDiffRange**](DependencyGraphApi.md#dependencygraphdiffrange) | **GET** /repos/{owner}/{repo}/dependency-graph/compare/{basehead} | Get a diff of the dependencies between commits


<a name="dependencygraphcreaterepositorysnapshot"></a>
# **DependencyGraphCreateRepositorySnapshot**
> DependencyGraphCreateRepositorySnapshot201Response DependencyGraphCreateRepositorySnapshot (string owner, string repo, Snapshot snapshot)

Create a snapshot of dependencies for a repository

Create a new snapshot of a repository's dependencies. You must authenticate using an access token with the `repo` scope to use this endpoint for a repository that the requesting user has access to.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependencyGraphCreateRepositorySnapshotExample
    {
        public void main()
        {
            var apiInstance = new DependencyGraphApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var snapshot = new Snapshot(); // Snapshot | 

            try
            {
                // Create a snapshot of dependencies for a repository
                DependencyGraphCreateRepositorySnapshot201Response result = apiInstance.DependencyGraphCreateRepositorySnapshot(owner, repo, snapshot);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependencyGraphApi.DependencyGraphCreateRepositorySnapshot: " + e.Message );
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
 **snapshot** | [**Snapshot**](Snapshot.md)|  | 

### Return type

[**DependencyGraphCreateRepositorySnapshot201Response**](DependencyGraphCreateRepositorySnapshot201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dependencygraphdiffrange"></a>
# **DependencyGraphDiffRange**
> List<DependencyGraphDiffInner> DependencyGraphDiffRange (string owner, string repo, string basehead, string name)

Get a diff of the dependencies between commits

Gets the diff of the dependency changes between two commits of a repository, based on the changes to the dependency manifests made in those commits.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DependencyGraphDiffRangeExample
    {
        public void main()
        {
            var apiInstance = new DependencyGraphApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var basehead = "basehead_example";  // string | The base and head Git revisions to compare. The Git revisions will be resolved to commit SHAs. Named revisions will be resolved to their corresponding HEAD commits, and an appropriate merge base will be determined. This parameter expects the format `{base}...{head}`.
            var name = "name_example";  // string | The full path, relative to the repository root, of the dependency manifest file. (optional) 

            try
            {
                // Get a diff of the dependencies between commits
                List&lt;DependencyGraphDiffInner&gt; result = apiInstance.DependencyGraphDiffRange(owner, repo, basehead, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DependencyGraphApi.DependencyGraphDiffRange: " + e.Message );
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
 **basehead** | **string**| The base and head Git revisions to compare. The Git revisions will be resolved to commit SHAs. Named revisions will be resolved to their corresponding HEAD commits, and an appropriate merge base will be determined. This parameter expects the format &#x60;{base}...{head}&#x60;. | 
 **name** | **string**| The full path, relative to the repository root, of the dependency manifest file. | [optional] 

### Return type

[**List<DependencyGraphDiffInner>**](DependencyGraphDiffInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

