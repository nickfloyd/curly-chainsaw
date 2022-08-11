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
  public class ProjectsMoveCardRequest {
    /// <summary>
    /// The position of the card in a column. Can be one of: `top`, `bottom`, or `after:<card_id>` to place after the specified card.
    /// </summary>
    /// <value>The position of the card in a column. Can be one of: `top`, `bottom`, or `after:<card_id>` to place after the specified card.</value>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public string Position { get; set; }

    /// <summary>
    /// The unique identifier of the column the card should be moved to
    /// </summary>
    /// <value>The unique identifier of the column the card should be moved to</value>
    [DataMember(Name="column_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "column_id")]
    public int? ColumnId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectsMoveCardRequest {\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  ColumnId: ").Append(ColumnId).Append("\n");
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
