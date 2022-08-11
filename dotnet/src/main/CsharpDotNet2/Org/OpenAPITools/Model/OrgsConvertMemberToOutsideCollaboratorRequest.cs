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
  public class OrgsConvertMemberToOutsideCollaboratorRequest {
    /// <summary>
    /// When set to `true`, the request will be performed asynchronously. Returns a 202 status code when the job is successfully queued.
    /// </summary>
    /// <value>When set to `true`, the request will be performed asynchronously. Returns a 202 status code when the job is successfully queued.</value>
    [DataMember(Name="async", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "async")]
    public bool? Async { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrgsConvertMemberToOutsideCollaboratorRequest {\n");
      sb.Append("  Async: ").Append(Async).Append("\n");
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
