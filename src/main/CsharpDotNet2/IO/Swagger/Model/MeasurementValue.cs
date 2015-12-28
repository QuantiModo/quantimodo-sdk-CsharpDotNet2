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
  public class MeasurementValue {
    
    /// <summary>
    /// When the measurement event occurred . Use ISO 8601 datetime format
    /// </summary>
    /// <value>When the measurement event occurred . Use ISO 8601 datetime format</value>
    [DataMember(Name="start_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_time")]
    public string StartTime { get; set; }

    
    /// <summary>
    /// Value for the measurement
    /// </summary>
    /// <value>Value for the measurement</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public float? Value { get; set; }

    
    /// <summary>
    /// An optional note the user may include with their measurement
    /// </summary>
    /// <value>An optional note the user may include with their measurement</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MeasurementValue {\n");
      
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      
      sb.Append("  Value: ").Append(Value).Append("\n");
      
      sb.Append("  Note: ").Append(Note).Append("\n");
      
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
