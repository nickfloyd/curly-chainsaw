using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Thread
  /// </summary>
  [DataContract]
  public class Thread {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Repository
    /// </summary>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public MinimalRepository Repository { get; set; }

    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subject")]
    public ThreadSubject Subject { get; set; }

    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Gets or Sets Unread
    /// </summary>
    [DataMember(Name="unread", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unread")]
    public bool? Unread { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets LastReadAt
    /// </summary>
    [DataMember(Name="last_read_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_read_at")]
    public string LastReadAt { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets SubscriptionUrl
    /// </summary>
    [DataMember(Name="subscription_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscription_url")]
    public string SubscriptionUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Thread {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Unread: ").Append(Unread).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  LastReadAt: ").Append(LastReadAt).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  SubscriptionUrl: ").Append(SubscriptionUrl).Append("\n");
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
