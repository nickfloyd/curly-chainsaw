using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A list of errors found in a repo&#39;s CODEOWNERS file
  /// </summary>
  [DataContract]
  public class CODEOWNERSErrors {
    /// <summary>
    /// Gets or Sets Errors
    /// </summary>
    [DataMember(Name="errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errors")]
    public List<CODEOWNERSErrorsErrorsInner> Errors { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CODEOWNERSErrors {\n");
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
