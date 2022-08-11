using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// SCIM User List
  /// </summary>
  [DataContract]
  public class SCIMUserList {
    /// <summary>
    /// SCIM schema used.
    /// </summary>
    /// <value>SCIM schema used.</value>
    [DataMember(Name="schemas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schemas")]
    public List<string> Schemas { get; set; }

    /// <summary>
    /// Gets or Sets TotalResults
    /// </summary>
    [DataMember(Name="totalResults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalResults")]
    public int? TotalResults { get; set; }

    /// <summary>
    /// Gets or Sets ItemsPerPage
    /// </summary>
    [DataMember(Name="itemsPerPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemsPerPage")]
    public int? ItemsPerPage { get; set; }

    /// <summary>
    /// Gets or Sets StartIndex
    /// </summary>
    [DataMember(Name="startIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startIndex")]
    public int? StartIndex { get; set; }

    /// <summary>
    /// Gets or Sets Resources
    /// </summary>
    [DataMember(Name="Resources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Resources")]
    public List<SCIMUsers> Resources { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SCIMUserList {\n");
      sb.Append("  Schemas: ").Append(Schemas).Append("\n");
      sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
      sb.Append("  ItemsPerPage: ").Append(ItemsPerPage).Append("\n");
      sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
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
