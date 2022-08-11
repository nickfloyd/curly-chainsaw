using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Create a new snapshot of a repository&#39;s dependencies.
  /// </summary>
  [DataContract]
  public class Snapshot {
    /// <summary>
    /// The version of the repository snapshot submission.
    /// </summary>
    /// <value>The version of the repository snapshot submission.</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public int? _Version { get; set; }

    /// <summary>
    /// Gets or Sets Job
    /// </summary>
    [DataMember(Name="job", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job")]
    public SnapshotJob Job { get; set; }

    /// <summary>
    /// The commit SHA associated with this dependency snapshot.
    /// </summary>
    /// <value>The commit SHA associated with this dependency snapshot.</value>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// The repository branch that triggered this snapshot.
    /// </summary>
    /// <value>The repository branch that triggered this snapshot.</value>
    [DataMember(Name="ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref")]
    public string Ref { get; set; }

    /// <summary>
    /// Gets or Sets Detector
    /// </summary>
    [DataMember(Name="detector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detector")]
    public SnapshotDetector Detector { get; set; }

    /// <summary>
    /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
    /// </summary>
    /// <value>User-defined metadata to store domain-specific information limited to 8 keys with scalar values.</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public Dictionary<string, Metadata> Metadata { get; set; }

    /// <summary>
    /// A collection of package manifests
    /// </summary>
    /// <value>A collection of package manifests</value>
    [DataMember(Name="manifests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "manifests")]
    public Dictionary<string, SnapshotManifestsValue> Manifests { get; set; }

    /// <summary>
    /// The time at which the snapshot was scanned.
    /// </summary>
    /// <value>The time at which the snapshot was scanned.</value>
    [DataMember(Name="scanned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scanned")]
    public DateTime? Scanned { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Snapshot {\n");
      sb.Append("  _Version: ").Append(_Version).Append("\n");
      sb.Append("  Job: ").Append(Job).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  Ref: ").Append(Ref).Append("\n");
      sb.Append("  Detector: ").Append(Detector).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("  Manifests: ").Append(Manifests).Append("\n");
      sb.Append("  Scanned: ").Append(Scanned).Append("\n");
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
