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
  public class JobStepsInner {
    /// <summary>
    /// The phase of the lifecycle that the job is currently in.
    /// </summary>
    /// <value>The phase of the lifecycle that the job is currently in.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The outcome of the job.
    /// </summary>
    /// <value>The outcome of the job.</value>
    [DataMember(Name="conclusion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conclusion")]
    public string Conclusion { get; set; }

    /// <summary>
    /// The name of the job.
    /// </summary>
    /// <value>The name of the job.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number")]
    public int? Number { get; set; }

    /// <summary>
    /// The time that the step started, in ISO 8601 format.
    /// </summary>
    /// <value>The time that the step started, in ISO 8601 format.</value>
    [DataMember(Name="started_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "started_at")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// The time that the job finished, in ISO 8601 format.
    /// </summary>
    /// <value>The time that the job finished, in ISO 8601 format.</value>
    [DataMember(Name="completed_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completed_at")]
    public DateTime? CompletedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JobStepsInner {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Conclusion: ").Append(Conclusion).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
      sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
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
