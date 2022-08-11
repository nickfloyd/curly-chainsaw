using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Credential Authorization
  /// </summary>
  [DataContract]
  public class CredentialAuthorization {
    /// <summary>
    /// User login that owns the underlying credential.
    /// </summary>
    /// <value>User login that owns the underlying credential.</value>
    [DataMember(Name="login", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "login")]
    public string Login { get; set; }

    /// <summary>
    /// Unique identifier for the credential.
    /// </summary>
    /// <value>Unique identifier for the credential.</value>
    [DataMember(Name="credential_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credential_id")]
    public int? CredentialId { get; set; }

    /// <summary>
    /// Human-readable description of the credential type.
    /// </summary>
    /// <value>Human-readable description of the credential type.</value>
    [DataMember(Name="credential_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credential_type")]
    public string CredentialType { get; set; }

    /// <summary>
    /// Last eight characters of the credential. Only included in responses with credential_type of personal access token.
    /// </summary>
    /// <value>Last eight characters of the credential. Only included in responses with credential_type of personal access token.</value>
    [DataMember(Name="token_last_eight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token_last_eight")]
    public string TokenLastEight { get; set; }

    /// <summary>
    /// Date when the credential was authorized for use.
    /// </summary>
    /// <value>Date when the credential was authorized for use.</value>
    [DataMember(Name="credential_authorized_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credential_authorized_at")]
    public DateTime? CredentialAuthorizedAt { get; set; }

    /// <summary>
    /// List of oauth scopes the token has been granted.
    /// </summary>
    /// <value>List of oauth scopes the token has been granted.</value>
    [DataMember(Name="scopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scopes")]
    public List<string> Scopes { get; set; }

    /// <summary>
    /// Unique string to distinguish the credential. Only included in responses with credential_type of SSH Key.
    /// </summary>
    /// <value>Unique string to distinguish the credential. Only included in responses with credential_type of SSH Key.</value>
    [DataMember(Name="fingerprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fingerprint")]
    public string Fingerprint { get; set; }

    /// <summary>
    /// Date when the credential was last accessed. May be null if it was never accessed
    /// </summary>
    /// <value>Date when the credential was last accessed. May be null if it was never accessed</value>
    [DataMember(Name="credential_accessed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "credential_accessed_at")]
    public DateTime? CredentialAccessedAt { get; set; }

    /// <summary>
    /// Gets or Sets AuthorizedCredentialId
    /// </summary>
    [DataMember(Name="authorized_credential_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorized_credential_id")]
    public int? AuthorizedCredentialId { get; set; }

    /// <summary>
    /// The title given to the ssh key. This will only be present when the credential is an ssh key.
    /// </summary>
    /// <value>The title given to the ssh key. This will only be present when the credential is an ssh key.</value>
    [DataMember(Name="authorized_credential_title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorized_credential_title")]
    public string AuthorizedCredentialTitle { get; set; }

    /// <summary>
    /// The note given to the token. This will only be present when the credential is a token.
    /// </summary>
    /// <value>The note given to the token. This will only be present when the credential is a token.</value>
    [DataMember(Name="authorized_credential_note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorized_credential_note")]
    public string AuthorizedCredentialNote { get; set; }

    /// <summary>
    /// The expiry for the token. This will only be present when the credential is a token.
    /// </summary>
    /// <value>The expiry for the token. This will only be present when the credential is a token.</value>
    [DataMember(Name="authorized_credential_expires_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authorized_credential_expires_at")]
    public DateTime? AuthorizedCredentialExpiresAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CredentialAuthorization {\n");
      sb.Append("  Login: ").Append(Login).Append("\n");
      sb.Append("  CredentialId: ").Append(CredentialId).Append("\n");
      sb.Append("  CredentialType: ").Append(CredentialType).Append("\n");
      sb.Append("  TokenLastEight: ").Append(TokenLastEight).Append("\n");
      sb.Append("  CredentialAuthorizedAt: ").Append(CredentialAuthorizedAt).Append("\n");
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
      sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
      sb.Append("  CredentialAccessedAt: ").Append(CredentialAccessedAt).Append("\n");
      sb.Append("  AuthorizedCredentialId: ").Append(AuthorizedCredentialId).Append("\n");
      sb.Append("  AuthorizedCredentialTitle: ").Append(AuthorizedCredentialTitle).Append("\n");
      sb.Append("  AuthorizedCredentialNote: ").Append(AuthorizedCredentialNote).Append("\n");
      sb.Append("  AuthorizedCredentialExpiresAt: ").Append(AuthorizedCredentialExpiresAt).Append("\n");
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
