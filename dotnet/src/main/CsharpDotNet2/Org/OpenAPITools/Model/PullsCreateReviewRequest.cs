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
  public class PullsCreateReviewRequest {
    /// <summary>
    /// The SHA of the commit that needs a review. Not using the latest commit SHA may render your review comment outdated if a subsequent commit modifies the line you specify as the `position`. Defaults to the most recent commit in the pull request when you do not specify a value.
    /// </summary>
    /// <value>The SHA of the commit that needs a review. Not using the latest commit SHA may render your review comment outdated if a subsequent commit modifies the line you specify as the `position`. Defaults to the most recent commit in the pull request when you do not specify a value.</value>
    [DataMember(Name="commit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_id")]
    public string CommitId { get; set; }

    /// <summary>
    /// **Required** when using `REQUEST_CHANGES` or `COMMENT` for the `event` parameter. The body text of the pull request review.
    /// </summary>
    /// <value>**Required** when using `REQUEST_CHANGES` or `COMMENT` for the `event` parameter. The body text of the pull request review.</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. By leaving this blank, you set the review action state to `PENDING`, which means you will need to [submit the pull request review](https://docs.github.com/rest/reference/pulls#submit-a-review-for-a-pull-request) when you are ready.
    /// </summary>
    /// <value>The review action you want to perform. The review actions include: `APPROVE`, `REQUEST_CHANGES`, or `COMMENT`. By leaving this blank, you set the review action state to `PENDING`, which means you will need to [submit the pull request review](https://docs.github.com/rest/reference/pulls#submit-a-review-for-a-pull-request) when you are ready.</value>
    [DataMember(Name="event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event")]
    public string Event { get; set; }

    /// <summary>
    /// Use the following table to specify the location, destination, and contents of the draft review comment.
    /// </summary>
    /// <value>Use the following table to specify the location, destination, and contents of the draft review comment.</value>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public List<PullsCreateReviewRequestCommentsInner> Comments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PullsCreateReviewRequest {\n");
      sb.Append("  CommitId: ").Append(CommitId).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Event: ").Append(Event).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
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
