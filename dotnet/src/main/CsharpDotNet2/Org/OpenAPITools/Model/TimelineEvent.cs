using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Timeline Event
  /// </summary>
  [DataContract]
  public class TimelineEvent {
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
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Actor
    /// </summary>
    [DataMember(Name="actor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actor")]
    public SimpleUser1 Actor { get; set; }

    /// <summary>
    /// Gets or Sets Event
    /// </summary>
    [DataMember(Name="event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event")]
    public string Event { get; set; }

    /// <summary>
    /// Gets or Sets CommitId
    /// </summary>
    [DataMember(Name="commit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_id")]
    public string CommitId { get; set; }

    /// <summary>
    /// Gets or Sets CommitUrl
    /// </summary>
    [DataMember(Name="commit_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_url")]
    public string CommitUrl { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets PerformedViaGithubApp
    /// </summary>
    [DataMember(Name="performed_via_github_app", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "performed_via_github_app")]
    public GitHubApp1 PerformedViaGithubApp { get; set; }

    /// <summary>
    /// Gets or Sets Label
    /// </summary>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public LabeledIssueEventLabel Label { get; set; }

    /// <summary>
    /// Gets or Sets Milestone
    /// </summary>
    [DataMember(Name="milestone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "milestone")]
    public MilestonedIssueEventMilestone Milestone { get; set; }

    /// <summary>
    /// Gets or Sets Rename
    /// </summary>
    [DataMember(Name="rename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rename")]
    public RenamedIssueEventRename Rename { get; set; }

    /// <summary>
    /// Gets or Sets ReviewRequester
    /// </summary>
    [DataMember(Name="review_requester", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "review_requester")]
    public SimpleUser1 ReviewRequester { get; set; }

    /// <summary>
    /// Gets or Sets RequestedTeam
    /// </summary>
    [DataMember(Name="requested_team", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requested_team")]
    public Team RequestedTeam { get; set; }

    /// <summary>
    /// Gets or Sets RequestedReviewer
    /// </summary>
    [DataMember(Name="requested_reviewer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requested_reviewer")]
    public SimpleUser1 RequestedReviewer { get; set; }

    /// <summary>
    /// Gets or Sets DismissedReview
    /// </summary>
    [DataMember(Name="dismissed_review", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismissed_review")]
    public ReviewDismissedIssueEventDismissedReview DismissedReview { get; set; }

    /// <summary>
    /// Gets or Sets LockReason
    /// </summary>
    [DataMember(Name="lock_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lock_reason")]
    public string LockReason { get; set; }

    /// <summary>
    /// Gets or Sets ProjectCard
    /// </summary>
    [DataMember(Name="project_card", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project_card")]
    public AddedToProjectIssueEventProjectCard ProjectCard { get; set; }

    /// <summary>
    /// The text of the review.
    /// </summary>
    /// <value>The text of the review.</value>
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
    public SimpleUser1 User { get; set; }

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
    /// Gets or Sets Reactions
    /// </summary>
    [DataMember(Name="reactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reactions")]
    public ReactionRollup Reactions { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public TimelineCrossReferencedEventSource Source { get; set; }

    /// <summary>
    /// SHA for the commit
    /// </summary>
    /// <value>SHA for the commit</value>
    [DataMember(Name="sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha")]
    public string Sha { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public GitCommitAuthor Author { get; set; }

    /// <summary>
    /// Gets or Sets Committer
    /// </summary>
    [DataMember(Name="committer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "committer")]
    public GitCommitAuthor Committer { get; set; }

    /// <summary>
    /// Message describing the purpose of the commit
    /// </summary>
    /// <value>Message describing the purpose of the commit</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Tree
    /// </summary>
    [DataMember(Name="tree", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tree")]
    public GitCommitTree Tree { get; set; }

    /// <summary>
    /// Gets or Sets Parents
    /// </summary>
    [DataMember(Name="parents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parents")]
    public List<GitCommitParentsInner> Parents { get; set; }

    /// <summary>
    /// Gets or Sets Verification
    /// </summary>
    [DataMember(Name="verification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verification")]
    public GitCommitVerification Verification { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

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
    /// Gets or Sets Comments
    /// </summary>
    [DataMember(Name="comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments")]
    public List<CommitComment> Comments { get; set; }

    /// <summary>
    /// Gets or Sets Assignee
    /// </summary>
    [DataMember(Name="assignee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignee")]
    public SimpleUser1 Assignee { get; set; }

    /// <summary>
    /// Gets or Sets StateReason
    /// </summary>
    [DataMember(Name="state_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state_reason")]
    public string StateReason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TimelineEvent {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Actor: ").Append(Actor).Append("\n");
      sb.Append("  Event: ").Append(Event).Append("\n");
      sb.Append("  CommitId: ").Append(CommitId).Append("\n");
      sb.Append("  CommitUrl: ").Append(CommitUrl).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  PerformedViaGithubApp: ").Append(PerformedViaGithubApp).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  Milestone: ").Append(Milestone).Append("\n");
      sb.Append("  Rename: ").Append(Rename).Append("\n");
      sb.Append("  ReviewRequester: ").Append(ReviewRequester).Append("\n");
      sb.Append("  RequestedTeam: ").Append(RequestedTeam).Append("\n");
      sb.Append("  RequestedReviewer: ").Append(RequestedReviewer).Append("\n");
      sb.Append("  DismissedReview: ").Append(DismissedReview).Append("\n");
      sb.Append("  LockReason: ").Append(LockReason).Append("\n");
      sb.Append("  ProjectCard: ").Append(ProjectCard).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  BodyText: ").Append(BodyText).Append("\n");
      sb.Append("  BodyHtml: ").Append(BodyHtml).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  IssueUrl: ").Append(IssueUrl).Append("\n");
      sb.Append("  AuthorAssociation: ").Append(AuthorAssociation).Append("\n");
      sb.Append("  Reactions: ").Append(Reactions).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Sha: ").Append(Sha).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Committer: ").Append(Committer).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Tree: ").Append(Tree).Append("\n");
      sb.Append("  Parents: ").Append(Parents).Append("\n");
      sb.Append("  Verification: ").Append(Verification).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  PullRequestUrl: ").Append(PullRequestUrl).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  SubmittedAt: ").Append(SubmittedAt).Append("\n");
      sb.Append("  Comments: ").Append(Comments).Append("\n");
      sb.Append("  Assignee: ").Append(Assignee).Append("\n");
      sb.Append("  StateReason: ").Append(StateReason).Append("\n");
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
