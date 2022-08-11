using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Scim Error
  /// </summary>
  [DataContract]
  public class ScimError {
    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets DocumentationUrl
    /// </summary>
    [DataMember(Name="documentation_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentation_url")]
    public string DocumentationUrl { get; set; }

    /// <summary>
    /// Gets or Sets Detail
    /// </summary>
    [DataMember(Name="detail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detail")]
    public string Detail { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public int? Status { get; set; }

    /// <summary>
    /// Gets or Sets ScimType
    /// </summary>
    [DataMember(Name="scimType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scimType")]
    public string ScimType { get; set; }

    /// <summary>
    /// Gets or Sets Schemas
    /// </summary>
    [DataMember(Name="schemas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schemas")]
    public List<string> Schemas { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScimError {\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  DocumentationUrl: ").Append(DocumentationUrl).Append("\n");
      sb.Append("  Detail: ").Append(Detail).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ScimType: ").Append(ScimType).Append("\n");
      sb.Append("  Schemas: ").Append(Schemas).Append("\n");
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
