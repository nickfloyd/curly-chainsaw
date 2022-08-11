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
  public class ServerStatisticsProxyEndpointInnerGheStatsMilestones {
    /// <summary>
    /// Gets or Sets TotalMilestones
    /// </summary>
    [DataMember(Name="total_milestones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_milestones")]
    public int? TotalMilestones { get; set; }

    /// <summary>
    /// Gets or Sets OpenMilestones
    /// </summary>
    [DataMember(Name="open_milestones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open_milestones")]
    public int? OpenMilestones { get; set; }

    /// <summary>
    /// Gets or Sets ClosedMilestones
    /// </summary>
    [DataMember(Name="closed_milestones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closed_milestones")]
    public int? ClosedMilestones { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerStatisticsProxyEndpointInnerGheStatsMilestones {\n");
      sb.Append("  TotalMilestones: ").Append(TotalMilestones).Append("\n");
      sb.Append("  OpenMilestones: ").Append(OpenMilestones).Append("\n");
      sb.Append("  ClosedMilestones: ").Append(ClosedMilestones).Append("\n");
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
