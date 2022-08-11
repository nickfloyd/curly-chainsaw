using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// The configuration for GitHub Pages for a repository.
  /// </summary>
  [DataContract]
  public class GitHubPages {
    /// <summary>
    /// The API address for accessing this Page resource.
    /// </summary>
    /// <value>The API address for accessing this Page resource.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// The status of the most recent build of the Page.
    /// </summary>
    /// <value>The status of the most recent build of the Page.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The Pages site's custom domain
    /// </summary>
    /// <value>The Pages site's custom domain</value>
    [DataMember(Name="cname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cname")]
    public string Cname { get; set; }

    /// <summary>
    /// The state if the domain is verified
    /// </summary>
    /// <value>The state if the domain is verified</value>
    [DataMember(Name="protected_domain_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protected_domain_state")]
    public string ProtectedDomainState { get; set; }

    /// <summary>
    /// The timestamp when a pending domain becomes unverified.
    /// </summary>
    /// <value>The timestamp when a pending domain becomes unverified.</value>
    [DataMember(Name="pending_domain_unverified_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pending_domain_unverified_at")]
    public DateTime? PendingDomainUnverifiedAt { get; set; }

    /// <summary>
    /// Whether the Page has a custom 404 page.
    /// </summary>
    /// <value>Whether the Page has a custom 404 page.</value>
    [DataMember(Name="custom_404", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "custom_404")]
    public bool? Custom404 { get; set; }

    /// <summary>
    /// The web address the Page can be accessed from.
    /// </summary>
    /// <value>The web address the Page can be accessed from.</value>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// The process in which the Page will be built.
    /// </summary>
    /// <value>The process in which the Page will be built.</value>
    [DataMember(Name="build_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "build_type")]
    public string BuildType { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public PagesSourceHash Source { get; set; }

    /// <summary>
    /// Whether the GitHub Pages site is publicly visible. If set to `true`, the site is accessible to anyone on the internet. If set to `false`, the site will only be accessible to users who have at least `read` access to the repository that published the site.
    /// </summary>
    /// <value>Whether the GitHub Pages site is publicly visible. If set to `true`, the site is accessible to anyone on the internet. If set to `false`, the site will only be accessible to users who have at least `read` access to the repository that published the site.</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public bool? Public { get; set; }

    /// <summary>
    /// Gets or Sets HttpsCertificate
    /// </summary>
    [DataMember(Name="https_certificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "https_certificate")]
    public PagesHttpsCertificate HttpsCertificate { get; set; }

    /// <summary>
    /// Whether https is enabled on the domain
    /// </summary>
    /// <value>Whether https is enabled on the domain</value>
    [DataMember(Name="https_enforced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "https_enforced")]
    public bool? HttpsEnforced { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GitHubPages {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Cname: ").Append(Cname).Append("\n");
      sb.Append("  ProtectedDomainState: ").Append(ProtectedDomainState).Append("\n");
      sb.Append("  PendingDomainUnverifiedAt: ").Append(PendingDomainUnverifiedAt).Append("\n");
      sb.Append("  Custom404: ").Append(Custom404).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  BuildType: ").Append(BuildType).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Public: ").Append(Public).Append("\n");
      sb.Append("  HttpsCertificate: ").Append(HttpsCertificate).Append("\n");
      sb.Append("  HttpsEnforced: ").Append(HttpsEnforced).Append("\n");
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
