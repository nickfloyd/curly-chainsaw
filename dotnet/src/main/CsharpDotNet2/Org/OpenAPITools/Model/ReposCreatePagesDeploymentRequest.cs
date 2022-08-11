using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The object used to create GitHub Pages deployment
  /// </summary>
  [DataContract]
  public class ReposCreatePagesDeploymentRequest {
    /// <summary>
    /// The URL of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository.
    /// </summary>
    /// <value>The URL of an artifact that contains the .zip or .tar of static assets to deploy. The artifact belongs to the repository.</value>
    [DataMember(Name="artifact_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifact_url")]
    public string ArtifactUrl { get; set; }

    /// <summary>
    /// The target environment for this GitHub Pages deployment.
    /// </summary>
    /// <value>The target environment for this GitHub Pages deployment.</value>
    [DataMember(Name="environment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "environment")]
    public string Environment { get; set; }

    /// <summary>
    /// A unique string that represents the version of the build for this deployment.
    /// </summary>
    /// <value>A unique string that represents the version of the build for this deployment.</value>
    [DataMember(Name="pages_build_version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pages_build_version")]
    public string PagesBuildVersion { get; set; }

    /// <summary>
    /// The OIDC token issued by GitHub Actions certifying the origin of the deployment.
    /// </summary>
    /// <value>The OIDC token issued by GitHub Actions certifying the origin of the deployment.</value>
    [DataMember(Name="oidc_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oidc_token")]
    public string OidcToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposCreatePagesDeploymentRequest {\n");
      sb.Append("  ArtifactUrl: ").Append(ArtifactUrl).Append("\n");
      sb.Append("  Environment: ").Append(Environment).Append("\n");
      sb.Append("  PagesBuildVersion: ").Append(PagesBuildVersion).Append("\n");
      sb.Append("  OidcToken: ").Append(OidcToken).Append("\n");
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
