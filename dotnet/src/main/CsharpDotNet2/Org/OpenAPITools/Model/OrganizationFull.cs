using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Organization Full
  /// </summary>
  [DataContract]
  public class OrganizationFull {
    /// <summary>
    /// Gets or Sets Login
    /// </summary>
    [DataMember(Name="login", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "login")]
    public string Login { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets ReposUrl
    /// </summary>
    [DataMember(Name="repos_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repos_url")]
    public string ReposUrl { get; set; }

    /// <summary>
    /// Gets or Sets EventsUrl
    /// </summary>
    [DataMember(Name="events_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events_url")]
    public string EventsUrl { get; set; }

    /// <summary>
    /// Gets or Sets HooksUrl
    /// </summary>
    [DataMember(Name="hooks_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hooks_url")]
    public string HooksUrl { get; set; }

    /// <summary>
    /// Gets or Sets IssuesUrl
    /// </summary>
    [DataMember(Name="issues_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues_url")]
    public string IssuesUrl { get; set; }

    /// <summary>
    /// Gets or Sets MembersUrl
    /// </summary>
    [DataMember(Name="members_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_url")]
    public string MembersUrl { get; set; }

    /// <summary>
    /// Gets or Sets PublicMembersUrl
    /// </summary>
    [DataMember(Name="public_members_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_members_url")]
    public string PublicMembersUrl { get; set; }

    /// <summary>
    /// Gets or Sets AvatarUrl
    /// </summary>
    [DataMember(Name="avatar_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar_url")]
    public string AvatarUrl { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Company
    /// </summary>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// Gets or Sets Blog
    /// </summary>
    [DataMember(Name="blog", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blog")]
    public string Blog { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets TwitterUsername
    /// </summary>
    [DataMember(Name="twitter_username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twitter_username")]
    public string TwitterUsername { get; set; }

    /// <summary>
    /// Gets or Sets IsVerified
    /// </summary>
    [DataMember(Name="is_verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_verified")]
    public bool? IsVerified { get; set; }

    /// <summary>
    /// Gets or Sets HasOrganizationProjects
    /// </summary>
    [DataMember(Name="has_organization_projects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_organization_projects")]
    public bool? HasOrganizationProjects { get; set; }

    /// <summary>
    /// Gets or Sets HasRepositoryProjects
    /// </summary>
    [DataMember(Name="has_repository_projects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_repository_projects")]
    public bool? HasRepositoryProjects { get; set; }

    /// <summary>
    /// Gets or Sets PublicRepos
    /// </summary>
    [DataMember(Name="public_repos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_repos")]
    public int? PublicRepos { get; set; }

    /// <summary>
    /// Gets or Sets PublicGists
    /// </summary>
    [DataMember(Name="public_gists", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_gists")]
    public int? PublicGists { get; set; }

    /// <summary>
    /// Gets or Sets Followers
    /// </summary>
    [DataMember(Name="followers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "followers")]
    public int? Followers { get; set; }

    /// <summary>
    /// Gets or Sets Following
    /// </summary>
    [DataMember(Name="following", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "following")]
    public int? Following { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets TotalPrivateRepos
    /// </summary>
    [DataMember(Name="total_private_repos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_private_repos")]
    public int? TotalPrivateRepos { get; set; }

    /// <summary>
    /// Gets or Sets OwnedPrivateRepos
    /// </summary>
    [DataMember(Name="owned_private_repos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owned_private_repos")]
    public int? OwnedPrivateRepos { get; set; }

    /// <summary>
    /// Gets or Sets PrivateGists
    /// </summary>
    [DataMember(Name="private_gists", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private_gists")]
    public int? PrivateGists { get; set; }

    /// <summary>
    /// Gets or Sets DiskUsage
    /// </summary>
    [DataMember(Name="disk_usage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disk_usage")]
    public int? DiskUsage { get; set; }

    /// <summary>
    /// Gets or Sets Collaborators
    /// </summary>
    [DataMember(Name="collaborators", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collaborators")]
    public int? Collaborators { get; set; }

    /// <summary>
    /// Gets or Sets BillingEmail
    /// </summary>
    [DataMember(Name="billing_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_email")]
    public string BillingEmail { get; set; }

    /// <summary>
    /// Gets or Sets Plan
    /// </summary>
    [DataMember(Name="plan", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "plan")]
    public OrganizationFullPlan Plan { get; set; }

    /// <summary>
    /// Gets or Sets DefaultRepositoryPermission
    /// </summary>
    [DataMember(Name="default_repository_permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_repository_permission")]
    public string DefaultRepositoryPermission { get; set; }

    /// <summary>
    /// Gets or Sets MembersCanCreateRepositories
    /// </summary>
    [DataMember(Name="members_can_create_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_repositories")]
    public bool? MembersCanCreateRepositories { get; set; }

    /// <summary>
    /// Gets or Sets TwoFactorRequirementEnabled
    /// </summary>
    [DataMember(Name="two_factor_requirement_enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "two_factor_requirement_enabled")]
    public bool? TwoFactorRequirementEnabled { get; set; }

    /// <summary>
    /// Gets or Sets MembersAllowedRepositoryCreationType
    /// </summary>
    [DataMember(Name="members_allowed_repository_creation_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_allowed_repository_creation_type")]
    public string MembersAllowedRepositoryCreationType { get; set; }

    /// <summary>
    /// Gets or Sets MembersCanCreatePublicRepositories
    /// </summary>
    [DataMember(Name="members_can_create_public_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_public_repositories")]
    public bool? MembersCanCreatePublicRepositories { get; set; }

    /// <summary>
    /// Gets or Sets MembersCanCreatePrivateRepositories
    /// </summary>
    [DataMember(Name="members_can_create_private_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_private_repositories")]
    public bool? MembersCanCreatePrivateRepositories { get; set; }

    /// <summary>
    /// Gets or Sets MembersCanCreateInternalRepositories
    /// </summary>
    [DataMember(Name="members_can_create_internal_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_internal_repositories")]
    public bool? MembersCanCreateInternalRepositories { get; set; }

    /// <summary>
    /// Gets or Sets MembersCanCreatePages
    /// </summary>
    [DataMember(Name="members_can_create_pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_pages")]
    public bool? MembersCanCreatePages { get; set; }

    /// <summary>
    /// Gets or Sets MembersCanCreatePublicPages
    /// </summary>
    [DataMember(Name="members_can_create_public_pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_public_pages")]
    public bool? MembersCanCreatePublicPages { get; set; }

    /// <summary>
    /// Gets or Sets MembersCanCreatePrivatePages
    /// </summary>
    [DataMember(Name="members_can_create_private_pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_private_pages")]
    public bool? MembersCanCreatePrivatePages { get; set; }

    /// <summary>
    /// Gets or Sets MembersCanForkPrivateRepositories
    /// </summary>
    [DataMember(Name="members_can_fork_private_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_fork_private_repositories")]
    public bool? MembersCanForkPrivateRepositories { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrganizationFull {\n");
      sb.Append("  Login: ").Append(Login).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  ReposUrl: ").Append(ReposUrl).Append("\n");
      sb.Append("  EventsUrl: ").Append(EventsUrl).Append("\n");
      sb.Append("  HooksUrl: ").Append(HooksUrl).Append("\n");
      sb.Append("  IssuesUrl: ").Append(IssuesUrl).Append("\n");
      sb.Append("  MembersUrl: ").Append(MembersUrl).Append("\n");
      sb.Append("  PublicMembersUrl: ").Append(PublicMembersUrl).Append("\n");
      sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  Blog: ").Append(Blog).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  TwitterUsername: ").Append(TwitterUsername).Append("\n");
      sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
      sb.Append("  HasOrganizationProjects: ").Append(HasOrganizationProjects).Append("\n");
      sb.Append("  HasRepositoryProjects: ").Append(HasRepositoryProjects).Append("\n");
      sb.Append("  PublicRepos: ").Append(PublicRepos).Append("\n");
      sb.Append("  PublicGists: ").Append(PublicGists).Append("\n");
      sb.Append("  Followers: ").Append(Followers).Append("\n");
      sb.Append("  Following: ").Append(Following).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TotalPrivateRepos: ").Append(TotalPrivateRepos).Append("\n");
      sb.Append("  OwnedPrivateRepos: ").Append(OwnedPrivateRepos).Append("\n");
      sb.Append("  PrivateGists: ").Append(PrivateGists).Append("\n");
      sb.Append("  DiskUsage: ").Append(DiskUsage).Append("\n");
      sb.Append("  Collaborators: ").Append(Collaborators).Append("\n");
      sb.Append("  BillingEmail: ").Append(BillingEmail).Append("\n");
      sb.Append("  Plan: ").Append(Plan).Append("\n");
      sb.Append("  DefaultRepositoryPermission: ").Append(DefaultRepositoryPermission).Append("\n");
      sb.Append("  MembersCanCreateRepositories: ").Append(MembersCanCreateRepositories).Append("\n");
      sb.Append("  TwoFactorRequirementEnabled: ").Append(TwoFactorRequirementEnabled).Append("\n");
      sb.Append("  MembersAllowedRepositoryCreationType: ").Append(MembersAllowedRepositoryCreationType).Append("\n");
      sb.Append("  MembersCanCreatePublicRepositories: ").Append(MembersCanCreatePublicRepositories).Append("\n");
      sb.Append("  MembersCanCreatePrivateRepositories: ").Append(MembersCanCreatePrivateRepositories).Append("\n");
      sb.Append("  MembersCanCreateInternalRepositories: ").Append(MembersCanCreateInternalRepositories).Append("\n");
      sb.Append("  MembersCanCreatePages: ").Append(MembersCanCreatePages).Append("\n");
      sb.Append("  MembersCanCreatePublicPages: ").Append(MembersCanCreatePublicPages).Append("\n");
      sb.Append("  MembersCanCreatePrivatePages: ").Append(MembersCanCreatePrivatePages).Append("\n");
      sb.Append("  MembersCanForkPrivateRepositories: ").Append(MembersCanForkPrivateRepositories).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
