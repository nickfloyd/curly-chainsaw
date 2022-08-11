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
  public class MetaRoot200Response {
    /// <summary>
    /// Gets or Sets CurrentUserUrl
    /// </summary>
    [DataMember(Name="current_user_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_url")]
    public string CurrentUserUrl { get; set; }

    /// <summary>
    /// Gets or Sets CurrentUserAuthorizationsHtmlUrl
    /// </summary>
    [DataMember(Name="current_user_authorizations_html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_authorizations_html_url")]
    public string CurrentUserAuthorizationsHtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizationsUrl
    /// </summary>
    [DataMember(Name="authorizations_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorizations_url")]
    public string AuthorizationsUrl { get; set; }

    /// <summary>
    /// Gets or Sets CodeSearchUrl
    /// </summary>
    [DataMember(Name="code_search_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code_search_url")]
    public string CodeSearchUrl { get; set; }

    /// <summary>
    /// Gets or Sets CommitSearchUrl
    /// </summary>
    [DataMember(Name="commit_search_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit_search_url")]
    public string CommitSearchUrl { get; set; }

    /// <summary>
    /// Gets or Sets EmailsUrl
    /// </summary>
    [DataMember(Name="emails_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emails_url")]
    public string EmailsUrl { get; set; }

    /// <summary>
    /// Gets or Sets EmojisUrl
    /// </summary>
    [DataMember(Name="emojis_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emojis_url")]
    public string EmojisUrl { get; set; }

    /// <summary>
    /// Gets or Sets EventsUrl
    /// </summary>
    [DataMember(Name="events_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events_url")]
    public string EventsUrl { get; set; }

    /// <summary>
    /// Gets or Sets FeedsUrl
    /// </summary>
    [DataMember(Name="feeds_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "feeds_url")]
    public string FeedsUrl { get; set; }

    /// <summary>
    /// Gets or Sets FollowersUrl
    /// </summary>
    [DataMember(Name="followers_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "followers_url")]
    public string FollowersUrl { get; set; }

    /// <summary>
    /// Gets or Sets FollowingUrl
    /// </summary>
    [DataMember(Name="following_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "following_url")]
    public string FollowingUrl { get; set; }

    /// <summary>
    /// Gets or Sets GistsUrl
    /// </summary>
    [DataMember(Name="gists_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gists_url")]
    public string GistsUrl { get; set; }

    /// <summary>
    /// Gets or Sets HubUrl
    /// </summary>
    [DataMember(Name="hub_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hub_url")]
    public string HubUrl { get; set; }

    /// <summary>
    /// Gets or Sets IssueSearchUrl
    /// </summary>
    [DataMember(Name="issue_search_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issue_search_url")]
    public string IssueSearchUrl { get; set; }

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
    /// Gets or Sets LabelSearchUrl
    /// </summary>
    [DataMember(Name="label_search_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label_search_url")]
    public string LabelSearchUrl { get; set; }

    /// <summary>
    /// Gets or Sets NotificationsUrl
    /// </summary>
    [DataMember(Name="notifications_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notifications_url")]
    public string NotificationsUrl { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationUrl
    /// </summary>
    [DataMember(Name="organization_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_url")]
    public string OrganizationUrl { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationRepositoriesUrl
    /// </summary>
    [DataMember(Name="organization_repositories_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_repositories_url")]
    public string OrganizationRepositoriesUrl { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationTeamsUrl
    /// </summary>
    [DataMember(Name="organization_teams_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_teams_url")]
    public string OrganizationTeamsUrl { get; set; }

    /// <summary>
    /// Gets or Sets PublicGistsUrl
    /// </summary>
    [DataMember(Name="public_gists_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_gists_url")]
    public string PublicGistsUrl { get; set; }

    /// <summary>
    /// Gets or Sets RateLimitUrl
    /// </summary>
    [DataMember(Name="rate_limit_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rate_limit_url")]
    public string RateLimitUrl { get; set; }

    /// <summary>
    /// Gets or Sets RepositoryUrl
    /// </summary>
    [DataMember(Name="repository_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_url")]
    public string RepositoryUrl { get; set; }

    /// <summary>
    /// Gets or Sets RepositorySearchUrl
    /// </summary>
    [DataMember(Name="repository_search_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_search_url")]
    public string RepositorySearchUrl { get; set; }

    /// <summary>
    /// Gets or Sets CurrentUserRepositoriesUrl
    /// </summary>
    [DataMember(Name="current_user_repositories_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "current_user_repositories_url")]
    public string CurrentUserRepositoriesUrl { get; set; }

    /// <summary>
    /// Gets or Sets StarredUrl
    /// </summary>
    [DataMember(Name="starred_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "starred_url")]
    public string StarredUrl { get; set; }

    /// <summary>
    /// Gets or Sets StarredGistsUrl
    /// </summary>
    [DataMember(Name="starred_gists_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "starred_gists_url")]
    public string StarredGistsUrl { get; set; }

    /// <summary>
    /// Gets or Sets TopicSearchUrl
    /// </summary>
    [DataMember(Name="topic_search_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "topic_search_url")]
    public string TopicSearchUrl { get; set; }

    /// <summary>
    /// Gets or Sets UserUrl
    /// </summary>
    [DataMember(Name="user_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_url")]
    public string UserUrl { get; set; }

    /// <summary>
    /// Gets or Sets UserOrganizationsUrl
    /// </summary>
    [DataMember(Name="user_organizations_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_organizations_url")]
    public string UserOrganizationsUrl { get; set; }

    /// <summary>
    /// Gets or Sets UserRepositoriesUrl
    /// </summary>
    [DataMember(Name="user_repositories_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_repositories_url")]
    public string UserRepositoriesUrl { get; set; }

    /// <summary>
    /// Gets or Sets UserSearchUrl
    /// </summary>
    [DataMember(Name="user_search_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_search_url")]
    public string UserSearchUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetaRoot200Response {\n");
      sb.Append("  CurrentUserUrl: ").Append(CurrentUserUrl).Append("\n");
      sb.Append("  CurrentUserAuthorizationsHtmlUrl: ").Append(CurrentUserAuthorizationsHtmlUrl).Append("\n");
      sb.Append("  AuthorizationsUrl: ").Append(AuthorizationsUrl).Append("\n");
      sb.Append("  CodeSearchUrl: ").Append(CodeSearchUrl).Append("\n");
      sb.Append("  CommitSearchUrl: ").Append(CommitSearchUrl).Append("\n");
      sb.Append("  EmailsUrl: ").Append(EmailsUrl).Append("\n");
      sb.Append("  EmojisUrl: ").Append(EmojisUrl).Append("\n");
      sb.Append("  EventsUrl: ").Append(EventsUrl).Append("\n");
      sb.Append("  FeedsUrl: ").Append(FeedsUrl).Append("\n");
      sb.Append("  FollowersUrl: ").Append(FollowersUrl).Append("\n");
      sb.Append("  FollowingUrl: ").Append(FollowingUrl).Append("\n");
      sb.Append("  GistsUrl: ").Append(GistsUrl).Append("\n");
      sb.Append("  HubUrl: ").Append(HubUrl).Append("\n");
      sb.Append("  IssueSearchUrl: ").Append(IssueSearchUrl).Append("\n");
      sb.Append("  IssuesUrl: ").Append(IssuesUrl).Append("\n");
      sb.Append("  KeysUrl: ").Append(KeysUrl).Append("\n");
      sb.Append("  LabelSearchUrl: ").Append(LabelSearchUrl).Append("\n");
      sb.Append("  NotificationsUrl: ").Append(NotificationsUrl).Append("\n");
      sb.Append("  OrganizationUrl: ").Append(OrganizationUrl).Append("\n");
      sb.Append("  OrganizationRepositoriesUrl: ").Append(OrganizationRepositoriesUrl).Append("\n");
      sb.Append("  OrganizationTeamsUrl: ").Append(OrganizationTeamsUrl).Append("\n");
      sb.Append("  PublicGistsUrl: ").Append(PublicGistsUrl).Append("\n");
      sb.Append("  RateLimitUrl: ").Append(RateLimitUrl).Append("\n");
      sb.Append("  RepositoryUrl: ").Append(RepositoryUrl).Append("\n");
      sb.Append("  RepositorySearchUrl: ").Append(RepositorySearchUrl).Append("\n");
      sb.Append("  CurrentUserRepositoriesUrl: ").Append(CurrentUserRepositoriesUrl).Append("\n");
      sb.Append("  StarredUrl: ").Append(StarredUrl).Append("\n");
      sb.Append("  StarredGistsUrl: ").Append(StarredGistsUrl).Append("\n");
      sb.Append("  TopicSearchUrl: ").Append(TopicSearchUrl).Append("\n");
      sb.Append("  UserUrl: ").Append(UserUrl).Append("\n");
      sb.Append("  UserOrganizationsUrl: ").Append(UserOrganizationsUrl).Append("\n");
      sb.Append("  UserRepositoriesUrl: ").Append(UserRepositoriesUrl).Append("\n");
      sb.Append("  UserSearchUrl: ").Append(UserSearchUrl).Append("\n");
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
