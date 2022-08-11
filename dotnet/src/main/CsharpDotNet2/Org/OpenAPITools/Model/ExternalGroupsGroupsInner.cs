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
  public class ExternalGroupsGroupsInner {
    /// <summary>
    /// The internal ID of the group
    /// </summary>
    /// <value>The internal ID of the group</value>
    [DataMember(Name="group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_id")]
    public int? GroupId { get; set; }

    /// <summary>
    /// The display name of the group
    /// </summary>
    /// <value>The display name of the group</value>
    [DataMember(Name="group_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_name")]
    public string GroupName { get; set; }

    /// <summary>
    /// The time of the last update for this group
    /// </summary>
    /// <value>The time of the last update for this group</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public string UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExternalGroupsGroupsInner {\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
