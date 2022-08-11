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
  public class SearchResultTextMatchesInner {
    /// <summary>
    /// Gets or Sets ObjectUrl
    /// </summary>
    [DataMember(Name="object_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object_url")]
    public string ObjectUrl { get; set; }

    /// <summary>
    /// Gets or Sets ObjectType
    /// </summary>
    [DataMember(Name="object_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "object_type")]
    public string ObjectType { get; set; }

    /// <summary>
    /// Gets or Sets Property
    /// </summary>
    [DataMember(Name="property", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "property")]
    public string Property { get; set; }

    /// <summary>
    /// Gets or Sets Fragment
    /// </summary>
    [DataMember(Name="fragment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fragment")]
    public string Fragment { get; set; }

    /// <summary>
    /// Gets or Sets Matches
    /// </summary>
    [DataMember(Name="matches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "matches")]
    public List<SearchResultTextMatchesInnerMatchesInner> Matches { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SearchResultTextMatchesInner {\n");
      sb.Append("  ObjectUrl: ").Append(ObjectUrl).Append("\n");
      sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
      sb.Append("  Property: ").Append(Property).Append("\n");
      sb.Append("  Fragment: ").Append(Fragment).Append("\n");
      sb.Append("  Matches: ").Append(Matches).Append("\n");
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
