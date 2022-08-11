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
  public class ReposDeleteFileRequest {
    /// <summary>
    /// The commit message.
    /// </summary>
    /// <value>The commit message.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// The blob SHA of the file being replaced.
    /// </summary>
    /// <value>The blob SHA of the file being replaced.</value>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// The branch name. Default: the repository’s default branch (usually `master`)
    /// </summary>
    /// <value>The branch name. Default: the repository’s default branch (usually `master`)</value>
    [DataMember(Name="branch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "branch")]
    public string Branch { get; set; }

    /// <summary>
    /// Gets or Sets Committer
    /// </summary>
    [DataMember(Name="committer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "committer")]
    public ReposDeleteFileRequestCommitter Committer { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public ReposDeleteFileRequestAuthor Author { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposDeleteFileRequest {\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  Branch: ").Append(Branch).Append("\n");
      sb.Append("  Committer: ").Append(Committer).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
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
