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
  public class TeamsCreateDiscussionCommentInOrgRequest {
    /// <summary>
    /// The discussion comment's body text.
    /// </summary>
    /// <value>The discussion comment's body text.</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public string Body { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TeamsCreateDiscussionCommentInOrgRequest {\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
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
