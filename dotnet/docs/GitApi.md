# Org.OpenAPITools.Api.GitApi

All URIs are relative to *https://api.github.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GitCreateBlob**](GitApi.md#gitcreateblob) | **POST** /repos/{owner}/{repo}/git/blobs | Create a blob
[**GitCreateCommit**](GitApi.md#gitcreatecommit) | **POST** /repos/{owner}/{repo}/git/commits | Create a commit
[**GitCreateRef**](GitApi.md#gitcreateref) | **POST** /repos/{owner}/{repo}/git/refs | Create a reference
[**GitCreateTag**](GitApi.md#gitcreatetag) | **POST** /repos/{owner}/{repo}/git/tags | Create a tag object
[**GitCreateTree**](GitApi.md#gitcreatetree) | **POST** /repos/{owner}/{repo}/git/trees | Create a tree
[**GitDeleteRef**](GitApi.md#gitdeleteref) | **DELETE** /repos/{owner}/{repo}/git/refs/{ref} | Delete a reference
[**GitGetBlob**](GitApi.md#gitgetblob) | **GET** /repos/{owner}/{repo}/git/blobs/{file_sha} | Get a blob
[**GitGetCommit**](GitApi.md#gitgetcommit) | **GET** /repos/{owner}/{repo}/git/commits/{commit_sha} | Get a commit
[**GitGetRef**](GitApi.md#gitgetref) | **GET** /repos/{owner}/{repo}/git/ref/{ref} | Get a reference
[**GitGetTag**](GitApi.md#gitgettag) | **GET** /repos/{owner}/{repo}/git/tags/{tag_sha} | Get a tag
[**GitGetTree**](GitApi.md#gitgettree) | **GET** /repos/{owner}/{repo}/git/trees/{tree_sha} | Get a tree
[**GitListMatchingRefs**](GitApi.md#gitlistmatchingrefs) | **GET** /repos/{owner}/{repo}/git/matching-refs/{ref} | List matching references
[**GitUpdateRef**](GitApi.md#gitupdateref) | **PATCH** /repos/{owner}/{repo}/git/refs/{ref} | Update a reference


<a name="gitcreateblob"></a>
# **GitCreateBlob**
> ShortBlob GitCreateBlob (string owner, string repo, GitCreateBlobRequest gitCreateBlobRequest)

Create a blob



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitCreateBlobExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var gitCreateBlobRequest = new GitCreateBlobRequest(); // GitCreateBlobRequest | 

            try
            {
                // Create a blob
                ShortBlob result = apiInstance.GitCreateBlob(owner, repo, gitCreateBlobRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitCreateBlob: " + e.Message );
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
 **gitCreateBlobRequest** | [**GitCreateBlobRequest**](GitCreateBlobRequest.md)|  | 

### Return type

[**ShortBlob**](ShortBlob.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitcreatecommit"></a>
# **GitCreateCommit**
> GitCommit GitCreateCommit (string owner, string repo, GitCreateCommitRequest gitCreateCommitRequest)

Create a commit

Creates a new Git [commit object](https://git-scm.com/book/en/v1/Git-Internals-Git-Objects#Commit-Objects).  **Signature verification object**  The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. | | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in the table below. | | `signature` | `string` | The signature that was extracted from the commit. | | `payload` | `string` | The value that was signed. |  These are the possible values for `reason` in the `verification` object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | `expired_key` | The key that made the signature is expired. | | `not_signing_key` | The \"signing\" flag is not among the usage flags in the GPG key that made the signature. | | `gpgverify_error` | There was an error communicating with the signature verification service. | | `gpgverify_unavailable` | The signature verification service is currently unavailable. | | `unsigned` | The object does not include a signature. | | `unknown_signature_type` | A non-PGP signature was found in the commit. | | `no_user` | No user was associated with the `committer` email address in the commit. | | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on her/his account. | | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. | | `unknown_key` | The key that made the signature has not been registered with any user's account. | | `malformed_signature` | There was an error parsing the signature. | | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | `valid` | None of the above errors applied, so the signature is considered to be verified. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitCreateCommitExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var gitCreateCommitRequest = new GitCreateCommitRequest(); // GitCreateCommitRequest | 

            try
            {
                // Create a commit
                GitCommit result = apiInstance.GitCreateCommit(owner, repo, gitCreateCommitRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitCreateCommit: " + e.Message );
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
 **gitCreateCommitRequest** | [**GitCreateCommitRequest**](GitCreateCommitRequest.md)|  | 

### Return type

[**GitCommit**](GitCommit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitcreateref"></a>
# **GitCreateRef**
> GitReference GitCreateRef (string owner, string repo, GitCreateRefRequest gitCreateRefRequest)

Create a reference

Creates a reference for your repository. You are unable to create new references for empty repositories, even if the commit SHA-1 hash used exists. Empty repositories are repositories without branches.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitCreateRefExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var gitCreateRefRequest = new GitCreateRefRequest(); // GitCreateRefRequest | 

            try
            {
                // Create a reference
                GitReference result = apiInstance.GitCreateRef(owner, repo, gitCreateRefRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitCreateRef: " + e.Message );
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
 **gitCreateRefRequest** | [**GitCreateRefRequest**](GitCreateRefRequest.md)|  | 

### Return type

[**GitReference**](GitReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitcreatetag"></a>
# **GitCreateTag**
> GitTag GitCreateTag (string owner, string repo, GitCreateTagRequest gitCreateTagRequest)

Create a tag object

Note that creating a tag object does not create the reference that makes a tag in Git. If you want to create an annotated tag in Git, you have to do this call to create the tag object, and then [create](https://docs.github.com/rest/reference/git#create-a-reference) the `refs/tags/[tag]` reference. If you want to create a lightweight tag, you only have to [create](https://docs.github.com/rest/reference/git#create-a-reference) the tag reference - this call would be unnecessary.  **Signature verification object**  The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. | | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. | | `signature` | `string` | The signature that was extracted from the commit. | | `payload` | `string` | The value that was signed. |  These are the possible values for `reason` in the `verification` object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | `expired_key` | The key that made the signature is expired. | | `not_signing_key` | The \"signing\" flag is not among the usage flags in the GPG key that made the signature. | | `gpgverify_error` | There was an error communicating with the signature verification service. | | `gpgverify_unavailable` | The signature verification service is currently unavailable. | | `unsigned` | The object does not include a signature. | | `unknown_signature_type` | A non-PGP signature was found in the commit. | | `no_user` | No user was associated with the `committer` email address in the commit. | | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on her/his account. | | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. | | `unknown_key` | The key that made the signature has not been registered with any user's account. | | `malformed_signature` | There was an error parsing the signature. | | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | `valid` | None of the above errors applied, so the signature is considered to be verified. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitCreateTagExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var gitCreateTagRequest = new GitCreateTagRequest(); // GitCreateTagRequest | 

            try
            {
                // Create a tag object
                GitTag result = apiInstance.GitCreateTag(owner, repo, gitCreateTagRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitCreateTag: " + e.Message );
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
 **gitCreateTagRequest** | [**GitCreateTagRequest**](GitCreateTagRequest.md)|  | 

### Return type

[**GitTag**](GitTag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitcreatetree"></a>
# **GitCreateTree**
> GitTree GitCreateTree (string owner, string repo, GitCreateTreeRequest gitCreateTreeRequest)

Create a tree

The tree creation API accepts nested entries. If you specify both a tree and a nested path modifying that tree, this endpoint will overwrite the contents of the tree with the new path contents, and create a new tree structure.  If you use this endpoint to add, delete, or modify the file contents in a tree, you will need to commit the tree and then update a branch to point to the commit. For more information see \"[Create a commit](https://docs.github.com/rest/reference/git#create-a-commit)\" and \"[Update a reference](https://docs.github.com/rest/reference/git#update-a-reference).\"  Returns an error if you try to delete a file that does not exist.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitCreateTreeExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var gitCreateTreeRequest = new GitCreateTreeRequest(); // GitCreateTreeRequest | 

            try
            {
                // Create a tree
                GitTree result = apiInstance.GitCreateTree(owner, repo, gitCreateTreeRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitCreateTree: " + e.Message );
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
 **gitCreateTreeRequest** | [**GitCreateTreeRequest**](GitCreateTreeRequest.md)|  | 

### Return type

[**GitTree**](GitTree.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitdeleteref"></a>
# **GitDeleteRef**
> void GitDeleteRef (string owner, string repo, string _ref)

Delete a reference



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitDeleteRefExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = "_ref_example";  // string | ref parameter

            try
            {
                // Delete a reference
                apiInstance.GitDeleteRef(owner, repo, _ref);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitDeleteRef: " + e.Message );
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
 **_ref** | **string**| ref parameter | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitgetblob"></a>
# **GitGetBlob**
> Blob GitGetBlob (string owner, string repo, string fileSha)

Get a blob

The `content` in the response will always be Base64 encoded.  _Note_: This API supports blobs up to 100 megabytes in size.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitGetBlobExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var fileSha = "fileSha_example";  // string | 

            try
            {
                // Get a blob
                Blob result = apiInstance.GitGetBlob(owner, repo, fileSha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitGetBlob: " + e.Message );
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
 **fileSha** | **string**|  | 

### Return type

[**Blob**](Blob.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitgetcommit"></a>
# **GitGetCommit**
> GitCommit GitGetCommit (string owner, string repo, string commitSha)

Get a commit

Gets a Git [commit object](https://git-scm.com/book/en/v1/Git-Internals-Git-Objects#Commit-Objects).  **Signature verification object**  The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. | | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in the table below. | | `signature` | `string` | The signature that was extracted from the commit. | | `payload` | `string` | The value that was signed. |  These are the possible values for `reason` in the `verification` object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | `expired_key` | The key that made the signature is expired. | | `not_signing_key` | The \"signing\" flag is not among the usage flags in the GPG key that made the signature. | | `gpgverify_error` | There was an error communicating with the signature verification service. | | `gpgverify_unavailable` | The signature verification service is currently unavailable. | | `unsigned` | The object does not include a signature. | | `unknown_signature_type` | A non-PGP signature was found in the commit. | | `no_user` | No user was associated with the `committer` email address in the commit. | | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on her/his account. | | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. | | `unknown_key` | The key that made the signature has not been registered with any user's account. | | `malformed_signature` | There was an error parsing the signature. | | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | `valid` | None of the above errors applied, so the signature is considered to be verified. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitGetCommitExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var commitSha = "commitSha_example";  // string | The SHA of the commit.

            try
            {
                // Get a commit
                GitCommit result = apiInstance.GitGetCommit(owner, repo, commitSha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitGetCommit: " + e.Message );
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
 **commitSha** | **string**| The SHA of the commit. | 

### Return type

[**GitCommit**](GitCommit.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitgetref"></a>
# **GitGetRef**
> GitReference GitGetRef (string owner, string repo, string _ref)

Get a reference

Returns a single reference from your Git database. The `:ref` in the URL must be formatted as `heads/<branch name>` for branches and `tags/<tag name>` for tags. If the `:ref` doesn't match an existing ref, a `404` is returned.  **Note:** You need to explicitly [request a pull request](https://docs.github.com/rest/reference/pulls#get-a-pull-request) to trigger a test merge commit, which checks the mergeability of pull requests. For more information, see \"[Checking mergeability of pull requests](https://docs.github.com/rest/guides/getting-started-with-the-git-database-api#checking-mergeability-of-pull-requests)\".

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitGetRefExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = "_ref_example";  // string | ref parameter

            try
            {
                // Get a reference
                GitReference result = apiInstance.GitGetRef(owner, repo, _ref);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitGetRef: " + e.Message );
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
 **_ref** | **string**| ref parameter | 

### Return type

[**GitReference**](GitReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitgettag"></a>
# **GitGetTag**
> GitTag GitGetTag (string owner, string repo, string tagSha)

Get a tag

**Signature verification object**  The response will include a `verification` object that describes the result of verifying the commit's signature. The following fields are included in the `verification` object:  | Name | Type | Description | | - -- - | - -- - | - -- -- -- -- -- | | `verified` | `boolean` | Indicates whether GitHub considers the signature in this commit to be verified. | | `reason` | `string` | The reason for verified value. Possible values and their meanings are enumerated in table below. | | `signature` | `string` | The signature that was extracted from the commit. | | `payload` | `string` | The value that was signed. |  These are the possible values for `reason` in the `verification` object:  | Value | Description | | - -- -- | - -- -- -- -- -- | | `expired_key` | The key that made the signature is expired. | | `not_signing_key` | The \"signing\" flag is not among the usage flags in the GPG key that made the signature. | | `gpgverify_error` | There was an error communicating with the signature verification service. | | `gpgverify_unavailable` | The signature verification service is currently unavailable. | | `unsigned` | The object does not include a signature. | | `unknown_signature_type` | A non-PGP signature was found in the commit. | | `no_user` | No user was associated with the `committer` email address in the commit. | | `unverified_email` | The `committer` email address in the commit was associated with a user, but the email address is not verified on her/his account. | | `bad_email` | The `committer` email address in the commit is not included in the identities of the PGP key that made the signature. | | `unknown_key` | The key that made the signature has not been registered with any user's account. | | `malformed_signature` | There was an error parsing the signature. | | `invalid` | The signature could not be cryptographically verified using the key whose key-id was found in the signature. | | `valid` | None of the above errors applied, so the signature is considered to be verified. |

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitGetTagExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var tagSha = "tagSha_example";  // string | 

            try
            {
                // Get a tag
                GitTag result = apiInstance.GitGetTag(owner, repo, tagSha);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitGetTag: " + e.Message );
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
 **tagSha** | **string**|  | 

### Return type

[**GitTag**](GitTag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitgettree"></a>
# **GitGetTree**
> GitTree GitGetTree (string owner, string repo, string treeSha, string recursive)

Get a tree

Returns a single tree using the SHA1 value for that tree.  If `truncated` is `true` in the response then the number of items in the `tree` array exceeded our maximum limit. If you need to fetch more items, use the non-recursive method of fetching trees, and fetch one sub-tree at a time.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitGetTreeExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var treeSha = "treeSha_example";  // string | 
            var recursive = "recursive_example";  // string | Setting this parameter to any value returns the objects or subtrees referenced by the tree specified in `:tree_sha`. For example, setting `recursive` to any of the following will enable returning objects or subtrees: `0`, `1`, `\"true\"`, and `\"false\"`. Omit this parameter to prevent recursively returning objects or subtrees. (optional) 

            try
            {
                // Get a tree
                GitTree result = apiInstance.GitGetTree(owner, repo, treeSha, recursive);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitGetTree: " + e.Message );
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
 **treeSha** | **string**|  | 
 **recursive** | **string**| Setting this parameter to any value returns the objects or subtrees referenced by the tree specified in &#x60;:tree_sha&#x60;. For example, setting &#x60;recursive&#x60; to any of the following will enable returning objects or subtrees: &#x60;0&#x60;, &#x60;1&#x60;, &#x60;\&quot;true\&quot;&#x60;, and &#x60;\&quot;false\&quot;&#x60;. Omit this parameter to prevent recursively returning objects or subtrees. | [optional] 

### Return type

[**GitTree**](GitTree.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitlistmatchingrefs"></a>
# **GitListMatchingRefs**
> List<GitReference> GitListMatchingRefs (string owner, string repo, string _ref)

List matching references

Returns an array of references from your Git database that match the supplied name. The `:ref` in the URL must be formatted as `heads/<branch name>` for branches and `tags/<tag name>` for tags. If the `:ref` doesn't exist in the repository, but existing refs start with `:ref`, they will be returned as an array.  When you use this endpoint without providing a `:ref`, it will return an array of all the references from your Git database, including notes and stashes if they exist on the server. Anything in the namespace is returned, not just `heads` and `tags`.  **Note:** You need to explicitly [request a pull request](https://docs.github.com/rest/reference/pulls#get-a-pull-request) to trigger a test merge commit, which checks the mergeability of pull requests. For more information, see \"[Checking mergeability of pull requests](https://docs.github.com/rest/guides/getting-started-with-the-git-database-api#checking-mergeability-of-pull-requests)\".  If you request matching references for a branch named `feature` but the branch `feature` doesn't exist, the response can still include other matching head refs that start with the word `feature`, such as `featureA` and `featureB`.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitListMatchingRefsExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = "_ref_example";  // string | ref parameter

            try
            {
                // List matching references
                List&lt;GitReference&gt; result = apiInstance.GitListMatchingRefs(owner, repo, _ref);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitListMatchingRefs: " + e.Message );
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
 **_ref** | **string**| ref parameter | 

### Return type

[**List<GitReference>**](GitReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gitupdateref"></a>
# **GitUpdateRef**
> GitReference GitUpdateRef (string owner, string repo, string _ref, GitUpdateRefRequest gitUpdateRefRequest)

Update a reference



### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GitUpdateRefExample
    {
        public void main()
        {
            var apiInstance = new GitApi();
            var owner = "owner_example";  // string | The account owner of the repository. The name is not case sensitive.
            var repo = "repo_example";  // string | The name of the repository. The name is not case sensitive.
            var _ref = refs/head/master;  // string | The name of the fully qualified reference to update. For example, `refs/heads/master`. If the value doesn't start with `refs` and have at least two slashes, it will be rejected.
            var gitUpdateRefRequest = new GitUpdateRefRequest(); // GitUpdateRefRequest | 

            try
            {
                // Update a reference
                GitReference result = apiInstance.GitUpdateRef(owner, repo, _ref, gitUpdateRefRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GitApi.GitUpdateRef: " + e.Message );
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
 **_ref** | **string**| The name of the fully qualified reference to update. For example, &#x60;refs/heads/master&#x60;. If the value doesn&#39;t start with &#x60;refs&#x60; and have at least two slashes, it will be rejected. | 
 **gitUpdateRefRequest** | [**GitUpdateRefRequest**](GitUpdateRefRequest.md)|  | 

### Return type

[**GitReference**](GitReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

