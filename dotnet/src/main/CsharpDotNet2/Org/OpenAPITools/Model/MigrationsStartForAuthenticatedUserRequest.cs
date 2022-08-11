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
  public class MigrationsStartForAuthenticatedUserRequest {
    /// <summary>
    /// Lock the repositories being migrated at the start of the migration
    /// </summary>
    /// <value>Lock the repositories being migrated at the start of the migration</value>
    [DataMember(Name="lock_repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lock_repositories")]
    public bool? LockRepositories { get; set; }

    /// <summary>
    /// Indicates whether metadata should be excluded and only git source should be included for the migration.
    /// </summary>
    /// <value>Indicates whether metadata should be excluded and only git source should be included for the migration.</value>
    [DataMember(Name="exclude_metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude_metadata")]
    public bool? ExcludeMetadata { get; set; }

    /// <summary>
    /// Indicates whether the repository git data should be excluded from the migration.
    /// </summary>
    /// <value>Indicates whether the repository git data should be excluded from the migration.</value>
    [DataMember(Name="exclude_git_data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude_git_data")]
    public bool? ExcludeGitData { get; set; }

    /// <summary>
    /// Do not include attachments in the migration
    /// </summary>
    /// <value>Do not include attachments in the migration</value>
    [DataMember(Name="exclude_attachments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude_attachments")]
    public bool? ExcludeAttachments { get; set; }

    /// <summary>
    /// Do not include releases in the migration
    /// </summary>
    /// <value>Do not include releases in the migration</value>
    [DataMember(Name="exclude_releases", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude_releases")]
    public bool? ExcludeReleases { get; set; }

    /// <summary>
    /// Indicates whether projects owned by the organization or users should be excluded.
    /// </summary>
    /// <value>Indicates whether projects owned by the organization or users should be excluded.</value>
    [DataMember(Name="exclude_owner_projects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude_owner_projects")]
    public bool? ExcludeOwnerProjects { get; set; }

    /// <summary>
    /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).
    /// </summary>
    /// <value>Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).</value>
    [DataMember(Name="org_metadata_only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "org_metadata_only")]
    public bool? OrgMetadataOnly { get; set; }

    /// <summary>
    /// Exclude attributes from the API response to improve performance
    /// </summary>
    /// <value>Exclude attributes from the API response to improve performance</value>
    [DataMember(Name="exclude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude")]
    public List<string> Exclude { get; set; }

    /// <summary>
    /// Gets or Sets Repositories
    /// </summary>
    [DataMember(Name="repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositories")]
    public List<string> Repositories { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MigrationsStartForAuthenticatedUserRequest {\n");
      sb.Append("  LockRepositories: ").Append(LockRepositories).Append("\n");
      sb.Append("  ExcludeMetadata: ").Append(ExcludeMetadata).Append("\n");
      sb.Append("  ExcludeGitData: ").Append(ExcludeGitData).Append("\n");
      sb.Append("  ExcludeAttachments: ").Append(ExcludeAttachments).Append("\n");
      sb.Append("  ExcludeReleases: ").Append(ExcludeReleases).Append("\n");
      sb.Append("  ExcludeOwnerProjects: ").Append(ExcludeOwnerProjects).Append("\n");
      sb.Append("  OrgMetadataOnly: ").Append(OrgMetadataOnly).Append("\n");
      sb.Append("  Exclude: ").Append(Exclude).Append("\n");
      sb.Append("  Repositories: ").Append(Repositories).Append("\n");
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
