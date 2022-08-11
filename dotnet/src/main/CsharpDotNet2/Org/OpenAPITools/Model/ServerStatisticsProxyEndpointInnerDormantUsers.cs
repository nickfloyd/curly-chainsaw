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
  public class ServerStatisticsProxyEndpointInnerDormantUsers {
    /// <summary>
    /// Gets or Sets TotalDormantUsers
    /// </summary>
    [DataMember(Name="total_dormant_users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_dormant_users")]
    public int? TotalDormantUsers { get; set; }

    /// <summary>
    /// Gets or Sets DormancyThreshold
    /// </summary>
    [DataMember(Name="dormancy_threshold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dormancy_threshold")]
    public string DormancyThreshold { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerStatisticsProxyEndpointInnerDormantUsers {\n");
      sb.Append("  TotalDormantUsers: ").Append(TotalDormantUsers).Append("\n");
      sb.Append("  DormancyThreshold: ").Append(DormancyThreshold).Append("\n");
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
