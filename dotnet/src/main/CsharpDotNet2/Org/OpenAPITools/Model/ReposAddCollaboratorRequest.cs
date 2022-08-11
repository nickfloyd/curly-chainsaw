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
  public class ReposAddCollaboratorRequest {
    /// <summary>
    /// The permission to grant the collaborator. **Only valid on organization-owned repositories.** In addition to the enumerated values, you can also specify a custom repository role name, if the owning organization has defined any.
    /// </summary>
    /// <value>The permission to grant the collaborator. **Only valid on organization-owned repositories.** In addition to the enumerated values, you can also specify a custom repository role name, if the owning organization has defined any.</value>
    [DataMember(Name="permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permission")]
    public string Permission { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposAddCollaboratorRequest {\n");
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
