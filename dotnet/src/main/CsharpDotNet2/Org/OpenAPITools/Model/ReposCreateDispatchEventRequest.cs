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
  public class ReposCreateDispatchEventRequest {
    /// <summary>
    /// A custom webhook event name. Must be 100 characters or fewer.
    /// </summary>
    /// <value>A custom webhook event name. Must be 100 characters or fewer.</value>
    [DataMember(Name="event_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_type")]
    public string EventType { get; set; }

    /// <summary>
    /// JSON payload with extra information about the webhook event that your action or workflow may use.
    /// </summary>
    /// <value>JSON payload with extra information about the webhook event that your action or workflow may use.</value>
    [DataMember(Name="client_payload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_payload")]
    public Dictionary<string, Object> ClientPayload { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreateDispatchEventRequest {\n");
      sb.Append("  EventType: ").Append(EventType).Append("\n");
      sb.Append("  ClientPayload: ").Append(ClientPayload).Append("\n");
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
