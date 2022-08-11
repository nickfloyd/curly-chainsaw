using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A list of external groups available to be connected to a team
  /// </summary>
  [DataContract]
  public class ExternalGroups {
    /// <summary>
    /// An array of external groups available to be mapped to a team
    /// </summary>
    /// <value>An array of external groups available to be mapped to a team</value>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<ExternalGroupsGroupsInner> Groups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExternalGroups {\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
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
