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
  public class ProjectsCreateCardRequest {
    /// <summary>
    /// The project card's note
    /// </summary>
    /// <value>The project card's note</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// The unique identifier of the content associated with the card
    /// </summary>
    /// <value>The unique identifier of the content associated with the card</value>
    [DataMember(Name="content_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content_id")]
    public int? ContentId { get; set; }

    /// <summary>
    /// The piece of content associated with the card
    /// </summary>
    /// <value>The piece of content associated with the card</value>
    [DataMember(Name="content_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content_type")]
    public string ContentType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectsCreateCardRequest {\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  ContentId: ").Append(ContentId).Append("\n");
      sb.Append("  ContentType: ").Append(ContentType).Append("\n");
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
