using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Simple Commit
  /// </summary>
  [DataContract]
  public class SimpleCommit {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets TreeId
    /// </summary>
    [DataMember(Name="tree_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tree_id")]
    public string TreeId { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public DateTime? Timestamp { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public SimpleCommitAuthor Author { get; set; }

    /// <summary>
    /// Gets or Sets Committer
    /// </summary>
    [DataMember(Name="committer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "committer")]
    public SimpleCommitAuthor Committer { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SimpleCommit {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  TreeId: ").Append(TreeId).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Committer: ").Append(Committer).Append("\n");
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
