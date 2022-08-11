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
  public class ReposCreateForAuthenticatedUserRequest {
    /// <summary>
    /// The name of the repository.
    /// </summary>
    /// <value>The name of the repository.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A short description of the repository.
    /// </summary>
    /// <value>A short description of the repository.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// A URL with more information about the repository.
    /// </summary>
    /// <value>A URL with more information about the repository.</value>
    [DataMember(Name="homepage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homepage")]
    public string Homepage { get; set; }

    /// <summary>
    /// Whether the repository is private.
    /// </summary>
    /// <value>Whether the repository is private.</value>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? Private { get; set; }

    /// <summary>
    /// Whether issues are enabled.
    /// </summary>
    /// <value>Whether issues are enabled.</value>
    [DataMember(Name="has_issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_issues")]
    public bool? HasIssues { get; set; }

    /// <summary>
    /// Whether projects are enabled.
    /// </summary>
    /// <value>Whether projects are enabled.</value>
    [DataMember(Name="has_projects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_projects")]
    public bool? HasProjects { get; set; }

    /// <summary>
    /// Whether the wiki is enabled.
    /// </summary>
    /// <value>Whether the wiki is enabled.</value>
    [DataMember(Name="has_wiki", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_wiki")]
    public bool? HasWiki { get; set; }

    /// <summary>
    /// The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.
    /// </summary>
    /// <value>The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.</value>
    [DataMember(Name="team_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team_id")]
    public int? TeamId { get; set; }

    /// <summary>
    /// Whether the repository is initialized with a minimal README.
    /// </summary>
    /// <value>Whether the repository is initialized with a minimal README.</value>
    [DataMember(Name="auto_init", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auto_init")]
    public bool? AutoInit { get; set; }

    /// <summary>
    /// The desired language or platform to apply to the .gitignore.
    /// </summary>
    /// <value>The desired language or platform to apply to the .gitignore.</value>
    [DataMember(Name="gitignore_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gitignore_template")]
    public string GitignoreTemplate { get; set; }

    /// <summary>
    /// The license keyword of the open source license for this repository.
    /// </summary>
    /// <value>The license keyword of the open source license for this repository.</value>
    [DataMember(Name="license_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "license_template")]
    public string LicenseTemplate { get; set; }

    /// <summary>
    /// Whether to allow squash merges for pull requests.
    /// </summary>
    /// <value>Whether to allow squash merges for pull requests.</value>
    [DataMember(Name="allow_squash_merge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_squash_merge")]
    public bool? AllowSquashMerge { get; set; }

    /// <summary>
    /// Whether to allow merge commits for pull requests.
    /// </summary>
    /// <value>Whether to allow merge commits for pull requests.</value>
    [DataMember(Name="allow_merge_commit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_merge_commit")]
    public bool? AllowMergeCommit { get; set; }

    /// <summary>
    /// Whether to allow rebase merges for pull requests.
    /// </summary>
    /// <value>Whether to allow rebase merges for pull requests.</value>
    [DataMember(Name="allow_rebase_merge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_rebase_merge")]
    public bool? AllowRebaseMerge { get; set; }

    /// <summary>
    /// Whether to allow Auto-merge to be used on pull requests.
    /// </summary>
    /// <value>Whether to allow Auto-merge to be used on pull requests.</value>
    [DataMember(Name="allow_auto_merge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_auto_merge")]
    public bool? AllowAutoMerge { get; set; }

    /// <summary>
    /// Whether to delete head branches when pull requests are merged
    /// </summary>
    /// <value>Whether to delete head branches when pull requests are merged</value>
    [DataMember(Name="delete_branch_on_merge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delete_branch_on_merge")]
    public bool? DeleteBranchOnMerge { get; set; }

    /// <summary>
    /// Whether downloads are enabled.
    /// </summary>
    /// <value>Whether downloads are enabled.</value>
    [DataMember(Name="has_downloads", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_downloads")]
    public bool? HasDownloads { get; set; }

    /// <summary>
    /// Whether this repository acts as a template that can be used to generate new repositories.
    /// </summary>
    /// <value>Whether this repository acts as a template that can be used to generate new repositories.</value>
    [DataMember(Name="is_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_template")]
    public bool? IsTemplate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreateForAuthenticatedUserRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Homepage: ").Append(Homepage).Append("\n");
      sb.Append("  Private: ").Append(Private).Append("\n");
      sb.Append("  HasIssues: ").Append(HasIssues).Append("\n");
      sb.Append("  HasProjects: ").Append(HasProjects).Append("\n");
      sb.Append("  HasWiki: ").Append(HasWiki).Append("\n");
      sb.Append("  TeamId: ").Append(TeamId).Append("\n");
      sb.Append("  AutoInit: ").Append(AutoInit).Append("\n");
      sb.Append("  GitignoreTemplate: ").Append(GitignoreTemplate).Append("\n");
      sb.Append("  LicenseTemplate: ").Append(LicenseTemplate).Append("\n");
      sb.Append("  AllowSquashMerge: ").Append(AllowSquashMerge).Append("\n");
      sb.Append("  AllowMergeCommit: ").Append(AllowMergeCommit).Append("\n");
      sb.Append("  AllowRebaseMerge: ").Append(AllowRebaseMerge).Append("\n");
      sb.Append("  AllowAutoMerge: ").Append(AllowAutoMerge).Append("\n");
      sb.Append("  DeleteBranchOnMerge: ").Append(DeleteBranchOnMerge).Append("\n");
      sb.Append("  HasDownloads: ").Append(HasDownloads).Append("\n");
      sb.Append("  IsTemplate: ").Append(IsTemplate).Append("\n");
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
