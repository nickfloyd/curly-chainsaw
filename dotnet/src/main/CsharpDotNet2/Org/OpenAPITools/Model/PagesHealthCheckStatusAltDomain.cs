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
  public class PagesHealthCheckStatusAltDomain {
    /// <summary>
    /// Gets or Sets Host
    /// </summary>
    [DataMember(Name="host", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "host")]
    public string Host { get; set; }

    /// <summary>
    /// Gets or Sets Uri
    /// </summary>
    [DataMember(Name="uri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uri")]
    public string Uri { get; set; }

    /// <summary>
    /// Gets or Sets Nameservers
    /// </summary>
    [DataMember(Name="nameservers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nameservers")]
    public string Nameservers { get; set; }

    /// <summary>
    /// Gets or Sets DnsResolves
    /// </summary>
    [DataMember(Name="dns_resolves", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dns_resolves")]
    public bool? DnsResolves { get; set; }

    /// <summary>
    /// Gets or Sets IsProxied
    /// </summary>
    [DataMember(Name="is_proxied", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_proxied")]
    public bool? IsProxied { get; set; }

    /// <summary>
    /// Gets or Sets IsCloudflareIp
    /// </summary>
    [DataMember(Name="is_cloudflare_ip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_cloudflare_ip")]
    public bool? IsCloudflareIp { get; set; }

    /// <summary>
    /// Gets or Sets IsFastlyIp
    /// </summary>
    [DataMember(Name="is_fastly_ip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_fastly_ip")]
    public bool? IsFastlyIp { get; set; }

    /// <summary>
    /// Gets or Sets IsOldIpAddress
    /// </summary>
    [DataMember(Name="is_old_ip_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_old_ip_address")]
    public bool? IsOldIpAddress { get; set; }

    /// <summary>
    /// Gets or Sets IsARecord
    /// </summary>
    [DataMember(Name="is_a_record", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_a_record")]
    public bool? IsARecord { get; set; }

    /// <summary>
    /// Gets or Sets HasCnameRecord
    /// </summary>
    [DataMember(Name="has_cname_record", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_cname_record")]
    public bool? HasCnameRecord { get; set; }

    /// <summary>
    /// Gets or Sets HasMxRecordsPresent
    /// </summary>
    [DataMember(Name="has_mx_records_present", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "has_mx_records_present")]
    public bool? HasMxRecordsPresent { get; set; }

    /// <summary>
    /// Gets or Sets IsValidDomain
    /// </summary>
    [DataMember(Name="is_valid_domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_valid_domain")]
    public bool? IsValidDomain { get; set; }

    /// <summary>
    /// Gets or Sets IsApexDomain
    /// </summary>
    [DataMember(Name="is_apex_domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_apex_domain")]
    public bool? IsApexDomain { get; set; }

    /// <summary>
    /// Gets or Sets ShouldBeARecord
    /// </summary>
    [DataMember(Name="should_be_a_record", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "should_be_a_record")]
    public bool? ShouldBeARecord { get; set; }

    /// <summary>
    /// Gets or Sets IsCnameToGithubUserDomain
    /// </summary>
    [DataMember(Name="is_cname_to_github_user_domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_cname_to_github_user_domain")]
    public bool? IsCnameToGithubUserDomain { get; set; }

    /// <summary>
    /// Gets or Sets IsCnameToPagesDotGithubDotCom
    /// </summary>
    [DataMember(Name="is_cname_to_pages_dot_github_dot_com", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_cname_to_pages_dot_github_dot_com")]
    public bool? IsCnameToPagesDotGithubDotCom { get; set; }

    /// <summary>
    /// Gets or Sets IsCnameToFastly
    /// </summary>
    [DataMember(Name="is_cname_to_fastly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_cname_to_fastly")]
    public bool? IsCnameToFastly { get; set; }

    /// <summary>
    /// Gets or Sets IsPointedToGithubPagesIp
    /// </summary>
    [DataMember(Name="is_pointed_to_github_pages_ip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_pointed_to_github_pages_ip")]
    public bool? IsPointedToGithubPagesIp { get; set; }

    /// <summary>
    /// Gets or Sets IsNonGithubPagesIpPresent
    /// </summary>
    [DataMember(Name="is_non_github_pages_ip_present", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_non_github_pages_ip_present")]
    public bool? IsNonGithubPagesIpPresent { get; set; }

    /// <summary>
    /// Gets or Sets IsPagesDomain
    /// </summary>
    [DataMember(Name="is_pages_domain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_pages_domain")]
    public bool? IsPagesDomain { get; set; }

    /// <summary>
    /// Gets or Sets IsServedByPages
    /// </summary>
    [DataMember(Name="is_served_by_pages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_served_by_pages")]
    public bool? IsServedByPages { get; set; }

    /// <summary>
    /// Gets or Sets IsValid
    /// </summary>
    [DataMember(Name="is_valid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_valid")]
    public bool? IsValid { get; set; }

    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Gets or Sets RespondsToHttps
    /// </summary>
    [DataMember(Name="responds_to_https", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responds_to_https")]
    public bool? RespondsToHttps { get; set; }

    /// <summary>
    /// Gets or Sets EnforcesHttps
    /// </summary>
    [DataMember(Name="enforces_https", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enforces_https")]
    public bool? EnforcesHttps { get; set; }

    /// <summary>
    /// Gets or Sets HttpsError
    /// </summary>
    [DataMember(Name="https_error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "https_error")]
    public string HttpsError { get; set; }

    /// <summary>
    /// Gets or Sets IsHttpsEligible
    /// </summary>
    [DataMember(Name="is_https_eligible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_https_eligible")]
    public bool? IsHttpsEligible { get; set; }

    /// <summary>
    /// Gets or Sets CaaError
    /// </summary>
    [DataMember(Name="caa_error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "caa_error")]
    public string CaaError { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PagesHealthCheckStatusAltDomain {\n");
      sb.Append("  Host: ").Append(Host).Append("\n");
      sb.Append("  Uri: ").Append(Uri).Append("\n");
      sb.Append("  Nameservers: ").Append(Nameservers).Append("\n");
      sb.Append("  DnsResolves: ").Append(DnsResolves).Append("\n");
      sb.Append("  IsProxied: ").Append(IsProxied).Append("\n");
      sb.Append("  IsCloudflareIp: ").Append(IsCloudflareIp).Append("\n");
      sb.Append("  IsFastlyIp: ").Append(IsFastlyIp).Append("\n");
      sb.Append("  IsOldIpAddress: ").Append(IsOldIpAddress).Append("\n");
      sb.Append("  IsARecord: ").Append(IsARecord).Append("\n");
      sb.Append("  HasCnameRecord: ").Append(HasCnameRecord).Append("\n");
      sb.Append("  HasMxRecordsPresent: ").Append(HasMxRecordsPresent).Append("\n");
      sb.Append("  IsValidDomain: ").Append(IsValidDomain).Append("\n");
      sb.Append("  IsApexDomain: ").Append(IsApexDomain).Append("\n");
      sb.Append("  ShouldBeARecord: ").Append(ShouldBeARecord).Append("\n");
      sb.Append("  IsCnameToGithubUserDomain: ").Append(IsCnameToGithubUserDomain).Append("\n");
      sb.Append("  IsCnameToPagesDotGithubDotCom: ").Append(IsCnameToPagesDotGithubDotCom).Append("\n");
      sb.Append("  IsCnameToFastly: ").Append(IsCnameToFastly).Append("\n");
      sb.Append("  IsPointedToGithubPagesIp: ").Append(IsPointedToGithubPagesIp).Append("\n");
      sb.Append("  IsNonGithubPagesIpPresent: ").Append(IsNonGithubPagesIpPresent).Append("\n");
      sb.Append("  IsPagesDomain: ").Append(IsPagesDomain).Append("\n");
      sb.Append("  IsServedByPages: ").Append(IsServedByPages).Append("\n");
      sb.Append("  IsValid: ").Append(IsValid).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  RespondsToHttps: ").Append(RespondsToHttps).Append("\n");
      sb.Append("  EnforcesHttps: ").Append(EnforcesHttps).Append("\n");
      sb.Append("  HttpsError: ").Append(HttpsError).Append("\n");
      sb.Append("  IsHttpsEligible: ").Append(IsHttpsEligible).Append("\n");
      sb.Append("  CaaError: ").Append(CaaError).Append("\n");
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
