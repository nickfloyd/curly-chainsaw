using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Comments provide a way for people to collaborate on an issue.
  /// </summary>
  [DataContract]
  public class IssueComment {
    /// <summary>
    /// Unique identifier of the issue comment
    /// </summary>
    /// <value>Unique identifier of the issue comment</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// URL for the issue comment
    /// </summary>
    /// <value>URL for the issue comment</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Contents of the issue comment
    /// </summary>
    /// <value>Contents of the issue comment</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// Gets or Sets BodyText
    /// </summary>
    [DataMember(Name="body_text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body_text")]
    public string BodyText { get; set; }

    /// <summary>
    /// Gets or Sets BodyHtml
    /// </summary>
    [DataMember(Name="body_html", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body_html")]
    public string BodyHtml { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUser User { get; set; }

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
    /// Gets or Sets IssueUrl
    /// </summary>
    [DataMember(Name="issue_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issue_url")]
    public string IssueUrl { get; set; }

    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    /// <value>How the author is associated with the repository.</value>
    [DataMember(Name="author_association", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author_association")]
    public string AuthorAssociation { get; set; }

    /// <summary>
    /// Gets or Sets PerformedViaGithubApp
    /// </summary>
    [DataMember(Name="performed_via_github_app", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "performed_via_github_app")]
    public GitHubApp1 PerformedViaGithubApp { get; set; }

    /// <summary>
    /// Gets or Sets Reactions
    /// </summary>
    [DataMember(Name="reactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reactions")]
    public ReactionRollup Reactions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueComment {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  BodyText: ").Append(BodyText).Append("\n");
      sb.Append("  BodyHtml: ").Append(BodyHtml).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  IssueUrl: ").Append(IssueUrl).Append("\n");
      sb.Append("  AuthorAssociation: ").Append(AuthorAssociation).Append("\n");
      sb.Append("  PerformedViaGithubApp: ").Append(PerformedViaGithubApp).Append("\n");
      sb.Append("  Reactions: ").Append(Reactions).Append("\n");
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
