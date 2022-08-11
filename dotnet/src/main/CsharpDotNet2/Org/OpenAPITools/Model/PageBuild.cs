using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Page Build
  /// </summary>
  [DataContract]
  public class PageBuild {
    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public PageBuildError Error { get; set; }

    /// <summary>
    /// Gets or Sets Pusher
    /// </summary>
    [DataMember(Name="pusher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pusher")]
    public SimpleUser Pusher { get; set; }

    /// <summary>
    /// Gets or Sets Commit
    /// </summary>
    [DataMember(Name="commit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commit")]
    public string Commit { get; set; }

    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageBuild {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  Pusher: ").Append(Pusher).Append("\n");
      sb.Append("  Commit: ").Append(Commit).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
