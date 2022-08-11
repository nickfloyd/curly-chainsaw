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
  public class ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances {
    /// <summary>
    /// Gets or Sets Users
    /// </summary>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<SimpleUser1> Users { get; set; }

    /// <summary>
    /// Gets or Sets Teams
    /// </summary>
    [DataMember(Name="teams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teams")]
    public List<Team> Teams { get; set; }

    /// <summary>
    /// Gets or Sets Apps
    /// </summary>
    [DataMember(Name="apps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apps")]
    public List<GitHubApp> Apps { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProtectedBranchRequiredPullRequestReviewsBypassPullRequestAllowances {\n");
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
