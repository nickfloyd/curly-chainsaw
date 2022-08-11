using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Commit Search Result Item
  /// </summary>
  [DataContract]
  public class CommitSearchResultItem {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Sha
    /// </summary>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets CommentsUrl
    /// </summary>
    [DataMember(Name="comments_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments_url")]
    public string CommentsUrl { get; set; }

    /// <summary>
    /// Gets or Sets Commit
    /// </summary>
    [DataMember(Name="commit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit")]
    public CommitSearchResultItemCommit Commit { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public SimpleUser Author { get; set; }

    /// <summary>
    /// Gets or Sets Committer
    /// </summary>
    [DataMember(Name="committer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "committer")]
    public GitUser Committer { get; set; }

    /// <summary>
    /// Gets or Sets Parents
    /// </summary>
    [DataMember(Name="parents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parents")]
    public List<FileCommitCommitParentsInner> Parents { get; set; }

    /// <summary>
    /// Gets or Sets Repository
    /// </summary>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public MinimalRepository Repository { get; set; }

    /// <summary>
    /// Gets or Sets Score
    /// </summary>
    [DataMember(Name="score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "score")]
    public decimal? Score { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// Gets or Sets TextMatches
    /// </summary>
    [DataMember(Name="text_matches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text_matches")]
    public List<SearchResultTextMatchesInner> TextMatches { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommitSearchResultItem {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  CommentsUrl: ").Append(CommentsUrl).Append("\n");
      sb.Append("  Commit: ").Append(Commit).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Committer: ").Append(Committer).Append("\n");
      sb.Append("  Parents: ").Append(Parents).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      sb.Append("  Score: ").Append(Score).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  TextMatches: ").Append(TextMatches).Append("\n");
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
