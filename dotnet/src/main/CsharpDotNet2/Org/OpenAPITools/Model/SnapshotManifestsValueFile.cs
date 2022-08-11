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
  public class SnapshotManifestsValueFile {
    /// <summary>
    /// The path of the manifest file relative to the root of the Git repository.
    /// </summary>
    /// <value>The path of the manifest file relative to the root of the Git repository.</value>
    [DataMember(Name="source_location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source_location")]
    public string SourceLocation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SnapshotManifestsValueFile {\n");
      sb.Append("  SourceLocation: ").Append(SourceLocation).Append("\n");
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
