using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class OrgsUpdateRequest {
    /// <summary>
    /// Billing email address. This address is not publicized.
    /// </summary>
    /// <value>Billing email address. This address is not publicized.</value>
    [DataMember(Name="billing_email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billing_email")]
    public string BillingEmail { get; set; }

    /// <summary>
    /// The company name.
    /// </summary>
    /// <value>The company name.</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// The publicly visible email address.
    /// </summary>
    /// <value>The publicly visible email address.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The Twitter username of the company.
    /// </summary>
    /// <value>The Twitter username of the company.</value>
    [DataMember(Name="twitter_username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "twitter_username")]
    public string TwitterUsername { get; set; }

    /// <summary>
    /// The location.
    /// </summary>
    /// <value>The location.</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// The shorthand name of the company.
    /// </summary>
    /// <value>The shorthand name of the company.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The description of the company.
    /// </summary>
    /// <value>The description of the company.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Whether an organization can use organization projects.
    /// </summary>
    /// <value>Whether an organization can use organization projects.</value>
    [DataMember(Name="has_organization_projects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_organization_projects")]
    public bool? HasOrganizationProjects { get; set; }

    /// <summary>
    /// Whether repositories that belong to the organization can use repository projects.
    /// </summary>
    /// <value>Whether repositories that belong to the organization can use repository projects.</value>
    [DataMember(Name="has_repository_projects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_repository_projects")]
    public bool? HasRepositoryProjects { get; set; }

    /// <summary>
    /// Default permission level members have for organization repositories.
    /// </summary>
    /// <value>Default permission level members have for organization repositories.</value>
    [DataMember(Name="default_repository_permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_repository_permission")]
    public string DefaultRepositoryPermission { get; set; }

    /// <summary>
    /// Whether of non-admin organization members can create repositories. **Note:** A parameter can override this parameter. See `members_allowed_repository_creation_type` in this table for details.
    /// </summary>
    /// <value>Whether of non-admin organization members can create repositories. **Note:** A parameter can override this parameter. See `members_allowed_repository_creation_type` in this table for details.</value>
    [DataMember(Name="members_can_create_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_repositories")]
    public bool? MembersCanCreateRepositories { get; set; }

    /// <summary>
    /// Whether organization members can create internal repositories, which are visible to all enterprise members. You can only allow members to create internal repositories if your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see \"[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)\" in the GitHub Help documentation.
    /// </summary>
    /// <value>Whether organization members can create internal repositories, which are visible to all enterprise members. You can only allow members to create internal repositories if your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see \"[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)\" in the GitHub Help documentation.</value>
    [DataMember(Name="members_can_create_internal_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_internal_repositories")]
    public bool? MembersCanCreateInternalRepositories { get; set; }

    /// <summary>
    /// Whether organization members can create private repositories, which are visible to organization members with permission. For more information, see \"[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)\" in the GitHub Help documentation.
    /// </summary>
    /// <value>Whether organization members can create private repositories, which are visible to organization members with permission. For more information, see \"[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)\" in the GitHub Help documentation.</value>
    [DataMember(Name="members_can_create_private_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_private_repositories")]
    public bool? MembersCanCreatePrivateRepositories { get; set; }

    /// <summary>
    /// Whether organization members can create public repositories, which are visible to anyone. For more information, see \"[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)\" in the GitHub Help documentation.
    /// </summary>
    /// <value>Whether organization members can create public repositories, which are visible to anyone. For more information, see \"[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)\" in the GitHub Help documentation.</value>
    [DataMember(Name="members_can_create_public_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_public_repositories")]
    public bool? MembersCanCreatePublicRepositories { get; set; }

    /// <summary>
    /// Specifies which types of repositories non-admin organization members can create. `private` is only available to repositories that are part of an organization on GitHub Enterprise Cloud.  **Note:** This parameter is deprecated and will be removed in the future. Its return value ignores internal repositories. Using this parameter overrides values set in `members_can_create_repositories`. See the parameter deprecation notice in the operation description for details.
    /// </summary>
    /// <value>Specifies which types of repositories non-admin organization members can create. `private` is only available to repositories that are part of an organization on GitHub Enterprise Cloud.  **Note:** This parameter is deprecated and will be removed in the future. Its return value ignores internal repositories. Using this parameter overrides values set in `members_can_create_repositories`. See the parameter deprecation notice in the operation description for details.</value>
    [DataMember(Name="members_allowed_repository_creation_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_allowed_repository_creation_type")]
    public string MembersAllowedRepositoryCreationType { get; set; }

    /// <summary>
    /// Whether organization members can create GitHub Pages sites. Existing published sites will not be impacted.
    /// </summary>
    /// <value>Whether organization members can create GitHub Pages sites. Existing published sites will not be impacted.</value>
    [DataMember(Name="members_can_create_pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_pages")]
    public bool? MembersCanCreatePages { get; set; }

    /// <summary>
    /// Whether organization members can create public GitHub Pages sites. Existing published sites will not be impacted.
    /// </summary>
    /// <value>Whether organization members can create public GitHub Pages sites. Existing published sites will not be impacted.</value>
    [DataMember(Name="members_can_create_public_pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_public_pages")]
    public bool? MembersCanCreatePublicPages { get; set; }

    /// <summary>
    /// Whether organization members can create private GitHub Pages sites. Existing published sites will not be impacted.
    /// </summary>
    /// <value>Whether organization members can create private GitHub Pages sites. Existing published sites will not be impacted.</value>
    [DataMember(Name="members_can_create_private_pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_create_private_pages")]
    public bool? MembersCanCreatePrivatePages { get; set; }

    /// <summary>
    /// Whether organization members can fork private organization repositories.
    /// </summary>
    /// <value>Whether organization members can fork private organization repositories.</value>
    [DataMember(Name="members_can_fork_private_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_can_fork_private_repositories")]
    public bool? MembersCanForkPrivateRepositories { get; set; }

    /// <summary>
    /// Gets or Sets Blog
    /// </summary>
    [DataMember(Name="blog", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blog")]
    public string Blog { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrgsUpdateRequest {\n");
      sb.Append("  BillingEmail: ").Append(BillingEmail).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  TwitterUsername: ").Append(TwitterUsername).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  HasOrganizationProjects: ").Append(HasOrganizationProjects).Append("\n");
      sb.Append("  HasRepositoryProjects: ").Append(HasRepositoryProjects).Append("\n");
      sb.Append("  DefaultRepositoryPermission: ").Append(DefaultRepositoryPermission).Append("\n");
      sb.Append("  MembersCanCreateRepositories: ").Append(MembersCanCreateRepositories).Append("\n");
      sb.Append("  MembersCanCreateInternalRepositories: ").Append(MembersCanCreateInternalRepositories).Append("\n");
      sb.Append("  MembersCanCreatePrivateRepositories: ").Append(MembersCanCreatePrivateRepositories).Append("\n");
      sb.Append("  MembersCanCreatePublicRepositories: ").Append(MembersCanCreatePublicRepositories).Append("\n");
      sb.Append("  MembersAllowedRepositoryCreationType: ").Append(MembersAllowedRepositoryCreationType).Append("\n");
      sb.Append("  MembersCanCreatePages: ").Append(MembersCanCreatePages).Append("\n");
      sb.Append("  MembersCanCreatePublicPages: ").Append(MembersCanCreatePublicPages).Append("\n");
      sb.Append("  MembersCanCreatePrivatePages: ").Append(MembersCanCreatePrivatePages).Append("\n");
      sb.Append("  MembersCanForkPrivateRepositories: ").Append(MembersCanForkPrivateRepositories).Append("\n");
      sb.Append("  Blog: ").Append(Blog).Append("\n");
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
