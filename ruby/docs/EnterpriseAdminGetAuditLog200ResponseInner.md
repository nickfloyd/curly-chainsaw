# OpenapiClient::EnterpriseAdminGetAuditLog200ResponseInner

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **timestamp** | **Integer** | The time the audit log event occurred, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time). | [optional] |
| **action** | **String** | The name of the action that was performed, for example &#x60;user.login&#x60; or &#x60;repo.create&#x60;. | [optional] |
| **active** | **Boolean** |  | [optional] |
| **active_was** | **Boolean** |  | [optional] |
| **actor** | **String** | The actor who performed the action. | [optional] |
| **actor_id** | **Integer** | The id of the actor who performed the action. | [optional] |
| **actor_location** | [**EnterpriseAdminGetAuditLog200ResponseInnerActorLocation**](EnterpriseAdminGetAuditLog200ResponseInnerActorLocation.md) |  | [optional] |
| **data** | **Hash&lt;String, Object&gt;** |  | [optional] |
| **org_id** | **Integer** |  | [optional] |
| **blocked_user** | **String** | The username of the account being blocked. | [optional] |
| **business** | **String** |  | [optional] |
| **config** | **Array&lt;Object&gt;** |  | [optional] |
| **config_was** | **Array&lt;Object&gt;** |  | [optional] |
| **content_type** | **String** |  | [optional] |
| **created_at** | **Integer** | The time the audit log event was recorded, given as a [Unix timestamp](http://en.wikipedia.org/wiki/Unix_time). | [optional] |
| **deploy_key_fingerprint** | **String** |  | [optional] |
| **_document_id** | **String** | A unique identifier for an audit event. | [optional] |
| **emoji** | **String** |  | [optional] |
| **events** | **Array&lt;Object&gt;** |  | [optional] |
| **events_were** | **Array&lt;Object&gt;** |  | [optional] |
| **explanation** | **String** |  | [optional] |
| **fingerprint** | **String** |  | [optional] |
| **hook_id** | **Integer** |  | [optional] |
| **limited_availability** | **Boolean** |  | [optional] |
| **message** | **String** |  | [optional] |
| **name** | **String** |  | [optional] |
| **old_user** | **String** |  | [optional] |
| **openssh_public_key** | **String** |  | [optional] |
| **org** | **String** |  | [optional] |
| **previous_visibility** | **String** |  | [optional] |
| **read_only** | **Boolean** |  | [optional] |
| **repo** | **String** | The name of the repository. | [optional] |
| **repository** | **String** | The name of the repository. | [optional] |
| **repository_public** | **Boolean** |  | [optional] |
| **target_login** | **String** |  | [optional] |
| **team** | **String** |  | [optional] |
| **transport_protocol** | **Integer** | The type of protocol (for example, HTTP or SSH) used to transfer Git data. | [optional] |
| **transport_protocol_name** | **String** | A human readable name for the protocol (for example, HTTP or SSH) used to transfer Git data. | [optional] |
| **user** | **String** | The user that was affected by the action performed (if available). | [optional] |
| **visibility** | **String** | The repository visibility, for example &#x60;public&#x60; or &#x60;private&#x60;. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::EnterpriseAdminGetAuditLog200ResponseInner.new(
  timestamp: null,
  action: null,
  active: null,
  active_was: null,
  actor: null,
  actor_id: null,
  actor_location: null,
  data: null,
  org_id: null,
  blocked_user: null,
  business: null,
  config: null,
  config_was: null,
  content_type: null,
  created_at: null,
  deploy_key_fingerprint: null,
  _document_id: null,
  emoji: null,
  events: null,
  events_were: null,
  explanation: null,
  fingerprint: null,
  hook_id: null,
  limited_availability: null,
  message: null,
  name: null,
  old_user: null,
  openssh_public_key: null,
  org: null,
  previous_visibility: null,
  read_only: null,
  repo: null,
  repository: null,
  repository_public: null,
  target_login: null,
  team: null,
  transport_protocol: null,
  transport_protocol_name: null,
  user: null,
  visibility: null
)
```

