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
  public class ReposUpdatePullRequestReviewProtectionRequest {
    /// <summary>
    /// Gets or Sets DismissalRestrictions
    /// </summary>
    [DataMember(Name="dismissal_restrictions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismissal_restrictions")]
    public ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions DismissalRestrictions { get; set; }

    /// <summary>
    /// Set to `true` if you want to automatically dismiss approving reviews when someone pushes a new commit.
    /// </summary>
    /// <value>Set to `true` if you want to automatically dismiss approving reviews when someone pushes a new commit.</value>
    [DataMember(Name="dismiss_stale_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismiss_stale_reviews")]
    public bool? DismissStaleReviews { get; set; }

    /// <summary>
    /// Blocks merging pull requests until [code owners](https://docs.github.com/articles/about-code-owners/) have reviewed.
    /// </summary>
    /// <value>Blocks merging pull requests until [code owners](https://docs.github.com/articles/about-code-owners/) have reviewed.</value>
    [DataMember(Name="require_code_owner_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "require_code_owner_reviews")]
    public bool? RequireCodeOwnerReviews { get; set; }

    /// <summary>
    /// Specifies the number of reviewers required to approve pull requests. Use a number between 1 and 6 or 0 to not require reviewers.
    /// </summary>
    /// <value>Specifies the number of reviewers required to approve pull requests. Use a number between 1 and 6 or 0 to not require reviewers.</value>
    [DataMember(Name="required_approving_review_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_approving_review_count")]
    public int? RequiredApprovingReviewCount { get; set; }

    /// <summary>
    /// Gets or Sets BypassPullRequestAllowances
    /// </summary>
    [DataMember(Name="bypass_pull_request_allowances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bypass_pull_request_allowances")]
    public ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsBypassPullRequestAllowances BypassPullRequestAllowances { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdatePullRequestReviewProtectionRequest {\n");
      sb.Append("  DismissalRestrictions: ").Append(DismissalRestrictions).Append("\n");
      sb.Append("  DismissStaleReviews: ").Append(DismissStaleReviews).Append("\n");
      sb.Append("  RequireCodeOwnerReviews: ").Append(RequireCodeOwnerReviews).Append("\n");
      sb.Append("  RequiredApprovingReviewCount: ").Append(RequiredApprovingReviewCount).Append("\n");
      sb.Append("  BypassPullRequestAllowances: ").Append(BypassPullRequestAllowances).Append("\n");
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
