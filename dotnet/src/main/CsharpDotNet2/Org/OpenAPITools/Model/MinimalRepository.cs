using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Minimal Repository
  /// </summary>
  [DataContract]
  public class MinimalRepository {
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
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets FullName
    /// </summary>
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
    /// Gets or Sets Private
    /// </summary>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? Private { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Fork
    /// </summary>
    [DataMember(Name="fork", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fork")]
    public bool? Fork { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets ArchiveUrl
    /// </summary>
    [DataMember(Name="archive_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archive_url")]
    public string ArchiveUrl { get; set; }

    /// <summary>
    /// Gets or Sets AssigneesUrl
    /// </summary>
    [DataMember(Name="assignees_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignees_url")]
    public string AssigneesUrl { get; set; }

    /// <summary>
    /// Gets or Sets BlobsUrl
    /// </summary>
    [DataMember(Name="blobs_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blobs_url")]
    public string BlobsUrl { get; set; }

    /// <summary>
    /// Gets or Sets BranchesUrl
    /// </summary>
    [DataMember(Name="branches_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "branches_url")]
    public string BranchesUrl { get; set; }

    /// <summary>
    /// Gets or Sets CollaboratorsUrl
    /// </summary>
    [DataMember(Name="collaborators_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collaborators_url")]
    public string CollaboratorsUrl { get; set; }

    /// <summary>
    /// Gets or Sets CommentsUrl
    /// </summary>
    [DataMember(Name="comments_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comments_url")]
    public string CommentsUrl { get; set; }

    /// <summary>
    /// Gets or Sets CommitsUrl
    /// </summary>
    [DataMember(Name="commits_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commits_url")]
    public string CommitsUrl { get; set; }

    /// <summary>
    /// Gets or Sets CompareUrl
    /// </summary>
    [DataMember(Name="compare_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "compare_url")]
    public string CompareUrl { get; set; }

    /// <summary>
    /// Gets or Sets ContentsUrl
    /// </summary>
    [DataMember(Name="contents_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contents_url")]
    public string ContentsUrl { get; set; }

    /// <summary>
    /// Gets or Sets ContributorsUrl
    /// </summary>
    [DataMember(Name="contributors_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contributors_url")]
    public string ContributorsUrl { get; set; }

    /// <summary>
    /// Gets or Sets DeploymentsUrl
    /// </summary>
    [DataMember(Name="deployments_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deployments_url")]
    public string DeploymentsUrl { get; set; }

    /// <summary>
    /// Gets or Sets DownloadsUrl
    /// </summary>
    [DataMember(Name="downloads_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "downloads_url")]
    public string DownloadsUrl { get; set; }

    /// <summary>
    /// Gets or Sets EventsUrl
    /// </summary>
    [DataMember(Name="events_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events_url")]
    public string EventsUrl { get; set; }

    /// <summary>
    /// Gets or Sets ForksUrl
    /// </summary>
    [DataMember(Name="forks_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forks_url")]
    public string ForksUrl { get; set; }

    /// <summary>
    /// Gets or Sets GitCommitsUrl
    /// </summary>
    [DataMember(Name="git_commits_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "git_commits_url")]
    public string GitCommitsUrl { get; set; }

    /// <summary>
    /// Gets or Sets GitRefsUrl
    /// </summary>
    [DataMember(Name="git_refs_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "git_refs_url")]
    public string GitRefsUrl { get; set; }

    /// <summary>
    /// Gets or Sets GitTagsUrl
    /// </summary>
    [DataMember(Name="git_tags_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "git_tags_url")]
    public string GitTagsUrl { get; set; }

    /// <summary>
    /// Gets or Sets GitUrl
    /// </summary>
    [DataMember(Name="git_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "git_url")]
    public string GitUrl { get; set; }

    /// <summary>
    /// Gets or Sets IssueCommentUrl
    /// </summary>
    [DataMember(Name="issue_comment_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issue_comment_url")]
    public string IssueCommentUrl { get; set; }

    /// <summary>
    /// Gets or Sets IssueEventsUrl
    /// </summary>
    [DataMember(Name="issue_events_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issue_events_url")]
    public string IssueEventsUrl { get; set; }

    /// <summary>
    /// Gets or Sets IssuesUrl
    /// </summary>
    [DataMember(Name="issues_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues_url")]
    public string IssuesUrl { get; set; }

    /// <summary>
    /// Gets or Sets KeysUrl
    /// </summary>
    [DataMember(Name="keys_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keys_url")]
    public string KeysUrl { get; set; }

    /// <summary>
    /// Gets or Sets LabelsUrl
    /// </summary>
    [DataMember(Name="labels_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels_url")]
    public string LabelsUrl { get; set; }

    /// <summary>
    /// Gets or Sets LanguagesUrl
    /// </summary>
    [DataMember(Name="languages_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "languages_url")]
    public string LanguagesUrl { get; set; }

    /// <summary>
    /// Gets or Sets MergesUrl
    /// </summary>
    [DataMember(Name="merges_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "merges_url")]
    public string MergesUrl { get; set; }

    /// <summary>
    /// Gets or Sets MilestonesUrl
    /// </summary>
    [DataMember(Name="milestones_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "milestones_url")]
    public string MilestonesUrl { get; set; }

    /// <summary>
    /// Gets or Sets NotificationsUrl
    /// </summary>
    [DataMember(Name="notifications_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notifications_url")]
    public string NotificationsUrl { get; set; }

    /// <summary>
    /// Gets or Sets PullsUrl
    /// </summary>
    [DataMember(Name="pulls_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pulls_url")]
    public string PullsUrl { get; set; }

    /// <summary>
    /// Gets or Sets ReleasesUrl
    /// </summary>
    [DataMember(Name="releases_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "releases_url")]
    public string ReleasesUrl { get; set; }

    /// <summary>
    /// Gets or Sets SshUrl
    /// </summary>
    [DataMember(Name="ssh_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ssh_url")]
    public string SshUrl { get; set; }

    /// <summary>
    /// Gets or Sets StargazersUrl
    /// </summary>
    [DataMember(Name="stargazers_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stargazers_url")]
    public string StargazersUrl { get; set; }

    /// <summary>
    /// Gets or Sets StatusesUrl
    /// </summary>
    [DataMember(Name="statuses_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statuses_url")]
    public string StatusesUrl { get; set; }

    /// <summary>
    /// Gets or Sets SubscribersUrl
    /// </summary>
    [DataMember(Name="subscribers_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscribers_url")]
    public string SubscribersUrl { get; set; }

    /// <summary>
    /// Gets or Sets SubscriptionUrl
    /// </summary>
    [DataMember(Name="subscription_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_url")]
    public string SubscriptionUrl { get; set; }

    /// <summary>
    /// Gets or Sets TagsUrl
    /// </summary>
    [DataMember(Name="tags_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags_url")]
    public string TagsUrl { get; set; }

    /// <summary>
    /// Gets or Sets TeamsUrl
    /// </summary>
    [DataMember(Name="teams_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teams_url")]
    public string TeamsUrl { get; set; }

    /// <summary>
    /// Gets or Sets TreesUrl
    /// </summary>
    [DataMember(Name="trees_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trees_url")]
    public string TreesUrl { get; set; }

    /// <summary>
    /// Gets or Sets CloneUrl
    /// </summary>
    [DataMember(Name="clone_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clone_url")]
    public string CloneUrl { get; set; }

    /// <summary>
    /// Gets or Sets MirrorUrl
    /// </summary>
    [DataMember(Name="mirror_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mirror_url")]
    public string MirrorUrl { get; set; }

    /// <summary>
    /// Gets or Sets HooksUrl
    /// </summary>
    [DataMember(Name="hooks_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hooks_url")]
    public string HooksUrl { get; set; }

    /// <summary>
    /// Gets or Sets SvnUrl
    /// </summary>
    [DataMember(Name="svn_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "svn_url")]
    public string SvnUrl { get; set; }

    /// <summary>
    /// Gets or Sets Homepage
    /// </summary>
    [DataMember(Name="homepage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homepage")]
    public string Homepage { get; set; }

    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Gets or Sets ForksCount
    /// </summary>
    [DataMember(Name="forks_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forks_count")]
    public int? ForksCount { get; set; }

    /// <summary>
    /// Gets or Sets StargazersCount
    /// </summary>
    [DataMember(Name="stargazers_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stargazers_count")]
    public int? StargazersCount { get; set; }

    /// <summary>
    /// Gets or Sets WatchersCount
    /// </summary>
    [DataMember(Name="watchers_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "watchers_count")]
    public int? WatchersCount { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public int? Size { get; set; }

    /// <summary>
    /// Gets or Sets DefaultBranch
    /// </summary>
    [DataMember(Name="default_branch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_branch")]
    public string DefaultBranch { get; set; }

    /// <summary>
    /// Gets or Sets OpenIssuesCount
    /// </summary>
    [DataMember(Name="open_issues_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open_issues_count")]
    public int? OpenIssuesCount { get; set; }

    /// <summary>
    /// Gets or Sets IsTemplate
    /// </summary>
    [DataMember(Name="is_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_template")]
    public bool? IsTemplate { get; set; }

    /// <summary>
    /// Gets or Sets Topics
    /// </summary>
    [DataMember(Name="topics", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topics")]
    public List<string> Topics { get; set; }

    /// <summary>
    /// Gets or Sets HasIssues
    /// </summary>
    [DataMember(Name="has_issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_issues")]
    public bool? HasIssues { get; set; }

    /// <summary>
    /// Gets or Sets HasProjects
    /// </summary>
    [DataMember(Name="has_projects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_projects")]
    public bool? HasProjects { get; set; }

    /// <summary>
    /// Gets or Sets HasWiki
    /// </summary>
    [DataMember(Name="has_wiki", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_wiki")]
    public bool? HasWiki { get; set; }

    /// <summary>
    /// Gets or Sets HasPages
    /// </summary>
    [DataMember(Name="has_pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_pages")]
    public bool? HasPages { get; set; }

    /// <summary>
    /// Gets or Sets HasDownloads
    /// </summary>
    [DataMember(Name="has_downloads", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_downloads")]
    public bool? HasDownloads { get; set; }

    /// <summary>
    /// Gets or Sets Archived
    /// </summary>
    [DataMember(Name="archived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archived")]
    public bool? Archived { get; set; }

    /// <summary>
    /// Gets or Sets Disabled
    /// </summary>
    [DataMember(Name="disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Gets or Sets Visibility
    /// </summary>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public string Visibility { get; set; }

    /// <summary>
    /// Gets or Sets PushedAt
    /// </summary>
    [DataMember(Name="pushed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pushed_at")]
    public DateTime? PushedAt { get; set; }

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
    /// Gets or Sets Permissions
    /// </summary>
    [DataMember(Name="permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissions")]
    public RepositoryTemplateRepositoryPermissions Permissions { get; set; }

    /// <summary>
    /// Gets or Sets RoleName
    /// </summary>
    [DataMember(Name="role_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role_name")]
    public string RoleName { get; set; }

    /// <summary>
    /// Gets or Sets TemplateRepository
    /// </summary>
    [DataMember(Name="template_repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "template_repository")]
    public Repository1 TemplateRepository { get; set; }

    /// <summary>
    /// Gets or Sets TempCloneToken
    /// </summary>
    [DataMember(Name="temp_clone_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "temp_clone_token")]
    public string TempCloneToken { get; set; }

    /// <summary>
    /// Gets or Sets DeleteBranchOnMerge
    /// </summary>
    [DataMember(Name="delete_branch_on_merge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delete_branch_on_merge")]
    public bool? DeleteBranchOnMerge { get; set; }

    /// <summary>
    /// Gets or Sets SubscribersCount
    /// </summary>
    [DataMember(Name="subscribers_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscribers_count")]
    public int? SubscribersCount { get; set; }

    /// <summary>
    /// Gets or Sets NetworkCount
    /// </summary>
    [DataMember(Name="network_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "network_count")]
    public int? NetworkCount { get; set; }

    /// <summary>
    /// Gets or Sets CodeOfConduct
    /// </summary>
    [DataMember(Name="code_of_conduct", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code_of_conduct")]
    public CodeOfConduct CodeOfConduct { get; set; }

    /// <summary>
    /// Gets or Sets License
    /// </summary>
    [DataMember(Name="license", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "license")]
    public MinimalRepositoryLicense License { get; set; }

    /// <summary>
    /// Gets or Sets Forks
    /// </summary>
    [DataMember(Name="forks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forks")]
    public int? Forks { get; set; }

    /// <summary>
    /// Gets or Sets OpenIssues
    /// </summary>
    [DataMember(Name="open_issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "open_issues")]
    public int? OpenIssues { get; set; }

    /// <summary>
    /// Gets or Sets Watchers
    /// </summary>
    [DataMember(Name="watchers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "watchers")]
    public int? Watchers { get; set; }

    /// <summary>
    /// Gets or Sets AllowForking
    /// </summary>
    [DataMember(Name="allow_forking", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allow_forking")]
    public bool? AllowForking { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MinimalRepository {\n");
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
      sb.Append("  GitUrl: ").Append(GitUrl).Append("\n");
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
      sb.Append("  SshUrl: ").Append(SshUrl).Append("\n");
      sb.Append("  StargazersUrl: ").Append(StargazersUrl).Append("\n");
      sb.Append("  StatusesUrl: ").Append(StatusesUrl).Append("\n");
      sb.Append("  SubscribersUrl: ").Append(SubscribersUrl).Append("\n");
      sb.Append("  SubscriptionUrl: ").Append(SubscriptionUrl).Append("\n");
      sb.Append("  TagsUrl: ").Append(TagsUrl).Append("\n");
      sb.Append("  TeamsUrl: ").Append(TeamsUrl).Append("\n");
      sb.Append("  TreesUrl: ").Append(TreesUrl).Append("\n");
      sb.Append("  CloneUrl: ").Append(CloneUrl).Append("\n");
      sb.Append("  MirrorUrl: ").Append(MirrorUrl).Append("\n");
      sb.Append("  HooksUrl: ").Append(HooksUrl).Append("\n");
      sb.Append("  SvnUrl: ").Append(SvnUrl).Append("\n");
      sb.Append("  Homepage: ").Append(Homepage).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  ForksCount: ").Append(ForksCount).Append("\n");
      sb.Append("  StargazersCount: ").Append(StargazersCount).Append("\n");
      sb.Append("  WatchersCount: ").Append(WatchersCount).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  DefaultBranch: ").Append(DefaultBranch).Append("\n");
      sb.Append("  OpenIssuesCount: ").Append(OpenIssuesCount).Append("\n");
      sb.Append("  IsTemplate: ").Append(IsTemplate).Append("\n");
      sb.Append("  Topics: ").Append(Topics).Append("\n");
      sb.Append("  HasIssues: ").Append(HasIssues).Append("\n");
      sb.Append("  HasProjects: ").Append(HasProjects).Append("\n");
      sb.Append("  HasWiki: ").Append(HasWiki).Append("\n");
      sb.Append("  HasPages: ").Append(HasPages).Append("\n");
      sb.Append("  HasDownloads: ").Append(HasDownloads).Append("\n");
      sb.Append("  Archived: ").Append(Archived).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  PushedAt: ").Append(PushedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
      sb.Append("  RoleName: ").Append(RoleName).Append("\n");
      sb.Append("  TemplateRepository: ").Append(TemplateRepository).Append("\n");
      sb.Append("  TempCloneToken: ").Append(TempCloneToken).Append("\n");
      sb.Append("  DeleteBranchOnMerge: ").Append(DeleteBranchOnMerge).Append("\n");
      sb.Append("  SubscribersCount: ").Append(SubscribersCount).Append("\n");
      sb.Append("  NetworkCount: ").Append(NetworkCount).Append("\n");
      sb.Append("  CodeOfConduct: ").Append(CodeOfConduct).Append("\n");
      sb.Append("  License: ").Append(License).Append("\n");
      sb.Append("  Forks: ").Append(Forks).Append("\n");
      sb.Append("  OpenIssues: ").Append(OpenIssues).Append("\n");
      sb.Append("  Watchers: ").Append(Watchers).Append("\n");
      sb.Append("  AllowForking: ").Append(AllowForking).Append("\n");
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
