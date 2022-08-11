using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Pull Request Review Request
  /// </summary>
  [DataContract]
  public class PullRequestReviewRequest {
    /// <summary>
    /// Gets or Sets Users
    /// </summary>
    [DataMember(Name="users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "users")]
    public List<SimpleUser1> Users { get; set; }

    /// <summary>
    /// Gets or Sets Teams
    /// </summary>
    [DataMember(Name="teams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teams")]
    public List<Team> Teams { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PullRequestReviewRequest {\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
      sb.Append("  Teams: ").Append(Teams).Append("\n");
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
