# Org.OpenAPITools.Model.DependencyGraphCreateRepositorySnapshot201Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | ID of the created snapshot. | 
**CreatedAt** | **string** | The time at which the snapshot was created. | 
**Result** | **string** | Either \&quot;SUCCESS\&quot;, \&quot;ACCEPTED\&quot;, or \&quot;INVALID\&quot;. \&quot;SUCCESS\&quot; indicates that the snapshot was successfully created and the repository&#39;s dependencies were updated. \&quot;ACCEPTED\&quot; indicates that the snapshot was successfully created, but the repository&#39;s dependencies were not updated. \&quot;INVALID\&quot; indicates that the snapshot was malformed. | 
**Message** | **string** | A message providing further details about the result, such as why the dependencies were not updated. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

