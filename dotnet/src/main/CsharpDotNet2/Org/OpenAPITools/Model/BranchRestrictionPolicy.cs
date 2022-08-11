using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Branch Restriction Policy
  /// </summary>
  [DataContract]
  public class BranchRestrictionPolicy {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets UsersUrl
    /// </summary>
    [DataMember(Name="users_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users_url")]
    public string UsersUrl { get; set; }

    /// <summary>
    /// Gets or Sets TeamsUrl
    /// </summary>
    [DataMember(Name="teams_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teams_url")]
    public string TeamsUrl { get; set; }

    /// <summary>
    /// Gets or Sets AppsUrl
    /// </summary>
    [DataMember(Name="apps_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apps_url")]
    public string AppsUrl { get; set; }

    /// <summary>
    /// Gets or Sets Users
    /// </summary>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<RepositoryTemplateRepositoryOwner> Users { get; set; }

    /// <summary>
    /// Gets or Sets Teams
    /// </summary>
    [DataMember(Name="teams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teams")]
    public List<BranchRestrictionPolicyTeamsInner> Teams { get; set; }

    /// <summary>
    /// Gets or Sets Apps
    /// </summary>
    [DataMember(Name="apps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apps")]
    public List<BranchRestrictionPolicyAppsInner> Apps { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BranchRestrictionPolicy {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  UsersUrl: ").Append(UsersUrl).Append("\n");
      sb.Append("  TeamsUrl: ").Append(TeamsUrl).Append("\n");
      sb.Append("  AppsUrl: ").Append(AppsUrl).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
      sb.Append("  Teams: ").Append(Teams).Append("\n");
      sb.Append("  Apps: ").Append(Apps).Append("\n");
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
