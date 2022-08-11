using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Details about the codespace&#39;s git repository.
  /// </summary>
  [DataContract]
  public class CodespaceGitStatus {
    /// <summary>
    /// The number of commits the local repository is ahead of the remote.
    /// </summary>
    /// <value>The number of commits the local repository is ahead of the remote.</value>
    [DataMember(Name="ahead", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ahead")]
    public int? Ahead { get; set; }

    /// <summary>
    /// The number of commits the local repository is behind the remote.
    /// </summary>
    /// <value>The number of commits the local repository is behind the remote.</value>
    [DataMember(Name="behind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "behind")]
    public int? Behind { get; set; }

    /// <summary>
    /// Whether the local repository has unpushed changes.
    /// </summary>
    /// <value>Whether the local repository has unpushed changes.</value>
    [DataMember(Name="has_unpushed_changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_unpushed_changes")]
    public bool? HasUnpushedChanges { get; set; }

    /// <summary>
    /// Whether the local repository has uncommitted changes.
    /// </summary>
    /// <value>Whether the local repository has uncommitted changes.</value>
    [DataMember(Name="has_uncommitted_changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_uncommitted_changes")]
    public bool? HasUncommittedChanges { get; set; }

    /// <summary>
    /// The current branch (or SHA if in detached HEAD state) of the local repository.
    /// </summary>
    /// <value>The current branch (or SHA if in detached HEAD state) of the local repository.</value>
    [DataMember(Name="ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ref")]
    public string Ref { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodespaceGitStatus {\n");
      sb.Append("  Ahead: ").Append(Ahead).Append("\n");
      sb.Append("  Behind: ").Append(Behind).Append("\n");
      sb.Append("  HasUnpushedChanges: ").Append(HasUnpushedChanges).Append("\n");
      sb.Append("  HasUncommittedChanges: ").Append(HasUncommittedChanges).Append("\n");
      sb.Append("  Ref: ").Append(Ref).Append("\n");
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
