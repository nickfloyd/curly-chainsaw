using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Restrict who can push to the protected branch. User, app, and team &#x60;restrictions&#x60; are only available for organization-owned repositories. Set to &#x60;null&#x60; to disable.
  /// </summary>
  [DataContract]
  public class ReposUpdateBranchProtectionRequestRestrictions {
    /// <summary>
    /// The list of user `login`s with push access
    /// </summary>
    /// <value>The list of user `login`s with push access</value>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<string> Users { get; set; }

    /// <summary>
    /// The list of team `slug`s with push access
    /// </summary>
    /// <value>The list of team `slug`s with push access</value>
    [DataMember(Name="teams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teams")]
    public List<string> Teams { get; set; }

    /// <summary>
    /// The list of app `slug`s with push access
    /// </summary>
    /// <value>The list of app `slug`s with push access</value>
    [DataMember(Name="apps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apps")]
    public List<string> Apps { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdateBranchProtectionRequestRestrictions {\n");
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
