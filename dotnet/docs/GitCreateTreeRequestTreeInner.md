# Org.OpenAPITools.Model.GitCreateTreeRequestTreeInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Path** | **string** | The file referenced in the tree. | [optional] 
**Mode** | **string** | The file mode; one of &#x60;100644&#x60; for file (blob), &#x60;100755&#x60; for executable (blob), &#x60;040000&#x60; for subdirectory (tree), &#x60;160000&#x60; for submodule (commit), or &#x60;120000&#x60; for a blob that specifies the path of a symlink. | [optional] 
**Type** | **string** | Either &#x60;blob&#x60;, &#x60;tree&#x60;, or &#x60;commit&#x60;. | [optional] 
**Sha** | **string** | The SHA1 checksum ID of the object in the tree. Also called &#x60;tree.sha&#x60;. If the value is &#x60;null&#x60; then the file will be deleted.      **Note:** Use either &#x60;tree.sha&#x60; or &#x60;content&#x60; to specify the contents of the entry. Using both &#x60;tree.sha&#x60; and &#x60;content&#x60; will return an error. | [optional] 
**Content** | **string** | The content you want this file to have. GitHub will write this blob out and use that SHA for this entry. Use either this, or &#x60;tree.sha&#x60;.      **Note:** Use either &#x60;tree.sha&#x60; or &#x60;content&#x60; to specify the contents of the entry. Using both &#x60;tree.sha&#x60; and &#x60;content&#x60; will return an error. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

