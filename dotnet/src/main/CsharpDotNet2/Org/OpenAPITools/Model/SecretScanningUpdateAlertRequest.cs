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
  public class SecretScanningUpdateAlertRequest {
    /// <summary>
    /// Sets the state of the secret scanning alert. Can be either `open` or `resolved`. You must provide `resolution` when you set the state to `resolved`.
    /// </summary>
    /// <value>Sets the state of the secret scanning alert. Can be either `open` or `resolved`. You must provide `resolution` when you set the state to `resolved`.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
    /// </summary>
    /// <value>**Required when the `state` is `resolved`.** The reason for resolving the alert.</value>
    [DataMember(Name="resolution", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolution")]
    public string Resolution { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SecretScanningUpdateAlertRequest {\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Resolution: ").Append(Resolution).Append("\n");
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
