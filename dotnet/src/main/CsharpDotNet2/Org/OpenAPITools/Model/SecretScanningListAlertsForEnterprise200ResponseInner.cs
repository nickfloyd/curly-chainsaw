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
  public class SecretScanningListAlertsForEnterprise200ResponseInner {
    /// <summary>
    /// The security alert number.
    /// </summary>
    /// <value>The security alert number.</value>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public int? Number { get; set; }

    /// <summary>
    /// The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
    /// </summary>
    /// <value>The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
    /// </summary>
    /// <value>The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// The REST API URL of the alert resource.
    /// </summary>
    /// <value>The REST API URL of the alert resource.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// The GitHub URL of the alert resource.
    /// </summary>
    /// <value>The GitHub URL of the alert resource.</value>
    [DataMember(Name="html_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "html_url")]
    public string HtmlUrl { get; set; }

    /// <summary>
    /// The REST API URL of the code locations for this alert.
    /// </summary>
    /// <value>The REST API URL of the code locations for this alert.</value>
    [DataMember(Name="locations_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locations_url")]
    public string LocationsUrl { get; set; }

    /// <summary>
    /// Sets the state of the secret scanning alert. Can be either `open` or `resolved`. You must provide `resolution` when you set the state to `resolved`.
    /// </summary>
    /// <value>Sets the state of the secret scanning alert. Can be either `open` or `resolved`. You must provide `resolution` when you set the state to `resolved`.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// **Required when the `state` is `resolved`.** The reason for resolving the alert.
    /// </summary>
    /// <value>**Required when the `state` is `resolved`.** The reason for resolving the alert.</value>
    [DataMember(Name="resolution", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolution")]
    public string Resolution { get; set; }

    /// <summary>
    /// The time that the alert was resolved in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
    /// </summary>
    /// <value>The time that the alert was resolved in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</value>
    [DataMember(Name="resolved_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolved_at")]
    public DateTime? ResolvedAt { get; set; }

    /// <summary>
    /// Gets or Sets ResolvedBy
    /// </summary>
    [DataMember(Name="resolved_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolved_by")]
    public SimpleUser ResolvedBy { get; set; }

    /// <summary>
    /// The type of secret that secret scanning detected.
    /// </summary>
    /// <value>The type of secret that secret scanning detected.</value>
    [DataMember(Name="secret_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret_type")]
    public string SecretType { get; set; }

    /// <summary>
    /// User-friendly name for the detected secret, matching the `secret_type`. For a list of built-in patterns, see \"[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security).\"
    /// </summary>
    /// <value>User-friendly name for the detected secret, matching the `secret_type`. For a list of built-in patterns, see \"[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security).\"</value>
    [DataMember(Name="secret_type_display_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret_type_display_name")]
    public string SecretTypeDisplayName { get; set; }

    /// <summary>
    /// The secret that was detected.
    /// </summary>
    /// <value>The secret that was detected.</value>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secret")]
    public string Secret { get; set; }

    /// <summary>
    /// Gets or Sets Repository
    /// </summary>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public SimpleRepository Repository { get; set; }

    /// <summary>
    /// Whether push protection was bypassed for the detected secret.
    /// </summary>
    /// <value>Whether push protection was bypassed for the detected secret.</value>
    [DataMember(Name="push_protection_bypassed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "push_protection_bypassed")]
    public bool? PushProtectionBypassed { get; set; }

    /// <summary>
    /// Gets or Sets PushProtectionBypassedBy
    /// </summary>
    [DataMember(Name="push_protection_bypassed_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "push_protection_bypassed_by")]
    public SimpleUser PushProtectionBypassedBy { get; set; }

    /// <summary>
    /// The time that push protection was bypassed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
    /// </summary>
    /// <value>The time that push protection was bypassed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</value>
    [DataMember(Name="push_protection_bypassed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "push_protection_bypassed_at")]
    public DateTime? PushProtectionBypassedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SecretScanningListAlertsForEnterprise200ResponseInner {\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  LocationsUrl: ").Append(LocationsUrl).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Resolution: ").Append(Resolution).Append("\n");
      sb.Append("  ResolvedAt: ").Append(ResolvedAt).Append("\n");
      sb.Append("  ResolvedBy: ").Append(ResolvedBy).Append("\n");
      sb.Append("  SecretType: ").Append(SecretType).Append("\n");
      sb.Append("  SecretTypeDisplayName: ").Append(SecretTypeDisplayName).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
      sb.Append("  PushProtectionBypassed: ").Append(PushProtectionBypassed).Append("\n");
      sb.Append("  PushProtectionBypassedBy: ").Append(PushProtectionBypassedBy).Append("\n");
      sb.Append("  PushProtectionBypassedAt: ").Append(PushProtectionBypassedAt).Append("\n");
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
