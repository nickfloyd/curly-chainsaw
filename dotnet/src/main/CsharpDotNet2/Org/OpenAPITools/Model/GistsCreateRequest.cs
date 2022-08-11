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
  public class GistsCreateRequest {
    /// <summary>
    /// Description of the gist
    /// </summary>
    /// <value>Description of the gist</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Names and content for the files that make up the gist
    /// </summary>
    /// <value>Names and content for the files that make up the gist</value>
    [DataMember(Name="files", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "files")]
    public Dictionary<string, GistsCreateRequestFilesValue> Files { get; set; }

    /// <summary>
    /// Gets or Sets Public
    /// </summary>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public GistsCreateRequestPublic Public { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GistsCreateRequest {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Files: ").Append(Files).Append("\n");
      sb.Append("  Public: ").Append(Public).Append("\n");
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
