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
  public class EnterpriseAdminProvisionAndInviteEnterpriseUserRequest {
    /// <summary>
    /// The SCIM schema URIs.
    /// </summary>
    /// <value>The SCIM schema URIs.</value>
    [DataMember(Name="schemas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schemas")]
    public List<string> Schemas { get; set; }

    /// <summary>
    /// The username for the user.
    /// </summary>
    /// <value>The username for the user.</value>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public EnterpriseAdminProvisionAndInviteEnterpriseUserRequestName Name { get; set; }

    /// <summary>
    /// List of user emails.
    /// </summary>
    /// <value>List of user emails.</value>
    [DataMember(Name="emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emails")]
    public List<EnterpriseAdminProvisionAndInviteEnterpriseUserRequestEmailsInner> Emails { get; set; }

    /// <summary>
    /// List of SCIM group IDs the user is a member of.
    /// </summary>
    /// <value>List of SCIM group IDs the user is a member of.</value>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<EnterpriseAdminListProvisionedIdentitiesEnterprise200ResponseResourcesInnerGroupsInner> Groups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnterpriseAdminProvisionAndInviteEnterpriseUserRequest {\n");
      sb.Append("  Schemas: ").Append(Schemas).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Emails: ").Append(Emails).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
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
