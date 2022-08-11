using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// A description of the machine powering a codespace.
  /// </summary>
  [DataContract]
  public class CodespaceMachine {
    /// <summary>
    /// The name of the machine.
    /// </summary>
    /// <value>The name of the machine.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The display name of the machine includes cores, memory, and storage.
    /// </summary>
    /// <value>The display name of the machine includes cores, memory, and storage.</value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The operating system of the machine.
    /// </summary>
    /// <value>The operating system of the machine.</value>
    [DataMember(Name="operating_system", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operating_system")]
    public string OperatingSystem { get; set; }

    /// <summary>
    /// How much storage is available to the codespace.
    /// </summary>
    /// <value>How much storage is available to the codespace.</value>
    [DataMember(Name="storage_in_bytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storage_in_bytes")]
    public int? StorageInBytes { get; set; }

    /// <summary>
    /// How much memory is available to the codespace.
    /// </summary>
    /// <value>How much memory is available to the codespace.</value>
    [DataMember(Name="memory_in_bytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memory_in_bytes")]
    public int? MemoryInBytes { get; set; }

    /// <summary>
    /// How many cores are available to the codespace.
    /// </summary>
    /// <value>How many cores are available to the codespace.</value>
    [DataMember(Name="cpus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cpus")]
    public int? Cpus { get; set; }

    /// <summary>
    /// Whether a prebuild is currently available when creating a codespace for this machine and repository. If a branch was not specified as a ref, the default branch will be assumed. Value will be \"null\" if prebuilds are not supported or prebuild availability could not be determined. Value will be \"none\" if no prebuild is available. Latest values \"ready\" and \"in_progress\" indicate the prebuild availability status.
    /// </summary>
    /// <value>Whether a prebuild is currently available when creating a codespace for this machine and repository. If a branch was not specified as a ref, the default branch will be assumed. Value will be \"null\" if prebuilds are not supported or prebuild availability could not be determined. Value will be \"none\" if no prebuild is available. Latest values \"ready\" and \"in_progress\" indicate the prebuild availability status.</value>
    [DataMember(Name="prebuild_availability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prebuild_availability")]
    public string PrebuildAvailability { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodespaceMachine {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  OperatingSystem: ").Append(OperatingSystem).Append("\n");
      sb.Append("  StorageInBytes: ").Append(StorageInBytes).Append("\n");
      sb.Append("  MemoryInBytes: ").Append(MemoryInBytes).Append("\n");
      sb.Append("  Cpus: ").Append(Cpus).Append("\n");
      sb.Append("  PrebuildAvailability: ").Append(PrebuildAvailability).Append("\n");
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
