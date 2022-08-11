using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Repository actions caches
  /// </summary>
  [DataContract]
  public class RepositoryActionsCaches {
    /// <summary>
    /// Total number of caches
    /// </summary>
    /// <value>Total number of caches</value>
    [DataMember(Name="total_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_count")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Array of caches
    /// </summary>
    /// <value>Array of caches</value>
    [DataMember(Name="actions_caches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actions_caches")]
    public List<RepositoryActionsCachesActionsCachesInner> ActionsCaches { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RepositoryActionsCaches {\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  ActionsCaches: ").Append(ActionsCaches).Append("\n");
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
