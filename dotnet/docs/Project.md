# Org.OpenAPITools.Model.Project

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OwnerUrl** | **string** |  | 
**Url** | **string** |  | 
**HtmlUrl** | **string** |  | 
**ColumnsUrl** | **string** |  | 
**Id** | **int?** |  | 
**NodeId** | **string** |  | 
**Name** | **string** | Name of the project | 
**Body** | **string** | Body of the project | 
**Number** | **int?** |  | 
**State** | **string** | State of the project; either &#39;open&#39; or &#39;closed&#39; | 
**Creator** | [**SimpleUser**](SimpleUser.md) |  | 
**CreatedAt** | **DateTime?** |  | 
**UpdatedAt** | **DateTime?** |  | 
**OrganizationPermission** | **string** | The baseline permission that all organization members have on this project. Only present if owner is an organization. | [optional] 
**Private** | **bool?** | Whether or not this project can be seen by everyone. Only present if owner is an organization. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

