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
  public class ActivitySetRepoSubscriptionRequest {
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActivitySetRepoSubscriptionRequest {\n");
      sb.Append("  Subscribed: ").Append(Subscribed).Append("\n");
      sb.Append("  Ignored: ").Append(Ignored).Append("\n");
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
