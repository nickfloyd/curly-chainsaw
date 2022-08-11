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
  public class GistsGet403Response {
    /// <summary>
    /// Gets or Sets Block
    /// </summary>
    [DataMember(Name="block", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "block")]
    public GistsGet403ResponseBlock Block { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets DocumentationUrl
    /// </summary>
    [DataMember(Name="documentation_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentation_url")]
    public string DocumentationUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GistsGet403Response {\n");
      sb.Append("  Block: ").Append(Block).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  DocumentationUrl: ").Append(DocumentationUrl).Append("\n");
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
