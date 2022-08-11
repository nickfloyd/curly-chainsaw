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
  public class EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta {
    /// <summary>
    /// Gets or Sets ResourceType
    /// </summary>
    [DataMember(Name="resourceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceType")]
    public string ResourceType { get; set; }

    /// <summary>
    /// Gets or Sets Created
    /// </summary>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public string Created { get; set; }

    /// <summary>
    /// Gets or Sets LastModified
    /// </summary>
    [DataMember(Name="lastModified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModified")]
    public string LastModified { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnterpriseAdminListProvisionedGroupsEnterprise200ResponseResourcesInnerMeta {\n");
      sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  LastModified: ").Append(LastModified).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
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
