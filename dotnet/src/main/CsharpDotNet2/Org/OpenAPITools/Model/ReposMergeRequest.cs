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
  public class ReposMergeRequest {
    /// <summary>
    /// The name of the base branch that the head will be merged into.
    /// </summary>
    /// <value>The name of the base branch that the head will be merged into.</value>
    [DataMember(Name="base", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base")]
    public string Base { get; set; }

    /// <summary>
    /// The head to merge. This can be a branch name or a commit SHA1.
    /// </summary>
    /// <value>The head to merge. This can be a branch name or a commit SHA1.</value>
    [DataMember(Name="head", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head")]
    public string Head { get; set; }

    /// <summary>
    /// Commit message to use for the merge commit. If omitted, a default message will be used.
    /// </summary>
    /// <value>Commit message to use for the merge commit. If omitted, a default message will be used.</value>
    [DataMember(Name="commit_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_message")]
    public string CommitMessage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposMergeRequest {\n");
      sb.Append("  Base: ").Append(Base).Append("\n");
      sb.Append("  Head: ").Append(Head).Append("\n");
      sb.Append("  CommitMessage: ").Append(CommitMessage).Append("\n");
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
