using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Branch protections protect branches
  /// </summary>
  [DataContract]
  public class ProtectedBranch {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets RequiredStatusChecks
    /// </summary>
    [DataMember(Name="required_status_checks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_status_checks")]
    public StatusCheckPolicy RequiredStatusChecks { get; set; }

    /// <summary>
    /// Gets or Sets RequiredPullRequestReviews
    /// </summary>
    [DataMember(Name="required_pull_request_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_pull_request_reviews")]
    public ProtectedBranchRequiredPullRequestReviews RequiredPullRequestReviews { get; set; }

    /// <summary>
    /// Gets or Sets RequiredSignatures
    /// </summary>
    [DataMember(Name="required_signatures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_signatures")]
    public BranchProtectionRequiredSignatures RequiredSignatures { get; set; }

    /// <summary>
    /// Gets or Sets EnforceAdmins
    /// </summary>
    [DataMember(Name="enforce_admins", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enforce_admins")]
    public ProtectedBranchEnforceAdmins EnforceAdmins { get; set; }

    /// <summary>
    /// Gets or Sets RequiredLinearHistory
    /// </summary>
    [DataMember(Name="required_linear_history", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_linear_history")]
    public ProtectedBranchRequiredLinearHistory RequiredLinearHistory { get; set; }

    /// <summary>
    /// Gets or Sets AllowForcePushes
    /// </summary>
    [DataMember(Name="allow_force_pushes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_force_pushes")]
    public ProtectedBranchRequiredLinearHistory AllowForcePushes { get; set; }

    /// <summary>
    /// Gets or Sets AllowDeletions
    /// </summary>
    [DataMember(Name="allow_deletions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_deletions")]
    public ProtectedBranchRequiredLinearHistory AllowDeletions { get; set; }

    /// <summary>
    /// Gets or Sets Restrictions
    /// </summary>
    [DataMember(Name="restrictions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restrictions")]
    public BranchRestrictionPolicy Restrictions { get; set; }

    /// <summary>
    /// Gets or Sets RequiredConversationResolution
    /// </summary>
    [DataMember(Name="required_conversation_resolution", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_conversation_resolution")]
    public ProtectedBranchRequiredConversationResolution RequiredConversationResolution { get; set; }

    /// <summary>
    /// Gets or Sets BlockCreations
    /// </summary>
    [DataMember(Name="block_creations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "block_creations")]
    public ProtectedBranchRequiredLinearHistory BlockCreations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProtectedBranch {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  RequiredStatusChecks: ").Append(RequiredStatusChecks).Append("\n");
      sb.Append("  RequiredPullRequestReviews: ").Append(RequiredPullRequestReviews).Append("\n");
      sb.Append("  RequiredSignatures: ").Append(RequiredSignatures).Append("\n");
      sb.Append("  EnforceAdmins: ").Append(EnforceAdmins).Append("\n");
      sb.Append("  RequiredLinearHistory: ").Append(RequiredLinearHistory).Append("\n");
      sb.Append("  AllowForcePushes: ").Append(AllowForcePushes).Append("\n");
      sb.Append("  AllowDeletions: ").Append(AllowDeletions).Append("\n");
      sb.Append("  Restrictions: ").Append(Restrictions).Append("\n");
      sb.Append("  RequiredConversationResolution: ").Append(RequiredConversationResolution).Append("\n");
      sb.Append("  BlockCreations: ").Append(BlockCreations).Append("\n");
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
