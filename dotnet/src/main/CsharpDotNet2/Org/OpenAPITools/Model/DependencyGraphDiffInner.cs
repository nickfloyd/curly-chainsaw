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
  public class DependencyGraphDiffInner {
    /// <summary>
    /// Gets or Sets ChangeType
    /// </summary>
    [DataMember(Name="change_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "change_type")]
    public string ChangeType { get; set; }

    /// <summary>
    /// Gets or Sets Manifest
    /// </summary>
    [DataMember(Name="manifest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "manifest")]
    public string Manifest { get; set; }

    /// <summary>
    /// Gets or Sets Ecosystem
    /// </summary>
    [DataMember(Name="ecosystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ecosystem")]
    public string Ecosystem { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets _Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string _Version { get; set; }

    /// <summary>
    /// Gets or Sets PackageUrl
    /// </summary>
    [DataMember(Name="package_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "package_url")]
    public string PackageUrl { get; set; }

    /// <summary>
    /// Gets or Sets License
    /// </summary>
    [DataMember(Name="license", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "license")]
    public string License { get; set; }

    /// <summary>
    /// Gets or Sets SourceRepositoryUrl
    /// </summary>
    [DataMember(Name="source_repository_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_repository_url")]
    public string SourceRepositoryUrl { get; set; }

    /// <summary>
    /// Gets or Sets Vulnerabilities
    /// </summary>
    [DataMember(Name="vulnerabilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vulnerabilities")]
    public List<DependencyGraphDiffInnerVulnerabilitiesInner> Vulnerabilities { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DependencyGraphDiffInner {\n");
      sb.Append("  ChangeType: ").Append(ChangeType).Append("\n");
      sb.Append("  Manifest: ").Append(Manifest).Append("\n");
      sb.Append("  Ecosystem: ").Append(Ecosystem).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  _Version: ").Append(_Version).Append("\n");
      sb.Append("  PackageUrl: ").Append(PackageUrl).Append("\n");
      sb.Append("  License: ").Append(License).Append("\n");
      sb.Append("  SourceRepositoryUrl: ").Append(SourceRepositoryUrl).Append("\n");
      sb.Append("  Vulnerabilities: ").Append(Vulnerabilities).Append("\n");
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
