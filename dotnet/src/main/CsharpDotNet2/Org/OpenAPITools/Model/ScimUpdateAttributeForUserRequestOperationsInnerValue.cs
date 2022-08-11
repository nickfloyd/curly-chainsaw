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
  public class ScimUpdateAttributeForUserRequestOperationsInnerValue {
    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }

    /// <summary>
    /// Gets or Sets ExternalId
    /// </summary>
    [DataMember(Name="externalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalId")]
    public string ExternalId { get; set; }

    /// <summary>
    /// Gets or Sets GivenName
    /// </summary>
    [DataMember(Name="givenName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "givenName")]
    public string GivenName { get; set; }

    /// <summary>
    /// Gets or Sets FamilyName
    /// </summary>
    [DataMember(Name="familyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "familyName")]
    public string FamilyName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScimUpdateAttributeForUserRequestOperationsInnerValue {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  GivenName: ").Append(GivenName).Append("\n");
      sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
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
