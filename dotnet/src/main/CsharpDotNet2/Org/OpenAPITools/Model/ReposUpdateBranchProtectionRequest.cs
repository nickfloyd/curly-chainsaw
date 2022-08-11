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
  public class ReposUpdateBranchProtectionRequest {
    /// <summary>
    /// Gets or Sets RequiredStatusChecks
    /// </summary>
    [DataMember(Name="required_status_checks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_status_checks")]
    public ReposUpdateBranchProtectionRequestRequiredStatusChecks RequiredStatusChecks { get; set; }

    /// <summary>
    /// Enforce all configured restrictions for administrators. Set to `true` to enforce required status checks for repository administrators. Set to `null` to disable.
    /// </summary>
    /// <value>Enforce all configured restrictions for administrators. Set to `true` to enforce required status checks for repository administrators. Set to `null` to disable.</value>
    [DataMember(Name="enforce_admins", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enforce_admins")]
    public bool? EnforceAdmins { get; set; }

    /// <summary>
    /// Gets or Sets RequiredPullRequestReviews
    /// </summary>
    [DataMember(Name="required_pull_request_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_pull_request_reviews")]
    public ReposUpdateBranchProtectionRequestRequiredPullRequestReviews RequiredPullRequestReviews { get; set; }

    /// <summary>
    /// Gets or Sets Restrictions
    /// </summary>
    [DataMember(Name="restrictions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restrictions")]
    public ReposUpdateBranchProtectionRequestRestrictions Restrictions { get; set; }

    /// <summary>
    /// Enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch. Set to `true` to enforce a linear commit history. Set to `false` to disable a linear commit Git history. Your repository must allow squash merging or rebase merging before you can enable a linear commit history. Default: `false`. For more information, see \"[Requiring a linear commit history](https://docs.github.com/github/administering-a-repository/requiring-a-linear-commit-history)\" in the GitHub Help documentation.
    /// </summary>
    /// <value>Enforces a linear commit Git history, which prevents anyone from pushing merge commits to a branch. Set to `true` to enforce a linear commit history. Set to `false` to disable a linear commit Git history. Your repository must allow squash merging or rebase merging before you can enable a linear commit history. Default: `false`. For more information, see \"[Requiring a linear commit history](https://docs.github.com/github/administering-a-repository/requiring-a-linear-commit-history)\" in the GitHub Help documentation.</value>
    [DataMember(Name="required_linear_history", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_linear_history")]
    public bool? RequiredLinearHistory { get; set; }

    /// <summary>
    /// Permits force pushes to the protected branch by anyone with write access to the repository. Set to `true` to allow force pushes. Set to `false` or `null` to block force pushes. Default: `false`. For more information, see \"[Enabling force pushes to a protected branch](https://docs.github.com/en/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)\" in the GitHub Help documentation.\"
    /// </summary>
    /// <value>Permits force pushes to the protected branch by anyone with write access to the repository. Set to `true` to allow force pushes. Set to `false` or `null` to block force pushes. Default: `false`. For more information, see \"[Enabling force pushes to a protected branch](https://docs.github.com/en/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)\" in the GitHub Help documentation.\"</value>
    [DataMember(Name="allow_force_pushes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_force_pushes")]
    public bool? AllowForcePushes { get; set; }

    /// <summary>
    /// Allows deletion of the protected branch by anyone with write access to the repository. Set to `false` to prevent deletion of the protected branch. Default: `false`. For more information, see \"[Enabling force pushes to a protected branch](https://docs.github.com/en/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)\" in the GitHub Help documentation.
    /// </summary>
    /// <value>Allows deletion of the protected branch by anyone with write access to the repository. Set to `false` to prevent deletion of the protected branch. Default: `false`. For more information, see \"[Enabling force pushes to a protected branch](https://docs.github.com/en/github/administering-a-repository/enabling-force-pushes-to-a-protected-branch)\" in the GitHub Help documentation.</value>
    [DataMember(Name="allow_deletions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_deletions")]
    public bool? AllowDeletions { get; set; }

    /// <summary>
    /// If set to `true`, the `restrictions` branch protection settings which limits who can push will also block pushes which create new branches, unless the push is initiated by a user, team, or app which has the ability to push. Set to `true` to restrict new branch creation. Default: `false`.
    /// </summary>
    /// <value>If set to `true`, the `restrictions` branch protection settings which limits who can push will also block pushes which create new branches, unless the push is initiated by a user, team, or app which has the ability to push. Set to `true` to restrict new branch creation. Default: `false`.</value>
    [DataMember(Name="block_creations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "block_creations")]
    public bool? BlockCreations { get; set; }

    /// <summary>
    /// Requires all conversations on code to be resolved before a pull request can be merged into a branch that matches this rule. Set to `false` to disable. Default: `false`.
    /// </summary>
    /// <value>Requires all conversations on code to be resolved before a pull request can be merged into a branch that matches this rule. Set to `false` to disable. Default: `false`.</value>
    [DataMember(Name="required_conversation_resolution", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_conversation_resolution")]
    public bool? RequiredConversationResolution { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdateBranchProtectionRequest {\n");
      sb.Append("  RequiredStatusChecks: ").Append(RequiredStatusChecks).Append("\n");
      sb.Append("  EnforceAdmins: ").Append(EnforceAdmins).Append("\n");
      sb.Append("  RequiredPullRequestReviews: ").Append(RequiredPullRequestReviews).Append("\n");
      sb.Append("  Restrictions: ").Append(Restrictions).Append("\n");
      sb.Append("  RequiredLinearHistory: ").Append(RequiredLinearHistory).Append("\n");
      sb.Append("  AllowForcePushes: ").Append(AllowForcePushes).Append("\n");
      sb.Append("  AllowDeletions: ").Append(AllowDeletions).Append("\n");
      sb.Append("  BlockCreations: ").Append(BlockCreations).Append("\n");
      sb.Append("  RequiredConversationResolution: ").Append(RequiredConversationResolution).Append("\n");
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
