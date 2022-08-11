# Org.OpenAPITools.Model.EnterpriseAdminGetAuditLog200ResponseInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **int?** | The time the audit log event occurred, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time). | [optional] 
**Action** | **string** | The name of the action that was performed, for example &#x60;user.login&#x60; or &#x60;repo.create&#x60;. | [optional] 
**Active** | **bool?** |  | [optional] 
**ActiveWas** | **bool?** |  | [optional] 
**Actor** | **string** | The actor who performed the action. | [optional] 
**ActorId** | **int?** | The id of the actor who performed the action. | [optional] 
**ActorLocation** | [**EnterpriseAdminGetAuditLog200ResponseInnerActorLocation**](EnterpriseAdminGetAuditLog200ResponseInnerActorLocation.md) |  | [optional] 
**Data** | **Dictionary<string, Object>** |  | [optional] 
**OrgId** | **int?** |  | [optional] 
**BlockedUser** | **string** | The username of the account being blocked. | [optional] 
**Business** | **string** |  | [optional] 
**Config** | **List<Object>** |  | [optional] 
**ConfigWas** | **List<Object>** |  | [optional] 
**ContentType** | **string** |  | [optional] 
**CreatedAt** | **int?** | The time the audit log event was recorded, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time). | [optional] 
**DeployKeyFingerprint** | **string** |  | [optional] 
**DocumentId** | **string** | A unique identifier for an audit event. | [optional] 
**Emoji** | **string** |  | [optional] 
**Events** | **List<Object>** |  | [optional] 
**EventsWere** | **List<Object>** |  | [optional] 
**Explanation** | **string** |  | [optional] 
**Fingerprint** | **string** |  | [optional] 
**HookId** | **int?** |  | [optional] 
**LimitedAvailability** | **bool?** |  | [optional] 
**Message** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**OldUser** | **string** |  | [optional] 
**OpensshPublicKey** | **string** |  | [optional] 
**Org** | **string** |  | [optional] 
**PreviousVisibility** | **string** |  | [optional] 
**ReadOnly** | **bool?** |  | [optional] 
**Repo** | **string** | The name of the repository. | [optional] 
**Repository** | **string** | The name of the repository. | [optional] 
**RepositoryPublic** | **bool?** |  | [optional] 
**TargetLogin** | **string** |  | [optional] 
**Team** | **string** |  | [optional] 
**TransportProtocol** | **int?** | The type of protocol (for example, HTTP or SSH) used to transfer Git data. | [optional] 
**TransportProtocolName** | **string** | A human readable name for the protocol (for example, HTTP or SSH) used to transfer Git data. | [optional] 
**User** | **string** | The user that was affected by the action performed (if available). | [optional] 
**Visibility** | **string** | The repository visibility, for example &#x60;public&#x60; or &#x60;private&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

