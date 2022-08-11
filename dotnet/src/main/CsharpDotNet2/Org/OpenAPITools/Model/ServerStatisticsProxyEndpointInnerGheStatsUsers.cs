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
  public class ServerStatisticsProxyEndpointInnerGheStatsUsers {
    /// <summary>
    /// Gets or Sets TotalUsers
    /// </summary>
    [DataMember(Name="total_users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_users")]
    public int? TotalUsers { get; set; }

    /// <summary>
    /// Gets or Sets AdminUsers
    /// </summary>
    [DataMember(Name="admin_users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "admin_users")]
    public int? AdminUsers { get; set; }

    /// <summary>
    /// Gets or Sets SuspendedUsers
    /// </summary>
    [DataMember(Name="suspended_users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suspended_users")]
    public int? SuspendedUsers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerStatisticsProxyEndpointInnerGheStatsUsers {\n");
      sb.Append("  TotalUsers: ").Append(TotalUsers).Append("\n");
      sb.Append("  AdminUsers: ").Append(AdminUsers).Append("\n");
      sb.Append("  SuspendedUsers: ").Append(SuspendedUsers).Append("\n");
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
