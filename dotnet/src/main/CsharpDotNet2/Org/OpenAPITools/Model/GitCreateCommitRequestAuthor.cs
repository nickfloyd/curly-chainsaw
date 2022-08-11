using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Information about the author of the commit. By default, the &#x60;author&#x60; will be the authenticated user and the current date. See the &#x60;author&#x60; and &#x60;committer&#x60; object below for details.
  /// </summary>
  [DataContract]
  public class GitCreateCommitRequestAuthor {
    /// <summary>
    /// The name of the author (or committer) of the commit
    /// </summary>
    /// <value>The name of the author (or committer) of the commit</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The email of the author (or committer) of the commit
    /// </summary>
    /// <value>The email of the author (or committer) of the commit</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Indicates when this commit was authored (or committed). This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
    /// </summary>
    /// <value>Indicates when this commit was authored (or committed). This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GitCreateCommitRequestAuthor {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
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
