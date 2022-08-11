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
  public class SCIMUsersOperationsInner {
    /// <summary>
    /// Gets or Sets Op
    /// </summary>
    [DataMember(Name="op", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "op")]
    public string Op { get; set; }

    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public SCIMUsersOperationsInnerValue Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SCIMUsersOperationsInner {\n");
      sb.Append("  Op: ").Append(Op).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
