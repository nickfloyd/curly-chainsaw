using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Actions OIDC Subject customization
  /// </summary>
  [DataContract]
  public class ActionsOIDCSubjectCustomization {
    /// <summary>
    /// Gets or Sets IncludeClaimKeys
    /// </summary>
    [DataMember(Name="include_claim_keys", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "include_claim_keys")]
    public List<string> IncludeClaimKeys { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionsOIDCSubjectCustomization {\n");
      sb.Append("  IncludeClaimKeys: ").Append(IncludeClaimKeys).Append("\n");
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
