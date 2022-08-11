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
  public class ReposCreateInOrgRequest {
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
    /// Can be `public` or `private`. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, `visibility` can also be `internal`. Note: For GitHub Enterprise Server and GitHub AE, this endpoint will only list repositories available to all users on the enterprise. For more information, see \"[Creating an internal repository](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/about-repository-visibility#about-internal-repositories)\" in the GitHub Help documentation.
    /// </summary>
    /// <value>Can be `public` or `private`. If your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+, `visibility` can also be `internal`. Note: For GitHub Enterprise Server and GitHub AE, this endpoint will only list repositories available to all users on the enterprise. For more information, see \"[Creating an internal repository](https://docs.github.com/en/github/creating-cloning-and-archiving-repositories/about-repository-visibility#about-internal-repositories)\" in the GitHub Help documentation.</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public string Visibility { get; set; }

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
    /// The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.
    /// </summary>
    /// <value>The id of the team that will be granted access to this repository. This is only valid when creating a repository in an organization.</value>
    [DataMember(Name="team_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team_id")]
    public int? TeamId { get; set; }

    /// <summary>
    /// Pass `true` to create an initial commit with empty README.
    /// </summary>
    /// <value>Pass `true` to create an initial commit with empty README.</value>
    [DataMember(Name="auto_init", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auto_init")]
    public bool? AutoInit { get; set; }

    /// <summary>
    /// Desired language or platform [.gitignore template](https://github.com/github/gitignore) to apply. Use the name of the template without the extension. For example, \"Haskell\".
    /// </summary>
    /// <value>Desired language or platform [.gitignore template](https://github.com/github/gitignore) to apply. Use the name of the template without the extension. For example, \"Haskell\".</value>
    [DataMember(Name="gitignore_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gitignore_template")]
    public string GitignoreTemplate { get; set; }

    /// <summary>
    /// Choose an [open source license template](https://choosealicense.com/) that best suits your needs, and then use the [license keyword](https://docs.github.com/articles/licensing-a-repository/#searching-github-by-license-type) as the `license_template` string. For example, \"mit\" or \"mpl-2.0\".
    /// </summary>
    /// <value>Choose an [open source license template](https://choosealicense.com/) that best suits your needs, and then use the [license keyword](https://docs.github.com/articles/licensing-a-repository/#searching-github-by-license-type) as the `license_template` string. For example, \"mit\" or \"mpl-2.0\".</value>
    [DataMember(Name="license_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "license_template")]
    public string LicenseTemplate { get; set; }

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
    /// Either `true` to allow squash-merge commits to use pull request title, or `false` to use commit message.
    /// </summary>
    /// <value>Either `true` to allow squash-merge commits to use pull request title, or `false` to use commit message.</value>
    [DataMember(Name="use_squash_pr_title_as_default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "use_squash_pr_title_as_default")]
    public bool? UseSquashPrTitleAsDefault { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreateInOrgRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Homepage: ").Append(Homepage).Append("\n");
      sb.Append("  Private: ").Append(Private).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  HasIssues: ").Append(HasIssues).Append("\n");
      sb.Append("  HasProjects: ").Append(HasProjects).Append("\n");
      sb.Append("  HasWiki: ").Append(HasWiki).Append("\n");
      sb.Append("  IsTemplate: ").Append(IsTemplate).Append("\n");
      sb.Append("  TeamId: ").Append(TeamId).Append("\n");
      sb.Append("  AutoInit: ").Append(AutoInit).Append("\n");
      sb.Append("  GitignoreTemplate: ").Append(GitignoreTemplate).Append("\n");
      sb.Append("  LicenseTemplate: ").Append(LicenseTemplate).Append("\n");
      sb.Append("  AllowSquashMerge: ").Append(AllowSquashMerge).Append("\n");
      sb.Append("  AllowMergeCommit: ").Append(AllowMergeCommit).Append("\n");
      sb.Append("  AllowRebaseMerge: ").Append(AllowRebaseMerge).Append("\n");
      sb.Append("  AllowAutoMerge: ").Append(AllowAutoMerge).Append("\n");
      sb.Append("  DeleteBranchOnMerge: ").Append(DeleteBranchOnMerge).Append("\n");
      sb.Append("  UseSquashPrTitleAsDefault: ").Append(UseSquashPrTitleAsDefault).Append("\n");
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
