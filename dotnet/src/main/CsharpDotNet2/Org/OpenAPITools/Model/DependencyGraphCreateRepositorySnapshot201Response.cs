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
  public class DependencyGraphCreateRepositorySnapshot201Response {
    /// <summary>
    /// ID of the created snapshot.
    /// </summary>
    /// <value>ID of the created snapshot.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// The time at which the snapshot was created.
    /// </summary>
    /// <value>The time at which the snapshot was created.</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Either \"SUCCESS\", \"ACCEPTED\", or \"INVALID\". \"SUCCESS\" indicates that the snapshot was successfully created and the repository's dependencies were updated. \"ACCEPTED\" indicates that the snapshot was successfully created, but the repository's dependencies were not updated. \"INVALID\" indicates that the snapshot was malformed.
    /// </summary>
    /// <value>Either \"SUCCESS\", \"ACCEPTED\", or \"INVALID\". \"SUCCESS\" indicates that the snapshot was successfully created and the repository's dependencies were updated. \"ACCEPTED\" indicates that the snapshot was successfully created, but the repository's dependencies were not updated. \"INVALID\" indicates that the snapshot was malformed.</value>
    [DataMember(Name="result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "result")]
    public string Result { get; set; }

    /// <summary>
    /// A message providing further details about the result, such as why the dependencies were not updated.
    /// </summary>
    /// <value>A message providing further details about the result, such as why the dependencies were not updated.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DependencyGraphCreateRepositorySnapshot201Response {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Result: ").Append(Result).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
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
