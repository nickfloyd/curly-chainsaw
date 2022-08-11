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
  public class ReposUpdateRequest {
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
    /// Either `true` to make the repository private or `false` to make it public. Default: `false`.   **Note**: You will get a `422` error if the organization restricts [changing repository visibility](https://docs.github.com/articles/repository-permission-levels-for-an-organization#changing-the-visibility-of-repositories) to organization owners and a non-owner tries to change the value of private.
    /// </summary>
    /// <value>Either `true` to make the repository private or `false` to make it public. Default: `false`.   **Note**: You will get a `422` error if the organization restricts [changing repository visibility](https://docs.github.com/articles/repository-permission-levels-for-an-organization#changing-the-visibility-of-repositories) to organization owners and a non-owner tries to change the value of private.</value>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? Private { get; set; }

    /// <summary>
    /// Can be `public` or `private`. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, `visibility` can also be `internal`.\"
    /// </summary>
    /// <value>Can be `public` or `private`. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, `visibility` can also be `internal`.\"</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public string Visibility { get; set; }

    /// <summary>
    /// Gets or Sets SecurityAndAnalysis
    /// </summary>
    [DataMember(Name="security_and_analysis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "security_and_analysis")]
    public ReposUpdateRequestSecurityAndAnalysis SecurityAndAnalysis { get; set; }

    /// <summary>
    /// Either `true` to enable issues for this repository or `false` to disable them.
    /// </summary>
    /// <value>Either `true` to enable issues for this repository or `false` to disable them.</value>
    [DataMember(Name="has_issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_issues")]
    public bool? HasIssues { get; set; }

    /// <summary>
    /// Either `true` to enable projects for this repository or `false` to disable them. **Note:** If you're creating a repository in an organization that has disabled repository projects, the default is `false`, and if you pass `true`, the API returns an error.
    /// </summary>
    /// <value>Either `true` to enable projects for this repository or `false` to disable them. **Note:** If you're creating a repository in an organization that has disabled repository projects, the default is `false`, and if you pass `true`, the API returns an error.</value>
    [DataMember(Name="has_projects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_projects")]
    public bool? HasProjects { get; set; }

    /// <summary>
    /// Either `true` to enable the wiki for this repository or `false` to disable it.
    /// </summary>
    /// <value>Either `true` to enable the wiki for this repository or `false` to disable it.</value>
    [DataMember(Name="has_wiki", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_wiki")]
    public bool? HasWiki { get; set; }

    /// <summary>
    /// Either `true` to make this repo available as a template repository or `false` to prevent it.
    /// </summary>
    /// <value>Either `true` to make this repo available as a template repository or `false` to prevent it.</value>
    [DataMember(Name="is_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_template")]
    public bool? IsTemplate { get; set; }

    /// <summary>
    /// Updates the default branch for this repository.
    /// </summary>
    /// <value>Updates the default branch for this repository.</value>
    [DataMember(Name="default_branch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_branch")]
    public string DefaultBranch { get; set; }

    /// <summary>
    /// Either `true` to allow squash-merging pull requests, or `false` to prevent squash-merging.
    /// </summary>
    /// <value>Either `true` to allow squash-merging pull requests, or `false` to prevent squash-merging.</value>
    [DataMember(Name="allow_squash_merge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_squash_merge")]
    public bool? AllowSquashMerge { get; set; }

    /// <summary>
    /// Either `true` to allow merging pull requests with a merge commit, or `false` to prevent merging pull requests with merge commits.
    /// </summary>
    /// <value>Either `true` to allow merging pull requests with a merge commit, or `false` to prevent merging pull requests with merge commits.</value>
    [DataMember(Name="allow_merge_commit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_merge_commit")]
    public bool? AllowMergeCommit { get; set; }

    /// <summary>
    /// Either `true` to allow rebase-merging pull requests, or `false` to prevent rebase-merging.
    /// </summary>
    /// <value>Either `true` to allow rebase-merging pull requests, or `false` to prevent rebase-merging.</value>
    [DataMember(Name="allow_rebase_merge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_rebase_merge")]
    public bool? AllowRebaseMerge { get; set; }

    /// <summary>
    /// Either `true` to allow auto-merge on pull requests, or `false` to disallow auto-merge.
    /// </summary>
    /// <value>Either `true` to allow auto-merge on pull requests, or `false` to disallow auto-merge.</value>
    [DataMember(Name="allow_auto_merge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_auto_merge")]
    public bool? AllowAutoMerge { get; set; }

    /// <summary>
    /// Either `true` to allow automatically deleting head branches when pull requests are merged, or `false` to prevent automatic deletion.
    /// </summary>
    /// <value>Either `true` to allow automatically deleting head branches when pull requests are merged, or `false` to prevent automatic deletion.</value>
    [DataMember(Name="delete_branch_on_merge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delete_branch_on_merge")]
    public bool? DeleteBranchOnMerge { get; set; }

    /// <summary>
    /// Either `true` to always allow a pull request head branch that is behind its base branch to be updated even if it is not required to be up to date before merging, or false otherwise.
    /// </summary>
    /// <value>Either `true` to always allow a pull request head branch that is behind its base branch to be updated even if it is not required to be up to date before merging, or false otherwise.</value>
    [DataMember(Name="allow_update_branch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_update_branch")]
    public bool? AllowUpdateBranch { get; set; }

    /// <summary>
    /// Either `true` to allow squash-merge commits to use pull request title, or `false` to use commit message.
    /// </summary>
    /// <value>Either `true` to allow squash-merge commits to use pull request title, or `false` to use commit message.</value>
    [DataMember(Name="use_squash_pr_title_as_default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "use_squash_pr_title_as_default")]
    public bool? UseSquashPrTitleAsDefault { get; set; }

    /// <summary>
    /// `true` to archive this repository. **Note**: You cannot unarchive repositories through the API.
    /// </summary>
    /// <value>`true` to archive this repository. **Note**: You cannot unarchive repositories through the API.</value>
    [DataMember(Name="archived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archived")]
    public bool? Archived { get; set; }

    /// <summary>
    /// Either `true` to allow private forks, or `false` to prevent private forks.
    /// </summary>
    /// <value>Either `true` to allow private forks, or `false` to prevent private forks.</value>
    [DataMember(Name="allow_forking", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_forking")]
    public bool? AllowForking { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdateRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Homepage: ").Append(Homepage).Append("\n");
      sb.Append("  Private: ").Append(Private).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  SecurityAndAnalysis: ").Append(SecurityAndAnalysis).Append("\n");
      sb.Append("  HasIssues: ").Append(HasIssues).Append("\n");
      sb.Append("  HasProjects: ").Append(HasProjects).Append("\n");
      sb.Append("  HasWiki: ").Append(HasWiki).Append("\n");
      sb.Append("  IsTemplate: ").Append(IsTemplate).Append("\n");
      sb.Append("  DefaultBranch: ").Append(DefaultBranch).Append("\n");
      sb.Append("  AllowSquashMerge: ").Append(AllowSquashMerge).Append("\n");
      sb.Append("  AllowMergeCommit: ").Append(AllowMergeCommit).Append("\n");
      sb.Append("  AllowRebaseMerge: ").Append(AllowRebaseMerge).Append("\n");
      sb.Append("  AllowAutoMerge: ").Append(AllowAutoMerge).Append("\n");
      sb.Append("  DeleteBranchOnMerge: ").Append(DeleteBranchOnMerge).Append("\n");
      sb.Append("  AllowUpdateBranch: ").Append(AllowUpdateBranch).Append("\n");
      sb.Append("  UseSquashPrTitleAsDefault: ").Append(UseSquashPrTitleAsDefault).Append("\n");
      sb.Append("  Archived: ").Append(Archived).Append("\n");
      sb.Append("  AllowForking: ").Append(AllowForking).Append("\n");
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
