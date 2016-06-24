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
  public class TrackingReminderNotification {
    /// <summary>
    /// id for the specific PENDING tracking remidner
    /// </summary>
    /// <value>id for the specific PENDING tracking remidner</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// id for the repeating tracking remidner
    /// </summary>
    /// <value>id for the repeating tracking remidner</value>
    [DataMember(Name="trackingReminderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackingReminderId")]
    public int? TrackingReminderId { get; set; }

    /// <summary>
    /// clientId
    /// </summary>
    /// <value>clientId</value>
    [DataMember(Name="clientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientId")]
    public string ClientId { get; set; }

    /// <summary>
    /// ID of User
    /// </summary>
    /// <value>ID of User</value>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public int? UserId { get; set; }

    /// <summary>
    /// Id for the variable to be tracked
    /// </summary>
    /// <value>Id for the variable to be tracked</value>
    [DataMember(Name="variableId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variableId")]
    public int? VariableId { get; set; }

    /// <summary>
    /// ISO 8601 timestamp for the specific time the variable should be tracked in UTC.  This will be used for the measurement startTime if the track endpoint is used.
    /// </summary>
    /// <value>ISO 8601 timestamp for the specific time the variable should be tracked in UTC.  This will be used for the measurement startTime if the track endpoint is used.</value>
    [DataMember(Name="pendingReminderTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pendingReminderTime")]
    public DateTime? PendingReminderTime { get; set; }

    /// <summary>
    /// Default value to use for the measurement when tracking
    /// </summary>
    /// <value>Default value to use for the measurement when tracking</value>
    [DataMember(Name="defaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValue")]
    public float? DefaultValue { get; set; }

    /// <summary>
    /// String identifier for the sound to accompany the reminder
    /// </summary>
    /// <value>String identifier for the sound to accompany the reminder</value>
    [DataMember(Name="reminderSound", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminderSound")]
    public string ReminderSound { get; set; }

    /// <summary>
    /// True if the reminders should appear as a popup notification
    /// </summary>
    /// <value>True if the reminders should appear as a popup notification</value>
    [DataMember(Name="popUp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "popUp")]
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
    [DataMember(Name="notificationBar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notificationBar")]
    public bool? NotificationBar { get; set; }

    /// <summary>
    /// When the record in the database was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.
    /// </summary>
    /// <value>When the record in the database was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local.</value>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Name of the variable to be used when sending measurements
    /// </summary>
    /// <value>Name of the variable to be used when sending measurements</value>
    [DataMember(Name="variableName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variableName")]
    public string VariableName { get; set; }

    /// <summary>
    /// Name of the variable category to be used when sending measurements
    /// </summary>
    /// <value>Name of the variable category to be used when sending measurements</value>
    [DataMember(Name="variableCategoryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variableCategoryName")]
    public string VariableCategoryName { get; set; }

    /// <summary>
    /// Abbreviated name of the unit to be used when sending measurements
    /// </summary>
    /// <value>Abbreviated name of the unit to be used when sending measurements</value>
    [DataMember(Name="abbreviatedUnitName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "abbreviatedUnitName")]
    public string AbbreviatedUnitName { get; set; }

    /// <summary>
    /// The way multiple measurements are aggregated over time
    /// </summary>
    /// <value>The way multiple measurements are aggregated over time</value>
    [DataMember(Name="combinationOperation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "combinationOperation")]
    public string CombinationOperation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TrackingReminderNotification {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  TrackingReminderId: ").Append(TrackingReminderId).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  VariableId: ").Append(VariableId).Append("\n");
      sb.Append("  PendingReminderTime: ").Append(PendingReminderTime).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  ReminderSound: ").Append(ReminderSound).Append("\n");
      sb.Append("  PopUp: ").Append(PopUp).Append("\n");
      sb.Append("  Sms: ").Append(Sms).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  NotificationBar: ").Append(NotificationBar).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  VariableName: ").Append(VariableName).Append("\n");
      sb.Append("  VariableCategoryName: ").Append(VariableCategoryName).Append("\n");
      sb.Append("  AbbreviatedUnitName: ").Append(AbbreviatedUnitName).Append("\n");
      sb.Append("  CombinationOperation: ").Append(CombinationOperation).Append("\n");
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
