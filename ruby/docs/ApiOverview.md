# OpenapiClient::ApiOverview

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **verifiable_password_authentication** | **Boolean** |  |  |
| **ssh_key_fingerprints** | [**ApiOverviewSshKeyFingerprints**](ApiOverviewSshKeyFingerprints.md) |  | [optional] |
| **ssh_keys** | **Array&lt;String&gt;** |  | [optional] |
| **hooks** | **Array&lt;String&gt;** |  | [optional] |
| **web** | **Array&lt;String&gt;** |  | [optional] |
| **api** | **Array&lt;String&gt;** |  | [optional] |
| **git** | **Array&lt;String&gt;** |  | [optional] |
| **packages** | **Array&lt;String&gt;** |  | [optional] |
| **pages** | **Array&lt;String&gt;** |  | [optional] |
| **importer** | **Array&lt;String&gt;** |  | [optional] |
| **actions** | **Array&lt;String&gt;** |  | [optional] |
| **dependabot** | **Array&lt;String&gt;** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::ApiOverview.new(
  verifiable_password_authentication: true,
  ssh_key_fingerprints: null,
  ssh_keys: [&quot;ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIOMqqnkVzrm0SdG6UOoqKLsabgH5C9okWi0dh2l9GKJl&quot;],
  hooks: [&quot;127.0.0.1/32&quot;],
  web: [&quot;127.0.0.1/32&quot;],
  api: [&quot;127.0.0.1/32&quot;],
  git: [&quot;127.0.0.1/32&quot;],
  packages: [&quot;13.65.0.0/16&quot;,&quot;157.55.204.33/32&quot;,&quot;2a01:111:f403:f90c::/62&quot;],
  pages: [&quot;192.30.252.153/32&quot;,&quot;192.30.252.154/32&quot;],
  importer: [&quot;54.158.161.132&quot;,&quot;54.226.70.38&quot;],
  actions: [&quot;13.64.0.0/16&quot;,&quot;13.65.0.0/16&quot;],
  dependabot: [&quot;192.168.7.15/32&quot;,&quot;192.168.7.16/32&quot;]
)
```

