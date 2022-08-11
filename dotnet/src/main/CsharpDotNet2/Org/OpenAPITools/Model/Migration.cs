using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A migration.
  /// </summary>
  [DataContract]
  public class Migration {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public SimpleUser Owner { get; set; }

    /// <summary>
    /// Gets or Sets Guid
    /// </summary>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets LockRepositories
    /// </summary>
    [DataMember(Name="lock_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lock_repositories")]
    public bool? LockRepositories { get; set; }

    /// <summary>
    /// Gets or Sets ExcludeMetadata
    /// </summary>
    [DataMember(Name="exclude_metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude_metadata")]
    public bool? ExcludeMetadata { get; set; }

    /// <summary>
    /// Gets or Sets ExcludeGitData
    /// </summary>
    [DataMember(Name="exclude_git_data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude_git_data")]
    public bool? ExcludeGitData { get; set; }

    /// <summary>
    /// Gets or Sets ExcludeAttachments
    /// </summary>
    [DataMember(Name="exclude_attachments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude_attachments")]
    public bool? ExcludeAttachments { get; set; }

    /// <summary>
    /// Gets or Sets ExcludeReleases
    /// </summary>
    [DataMember(Name="exclude_releases", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude_releases")]
    public bool? ExcludeReleases { get; set; }

    /// <summary>
    /// Gets or Sets ExcludeOwnerProjects
    /// </summary>
    [DataMember(Name="exclude_owner_projects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude_owner_projects")]
    public bool? ExcludeOwnerProjects { get; set; }

    /// <summary>
    /// Gets or Sets OrgMetadataOnly
    /// </summary>
    [DataMember(Name="org_metadata_only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "org_metadata_only")]
    public bool? OrgMetadataOnly { get; set; }

    /// <summary>
    /// Gets or Sets Repositories
    /// </summary>
    [DataMember(Name="repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositories")]
    public List<Repository> Repositories { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// Gets or Sets ArchiveUrl
    /// </summary>
    [DataMember(Name="archive_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archive_url")]
    public string ArchiveUrl { get; set; }

    /// <summary>
    /// Gets or Sets Exclude
    /// </summary>
    [DataMember(Name="exclude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude")]
    public List<Object> Exclude { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Migration {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  LockRepositories: ").Append(LockRepositories).Append("\n");
      sb.Append("  ExcludeMetadata: ").Append(ExcludeMetadata).Append("\n");
      sb.Append("  ExcludeGitData: ").Append(ExcludeGitData).Append("\n");
      sb.Append("  ExcludeAttachments: ").Append(ExcludeAttachments).Append("\n");
      sb.Append("  ExcludeReleases: ").Append(ExcludeReleases).Append("\n");
      sb.Append("  ExcludeOwnerProjects: ").Append(ExcludeOwnerProjects).Append("\n");
      sb.Append("  OrgMetadataOnly: ").Append(OrgMetadataOnly).Append("\n");
      sb.Append("  Repositories: ").Append(Repositories).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  ArchiveUrl: ").Append(ArchiveUrl).Append("\n");
      sb.Append("  Exclude: ").Append(Exclude).Append("\n");
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
