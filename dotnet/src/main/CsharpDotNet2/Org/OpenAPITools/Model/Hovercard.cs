using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Hovercard
  /// </summary>
  [DataContract]
  public class Hovercard {
    /// <summary>
    /// Gets or Sets Contexts
    /// </summary>
    [DataMember(Name="contexts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contexts")]
    public List<HovercardContextsInner> Contexts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Hovercard {\n");
      sb.Append("  Contexts: ").Append(Contexts).Append("\n");
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
