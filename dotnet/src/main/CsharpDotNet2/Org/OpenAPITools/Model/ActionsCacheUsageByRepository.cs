using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// GitHub Actions Cache Usage by repository.
  /// </summary>
  [DataContract]
  public class ActionsCacheUsageByRepository {
    /// <summary>
    /// The repository owner and name for the cache usage being shown.
    /// </summary>
    /// <value>The repository owner and name for the cache usage being shown.</value>
    [DataMember(Name="full_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "full_name")]
    public string FullName { get; set; }

    /// <summary>
    /// The sum of the size in bytes of all the active cache items in the repository.
    /// </summary>
    /// <value>The sum of the size in bytes of all the active cache items in the repository.</value>
    [DataMember(Name="active_caches_size_in_bytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active_caches_size_in_bytes")]
    public int? ActiveCachesSizeInBytes { get; set; }

    /// <summary>
    /// The number of active caches in the repository.
    /// </summary>
    /// <value>The number of active caches in the repository.</value>
    [DataMember(Name="active_caches_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active_caches_count")]
    public int? ActiveCachesCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionsCacheUsageByRepository {\n");
      sb.Append("  FullName: ").Append(FullName).Append("\n");
      sb.Append("  ActiveCachesSizeInBytes: ").Append(ActiveCachesSizeInBytes).Append("\n");
      sb.Append("  ActiveCachesCount: ").Append(ActiveCachesCount).Append("\n");
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
