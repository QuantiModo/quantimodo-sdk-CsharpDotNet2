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
  public class UserVariable {
    /// <summary>
    /// ID of the parent variable if this variable has any parent
    /// </summary>
    /// <value>ID of the parent variable if this variable has any parent</value>
    [DataMember(Name="parent_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_id")]
    public int? ParentId { get; set; }

    /// <summary>
    /// User ID
    /// </summary>
    /// <value>User ID</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    /// <summary>
    /// client_id
    /// </summary>
    /// <value>client_id</value>
    [DataMember(Name="client_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_id")]
    public string ClientId { get; set; }

    /// <summary>
    /// ID of variable
    /// </summary>
    /// <value>ID of variable</value>
    [DataMember(Name="variable_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variable_id")]
    public int? VariableId { get; set; }

    /// <summary>
    /// ID of unit to use for this variable
    /// </summary>
    /// <value>ID of unit to use for this variable</value>
    [DataMember(Name="default_unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_unit_id")]
    public int? DefaultUnitId { get; set; }

    /// <summary>
    /// Minimum reasonable value for this variable (uses default unit)
    /// </summary>
    /// <value>Minimum reasonable value for this variable (uses default unit)</value>
    [DataMember(Name="minimum_allowed_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimum_allowed_value")]
    public float? MinimumAllowedValue { get; set; }

    /// <summary>
    /// Maximum reasonable value for this variable (uses default unit)
    /// </summary>
    /// <value>Maximum reasonable value for this variable (uses default unit)</value>
    [DataMember(Name="maximum_allowed_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximum_allowed_value")]
    public float? MaximumAllowedValue { get; set; }

    /// <summary>
    /// Value for replacing null measurements
    /// </summary>
    /// <value>Value for replacing null measurements</value>
    [DataMember(Name="filling_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filling_value")]
    public float? FillingValue { get; set; }

    /// <summary>
    /// The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables
    /// </summary>
    /// <value>The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</value>
    [DataMember(Name="join_with", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "join_with")]
    public int? JoinWith { get; set; }

    /// <summary>
    /// How long it takes for a measurement in this variable to take effect
    /// </summary>
    /// <value>How long it takes for a measurement in this variable to take effect</value>
    [DataMember(Name="onset_delay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onset_delay")]
    public int? OnsetDelay { get; set; }

    /// <summary>
    /// Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect
    /// </summary>
    /// <value>Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</value>
    [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration_of_action")]
    public int? DurationOfAction { get; set; }

    /// <summary>
    /// ID of variable category
    /// </summary>
    /// <value>ID of variable category</value>
    [DataMember(Name="variable_category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variable_category_id")]
    public int? VariableCategoryId { get; set; }

    /// <summary>
    /// updated
    /// </summary>
    /// <value>updated</value>
    [DataMember(Name="updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated")]
    public int? Updated { get; set; }

    /// <summary>
    /// Is variable public
    /// </summary>
    /// <value>Is variable public</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public int? _Public { get; set; }

    /// <summary>
    /// A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user
    /// </summary>
    /// <value>A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</value>
    [DataMember(Name="cause_only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_only")]
    public bool? CauseOnly { get; set; }

    /// <summary>
    /// 0 -> No filling, 1 -> Use filling-value
    /// </summary>
    /// <value>0 -> No filling, 1 -> Use filling-value</value>
    [DataMember(Name="filling_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filling_type")]
    public string FillingType { get; set; }

    /// <summary>
    /// Number of measurements
    /// </summary>
    /// <value>Number of measurements</value>
    [DataMember(Name="number_of_measurements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_measurements")]
    public int? NumberOfMeasurements { get; set; }

    /// <summary>
    /// Number of processed measurements
    /// </summary>
    /// <value>Number of processed measurements</value>
    [DataMember(Name="number_of_processed_measurements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_processed_measurements")]
    public int? NumberOfProcessedMeasurements { get; set; }

    /// <summary>
    /// Number of measurements at last analysis
    /// </summary>
    /// <value>Number of measurements at last analysis</value>
    [DataMember(Name="measurements_at_last_analysis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "measurements_at_last_analysis")]
    public int? MeasurementsAtLastAnalysis { get; set; }

    /// <summary>
    /// ID of last Unit
    /// </summary>
    /// <value>ID of last Unit</value>
    [DataMember(Name="last_unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_unit_id")]
    public int? LastUnitId { get; set; }

    /// <summary>
    /// ID of last original Unit
    /// </summary>
    /// <value>ID of last original Unit</value>
    [DataMember(Name="last_original_unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_original_unit_id")]
    public int? LastOriginalUnitId { get; set; }

    /// <summary>
    /// Last Value
    /// </summary>
    /// <value>Last Value</value>
    [DataMember(Name="last_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_value")]
    public float? LastValue { get; set; }

    /// <summary>
    /// Last original value which is stored
    /// </summary>
    /// <value>Last original value which is stored</value>
    [DataMember(Name="last_original_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_original_value")]
    public int? LastOriginalValue { get; set; }

    /// <summary>
    /// ID of last source
    /// </summary>
    /// <value>ID of last source</value>
    [DataMember(Name="last_source_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_source_id")]
    public int? LastSourceId { get; set; }

    /// <summary>
    /// Number of correlations for this variable
    /// </summary>
    /// <value>Number of correlations for this variable</value>
    [DataMember(Name="number_of_correlations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_correlations")]
    public int? NumberOfCorrelations { get; set; }

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
    /// When this variable or its settings were last updated
    /// </summary>
    /// <value>When this variable or its settings were last updated</value>
    [DataMember(Name="last_successful_update_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_successful_update_time")]
    public DateTime? LastSuccessfulUpdateTime { get; set; }

    /// <summary>
    /// Standard deviation
    /// </summary>
    /// <value>Standard deviation</value>
    [DataMember(Name="standard_deviation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "standard_deviation")]
    public float? StandardDeviation { get; set; }

    /// <summary>
    /// Variance
    /// </summary>
    /// <value>Variance</value>
    [DataMember(Name="variance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variance")]
    public float? Variance { get; set; }

    /// <summary>
    /// Minimum recorded value of this variable
    /// </summary>
    /// <value>Minimum recorded value of this variable</value>
    [DataMember(Name="minimum_recorded_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimum_recorded_value")]
    public float? MinimumRecordedValue { get; set; }

    /// <summary>
    /// Maximum recorded daily value of this variable
    /// </summary>
    /// <value>Maximum recorded daily value of this variable</value>
    [DataMember(Name="maximum_recorded_daily_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximum_recorded_daily_value")]
    public float? MaximumRecordedDailyValue { get; set; }

    /// <summary>
    /// Mean
    /// </summary>
    /// <value>Mean</value>
    [DataMember(Name="mean", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mean")]
    public float? Mean { get; set; }

    /// <summary>
    /// Median
    /// </summary>
    /// <value>Median</value>
    [DataMember(Name="median", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "median")]
    public float? Median { get; set; }

    /// <summary>
    /// Most common Unit ID
    /// </summary>
    /// <value>Most common Unit ID</value>
    [DataMember(Name="most_common_unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "most_common_unit_id")]
    public int? MostCommonUnitId { get; set; }

    /// <summary>
    /// Most common value
    /// </summary>
    /// <value>Most common value</value>
    [DataMember(Name="most_common_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "most_common_value")]
    public float? MostCommonValue { get; set; }

    /// <summary>
    /// Number of unique daily values
    /// </summary>
    /// <value>Number of unique daily values</value>
    [DataMember(Name="number_of_unique_daily_values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_unique_daily_values")]
    public float? NumberOfUniqueDailyValues { get; set; }

    /// <summary>
    /// Number of changes
    /// </summary>
    /// <value>Number of changes</value>
    [DataMember(Name="number_of_changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_changes")]
    public int? NumberOfChanges { get; set; }

    /// <summary>
    /// Skewness
    /// </summary>
    /// <value>Skewness</value>
    [DataMember(Name="skewness", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "skewness")]
    public float? Skewness { get; set; }

    /// <summary>
    /// Kurtosis
    /// </summary>
    /// <value>Kurtosis</value>
    [DataMember(Name="kurtosis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kurtosis")]
    public float? Kurtosis { get; set; }

    /// <summary>
    /// Latitude
    /// </summary>
    /// <value>Latitude</value>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latitude")]
    public float? Latitude { get; set; }

    /// <summary>
    /// Longitude
    /// </summary>
    /// <value>Longitude</value>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longitude")]
    public float? Longitude { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    /// <value>Location</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// Earliest measurement start_time to be used in analysis. Use ISO 8601 datetime format
    /// </summary>
    /// <value>Earliest measurement start_time to be used in analysis. Use ISO 8601 datetime format</value>
    [DataMember(Name="experiment_start_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "experiment_start_time")]
    public DateTime? ExperimentStartTime { get; set; }

    /// <summary>
    /// Latest measurement start_time to be used in analysis. Use ISO 8601 datetime format
    /// </summary>
    /// <value>Latest measurement start_time to be used in analysis. Use ISO 8601 datetime format</value>
    [DataMember(Name="experiment_end_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "experiment_end_time")]
    public DateTime? ExperimentEndTime { get; set; }

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
    /// Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables
    /// </summary>
    /// <value>Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</value>
    [DataMember(Name="outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "outcome")]
    public bool? Outcome { get; set; }

    /// <summary>
    /// Comma-separated list of source names to limit variables to those sources
    /// </summary>
    /// <value>Comma-separated list of source names to limit variables to those sources</value>
    [DataMember(Name="sources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sources")]
    public string Sources { get; set; }

    /// <summary>
    /// Earliest source time
    /// </summary>
    /// <value>Earliest source time</value>
    [DataMember(Name="earliest_source_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "earliest_source_time")]
    public int? EarliestSourceTime { get; set; }

    /// <summary>
    /// Latest source time
    /// </summary>
    /// <value>Latest source time</value>
    [DataMember(Name="latest_source_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latest_source_time")]
    public int? LatestSourceTime { get; set; }

    /// <summary>
    /// Earliest measurement time
    /// </summary>
    /// <value>Earliest measurement time</value>
    [DataMember(Name="earliest_measurement_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "earliest_measurement_time")]
    public int? EarliestMeasurementTime { get; set; }

    /// <summary>
    /// Latest measurement time
    /// </summary>
    /// <value>Latest measurement time</value>
    [DataMember(Name="latest_measurement_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latest_measurement_time")]
    public int? LatestMeasurementTime { get; set; }

    /// <summary>
    /// Earliest filling time
    /// </summary>
    /// <value>Earliest filling time</value>
    [DataMember(Name="earliest_filling_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "earliest_filling_time")]
    public int? EarliestFillingTime { get; set; }

    /// <summary>
    /// Latest filling time
    /// </summary>
    /// <value>Latest filling time</value>
    [DataMember(Name="latest_filling_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latest_filling_time")]
    public int? LatestFillingTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserVariable {\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  VariableId: ").Append(VariableId).Append("\n");
      sb.Append("  DefaultUnitId: ").Append(DefaultUnitId).Append("\n");
      sb.Append("  MinimumAllowedValue: ").Append(MinimumAllowedValue).Append("\n");
      sb.Append("  MaximumAllowedValue: ").Append(MaximumAllowedValue).Append("\n");
      sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
      sb.Append("  JoinWith: ").Append(JoinWith).Append("\n");
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      sb.Append("  VariableCategoryId: ").Append(VariableCategoryId).Append("\n");
      sb.Append("  Updated: ").Append(Updated).Append("\n");
      sb.Append("  _Public: ").Append(_Public).Append("\n");
      sb.Append("  CauseOnly: ").Append(CauseOnly).Append("\n");
      sb.Append("  FillingType: ").Append(FillingType).Append("\n");
      sb.Append("  NumberOfMeasurements: ").Append(NumberOfMeasurements).Append("\n");
      sb.Append("  NumberOfProcessedMeasurements: ").Append(NumberOfProcessedMeasurements).Append("\n");
      sb.Append("  MeasurementsAtLastAnalysis: ").Append(MeasurementsAtLastAnalysis).Append("\n");
      sb.Append("  LastUnitId: ").Append(LastUnitId).Append("\n");
      sb.Append("  LastOriginalUnitId: ").Append(LastOriginalUnitId).Append("\n");
      sb.Append("  LastValue: ").Append(LastValue).Append("\n");
      sb.Append("  LastOriginalValue: ").Append(LastOriginalValue).Append("\n");
      sb.Append("  LastSourceId: ").Append(LastSourceId).Append("\n");
      sb.Append("  NumberOfCorrelations: ").Append(NumberOfCorrelations).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  LastSuccessfulUpdateTime: ").Append(LastSuccessfulUpdateTime).Append("\n");
      sb.Append("  StandardDeviation: ").Append(StandardDeviation).Append("\n");
      sb.Append("  Variance: ").Append(Variance).Append("\n");
      sb.Append("  MinimumRecordedValue: ").Append(MinimumRecordedValue).Append("\n");
      sb.Append("  MaximumRecordedDailyValue: ").Append(MaximumRecordedDailyValue).Append("\n");
      sb.Append("  Mean: ").Append(Mean).Append("\n");
      sb.Append("  Median: ").Append(Median).Append("\n");
      sb.Append("  MostCommonUnitId: ").Append(MostCommonUnitId).Append("\n");
      sb.Append("  MostCommonValue: ").Append(MostCommonValue).Append("\n");
      sb.Append("  NumberOfUniqueDailyValues: ").Append(NumberOfUniqueDailyValues).Append("\n");
      sb.Append("  NumberOfChanges: ").Append(NumberOfChanges).Append("\n");
      sb.Append("  Skewness: ").Append(Skewness).Append("\n");
      sb.Append("  Kurtosis: ").Append(Kurtosis).Append("\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  ExperimentStartTime: ").Append(ExperimentStartTime).Append("\n");
      sb.Append("  ExperimentEndTime: ").Append(ExperimentEndTime).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Outcome: ").Append(Outcome).Append("\n");
      sb.Append("  Sources: ").Append(Sources).Append("\n");
      sb.Append("  EarliestSourceTime: ").Append(EarliestSourceTime).Append("\n");
      sb.Append("  LatestSourceTime: ").Append(LatestSourceTime).Append("\n");
      sb.Append("  EarliestMeasurementTime: ").Append(EarliestMeasurementTime).Append("\n");
      sb.Append("  LatestMeasurementTime: ").Append(LatestMeasurementTime).Append("\n");
      sb.Append("  EarliestFillingTime: ").Append(EarliestFillingTime).Append("\n");
      sb.Append("  LatestFillingTime: ").Append(LatestFillingTime).Append("\n");
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
