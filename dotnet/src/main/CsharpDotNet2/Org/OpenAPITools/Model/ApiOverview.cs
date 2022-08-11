using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Api Overview
  /// </summary>
  [DataContract]
  public class ApiOverview {
    /// <summary>
    /// Gets or Sets VerifiablePasswordAuthentication
    /// </summary>
    [DataMember(Name="verifiable_password_authentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verifiable_password_authentication")]
    public bool? VerifiablePasswordAuthentication { get; set; }

    /// <summary>
    /// Gets or Sets SshKeyFingerprints
    /// </summary>
    [DataMember(Name="ssh_key_fingerprints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ssh_key_fingerprints")]
    public ApiOverviewSshKeyFingerprints SshKeyFingerprints { get; set; }

    /// <summary>
    /// Gets or Sets SshKeys
    /// </summary>
    [DataMember(Name="ssh_keys", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ssh_keys")]
    public List<string> SshKeys { get; set; }

    /// <summary>
    /// Gets or Sets Hooks
    /// </summary>
    [DataMember(Name="hooks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hooks")]
    public List<string> Hooks { get; set; }

    /// <summary>
    /// Gets or Sets Web
    /// </summary>
    [DataMember(Name="web", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "web")]
    public List<string> Web { get; set; }

    /// <summary>
    /// Gets or Sets Api
    /// </summary>
    [DataMember(Name="api", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "api")]
    public List<string> Api { get; set; }

    /// <summary>
    /// Gets or Sets Git
    /// </summary>
    [DataMember(Name="git", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "git")]
    public List<string> Git { get; set; }

    /// <summary>
    /// Gets or Sets Packages
    /// </summary>
    [DataMember(Name="packages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "packages")]
    public List<string> Packages { get; set; }

    /// <summary>
    /// Gets or Sets Pages
    /// </summary>
    [DataMember(Name="pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pages")]
    public List<string> Pages { get; set; }

    /// <summary>
    /// Gets or Sets Importer
    /// </summary>
    [DataMember(Name="importer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "importer")]
    public List<string> Importer { get; set; }

    /// <summary>
    /// Gets or Sets Actions
    /// </summary>
    [DataMember(Name="actions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actions")]
    public List<string> Actions { get; set; }

    /// <summary>
    /// Gets or Sets Dependabot
    /// </summary>
    [DataMember(Name="dependabot", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dependabot")]
    public List<string> Dependabot { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApiOverview {\n");
      sb.Append("  VerifiablePasswordAuthentication: ").Append(VerifiablePasswordAuthentication).Append("\n");
      sb.Append("  SshKeyFingerprints: ").Append(SshKeyFingerprints).Append("\n");
      sb.Append("  SshKeys: ").Append(SshKeys).Append("\n");
      sb.Append("  Hooks: ").Append(Hooks).Append("\n");
      sb.Append("  Web: ").Append(Web).Append("\n");
      sb.Append("  Api: ").Append(Api).Append("\n");
      sb.Append("  Git: ").Append(Git).Append("\n");
      sb.Append("  Packages: ").Append(Packages).Append("\n");
      sb.Append("  Pages: ").Append(Pages).Append("\n");
      sb.Append("  Importer: ").Append(Importer).Append("\n");
      sb.Append("  Actions: ").Append(Actions).Append("\n");
      sb.Append("  Dependabot: ").Append(Dependabot).Append("\n");
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
