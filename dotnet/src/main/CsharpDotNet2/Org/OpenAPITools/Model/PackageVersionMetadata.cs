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
  public class PackageVersionMetadata {
    /// <summary>
    /// Gets or Sets PackageType
    /// </summary>
    [DataMember(Name="package_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "package_type")]
    public string PackageType { get; set; }

    /// <summary>
    /// Gets or Sets Container
    /// </summary>
    [DataMember(Name="container", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "container")]
    public ContainerMetadata Container { get; set; }

    /// <summary>
    /// Gets or Sets Docker
    /// </summary>
    [DataMember(Name="docker", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "docker")]
    public DockerMetadata Docker { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PackageVersionMetadata {\n");
      sb.Append("  PackageType: ").Append(PackageType).Append("\n");
      sb.Append("  Container: ").Append(Container).Append("\n");
      sb.Append("  Docker: ").Append(Docker).Append("\n");
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
