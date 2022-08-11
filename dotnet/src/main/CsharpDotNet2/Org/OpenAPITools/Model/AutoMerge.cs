using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The status of auto merging a pull request.
  /// </summary>
  [DataContract]
  public class AutoMerge {
    /// <summary>
    /// Gets or Sets EnabledBy
    /// </summary>
    [DataMember(Name="enabled_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled_by")]
    public SimpleUser1 EnabledBy { get; set; }

    /// <summary>
    /// The merge method to use.
    /// </summary>
    /// <value>The merge method to use.</value>
    [DataMember(Name="merge_method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merge_method")]
    public string MergeMethod { get; set; }

    /// <summary>
    /// Title for the merge commit message.
    /// </summary>
    /// <value>Title for the merge commit message.</value>
    [DataMember(Name="commit_title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_title")]
    public string CommitTitle { get; set; }

    /// <summary>
    /// Commit message for the merge commit.
    /// </summary>
    /// <value>Commit message for the merge commit.</value>
    [DataMember(Name="commit_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_message")]
    public string CommitMessage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AutoMerge {\n");
      sb.Append("  EnabledBy: ").Append(EnabledBy).Append("\n");
      sb.Append("  MergeMethod: ").Append(MergeMethod).Append("\n");
      sb.Append("  CommitTitle: ").Append(CommitTitle).Append("\n");
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
