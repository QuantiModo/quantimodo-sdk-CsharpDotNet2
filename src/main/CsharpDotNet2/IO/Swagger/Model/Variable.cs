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
  public class Variable {
    
    /// <summary>
    /// id
    /// </summary>
    /// <value>id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    
    /// <summary>
    /// client_id
    /// </summary>
    /// <value>client_id</value>
    [DataMember(Name="client_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "client_id")]
    public string ClientId { get; set; }

    
    /// <summary>
    /// ID of the parent variable if this variable has any parent
    /// </summary>
    /// <value>ID of the parent variable if this variable has any parent</value>
    [DataMember(Name="parent_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_id")]
    public int? ParentId { get; set; }

    
    /// <summary>
    /// User-defined variable display name
    /// </summary>
    /// <value>User-defined variable display name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    
    /// <summary>
    /// Variable category ID
    /// </summary>
    /// <value>Variable category ID</value>
    [DataMember(Name="variable_category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variable_category_id")]
    public int? VariableCategoryId { get; set; }

    
    /// <summary>
    /// ID of the default unit of measurement to use for this variable
    /// </summary>
    /// <value>ID of the default unit of measurement to use for this variable</value>
    [DataMember(Name="default_unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_unit_id")]
    public int? DefaultUnitId { get; set; }

    
    /// <summary>
    /// How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN
    /// </summary>
    /// <value>How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</value>
    [DataMember(Name="combination_operation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "combination_operation")]
    public string CombinationOperation { get; set; }

    
    /// <summary>
    /// Value for replacing null measurements
    /// </summary>
    /// <value>Value for replacing null measurements</value>
    [DataMember(Name="filling_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filling_value")]
    public float? FillingValue { get; set; }

    
    /// <summary>
    /// Maximum reasonable value for this variable (uses default unit)
    /// </summary>
    /// <value>Maximum reasonable value for this variable (uses default unit)</value>
    [DataMember(Name="maximum_allowed_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximum_allowed_value")]
    public float? MaximumAllowedValue { get; set; }

    
    /// <summary>
    /// Minimum reasonable value for this variable (uses default unit)
    /// </summary>
    /// <value>Minimum reasonable value for this variable (uses default unit)</value>
    [DataMember(Name="minimum_allowed_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimum_allowed_value")]
    public float? MinimumAllowedValue { get; set; }

    
    /// <summary>
    /// How long it takes for a measurement in this variable to take effect
    /// </summary>
    /// <value>How long it takes for a measurement in this variable to take effect</value>
    [DataMember(Name="onset_delay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onset_delay")]
    public int? OnsetDelay { get; set; }

    
    /// <summary>
    /// How long the effect of a measurement in this variable lasts
    /// </summary>
    /// <value>How long the effect of a measurement in this variable lasts</value>
    [DataMember(Name="duration_of_action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration_of_action")]
    public int? DurationOfAction { get; set; }

    
    /// <summary>
    /// Is variable public
    /// </summary>
    /// <value>Is variable public</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public int? Public { get; set; }

    
    /// <summary>
    /// A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user
    /// </summary>
    /// <value>A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</value>
    [DataMember(Name="cause_only", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cause_only")]
    public bool? CauseOnly { get; set; }

    
    /// <summary>
    /// Most common value
    /// </summary>
    /// <value>Most common value</value>
    [DataMember(Name="most_common_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "most_common_value")]
    public float? MostCommonValue { get; set; }

    
    /// <summary>
    /// Most common Unit
    /// </summary>
    /// <value>Most common Unit</value>
    [DataMember(Name="most_common_unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "most_common_unit_id")]
    public int? MostCommonUnitId { get; set; }

    
    /// <summary>
    /// Standard Deviation
    /// </summary>
    /// <value>Standard Deviation</value>
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
    /// Number of measurements
    /// </summary>
    /// <value>Number of measurements</value>
    [DataMember(Name="number_of_measurements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_measurements")]
    public float? NumberOfMeasurements { get; set; }

    
    /// <summary>
    /// Number of unique values
    /// </summary>
    /// <value>Number of unique values</value>
    [DataMember(Name="number_of_unique_values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_unique_values")]
    public float? NumberOfUniqueValues { get; set; }

    
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
    /// Product URL
    /// </summary>
    /// <value>Product URL</value>
    [DataMember(Name="product_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product_url")]
    public string ProductUrl { get; set; }

    
    /// <summary>
    /// Image URL
    /// </summary>
    /// <value>Image URL</value>
    [DataMember(Name="image_url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image_url")]
    public string ImageUrl { get; set; }

    
    /// <summary>
    /// Price
    /// </summary>
    /// <value>Price</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public float? Price { get; set; }

    
    /// <summary>
    /// Number of variables
    /// </summary>
    /// <value>Number of variables</value>
    [DataMember(Name="number_of_user_variables", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "number_of_user_variables")]
    public int? NumberOfUserVariables { get; set; }

    
    /// <summary>
    /// Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.
    /// </summary>
    /// <value>Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</value>
    [DataMember(Name="outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "outcome")]
    public bool? Outcome { get; set; }

    
    /// <summary>
    /// Minimum recorded value of this variable
    /// </summary>
    /// <value>Minimum recorded value of this variable</value>
    [DataMember(Name="minimum_recorded_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimum_recorded_value")]
    public float? MinimumRecordedValue { get; set; }

    
    /// <summary>
    /// Maximum recorded value of this variable
    /// </summary>
    /// <value>Maximum recorded value of this variable</value>
    [DataMember(Name="maximum_recorded_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximum_recorded_value")]
    public float? MaximumRecordedValue { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Variable {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  VariableCategoryId: ").Append(VariableCategoryId).Append("\n");
      
      sb.Append("  DefaultUnitId: ").Append(DefaultUnitId).Append("\n");
      
      sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
      
      sb.Append("  FillingValue: ").Append(FillingValue).Append("\n");
      
      sb.Append("  MaximumAllowedValue: ").Append(MaximumAllowedValue).Append("\n");
      
      sb.Append("  MinimumAllowedValue: ").Append(MinimumAllowedValue).Append("\n");
      
      sb.Append("  OnsetDelay: ").Append(OnsetDelay).Append("\n");
      
      sb.Append("  DurationOfAction: ").Append(DurationOfAction).Append("\n");
      
      sb.Append("  Public: ").Append(Public).Append("\n");
      
      sb.Append("  CauseOnly: ").Append(CauseOnly).Append("\n");
      
      sb.Append("  MostCommonValue: ").Append(MostCommonValue).Append("\n");
      
      sb.Append("  MostCommonUnitId: ").Append(MostCommonUnitId).Append("\n");
      
      sb.Append("  StandardDeviation: ").Append(StandardDeviation).Append("\n");
      
      sb.Append("  Variance: ").Append(Variance).Append("\n");
      
      sb.Append("  Mean: ").Append(Mean).Append("\n");
      
      sb.Append("  Median: ").Append(Median).Append("\n");
      
      sb.Append("  NumberOfMeasurements: ").Append(NumberOfMeasurements).Append("\n");
      
      sb.Append("  NumberOfUniqueValues: ").Append(NumberOfUniqueValues).Append("\n");
      
      sb.Append("  Skewness: ").Append(Skewness).Append("\n");
      
      sb.Append("  Kurtosis: ").Append(Kurtosis).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      
      sb.Append("  LastSuccessfulUpdateTime: ").Append(LastSuccessfulUpdateTime).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      
      sb.Append("  ProductUrl: ").Append(ProductUrl).Append("\n");
      
      sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
      
      sb.Append("  Price: ").Append(Price).Append("\n");
      
      sb.Append("  NumberOfUserVariables: ").Append(NumberOfUserVariables).Append("\n");
      
      sb.Append("  Outcome: ").Append(Outcome).Append("\n");
      
      sb.Append("  MinimumRecordedValue: ").Append(MinimumRecordedValue).Append("\n");
      
      sb.Append("  MaximumRecordedValue: ").Append(MaximumRecordedValue).Append("\n");
      
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
