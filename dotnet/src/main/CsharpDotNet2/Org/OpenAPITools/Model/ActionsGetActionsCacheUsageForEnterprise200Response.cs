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
  public class ActionsGetActionsCacheUsageForEnterprise200Response {
    /// <summary>
    /// The count of active caches across all repositories of an enterprise or an organization.
    /// </summary>
    /// <value>The count of active caches across all repositories of an enterprise or an organization.</value>
    [DataMember(Name="total_active_caches_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_active_caches_count")]
    public int? TotalActiveCachesCount { get; set; }

    /// <summary>
    /// The total size in bytes of all active cache items across all repositories of an enterprise or an organization.
    /// </summary>
    /// <value>The total size in bytes of all active cache items across all repositories of an enterprise or an organization.</value>
    [DataMember(Name="total_active_caches_size_in_bytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_active_caches_size_in_bytes")]
    public int? TotalActiveCachesSizeInBytes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionsGetActionsCacheUsageForEnterprise200Response {\n");
      sb.Append("  TotalActiveCachesCount: ").Append(TotalActiveCachesCount).Append("\n");
      sb.Append("  TotalActiveCachesSizeInBytes: ").Append(TotalActiveCachesSizeInBytes).Append("\n");
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
