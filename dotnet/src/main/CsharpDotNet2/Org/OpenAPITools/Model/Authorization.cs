using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The authorization for an OAuth app, GitHub App, or a Personal Access Token.
  /// </summary>
  [DataContract]
  public class Authorization {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// A list of scopes that this authorization is in.
    /// </summary>
    /// <value>A list of scopes that this authorization is in.</value>
    [DataMember(Name="scopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scopes")]
    public List<string> Scopes { get; set; }

    /// <summary>
    /// Gets or Sets Token
    /// </summary>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// Gets or Sets TokenLastEight
    /// </summary>
    [DataMember(Name="token_last_eight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token_last_eight")]
    public string TokenLastEight { get; set; }

    /// <summary>
    /// Gets or Sets HashedToken
    /// </summary>
    [DataMember(Name="hashed_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hashed_token")]
    public string HashedToken { get; set; }

    /// <summary>
    /// Gets or Sets App
    /// </summary>
    [DataMember(Name="app", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "app")]
    public AuthorizationApp App { get; set; }

    /// <summary>
    /// Gets or Sets Note
    /// </summary>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// Gets or Sets NoteUrl
    /// </summary>
    [DataMember(Name="note_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note_url")]
    public string NoteUrl { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Fingerprint
    /// </summary>
    [DataMember(Name="fingerprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fingerprint")]
    public string Fingerprint { get; set; }

    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public SimpleUser User { get; set; }

    /// <summary>
    /// Gets or Sets Installation
    /// </summary>
    [DataMember(Name="installation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "installation")]
    public ScopedInstallation Installation { get; set; }

    /// <summary>
    /// Gets or Sets ExpiresAt
    /// </summary>
    [DataMember(Name="expires_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires_at")]
    public DateTime? ExpiresAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Authorization {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  TokenLastEight: ").Append(TokenLastEight).Append("\n");
      sb.Append("  HashedToken: ").Append(HashedToken).Append("\n");
      sb.Append("  App: ").Append(App).Append("\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  NoteUrl: ").Append(NoteUrl).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  Installation: ").Append(Installation).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
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
