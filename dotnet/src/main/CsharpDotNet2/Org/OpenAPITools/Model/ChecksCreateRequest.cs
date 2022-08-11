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
  public class ChecksCreateRequest {
    /// <summary>
    /// The name of the check. For example, \"code-coverage\".
    /// </summary>
    /// <value>The name of the check. For example, \"code-coverage\".</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The SHA of the commit.
    /// </summary>
    /// <value>The SHA of the commit.</value>
    [DataMember(Name="head_sha", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "head_sha")]
    public string HeadSha { get; set; }

    /// <summary>
    /// The URL of the integrator's site that has the full details of the check. If the integrator does not provide this, then the homepage of the GitHub app is used.
    /// </summary>
    /// <value>The URL of the integrator's site that has the full details of the check. If the integrator does not provide this, then the homepage of the GitHub app is used.</value>
    [DataMember(Name="details_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details_url")]
    public string DetailsUrl { get; set; }

    /// <summary>
    /// A reference for the run on the integrator's system.
    /// </summary>
    /// <value>A reference for the run on the integrator's system.</value>
    [DataMember(Name="external_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "external_id")]
    public string ExternalId { get; set; }

    /// <summary>
    /// The current status.
    /// </summary>
    /// <value>The current status.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The time that the check run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
    /// </summary>
    /// <value>The time that the check run began. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</value>
    [DataMember(Name="started_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "started_at")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// **Required if you provide `completed_at` or a `status` of `completed`**. The final conclusion of the check.  **Note:** Providing `conclusion` will automatically set the `status` parameter to `completed`. You cannot change a check run conclusion to `stale`, only GitHub can set this.
    /// </summary>
    /// <value>**Required if you provide `completed_at` or a `status` of `completed`**. The final conclusion of the check.  **Note:** Providing `conclusion` will automatically set the `status` parameter to `completed`. You cannot change a check run conclusion to `stale`, only GitHub can set this.</value>
    [DataMember(Name="conclusion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conclusion")]
    public string Conclusion { get; set; }

    /// <summary>
    /// The time the check completed. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.
    /// </summary>
    /// <value>The time the check completed. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`.</value>
    [DataMember(Name="completed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed_at")]
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Gets or Sets Output
    /// </summary>
    [DataMember(Name="output", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "output")]
    public ChecksCreateRequestOutput Output { get; set; }

    /// <summary>
    /// Displays a button on GitHub that can be clicked to alert your app to do additional tasks. For example, a code linting app can display a button that automatically fixes detected errors. The button created in this object is displayed after the check run completes. When a user clicks the button, GitHub sends the [`check_run.requested_action` webhook](https://docs.github.com/webhooks/event-payloads/#check_run) to your app. Each action includes a `label`, `identifier` and `description`. A maximum of three actions are accepted. See the [`actions` object](https://docs.github.com/rest/reference/checks#actions-object) description. To learn more about check runs and requested actions, see \"[Check runs and requested actions](https://docs.github.com/rest/reference/checks#check-runs-and-requested-actions).\"
    /// </summary>
    /// <value>Displays a button on GitHub that can be clicked to alert your app to do additional tasks. For example, a code linting app can display a button that automatically fixes detected errors. The button created in this object is displayed after the check run completes. When a user clicks the button, GitHub sends the [`check_run.requested_action` webhook](https://docs.github.com/webhooks/event-payloads/#check_run) to your app. Each action includes a `label`, `identifier` and `description`. A maximum of three actions are accepted. See the [`actions` object](https://docs.github.com/rest/reference/checks#actions-object) description. To learn more about check runs and requested actions, see \"[Check runs and requested actions](https://docs.github.com/rest/reference/checks#check-runs-and-requested-actions).\"</value>
    [DataMember(Name="actions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actions")]
    public List<ChecksCreateRequestActionsInner> Actions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChecksCreateRequest {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  HeadSha: ").Append(HeadSha).Append("\n");
      sb.Append("  DetailsUrl: ").Append(DetailsUrl).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
      sb.Append("  Conclusion: ").Append(Conclusion).Append("\n");
      sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
      sb.Append("  Output: ").Append(Output).Append("\n");
      sb.Append("  Actions: ").Append(Actions).Append("\n");
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
