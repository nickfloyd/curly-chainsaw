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
  public class ScimSetInformationForProvisionedUserRequest {
    /// <summary>
    /// Gets or Sets Schemas
    /// </summary>
    [DataMember(Name="schemas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schemas")]
    public List<string> Schemas { get; set; }

    /// <summary>
    /// The name of the user, suitable for display to end-users
    /// </summary>
    /// <value>The name of the user, suitable for display to end-users</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ExternalId
    /// </summary>
    [DataMember(Name="externalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalId")]
    public string ExternalId { get; set; }

    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [DataMember(Name="groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groups")]
    public List<string> Groups { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Configured by the admin. Could be an email, login, or username
    /// </summary>
    /// <value>Configured by the admin. Could be an email, login, or username</value>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public ScimProvisionAndInviteUserRequestName Name { get; set; }

    /// <summary>
    /// user emails
    /// </summary>
    /// <value>user emails</value>
    [DataMember(Name="emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emails")]
    public List<ScimSetInformationForProvisionedUserRequestEmailsInner> Emails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScimSetInformationForProvisionedUserRequest {\n");
      sb.Append("  Schemas: ").Append(Schemas).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Emails: ").Append(Emails).Append("\n");
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
