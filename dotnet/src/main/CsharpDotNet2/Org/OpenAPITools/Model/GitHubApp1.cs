using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.
  /// </summary>
  [DataContract]
  public class GitHubApp1 {
    /// <summary>
    /// Unique identifier of the GitHub app
    /// </summary>
    /// <value>Unique identifier of the GitHub app</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The slug name of the GitHub app
    /// </summary>
    /// <value>The slug name of the GitHub app</value>
    [DataMember(Name="slug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slug")]
    public string Slug { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public SimpleUser Owner { get; set; }

    /// <summary>
    /// The name of the GitHub app
    /// </summary>
    /// <value>The name of the GitHub app</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets ExternalUrl
    /// </summary>
    [DataMember(Name="external_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "external_url")]
    public string ExternalUrl { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

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
    public GitHubAppPermissions Permissions { get; set; }

    /// <summary>
    /// The list of events for the GitHub app
    /// </summary>
    /// <value>The list of events for the GitHub app</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<string> Events { get; set; }

    /// <summary>
    /// The number of installations associated with the GitHub app
    /// </summary>
    /// <value>The number of installations associated with the GitHub app</value>
    [DataMember(Name="installations_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installations_count")]
    public int? InstallationsCount { get; set; }

    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [DataMember(Name="client_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_id")]
    public string ClientId { get; set; }

    /// <summary>
    /// Gets or Sets ClientSecret
    /// </summary>
    [DataMember(Name="client_secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_secret")]
    public string ClientSecret { get; set; }

    /// <summary>
    /// Gets or Sets WebhookSecret
    /// </summary>
    [DataMember(Name="webhook_secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webhook_secret")]
    public string WebhookSecret { get; set; }

    /// <summary>
    /// Gets or Sets Pem
    /// </summary>
    [DataMember(Name="pem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pem")]
    public string Pem { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GitHubApp1 {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Slug: ").Append(Slug).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ExternalUrl: ").Append(ExternalUrl).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
      sb.Append("  InstallationsCount: ").Append(InstallationsCount).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
      sb.Append("  WebhookSecret: ").Append(WebhookSecret).Append("\n");
      sb.Append("  Pem: ").Append(Pem).Append("\n");
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
