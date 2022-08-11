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
  public class DependabotCreateOrUpdateOrgSecretRequest {
    /// <summary>
    /// Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get an organization public key](https://docs.github.com/rest/reference/dependabot#get-an-organization-public-key) endpoint.
    /// </summary>
    /// <value>Value for your secret, encrypted with [LibSodium](https://libsodium.gitbook.io/doc/bindings_for_other_languages) using the public key retrieved from the [Get an organization public key](https://docs.github.com/rest/reference/dependabot#get-an-organization-public-key) endpoint.</value>
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
    /// Which type of organization repositories have access to the organization secret. `selected` means only the repositories specified by `selected_repository_ids` can access the secret.
    /// </summary>
    /// <value>Which type of organization repositories have access to the organization secret. `selected` means only the repositories specified by `selected_repository_ids` can access the secret.</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public string Visibility { get; set; }

    /// <summary>
    /// An array of repository ids that can access the organization secret. You can only provide a list of repository ids when the `visibility` is set to `selected`. You can manage the list of selected repositories using the [List selected repositories for an organization secret](https://docs.github.com/rest/reference/dependabot#list-selected-repositories-for-an-organization-secret), [Set selected repositories for an organization secret](https://docs.github.com/rest/reference/dependabot#set-selected-repositories-for-an-organization-secret), and [Remove selected repository from an organization secret](https://docs.github.com/rest/reference/dependabot#remove-selected-repository-from-an-organization-secret) endpoints.
    /// </summary>
    /// <value>An array of repository ids that can access the organization secret. You can only provide a list of repository ids when the `visibility` is set to `selected`. You can manage the list of selected repositories using the [List selected repositories for an organization secret](https://docs.github.com/rest/reference/dependabot#list-selected-repositories-for-an-organization-secret), [Set selected repositories for an organization secret](https://docs.github.com/rest/reference/dependabot#set-selected-repositories-for-an-organization-secret), and [Remove selected repository from an organization secret](https://docs.github.com/rest/reference/dependabot#remove-selected-repository-from-an-organization-secret) endpoints.</value>
    [DataMember(Name="selected_repository_ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selected_repository_ids")]
    public List<string> SelectedRepositoryIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DependabotCreateOrUpdateOrgSecretRequest {\n");
      sb.Append("  EncryptedValue: ").Append(EncryptedValue).Append("\n");
      sb.Append("  KeyId: ").Append(KeyId).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  SelectedRepositoryIds: ").Append(SelectedRepositoryIds).Append("\n");
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
