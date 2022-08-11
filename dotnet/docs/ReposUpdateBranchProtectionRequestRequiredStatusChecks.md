# Org.OpenAPITools.Model.ReposUpdateBranchProtectionRequestRequiredStatusChecks

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Strict** | **bool?** | Require branches to be up to date before merging. | 
**Contexts** | **List<string>** | **Deprecated**: The list of status checks to require in order to merge into this branch. If any of these checks have recently been set by a particular GitHub App, they will be required to come from that app in future for the branch to merge. Use &#x60;checks&#x60; instead of &#x60;contexts&#x60; for more fine-grained control.  | 
**Checks** | [**List<ReposUpdateBranchProtectionRequestRequiredStatusChecksChecksInner>**](ReposUpdateBranchProtectionRequestRequiredStatusChecksChecksInner.md) | The list of status checks to require in order to merge into this branch. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

