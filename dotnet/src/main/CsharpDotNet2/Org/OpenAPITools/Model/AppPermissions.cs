using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The permissions granted to the user-to-server access token.
  /// </summary>
  [DataContract]
  public class AppPermissions {
    /// <summary>
    /// The level of permission to grant the access token for GitHub Actions workflows, workflow runs, and artifacts.
    /// </summary>
    /// <value>The level of permission to grant the access token for GitHub Actions workflows, workflow runs, and artifacts.</value>
    [DataMember(Name="actions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actions")]
    public string Actions { get; set; }

    /// <summary>
    /// The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation.
    /// </summary>
    /// <value>The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation.</value>
    [DataMember(Name="administration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "administration")]
    public string Administration { get; set; }

    /// <summary>
    /// The level of permission to grant the access token for checks on code.
    /// </summary>
    /// <value>The level of permission to grant the access token for checks on code.</value>
    [DataMember(Name="checks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checks")]
    public string Checks { get; set; }

    /// <summary>
    /// The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges.
    /// </summary>
    /// <value>The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges.</value>
    [DataMember(Name="contents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contents")]
    public string Contents { get; set; }

    /// <summary>
    /// The level of permission to grant the access token for deployments and deployment statuses.
    /// </summary>
    /// <value>The level of permission to grant the access token for deployments and deployment statuses.</value>
    [DataMember(Name="deployments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deployments")]
    public string Deployments { get; set; }

    /// <summary>
    /// The level of permission to grant the access token for managing repository environments.
    /// </summary>
    /// <value>The level of permission to grant the access token for managing repository environments.</value>
    [DataMember(Name="environments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environments")]
    public string Environments { get; set; }

    /// <summary>
    /// The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones.
    /// </summary>
    /// <value>The level of permission to grant the access token for issues and related comments, assignees, labels, and milestones.</value>
    [DataMember(Name="issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues")]
    public string Issues { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata.
    /// </summary>
    /// <value>The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata.</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public string Metadata { get; set; }

    /// <summary>
    /// The level of permission to grant the access token for packages published to GitHub Packages.
    /// </summary>
    /// <value>The level of permission to grant the access token for packages published to GitHub Packages.</value>
    [DataMember(Name="packages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "packages")]
    public string Packages { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds.
    /// </summary>
    /// <value>The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds.</value>
    [DataMember(Name="pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pages")]
    public string Pages { get; set; }

    /// <summary>
    /// The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges.
    /// </summary>
    /// <value>The level of permission to grant the access token for pull requests and related comments, assignees, labels, milestones, and merges.</value>
    [DataMember(Name="pull_requests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pull_requests")]
    public string PullRequests { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to manage the post-receive hooks for a repository.
    /// </summary>
    /// <value>The level of permission to grant the access token to manage the post-receive hooks for a repository.</value>
    [DataMember(Name="repository_hooks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_hooks")]
    public string RepositoryHooks { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to manage repository projects, columns, and cards.
    /// </summary>
    /// <value>The level of permission to grant the access token to manage repository projects, columns, and cards.</value>
    [DataMember(Name="repository_projects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_projects")]
    public string RepositoryProjects { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to view and manage secret scanning alerts.
    /// </summary>
    /// <value>The level of permission to grant the access token to view and manage secret scanning alerts.</value>
    [DataMember(Name="secret_scanning_alerts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret_scanning_alerts")]
    public string SecretScanningAlerts { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to manage repository secrets.
    /// </summary>
    /// <value>The level of permission to grant the access token to manage repository secrets.</value>
    [DataMember(Name="secrets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secrets")]
    public string Secrets { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to view and manage security events like code scanning alerts.
    /// </summary>
    /// <value>The level of permission to grant the access token to view and manage security events like code scanning alerts.</value>
    [DataMember(Name="security_events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security_events")]
    public string SecurityEvents { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to manage just a single file.
    /// </summary>
    /// <value>The level of permission to grant the access token to manage just a single file.</value>
    [DataMember(Name="single_file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "single_file")]
    public string SingleFile { get; set; }

    /// <summary>
    /// The level of permission to grant the access token for commit statuses.
    /// </summary>
    /// <value>The level of permission to grant the access token for commit statuses.</value>
    [DataMember(Name="statuses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statuses")]
    public string Statuses { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to manage Dependabot alerts.
    /// </summary>
    /// <value>The level of permission to grant the access token to manage Dependabot alerts.</value>
    [DataMember(Name="vulnerability_alerts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vulnerability_alerts")]
    public string VulnerabilityAlerts { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to update GitHub Actions workflow files.
    /// </summary>
    /// <value>The level of permission to grant the access token to update GitHub Actions workflow files.</value>
    [DataMember(Name="workflows", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workflows")]
    public string Workflows { get; set; }

    /// <summary>
    /// The level of permission to grant the access token for organization teams and members.
    /// </summary>
    /// <value>The level of permission to grant the access token for organization teams and members.</value>
    [DataMember(Name="members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members")]
    public string Members { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to manage access to an organization.
    /// </summary>
    /// <value>The level of permission to grant the access token to manage access to an organization.</value>
    [DataMember(Name="organization_administration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_administration")]
    public string OrganizationAdministration { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to manage the post-receive hooks for an organization.
    /// </summary>
    /// <value>The level of permission to grant the access token to manage the post-receive hooks for an organization.</value>
    [DataMember(Name="organization_hooks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_hooks")]
    public string OrganizationHooks { get; set; }

    /// <summary>
    /// The level of permission to grant the access token for viewing an organization's plan.
    /// </summary>
    /// <value>The level of permission to grant the access token for viewing an organization's plan.</value>
    [DataMember(Name="organization_plan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_plan")]
    public string OrganizationPlan { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to manage organization projects and projects beta (where available).
    /// </summary>
    /// <value>The level of permission to grant the access token to manage organization projects and projects beta (where available).</value>
    [DataMember(Name="organization_projects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_projects")]
    public string OrganizationProjects { get; set; }

    /// <summary>
    /// The level of permission to grant the access token for organization packages published to GitHub Packages.
    /// </summary>
    /// <value>The level of permission to grant the access token for organization packages published to GitHub Packages.</value>
    [DataMember(Name="organization_packages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_packages")]
    public string OrganizationPackages { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to manage organization secrets.
    /// </summary>
    /// <value>The level of permission to grant the access token to manage organization secrets.</value>
    [DataMember(Name="organization_secrets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_secrets")]
    public string OrganizationSecrets { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to view and manage GitHub Actions self-hosted runners available to an organization.
    /// </summary>
    /// <value>The level of permission to grant the access token to view and manage GitHub Actions self-hosted runners available to an organization.</value>
    [DataMember(Name="organization_self_hosted_runners", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_self_hosted_runners")]
    public string OrganizationSelfHostedRunners { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to view and manage users blocked by the organization.
    /// </summary>
    /// <value>The level of permission to grant the access token to view and manage users blocked by the organization.</value>
    [DataMember(Name="organization_user_blocking", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_user_blocking")]
    public string OrganizationUserBlocking { get; set; }

    /// <summary>
    /// The level of permission to grant the access token to manage team discussions and related comments.
    /// </summary>
    /// <value>The level of permission to grant the access token to manage team discussions and related comments.</value>
    [DataMember(Name="team_discussions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team_discussions")]
    public string TeamDiscussions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppPermissions {\n");
      sb.Append("  Actions: ").Append(Actions).Append("\n");
      sb.Append("  Administration: ").Append(Administration).Append("\n");
      sb.Append("  Checks: ").Append(Checks).Append("\n");
      sb.Append("  Contents: ").Append(Contents).Append("\n");
      sb.Append("  Deployments: ").Append(Deployments).Append("\n");
      sb.Append("  Environments: ").Append(Environments).Append("\n");
      sb.Append("  Issues: ").Append(Issues).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("  Packages: ").Append(Packages).Append("\n");
      sb.Append("  Pages: ").Append(Pages).Append("\n");
      sb.Append("  PullRequests: ").Append(PullRequests).Append("\n");
      sb.Append("  RepositoryHooks: ").Append(RepositoryHooks).Append("\n");
      sb.Append("  RepositoryProjects: ").Append(RepositoryProjects).Append("\n");
      sb.Append("  SecretScanningAlerts: ").Append(SecretScanningAlerts).Append("\n");
      sb.Append("  Secrets: ").Append(Secrets).Append("\n");
      sb.Append("  SecurityEvents: ").Append(SecurityEvents).Append("\n");
      sb.Append("  SingleFile: ").Append(SingleFile).Append("\n");
      sb.Append("  Statuses: ").Append(Statuses).Append("\n");
      sb.Append("  VulnerabilityAlerts: ").Append(VulnerabilityAlerts).Append("\n");
      sb.Append("  Workflows: ").Append(Workflows).Append("\n");
      sb.Append("  Members: ").Append(Members).Append("\n");
      sb.Append("  OrganizationAdministration: ").Append(OrganizationAdministration).Append("\n");
      sb.Append("  OrganizationHooks: ").Append(OrganizationHooks).Append("\n");
      sb.Append("  OrganizationPlan: ").Append(OrganizationPlan).Append("\n");
      sb.Append("  OrganizationProjects: ").Append(OrganizationProjects).Append("\n");
      sb.Append("  OrganizationPackages: ").Append(OrganizationPackages).Append("\n");
      sb.Append("  OrganizationSecrets: ").Append(OrganizationSecrets).Append("\n");
      sb.Append("  OrganizationSelfHostedRunners: ").Append(OrganizationSelfHostedRunners).Append("\n");
      sb.Append("  OrganizationUserBlocking: ").Append(OrganizationUserBlocking).Append("\n");
      sb.Append("  TeamDiscussions: ").Append(TeamDiscussions).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

}
}
