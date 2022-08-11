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
  public class GitCreateCommitRequest {
    /// <summary>
    /// The commit message
    /// </summary>
    /// <value>The commit message</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// The SHA of the tree object this commit points to
    /// </summary>
    /// <value>The SHA of the tree object this commit points to</value>
    [DataMember(Name="tree", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tree")]
    public string Tree { get; set; }

    /// <summary>
    /// The SHAs of the commits that were the parents of this commit. If omitted or empty, the commit will be written as a root commit. For a single parent, an array of one SHA should be provided; for a merge commit, an array of more than one should be provided.
    /// </summary>
    /// <value>The SHAs of the commits that were the parents of this commit. If omitted or empty, the commit will be written as a root commit. For a single parent, an array of one SHA should be provided; for a merge commit, an array of more than one should be provided.</value>
    [DataMember(Name="parents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parents")]
    public List<string> Parents { get; set; }

    /// <summary>
    /// Gets or Sets Author
    /// </summary>
    [DataMember(Name="author", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "author")]
    public GitCreateCommitRequestAuthor Author { get; set; }

    /// <summary>
    /// Gets or Sets Committer
    /// </summary>
    [DataMember(Name="committer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "committer")]
    public GitCreateCommitRequestCommitter Committer { get; set; }

    /// <summary>
    /// The [PGP signature](https://en.wikipedia.org/wiki/Pretty_Good_Privacy) of the commit. GitHub adds the signature to the `gpgsig` header of the created commit. For a commit signature to be verifiable by Git or GitHub, it must be an ASCII-armored detached PGP signature over the string commit as it would be written to the object database. To pass a `signature` parameter, you need to first manually create a valid PGP signature, which can be complicated. You may find it easier to [use the command line](https://git-scm.com/book/id/v2/Git-Tools-Signing-Your-Work) to create signed commits.
    /// </summary>
    /// <value>The [PGP signature](https://en.wikipedia.org/wiki/Pretty_Good_Privacy) of the commit. GitHub adds the signature to the `gpgsig` header of the created commit. For a commit signature to be verifiable by Git or GitHub, it must be an ASCII-armored detached PGP signature over the string commit as it would be written to the object database. To pass a `signature` parameter, you need to first manually create a valid PGP signature, which can be complicated. You may find it easier to [use the command line](https://git-scm.com/book/id/v2/Git-Tools-Signing-Your-Work) to create signed commits.</value>
    [DataMember(Name="signature", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signature")]
    public string Signature { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GitCreateCommitRequest {\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Tree: ").Append(Tree).Append("\n");
      sb.Append("  Parents: ").Append(Parents).Append("\n");
      sb.Append("  Author: ").Append(Author).Append("\n");
      sb.Append("  Committer: ").Append(Committer).Append("\n");
      sb.Append("  Signature: ").Append(Signature).Append("\n");
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
