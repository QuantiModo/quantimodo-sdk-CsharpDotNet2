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
  public class TrackingReminder {
    
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
    /// ID of User
    /// </summary>
    /// <value>ID of User</value>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user_id")]
    public int? UserId { get; set; }

    
    /// <summary>
    /// Id for the variable to be tracked
    /// </summary>
    /// <value>Id for the variable to be tracked</value>
    [DataMember(Name="variable_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variable_id")]
    public int? VariableId { get; set; }

    
    /// <summary>
    /// Default value to use for the measurement when tracking
    /// </summary>
    /// <value>Default value to use for the measurement when tracking</value>
    [DataMember(Name="default_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_value")]
    public float? DefaultValue { get; set; }

    
    /// <summary>
    /// Earliest time of day at which reminders should appear
    /// </summary>
    /// <value>Earliest time of day at which reminders should appear</value>
    [DataMember(Name="reminder_start_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminder_start_time")]
    public string ReminderStartTime { get; set; }

    
    /// <summary>
    /// Latest time of day at which reminders should appear
    /// </summary>
    /// <value>Latest time of day at which reminders should appear</value>
    [DataMember(Name="reminder_end_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminder_end_time")]
    public string ReminderEndTime { get; set; }

    
    /// <summary>
    /// String identifier for the sound to accompany the reminder
    /// </summary>
    /// <value>String identifier for the sound to accompany the reminder</value>
    [DataMember(Name="reminder_sound", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminder_sound")]
    public string ReminderSound { get; set; }

    
    /// <summary>
    /// Number of seconds between one reminder and the next
    /// </summary>
    /// <value>Number of seconds between one reminder and the next</value>
    [DataMember(Name="reminder_frequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminder_frequency")]
    public int? ReminderFrequency { get; set; }

    
    /// <summary>
    /// True if the reminders should appear as a popup notification
    /// </summary>
    /// <value>True if the reminders should appear as a popup notification</value>
    [DataMember(Name="pop_up", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pop_up")]
    public bool? PopUp { get; set; }

    
    /// <summary>
    /// True if the reminders should be delivered via SMS
    /// </summary>
    /// <value>True if the reminders should be delivered via SMS</value>
    [DataMember(Name="sms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sms")]
    public bool? Sms { get; set; }

    
    /// <summary>
    /// True if the reminders should be delivered via email
    /// </summary>
    /// <value>True if the reminders should be delivered via email</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public bool? Email { get; set; }

    
    /// <summary>
    /// True if the reminders should appear in the notification bar
    /// </summary>
    /// <value>True if the reminders should appear in the notification bar</value>
    [DataMember(Name="notification_bar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notification_bar")]
    public bool? NotificationBar { get; set; }

    
    /// <summary>
    /// ISO 8601 timestamp for the last time a reminder was sent
    /// </summary>
    /// <value>ISO 8601 timestamp for the last time a reminder was sent</value>
    [DataMember(Name="last_reminded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_reminded")]
    public DateTime? LastReminded { get; set; }

    
    /// <summary>
    /// ISO 8601 timestamp for the last time a measurement was received for this user and variable
    /// </summary>
    /// <value>ISO 8601 timestamp for the last time a measurement was received for this user and variable</value>
    [DataMember(Name="last_tracked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_tracked")]
    public DateTime? LastTracked { get; set; }

    
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TrackingReminder {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      
      sb.Append("  VariableId: ").Append(VariableId).Append("\n");
      
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      
      sb.Append("  ReminderStartTime: ").Append(ReminderStartTime).Append("\n");
      
      sb.Append("  ReminderEndTime: ").Append(ReminderEndTime).Append("\n");
      
      sb.Append("  ReminderSound: ").Append(ReminderSound).Append("\n");
      
      sb.Append("  ReminderFrequency: ").Append(ReminderFrequency).Append("\n");
      
      sb.Append("  PopUp: ").Append(PopUp).Append("\n");
      
      sb.Append("  Sms: ").Append(Sms).Append("\n");
      
      sb.Append("  Email: ").Append(Email).Append("\n");
      
      sb.Append("  NotificationBar: ").Append(NotificationBar).Append("\n");
      
      sb.Append("  LastReminded: ").Append(LastReminded).Append("\n");
      
      sb.Append("  LastTracked: ").Append(LastTracked).Append("\n");
      
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
