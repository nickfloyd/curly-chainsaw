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
  public class ImportProjectChoicesInner {
    /// <summary>
    /// Gets or Sets Vcs
    /// </summary>
    [DataMember(Name="vcs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vcs")]
    public string Vcs { get; set; }

    /// <summary>
    /// Gets or Sets TfvcProject
    /// </summary>
    [DataMember(Name="tfvc_project", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tfvc_project")]
    public string TfvcProject { get; set; }

    /// <summary>
    /// Gets or Sets HumanName
    /// </summary>
    [DataMember(Name="human_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "human_name")]
    public string HumanName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ImportProjectChoicesInner {\n");
      sb.Append("  Vcs: ").Append(Vcs).Append("\n");
      sb.Append("  TfvcProject: ").Append(TfvcProject).Append("\n");
      sb.Append("  HumanName: ").Append(HumanName).Append("\n");
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
