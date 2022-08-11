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
  public class AppsListReposAccessibleToInstallation200Response {
    /// <summary>
    /// Gets or Sets TotalCount
    /// </summary>
    [DataMember(Name="total_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_count")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Gets or Sets Repositories
    /// </summary>
    [DataMember(Name="repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositories")]
    public List<Repository> Repositories { get; set; }

    /// <summary>
    /// Gets or Sets RepositorySelection
    /// </summary>
    [DataMember(Name="repository_selection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_selection")]
    public string RepositorySelection { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppsListReposAccessibleToInstallation200Response {\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  Repositories: ").Append(Repositories).Append("\n");
      sb.Append("  RepositorySelection: ").Append(RepositorySelection).Append("\n");
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
