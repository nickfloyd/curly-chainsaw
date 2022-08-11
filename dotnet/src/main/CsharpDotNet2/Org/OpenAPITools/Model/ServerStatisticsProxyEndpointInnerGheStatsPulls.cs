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
  public class ServerStatisticsProxyEndpointInnerGheStatsPulls {
    /// <summary>
    /// Gets or Sets TotalPulls
    /// </summary>
    [DataMember(Name="total_pulls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_pulls")]
    public int? TotalPulls { get; set; }

    /// <summary>
    /// Gets or Sets MergedPulls
    /// </summary>
    [DataMember(Name="merged_pulls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merged_pulls")]
    public int? MergedPulls { get; set; }

    /// <summary>
    /// Gets or Sets MergeablePulls
    /// </summary>
    [DataMember(Name="mergeable_pulls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mergeable_pulls")]
    public int? MergeablePulls { get; set; }

    /// <summary>
    /// Gets or Sets UnmergeablePulls
    /// </summary>
    [DataMember(Name="unmergeable_pulls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unmergeable_pulls")]
    public int? UnmergeablePulls { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerStatisticsProxyEndpointInnerGheStatsPulls {\n");
      sb.Append("  TotalPulls: ").Append(TotalPulls).Append("\n");
      sb.Append("  MergedPulls: ").Append(MergedPulls).Append("\n");
      sb.Append("  MergeablePulls: ").Append(MergeablePulls).Append("\n");
      sb.Append("  UnmergeablePulls: ").Append(UnmergeablePulls).Append("\n");
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
