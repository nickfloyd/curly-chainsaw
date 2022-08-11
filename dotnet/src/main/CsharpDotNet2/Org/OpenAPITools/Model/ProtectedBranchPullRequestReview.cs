using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Protected Branch Pull Request Review
  /// </summary>
  [DataContract]
  public class ProtectedBranchPullRequestReview {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets DismissalRestrictions
    /// </summary>
    [DataMember(Name="dismissal_restrictions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismissal_restrictions")]
    public ProtectedBranchPullRequestReviewDismissalRestrictions DismissalRestrictions { get; set; }

    /// <summary>
    /// Gets or Sets BypassPullRequestAllowances
    /// </summary>
    [DataMember(Name="bypass_pull_request_allowances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bypass_pull_request_allowances")]
    public ProtectedBranchPullRequestReviewBypassPullRequestAllowances BypassPullRequestAllowances { get; set; }

    /// <summary>
    /// Gets or Sets DismissStaleReviews
    /// </summary>
    [DataMember(Name="dismiss_stale_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismiss_stale_reviews")]
    public bool? DismissStaleReviews { get; set; }

    /// <summary>
    /// Gets or Sets RequireCodeOwnerReviews
    /// </summary>
    [DataMember(Name="require_code_owner_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "require_code_owner_reviews")]
    public bool? RequireCodeOwnerReviews { get; set; }

    /// <summary>
    /// Gets or Sets RequiredApprovingReviewCount
    /// </summary>
    [DataMember(Name="required_approving_review_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required_approving_review_count")]
    public int? RequiredApprovingReviewCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProtectedBranchPullRequestReview {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  DismissalRestrictions: ").Append(DismissalRestrictions).Append("\n");
      sb.Append("  BypassPullRequestAllowances: ").Append(BypassPullRequestAllowances).Append("\n");
      sb.Append("  DismissStaleReviews: ").Append(DismissStaleReviews).Append("\n");
      sb.Append("  RequireCodeOwnerReviews: ").Append(RequireCodeOwnerReviews).Append("\n");
      sb.Append("  RequiredApprovingReviewCount: ").Append(RequiredApprovingReviewCount).Append("\n");
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
