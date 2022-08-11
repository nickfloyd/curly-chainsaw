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
  public class PullsRemoveRequestedReviewersRequest {
    /// <summary>
    /// An array of user `login`s that will be removed.
    /// </summary>
    /// <value>An array of user `login`s that will be removed.</value>
    [DataMember(Name="reviewers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reviewers")]
    public List<string> Reviewers { get; set; }

    /// <summary>
    /// An array of team `slug`s that will be removed.
    /// </summary>
    /// <value>An array of team `slug`s that will be removed.</value>
    [DataMember(Name="team_reviewers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team_reviewers")]
    public List<string> TeamReviewers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PullsRemoveRequestedReviewersRequest {\n");
      sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
      sb.Append("  TeamReviewers: ").Append(TeamReviewers).Append("\n");
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
