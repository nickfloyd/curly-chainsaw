using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Allow specific users, teams, or apps to bypass pull request requirements.
  /// </summary>
  [DataContract]
  public class ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsBypassPullRequestAllowances {
    /// <summary>
    /// The list of user `login`s allowed to bypass pull request requirements.
    /// </summary>
    /// <value>The list of user `login`s allowed to bypass pull request requirements.</value>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<string> Users { get; set; }

    /// <summary>
    /// The list of team `slug`s allowed to bypass pull request requirements.
    /// </summary>
    /// <value>The list of team `slug`s allowed to bypass pull request requirements.</value>
    [DataMember(Name="teams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teams")]
    public List<string> Teams { get; set; }

    /// <summary>
    /// The list of app `slug`s allowed to bypass pull request requirements.
    /// </summary>
    /// <value>The list of app `slug`s allowed to bypass pull request requirements.</value>
    [DataMember(Name="apps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apps")]
    public List<string> Apps { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsBypassPullRequestAllowances {\n");
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
