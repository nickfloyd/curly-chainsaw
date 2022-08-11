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
  public class ServerStatisticsProxyEndpointInnerGheStats {
    /// <summary>
    /// Gets or Sets Comments
    /// </summary>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public ServerStatisticsProxyEndpointInnerGheStatsComments Comments { get; set; }

    /// <summary>
    /// Gets or Sets Gists
    /// </summary>
    [DataMember(Name="gists", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gists")]
    public ServerStatisticsProxyEndpointInnerGheStatsGists Gists { get; set; }

    /// <summary>
    /// Gets or Sets Hooks
    /// </summary>
    [DataMember(Name="hooks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hooks")]
    public ServerStatisticsProxyEndpointInnerGheStatsHooks Hooks { get; set; }

    /// <summary>
    /// Gets or Sets Issues
    /// </summary>
    [DataMember(Name="issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues")]
    public ServerStatisticsProxyEndpointInnerGheStatsIssues Issues { get; set; }

    /// <summary>
    /// Gets or Sets Milestones
    /// </summary>
    [DataMember(Name="milestones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "milestones")]
    public ServerStatisticsProxyEndpointInnerGheStatsMilestones Milestones { get; set; }

    /// <summary>
    /// Gets or Sets Orgs
    /// </summary>
    [DataMember(Name="orgs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orgs")]
    public ServerStatisticsProxyEndpointInnerGheStatsOrgs Orgs { get; set; }

    /// <summary>
    /// Gets or Sets Pages
    /// </summary>
    [DataMember(Name="pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pages")]
    public ServerStatisticsProxyEndpointInnerGheStatsPages Pages { get; set; }

    /// <summary>
    /// Gets or Sets Pulls
    /// </summary>
    [DataMember(Name="pulls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pulls")]
    public ServerStatisticsProxyEndpointInnerGheStatsPulls Pulls { get; set; }

    /// <summary>
    /// Gets or Sets Repos
    /// </summary>
    [DataMember(Name="repos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repos")]
    public ServerStatisticsProxyEndpointInnerGheStatsRepos Repos { get; set; }

    /// <summary>
    /// Gets or Sets Users
    /// </summary>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public ServerStatisticsProxyEndpointInnerGheStatsUsers Users { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServerStatisticsProxyEndpointInnerGheStats {\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  Gists: ").Append(Gists).Append("\n");
      sb.Append("  Hooks: ").Append(Hooks).Append("\n");
      sb.Append("  Issues: ").Append(Issues).Append("\n");
      sb.Append("  Milestones: ").Append(Milestones).Append("\n");
      sb.Append("  Orgs: ").Append(Orgs).Append("\n");
      sb.Append("  Pages: ").Append(Pages).Append("\n");
      sb.Append("  Pulls: ").Append(Pulls).Append("\n");
      sb.Append("  Repos: ").Append(Repos).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
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
