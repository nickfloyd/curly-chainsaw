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
  public class CodespacesPreFlightWithRepoForAuthenticatedUser200ResponseDefaults {
    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// Gets or Sets DevcontainerPath
    /// </summary>
    [DataMember(Name="devcontainer_path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "devcontainer_path")]
    public string DevcontainerPath { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodespacesPreFlightWithRepoForAuthenticatedUser200ResponseDefaults {\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  DevcontainerPath: ").Append(DevcontainerPath).Append("\n");
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
