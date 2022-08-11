using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Simple User
  /// </summary>
  [DataContract]
  public class SimpleUser {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets Login
    /// </summary>
    [DataMember(Name="login", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "login")]
    public string Login { get; set; }

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
    /// Gets or Sets AvatarUrl
    /// </summary>
    [DataMember(Name="avatar_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar_url")]
    public string AvatarUrl { get; set; }

    /// <summary>
    /// Gets or Sets GravatarId
    /// </summary>
    [DataMember(Name="gravatar_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gravatar_id")]
    public string GravatarId { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

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
    /// Gets or Sets StarredUrl
    /// </summary>
    [DataMember(Name="starred_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "starred_url")]
    public string StarredUrl { get; set; }

    /// <summary>
    /// Gets or Sets SubscriptionsUrl
    /// </summary>
    [DataMember(Name="subscriptions_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptions_url")]
    public string SubscriptionsUrl { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationsUrl
    /// </summary>
    [DataMember(Name="organizations_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organizations_url")]
    public string OrganizationsUrl { get; set; }

    /// <summary>
    /// Gets or Sets ReposUrl
    /// </summary>
    [DataMember(Name="repos_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repos_url")]
    public string ReposUrl { get; set; }

    /// <summary>
    /// Gets or Sets EventsUrl
    /// </summary>
    [DataMember(Name="events_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events_url")]
    public string EventsUrl { get; set; }

    /// <summary>
    /// Gets or Sets ReceivedEventsUrl
    /// </summary>
    [DataMember(Name="received_events_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "received_events_url")]
    public string ReceivedEventsUrl { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets SiteAdmin
    /// </summary>
    [DataMember(Name="site_admin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "site_admin")]
    public bool? SiteAdmin { get; set; }

    /// <summary>
    /// Gets or Sets StarredAt
    /// </summary>
    [DataMember(Name="starred_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "starred_at")]
    public string StarredAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SimpleUser {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Login: ").Append(Login).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
      sb.Append("  GravatarId: ").Append(GravatarId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  FollowersUrl: ").Append(FollowersUrl).Append("\n");
      sb.Append("  FollowingUrl: ").Append(FollowingUrl).Append("\n");
      sb.Append("  GistsUrl: ").Append(GistsUrl).Append("\n");
      sb.Append("  StarredUrl: ").Append(StarredUrl).Append("\n");
      sb.Append("  SubscriptionsUrl: ").Append(SubscriptionsUrl).Append("\n");
      sb.Append("  OrganizationsUrl: ").Append(OrganizationsUrl).Append("\n");
      sb.Append("  ReposUrl: ").Append(ReposUrl).Append("\n");
      sb.Append("  EventsUrl: ").Append(EventsUrl).Append("\n");
      sb.Append("  ReceivedEventsUrl: ").Append(ReceivedEventsUrl).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  SiteAdmin: ").Append(SiteAdmin).Append("\n");
      sb.Append("  StarredAt: ").Append(StarredAt).Append("\n");
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
