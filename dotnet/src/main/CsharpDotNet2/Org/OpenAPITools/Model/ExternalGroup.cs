using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Information about an external group&#39;s usage and its members
  /// </summary>
  [DataContract]
  public class ExternalGroup {
    /// <summary>
    /// The internal ID of the group
    /// </summary>
    /// <value>The internal ID of the group</value>
    [DataMember(Name="group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_id")]
    public int? GroupId { get; set; }

    /// <summary>
    /// The display name for the group
    /// </summary>
    /// <value>The display name for the group</value>
    [DataMember(Name="group_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_name")]
    public string GroupName { get; set; }

    /// <summary>
    /// The date when the group was last updated_at
    /// </summary>
    /// <value>The date when the group was last updated_at</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// An array of teams linked to this group
    /// </summary>
    /// <value>An array of teams linked to this group</value>
    [DataMember(Name="teams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teams")]
    public List<ExternalGroupTeamsInner> Teams { get; set; }

    /// <summary>
    /// An array of external members linked to this group
    /// </summary>
    /// <value>An array of external members linked to this group</value>
    [DataMember(Name="members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members")]
    public List<ExternalGroupMembersInner> Members { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExternalGroup {\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Teams: ").Append(Teams).Append("\n");
      sb.Append("  Members: ").Append(Members).Append("\n");
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
