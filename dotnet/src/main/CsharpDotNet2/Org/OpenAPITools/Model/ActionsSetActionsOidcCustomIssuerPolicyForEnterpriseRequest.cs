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
  public class ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest {
    /// <summary>
    /// Whether the enterprise customer requested a custom issuer URL.
    /// </summary>
    /// <value>Whether the enterprise customer requested a custom issuer URL.</value>
    [DataMember(Name="include_enterprise_slug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "include_enterprise_slug")]
    public bool? IncludeEnterpriseSlug { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionsSetActionsOidcCustomIssuerPolicyForEnterpriseRequest {\n");
      sb.Append("  IncludeEnterpriseSlug: ").Append(IncludeEnterpriseSlug).Append("\n");
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
