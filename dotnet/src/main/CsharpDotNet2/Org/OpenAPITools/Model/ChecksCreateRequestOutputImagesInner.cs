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
  public class ChecksCreateRequestOutputImagesInner {
    /// <summary>
    /// The alternative text for the image.
    /// </summary>
    /// <value>The alternative text for the image.</value>
    [DataMember(Name="alt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alt")]
    public string Alt { get; set; }

    /// <summary>
    /// The full URL of the image.
    /// </summary>
    /// <value>The full URL of the image.</value>
    [DataMember(Name="image_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_url")]
    public string ImageUrl { get; set; }

    /// <summary>
    /// A short image description.
    /// </summary>
    /// <value>A short image description.</value>
    [DataMember(Name="caption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "caption")]
    public string Caption { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChecksCreateRequestOutputImagesInner {\n");
      sb.Append("  Alt: ").Append(Alt).Append("\n");
      sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
      sb.Append("  Caption: ").Append(Caption).Append("\n");
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
