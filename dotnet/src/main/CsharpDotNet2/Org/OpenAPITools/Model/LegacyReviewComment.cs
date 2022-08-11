using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Legacy Review Comment
  /// </summary>
  [DataContract]
  public class LegacyReviewComment {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets PullRequestReviewId
    /// </summary>
    [DataMember(Name="pull_request_review_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pull_request_review_id")]
    public int? PullRequestReviewId { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
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
    /// Gets or Sets DiffHunk
    /// </summary>
    [DataMember(Name="diff_hunk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "diff_hunk")]
    public string DiffHunk { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets Position
    /// </summary>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public int? Position { get; set; }

    /// <summary>
    /// Gets or Sets OriginalPosition
    /// </summary>
    [DataMember(Name="original_position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_position")]
    public int? OriginalPosition { get; set; }

    /// <summary>
    /// Gets or Sets CommitId
    /// </summary>
    [DataMember(Name="commit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_id")]
    public string CommitId { get; set; }

    /// <summary>
    /// Gets or Sets OriginalCommitId
    /// </summary>
    [DataMember(Name="original_commit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_commit_id")]
    public string OriginalCommitId { get; set; }

    /// <summary>
    /// Gets or Sets InReplyToId
    /// </summary>
    [DataMember(Name="in_reply_to_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "in_reply_to_id")]
    public int? InReplyToId { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUser User { get; set; }

    /// <summary>
    /// Gets or Sets Body
    /// </summary>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

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
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets PullRequestUrl
    /// </summary>
    [DataMember(Name="pull_request_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pull_request_url")]
    public string PullRequestUrl { get; set; }

    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    /// <value>How the author is associated with the repository.</value>
    [DataMember(Name="author_association", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author_association")]
    public string AuthorAssociation { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public LegacyReviewCommentLinks Links { get; set; }

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
    /// Gets or Sets Reactions
    /// </summary>
    [DataMember(Name="reactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reactions")]
    public ReactionRollup Reactions { get; set; }

    /// <summary>
    /// The side of the first line of the range for a multi-line comment.
    /// </summary>
    /// <value>The side of the first line of the range for a multi-line comment.</value>
    [DataMember(Name="side", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "side")]
    public string Side { get; set; }

    /// <summary>
    /// The side of the first line of the range for a multi-line comment.
    /// </summary>
    /// <value>The side of the first line of the range for a multi-line comment.</value>
    [DataMember(Name="start_side", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_side")]
    public string StartSide { get; set; }

    /// <summary>
    /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
    /// </summary>
    /// <value>The line of the blob to which the comment applies. The last line of the range for a multi-line comment</value>
    [DataMember(Name="line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line")]
    public int? Line { get; set; }

    /// <summary>
    /// The original line of the blob to which the comment applies. The last line of the range for a multi-line comment
    /// </summary>
    /// <value>The original line of the blob to which the comment applies. The last line of the range for a multi-line comment</value>
    [DataMember(Name="original_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_line")]
    public int? OriginalLine { get; set; }

    /// <summary>
    /// The first line of the range for a multi-line comment.
    /// </summary>
    /// <value>The first line of the range for a multi-line comment.</value>
    [DataMember(Name="start_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_line")]
    public int? StartLine { get; set; }

    /// <summary>
    /// The original first line of the range for a multi-line comment.
    /// </summary>
    /// <value>The original first line of the range for a multi-line comment.</value>
    [DataMember(Name="original_start_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_start_line")]
    public int? OriginalStartLine { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LegacyReviewComment {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  PullRequestReviewId: ").Append(PullRequestReviewId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  DiffHunk: ").Append(DiffHunk).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  OriginalPosition: ").Append(OriginalPosition).Append("\n");
      sb.Append("  CommitId: ").Append(CommitId).Append("\n");
      sb.Append("  OriginalCommitId: ").Append(OriginalCommitId).Append("\n");
      sb.Append("  InReplyToId: ").Append(InReplyToId).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  PullRequestUrl: ").Append(PullRequestUrl).Append("\n");
      sb.Append("  AuthorAssociation: ").Append(AuthorAssociation).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  BodyText: ").Append(BodyText).Append("\n");
      sb.Append("  BodyHtml: ").Append(BodyHtml).Append("\n");
      sb.Append("  Reactions: ").Append(Reactions).Append("\n");
      sb.Append("  Side: ").Append(Side).Append("\n");
      sb.Append("  StartSide: ").Append(StartSide).Append("\n");
      sb.Append("  Line: ").Append(Line).Append("\n");
      sb.Append("  OriginalLine: ").Append(OriginalLine).Append("\n");
      sb.Append("  StartLine: ").Append(StartLine).Append("\n");
      sb.Append("  OriginalStartLine: ").Append(OriginalStartLine).Append("\n");
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
