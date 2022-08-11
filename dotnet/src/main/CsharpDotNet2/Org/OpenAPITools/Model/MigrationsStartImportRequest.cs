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
  public class MigrationsStartImportRequest {
    /// <summary>
    /// The URL of the originating repository.
    /// </summary>
    /// <value>The URL of the originating repository.</value>
    [DataMember(Name="vcs_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vcs_url")]
    public string VcsUrl { get; set; }

    /// <summary>
    /// The originating VCS type. Without this parameter, the import job will take additional time to detect the VCS type before beginning the import. This detection step will be reflected in the response.
    /// </summary>
    /// <value>The originating VCS type. Without this parameter, the import job will take additional time to detect the VCS type before beginning the import. This detection step will be reflected in the response.</value>
    [DataMember(Name="vcs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vcs")]
    public string Vcs { get; set; }

    /// <summary>
    /// If authentication is required, the username to provide to `vcs_url`.
    /// </summary>
    /// <value>If authentication is required, the username to provide to `vcs_url`.</value>
    [DataMember(Name="vcs_username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vcs_username")]
    public string VcsUsername { get; set; }

    /// <summary>
    /// If authentication is required, the password to provide to `vcs_url`.
    /// </summary>
    /// <value>If authentication is required, the password to provide to `vcs_url`.</value>
    [DataMember(Name="vcs_password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vcs_password")]
    public string VcsPassword { get; set; }

    /// <summary>
    /// For a tfvc import, the name of the project that is being imported.
    /// </summary>
    /// <value>For a tfvc import, the name of the project that is being imported.</value>
    [DataMember(Name="tfvc_project", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tfvc_project")]
    public string TfvcProject { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MigrationsStartImportRequest {\n");
      sb.Append("  VcsUrl: ").Append(VcsUrl).Append("\n");
      sb.Append("  Vcs: ").Append(Vcs).Append("\n");
      sb.Append("  VcsUsername: ").Append(VcsUsername).Append("\n");
      sb.Append("  VcsPassword: ").Append(VcsPassword).Append("\n");
      sb.Append("  TfvcProject: ").Append(TfvcProject).Append("\n");
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
