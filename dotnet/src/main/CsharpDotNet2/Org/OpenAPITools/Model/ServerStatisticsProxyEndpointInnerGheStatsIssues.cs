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
  public class ServerStatisticsProxyEndpointInnerGheStatsIssues {
    /// <summary>
    /// Gets or Sets TotalIssues
    /// </summary>
    [DataMember(Name="total_issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_issues")]
    public int? TotalIssues { get; set; }

    /// <summary>
    /// Gets or Sets OpenIssues
    /// </summary>
    [DataMember(Name="open_issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open_issues")]
    public int? OpenIssues { get; set; }

    /// <summary>
    /// Gets or Sets ClosedIssues
    /// </summary>
    [DataMember(Name="closed_issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closed_issues")]
    public int? ClosedIssues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerStatisticsProxyEndpointInnerGheStatsIssues {\n");
      sb.Append("  TotalIssues: ").Append(TotalIssues).Append("\n");
      sb.Append("  OpenIssues: ").Append(OpenIssues).Append("\n");
      sb.Append("  ClosedIssues: ").Append(ClosedIssues).Append("\n");
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
