using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Issue Event Rename
  /// </summary>
  [DataContract]
  public class IssueEventRename {
    /// <summary>
    /// Gets or Sets From
    /// </summary>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public string From { get; set; }

    /// <summary>
    /// Gets or Sets To
    /// </summary>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public string To { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueEventRename {\n");
      sb.Append("  From: ").Append(From).Append("\n");
      sb.Append("  To: ").Append(To).Append("\n");
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
