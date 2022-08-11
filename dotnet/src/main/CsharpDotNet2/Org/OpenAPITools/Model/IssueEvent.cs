using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Issue Event
  /// </summary>
  [DataContract]
  public class IssueEvent {
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
    public SimpleUser Actor { get; set; }

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
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Issue
    /// </summary>
    [DataMember(Name="issue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issue")]
    public Issue1 Issue { get; set; }

    /// <summary>
    /// Gets or Sets Label
    /// </summary>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public IssueEventLabel Label { get; set; }

    /// <summary>
    /// Gets or Sets Assignee
    /// </summary>
    [DataMember(Name="assignee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignee")]
    public SimpleUser Assignee { get; set; }

    /// <summary>
    /// Gets or Sets Assigner
    /// </summary>
    [DataMember(Name="assigner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assigner")]
    public SimpleUser Assigner { get; set; }

    /// <summary>
    /// Gets or Sets ReviewRequester
    /// </summary>
    [DataMember(Name="review_requester", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "review_requester")]
    public SimpleUser ReviewRequester { get; set; }

    /// <summary>
    /// Gets or Sets RequestedReviewer
    /// </summary>
    [DataMember(Name="requested_reviewer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requested_reviewer")]
    public SimpleUser RequestedReviewer { get; set; }

    /// <summary>
    /// Gets or Sets RequestedTeam
    /// </summary>
    [DataMember(Name="requested_team", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requested_team")]
    public Team RequestedTeam { get; set; }

    /// <summary>
    /// Gets or Sets DismissedReview
    /// </summary>
    [DataMember(Name="dismissed_review", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismissed_review")]
    public IssueEventDismissedReview DismissedReview { get; set; }

    /// <summary>
    /// Gets or Sets Milestone
    /// </summary>
    [DataMember(Name="milestone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "milestone")]
    public IssueEventMilestone Milestone { get; set; }

    /// <summary>
    /// Gets or Sets ProjectCard
    /// </summary>
    [DataMember(Name="project_card", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project_card")]
    public IssueEventProjectCard ProjectCard { get; set; }

    /// <summary>
    /// Gets or Sets Rename
    /// </summary>
    [DataMember(Name="rename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rename")]
    public IssueEventRename Rename { get; set; }

    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    /// <value>How the author is associated with the repository.</value>
    [DataMember(Name="author_association", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author_association")]
    public string AuthorAssociation { get; set; }

    /// <summary>
    /// Gets or Sets LockReason
    /// </summary>
    [DataMember(Name="lock_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lock_reason")]
    public string LockReason { get; set; }

    /// <summary>
    /// Gets or Sets PerformedViaGithubApp
    /// </summary>
    [DataMember(Name="performed_via_github_app", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "performed_via_github_app")]
    public GitHubApp1 PerformedViaGithubApp { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueEvent {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Actor: ").Append(Actor).Append("\n");
      sb.Append("  Event: ").Append(Event).Append("\n");
      sb.Append("  CommitId: ").Append(CommitId).Append("\n");
      sb.Append("  CommitUrl: ").Append(CommitUrl).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Issue: ").Append(Issue).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  Assignee: ").Append(Assignee).Append("\n");
      sb.Append("  Assigner: ").Append(Assigner).Append("\n");
      sb.Append("  ReviewRequester: ").Append(ReviewRequester).Append("\n");
      sb.Append("  RequestedReviewer: ").Append(RequestedReviewer).Append("\n");
      sb.Append("  RequestedTeam: ").Append(RequestedTeam).Append("\n");
      sb.Append("  DismissedReview: ").Append(DismissedReview).Append("\n");
      sb.Append("  Milestone: ").Append(Milestone).Append("\n");
      sb.Append("  ProjectCard: ").Append(ProjectCard).Append("\n");
      sb.Append("  Rename: ").Append(Rename).Append("\n");
      sb.Append("  AuthorAssociation: ").Append(AuthorAssociation).Append("\n");
      sb.Append("  LockReason: ").Append(LockReason).Append("\n");
      sb.Append("  PerformedViaGithubApp: ").Append(PerformedViaGithubApp).Append("\n");
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
