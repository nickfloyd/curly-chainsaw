using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// An artifact
  /// </summary>
  [DataContract]
  public class Artifact {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// The name of the artifact.
    /// </summary>
    /// <value>The name of the artifact.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The size in bytes of the artifact.
    /// </summary>
    /// <value>The size in bytes of the artifact.</value>
    [DataMember(Name="size_in_bytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size_in_bytes")]
    public int? SizeInBytes { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets ArchiveDownloadUrl
    /// </summary>
    [DataMember(Name="archive_download_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archive_download_url")]
    public string ArchiveDownloadUrl { get; set; }

    /// <summary>
    /// Whether or not the artifact has expired.
    /// </summary>
    /// <value>Whether or not the artifact has expired.</value>
    [DataMember(Name="expired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expired")]
    public bool? Expired { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets ExpiresAt
    /// </summary>
    [DataMember(Name="expires_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires_at")]
    public DateTime? ExpiresAt { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets WorkflowRun
    /// </summary>
    [DataMember(Name="workflow_run", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workflow_run")]
    public ArtifactWorkflowRun WorkflowRun { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Artifact {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SizeInBytes: ").Append(SizeInBytes).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  ArchiveDownloadUrl: ").Append(ArchiveDownloadUrl).Append("\n");
      sb.Append("  Expired: ").Append(Expired).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  WorkflowRun: ").Append(WorkflowRun).Append("\n");
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
