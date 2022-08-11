using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Simple Repository
  /// </summary>
  [DataContract]
  public class SimpleRepository {
    /// <summary>
    /// A unique identifier of the repository.
    /// </summary>
    /// <value>A unique identifier of the repository.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The GraphQL identifier of the repository.
    /// </summary>
    /// <value>The GraphQL identifier of the repository.</value>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// The name of the repository.
    /// </summary>
    /// <value>The name of the repository.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The full, globally unique, name of the repository.
    /// </summary>
    /// <value>The full, globally unique, name of the repository.</value>
    [DataMember(Name="full_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "full_name")]
    public string FullName { get; set; }

    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public SimpleUser1 Owner { get; set; }

    /// <summary>
    /// Whether the repository is private.
    /// </summary>
    /// <value>Whether the repository is private.</value>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? Private { get; set; }

    /// <summary>
    /// The URL to view the repository on GitHub.com.
    /// </summary>
    /// <value>The URL to view the repository on GitHub.com.</value>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// The repository description.
    /// </summary>
    /// <value>The repository description.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Whether the repository is a fork.
    /// </summary>
    /// <value>Whether the repository is a fork.</value>
    [DataMember(Name="fork", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fork")]
    public bool? Fork { get; set; }

    /// <summary>
    /// The URL to get more information about the repository from the GitHub API.
    /// </summary>
    /// <value>The URL to get more information about the repository from the GitHub API.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// A template for the API URL to download the repository as an archive.
    /// </summary>
    /// <value>A template for the API URL to download the repository as an archive.</value>
    [DataMember(Name="archive_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archive_url")]
    public string ArchiveUrl { get; set; }

    /// <summary>
    /// A template for the API URL to list the available assignees for issues in the repository.
    /// </summary>
    /// <value>A template for the API URL to list the available assignees for issues in the repository.</value>
    [DataMember(Name="assignees_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignees_url")]
    public string AssigneesUrl { get; set; }

    /// <summary>
    /// A template for the API URL to create or retrieve a raw Git blob in the repository.
    /// </summary>
    /// <value>A template for the API URL to create or retrieve a raw Git blob in the repository.</value>
    [DataMember(Name="blobs_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blobs_url")]
    public string BlobsUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about branches in the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about branches in the repository.</value>
    [DataMember(Name="branches_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "branches_url")]
    public string BranchesUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about collaborators of the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about collaborators of the repository.</value>
    [DataMember(Name="collaborators_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collaborators_url")]
    public string CollaboratorsUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about comments on the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about comments on the repository.</value>
    [DataMember(Name="comments_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments_url")]
    public string CommentsUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about commits on the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about commits on the repository.</value>
    [DataMember(Name="commits_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commits_url")]
    public string CommitsUrl { get; set; }

    /// <summary>
    /// A template for the API URL to compare two commits or refs.
    /// </summary>
    /// <value>A template for the API URL to compare two commits or refs.</value>
    [DataMember(Name="compare_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "compare_url")]
    public string CompareUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get the contents of the repository.
    /// </summary>
    /// <value>A template for the API URL to get the contents of the repository.</value>
    [DataMember(Name="contents_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contents_url")]
    public string ContentsUrl { get; set; }

    /// <summary>
    /// A template for the API URL to list the contributors to the repository.
    /// </summary>
    /// <value>A template for the API URL to list the contributors to the repository.</value>
    [DataMember(Name="contributors_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contributors_url")]
    public string ContributorsUrl { get; set; }

    /// <summary>
    /// The API URL to list the deployments of the repository.
    /// </summary>
    /// <value>The API URL to list the deployments of the repository.</value>
    [DataMember(Name="deployments_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deployments_url")]
    public string DeploymentsUrl { get; set; }

    /// <summary>
    /// The API URL to list the downloads on the repository.
    /// </summary>
    /// <value>The API URL to list the downloads on the repository.</value>
    [DataMember(Name="downloads_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "downloads_url")]
    public string DownloadsUrl { get; set; }

    /// <summary>
    /// The API URL to list the events of the repository.
    /// </summary>
    /// <value>The API URL to list the events of the repository.</value>
    [DataMember(Name="events_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events_url")]
    public string EventsUrl { get; set; }

    /// <summary>
    /// The API URL to list the forks of the repository.
    /// </summary>
    /// <value>The API URL to list the forks of the repository.</value>
    [DataMember(Name="forks_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forks_url")]
    public string ForksUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about Git commits of the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about Git commits of the repository.</value>
    [DataMember(Name="git_commits_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "git_commits_url")]
    public string GitCommitsUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about Git refs of the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about Git refs of the repository.</value>
    [DataMember(Name="git_refs_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "git_refs_url")]
    public string GitRefsUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about Git tags of the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about Git tags of the repository.</value>
    [DataMember(Name="git_tags_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "git_tags_url")]
    public string GitTagsUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about issue comments on the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about issue comments on the repository.</value>
    [DataMember(Name="issue_comment_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issue_comment_url")]
    public string IssueCommentUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about issue events on the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about issue events on the repository.</value>
    [DataMember(Name="issue_events_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issue_events_url")]
    public string IssueEventsUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about issues on the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about issues on the repository.</value>
    [DataMember(Name="issues_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues_url")]
    public string IssuesUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about deploy keys on the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about deploy keys on the repository.</value>
    [DataMember(Name="keys_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keys_url")]
    public string KeysUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about labels of the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about labels of the repository.</value>
    [DataMember(Name="labels_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels_url")]
    public string LabelsUrl { get; set; }

    /// <summary>
    /// The API URL to get information about the languages of the repository.
    /// </summary>
    /// <value>The API URL to get information about the languages of the repository.</value>
    [DataMember(Name="languages_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "languages_url")]
    public string LanguagesUrl { get; set; }

    /// <summary>
    /// The API URL to merge branches in the repository.
    /// </summary>
    /// <value>The API URL to merge branches in the repository.</value>
    [DataMember(Name="merges_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merges_url")]
    public string MergesUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about milestones of the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about milestones of the repository.</value>
    [DataMember(Name="milestones_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "milestones_url")]
    public string MilestonesUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about notifications on the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about notifications on the repository.</value>
    [DataMember(Name="notifications_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notifications_url")]
    public string NotificationsUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about pull requests on the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about pull requests on the repository.</value>
    [DataMember(Name="pulls_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pulls_url")]
    public string PullsUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about releases on the repository.
    /// </summary>
    /// <value>A template for the API URL to get information about releases on the repository.</value>
    [DataMember(Name="releases_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "releases_url")]
    public string ReleasesUrl { get; set; }

    /// <summary>
    /// The API URL to list the stargazers on the repository.
    /// </summary>
    /// <value>The API URL to list the stargazers on the repository.</value>
    [DataMember(Name="stargazers_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stargazers_url")]
    public string StargazersUrl { get; set; }

    /// <summary>
    /// A template for the API URL to get information about statuses of a commit.
    /// </summary>
    /// <value>A template for the API URL to get information about statuses of a commit.</value>
    [DataMember(Name="statuses_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statuses_url")]
    public string StatusesUrl { get; set; }

    /// <summary>
    /// The API URL to list the subscribers on the repository.
    /// </summary>
    /// <value>The API URL to list the subscribers on the repository.</value>
    [DataMember(Name="subscribers_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscribers_url")]
    public string SubscribersUrl { get; set; }

    /// <summary>
    /// The API URL to subscribe to notifications for this repository.
    /// </summary>
    /// <value>The API URL to subscribe to notifications for this repository.</value>
    [DataMember(Name="subscription_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_url")]
    public string SubscriptionUrl { get; set; }

    /// <summary>
    /// The API URL to get information about tags on the repository.
    /// </summary>
    /// <value>The API URL to get information about tags on the repository.</value>
    [DataMember(Name="tags_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags_url")]
    public string TagsUrl { get; set; }

    /// <summary>
    /// The API URL to list the teams on the repository.
    /// </summary>
    /// <value>The API URL to list the teams on the repository.</value>
    [DataMember(Name="teams_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teams_url")]
    public string TeamsUrl { get; set; }

    /// <summary>
    /// A template for the API URL to create or retrieve a raw Git tree of the repository.
    /// </summary>
    /// <value>A template for the API URL to create or retrieve a raw Git tree of the repository.</value>
    [DataMember(Name="trees_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trees_url")]
    public string TreesUrl { get; set; }

    /// <summary>
    /// The API URL to list the hooks on the repository.
    /// </summary>
    /// <value>The API URL to list the hooks on the repository.</value>
    [DataMember(Name="hooks_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hooks_url")]
    public string HooksUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SimpleRepository {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  FullName: ").Append(FullName).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  Private: ").Append(Private).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Fork: ").Append(Fork).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  ArchiveUrl: ").Append(ArchiveUrl).Append("\n");
      sb.Append("  AssigneesUrl: ").Append(AssigneesUrl).Append("\n");
      sb.Append("  BlobsUrl: ").Append(BlobsUrl).Append("\n");
      sb.Append("  BranchesUrl: ").Append(BranchesUrl).Append("\n");
      sb.Append("  CollaboratorsUrl: ").Append(CollaboratorsUrl).Append("\n");
      sb.Append("  CommentsUrl: ").Append(CommentsUrl).Append("\n");
      sb.Append("  CommitsUrl: ").Append(CommitsUrl).Append("\n");
      sb.Append("  CompareUrl: ").Append(CompareUrl).Append("\n");
      sb.Append("  ContentsUrl: ").Append(ContentsUrl).Append("\n");
      sb.Append("  ContributorsUrl: ").Append(ContributorsUrl).Append("\n");
      sb.Append("  DeploymentsUrl: ").Append(DeploymentsUrl).Append("\n");
      sb.Append("  DownloadsUrl: ").Append(DownloadsUrl).Append("\n");
      sb.Append("  EventsUrl: ").Append(EventsUrl).Append("\n");
      sb.Append("  ForksUrl: ").Append(ForksUrl).Append("\n");
      sb.Append("  GitCommitsUrl: ").Append(GitCommitsUrl).Append("\n");
      sb.Append("  GitRefsUrl: ").Append(GitRefsUrl).Append("\n");
      sb.Append("  GitTagsUrl: ").Append(GitTagsUrl).Append("\n");
      sb.Append("  IssueCommentUrl: ").Append(IssueCommentUrl).Append("\n");
      sb.Append("  IssueEventsUrl: ").Append(IssueEventsUrl).Append("\n");
      sb.Append("  IssuesUrl: ").Append(IssuesUrl).Append("\n");
      sb.Append("  KeysUrl: ").Append(KeysUrl).Append("\n");
      sb.Append("  LabelsUrl: ").Append(LabelsUrl).Append("\n");
      sb.Append("  LanguagesUrl: ").Append(LanguagesUrl).Append("\n");
      sb.Append("  MergesUrl: ").Append(MergesUrl).Append("\n");
      sb.Append("  MilestonesUrl: ").Append(MilestonesUrl).Append("\n");
      sb.Append("  NotificationsUrl: ").Append(NotificationsUrl).Append("\n");
      sb.Append("  PullsUrl: ").Append(PullsUrl).Append("\n");
      sb.Append("  ReleasesUrl: ").Append(ReleasesUrl).Append("\n");
      sb.Append("  StargazersUrl: ").Append(StargazersUrl).Append("\n");
      sb.Append("  StatusesUrl: ").Append(StatusesUrl).Append("\n");
      sb.Append("  SubscribersUrl: ").Append(SubscribersUrl).Append("\n");
      sb.Append("  SubscriptionUrl: ").Append(SubscriptionUrl).Append("\n");
      sb.Append("  TagsUrl: ").Append(TagsUrl).Append("\n");
      sb.Append("  TeamsUrl: ").Append(TeamsUrl).Append("\n");
      sb.Append("  TreesUrl: ").Append(TreesUrl).Append("\n");
      sb.Append("  HooksUrl: ").Append(HooksUrl).Append("\n");
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
