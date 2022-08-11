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
  public class CodeScanningUpdateAlertRequest {
    /// <summary>
    /// Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.
    /// </summary>
    /// <value>Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
    /// </summary>
    /// <value>**Required when the state is dismissed.** The reason for dismissing or closing the alert.</value>
    [DataMember(Name="dismissed_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismissed_reason")]
    public string DismissedReason { get; set; }

    /// <summary>
    /// The dismissal comment associated with the dismissal of the alert.
    /// </summary>
    /// <value>The dismissal comment associated with the dismissal of the alert.</value>
    [DataMember(Name="dismissed_comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismissed_comment")]
    public string DismissedComment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodeScanningUpdateAlertRequest {\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  DismissedReason: ").Append(DismissedReason).Append("\n");
      sb.Append("  DismissedComment: ").Append(DismissedComment).Append("\n");
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
