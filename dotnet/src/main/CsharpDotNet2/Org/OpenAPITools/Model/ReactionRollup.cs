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
  public class ReactionRollup {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets TotalCount
    /// </summary>
    [DataMember(Name="total_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_count")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Gets or Sets +1
    /// </summary>
    [DataMember(Name="+1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "+1")]
    public int? Plus_1 { get; set; }

    /// <summary>
    /// Gets or Sets -1
    /// </summary>
    [DataMember(Name="-1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "-1")]
    public int? Minus_1 { get; set; }

    /// <summary>
    /// Gets or Sets Laugh
    /// </summary>
    [DataMember(Name="laugh", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "laugh")]
    public int? Laugh { get; set; }

    /// <summary>
    /// Gets or Sets Confused
    /// </summary>
    [DataMember(Name="confused", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confused")]
    public int? Confused { get; set; }

    /// <summary>
    /// Gets or Sets Heart
    /// </summary>
    [DataMember(Name="heart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "heart")]
    public int? Heart { get; set; }

    /// <summary>
    /// Gets or Sets Hooray
    /// </summary>
    [DataMember(Name="hooray", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hooray")]
    public int? Hooray { get; set; }

    /// <summary>
    /// Gets or Sets Eyes
    /// </summary>
    [DataMember(Name="eyes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eyes")]
    public int? Eyes { get; set; }

    /// <summary>
    /// Gets or Sets Rocket
    /// </summary>
    [DataMember(Name="rocket", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rocket")]
    public int? Rocket { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReactionRollup {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  +1: ").Append(Plus_1).Append("\n");
      sb.Append("  -1: ").Append(Minus_1).Append("\n");
      sb.Append("  Laugh: ").Append(Laugh).Append("\n");
      sb.Append("  Confused: ").Append(Confused).Append("\n");
      sb.Append("  Heart: ").Append(Heart).Append("\n");
      sb.Append("  Hooray: ").Append(Hooray).Append("\n");
      sb.Append("  Eyes: ").Append(Eyes).Append("\n");
      sb.Append("  Rocket: ").Append(Rocket).Append("\n");
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
