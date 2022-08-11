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
  public class CodespacesUpdateForAuthenticatedUserRequest {
    /// <summary>
    /// A valid machine to transition this codespace to.
    /// </summary>
    /// <value>A valid machine to transition this codespace to.</value>
    [DataMember(Name="machine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "machine")]
    public string Machine { get; set; }

    /// <summary>
    /// Display name for this codespace
    /// </summary>
    /// <value>Display name for this codespace</value>
    [DataMember(Name="display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "display_name")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Recently opened folders inside the codespace. It is currently used by the clients to determine the folder path to load the codespace in.
    /// </summary>
    /// <value>Recently opened folders inside the codespace. It is currently used by the clients to determine the folder path to load the codespace in.</value>
    [DataMember(Name="recent_folders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recent_folders")]
    public List<string> RecentFolders { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodespacesUpdateForAuthenticatedUserRequest {\n");
      sb.Append("  Machine: ").Append(Machine).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  RecentFolders: ").Append(RecentFolders).Append("\n");
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
