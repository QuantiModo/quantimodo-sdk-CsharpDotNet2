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
  public class CommonVariableRelationship {
    
    /// <summary>
    /// id
    /// </summary>
    /// <value>id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    
    /// <summary>
    /// Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors
    /// </summary>
    /// <value>Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</value>
    [DataMember(Name="confidence_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confidence_level")]
    public string ConfidenceLevel { get; set; }

    
    /// <summary>
    /// A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors
    /// </summary>
    /// <value>A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</value>
    [DataMember(Name="confidence_score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confidence_score")]
    public float? ConfidenceScore { get; set; }

    
    /// <summary>
    /// Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.
    /// </summary>
    /// <value>Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</value>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public string Direction { get; set; }

    
    /// <summary>
    /// duration_of_action
    /// </summary>
    /// <value>duration_of_action</value>
    [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration_of_action")]
    public int? DurationOfAction { get; set; }

    
    /// <summary>
    /// error_message
    /// </summary>
    /// <value>error_message</value>
    [DataMember(Name="error_message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_message")]
    public string ErrorMessage { get; set; }

    
    /// <summary>
    /// User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed
    /// </summary>
    /// <value>User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</value>
    [DataMember(Name="onset_delay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onset_delay")]
    public int? OnsetDelay { get; set; }

    
    /// <summary>
    /// Variable ID for the outcome variable
    /// </summary>
    /// <value>Variable ID for the outcome variable</value>
    [DataMember(Name="outcome_variable_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "outcome_variable_id")]
    public int? OutcomeVariableId { get; set; }

    
    /// <summary>
    /// Variable ID for the predictor variable
    /// </summary>
    /// <value>Variable ID for the predictor variable</value>
    [DataMember(Name="predictor_variable_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "predictor_variable_id")]
    public int? PredictorVariableId { get; set; }

    
    /// <summary>
    /// ID for default unit of the predictor variable
    /// </summary>
    /// <value>ID for default unit of the predictor variable</value>
    [DataMember(Name="predictor_unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "predictor_unit_id")]
    public int? PredictorUnitId { get; set; }

    
    /// <summary>
    /// A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.
    /// </summary>
    /// <value>A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</value>
    [DataMember(Name="sinn_rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sinn_rank")]
    public float? SinnRank { get; set; }

    
    /// <summary>
    /// A value represented to the size of the effect which the predictor appears to have on the outcome.
    /// </summary>
    /// <value>A value represented to the size of the effect which the predictor appears to have on the outcome.</value>
    [DataMember(Name="strength_score", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "strength_score")]
    public float? StrengthScore { get; set; }

    
    /// <summary>
    /// Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.
    /// </summary>
    /// <value>Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</value>
    [DataMember(Name="strength_level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "strength_level")]
    public string StrengthLevel { get; set; }

    
    /// <summary>
    /// Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.
    /// </summary>
    /// <value>Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.</value>
    [DataMember(Name="up_votes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "up_votes")]
    public int? UpVotes { get; set; }

    
    /// <summary>
    /// Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.
    /// </summary>
    /// <value>Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.</value>
    [DataMember(Name="down_votes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "down_votes")]
    public int? DownVotes { get; set; }

    
    /// <summary>
    /// Value for the predictor variable (in it's default unit) which typically precedes an above average outcome value
    /// </summary>
    /// <value>Value for the predictor variable (in it's default unit) which typically precedes an above average outcome value</value>
    [DataMember(Name="value_predicting_high_outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value_predicting_high_outcome")]
    public float? ValuePredictingHighOutcome { get; set; }

    
    /// <summary>
    /// Value for the predictor variable (in it's default unit) which typically precedes a below average outcome value
    /// </summary>
    /// <value>Value for the predictor variable (in it's default unit) which typically precedes a below average outcome value</value>
    [DataMember(Name="value_predicting_low_outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value_predicting_low_outcome")]
    public float? ValuePredictingLowOutcome { get; set; }

    
    /// <summary>
    /// Number of users whose data was aggregated to obtain this relationship
    /// </summary>
    /// <value>Number of users whose data was aggregated to obtain this relationship</value>
    [DataMember(Name="number_of_users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_users")]
    public int? NumberOfUsers { get; set; }

    
    /// <summary>
    /// Source of data for this common variable relationship
    /// </summary>
    /// <value>Source of data for this common variable relationship</value>
    [DataMember(Name="data_source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data_source")]
    public string DataSource { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommonVariableRelationship {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  ConfidenceLevel: ").Append(ConfidenceLevel).Append("\n");
      
      sb.Append("  ConfidenceScore: ").Append(ConfidenceScore).Append("\n");
      
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      
      sb.Append("  OutcomeVariableId: ").Append(OutcomeVariableId).Append("\n");
      
      sb.Append("  PredictorVariableId: ").Append(PredictorVariableId).Append("\n");
      
      sb.Append("  PredictorUnitId: ").Append(PredictorUnitId).Append("\n");
      
      sb.Append("  SinnRank: ").Append(SinnRank).Append("\n");
      
      sb.Append("  StrengthScore: ").Append(StrengthScore).Append("\n");
      
      sb.Append("  StrengthLevel: ").Append(StrengthLevel).Append("\n");
      
      sb.Append("  UpVotes: ").Append(UpVotes).Append("\n");
      
      sb.Append("  DownVotes: ").Append(DownVotes).Append("\n");
      
      sb.Append("  ValuePredictingHighOutcome: ").Append(ValuePredictingHighOutcome).Append("\n");
      
      sb.Append("  ValuePredictingLowOutcome: ").Append(ValuePredictingLowOutcome).Append("\n");
      
      sb.Append("  NumberOfUsers: ").Append(NumberOfUsers).Append("\n");
      
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
