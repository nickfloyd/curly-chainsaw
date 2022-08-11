using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// SCIM /Users provisioning endpoints
  /// </summary>
  [DataContract]
  public class SCIMUsers {
    /// <summary>
    /// SCIM schema used.
    /// </summary>
    /// <value>SCIM schema used.</value>
    [DataMember(Name="schemas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schemas")]
    public List<string> Schemas { get; set; }

    /// <summary>
    /// Unique identifier of an external identity
    /// </summary>
    /// <value>Unique identifier of an external identity</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The ID of the User.
    /// </summary>
    /// <value>The ID of the User.</value>
    [DataMember(Name="externalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalId")]
    public string ExternalId { get; set; }

    /// <summary>
    /// Configured by the admin. Could be an email, login, or username
    /// </summary>
    /// <value>Configured by the admin. Could be an email, login, or username</value>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }

    /// <summary>
    /// The name of the user, suitable for display to end-users
    /// </summary>
    /// <value>The name of the user, suitable for display to end-users</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public SCIMUsersName Name { get; set; }

    /// <summary>
    /// user emails
    /// </summary>
    /// <value>user emails</value>
    [DataMember(Name="emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emails")]
    public List<SCIMUsersEmailsInner> Emails { get; set; }

    /// <summary>
    /// The active status of the User.
    /// </summary>
    /// <value>The active status of the User.</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets Meta
    /// </summary>
    [DataMember(Name="meta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "meta")]
    public SCIMUsersMeta Meta { get; set; }

    /// <summary>
    /// The ID of the organization.
    /// </summary>
    /// <value>The ID of the organization.</value>
    [DataMember(Name="organization_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization_id")]
    public int? OrganizationId { get; set; }

    /// <summary>
    /// Set of operations to be performed
    /// </summary>
    /// <value>Set of operations to be performed</value>
    [DataMember(Name="operations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operations")]
    public List<SCIMUsersOperationsInner> Operations { get; set; }

    /// <summary>
    /// associated groups
    /// </summary>
    /// <value>associated groups</value>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<SCIMUsersGroupsInner> Groups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SCIMUsers {\n");
      sb.Append("  Schemas: ").Append(Schemas).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Emails: ").Append(Emails).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Meta: ").Append(Meta).Append("\n");
      sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
      sb.Append("  Operations: ").Append(Operations).Append("\n");
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
