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
  public class PullRequestSimpleLinks {
    /// <summary>
    /// Gets or Sets Comments
    /// </summary>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public Link Comments { get; set; }

    /// <summary>
    /// Gets or Sets Commits
    /// </summary>
    [DataMember(Name="commits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commits")]
    public Link Commits { get; set; }

    /// <summary>
    /// Gets or Sets Statuses
    /// </summary>
    [DataMember(Name="statuses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statuses")]
    public Link Statuses { get; set; }

    /// <summary>
    /// Gets or Sets Html
    /// </summary>
    [DataMember(Name="html", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html")]
    public Link Html { get; set; }

    /// <summary>
    /// Gets or Sets Issue
    /// </summary>
    [DataMember(Name="issue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issue")]
    public Link Issue { get; set; }

    /// <summary>
    /// Gets or Sets ReviewComments
    /// </summary>
    [DataMember(Name="review_comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "review_comments")]
    public Link ReviewComments { get; set; }

    /// <summary>
    /// Gets or Sets ReviewComment
    /// </summary>
    [DataMember(Name="review_comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "review_comment")]
    public Link ReviewComment { get; set; }

    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [DataMember(Name="self", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "self")]
    public Link Self { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PullRequestSimpleLinks {\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  Commits: ").Append(Commits).Append("\n");
      sb.Append("  Statuses: ").Append(Statuses).Append("\n");
      sb.Append("  Html: ").Append(Html).Append("\n");
      sb.Append("  Issue: ").Append(Issue).Append("\n");
      sb.Append("  ReviewComments: ").Append(ReviewComments).Append("\n");
      sb.Append("  ReviewComment: ").Append(ReviewComment).Append("\n");
      sb.Append("  Self: ").Append(Self).Append("\n");
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
