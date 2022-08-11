using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Gist Commit
  /// </summary>
  [DataContract]
  public class GistCommit {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets _Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string _Version { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUser User { get; set; }

    /// <summary>
    /// Gets or Sets ChangeStatus
    /// </summary>
    [DataMember(Name="change_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "change_status")]
    public GistHistoryChangeStatus ChangeStatus { get; set; }

    /// <summary>
    /// Gets or Sets CommittedAt
    /// </summary>
    [DataMember(Name="committed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "committed_at")]
    public DateTime? CommittedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GistCommit {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  _Version: ").Append(_Version).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  ChangeStatus: ").Append(ChangeStatus).Append("\n");
      sb.Append("  CommittedAt: ").Append(CommittedAt).Append("\n");
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
