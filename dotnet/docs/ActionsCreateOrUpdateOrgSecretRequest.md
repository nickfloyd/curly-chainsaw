# Org.OpenAPITools.Model.ActionsCreateOrUpdateOrgSecretRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EncryptedValue** | **string** | Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get an organization public key](https://docs.github.com/rest/reference/actions#get-an-organization-public-key) endpoint. | [optional] 
**KeyId** | **string** | ID of the key you used to encrypt the secret. | [optional] 
**Visibility** | **string** | Which type of organization repositories have access to the organization secret. &#x60;selected&#x60; means only the repositories specified by &#x60;selected_repository_ids&#x60; can access the secret. | 
**SelectedRepositoryIds** | **List<int?>** | An array of repository ids that can access the organization secret. You can only provide a list of repository ids when the &#x60;visibility&#x60; is set to &#x60;selected&#x60;. You can manage the list of selected repositories using the [List selected repositories for an organization secret](https://docs.github.com/rest/reference/actions#list-selected-repositories-for-an-organization-secret), [Set selected repositories for an organization secret](https://docs.github.com/rest/reference/actions#set-selected-repositories-for-an-organization-secret), and [Remove selected repository from an organization secret](https://docs.github.com/rest/reference/actions#remove-selected-repository-from-an-organization-secret) endpoints. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

