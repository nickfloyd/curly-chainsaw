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
  public class MigrationsSetLfsPreferenceRequest {
    /// <summary>
    /// Whether to store large files during the import. `opt_in` means large files will be stored using Git LFS. `opt_out` means large files will be removed during the import.
    /// </summary>
    /// <value>Whether to store large files during the import. `opt_in` means large files will be stored using Git LFS. `opt_out` means large files will be removed during the import.</value>
    [DataMember(Name="use_lfs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "use_lfs")]
    public string UseLfs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MigrationsSetLfsPreferenceRequest {\n");
      sb.Append("  UseLfs: ").Append(UseLfs).Append("\n");
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
