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
  public class TeamsAddOrUpdateRepoPermissionsLegacyRequest {
    /// <summary>
    /// The permission to grant the team on this repository. If no permission is specified, the team's `permission` attribute will be used to determine what permission to grant the team on this repository.
    /// </summary>
    /// <value>The permission to grant the team on this repository. If no permission is specified, the team's `permission` attribute will be used to determine what permission to grant the team on this repository.</value>
    [DataMember(Name="permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permission")]
    public string Permission { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TeamsAddOrUpdateRepoPermissionsLegacyRequest {\n");
      sb.Append("  Permission: ").Append(Permission).Append("\n");
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
