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
  public class GistsUpdateRequestFilesValue {
    /// <summary>
    /// The new content of the file
    /// </summary>
    /// <value>The new content of the file</value>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }

    /// <summary>
    /// The new filename for the file
    /// </summary>
    /// <value>The new filename for the file</value>
    [DataMember(Name="filename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filename")]
    public string Filename { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GistsUpdateRequestFilesValue {\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
      sb.Append("  Filename: ").Append(Filename).Append("\n");
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
