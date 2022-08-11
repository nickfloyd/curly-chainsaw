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
  public class EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMembersInner {
    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Gets or Sets Ref
    /// </summary>
    [DataMember(Name="$ref", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "$ref")]
    public string Ref { get; set; }

    /// <summary>
    /// Gets or Sets Display
    /// </summary>
    [DataMember(Name="display", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display")]
    public string Display { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMembersInner {\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Ref: ").Append(Ref).Append("\n");
      sb.Append("  Display: ").Append(Display).Append("\n");
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
