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
  public class AggregatedCorrelation {
    
    /// <summary>
    /// id
    /// </summary>
    /// <value>id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    
    /// <summary>
    /// correlation
    /// </summary>
    /// <value>correlation</value>
    [DataMember(Name="correlation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "correlation")]
    public float? Correlation { get; set; }

    
    /// <summary>
    /// cause_id
    /// </summary>
    /// <value>cause_id</value>
    [DataMember(Name="cause_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_id")]
    public int? CauseId { get; set; }

    
    /// <summary>
    /// effect_id
    /// </summary>
    /// <value>effect_id</value>
    [DataMember(Name="effect_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect_id")]
    public int? EffectId { get; set; }

    
    /// <summary>
    /// onset_delay
    /// </summary>
    /// <value>onset_delay</value>
    [DataMember(Name="onset_delay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onset_delay")]
    public int? OnsetDelay { get; set; }

    
    /// <summary>
    /// duration_of_action
    /// </summary>
    /// <value>duration_of_action</value>
    [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration_of_action")]
    public int? DurationOfAction { get; set; }

    
    /// <summary>
    /// number_of_pairs
    /// </summary>
    /// <value>number_of_pairs</value>
    [DataMember(Name="number_of_pairs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_pairs")]
    public int? NumberOfPairs { get; set; }

    
    /// <summary>
    /// value_predicting_high_outcome
    /// </summary>
    /// <value>value_predicting_high_outcome</value>
    [DataMember(Name="value_predicting_high_outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value_predicting_high_outcome")]
    public float? ValuePredictingHighOutcome { get; set; }

    
    /// <summary>
    /// value_predicting_low_outcome
    /// </summary>
    /// <value>value_predicting_low_outcome</value>
    [DataMember(Name="value_predicting_low_outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value_predicting_low_outcome")]
    public float? ValuePredictingLowOutcome { get; set; }

    
    /// <summary>
    /// optimal_pearson_product
    /// </summary>
    /// <value>optimal_pearson_product</value>
    [DataMember(Name="optimal_pearson_product", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optimal_pearson_product")]
    public float? OptimalPearsonProduct { get; set; }

    
    /// <summary>
    /// vote
    /// </summary>
    /// <value>vote</value>
    [DataMember(Name="vote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vote")]
    public float? Vote { get; set; }

    
    /// <summary>
    /// number_of_users
    /// </summary>
    /// <value>number_of_users</value>
    [DataMember(Name="number_of_users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_users")]
    public int? NumberOfUsers { get; set; }

    
    /// <summary>
    /// number_of_correlations
    /// </summary>
    /// <value>number_of_correlations</value>
    [DataMember(Name="number_of_correlations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_correlations")]
    public int? NumberOfCorrelations { get; set; }

    
    /// <summary>
    /// statistical_significance
    /// </summary>
    /// <value>statistical_significance</value>
    [DataMember(Name="statistical_significance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statistical_significance")]
    public float? StatisticalSignificance { get; set; }

    
    /// <summary>
    /// cause_unit
    /// </summary>
    /// <value>cause_unit</value>
    [DataMember(Name="cause_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_unit")]
    public string CauseUnit { get; set; }

    
    /// <summary>
    /// cause_unit_id
    /// </summary>
    /// <value>cause_unit_id</value>
    [DataMember(Name="cause_unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_unit_id")]
    public int? CauseUnitId { get; set; }

    
    /// <summary>
    /// cause_changes
    /// </summary>
    /// <value>cause_changes</value>
    [DataMember(Name="cause_changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_changes")]
    public int? CauseChanges { get; set; }

    
    /// <summary>
    /// effect_changes
    /// </summary>
    /// <value>effect_changes</value>
    [DataMember(Name="effect_changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect_changes")]
    public int? EffectChanges { get; set; }

    
    /// <summary>
    /// aggregate_qm_score
    /// </summary>
    /// <value>aggregate_qm_score</value>
    [DataMember(Name="aggregate_qm_score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aggregate_qm_score")]
    public float? AggregateQmScore { get; set; }

    
    /// <summary>
    /// created_at
    /// </summary>
    /// <value>created_at</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    
    /// <summary>
    /// updated_at
    /// </summary>
    /// <value>updated_at</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    
    /// <summary>
    /// status
    /// </summary>
    /// <value>status</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    
    /// <summary>
    /// error_message
    /// </summary>
    /// <value>error_message</value>
    [DataMember(Name="error_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_message")]
    public string ErrorMessage { get; set; }

    
    /// <summary>
    /// last_successful_update_time
    /// </summary>
    /// <value>last_successful_update_time</value>
    [DataMember(Name="last_successful_update_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_successful_update_time")]
    public DateTime? LastSuccessfulUpdateTime { get; set; }

    
    /// <summary>
    /// reverse_pearson_correlation_coefficient
    /// </summary>
    /// <value>reverse_pearson_correlation_coefficient</value>
    [DataMember(Name="reverse_pearson_correlation_coefficient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reverse_pearson_correlation_coefficient")]
    public float? ReversePearsonCorrelationCoefficient { get; set; }

    
    /// <summary>
    /// predictive_pearson_correlation_coefficient
    /// </summary>
    /// <value>predictive_pearson_correlation_coefficient</value>
    [DataMember(Name="predictive_pearson_correlation_coefficient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "predictive_pearson_correlation_coefficient")]
    public float? PredictivePearsonCorrelationCoefficient { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AggregatedCorrelation {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Correlation: ").Append(Correlation).Append("\n");
      
      sb.Append("  CauseId: ").Append(CauseId).Append("\n");
      
      sb.Append("  EffectId: ").Append(EffectId).Append("\n");
      
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      
      sb.Append("  NumberOfPairs: ").Append(NumberOfPairs).Append("\n");
      
      sb.Append("  ValuePredictingHighOutcome: ").Append(ValuePredictingHighOutcome).Append("\n");
      
      sb.Append("  ValuePredictingLowOutcome: ").Append(ValuePredictingLowOutcome).Append("\n");
      
      sb.Append("  OptimalPearsonProduct: ").Append(OptimalPearsonProduct).Append("\n");
      
      sb.Append("  Vote: ").Append(Vote).Append("\n");
      
      sb.Append("  NumberOfUsers: ").Append(NumberOfUsers).Append("\n");
      
      sb.Append("  NumberOfCorrelations: ").Append(NumberOfCorrelations).Append("\n");
      
      sb.Append("  StatisticalSignificance: ").Append(StatisticalSignificance).Append("\n");
      
      sb.Append("  CauseUnit: ").Append(CauseUnit).Append("\n");
      
      sb.Append("  CauseUnitId: ").Append(CauseUnitId).Append("\n");
      
      sb.Append("  CauseChanges: ").Append(CauseChanges).Append("\n");
      
      sb.Append("  EffectChanges: ").Append(EffectChanges).Append("\n");
      
      sb.Append("  AggregateQmScore: ").Append(AggregateQmScore).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      
      sb.Append("  LastSuccessfulUpdateTime: ").Append(LastSuccessfulUpdateTime).Append("\n");
      
      sb.Append("  ReversePearsonCorrelationCoefficient: ").Append(ReversePearsonCorrelationCoefficient).Append("\n");
      
      sb.Append("  PredictivePearsonCorrelationCoefficient: ").Append(PredictivePearsonCorrelationCoefficient).Append("\n");
      
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
