using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A single package dependency.
  /// </summary>
  [DataContract]
  public class SnapshotManifestsValueResolvedValue {
    /// <summary>
    /// Package-url (PURL) of dependency. See https://github.com/package-url/purl-spec for more details.
    /// </summary>
    /// <value>Package-url (PURL) of dependency. See https://github.com/package-url/purl-spec for more details.</value>
    [DataMember(Name="package_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "package_url")]
    public string PackageUrl { get; set; }

    /// <summary>
    /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
    /// </summary>
    /// <value>User-defined metadata to store domain-specific information limited to 8 keys with scalar values.</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public Dictionary<string, Metadata> Metadata { get; set; }

    /// <summary>
    /// A notation of whether a dependency is requested directly by this manifest or is a dependency of another dependency.
    /// </summary>
    /// <value>A notation of whether a dependency is requested directly by this manifest or is a dependency of another dependency.</value>
    [DataMember(Name="relationship", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relationship")]
    public string Relationship { get; set; }

    /// <summary>
    /// A notation of whether the dependency is required for the primary build artifact (runtime) or is only used for development. Future versions of this specification may allow for more granular scopes.
    /// </summary>
    /// <value>A notation of whether the dependency is required for the primary build artifact (runtime) or is only used for development. Future versions of this specification may allow for more granular scopes.</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// Array of package-url (PURLs) of direct child dependencies.
    /// </summary>
    /// <value>Array of package-url (PURLs) of direct child dependencies.</value>
    [DataMember(Name="dependencies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dependencies")]
    public List<string> Dependencies { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SnapshotManifestsValueResolvedValue {\n");
      sb.Append("  PackageUrl: ").Append(PackageUrl).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
      sb.Append("  Relationship: ").Append(Relationship).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
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
