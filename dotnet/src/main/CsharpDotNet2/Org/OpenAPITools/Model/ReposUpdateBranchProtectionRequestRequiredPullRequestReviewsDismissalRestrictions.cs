using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Specify which users, teams, and apps can dismiss pull request reviews. Pass an empty &#x60;dismissal_restrictions&#x60; object to disable. User and team &#x60;dismissal_restrictions&#x60; are only available for organization-owned repositories. Omit this parameter for personal repositories.
  /// </summary>
  [DataContract]
  public class ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions {
    /// <summary>
    /// The list of user `login`s with dismissal access
    /// </summary>
    /// <value>The list of user `login`s with dismissal access</value>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<string> Users { get; set; }

    /// <summary>
    /// The list of team `slug`s with dismissal access
    /// </summary>
    /// <value>The list of team `slug`s with dismissal access</value>
    [DataMember(Name="teams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teams")]
    public List<string> Teams { get; set; }

    /// <summary>
    /// The list of app `slug`s with dismissal access
    /// </summary>
    /// <value>The list of app `slug`s with dismissal access</value>
    [DataMember(Name="apps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apps")]
    public List<string> Apps { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdateBranchProtectionRequestRequiredPullRequestReviewsDismissalRestrictions {\n");
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
