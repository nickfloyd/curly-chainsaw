using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Authentication Token
  /// </summary>
  [DataContract]
  public class AuthenticationToken {
    /// <summary>
    /// The token used for authentication
    /// </summary>
    /// <value>The token used for authentication</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// The time this token expires
    /// </summary>
    /// <value>The time this token expires</value>
    [DataMember(Name="expires_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expires_at")]
    public DateTime? ExpiresAt { get; set; }

    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [DataMember(Name="permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissions")]
    public Object Permissions { get; set; }

    /// <summary>
    /// The repositories this token has access to
    /// </summary>
    /// <value>The repositories this token has access to</value>
    [DataMember(Name="repositories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repositories")]
    public List<Repository> Repositories { get; set; }

    /// <summary>
    /// Gets or Sets SingleFile
    /// </summary>
    [DataMember(Name="single_file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "single_file")]
    public string SingleFile { get; set; }

    /// <summary>
    /// Describe whether all repositories have been selected or there's a selection involved
    /// </summary>
    /// <value>Describe whether all repositories have been selected or there's a selection involved</value>
    [DataMember(Name="repository_selection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository_selection")]
    public string RepositorySelection { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationToken {\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
      sb.Append("  Repositories: ").Append(Repositories).Append("\n");
      sb.Append("  SingleFile: ").Append(SingleFile).Append("\n");
      sb.Append("  RepositorySelection: ").Append(RepositorySelection).Append("\n");
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
