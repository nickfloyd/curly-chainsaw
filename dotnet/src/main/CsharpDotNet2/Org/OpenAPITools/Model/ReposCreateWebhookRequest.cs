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
  public class ReposCreateWebhookRequest {
    /// <summary>
    /// Use `web` to create a webhook. Default: `web`. This parameter only accepts the value `web`.
    /// </summary>
    /// <value>Use `web` to create a webhook. Default: `web`. This parameter only accepts the value `web`.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [DataMember(Name="config", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "config")]
    public ReposCreateWebhookRequestConfig Config { get; set; }

    /// <summary>
    /// Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for.
    /// </summary>
    /// <value>Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for.</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<string> Events { get; set; }

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
      sb.Append("class ReposCreateWebhookRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
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
