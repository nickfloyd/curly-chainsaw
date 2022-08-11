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
  public class ActionsGetWorkflowAccessToRepository200Response {
    /// <summary>
    /// Defines the level of access that workflows outside of the repository have to actions and reusable workflows within the repository. `none` means access is only possible from workflows in this repository.
    /// </summary>
    /// <value>Defines the level of access that workflows outside of the repository have to actions and reusable workflows within the repository. `none` means access is only possible from workflows in this repository.</value>
    [DataMember(Name="access_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "access_level")]
    public string AccessLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionsGetWorkflowAccessToRepository200Response {\n");
      sb.Append("  AccessLevel: ").Append(AccessLevel).Append("\n");
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
