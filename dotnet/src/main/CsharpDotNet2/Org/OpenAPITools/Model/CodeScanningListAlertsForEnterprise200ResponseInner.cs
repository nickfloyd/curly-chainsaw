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
  public class CodeScanningListAlertsForEnterprise200ResponseInner {
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
    /// The REST API URL for fetching the list of instances for an alert.
    /// </summary>
    /// <value>The REST API URL for fetching the list of instances for an alert.</value>
    [DataMember(Name="instances_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instances_url")]
    public string InstancesUrl { get; set; }

    /// <summary>
    /// State of a code scanning alert.
    /// </summary>
    /// <value>State of a code scanning alert.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The time that the alert was no longer detected and was considered fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
    /// </summary>
    /// <value>The time that the alert was no longer detected and was considered fixed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</value>
    [DataMember(Name="fixed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fixed_at")]
    public DateTime? FixedAt { get; set; }

    /// <summary>
    /// Gets or Sets DismissedBy
    /// </summary>
    [DataMember(Name="dismissed_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismissed_by")]
    public SimpleUser DismissedBy { get; set; }

    /// <summary>
    /// The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.
    /// </summary>
    /// <value>The time that the alert was dismissed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</value>
    [DataMember(Name="dismissed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismissed_at")]
    public DateTime? DismissedAt { get; set; }

    /// <summary>
    /// **Required when the state is dismissed.** The reason for dismissing or closing the alert.
    /// </summary>
    /// <value>**Required when the state is dismissed.** The reason for dismissing or closing the alert.</value>
    [DataMember(Name="dismissed_reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismissed_reason")]
    public string DismissedReason { get; set; }

    /// <summary>
    /// The dismissal comment associated with the dismissal of the alert.
    /// </summary>
    /// <value>The dismissal comment associated with the dismissal of the alert.</value>
    [DataMember(Name="dismissed_comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dismissed_comment")]
    public string DismissedComment { get; set; }

    /// <summary>
    /// Gets or Sets Rule
    /// </summary>
    [DataMember(Name="rule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rule")]
    public CodeScanningListAlertsForEnterprise200ResponseInnerRule Rule { get; set; }

    /// <summary>
    /// Gets or Sets Tool
    /// </summary>
    [DataMember(Name="tool", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tool")]
    public CodeScanningListAlertsForEnterprise200ResponseInnerTool Tool { get; set; }

    /// <summary>
    /// Gets or Sets MostRecentInstance
    /// </summary>
    [DataMember(Name="most_recent_instance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "most_recent_instance")]
    public CodeScanningListAlertsForEnterprise200ResponseInnerMostRecentInstance MostRecentInstance { get; set; }

    /// <summary>
    /// Gets or Sets Repository
    /// </summary>
    [DataMember(Name="repository", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "repository")]
    public SimpleRepository Repository { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CodeScanningListAlertsForEnterprise200ResponseInner {\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
      sb.Append("  InstancesUrl: ").Append(InstancesUrl).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  FixedAt: ").Append(FixedAt).Append("\n");
      sb.Append("  DismissedBy: ").Append(DismissedBy).Append("\n");
      sb.Append("  DismissedAt: ").Append(DismissedAt).Append("\n");
      sb.Append("  DismissedReason: ").Append(DismissedReason).Append("\n");
      sb.Append("  DismissedComment: ").Append(DismissedComment).Append("\n");
      sb.Append("  Rule: ").Append(Rule).Append("\n");
      sb.Append("  Tool: ").Append(Tool).Append("\n");
      sb.Append("  MostRecentInstance: ").Append(MostRecentInstance).Append("\n");
      sb.Append("  Repository: ").Append(Repository).Append("\n");
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
