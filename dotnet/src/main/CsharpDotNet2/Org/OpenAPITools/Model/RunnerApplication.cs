using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Runner Application
  /// </summary>
  [DataContract]
  public class RunnerApplication {
    /// <summary>
    /// Gets or Sets Os
    /// </summary>
    [DataMember(Name="os", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "os")]
    public string Os { get; set; }

    /// <summary>
    /// Gets or Sets Architecture
    /// </summary>
    [DataMember(Name="architecture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "architecture")]
    public string Architecture { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    [DataMember(Name="download_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "download_url")]
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets Filename
    /// </summary>
    [DataMember(Name="filename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filename")]
    public string Filename { get; set; }

    /// <summary>
    /// A short lived bearer token used to download the runner, if needed.
    /// </summary>
    /// <value>A short lived bearer token used to download the runner, if needed.</value>
    [DataMember(Name="temp_download_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "temp_download_token")]
    public string TempDownloadToken { get; set; }

    /// <summary>
    /// Gets or Sets Sha256Checksum
    /// </summary>
    [DataMember(Name="sha256_checksum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sha256_checksum")]
    public string Sha256Checksum { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RunnerApplication {\n");
      sb.Append("  Os: ").Append(Os).Append("\n");
      sb.Append("  Architecture: ").Append(Architecture).Append("\n");
      sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
      sb.Append("  Filename: ").Append(Filename).Append("\n");
      sb.Append("  TempDownloadToken: ").Append(TempDownloadToken).Append("\n");
      sb.Append("  Sha256Checksum: ").Append(Sha256Checksum).Append("\n");
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
