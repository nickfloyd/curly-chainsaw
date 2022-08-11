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
  public class EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInner {
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
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerName Name { get; set; }

    /// <summary>
    /// Gets or Sets Emails
    /// </summary>
    [DataMember(Name="emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emails")]
    public List<EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerEmailsInner> Emails { get; set; }

    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerGroupsInner> Groups { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

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
      sb.Append("class EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInner {\n");
      sb.Append("  Schemas: ").Append(Schemas).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Emails: ").Append(Emails).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
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
