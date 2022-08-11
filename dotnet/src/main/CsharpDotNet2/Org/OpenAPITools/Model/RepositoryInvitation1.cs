using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Repository invitations let you manage who you collaborate with.
  /// </summary>
  [DataContract]
  public class RepositoryInvitation1 {
    /// <summary>
    /// Determines if notifications should be received from this repository.
    /// </summary>
    /// <value>Determines if notifications should be received from this repository.</value>
    [DataMember(Name="subscribed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscribed")]
    public bool? Subscribed { get; set; }

    /// <summary>
    /// Determines if all notifications should be blocked from this repository.
    /// </summary>
    /// <value>Determines if all notifications should be blocked from this repository.</value>
    [DataMember(Name="ignored", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ignored")]
    public bool? Ignored { get; set; }

    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

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
    /// Gets or Sets RepositoryUrl
    /// </summary>
    [DataMember(Name="repository_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_url")]
    public string RepositoryUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RepositoryInvitation1 {\n");
      sb.Append("  Subscribed: ").Append(Subscribed).Append("\n");
      sb.Append("  Ignored: ").Append(Ignored).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  RepositoryUrl: ").Append(RepositoryUrl).Append("\n");
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
