using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Successful deletion of a code scanning analysis
  /// </summary>
  [DataContract]
  public class AnalysisDeletion {
    /// <summary>
    /// Next deletable analysis in chain, without last analysis deletion confirmation
    /// </summary>
    /// <value>Next deletable analysis in chain, without last analysis deletion confirmation</value>
    [DataMember(Name="next_analysis_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next_analysis_url")]
    public string NextAnalysisUrl { get; set; }

    /// <summary>
    /// Next deletable analysis in chain, with last analysis deletion confirmation
    /// </summary>
    /// <value>Next deletable analysis in chain, with last analysis deletion confirmation</value>
    [DataMember(Name="confirm_delete_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confirm_delete_url")]
    public string ConfirmDeleteUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AnalysisDeletion {\n");
      sb.Append("  NextAnalysisUrl: ").Append(NextAnalysisUrl).Append("\n");
      sb.Append("  ConfirmDeleteUrl: ").Append(ConfirmDeleteUrl).Append("\n");
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
