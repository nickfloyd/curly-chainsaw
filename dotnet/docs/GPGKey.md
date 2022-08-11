# Org.OpenAPITools.Model.GPGKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** |  | 
**Name** | **string** |  | [optional] 
**PrimaryKeyId** | **int?** |  | 
**KeyId** | **string** |  | 
**PublicKey** | **string** |  | 
**Emails** | [**List<GPGKeyEmailsInner>**](GPGKeyEmailsInner.md) |  | 
**Subkeys** | [**List<GPGKeySubkeysInner>**](GPGKeySubkeysInner.md) |  | 
**CanSign** | **bool?** |  | 
**CanEncryptComms** | **bool?** |  | 
**CanEncryptStorage** | **bool?** |  | 
**CanCertify** | **bool?** |  | 
**CreatedAt** | **DateTime?** |  | 
**ExpiresAt** | **DateTime?** |  | 
**Revoked** | **bool?** |  | 
**RawKey** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

