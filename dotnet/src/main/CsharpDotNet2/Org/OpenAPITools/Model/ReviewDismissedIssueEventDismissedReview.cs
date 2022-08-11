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
  public class ReviewDismissedIssueEventDismissedReview {
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets ReviewId
    /// </summary>
    [DataMember(Name="review_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "review_id")]
    public int? ReviewId { get; set; }

    /// <summary>
    /// Gets or Sets DismissalMessage
    /// </summary>
    [DataMember(Name="dismissal_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismissal_message")]
    public string DismissalMessage { get; set; }

    /// <summary>
    /// Gets or Sets DismissalCommitId
    /// </summary>
    [DataMember(Name="dismissal_commit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismissal_commit_id")]
    public string DismissalCommitId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReviewDismissedIssueEventDismissedReview {\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  ReviewId: ").Append(ReviewId).Append("\n");
      sb.Append("  DismissalMessage: ").Append(DismissalMessage).Append("\n");
      sb.Append("  DismissalCommitId: ").Append(DismissalCommitId).Append("\n");
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
