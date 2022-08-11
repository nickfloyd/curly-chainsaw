using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// An autolink reference.
  /// </summary>
  [DataContract]
  public class AutolinkReference {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The prefix of a key that is linkified.
    /// </summary>
    /// <value>The prefix of a key that is linkified.</value>
    [DataMember(Name="key_prefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key_prefix")]
    public string KeyPrefix { get; set; }

    /// <summary>
    /// A template for the target URL that is generated if a key was found.
    /// </summary>
    /// <value>A template for the target URL that is generated if a key was found.</value>
    [DataMember(Name="url_template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url_template")]
    public string UrlTemplate { get; set; }

    /// <summary>
    /// Whether this autolink reference matches alphanumeric characters. If false, this autolink reference is a legacy autolink that only matches numeric characters.
    /// </summary>
    /// <value>Whether this autolink reference matches alphanumeric characters. If false, this autolink reference is a legacy autolink that only matches numeric characters.</value>
    [DataMember(Name="is_alphanumeric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_alphanumeric")]
    public bool? IsAlphanumeric { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AutolinkReference {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  KeyPrefix: ").Append(KeyPrefix).Append("\n");
      sb.Append("  UrlTemplate: ").Append(UrlTemplate).Append("\n");
      sb.Append("  IsAlphanumeric: ").Append(IsAlphanumeric).Append("\n");
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
