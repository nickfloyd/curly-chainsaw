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
  public class PullsMergeRequest {
    /// <summary>
    /// Title for the automatic commit message.
    /// </summary>
    /// <value>Title for the automatic commit message.</value>
    [DataMember(Name="commit_title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_title")]
    public string CommitTitle { get; set; }

    /// <summary>
    /// Extra detail to append to automatic commit message.
    /// </summary>
    /// <value>Extra detail to append to automatic commit message.</value>
    [DataMember(Name="commit_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_message")]
    public string CommitMessage { get; set; }

    /// <summary>
    /// SHA that pull request head must match to allow merge.
    /// </summary>
    /// <value>SHA that pull request head must match to allow merge.</value>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// Merge method to use. Possible values are `merge`, `squash` or `rebase`. Default is `merge`.
    /// </summary>
    /// <value>Merge method to use. Possible values are `merge`, `squash` or `rebase`. Default is `merge`.</value>
    [DataMember(Name="merge_method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merge_method")]
    public string MergeMethod { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PullsMergeRequest {\n");
      sb.Append("  CommitTitle: ").Append(CommitTitle).Append("\n");
      sb.Append("  CommitMessage: ").Append(CommitMessage).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  MergeMethod: ").Append(MergeMethod).Append("\n");
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
