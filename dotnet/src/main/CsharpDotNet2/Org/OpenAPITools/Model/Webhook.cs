using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Webhooks for repositories.
  /// </summary>
  [DataContract]
  public class Webhook {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Unique identifier of the webhook.
    /// </summary>
    /// <value>Unique identifier of the webhook.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of a valid service, use 'web' for a webhook.
    /// </summary>
    /// <value>The name of a valid service, use 'web' for a webhook.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Determines whether the hook is actually triggered on pushes.
    /// </summary>
    /// <value>Determines whether the hook is actually triggered on pushes.</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Determines what events the hook is triggered for. Default: ['push'].
    /// </summary>
    /// <value>Determines what events the hook is triggered for. Default: ['push'].</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<string> Events { get; set; }

    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [DataMember(Name="config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config")]
    public WebhookConfig Config { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets TestUrl
    /// </summary>
    [DataMember(Name="test_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "test_url")]
    public string TestUrl { get; set; }

    /// <summary>
    /// Gets or Sets PingUrl
    /// </summary>
    [DataMember(Name="ping_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ping_url")]
    public string PingUrl { get; set; }

    /// <summary>
    /// Gets or Sets DeliveriesUrl
    /// </summary>
    [DataMember(Name="deliveries_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveries_url")]
    public string DeliveriesUrl { get; set; }

    /// <summary>
    /// Gets or Sets LastResponse
    /// </summary>
    [DataMember(Name="last_response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_response")]
    public HookResponse LastResponse { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Webhook {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  TestUrl: ").Append(TestUrl).Append("\n");
      sb.Append("  PingUrl: ").Append(PingUrl).Append("\n");
      sb.Append("  DeliveriesUrl: ").Append(DeliveriesUrl).Append("\n");
      sb.Append("  LastResponse: ").Append(LastResponse).Append("\n");
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
