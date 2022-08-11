using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A team discussion is a persistent record of a free-form conversation within a team.
  /// </summary>
  [DataContract]
  public class TeamDiscussion {
    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public SimpleUser Author { get; set; }

    /// <summary>
    /// The main text of the discussion.
    /// </summary>
    /// <value>The main text of the discussion.</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// Gets or Sets BodyHtml
    /// </summary>
    [DataMember(Name="body_html", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body_html")]
    public string BodyHtml { get; set; }

    /// <summary>
    /// The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.
    /// </summary>
    /// <value>The current version of the body content. If provided, this update operation will be rejected if the given version does not match the latest version on the server.</value>
    [DataMember(Name="body_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body_version")]
    public string BodyVersion { get; set; }

    /// <summary>
    /// Gets or Sets CommentsCount
    /// </summary>
    [DataMember(Name="comments_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments_count")]
    public int? CommentsCount { get; set; }

    /// <summary>
    /// Gets or Sets CommentsUrl
    /// </summary>
    [DataMember(Name="comments_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments_url")]
    public string CommentsUrl { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets LastEditedAt
    /// </summary>
    [DataMember(Name="last_edited_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_edited_at")]
    public DateTime? LastEditedAt { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// The unique sequence number of a team discussion.
    /// </summary>
    /// <value>The unique sequence number of a team discussion.</value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public int? Number { get; set; }

    /// <summary>
    /// Whether or not this discussion should be pinned for easy retrieval.
    /// </summary>
    /// <value>Whether or not this discussion should be pinned for easy retrieval.</value>
    [DataMember(Name="pinned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pinned")]
    public bool? Pinned { get; set; }

    /// <summary>
    /// Whether or not this discussion should be restricted to team members and organization administrators.
    /// </summary>
    /// <value>Whether or not this discussion should be restricted to team members and organization administrators.</value>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? Private { get; set; }

    /// <summary>
    /// Gets or Sets TeamUrl
    /// </summary>
    [DataMember(Name="team_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "team_url")]
    public string TeamUrl { get; set; }

    /// <summary>
    /// The title of the discussion.
    /// </summary>
    /// <value>The title of the discussion.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

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
      sb.Append("class TeamDiscussion {\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  BodyHtml: ").Append(BodyHtml).Append("\n");
      sb.Append("  BodyVersion: ").Append(BodyVersion).Append("\n");
      sb.Append("  CommentsCount: ").Append(CommentsCount).Append("\n");
      sb.Append("  CommentsUrl: ").Append(CommentsUrl).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  LastEditedAt: ").Append(LastEditedAt).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  Pinned: ").Append(Pinned).Append("\n");
      sb.Append("  Private: ").Append(Private).Append("\n");
      sb.Append("  TeamUrl: ").Append(TeamUrl).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
