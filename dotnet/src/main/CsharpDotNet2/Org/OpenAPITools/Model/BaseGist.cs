using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Base Gist
  /// </summary>
  [DataContract]
  public class BaseGist {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets ForksUrl
    /// </summary>
    [DataMember(Name="forks_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forks_url")]
    public string ForksUrl { get; set; }

    /// <summary>
    /// Gets or Sets CommitsUrl
    /// </summary>
    [DataMember(Name="commits_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commits_url")]
    public string CommitsUrl { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// Gets or Sets GitPullUrl
    /// </summary>
    [DataMember(Name="git_pull_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "git_pull_url")]
    public string GitPullUrl { get; set; }

    /// <summary>
    /// Gets or Sets GitPushUrl
    /// </summary>
    [DataMember(Name="git_push_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "git_push_url")]
    public string GitPushUrl { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets Files
    /// </summary>
    [DataMember(Name="files", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "files")]
    public Dictionary<string, BaseGistFilesValue> Files { get; set; }

    /// <summary>
    /// Gets or Sets Public
    /// </summary>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public bool? Public { get; set; }

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
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Comments
    /// </summary>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public int? Comments { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUser User { get; set; }

    /// <summary>
    /// Gets or Sets CommentsUrl
    /// </summary>
    [DataMember(Name="comments_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments_url")]
    public string CommentsUrl { get; set; }

    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public SimpleUser1 Owner { get; set; }

    /// <summary>
    /// Gets or Sets Truncated
    /// </summary>
    [DataMember(Name="truncated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "truncated")]
    public bool? Truncated { get; set; }

    /// <summary>
    /// Gets or Sets Forks
    /// </summary>
    [DataMember(Name="forks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forks")]
    public List<Object> Forks { get; set; }

    /// <summary>
    /// Gets or Sets History
    /// </summary>
    [DataMember(Name="history", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "history")]
    public List<Object> History { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BaseGist {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  ForksUrl: ").Append(ForksUrl).Append("\n");
      sb.Append("  CommitsUrl: ").Append(CommitsUrl).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  GitPullUrl: ").Append(GitPullUrl).Append("\n");
      sb.Append("  GitPushUrl: ").Append(GitPushUrl).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  Files: ").Append(Files).Append("\n");
      sb.Append("  Public: ").Append(Public).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  CommentsUrl: ").Append(CommentsUrl).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  Truncated: ").Append(Truncated).Append("\n");
      sb.Append("  Forks: ").Append(Forks).Append("\n");
      sb.Append("  History: ").Append(History).Append("\n");
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
