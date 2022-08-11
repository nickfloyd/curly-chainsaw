using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Pull request number for this codespace
  /// </summary>
  [DataContract]
  public class CodespacesCreateForAuthenticatedUserRequestOneOf1PullRequest {
    /// <summary>
    /// Pull request number
    /// </summary>
    /// <value>Pull request number</value>
    [DataMember(Name="pull_request_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pull_request_number")]
    public int? PullRequestNumber { get; set; }

    /// <summary>
    /// Repository id for this codespace
    /// </summary>
    /// <value>Repository id for this codespace</value>
    [DataMember(Name="repository_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_id")]
    public int? RepositoryId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodespacesCreateForAuthenticatedUserRequestOneOf1PullRequest {\n");
      sb.Append("  PullRequestNumber: ").Append(PullRequestNumber).Append("\n");
      sb.Append("  RepositoryId: ").Append(RepositoryId).Append("\n");
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
