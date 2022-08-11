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
  public class IssuesLockRequest {
    /// <summary>
    /// The reason for locking the issue or pull request conversation. Lock will fail if you don't use one of these reasons:   \\* `off-topic`   \\* `too heated`   \\* `resolved`   \\* `spam`
    /// </summary>
    /// <value>The reason for locking the issue or pull request conversation. Lock will fail if you don't use one of these reasons:   \\* `off-topic`   \\* `too heated`   \\* `resolved`   \\* `spam`</value>
    [DataMember(Name="lock_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lock_reason")]
    public string LockReason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssuesLockRequest {\n");
      sb.Append("  LockReason: ").Append(LockReason).Append("\n");
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
