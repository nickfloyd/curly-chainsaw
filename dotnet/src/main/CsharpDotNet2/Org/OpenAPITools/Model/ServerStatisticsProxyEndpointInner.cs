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
  public class ServerStatisticsProxyEndpointInner {
    /// <summary>
    /// Gets or Sets ServerId
    /// </summary>
    [DataMember(Name="server_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "server_id")]
    public string ServerId { get; set; }

    /// <summary>
    /// Gets or Sets CollectionDate
    /// </summary>
    [DataMember(Name="collection_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collection_date")]
    public string CollectionDate { get; set; }

    /// <summary>
    /// Gets or Sets SchemaVersion
    /// </summary>
    [DataMember(Name="schema_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schema_version")]
    public string SchemaVersion { get; set; }

    /// <summary>
    /// Gets or Sets GhesVersion
    /// </summary>
    [DataMember(Name="ghes_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ghes_version")]
    public string GhesVersion { get; set; }

    /// <summary>
    /// Gets or Sets HostName
    /// </summary>
    [DataMember(Name="host_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host_name")]
    public string HostName { get; set; }

    /// <summary>
    /// Gets or Sets GithubConnect
    /// </summary>
    [DataMember(Name="github_connect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "github_connect")]
    public ServerStatisticsProxyEndpointInnerGithubConnect GithubConnect { get; set; }

    /// <summary>
    /// Gets or Sets GheStats
    /// </summary>
    [DataMember(Name="ghe_stats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ghe_stats")]
    public ServerStatisticsProxyEndpointInnerGheStats GheStats { get; set; }

    /// <summary>
    /// Gets or Sets DormantUsers
    /// </summary>
    [DataMember(Name="dormant_users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dormant_users")]
    public ServerStatisticsProxyEndpointInnerDormantUsers DormantUsers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerStatisticsProxyEndpointInner {\n");
      sb.Append("  ServerId: ").Append(ServerId).Append("\n");
      sb.Append("  CollectionDate: ").Append(CollectionDate).Append("\n");
      sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
      sb.Append("  GhesVersion: ").Append(GhesVersion).Append("\n");
      sb.Append("  HostName: ").Append(HostName).Append("\n");
      sb.Append("  GithubConnect: ").Append(GithubConnect).Append("\n");
      sb.Append("  GheStats: ").Append(GheStats).Append("\n");
      sb.Append("  DormantUsers: ").Append(DormantUsers).Append("\n");
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
