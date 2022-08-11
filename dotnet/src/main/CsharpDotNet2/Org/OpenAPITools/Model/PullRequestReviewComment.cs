using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Pull Request Review Comments are comments on a portion of the Pull Request&#39;s diff.
  /// </summary>
  [DataContract]
  public class PullRequestReviewComment {
    /// <summary>
    /// URL for the pull request review comment
    /// </summary>
    /// <value>URL for the pull request review comment</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// The ID of the pull request review to which the comment belongs.
    /// </summary>
    /// <value>The ID of the pull request review to which the comment belongs.</value>
    [DataMember(Name="pull_request_review_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pull_request_review_id")]
    public int? PullRequestReviewId { get; set; }

    /// <summary>
    /// The ID of the pull request review comment.
    /// </summary>
    /// <value>The ID of the pull request review comment.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The node ID of the pull request review comment.
    /// </summary>
    /// <value>The node ID of the pull request review comment.</value>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// The diff of the line that the comment refers to.
    /// </summary>
    /// <value>The diff of the line that the comment refers to.</value>
    [DataMember(Name="diff_hunk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "diff_hunk")]
    public string DiffHunk { get; set; }

    /// <summary>
    /// The relative path of the file to which the comment applies.
    /// </summary>
    /// <value>The relative path of the file to which the comment applies.</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// The line index in the diff to which the comment applies. This field is deprecated; use `line` instead.
    /// </summary>
    /// <value>The line index in the diff to which the comment applies. This field is deprecated; use `line` instead.</value>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public int? Position { get; set; }

    /// <summary>
    /// The index of the original line in the diff to which the comment applies. This field is deprecated; use `original_line` instead.
    /// </summary>
    /// <value>The index of the original line in the diff to which the comment applies. This field is deprecated; use `original_line` instead.</value>
    [DataMember(Name="original_position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_position")]
    public int? OriginalPosition { get; set; }

    /// <summary>
    /// The SHA of the commit to which the comment applies.
    /// </summary>
    /// <value>The SHA of the commit to which the comment applies.</value>
    [DataMember(Name="commit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_id")]
    public string CommitId { get; set; }

    /// <summary>
    /// The SHA of the original commit to which the comment applies.
    /// </summary>
    /// <value>The SHA of the original commit to which the comment applies.</value>
    [DataMember(Name="original_commit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_commit_id")]
    public string OriginalCommitId { get; set; }

    /// <summary>
    /// The comment ID to reply to.
    /// </summary>
    /// <value>The comment ID to reply to.</value>
    [DataMember(Name="in_reply_to_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "in_reply_to_id")]
    public int? InReplyToId { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUser1 User { get; set; }

    /// <summary>
    /// The text of the comment.
    /// </summary>
    /// <value>The text of the comment.</value>
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
    /// HTML URL for the pull request review comment.
    /// </summary>
    /// <value>HTML URL for the pull request review comment.</value>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// URL for the pull request that the review comment belongs to.
    /// </summary>
    /// <value>URL for the pull request that the review comment belongs to.</value>
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
    public PullRequestReviewCommentLinks Links { get; set; }

    /// <summary>
    /// The first line of the range for a multi-line comment.
    /// </summary>
    /// <value>The first line of the range for a multi-line comment.</value>
    [DataMember(Name="start_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_line")]
    public int? StartLine { get; set; }

    /// <summary>
    /// The first line of the range for a multi-line comment.
    /// </summary>
    /// <value>The first line of the range for a multi-line comment.</value>
    [DataMember(Name="original_start_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_start_line")]
    public int? OriginalStartLine { get; set; }

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
    /// The line of the blob to which the comment applies. The last line of the range for a multi-line comment
    /// </summary>
    /// <value>The line of the blob to which the comment applies. The last line of the range for a multi-line comment</value>
    [DataMember(Name="original_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "original_line")]
    public int? OriginalLine { get; set; }

    /// <summary>
    /// The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment
    /// </summary>
    /// <value>The side of the diff to which the comment applies. The side of the last line of the range for a multi-line comment</value>
    [DataMember(Name="side", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "side")]
    public string Side { get; set; }

    /// <summary>
    /// Gets or Sets Reactions
    /// </summary>
    [DataMember(Name="reactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reactions")]
    public ReactionRollup Reactions { get; set; }

    /// <summary>
    /// Gets or Sets BodyHtml
    /// </summary>
    [DataMember(Name="body_html", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body_html")]
    public string BodyHtml { get; set; }

    /// <summary>
    /// Gets or Sets BodyText
    /// </summary>
    [DataMember(Name="body_text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body_text")]
    public string BodyText { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PullRequestReviewComment {\n");
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
      sb.Append("  StartLine: ").Append(StartLine).Append("\n");
      sb.Append("  OriginalStartLine: ").Append(OriginalStartLine).Append("\n");
      sb.Append("  StartSide: ").Append(StartSide).Append("\n");
      sb.Append("  Line: ").Append(Line).Append("\n");
      sb.Append("  OriginalLine: ").Append(OriginalLine).Append("\n");
      sb.Append("  Side: ").Append(Side).Append("\n");
      sb.Append("  Reactions: ").Append(Reactions).Append("\n");
      sb.Append("  BodyHtml: ").Append(BodyHtml).Append("\n");
      sb.Append("  BodyText: ").Append(BodyText).Append("\n");
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
