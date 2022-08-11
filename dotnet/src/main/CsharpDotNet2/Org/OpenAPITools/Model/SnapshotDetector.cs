using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A description of the detector used.
  /// </summary>
  [DataContract]
  public class SnapshotDetector {
    /// <summary>
    /// The name of the detector used.
    /// </summary>
    /// <value>The name of the detector used.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The version of the detector used.
    /// </summary>
    /// <value>The version of the detector used.</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string _Version { get; set; }

    /// <summary>
    /// The url of the detector used.
    /// </summary>
    /// <value>The url of the detector used.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SnapshotDetector {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  _Version: ").Append(_Version).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
