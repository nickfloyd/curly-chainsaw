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
  public class CodespacesCreateForAuthenticatedUserRequestOneOf1 {
    /// <summary>
    /// Gets or Sets PullRequest
    /// </summary>
    [DataMember(Name="pull_request", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pull_request")]
    public CodespacesCreateForAuthenticatedUserRequestOneOf1PullRequest PullRequest { get; set; }

    /// <summary>
    /// Location for this codespace. Assigned by IP if not provided
    /// </summary>
    /// <value>Location for this codespace. Assigned by IP if not provided</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodespacesCreateForAuthenticatedUserRequestOneOf1 {\n");
      sb.Append("  PullRequest: ").Append(PullRequest).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Machine: ").Append(Machine).Append("\n");
      sb.Append("  DevcontainerPath: ").Append(DevcontainerPath).Append("\n");
      sb.Append("  WorkingDirectory: ").Append(WorkingDirectory).Append("\n");
      sb.Append("  IdleTimeoutMinutes: ").Append(IdleTimeoutMinutes).Append("\n");
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
