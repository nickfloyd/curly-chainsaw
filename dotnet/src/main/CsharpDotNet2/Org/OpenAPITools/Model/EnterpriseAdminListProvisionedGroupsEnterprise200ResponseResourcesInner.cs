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
  public class EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner {
    /// <summary>
    /// Gets or Sets Schemas
    /// </summary>
    [DataMember(Name="schemas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schemas")]
    public List<string> Schemas { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets ExternalId
    /// </summary>
    [DataMember(Name="externalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalId")]
    public string ExternalId { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Members
    /// </summary>
    [DataMember(Name="members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "members")]
    public List<EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMembersInner> Members { get; set; }

    /// <summary>
    /// Gets or Sets Meta
    /// </summary>
    [DataMember(Name="meta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meta")]
    public EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta Meta { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInner {\n");
      sb.Append("  Schemas: ").Append(Schemas).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Members: ").Append(Members).Append("\n");
      sb.Append("  Meta: ").Append(Meta).Append("\n");
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
