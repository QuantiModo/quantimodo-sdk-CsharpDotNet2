using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PostVote {
    /// <summary>
    /// Cause variable name
    /// </summary>
    /// <value>Cause variable name</value>
    [DataMember(Name="cause", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause")]
    public string Cause { get; set; }

    /// <summary>
    /// Effect variable name
    /// </summary>
    /// <value>Effect variable name</value>
    [DataMember(Name="effect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect")]
    public string Effect { get; set; }

    /// <summary>
    /// Vote: 0 (for implausible) or 1 (for plausible)
    /// </summary>
    /// <value>Vote: 0 (for implausible) or 1 (for plausible)</value>
    [DataMember(Name="vote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vote")]
    public bool? Vote { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PostVote {\n");
      sb.Append("  Cause: ").Append(Cause).Append("\n");
      sb.Append("  Effect: ").Append(Effect).Append("\n");
      sb.Append("  Vote: ").Append(Vote).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
