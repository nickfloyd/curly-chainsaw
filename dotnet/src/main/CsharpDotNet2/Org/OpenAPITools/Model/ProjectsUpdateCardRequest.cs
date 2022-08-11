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
  public class ProjectsUpdateCardRequest {
    /// <summary>
    /// The project card's note
    /// </summary>
    /// <value>The project card's note</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// Whether or not the card is archived
    /// </summary>
    /// <value>Whether or not the card is archived</value>
    [DataMember(Name="archived", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "archived")]
    public bool? Archived { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectsUpdateCardRequest {\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  Archived: ").Append(Archived).Append("\n");
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
