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
  public class ReposUpdateWebhookRequest {
    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [DataMember(Name="config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config")]
    public ReposUpdateWebhookRequestConfig Config { get; set; }

    /// <summary>
    /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. This replaces the entire array of events.
    /// </summary>
    /// <value>Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for. This replaces the entire array of events.</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<string> Events { get; set; }

    /// <summary>
    /// Determines a list of events to be added to the list of events that the Hook triggers for.
    /// </summary>
    /// <value>Determines a list of events to be added to the list of events that the Hook triggers for.</value>
    [DataMember(Name="add_events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add_events")]
    public List<string> AddEvents { get; set; }

    /// <summary>
    /// Determines a list of events to be removed from the list of events that the Hook triggers for.
    /// </summary>
    /// <value>Determines a list of events to be removed from the list of events that the Hook triggers for.</value>
    [DataMember(Name="remove_events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remove_events")]
    public List<string> RemoveEvents { get; set; }

    /// <summary>
    /// Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.
    /// </summary>
    /// <value>Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdateWebhookRequest {\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
      sb.Append("  AddEvents: ").Append(AddEvents).Append("\n");
      sb.Append("  RemoveEvents: ").Append(RemoveEvents).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
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
