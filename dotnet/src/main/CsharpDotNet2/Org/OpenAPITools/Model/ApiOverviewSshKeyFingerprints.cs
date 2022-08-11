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
  public class ApiOverviewSshKeyFingerprints {
    /// <summary>
    /// Gets or Sets SHA256RSA
    /// </summary>
    [DataMember(Name="SHA256_RSA", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SHA256_RSA")]
    public string SHA256RSA { get; set; }

    /// <summary>
    /// Gets or Sets SHA256DSA
    /// </summary>
    [DataMember(Name="SHA256_DSA", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SHA256_DSA")]
    public string SHA256DSA { get; set; }

    /// <summary>
    /// Gets or Sets SHA256ECDSA
    /// </summary>
    [DataMember(Name="SHA256_ECDSA", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SHA256_ECDSA")]
    public string SHA256ECDSA { get; set; }

    /// <summary>
    /// Gets or Sets SHA256ED25519
    /// </summary>
    [DataMember(Name="SHA256_ED25519", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SHA256_ED25519")]
    public string SHA256ED25519 { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApiOverviewSshKeyFingerprints {\n");
      sb.Append("  SHA256RSA: ").Append(SHA256RSA).Append("\n");
      sb.Append("  SHA256DSA: ").Append(SHA256DSA).Append("\n");
      sb.Append("  SHA256ECDSA: ").Append(SHA256ECDSA).Append("\n");
      sb.Append("  SHA256ED25519: ").Append(SHA256ED25519).Append("\n");
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
