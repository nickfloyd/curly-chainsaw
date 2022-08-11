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
  public class AppsCreateFromManifest201ResponseAllOf : Dictionary<String, Object> {
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
      sb.Append("class AppsCreateFromManifest201ResponseAllOf {\n");
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
    public  new string ToJson() {
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

}
}
