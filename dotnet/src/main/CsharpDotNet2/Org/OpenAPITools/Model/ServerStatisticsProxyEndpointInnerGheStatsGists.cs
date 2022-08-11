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
  public class ServerStatisticsProxyEndpointInnerGheStatsGists {
    /// <summary>
    /// Gets or Sets TotalGists
    /// </summary>
    [DataMember(Name="total_gists", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_gists")]
    public int? TotalGists { get; set; }

    /// <summary>
    /// Gets or Sets PrivateGists
    /// </summary>
    [DataMember(Name="private_gists", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private_gists")]
    public int? PrivateGists { get; set; }

    /// <summary>
    /// Gets or Sets PublicGists
    /// </summary>
    [DataMember(Name="public_gists", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_gists")]
    public int? PublicGists { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerStatisticsProxyEndpointInnerGheStatsGists {\n");
      sb.Append("  TotalGists: ").Append(TotalGists).Append("\n");
      sb.Append("  PrivateGists: ").Append(PrivateGists).Append("\n");
      sb.Append("  PublicGists: ").Append(PublicGists).Append("\n");
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
