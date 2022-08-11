using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Timeline Reviewed Event
  /// </summary>
  [DataContract]
  public class TimelineReviewedEvent {
    /// <summary>
    /// Gets or Sets Event
    /// </summary>
    [DataMember(Name="event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event")]
    public string Event { get; set; }

    /// <summary>
    /// Unique identifier of the review
    /// </summary>
    /// <value>Unique identifier of the review</value>
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
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUser1 User { get; set; }

    /// <summary>
    /// The text of the review.
    /// </summary>
    /// <value>The text of the review.</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

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
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public TimelineReviewedEventLinks Links { get; set; }

    /// <summary>
    /// Gets or Sets SubmittedAt
    /// </summary>
    [DataMember(Name="submitted_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "submitted_at")]
    public DateTime? SubmittedAt { get; set; }

    /// <summary>
    /// A commit SHA for the review.
    /// </summary>
    /// <value>A commit SHA for the review.</value>
    [DataMember(Name="commit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_id")]
    public string CommitId { get; set; }

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
    /// How the author is associated with the repository.
    /// </summary>
    /// <value>How the author is associated with the repository.</value>
    [DataMember(Name="author_association", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author_association")]
    public string AuthorAssociation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TimelineReviewedEvent {\n");
      sb.Append("  Event: ").Append(Event).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  PullRequestUrl: ").Append(PullRequestUrl).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  SubmittedAt: ").Append(SubmittedAt).Append("\n");
      sb.Append("  CommitId: ").Append(CommitId).Append("\n");
      sb.Append("  BodyHtml: ").Append(BodyHtml).Append("\n");
      sb.Append("  BodyText: ").Append(BodyText).Append("\n");
      sb.Append("  AuthorAssociation: ").Append(AuthorAssociation).Append("\n");
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
