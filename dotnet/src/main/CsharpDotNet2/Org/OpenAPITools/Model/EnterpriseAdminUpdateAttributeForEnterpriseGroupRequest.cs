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
  public class EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest {
    /// <summary>
    /// The SCIM schema URIs.
    /// </summary>
    /// <value>The SCIM schema URIs.</value>
    [DataMember(Name="schemas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schemas")]
    public List<string> Schemas { get; set; }

    /// <summary>
    /// Array of [SCIM operations](https://tools.ietf.org/html/rfc7644#section-3.5.2).
    /// </summary>
    /// <value>Array of [SCIM operations](https://tools.ietf.org/html/rfc7644#section-3.5.2).</value>
    [DataMember(Name="Operations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Operations")]
    public List<EnterpriseAdminUpdateAttributeForEnterpriseGroupRequestOperationsInner> Operations { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnterpriseAdminUpdateAttributeForEnterpriseGroupRequest {\n");
      sb.Append("  Schemas: ").Append(Schemas).Append("\n");
      sb.Append("  Operations: ").Append(Operations).Append("\n");
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
