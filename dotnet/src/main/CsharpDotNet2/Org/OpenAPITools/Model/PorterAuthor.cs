using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Porter Author
  /// </summary>
  [DataContract]
  public class PorterAuthor {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets RemoteId
    /// </summary>
    [DataMember(Name="remote_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remote_id")]
    public string RemoteId { get; set; }

    /// <summary>
    /// Gets or Sets RemoteName
    /// </summary>
    [DataMember(Name="remote_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remote_name")]
    public string RemoteName { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets ImportUrl
    /// </summary>
    [DataMember(Name="import_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "import_url")]
    public string ImportUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PorterAuthor {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
      sb.Append("  RemoteName: ").Append(RemoteName).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  ImportUrl: ").Append(ImportUrl).Append("\n");
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
