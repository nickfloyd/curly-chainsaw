# OpenapiClient::AppPermissions

## Properties

| Name | Type | Description | Notes |
| ---- | ---- | ----------- | ----- |
| **actions** | **String** | The level of permission to grant the access token for GitHub Actions workflows, workflow runs, and artifacts. | [optional] |
| **administration** | **String** | The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation. | [optional] |
| **checks** | **String** | The level of permission to grant the access token for checks on code. | [optional] |
| **contents** | **String** | The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges. | [optional] |
| **deployments** | **String** | The level of permission to grant the access token for deployments and deployment statuses. | [optional] |
| **environments** | **String** | The level of permission to grant the access token for managing repository environments. | [optional] |
| **issues** | **String** | The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones. | [optional] |
| **metadata** | **String** | The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata. | [optional] |
| **packages** | **String** | The level of permission to grant the access token for packages published to GitHub Packages. | [optional] |
| **pages** | **String** | The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds. | [optional] |
| **pull_requests** | **String** | The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges. | [optional] |
| **repository_hooks** | **String** | The level of permission to grant the access token to manage the post-receive hooks for a repository. | [optional] |
| **repository_projects** | **String** | The level of permission to grant the access token to manage repository projects, columns, and cards. | [optional] |
| **secret_scanning_alerts** | **String** | The level of permission to grant the access token to view and manage secret scanning alerts. | [optional] |
| **secrets** | **String** | The level of permission to grant the access token to manage repository secrets. | [optional] |
| **security_events** | **String** | The level of permission to grant the access token to view and manage security events like code scanning alerts. | [optional] |
| **single_file** | **String** | The level of permission to grant the access token to manage just a single file. | [optional] |
| **statuses** | **String** | The level of permission to grant the access token for commit statuses. | [optional] |
| **vulnerability_alerts** | **String** | The level of permission to grant the access token to manage Dependabot alerts. | [optional] |
| **workflows** | **String** | The level of permission to grant the access token to update GitHub Actions workflow files. | [optional] |
| **members** | **String** | The level of permission to grant the access token for organization teams and members. | [optional] |
| **organization_administration** | **String** | The level of permission to grant the access token to manage access to an organization. | [optional] |
| **organization_hooks** | **String** | The level of permission to grant the access token to manage the post-receive hooks for an organization. | [optional] |
| **organization_plan** | **String** | The level of permission to grant the access token for viewing an organization&#39;s plan. | [optional] |
| **organization_projects** | **String** | The level of permission to grant the access token to manage organization projects and projects beta (where available). | [optional] |
| **organization_packages** | **String** | The level of permission to grant the access token for organization packages published to GitHub Packages. | [optional] |
| **organization_secrets** | **String** | The level of permission to grant the access token to manage organization secrets. | [optional] |
| **organization_self_hosted_runners** | **String** | The level of permission to grant the access token to view and manage GitHub Actions self-hosted runners available to an organization. | [optional] |
| **organization_user_blocking** | **String** | The level of permission to grant the access token to view and manage users blocked by the organization. | [optional] |
| **team_discussions** | **String** | The level of permission to grant the access token to manage team discussions and related comments. | [optional] |

## Example

```ruby
require 'openapi_client'

instance = OpenapiClient::AppPermissions.new(
  actions: null,
  administration: null,
  checks: null,
  contents: null,
  deployments: null,
  environments: null,
  issues: null,
  metadata: null,
  packages: null,
  pages: null,
  pull_requests: null,
  repository_hooks: null,
  repository_projects: null,
  secret_scanning_alerts: null,
  secrets: null,
  security_events: null,
  single_file: null,
  statuses: null,
  vulnerability_alerts: null,
  workflows: null,
  members: null,
  organization_administration: null,
  organization_hooks: null,
  organization_plan: null,
  organization_projects: null,
  organization_packages: null,
  organization_secrets: null,
  organization_self_hosted_runners: null,
  organization_user_blocking: null,
  team_discussions: null
)
```

