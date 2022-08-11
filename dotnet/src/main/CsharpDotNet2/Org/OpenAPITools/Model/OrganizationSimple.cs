using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Organization Simple
  /// </summary>
  [DataContract]
  public class OrganizationSimple {
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
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

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
    /// Gets or Sets HooksUrl
    /// </summary>
    [DataMember(Name="hooks_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hooks_url")]
    public string HooksUrl { get; set; }

    /// <summary>
    /// Gets or Sets IssuesUrl
    /// </summary>
    [DataMember(Name="issues_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues_url")]
    public string IssuesUrl { get; set; }

    /// <summary>
    /// Gets or Sets MembersUrl
    /// </summary>
    [DataMember(Name="members_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members_url")]
    public string MembersUrl { get; set; }

    /// <summary>
    /// Gets or Sets PublicMembersUrl
    /// </summary>
    [DataMember(Name="public_members_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_members_url")]
    public string PublicMembersUrl { get; set; }

    /// <summary>
    /// Gets or Sets AvatarUrl
    /// </summary>
    [DataMember(Name="avatar_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatar_url")]
    public string AvatarUrl { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrganizationSimple {\n");
      sb.Append("  Login: ").Append(Login).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  ReposUrl: ").Append(ReposUrl).Append("\n");
      sb.Append("  EventsUrl: ").Append(EventsUrl).Append("\n");
      sb.Append("  HooksUrl: ").Append(HooksUrl).Append("\n");
      sb.Append("  IssuesUrl: ").Append(IssuesUrl).Append("\n");
      sb.Append("  MembersUrl: ").Append(MembersUrl).Append("\n");
      sb.Append("  PublicMembersUrl: ").Append(PublicMembersUrl).Append("\n");
      sb.Append("  AvatarUrl: ").Append(AvatarUrl).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
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
