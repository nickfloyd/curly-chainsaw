using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A collection of related dependencies declared in a file or representing a logical group of dependencies.
  /// </summary>
  [DataContract]
  public class SnapshotManifestsValue {
    /// <summary>
    /// The name of the manifest.
    /// </summary>
    /// <value>The name of the manifest.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets File
    /// </summary>
    [DataMember(Name="file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file")]
    public SnapshotManifestsValueFile File { get; set; }

    /// <summary>
    /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
    /// </summary>
    /// <value>User-defined metadata to store domain-specific information limited to 8 keys with scalar values.</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public Dictionary<string, Metadata> Metadata { get; set; }

    /// <summary>
    /// Gets or Sets Resolved
    /// </summary>
    [DataMember(Name="resolved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolved")]
    public Dictionary<string, SnapshotManifestsValueResolvedValue> Resolved { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SnapshotManifestsValue {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  File: ").Append(File).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("  Resolved: ").Append(Resolved).Append("\n");
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
