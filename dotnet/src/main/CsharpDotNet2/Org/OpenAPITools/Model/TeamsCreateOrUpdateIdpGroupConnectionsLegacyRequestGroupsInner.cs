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
  public class TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequestGroupsInner {
    /// <summary>
    /// ID of the IdP group.
    /// </summary>
    /// <value>ID of the IdP group.</value>
    [DataMember(Name="group_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_id")]
    public string GroupId { get; set; }

    /// <summary>
    /// Name of the IdP group.
    /// </summary>
    /// <value>Name of the IdP group.</value>
    [DataMember(Name="group_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_name")]
    public string GroupName { get; set; }

    /// <summary>
    /// Description of the IdP group.
    /// </summary>
    /// <value>Description of the IdP group.</value>
    [DataMember(Name="group_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_description")]
    public string GroupDescription { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TeamsCreateOrUpdateIdpGroupConnectionsLegacyRequestGroupsInner {\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
      sb.Append("  GroupDescription: ").Append(GroupDescription).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
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
