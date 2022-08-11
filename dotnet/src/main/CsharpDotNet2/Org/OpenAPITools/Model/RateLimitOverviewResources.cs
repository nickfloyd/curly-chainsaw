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
  public class RateLimitOverviewResources {
    /// <summary>
    /// Gets or Sets Core
    /// </summary>
    [DataMember(Name="core", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "core")]
    public RateLimit Core { get; set; }

    /// <summary>
    /// Gets or Sets Graphql
    /// </summary>
    [DataMember(Name="graphql", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "graphql")]
    public RateLimit Graphql { get; set; }

    /// <summary>
    /// Gets or Sets Search
    /// </summary>
    [DataMember(Name="search", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "search")]
    public RateLimit Search { get; set; }

    /// <summary>
    /// Gets or Sets SourceImport
    /// </summary>
    [DataMember(Name="source_import", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_import")]
    public RateLimit SourceImport { get; set; }

    /// <summary>
    /// Gets or Sets IntegrationManifest
    /// </summary>
    [DataMember(Name="integration_manifest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "integration_manifest")]
    public RateLimit IntegrationManifest { get; set; }

    /// <summary>
    /// Gets or Sets CodeScanningUpload
    /// </summary>
    [DataMember(Name="code_scanning_upload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code_scanning_upload")]
    public RateLimit CodeScanningUpload { get; set; }

    /// <summary>
    /// Gets or Sets ActionsRunnerRegistration
    /// </summary>
    [DataMember(Name="actions_runner_registration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actions_runner_registration")]
    public RateLimit ActionsRunnerRegistration { get; set; }

    /// <summary>
    /// Gets or Sets Scim
    /// </summary>
    [DataMember(Name="scim", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scim")]
    public RateLimit Scim { get; set; }

    /// <summary>
    /// Gets or Sets DependencySnapshots
    /// </summary>
    [DataMember(Name="dependency_snapshots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dependency_snapshots")]
    public RateLimit DependencySnapshots { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RateLimitOverviewResources {\n");
      sb.Append("  Core: ").Append(Core).Append("\n");
      sb.Append("  Graphql: ").Append(Graphql).Append("\n");
      sb.Append("  Search: ").Append(Search).Append("\n");
      sb.Append("  SourceImport: ").Append(SourceImport).Append("\n");
      sb.Append("  IntegrationManifest: ").Append(IntegrationManifest).Append("\n");
      sb.Append("  CodeScanningUpload: ").Append(CodeScanningUpload).Append("\n");
      sb.Append("  ActionsRunnerRegistration: ").Append(ActionsRunnerRegistration).Append("\n");
      sb.Append("  Scim: ").Append(Scim).Append("\n");
      sb.Append("  DependencySnapshots: ").Append(DependencySnapshots).Append("\n");
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
