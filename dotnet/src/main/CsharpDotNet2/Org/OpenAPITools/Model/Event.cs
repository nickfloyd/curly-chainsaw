using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Event
  /// </summary>
  [DataContract]
  public class Event {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Actor
    /// </summary>
    [DataMember(Name="actor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actor")]
    public Actor Actor { get; set; }

    /// <summary>
    /// Gets or Sets Repo
    /// </summary>
    [DataMember(Name="repo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repo")]
    public EventRepo Repo { get; set; }

    /// <summary>
    /// Gets or Sets Org
    /// </summary>
    [DataMember(Name="org", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "org")]
    public Actor Org { get; set; }

    /// <summary>
    /// Gets or Sets Payload
    /// </summary>
    [DataMember(Name="payload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payload")]
    public EventPayload Payload { get; set; }

    /// <summary>
    /// Gets or Sets Public
    /// </summary>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public bool? Public { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Event {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Actor: ").Append(Actor).Append("\n");
      sb.Append("  Repo: ").Append(Repo).Append("\n");
      sb.Append("  Org: ").Append(Org).Append("\n");
      sb.Append("  Payload: ").Append(Payload).Append("\n");
      sb.Append("  Public: ").Append(Public).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
