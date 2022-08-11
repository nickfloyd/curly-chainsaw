using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// License
  /// </summary>
  [DataContract]
  public class License {
    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets SpdxId
    /// </summary>
    [DataMember(Name="spdx_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "spdx_id")]
    public string SpdxId { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>
    [DataMember(Name="node_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node_id")]
    public string NodeId { get; set; }

    /// <summary>
    /// Gets or Sets HtmlUrl
    /// </summary>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Implementation
    /// </summary>
    [DataMember(Name="implementation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "implementation")]
    public string Implementation { get; set; }

    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [DataMember(Name="permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissions")]
    public List<string> Permissions { get; set; }

    /// <summary>
    /// Gets or Sets Conditions
    /// </summary>
    [DataMember(Name="conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conditions")]
    public List<string> Conditions { get; set; }

    /// <summary>
    /// Gets or Sets Limitations
    /// </summary>
    [DataMember(Name="limitations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limitations")]
    public List<string> Limitations { get; set; }

    /// <summary>
    /// Gets or Sets Body
    /// </summary>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }

    /// <summary>
    /// Gets or Sets Featured
    /// </summary>
    [DataMember(Name="featured", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featured")]
    public bool? Featured { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class License {\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SpdxId: ").Append(SpdxId).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Implementation: ").Append(Implementation).Append("\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      sb.Append("  Limitations: ").Append(Limitations).Append("\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Featured: ").Append(Featured).Append("\n");
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
