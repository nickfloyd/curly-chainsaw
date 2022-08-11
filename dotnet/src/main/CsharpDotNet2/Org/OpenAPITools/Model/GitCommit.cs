using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Low-level Git commit operations within a repository
  /// </summary>
  [DataContract]
  public class GitCommit {
    /// <summary>
    /// SHA for the commit
    /// </summary>
    /// <value>SHA for the commit</value>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public GitCommitAuthor Author { get; set; }

    /// <summary>
    /// Gets or Sets Committer
    /// </summary>
    [DataMember(Name="committer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "committer")]
    public GitCommitAuthor Committer { get; set; }

    /// <summary>
    /// Message describing the purpose of the commit
    /// </summary>
    /// <value>Message describing the purpose of the commit</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Tree
    /// </summary>
    [DataMember(Name="tree", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tree")]
    public GitCommitTree Tree { get; set; }

    /// <summary>
    /// Gets or Sets Parents
    /// </summary>
    [DataMember(Name="parents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parents")]
    public List<GitCommitParentsInner> Parents { get; set; }

    /// <summary>
    /// Gets or Sets Verification
    /// </summary>
    [DataMember(Name="verification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verification")]
    public GitCommitVerification Verification { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GitCommit {\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Committer: ").Append(Committer).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Tree: ").Append(Tree).Append("\n");
      sb.Append("  Parents: ").Append(Parents).Append("\n");
      sb.Append("  Verification: ").Append(Verification).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
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
