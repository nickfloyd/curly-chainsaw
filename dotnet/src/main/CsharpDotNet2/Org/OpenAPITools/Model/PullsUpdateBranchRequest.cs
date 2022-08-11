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
  public class PullsUpdateBranchRequest {
    /// <summary>
    /// The expected SHA of the pull request's HEAD ref. This is the most recent commit on the pull request's branch. If the expected SHA does not match the pull request's HEAD, you will receive a `422 Unprocessable Entity` status. You can use the \"[List commits](https://docs.github.com/rest/reference/repos#list-commits)\" endpoint to find the most recent commit SHA. Default: SHA of the pull request's current HEAD ref.
    /// </summary>
    /// <value>The expected SHA of the pull request's HEAD ref. This is the most recent commit on the pull request's branch. If the expected SHA does not match the pull request's HEAD, you will receive a `422 Unprocessable Entity` status. You can use the \"[List commits](https://docs.github.com/rest/reference/repos#list-commits)\" endpoint to find the most recent commit SHA. Default: SHA of the pull request's current HEAD ref.</value>
    [DataMember(Name="expected_head_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expected_head_sha")]
    public string ExpectedHeadSha { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PullsUpdateBranchRequest {\n");
      sb.Append("  ExpectedHeadSha: ").Append(ExpectedHeadSha).Append("\n");
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
