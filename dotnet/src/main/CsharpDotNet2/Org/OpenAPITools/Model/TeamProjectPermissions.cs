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
  public class TeamProjectPermissions {
    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    [DataMember(Name="read", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "read")]
    public bool? Read { get; set; }

    /// <summary>
    /// Gets or Sets Write
    /// </summary>
    [DataMember(Name="write", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "write")]
    public bool? Write { get; set; }

    /// <summary>
    /// Gets or Sets Admin
    /// </summary>
    [DataMember(Name="admin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "admin")]
    public bool? Admin { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TeamProjectPermissions {\n");
      sb.Append("  Read: ").Append(Read).Append("\n");
      sb.Append("  Write: ").Append(Write).Append("\n");
      sb.Append("  Admin: ").Append(Admin).Append("\n");
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
