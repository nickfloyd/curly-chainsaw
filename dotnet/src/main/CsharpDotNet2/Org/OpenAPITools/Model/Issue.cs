using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
  /// </summary>
  [DataContract]
  public class Issue {
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
    /// URL for the issue
    /// </summary>
    /// <value>URL for the issue</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryUrl
    /// </summary>
    [DataMember(Name="repository_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_url")]
    public string RepositoryUrl { get; set; }

    /// <summary>
    /// Gets or Sets LabelsUrl
    /// </summary>
    [DataMember(Name="labels_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels_url")]
    public string LabelsUrl { get; set; }

    /// <summary>
    /// Gets or Sets CommentsUrl
    /// </summary>
    [DataMember(Name="comments_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments_url")]
    public string CommentsUrl { get; set; }

    /// <summary>
    /// Gets or Sets EventsUrl
    /// </summary>
    [DataMember(Name="events_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events_url")]
    public string EventsUrl { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Number uniquely identifying the issue within its repository
    /// </summary>
    /// <value>Number uniquely identifying the issue within its repository</value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public int? Number { get; set; }

    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    /// <value>State of the issue; either 'open' or 'closed'</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The reason for the current state
    /// </summary>
    /// <value>The reason for the current state</value>
    [DataMember(Name="state_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state_reason")]
    public string StateReason { get; set; }

    /// <summary>
    /// Title of the issue
    /// </summary>
    /// <value>Title of the issue</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Contents of the issue
    /// </summary>
    /// <value>Contents of the issue</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUser User { get; set; }

    /// <summary>
    /// Labels to associate with this issue; pass one or more label names to replace the set of labels on this issue; send an empty array to clear all labels from the issue; note that the labels are silently dropped for users without push access to the repository
    /// </summary>
    /// <value>Labels to associate with this issue; pass one or more label names to replace the set of labels on this issue; send an empty array to clear all labels from the issue; note that the labels are silently dropped for users without push access to the repository</value>
    [DataMember(Name="labels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels")]
    public List<IssueLabelsInner> Labels { get; set; }

    /// <summary>
    /// Gets or Sets Assignee
    /// </summary>
    [DataMember(Name="assignee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignee")]
    public SimpleUser Assignee { get; set; }

    /// <summary>
    /// Gets or Sets Assignees
    /// </summary>
    [DataMember(Name="assignees", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignees")]
    public List<SimpleUser1> Assignees { get; set; }

    /// <summary>
    /// Gets or Sets Milestone
    /// </summary>
    [DataMember(Name="milestone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "milestone")]
    public Milestone Milestone { get; set; }

    /// <summary>
    /// Gets or Sets Locked
    /// </summary>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// Gets or Sets ActiveLockReason
    /// </summary>
    [DataMember(Name="active_lock_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active_lock_reason")]
    public string ActiveLockReason { get; set; }

    /// <summary>
    /// Gets or Sets Comments
    /// </summary>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public int? Comments { get; set; }

    /// <summary>
    /// Gets or Sets PullRequest
    /// </summary>
    [DataMember(Name="pull_request", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pull_request")]
    public IssuePullRequest PullRequest { get; set; }

    /// <summary>
    /// Gets or Sets ClosedAt
    /// </summary>
    [DataMember(Name="closed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closed_at")]
    public DateTime? ClosedAt { get; set; }

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
    /// Gets or Sets Draft
    /// </summary>
    [DataMember(Name="draft", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "draft")]
    public bool? Draft { get; set; }

    /// <summary>
    /// Gets or Sets ClosedBy
    /// </summary>
    [DataMember(Name="closed_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closed_by")]
    public SimpleUser ClosedBy { get; set; }

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
    /// Gets or Sets TimelineUrl
    /// </summary>
    [DataMember(Name="timeline_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeline_url")]
    public string TimelineUrl { get; set; }

    /// <summary>
    /// Gets or Sets Repository
    /// </summary>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public Repository Repository { get; set; }

    /// <summary>
    /// Gets or Sets PerformedViaGithubApp
    /// </summary>
    [DataMember(Name="performed_via_github_app", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "performed_via_github_app")]
    public GitHubApp1 PerformedViaGithubApp { get; set; }

    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    /// <value>How the author is associated with the repository.</value>
    [DataMember(Name="author_association", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author_association")]
    public string AuthorAssociation { get; set; }

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
      sb.Append("class Issue {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  RepositoryUrl: ").Append(RepositoryUrl).Append("\n");
      sb.Append("  LabelsUrl: ").Append(LabelsUrl).Append("\n");
      sb.Append("  CommentsUrl: ").Append(CommentsUrl).Append("\n");
      sb.Append("  EventsUrl: ").Append(EventsUrl).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  StateReason: ").Append(StateReason).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Labels: ").Append(Labels).Append("\n");
      sb.Append("  Assignee: ").Append(Assignee).Append("\n");
      sb.Append("  Assignees: ").Append(Assignees).Append("\n");
      sb.Append("  Milestone: ").Append(Milestone).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  ActiveLockReason: ").Append(ActiveLockReason).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  PullRequest: ").Append(PullRequest).Append("\n");
      sb.Append("  ClosedAt: ").Append(ClosedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Draft: ").Append(Draft).Append("\n");
      sb.Append("  ClosedBy: ").Append(ClosedBy).Append("\n");
      sb.Append("  BodyHtml: ").Append(BodyHtml).Append("\n");
      sb.Append("  BodyText: ").Append(BodyText).Append("\n");
      sb.Append("  TimelineUrl: ").Append(TimelineUrl).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      sb.Append("  PerformedViaGithubApp: ").Append(PerformedViaGithubApp).Append("\n");
      sb.Append("  AuthorAssociation: ").Append(AuthorAssociation).Append("\n");
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
