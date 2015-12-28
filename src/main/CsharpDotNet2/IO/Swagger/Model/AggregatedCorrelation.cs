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
    /// Pearson correlation coefficient between cause and effect measurements
    /// </summary>
    /// <value>Pearson correlation coefficient between cause and effect measurements</value>
    [DataMember(Name="correlation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "correlation")]
    public float? Correlation { get; set; }

    
    /// <summary>
    /// variable ID of the cause variable for which the user desires correlations
    /// </summary>
    /// <value>variable ID of the cause variable for which the user desires correlations</value>
    [DataMember(Name="cause_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_id")]
    public int? CauseId { get; set; }

    
    /// <summary>
    /// variable ID of the effect variable for which the user desires correlations
    /// </summary>
    /// <value>variable ID of the effect variable for which the user desires correlations</value>
    [DataMember(Name="effect_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect_id")]
    public int? EffectId { get; set; }

    
    /// <summary>
    /// User estimated or default time after cause measurement before a perceivable effect is observed
    /// </summary>
    /// <value>User estimated or default time after cause measurement before a perceivable effect is observed</value>
    [DataMember(Name="onset_delay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onset_delay")]
    public int? OnsetDelay { get; set; }

    
    /// <summary>
    /// Time over which the cause is expected to produce a perceivable effect following the onset delay
    /// </summary>
    /// <value>Time over which the cause is expected to produce a perceivable effect following the onset delay</value>
    [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration_of_action")]
    public int? DurationOfAction { get; set; }

    
    /// <summary>
    /// Number of points that went into the correlation calculation
    /// </summary>
    /// <value>Number of points that went into the correlation calculation</value>
    [DataMember(Name="number_of_pairs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_pairs")]
    public int? NumberOfPairs { get; set; }

    
    /// <summary>
    /// cause value that predicts an above average effect value (in default unit for cause variable)
    /// </summary>
    /// <value>cause value that predicts an above average effect value (in default unit for cause variable)</value>
    [DataMember(Name="value_predicting_high_outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value_predicting_high_outcome")]
    public float? ValuePredictingHighOutcome { get; set; }

    
    /// <summary>
    /// cause value that predicts a below average effect value (in default unit for cause variable)
    /// </summary>
    /// <value>cause value that predicts a below average effect value (in default unit for cause variable)</value>
    [DataMember(Name="value_predicting_low_outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value_predicting_low_outcome")]
    public float? ValuePredictingLowOutcome { get; set; }

    
    /// <summary>
    /// Optimal Pearson Product
    /// </summary>
    /// <value>Optimal Pearson Product</value>
    [DataMember(Name="optimal_pearson_product", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "optimal_pearson_product")]
    public float? OptimalPearsonProduct { get; set; }

    
    /// <summary>
    /// Vote
    /// </summary>
    /// <value>Vote</value>
    [DataMember(Name="vote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vote")]
    public float? Vote { get; set; }

    
    /// <summary>
    /// Number of Users by which correlation is aggregated
    /// </summary>
    /// <value>Number of Users by which correlation is aggregated</value>
    [DataMember(Name="number_of_users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_users")]
    public int? NumberOfUsers { get; set; }

    
    /// <summary>
    /// Number of Correlations by which correlation is aggregated
    /// </summary>
    /// <value>Number of Correlations by which correlation is aggregated</value>
    [DataMember(Name="number_of_correlations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_correlations")]
    public int? NumberOfCorrelations { get; set; }

    
    /// <summary>
    /// A function of the effect size and sample size
    /// </summary>
    /// <value>A function of the effect size and sample size</value>
    [DataMember(Name="statistical_significance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statistical_significance")]
    public float? StatisticalSignificance { get; set; }

    
    /// <summary>
    /// Unit of the predictor variable
    /// </summary>
    /// <value>Unit of the predictor variable</value>
    [DataMember(Name="cause_unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_unit")]
    public string CauseUnit { get; set; }

    
    /// <summary>
    /// Unit ID of the predictor variable
    /// </summary>
    /// <value>Unit ID of the predictor variable</value>
    [DataMember(Name="cause_unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_unit_id")]
    public int? CauseUnitId { get; set; }

    
    /// <summary>
    /// Cause changes
    /// </summary>
    /// <value>Cause changes</value>
    [DataMember(Name="cause_changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_changes")]
    public int? CauseChanges { get; set; }

    
    /// <summary>
    /// Effect changes
    /// </summary>
    /// <value>Effect changes</value>
    [DataMember(Name="effect_changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effect_changes")]
    public int? EffectChanges { get; set; }

    
    /// <summary>
    /// Aggregated QM Score
    /// </summary>
    /// <value>Aggregated QM Score</value>
    [DataMember(Name="aggregate_qm_score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aggregate_qm_score")]
    public float? AggregateQmScore { get; set; }

    
    /// <summary>
    /// When the record was first created. Use ISO 8601 datetime format
    /// </summary>
    /// <value>When the record was first created. Use ISO 8601 datetime format</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    
    /// <summary>
    /// When the record in the database was last updated. Use ISO 8601 datetime format
    /// </summary>
    /// <value>When the record in the database was last updated. Use ISO 8601 datetime format</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    
    /// <summary>
    /// Status
    /// </summary>
    /// <value>Status</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    
    /// <summary>
    /// Error Message
    /// </summary>
    /// <value>Error Message</value>
    [DataMember(Name="error_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_message")]
    public string ErrorMessage { get; set; }

    
    /// <summary>
    /// Last Successful update time
    /// </summary>
    /// <value>Last Successful update time</value>
    [DataMember(Name="last_successful_update_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_successful_update_time")]
    public DateTime? LastSuccessfulUpdateTime { get; set; }

    
    /// <summary>
    /// Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation
    /// </summary>
    /// <value>Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</value>
    [DataMember(Name="reverse_pearson_correlation_coefficient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reverse_pearson_correlation_coefficient")]
    public float? ReversePearsonCorrelationCoefficient { get; set; }

    
    /// <summary>
    /// Predictive Pearson Correlation Coefficient
    /// </summary>
    /// <value>Predictive Pearson Correlation Coefficient</value>
    [DataMember(Name="predictive_pearson_correlation_coefficient", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "predictive_pearson_correlation_coefficient")]
    public float? PredictivePearsonCorrelationCoefficient { get; set; }

    
    /// <summary>
    /// Source of data for this correlation
    /// </summary>
    /// <value>Source of data for this correlation</value>
    [DataMember(Name="data_source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data_source")]
    public string DataSource { get; set; }

    

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
      
      sb.Append("  DataSource: ").Append(DataSource).Append("\n");
      
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
