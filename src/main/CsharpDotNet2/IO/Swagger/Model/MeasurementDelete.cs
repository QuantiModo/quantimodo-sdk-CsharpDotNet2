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
  public class MeasurementDelete {
    /// <summary>
    /// Variable id of the measurement to be deleted
    /// </summary>
    /// <value>Variable id of the measurement to be deleted</value>
    [DataMember(Name="variableId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variableId")]
    public int? VariableId { get; set; }

    /// <summary>
    /// Start time of the measurement to be deleted
    /// </summary>
    /// <value>Start time of the measurement to be deleted</value>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startTime")]
    public int? StartTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MeasurementDelete {\n");
      sb.Append("  VariableId: ").Append(VariableId).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
