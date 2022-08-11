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
  public class ReposUpdateInformationAboutPagesSiteRequest {
    /// <summary>
    /// Specify a custom domain for the repository. Sending a `null` value will remove the custom domain. For more about custom domains, see \"[Using a custom domain with GitHub Pages](https://docs.github.com/articles/using-a-custom-domain-with-github-pages/).\"
    /// </summary>
    /// <value>Specify a custom domain for the repository. Sending a `null` value will remove the custom domain. For more about custom domains, see \"[Using a custom domain with GitHub Pages](https://docs.github.com/articles/using-a-custom-domain-with-github-pages/).\"</value>
    [DataMember(Name="cname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cname")]
    public string Cname { get; set; }

    /// <summary>
    /// Specify whether HTTPS should be enforced for the repository.
    /// </summary>
    /// <value>Specify whether HTTPS should be enforced for the repository.</value>
    [DataMember(Name="https_enforced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "https_enforced")]
    public bool? HttpsEnforced { get; set; }

    /// <summary>
    /// Configures access controls for the GitHub Pages site. If public is set to `true`, the site is accessible to anyone on the internet. If set to `false`, the site will only be accessible to users who have at least `read` access to the repository that published the site. This includes anyone in your Enterprise if the repository is set to `internal` visibility. This feature is only available to repositories in an organization on an Enterprise plan.
    /// </summary>
    /// <value>Configures access controls for the GitHub Pages site. If public is set to `true`, the site is accessible to anyone on the internet. If set to `false`, the site will only be accessible to users who have at least `read` access to the repository that published the site. This includes anyone in your Enterprise if the repository is set to `internal` visibility. This feature is only available to repositories in an organization on an Enterprise plan.</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public bool? Public { get; set; }

    /// <summary>
    /// The process by which the GitHub Pages site will be built. `workflow` means that the site is built by a custom GitHub Actions workflow. `legacy` means that the site is built by GitHub when changes are pushed to a specific branch.
    /// </summary>
    /// <value>The process by which the GitHub Pages site will be built. `workflow` means that the site is built by a custom GitHub Actions workflow. `legacy` means that the site is built by GitHub when changes are pushed to a specific branch.</value>
    [DataMember(Name="build_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "build_type")]
    public string BuildType { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public ReposUpdateInformationAboutPagesSiteRequestSource Source { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReposUpdateInformationAboutPagesSiteRequest {\n");
      sb.Append("  Cname: ").Append(Cname).Append("\n");
      sb.Append("  HttpsEnforced: ").Append(HttpsEnforced).Append("\n");
      sb.Append("  Public: ").Append(Public).Append("\n");
      sb.Append("  BuildType: ").Append(BuildType).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
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
