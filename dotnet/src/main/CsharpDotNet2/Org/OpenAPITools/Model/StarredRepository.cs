using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Starred Repository
  /// </summary>
  [DataContract]
  public class StarredRepository {
    /// <summary>
    /// Gets or Sets StarredAt
    /// </summary>
    [DataMember(Name="starred_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "starred_at")]
    public DateTime? StarredAt { get; set; }

    /// <summary>
    /// Gets or Sets Repo
    /// </summary>
    [DataMember(Name="repo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repo")]
    public Repository Repo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StarredRepository {\n");
      sb.Append("  StarredAt: ").Append(StarredAt).Append("\n");
      sb.Append("  Repo: ").Append(Repo).Append("\n");
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
