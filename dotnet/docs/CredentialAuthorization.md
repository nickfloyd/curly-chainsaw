# Org.OpenAPITools.Model.CredentialAuthorization

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Login** | **string** | User login that owns the underlying credential. | 
**CredentialId** | **int?** | Unique identifier for the credential. | 
**CredentialType** | **string** | Human-readable description of the credential type. | 
**TokenLastEight** | **string** | Last eight characters of the credential. Only included in responses with credential_type of personal access token. | [optional] 
**CredentialAuthorizedAt** | **DateTime?** | Date when the credential was authorized for use. | 
**Scopes** | **List<string>** | List of oauth scopes the token has been granted. | [optional] 
**Fingerprint** | **string** | Unique string to distinguish the credential. Only included in responses with credential_type of SSH Key. | [optional] 
**CredentialAccessedAt** | **DateTime?** | Date when the credential was last accessed. May be null if it was never accessed | 
**AuthorizedCredentialId** | **int?** |  | 
**AuthorizedCredentialTitle** | **string** | The title given to the ssh key. This will only be present when the credential is an ssh key. | [optional] 
**AuthorizedCredentialNote** | **string** | The note given to the token. This will only be present when the credential is a token. | [optional] 
**AuthorizedCredentialExpiresAt** | **DateTime?** | The expiry for the token. This will only be present when the credential is a token. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

