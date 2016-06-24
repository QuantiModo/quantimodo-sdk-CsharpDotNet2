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
  public class UserVariables {
    /// <summary>
    /// User ID
    /// </summary>
    /// <value>User ID</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public int? User { get; set; }

    /// <summary>
    /// Common variable id
    /// </summary>
    /// <value>Common variable id</value>
    [DataMember(Name="variableId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variableId")]
    public int? VariableId { get; set; }

    /// <summary>
    /// Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect
    /// </summary>
    /// <value>Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</value>
    [DataMember(Name="durationOfAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "durationOfAction")]
    public int? DurationOfAction { get; set; }

    /// <summary>
    /// fillingValue
    /// </summary>
    /// <value>fillingValue</value>
    [DataMember(Name="fillingValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fillingValue")]
    public int? FillingValue { get; set; }

    /// <summary>
    /// joinWith
    /// </summary>
    /// <value>joinWith</value>
    [DataMember(Name="joinWith", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "joinWith")]
    public string JoinWith { get; set; }

    /// <summary>
    /// maximumAllowedValue
    /// </summary>
    /// <value>maximumAllowedValue</value>
    [DataMember(Name="maximumAllowedValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximumAllowedValue")]
    public float? MaximumAllowedValue { get; set; }

    /// <summary>
    /// minimumAllowedValue
    /// </summary>
    /// <value>minimumAllowedValue</value>
    [DataMember(Name="minimumAllowedValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumAllowedValue")]
    public float? MinimumAllowedValue { get; set; }

    /// <summary>
    /// onsetDelay
    /// </summary>
    /// <value>onsetDelay</value>
    [DataMember(Name="onsetDelay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onsetDelay")]
    public int? OnsetDelay { get; set; }

    /// <summary>
    /// Earliest measurement startTime that should be used in analysis in ISO format
    /// </summary>
    /// <value>Earliest measurement startTime that should be used in analysis in ISO format</value>
    [DataMember(Name="experimentStartTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "experimentStartTime")]
    public string ExperimentStartTime { get; set; }

    /// <summary>
    /// Latest measurement startTime that should be used in analysis in ISO format
    /// </summary>
    /// <value>Latest measurement startTime that should be used in analysis in ISO format</value>
    [DataMember(Name="experimentEndTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "experimentEndTime")]
    public string ExperimentEndTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserVariables {\n");
      sb.Append("  User: ").Append(User).Append("\n");
      sb.Append("  VariableId: ").Append(VariableId).Append("\n");
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
      sb.Append("  JoinWith: ").Append(JoinWith).Append("\n");
      sb.Append("  MaximumAllowedValue: ").Append(MaximumAllowedValue).Append("\n");
      sb.Append("  MinimumAllowedValue: ").Append(MinimumAllowedValue).Append("\n");
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      sb.Append("  ExperimentStartTime: ").Append(ExperimentStartTime).Append("\n");
      sb.Append("  ExperimentEndTime: ").Append(ExperimentEndTime).Append("\n");
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
