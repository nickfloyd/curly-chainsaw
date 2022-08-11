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
  public class GroupMappingGroupsInner {
    /// <summary>
    /// The ID of the group
    /// </summary>
    /// <value>The ID of the group</value>
    [DataMember(Name="group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_id")]
    public string GroupId { get; set; }

    /// <summary>
    /// The name of the group
    /// </summary>
    /// <value>The name of the group</value>
    [DataMember(Name="group_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_name")]
    public string GroupName { get; set; }

    /// <summary>
    /// a description of the group
    /// </summary>
    /// <value>a description of the group</value>
    [DataMember(Name="group_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_description")]
    public string GroupDescription { get; set; }

    /// <summary>
    /// synchronization status for this group mapping
    /// </summary>
    /// <value>synchronization status for this group mapping</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// the time of the last sync for this group-mapping
    /// </summary>
    /// <value>the time of the last sync for this group-mapping</value>
    [DataMember(Name="synced_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "synced_at")]
    public string SyncedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupMappingGroupsInner {\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
      sb.Append("  GroupDescription: ").Append(GroupDescription).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
