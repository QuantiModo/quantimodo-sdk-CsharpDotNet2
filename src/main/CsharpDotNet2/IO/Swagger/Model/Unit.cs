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
  public class Unit {
    
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
    /// Unit name
    /// </summary>
    /// <value>Unit name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    
    /// <summary>
    /// Unit abbreviation
    /// </summary>
    /// <value>Unit abbreviation</value>
    [DataMember(Name="abbreviated_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "abbreviated_name")]
    public string AbbreviatedName { get; set; }

    
    /// <summary>
    /// Unit category ID
    /// </summary>
    /// <value>Unit category ID</value>
    [DataMember(Name="category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_id")]
    public int? CategoryId { get; set; }

    
    /// <summary>
    /// Unit minimum value
    /// </summary>
    /// <value>Unit minimum value</value>
    [DataMember(Name="minimum_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimum_value")]
    public float? MinimumValue { get; set; }

    
    /// <summary>
    /// Unit maximum value
    /// </summary>
    /// <value>Unit maximum value</value>
    [DataMember(Name="maximum_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximum_value")]
    public float? MaximumValue { get; set; }

    
    /// <summary>
    /// updated
    /// </summary>
    /// <value>updated</value>
    [DataMember(Name="updated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated")]
    public int? Updated { get; set; }

    
    /// <summary>
    /// ID of default unit
    /// </summary>
    /// <value>ID of default unit</value>
    [DataMember(Name="default_unit_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_unit_id")]
    public int? DefaultUnitId { get; set; }

    
    /// <summary>
    /// Value multiplied to
    /// </summary>
    /// <value>Value multiplied to</value>
    [DataMember(Name="multiply", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "multiply")]
    public float? Multiply { get; set; }

    
    /// <summary>
    /// Value which should be added to convert to default unit
    /// </summary>
    /// <value>Value which should be added to convert to default unit</value>
    [DataMember(Name="add", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "add")]
    public float? Add { get; set; }

    
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Unit {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  AbbreviatedName: ").Append(AbbreviatedName).Append("\n");
      
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      
      sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
      
      sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
      
      sb.Append("  Updated: ").Append(Updated).Append("\n");
      
      sb.Append("  DefaultUnitId: ").Append(DefaultUnitId).Append("\n");
      
      sb.Append("  Multiply: ").Append(Multiply).Append("\n");
      
      sb.Append("  Add: ").Append(Add).Append("\n");
      
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      
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
