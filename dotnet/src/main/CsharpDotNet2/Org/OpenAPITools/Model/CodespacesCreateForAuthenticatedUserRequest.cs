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
  public class CodespacesCreateForAuthenticatedUserRequest {
    /// <summary>
    /// Repository id for this codespace
    /// </summary>
    /// <value>Repository id for this codespace</value>
    [DataMember(Name="repository_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_id")]
    public int? RepositoryId { get; set; }

    /// <summary>
    /// Git ref (typically a branch name) for this codespace
    /// </summary>
    /// <value>Git ref (typically a branch name) for this codespace</value>
    [DataMember(Name="ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref")]
    public string Ref { get; set; }

    /// <summary>
    /// Location for this codespace. Assigned by IP if not provided
    /// </summary>
    /// <value>Location for this codespace. Assigned by IP if not provided</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// IP for location auto-detection when proxying a request
    /// </summary>
    /// <value>IP for location auto-detection when proxying a request</value>
    [DataMember(Name="client_ip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_ip")]
    public string ClientIp { get; set; }

    /// <summary>
    /// Machine type to use for this codespace
    /// </summary>
    /// <value>Machine type to use for this codespace</value>
    [DataMember(Name="machine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "machine")]
    public string Machine { get; set; }

    /// <summary>
    /// Path to devcontainer.json config to use for this codespace
    /// </summary>
    /// <value>Path to devcontainer.json config to use for this codespace</value>
    [DataMember(Name="devcontainer_path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "devcontainer_path")]
    public string DevcontainerPath { get; set; }

    /// <summary>
    /// Whether to authorize requested permissions from devcontainer.json
    /// </summary>
    /// <value>Whether to authorize requested permissions from devcontainer.json</value>
    [DataMember(Name="multi_repo_permissions_opt_out", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "multi_repo_permissions_opt_out")]
    public bool? MultiRepoPermissionsOptOut { get; set; }

    /// <summary>
    /// Working directory for this codespace
    /// </summary>
    /// <value>Working directory for this codespace</value>
    [DataMember(Name="working_directory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "working_directory")]
    public string WorkingDirectory { get; set; }

    /// <summary>
    /// Time in minutes before codespace stops from inactivity
    /// </summary>
    /// <value>Time in minutes before codespace stops from inactivity</value>
    [DataMember(Name="idle_timeout_minutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idle_timeout_minutes")]
    public int? IdleTimeoutMinutes { get; set; }

    /// <summary>
    /// Display name for this codespace
    /// </summary>
    /// <value>Display name for this codespace</value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days).
    /// </summary>
    /// <value>Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days).</value>
    [DataMember(Name="retention_period_minutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "retention_period_minutes")]
    public int? RetentionPeriodMinutes { get; set; }

    /// <summary>
    /// Gets or Sets PullRequest
    /// </summary>
    [DataMember(Name="pull_request", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pull_request")]
    public CodespacesCreateForAuthenticatedUserRequestOneOf1PullRequest PullRequest { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodespacesCreateForAuthenticatedUserRequest {\n");
      sb.Append("  RepositoryId: ").Append(RepositoryId).Append("\n");
      sb.Append("  Ref: ").Append(Ref).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  ClientIp: ").Append(ClientIp).Append("\n");
      sb.Append("  Machine: ").Append(Machine).Append("\n");
      sb.Append("  DevcontainerPath: ").Append(DevcontainerPath).Append("\n");
      sb.Append("  MultiRepoPermissionsOptOut: ").Append(MultiRepoPermissionsOptOut).Append("\n");
      sb.Append("  WorkingDirectory: ").Append(WorkingDirectory).Append("\n");
      sb.Append("  IdleTimeoutMinutes: ").Append(IdleTimeoutMinutes).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  RetentionPeriodMinutes: ").Append(RetentionPeriodMinutes).Append("\n");
      sb.Append("  PullRequest: ").Append(PullRequest).Append("\n");
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
