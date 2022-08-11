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
  public class AppsUpdateWebhookConfigForAppRequest {
    /// <summary>
    /// The URL to which the payloads will be delivered.
    /// </summary>
    /// <value>The URL to which the payloads will be delivered.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// The media type used to serialize the payloads. Supported values include `json` and `form`. The default is `form`.
    /// </summary>
    /// <value>The media type used to serialize the payloads. Supported values include `json` and `form`. The default is `form`.</value>
    [DataMember(Name="content_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content_type")]
    public string ContentType { get; set; }

    /// <summary>
    /// If provided, the `secret` will be used as the `key` to generate the HMAC hex digest value for [delivery signature headers](https://docs.github.com/webhooks/event-payloads/#delivery-headers).
    /// </summary>
    /// <value>If provided, the `secret` will be used as the `key` to generate the HMAC hex digest value for [delivery signature headers](https://docs.github.com/webhooks/event-payloads/#delivery-headers).</value>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }

    /// <summary>
    /// Gets or Sets InsecureSsl
    /// </summary>
    [DataMember(Name="insecure_ssl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insecure_ssl")]
    public WebhookConfigurationInsecureSsl InsecureSsl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppsUpdateWebhookConfigForAppRequest {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  ContentType: ").Append(ContentType).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  InsecureSsl: ").Append(InsecureSsl).Append("\n");
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
