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
  public class ServerStatisticsProxyEndpointInnerGheStatsRepos {
    /// <summary>
    /// Gets or Sets TotalRepos
    /// </summary>
    [DataMember(Name="total_repos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_repos")]
    public int? TotalRepos { get; set; }

    /// <summary>
    /// Gets or Sets RootRepos
    /// </summary>
    [DataMember(Name="root_repos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "root_repos")]
    public int? RootRepos { get; set; }

    /// <summary>
    /// Gets or Sets ForkRepos
    /// </summary>
    [DataMember(Name="fork_repos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fork_repos")]
    public int? ForkRepos { get; set; }

    /// <summary>
    /// Gets or Sets OrgRepos
    /// </summary>
    [DataMember(Name="org_repos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "org_repos")]
    public int? OrgRepos { get; set; }

    /// <summary>
    /// Gets or Sets TotalPushes
    /// </summary>
    [DataMember(Name="total_pushes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_pushes")]
    public int? TotalPushes { get; set; }

    /// <summary>
    /// Gets or Sets TotalWikis
    /// </summary>
    [DataMember(Name="total_wikis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_wikis")]
    public int? TotalWikis { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerStatisticsProxyEndpointInnerGheStatsRepos {\n");
      sb.Append("  TotalRepos: ").Append(TotalRepos).Append("\n");
      sb.Append("  RootRepos: ").Append(RootRepos).Append("\n");
      sb.Append("  ForkRepos: ").Append(ForkRepos).Append("\n");
      sb.Append("  OrgRepos: ").Append(OrgRepos).Append("\n");
      sb.Append("  TotalPushes: ").Append(TotalPushes).Append("\n");
      sb.Append("  TotalWikis: ").Append(TotalWikis).Append("\n");
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
