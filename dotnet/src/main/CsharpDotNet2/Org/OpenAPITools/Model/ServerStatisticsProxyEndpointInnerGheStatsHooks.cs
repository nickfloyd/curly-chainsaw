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
  public class ServerStatisticsProxyEndpointInnerGheStatsHooks {
    /// <summary>
    /// Gets or Sets TotalHooks
    /// </summary>
    [DataMember(Name="total_hooks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_hooks")]
    public int? TotalHooks { get; set; }

    /// <summary>
    /// Gets or Sets ActiveHooks
    /// </summary>
    [DataMember(Name="active_hooks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active_hooks")]
    public int? ActiveHooks { get; set; }

    /// <summary>
    /// Gets or Sets InactiveHooks
    /// </summary>
    [DataMember(Name="inactive_hooks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inactive_hooks")]
    public int? InactiveHooks { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerStatisticsProxyEndpointInnerGheStatsHooks {\n");
      sb.Append("  TotalHooks: ").Append(TotalHooks).Append("\n");
      sb.Append("  ActiveHooks: ").Append(ActiveHooks).Append("\n");
      sb.Append("  InactiveHooks: ").Append(InactiveHooks).Append("\n");
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
