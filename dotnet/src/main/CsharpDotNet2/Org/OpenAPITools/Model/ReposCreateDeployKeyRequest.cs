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
  public class ReposCreateDeployKeyRequest {
    /// <summary>
    /// A name for the key.
    /// </summary>
    /// <value>A name for the key.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The contents of the key.
    /// </summary>
    /// <value>The contents of the key.</value>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public string Key { get; set; }

    /// <summary>
    /// If `true`, the key will only be able to read repository contents. Otherwise, the key will be able to read and write.      Deploy keys with write access can perform the same actions as an organization member with admin access, or a collaborator on a personal repository. For more information, see \"[Repository permission levels for an organization](https://docs.github.com/articles/repository-permission-levels-for-an-organization/)\" and \"[Permission levels for a user account repository](https://docs.github.com/articles/permission-levels-for-a-user-account-repository/).\"
    /// </summary>
    /// <value>If `true`, the key will only be able to read repository contents. Otherwise, the key will be able to read and write.      Deploy keys with write access can perform the same actions as an organization member with admin access, or a collaborator on a personal repository. For more information, see \"[Repository permission levels for an organization](https://docs.github.com/articles/repository-permission-levels-for-an-organization/)\" and \"[Permission levels for a user account repository](https://docs.github.com/articles/permission-levels-for-a-user-account-repository/).\"</value>
    [DataMember(Name="read_only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "read_only")]
    public bool? ReadOnly { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreateDeployKeyRequest {\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
      sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
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
