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
  public class CodeScanningGetSarif200Response {
    /// <summary>
    /// `pending` files have not yet been processed, while `complete` means results from the SARIF have been stored. `failed` files have either not been processed at all, or could only be partially processed.
    /// </summary>
    /// <value>`pending` files have not yet been processed, while `complete` means results from the SARIF have been stored. `failed` files have either not been processed at all, or could only be partially processed.</value>
    [DataMember(Name="processing_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processing_status")]
    public string ProcessingStatus { get; set; }

    /// <summary>
    /// The REST API URL for getting the analyses associated with the upload.
    /// </summary>
    /// <value>The REST API URL for getting the analyses associated with the upload.</value>
    [DataMember(Name="analyses_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "analyses_url")]
    public string AnalysesUrl { get; set; }

    /// <summary>
    /// Any errors that ocurred during processing of the delivery.
    /// </summary>
    /// <value>Any errors that ocurred during processing of the delivery.</value>
    [DataMember(Name="errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errors")]
    public List<string> Errors { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodeScanningGetSarif200Response {\n");
      sb.Append("  ProcessingStatus: ").Append(ProcessingStatus).Append("\n");
      sb.Append("  AnalysesUrl: ").Append(AnalysesUrl).Append("\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
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
