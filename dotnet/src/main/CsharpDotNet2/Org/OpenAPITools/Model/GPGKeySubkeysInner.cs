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
  public class GPGKeySubkeysInner {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryKeyId
    /// </summary>
    [DataMember(Name="primary_key_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primary_key_id")]
    public int? PrimaryKeyId { get; set; }

    /// <summary>
    /// Gets or Sets KeyId
    /// </summary>
    [DataMember(Name="key_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key_id")]
    public string KeyId { get; set; }

    /// <summary>
    /// Gets or Sets PublicKey
    /// </summary>
    [DataMember(Name="public_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public_key")]
    public string PublicKey { get; set; }

    /// <summary>
    /// Gets or Sets Emails
    /// </summary>
    [DataMember(Name="emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emails")]
    public List<Object> Emails { get; set; }

    /// <summary>
    /// Gets or Sets Subkeys
    /// </summary>
    [DataMember(Name="subkeys", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subkeys")]
    public List<Object> Subkeys { get; set; }

    /// <summary>
    /// Gets or Sets CanSign
    /// </summary>
    [DataMember(Name="can_sign", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "can_sign")]
    public bool? CanSign { get; set; }

    /// <summary>
    /// Gets or Sets CanEncryptComms
    /// </summary>
    [DataMember(Name="can_encrypt_comms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "can_encrypt_comms")]
    public bool? CanEncryptComms { get; set; }

    /// <summary>
    /// Gets or Sets CanEncryptStorage
    /// </summary>
    [DataMember(Name="can_encrypt_storage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "can_encrypt_storage")]
    public bool? CanEncryptStorage { get; set; }

    /// <summary>
    /// Gets or Sets CanCertify
    /// </summary>
    [DataMember(Name="can_certify", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "can_certify")]
    public bool? CanCertify { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets ExpiresAt
    /// </summary>
    [DataMember(Name="expires_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires_at")]
    public string ExpiresAt { get; set; }

    /// <summary>
    /// Gets or Sets RawKey
    /// </summary>
    [DataMember(Name="raw_key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "raw_key")]
    public string RawKey { get; set; }

    /// <summary>
    /// Gets or Sets Revoked
    /// </summary>
    [DataMember(Name="revoked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revoked")]
    public bool? Revoked { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GPGKeySubkeysInner {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PrimaryKeyId: ").Append(PrimaryKeyId).Append("\n");
      sb.Append("  KeyId: ").Append(KeyId).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
      sb.Append("  Emails: ").Append(Emails).Append("\n");
      sb.Append("  Subkeys: ").Append(Subkeys).Append("\n");
      sb.Append("  CanSign: ").Append(CanSign).Append("\n");
      sb.Append("  CanEncryptComms: ").Append(CanEncryptComms).Append("\n");
      sb.Append("  CanEncryptStorage: ").Append(CanEncryptStorage).Append("\n");
      sb.Append("  CanCertify: ").Append(CanCertify).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("  RawKey: ").Append(RawKey).Append("\n");
      sb.Append("  Revoked: ").Append(Revoked).Append("\n");
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
