# OpenapiClient::SimpleUser1

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **name** | **String** |  | [optional] |
| **email** | **String** |  | [optional] |
| **login** | **String** |  |  |
| **id** | **Integer** |  |  |
| **node_id** | **String** |  |  |
| **avatar_url** | **String** |  |  |
| **gravatar_id** | **String** |  |  |
| **url** | **String** |  |  |
| **html_url** | **String** |  |  |
| **followers_url** | **String** |  |  |
| **following_url** | **String** |  |  |
| **gists_url** | **String** |  |  |
| **starred_url** | **String** |  |  |
| **subscriptions_url** | **String** |  |  |
| **organizations_url** | **String** |  |  |
| **repos_url** | **String** |  |  |
| **events_url** | **String** |  |  |
| **received_events_url** | **String** |  |  |
| **type** | **String** |  |  |
| **site_admin** | **Boolean** |  |  |
| **starred_at** | **String** |  | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::SimpleUser1.new(
  name: null,
  email: null,
  login: octocat,
  id: 1,
  node_id: MDQ6VXNlcjE&#x3D;,
  avatar_url: https://github.com/images/error/octocat_happy.gif,
  gravatar_id: 41d064eb2195891e12d0413f63227ea7,
  url: https://api.github.com/users/octocat,
  html_url: https://github.com/octocat,
  followers_url: https://api.github.com/users/octocat/followers,
  following_url: https://api.github.com/users/octocat/following{/other_user},
  gists_url: https://api.github.com/users/octocat/gists{/gist_id},
  starred_url: https://api.github.com/users/octocat/starred{/owner}{/repo},
  subscriptions_url: https://api.github.com/users/octocat/subscriptions,
  organizations_url: https://api.github.com/users/octocat/orgs,
  repos_url: https://api.github.com/users/octocat/repos,
  events_url: https://api.github.com/users/octocat/events{/privacy},
  received_events_url: https://api.github.com/users/octocat/received_events,
  type: User,
  site_admin: null,
  starred_at: &quot;2020-07-09T00:17:55Z&quot;
)
```

