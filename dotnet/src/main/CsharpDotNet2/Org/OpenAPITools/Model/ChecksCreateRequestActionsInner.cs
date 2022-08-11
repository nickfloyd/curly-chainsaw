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
  public class ChecksCreateRequestActionsInner {
    /// <summary>
    /// The text to be displayed on a button in the web UI. The maximum size is 20 characters.
    /// </summary>
    /// <value>The text to be displayed on a button in the web UI. The maximum size is 20 characters.</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// A short explanation of what this action would do. The maximum size is 40 characters.
    /// </summary>
    /// <value>A short explanation of what this action would do. The maximum size is 40 characters.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// A reference for the action on the integrator's system. The maximum size is 20 characters.
    /// </summary>
    /// <value>A reference for the action on the integrator's system. The maximum size is 20 characters.</value>
    [DataMember(Name="identifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier")]
    public string Identifier { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChecksCreateRequestActionsInner {\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Identifier: ").Append(Identifier).Append("\n");
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
