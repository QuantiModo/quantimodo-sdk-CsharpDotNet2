using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRemindersApi
    {
        /// <summary>
        /// Get specific pending tracking reminders Specfic pending reminder instances that still need to be tracked.  
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="variableCategoryName">Limit tracking reminder notifications to a specific variable category</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local. </param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local. </param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 V1TrackingReminderNotificationsGet (string accessToken, string variableCategoryName, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        /// <summary>
        /// Skip a pending tracking reminder Deletes the pending tracking reminder
        /// </summary>
        /// <param name="body">Id of the pending reminder to be skipped or deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1TrackingReminderNotificationsSkipPost (TrackingReminderNotificationSkip body, string accessToken);
        /// <summary>
        /// Snooze a pending tracking reminder Changes the reminder time to now plus one hour
        /// </summary>
        /// <param name="body">Id of the pending reminder to be snoozed</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1TrackingReminderNotificationsSnoozePost (TrackingReminderNotificationSnooze body, string accessToken);
        /// <summary>
        /// Track a pending tracking reminder Adds the default measurement for the pending tracking reminder with the reminder time as the measurment start time
        /// </summary>
        /// <param name="body">Id of the pending reminder to be tracked</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1TrackingReminderNotificationsTrackPost (TrackingReminderNotificationTrack body, string accessToken);
        /// <summary>
        /// Delete tracking reminder Delete previously created tracking reminder
        /// </summary>
        /// <param name="body">Id of reminder to be deleted</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1TrackingRemindersDeletePost (TrackingReminderDelete body, string accessToken);
        /// <summary>
        /// Get repeating tracking reminder settings Users can be reminded to track certain variables at a specified frequency with a default value.  
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="variableCategoryName">Limit tracking reminders to a specific variable category</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local. </param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local. </param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 V1TrackingRemindersGet (string accessToken, string variableCategoryName, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        /// <summary>
        /// Store a Tracking Reminder This is to enable users to create reminders to track a variable with a default value at a specified frequency
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be stored</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 V1TrackingRemindersPost (string accessToken, TrackingReminder body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RemindersApi : IRemindersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemindersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RemindersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RemindersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RemindersApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Get specific pending tracking reminders Specfic pending reminder instances that still need to be tracked.  
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="variableCategoryName">Limit tracking reminder notifications to a specific variable category</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local. </param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local. </param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 V1TrackingReminderNotificationsGet (string accessToken, string variableCategoryName, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/v1/trackingReminderNotifications";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (variableCategoryName != null) queryParams.Add("variableCategoryName", ApiClient.ParameterToString(variableCategoryName)); // query parameter
 if (createdAt != null) queryParams.Add("createdAt", ApiClient.ParameterToString(createdAt)); // query parameter
 if (updatedAt != null) queryParams.Add("updatedAt", ApiClient.ParameterToString(updatedAt)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingReminderNotificationsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingReminderNotificationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        /// Skip a pending tracking reminder Deletes the pending tracking reminder
        /// </summary>
        /// <param name="body">Id of the pending reminder to be skipped or deleted</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>CommonResponse</returns>            
        public CommonResponse V1TrackingReminderNotificationsSkipPost (TrackingReminderNotificationSkip body, string accessToken)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1TrackingReminderNotificationsSkipPost");
            
    
            var path = "/v1/trackingReminderNotifications/skip";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingReminderNotificationsSkipPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingReminderNotificationsSkipPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
    
        /// <summary>
        /// Snooze a pending tracking reminder Changes the reminder time to now plus one hour
        /// </summary>
        /// <param name="body">Id of the pending reminder to be snoozed</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>CommonResponse</returns>            
        public CommonResponse V1TrackingReminderNotificationsSnoozePost (TrackingReminderNotificationSnooze body, string accessToken)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1TrackingReminderNotificationsSnoozePost");
            
    
            var path = "/v1/trackingReminderNotifications/snooze";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingReminderNotificationsSnoozePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingReminderNotificationsSnoozePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
    
        /// <summary>
        /// Track a pending tracking reminder Adds the default measurement for the pending tracking reminder with the reminder time as the measurment start time
        /// </summary>
        /// <param name="body">Id of the pending reminder to be tracked</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>CommonResponse</returns>            
        public CommonResponse V1TrackingReminderNotificationsTrackPost (TrackingReminderNotificationTrack body, string accessToken)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1TrackingReminderNotificationsTrackPost");
            
    
            var path = "/v1/trackingReminderNotifications/track";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingReminderNotificationsTrackPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingReminderNotificationsTrackPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
    
        /// <summary>
        /// Delete tracking reminder Delete previously created tracking reminder
        /// </summary>
        /// <param name="body">Id of reminder to be deleted</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>CommonResponse</returns>            
        public CommonResponse V1TrackingRemindersDeletePost (TrackingReminderDelete body, string accessToken)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1TrackingRemindersDeletePost");
            
    
            var path = "/v1/trackingReminders/delete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingRemindersDeletePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingRemindersDeletePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
    
        /// <summary>
        /// Get repeating tracking reminder settings Users can be reminded to track certain variables at a specified frequency with a default value.  
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="variableCategoryName">Limit tracking reminders to a specific variable category</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format. Time zone should be UTC and not local. </param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format. Time zone should be UTC and not local. </param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 V1TrackingRemindersGet (string accessToken, string variableCategoryName, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/v1/trackingReminders";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (variableCategoryName != null) queryParams.Add("variableCategoryName", ApiClient.ParameterToString(variableCategoryName)); // query parameter
 if (createdAt != null) queryParams.Add("createdAt", ApiClient.ParameterToString(createdAt)); // query parameter
 if (updatedAt != null) queryParams.Add("updatedAt", ApiClient.ParameterToString(updatedAt)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingRemindersGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingRemindersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        /// Store a Tracking Reminder This is to enable users to create reminders to track a variable with a default value at a specified frequency
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">TrackingReminder that should be stored</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 V1TrackingRemindersPost (string accessToken, TrackingReminder body)
        {
            
    
            var path = "/v1/trackingReminders";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingRemindersPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1TrackingRemindersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
    }
}
