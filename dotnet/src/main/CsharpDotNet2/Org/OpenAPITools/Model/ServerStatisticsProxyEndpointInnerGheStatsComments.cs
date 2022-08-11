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
  public class ServerStatisticsProxyEndpointInnerGheStatsComments {
    /// <summary>
    /// Gets or Sets TotalCommitComments
    /// </summary>
    [DataMember(Name="total_commit_comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_commit_comments")]
    public int? TotalCommitComments { get; set; }

    /// <summary>
    /// Gets or Sets TotalGistComments
    /// </summary>
    [DataMember(Name="total_gist_comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_gist_comments")]
    public int? TotalGistComments { get; set; }

    /// <summary>
    /// Gets or Sets TotalIssueComments
    /// </summary>
    [DataMember(Name="total_issue_comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_issue_comments")]
    public int? TotalIssueComments { get; set; }

    /// <summary>
    /// Gets or Sets TotalPullRequestComments
    /// </summary>
    [DataMember(Name="total_pull_request_comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_pull_request_comments")]
    public int? TotalPullRequestComments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerStatisticsProxyEndpointInnerGheStatsComments {\n");
      sb.Append("  TotalCommitComments: ").Append(TotalCommitComments).Append("\n");
      sb.Append("  TotalGistComments: ").Append(TotalGistComments).Append("\n");
      sb.Append("  TotalIssueComments: ").Append(TotalIssueComments).Append("\n");
      sb.Append("  TotalPullRequestComments: ").Append(TotalPullRequestComments).Append("\n");
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
