using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A codespace.
  /// </summary>
  [DataContract]
  public class Codespace {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Automatically generated name of this codespace.
    /// </summary>
    /// <value>Automatically generated name of this codespace.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Display name for this codespace.
    /// </summary>
    /// <value>Display name for this codespace.</value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// UUID identifying this codespace's environment.
    /// </summary>
    /// <value>UUID identifying this codespace's environment.</value>
    [DataMember(Name="environment_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment_id")]
    public string EnvironmentId { get; set; }

    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public SimpleUser1 Owner { get; set; }

    /// <summary>
    /// Gets or Sets BillableOwner
    /// </summary>
    [DataMember(Name="billable_owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "billable_owner")]
    public SimpleUser1 BillableOwner { get; set; }

    /// <summary>
    /// Gets or Sets Repository
    /// </summary>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public MinimalRepository Repository { get; set; }

    /// <summary>
    /// Gets or Sets Machine
    /// </summary>
    [DataMember(Name="machine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "machine")]
    public CodespaceMachine Machine { get; set; }

    /// <summary>
    /// Path to devcontainer.json from repo root used to create Codespace.
    /// </summary>
    /// <value>Path to devcontainer.json from repo root used to create Codespace.</value>
    [DataMember(Name="devcontainer_path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "devcontainer_path")]
    public string DevcontainerPath { get; set; }

    /// <summary>
    /// Whether the codespace was created from a prebuild.
    /// </summary>
    /// <value>Whether the codespace was created from a prebuild.</value>
    [DataMember(Name="prebuild", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prebuild")]
    public bool? Prebuild { get; set; }

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
    /// Last known time this codespace was started.
    /// </summary>
    /// <value>Last known time this codespace was started.</value>
    [DataMember(Name="last_used_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_used_at")]
    public DateTime? LastUsedAt { get; set; }

    /// <summary>
    /// State of this codespace.
    /// </summary>
    /// <value>State of this codespace.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// API URL for this codespace.
    /// </summary>
    /// <value>API URL for this codespace.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets GitStatus
    /// </summary>
    [DataMember(Name="git_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "git_status")]
    public CodespaceGitStatus GitStatus { get; set; }

    /// <summary>
    /// The Azure region where this codespace is located.
    /// </summary>
    /// <value>The Azure region where this codespace is located.</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// The number of minutes of inactivity after which this codespace will be automatically stopped.
    /// </summary>
    /// <value>The number of minutes of inactivity after which this codespace will be automatically stopped.</value>
    [DataMember(Name="idle_timeout_minutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idle_timeout_minutes")]
    public int? IdleTimeoutMinutes { get; set; }

    /// <summary>
    /// URL to access this codespace on the web.
    /// </summary>
    /// <value>URL to access this codespace on the web.</value>
    [DataMember(Name="web_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "web_url")]
    public string WebUrl { get; set; }

    /// <summary>
    /// API URL to access available alternate machine types for this codespace.
    /// </summary>
    /// <value>API URL to access available alternate machine types for this codespace.</value>
    [DataMember(Name="machines_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "machines_url")]
    public string MachinesUrl { get; set; }

    /// <summary>
    /// API URL to start this codespace.
    /// </summary>
    /// <value>API URL to start this codespace.</value>
    [DataMember(Name="start_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_url")]
    public string StartUrl { get; set; }

    /// <summary>
    /// API URL to stop this codespace.
    /// </summary>
    /// <value>API URL to stop this codespace.</value>
    [DataMember(Name="stop_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stop_url")]
    public string StopUrl { get; set; }

    /// <summary>
    /// API URL for the Pull Request associated with this codespace, if any.
    /// </summary>
    /// <value>API URL for the Pull Request associated with this codespace, if any.</value>
    [DataMember(Name="pulls_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pulls_url")]
    public string PullsUrl { get; set; }

    /// <summary>
    /// Gets or Sets RecentFolders
    /// </summary>
    [DataMember(Name="recent_folders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recent_folders")]
    public List<string> RecentFolders { get; set; }

    /// <summary>
    /// Gets or Sets RuntimeConstraints
    /// </summary>
    [DataMember(Name="runtime_constraints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runtime_constraints")]
    public CodespaceRuntimeConstraints RuntimeConstraints { get; set; }

    /// <summary>
    /// Whether or not a codespace has a pending async operation. This would mean that the codespace is temporarily unavailable. The only thing that you can do with a codespace in this state is delete it.
    /// </summary>
    /// <value>Whether or not a codespace has a pending async operation. This would mean that the codespace is temporarily unavailable. The only thing that you can do with a codespace in this state is delete it.</value>
    [DataMember(Name="pending_operation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pending_operation")]
    public bool? PendingOperation { get; set; }

    /// <summary>
    /// Text to show user when codespace is disabled by a pending operation
    /// </summary>
    /// <value>Text to show user when codespace is disabled by a pending operation</value>
    [DataMember(Name="pending_operation_disabled_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pending_operation_disabled_reason")]
    public string PendingOperationDisabledReason { get; set; }

    /// <summary>
    /// Text to show user when codespace idle timeout minutes has been overriden by an organization policy
    /// </summary>
    /// <value>Text to show user when codespace idle timeout minutes has been overriden by an organization policy</value>
    [DataMember(Name="idle_timeout_notice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idle_timeout_notice")]
    public string IdleTimeoutNotice { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Codespace {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  EnvironmentId: ").Append(EnvironmentId).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  BillableOwner: ").Append(BillableOwner).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      sb.Append("  Machine: ").Append(Machine).Append("\n");
      sb.Append("  DevcontainerPath: ").Append(DevcontainerPath).Append("\n");
      sb.Append("  Prebuild: ").Append(Prebuild).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  LastUsedAt: ").Append(LastUsedAt).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  GitStatus: ").Append(GitStatus).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  IdleTimeoutMinutes: ").Append(IdleTimeoutMinutes).Append("\n");
      sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
      sb.Append("  MachinesUrl: ").Append(MachinesUrl).Append("\n");
      sb.Append("  StartUrl: ").Append(StartUrl).Append("\n");
      sb.Append("  StopUrl: ").Append(StopUrl).Append("\n");
      sb.Append("  PullsUrl: ").Append(PullsUrl).Append("\n");
      sb.Append("  RecentFolders: ").Append(RecentFolders).Append("\n");
      sb.Append("  RuntimeConstraints: ").Append(RuntimeConstraints).Append("\n");
      sb.Append("  PendingOperation: ").Append(PendingOperation).Append("\n");
      sb.Append("  PendingOperationDisabledReason: ").Append(PendingOperationDisabledReason).Append("\n");
      sb.Append("  IdleTimeoutNotice: ").Append(IdleTimeoutNotice).Append("\n");
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
