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
  public class ActionsSetGithubActionsPermissionsRepositoryRequest {
    /// <summary>
    /// Whether GitHub Actions is enabled on the repository.
    /// </summary>
    /// <value>Whether GitHub Actions is enabled on the repository.</value>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
    /// </summary>
    /// <value>The permissions policy that controls the actions and reusable workflows that are allowed to run.</value>
    [DataMember(Name="allowed_actions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowed_actions")]
    public string AllowedActions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionsSetGithubActionsPermissionsRepositoryRequest {\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  AllowedActions: ").Append(AllowedActions).Append("\n");
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
