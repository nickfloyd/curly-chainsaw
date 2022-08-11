using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Pull Request Simple
  /// </summary>
  [DataContract]
  public class PullRequestSimple {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

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
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets DiffUrl
    /// </summary>
    [DataMember(Name="diff_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "diff_url")]
    public string DiffUrl { get; set; }

    /// <summary>
    /// Gets or Sets PatchUrl
    /// </summary>
    [DataMember(Name="patch_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "patch_url")]
    public string PatchUrl { get; set; }

    /// <summary>
    /// Gets or Sets IssueUrl
    /// </summary>
    [DataMember(Name="issue_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issue_url")]
    public string IssueUrl { get; set; }

    /// <summary>
    /// Gets or Sets CommitsUrl
    /// </summary>
    [DataMember(Name="commits_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commits_url")]
    public string CommitsUrl { get; set; }

    /// <summary>
    /// Gets or Sets ReviewCommentsUrl
    /// </summary>
    [DataMember(Name="review_comments_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "review_comments_url")]
    public string ReviewCommentsUrl { get; set; }

    /// <summary>
    /// Gets or Sets ReviewCommentUrl
    /// </summary>
    [DataMember(Name="review_comment_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "review_comment_url")]
    public string ReviewCommentUrl { get; set; }

    /// <summary>
    /// Gets or Sets CommentsUrl
    /// </summary>
    [DataMember(Name="comments_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments_url")]
    public string CommentsUrl { get; set; }

    /// <summary>
    /// Gets or Sets StatusesUrl
    /// </summary>
    [DataMember(Name="statuses_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statuses_url")]
    public string StatusesUrl { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public int? Number { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets Locked
    /// </summary>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public bool? Locked { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

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
    /// Gets or Sets Labels
    /// </summary>
    [DataMember(Name="labels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels")]
    public List<PullRequestSimpleLabelsInner> Labels { get; set; }

    /// <summary>
    /// Gets or Sets Milestone
    /// </summary>
    [DataMember(Name="milestone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "milestone")]
    public Milestone Milestone { get; set; }

    /// <summary>
    /// Gets or Sets ActiveLockReason
    /// </summary>
    [DataMember(Name="active_lock_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active_lock_reason")]
    public string ActiveLockReason { get; set; }

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
    /// Gets or Sets ClosedAt
    /// </summary>
    [DataMember(Name="closed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closed_at")]
    public DateTime? ClosedAt { get; set; }

    /// <summary>
    /// Gets or Sets MergedAt
    /// </summary>
    [DataMember(Name="merged_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merged_at")]
    public DateTime? MergedAt { get; set; }

    /// <summary>
    /// Gets or Sets MergeCommitSha
    /// </summary>
    [DataMember(Name="merge_commit_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merge_commit_sha")]
    public string MergeCommitSha { get; set; }

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
    /// Gets or Sets RequestedReviewers
    /// </summary>
    [DataMember(Name="requested_reviewers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requested_reviewers")]
    public List<SimpleUser1> RequestedReviewers { get; set; }

    /// <summary>
    /// Gets or Sets RequestedTeams
    /// </summary>
    [DataMember(Name="requested_teams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requested_teams")]
    public List<Team> RequestedTeams { get; set; }

    /// <summary>
    /// Gets or Sets Head
    /// </summary>
    [DataMember(Name="head", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head")]
    public PullRequestSimpleHead Head { get; set; }

    /// <summary>
    /// Gets or Sets Base
    /// </summary>
    [DataMember(Name="base", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base")]
    public PullRequestSimpleHead Base { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="_links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_links")]
    public PullRequestSimpleLinks Links { get; set; }

    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    /// <value>How the author is associated with the repository.</value>
    [DataMember(Name="author_association", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author_association")]
    public string AuthorAssociation { get; set; }

    /// <summary>
    /// Gets or Sets AutoMerge
    /// </summary>
    [DataMember(Name="auto_merge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auto_merge")]
    public AutoMerge AutoMerge { get; set; }

    /// <summary>
    /// Indicates whether or not the pull request is a draft.
    /// </summary>
    /// <value>Indicates whether or not the pull request is a draft.</value>
    [DataMember(Name="draft", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "draft")]
    public bool? Draft { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PullRequestSimple {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  DiffUrl: ").Append(DiffUrl).Append("\n");
      sb.Append("  PatchUrl: ").Append(PatchUrl).Append("\n");
      sb.Append("  IssueUrl: ").Append(IssueUrl).Append("\n");
      sb.Append("  CommitsUrl: ").Append(CommitsUrl).Append("\n");
      sb.Append("  ReviewCommentsUrl: ").Append(ReviewCommentsUrl).Append("\n");
      sb.Append("  ReviewCommentUrl: ").Append(ReviewCommentUrl).Append("\n");
      sb.Append("  CommentsUrl: ").Append(CommentsUrl).Append("\n");
      sb.Append("  StatusesUrl: ").Append(StatusesUrl).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Labels: ").Append(Labels).Append("\n");
      sb.Append("  Milestone: ").Append(Milestone).Append("\n");
      sb.Append("  ActiveLockReason: ").Append(ActiveLockReason).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  ClosedAt: ").Append(ClosedAt).Append("\n");
      sb.Append("  MergedAt: ").Append(MergedAt).Append("\n");
      sb.Append("  MergeCommitSha: ").Append(MergeCommitSha).Append("\n");
      sb.Append("  Assignee: ").Append(Assignee).Append("\n");
      sb.Append("  Assignees: ").Append(Assignees).Append("\n");
      sb.Append("  RequestedReviewers: ").Append(RequestedReviewers).Append("\n");
      sb.Append("  RequestedTeams: ").Append(RequestedTeams).Append("\n");
      sb.Append("  Head: ").Append(Head).Append("\n");
      sb.Append("  Base: ").Append(Base).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  AuthorAssociation: ").Append(AuthorAssociation).Append("\n");
      sb.Append("  AutoMerge: ").Append(AutoMerge).Append("\n");
      sb.Append("  Draft: ").Append(Draft).Append("\n");
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
