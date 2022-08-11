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
  public class TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest {
    /// <summary>
    /// The IdP groups you want to connect to a GitHub team. When updating, the new `groups` object will replace the original one. You must include any existing groups that you don't want to remove.
    /// </summary>
    /// <value>The IdP groups you want to connect to a GitHub team. When updating, the new `groups` object will replace the original one. You must include any existing groups that you don't want to remove.</value>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequestGroupsInner> Groups { get; set; }

    /// <summary>
    /// Gets or Sets SyncedAt
    /// </summary>
    [DataMember(Name="synced_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "synced_at")]
    public string SyncedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequest {\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  SyncedAt: ").Append(SyncedAt).Append("\n");
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
