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
  public class VoteDelete {
    /// <summary>
    /// Cause variable name for the correlation to which the vote pertains
    /// </summary>
    /// <value>Cause variable name for the correlation to which the vote pertains</value>
    [DataMember(Name="cause", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause")]
    public string Cause { get; set; }

    /// <summary>
    /// Effect variable name for the correlation to which the vote pertains
    /// </summary>
    /// <value>Effect variable name for the correlation to which the vote pertains</value>
    [DataMember(Name="effect", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect")]
    public string Effect { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VoteDelete {\n");
      sb.Append("  Cause: ").Append(Cause).Append("\n");
      sb.Append("  Effect: ").Append(Effect).Append("\n");
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
