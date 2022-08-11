using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Porter Large File
  /// </summary>
  [DataContract]
  public class PorterLargeFile {
    /// <summary>
    /// Gets or Sets RefName
    /// </summary>
    [DataMember(Name="ref_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref_name")]
    public string RefName { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets Oid
    /// </summary>
    [DataMember(Name="oid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oid")]
    public string Oid { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public int? Size { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PorterLargeFile {\n");
      sb.Append("  RefName: ").Append(RefName).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Oid: ").Append(Oid).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
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
