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
  public class WebhookDeliveryResponse {
    /// <summary>
    /// The response headers received when the delivery was made.
    /// </summary>
    /// <value>The response headers received when the delivery was made.</value>
    [DataMember(Name="headers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headers")]
    public Dictionary<string, Object> Headers { get; set; }

    /// <summary>
    /// The response payload received.
    /// </summary>
    /// <value>The response payload received.</value>
    [DataMember(Name="payload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payload")]
    public Dictionary<string, Object> Payload { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebhookDeliveryResponse {\n");
      sb.Append("  Headers: ").Append(Headers).Append("\n");
      sb.Append("  Payload: ").Append(Payload).Append("\n");
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
