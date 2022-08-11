using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Delivery made by a webhook.
  /// </summary>
  [DataContract]
  public class WebhookDelivery {
    /// <summary>
    /// Unique identifier of the delivery.
    /// </summary>
    /// <value>Unique identifier of the delivery.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Unique identifier for the event (shared with all deliveries for all webhooks that subscribe to this event).
    /// </summary>
    /// <value>Unique identifier for the event (shared with all deliveries for all webhooks that subscribe to this event).</value>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// Time when the delivery was delivered.
    /// </summary>
    /// <value>Time when the delivery was delivered.</value>
    [DataMember(Name="delivered_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivered_at")]
    public DateTime? DeliveredAt { get; set; }

    /// <summary>
    /// Whether the delivery is a redelivery.
    /// </summary>
    /// <value>Whether the delivery is a redelivery.</value>
    [DataMember(Name="redelivery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redelivery")]
    public bool? Redelivery { get; set; }

    /// <summary>
    /// Time spent delivering.
    /// </summary>
    /// <value>Time spent delivering.</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public decimal? Duration { get; set; }

    /// <summary>
    /// Description of the status of the attempted delivery
    /// </summary>
    /// <value>Description of the status of the attempted delivery</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Status code received when delivery was made.
    /// </summary>
    /// <value>Status code received when delivery was made.</value>
    [DataMember(Name="status_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status_code")]
    public int? StatusCode { get; set; }

    /// <summary>
    /// The event that triggered the delivery.
    /// </summary>
    /// <value>The event that triggered the delivery.</value>
    [DataMember(Name="event", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event")]
    public string Event { get; set; }

    /// <summary>
    /// The type of activity for the event that triggered the delivery.
    /// </summary>
    /// <value>The type of activity for the event that triggered the delivery.</value>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// The id of the GitHub App installation associated with this event.
    /// </summary>
    /// <value>The id of the GitHub App installation associated with this event.</value>
    [DataMember(Name="installation_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installation_id")]
    public int? InstallationId { get; set; }

    /// <summary>
    /// The id of the repository associated with this event.
    /// </summary>
    /// <value>The id of the repository associated with this event.</value>
    [DataMember(Name="repository_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_id")]
    public int? RepositoryId { get; set; }

    /// <summary>
    /// The URL target of the delivery.
    /// </summary>
    /// <value>The URL target of the delivery.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Request
    /// </summary>
    [DataMember(Name="request", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request")]
    public WebhookDeliveryRequest Request { get; set; }

    /// <summary>
    /// Gets or Sets Response
    /// </summary>
    [DataMember(Name="response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "response")]
    public WebhookDeliveryResponse Response { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebhookDelivery {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  DeliveredAt: ").Append(DeliveredAt).Append("\n");
      sb.Append("  Redelivery: ").Append(Redelivery).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
      sb.Append("  Event: ").Append(Event).Append("\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  InstallationId: ").Append(InstallationId).Append("\n");
      sb.Append("  RepositoryId: ").Append(RepositoryId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Request: ").Append(Request).Append("\n");
      sb.Append("  Response: ").Append(Response).Append("\n");
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
