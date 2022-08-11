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
  public class BillingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown {
    /// <summary>
    /// Total minutes used on Ubuntu runner machines.
    /// </summary>
    /// <value>Total minutes used on Ubuntu runner machines.</value>
    [DataMember(Name="UBUNTU", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UBUNTU")]
    public int? UBUNTU { get; set; }

    /// <summary>
    /// Total minutes used on macOS runner machines.
    /// </summary>
    /// <value>Total minutes used on macOS runner machines.</value>
    [DataMember(Name="MACOS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MACOS")]
    public int? MACOS { get; set; }

    /// <summary>
    /// Total minutes used on Windows runner machines.
    /// </summary>
    /// <value>Total minutes used on Windows runner machines.</value>
    [DataMember(Name="WINDOWS", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WINDOWS")]
    public int? WINDOWS { get; set; }

    /// <summary>
    /// Total minutes used on Ubuntu 4 core runner machines.
    /// </summary>
    /// <value>Total minutes used on Ubuntu 4 core runner machines.</value>
    [DataMember(Name="ubuntu_4_core", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ubuntu_4_core")]
    public int? Ubuntu4Core { get; set; }

    /// <summary>
    /// Total minutes used on Ubuntu 8 core runner machines.
    /// </summary>
    /// <value>Total minutes used on Ubuntu 8 core runner machines.</value>
    [DataMember(Name="ubuntu_8_core", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ubuntu_8_core")]
    public int? Ubuntu8Core { get; set; }

    /// <summary>
    /// Total minutes used on Ubuntu 16 core runner machines.
    /// </summary>
    /// <value>Total minutes used on Ubuntu 16 core runner machines.</value>
    [DataMember(Name="ubuntu_16_core", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ubuntu_16_core")]
    public int? Ubuntu16Core { get; set; }

    /// <summary>
    /// Total minutes used on Ubuntu 32 core runner machines.
    /// </summary>
    /// <value>Total minutes used on Ubuntu 32 core runner machines.</value>
    [DataMember(Name="ubuntu_32_core", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ubuntu_32_core")]
    public int? Ubuntu32Core { get; set; }

    /// <summary>
    /// Total minutes used on Ubuntu 64 core runner machines.
    /// </summary>
    /// <value>Total minutes used on Ubuntu 64 core runner machines.</value>
    [DataMember(Name="ubuntu_64_core", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ubuntu_64_core")]
    public int? Ubuntu64Core { get; set; }

    /// <summary>
    /// Total minutes used on Windows 4 core runner machines.
    /// </summary>
    /// <value>Total minutes used on Windows 4 core runner machines.</value>
    [DataMember(Name="windows_4_core", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "windows_4_core")]
    public int? Windows4Core { get; set; }

    /// <summary>
    /// Total minutes used on Windows 8 core runner machines.
    /// </summary>
    /// <value>Total minutes used on Windows 8 core runner machines.</value>
    [DataMember(Name="windows_8_core", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "windows_8_core")]
    public int? Windows8Core { get; set; }

    /// <summary>
    /// Total minutes used on Windows 16 core runner machines.
    /// </summary>
    /// <value>Total minutes used on Windows 16 core runner machines.</value>
    [DataMember(Name="windows_16_core", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "windows_16_core")]
    public int? Windows16Core { get; set; }

    /// <summary>
    /// Total minutes used on Windows 32 core runner machines.
    /// </summary>
    /// <value>Total minutes used on Windows 32 core runner machines.</value>
    [DataMember(Name="windows_32_core", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "windows_32_core")]
    public int? Windows32Core { get; set; }

    /// <summary>
    /// Total minutes used on Windows 64 core runner machines.
    /// </summary>
    /// <value>Total minutes used on Windows 64 core runner machines.</value>
    [DataMember(Name="windows_64_core", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "windows_64_core")]
    public int? Windows64Core { get; set; }

    /// <summary>
    /// Total minutes used on all runner machines.
    /// </summary>
    /// <value>Total minutes used on all runner machines.</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingGetGithubActionsBillingGhe200ResponseMinutesUsedBreakdown {\n");
      sb.Append("  UBUNTU: ").Append(UBUNTU).Append("\n");
      sb.Append("  MACOS: ").Append(MACOS).Append("\n");
      sb.Append("  WINDOWS: ").Append(WINDOWS).Append("\n");
      sb.Append("  Ubuntu4Core: ").Append(Ubuntu4Core).Append("\n");
      sb.Append("  Ubuntu8Core: ").Append(Ubuntu8Core).Append("\n");
      sb.Append("  Ubuntu16Core: ").Append(Ubuntu16Core).Append("\n");
      sb.Append("  Ubuntu32Core: ").Append(Ubuntu32Core).Append("\n");
      sb.Append("  Ubuntu64Core: ").Append(Ubuntu64Core).Append("\n");
      sb.Append("  Windows4Core: ").Append(Windows4Core).Append("\n");
      sb.Append("  Windows8Core: ").Append(Windows8Core).Append("\n");
      sb.Append("  Windows16Core: ").Append(Windows16Core).Append("\n");
      sb.Append("  Windows32Core: ").Append(Windows32Core).Append("\n");
      sb.Append("  Windows64Core: ").Append(Windows64Core).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
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
