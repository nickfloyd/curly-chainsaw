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
  public class PullsCreateReviewCommentRequest {
    /// <summary>
    /// The text of the review comment.
    /// </summary>
    /// <value>The text of the review comment.</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// The SHA of the commit needing a comment. Not using the latest commit SHA may render your comment outdated if a subsequent commit modifies the line you specify as the `position`.
    /// </summary>
    /// <value>The SHA of the commit needing a comment. Not using the latest commit SHA may render your comment outdated if a subsequent commit modifies the line you specify as the `position`.</value>
    [DataMember(Name="commit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_id")]
    public string CommitId { get; set; }

    /// <summary>
    /// The relative path to the file that necessitates a comment.
    /// </summary>
    /// <value>The relative path to the file that necessitates a comment.</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// **This parameter is deprecated. Use `line` instead**. The position in the diff where you want to add a review comment. Note this value is not the same as the line number in the file. For help finding the position value, read the note above.
    /// </summary>
    /// <value>**This parameter is deprecated. Use `line` instead**. The position in the diff where you want to add a review comment. Note this value is not the same as the line number in the file. For help finding the position value, read the note above.</value>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    [Obsolete]
    public int? Position { get; set; }

    /// <summary>
    /// In a split diff view, the side of the diff that the pull request's changes appear on. Can be `LEFT` or `RIGHT`. Use `LEFT` for deletions that appear in red. Use `RIGHT` for additions that appear in green or unchanged lines that appear in white and are shown for context. For a multi-line comment, side represents whether the last line of the comment range is a deletion or addition. For more information, see \"[Diff view options](https://docs.github.com/en/articles/about-comparing-branches-in-pull-requests#diff-view-options)\" in the GitHub Help documentation.
    /// </summary>
    /// <value>In a split diff view, the side of the diff that the pull request's changes appear on. Can be `LEFT` or `RIGHT`. Use `LEFT` for deletions that appear in red. Use `RIGHT` for additions that appear in green or unchanged lines that appear in white and are shown for context. For a multi-line comment, side represents whether the last line of the comment range is a deletion or addition. For more information, see \"[Diff view options](https://docs.github.com/en/articles/about-comparing-branches-in-pull-requests#diff-view-options)\" in the GitHub Help documentation.</value>
    [DataMember(Name="side", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "side")]
    public string Side { get; set; }

    /// <summary>
    /// The line of the blob in the pull request diff that the comment applies to. For a multi-line comment, the last line of the range that your comment applies to.
    /// </summary>
    /// <value>The line of the blob in the pull request diff that the comment applies to. For a multi-line comment, the last line of the range that your comment applies to.</value>
    [DataMember(Name="line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line")]
    public int? Line { get; set; }

    /// <summary>
    /// **Required when using multi-line comments unless using `in_reply_to`**. The `start_line` is the first line in the pull request diff that your multi-line comment applies to. To learn more about multi-line comments, see \"[Commenting on a pull request](https://docs.github.com/en/articles/commenting-on-a-pull-request#adding-line-comments-to-a-pull-request)\" in the GitHub Help documentation.
    /// </summary>
    /// <value>**Required when using multi-line comments unless using `in_reply_to`**. The `start_line` is the first line in the pull request diff that your multi-line comment applies to. To learn more about multi-line comments, see \"[Commenting on a pull request](https://docs.github.com/en/articles/commenting-on-a-pull-request#adding-line-comments-to-a-pull-request)\" in the GitHub Help documentation.</value>
    [DataMember(Name="start_line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_line")]
    public int? StartLine { get; set; }

    /// <summary>
    /// **Required when using multi-line comments unless using `in_reply_to`**. The `start_side` is the starting side of the diff that the comment applies to. Can be `LEFT` or `RIGHT`. To learn more about multi-line comments, see \"[Commenting on a pull request](https://docs.github.com/en/articles/commenting-on-a-pull-request#adding-line-comments-to-a-pull-request)\" in the GitHub Help documentation. See `side` in this table for additional context.
    /// </summary>
    /// <value>**Required when using multi-line comments unless using `in_reply_to`**. The `start_side` is the starting side of the diff that the comment applies to. Can be `LEFT` or `RIGHT`. To learn more about multi-line comments, see \"[Commenting on a pull request](https://docs.github.com/en/articles/commenting-on-a-pull-request#adding-line-comments-to-a-pull-request)\" in the GitHub Help documentation. See `side` in this table for additional context.</value>
    [DataMember(Name="start_side", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_side")]
    public string StartSide { get; set; }

    /// <summary>
    /// The ID of the review comment to reply to. To find the ID of a review comment with [\"List review comments on a pull request\"](#list-review-comments-on-a-pull-request). When specified, all parameters other than `body` in the request body are ignored.
    /// </summary>
    /// <value>The ID of the review comment to reply to. To find the ID of a review comment with [\"List review comments on a pull request\"](#list-review-comments-on-a-pull-request). When specified, all parameters other than `body` in the request body are ignored.</value>
    [DataMember(Name="in_reply_to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "in_reply_to")]
    public int? InReplyTo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PullsCreateReviewCommentRequest {\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  CommitId: ").Append(CommitId).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  Side: ").Append(Side).Append("\n");
      sb.Append("  Line: ").Append(Line).Append("\n");
      sb.Append("  StartLine: ").Append(StartLine).Append("\n");
      sb.Append("  StartSide: ").Append(StartSide).Append("\n");
      sb.Append("  InReplyTo: ").Append(InReplyTo).Append("\n");
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
