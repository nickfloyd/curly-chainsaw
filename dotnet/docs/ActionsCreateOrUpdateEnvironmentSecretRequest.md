# Org.OpenAPITools.Model.ActionsCreateOrUpdateEnvironmentSecretRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EncryptedValue** | **string** | Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get an environment public key](https://docs.github.com/rest/reference/actions#get-an-environment-public-key) endpoint. | 
**KeyId** | **string** | ID of the key you used to encrypt the secret. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

