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
  public class ActionsCreateOrUpdateEnvironmentSecretRequest {
    /// <summary>
    /// Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get an environment public key](https://docs.github.com/rest/reference/actions#get-an-environment-public-key) endpoint.
    /// </summary>
    /// <value>Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get an environment public key](https://docs.github.com/rest/reference/actions#get-an-environment-public-key) endpoint.</value>
    [DataMember(Name="encrypted_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "encrypted_value")]
    public string EncryptedValue { get; set; }

    /// <summary>
    /// ID of the key you used to encrypt the secret.
    /// </summary>
    /// <value>ID of the key you used to encrypt the secret.</value>
    [DataMember(Name="key_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key_id")]
    public string KeyId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionsCreateOrUpdateEnvironmentSecretRequest {\n");
      sb.Append("  EncryptedValue: ").Append(EncryptedValue).Append("\n");
      sb.Append("  KeyId: ").Append(KeyId).Append("\n");
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
