using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITrackingReminderApi
    {
        
        /// <summary>
        /// Get tracking reminders Users can be reminded to track certain variables at a specified frequency with a default value.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this tracking reminder</param>
        /// <param name="userId">ID of the user who created a reminder</param>
        /// <param name="variableId">Id for the variable to be tracked</param>
        /// <param name="popUp">True if the reminders should appear as a popup notification</param>
        /// <param name="sms">True if the reminders should be delivered via SMS</param>
        /// <param name="email">True if the reminders should be delivered via email</param>
        /// <param name="notificationBar">True if the reminders should appear in the notification bar</param>
        /// <param name="lastReminded">ISO 8601 timestamp for the last time a reminder was sent</param>
        /// <param name="lastTracked">ISO 8601 timestamp for the last time a measurement was received for this user and variable</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 TrackingRemindersGet (string accessToken, string clientId, int? userId, int? variableId, bool? popUp, bool? sms, bool? email, bool? notificationBar, string lastReminded, string lastTracked, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store TrackingReminder This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be stored</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 TrackingRemindersPost (string accessToken, TrackingReminder body);
        
        /// <summary>
        /// Get TrackingReminder Get TrackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20023</returns>
        InlineResponse20023 TrackingRemindersIdGet (int? id, string accessToken);
        
        /// <summary>
        /// Update TrackingReminder Update TrackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">TrackingReminder that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 TrackingRemindersIdPut (int? id, string accessToken, TrackingReminder body);
        
        /// <summary>
        /// Delete TrackingReminder Delete previously posted trackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 TrackingRemindersIdDelete (int? id, string accessToken);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TrackingReminderApi : ITrackingReminderApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingReminderApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TrackingReminderApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingReminderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TrackingReminderApi(String basePath)
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
        /// Get tracking reminders Users can be reminded to track certain variables at a specified frequency with a default value.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this tracking reminder</param> 
        /// <param name="userId">ID of the user who created a reminder</param> 
        /// <param name="variableId">Id for the variable to be tracked</param> 
        /// <param name="popUp">True if the reminders should appear as a popup notification</param> 
        /// <param name="sms">True if the reminders should be delivered via SMS</param> 
        /// <param name="email">True if the reminders should be delivered via email</param> 
        /// <param name="notificationBar">True if the reminders should appear in the notification bar</param> 
        /// <param name="lastReminded">ISO 8601 timestamp for the last time a reminder was sent</param> 
        /// <param name="lastTracked">ISO 8601 timestamp for the last time a measurement was received for this user and variable</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2006</returns>            
        public InlineResponse2006 TrackingRemindersGet (string accessToken, string clientId, int? userId, int? variableId, bool? popUp, bool? sms, bool? email, bool? notificationBar, string lastReminded, string lastTracked, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/trackingReminders";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
             if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
             if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
             if (variableId != null) queryParams.Add("variable_id", ApiClient.ParameterToString(variableId)); // query parameter
             if (popUp != null) queryParams.Add("pop_up", ApiClient.ParameterToString(popUp)); // query parameter
             if (sms != null) queryParams.Add("sms", ApiClient.ParameterToString(sms)); // query parameter
             if (email != null) queryParams.Add("email", ApiClient.ParameterToString(email)); // query parameter
             if (notificationBar != null) queryParams.Add("notification_bar", ApiClient.ParameterToString(notificationBar)); // query parameter
             if (lastReminded != null) queryParams.Add("last_reminded", ApiClient.ParameterToString(lastReminded)); // query parameter
             if (lastTracked != null) queryParams.Add("last_tracked", ApiClient.ParameterToString(lastTracked)); // query parameter
             if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
             if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingRemindersGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingRemindersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2006) ApiClient.Deserialize(response.Content, typeof(InlineResponse2006), response.Headers);
        }
    
        
        /// <summary>
        /// Store TrackingReminder This is to enable users to indicate their opinion on the plausibility of a causal relationship between a treatment and outcome. QuantiModo incorporates crowd-sourced plausibility estimations into their algorithm. This is done allowing user to indicate their view of the plausibility of each relationship with thumbs up/down buttons placed next to each prediction.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">TrackingReminder that should be stored</param> 
        /// <returns>InlineResponse20023</returns>            
        public InlineResponse20023 TrackingRemindersPost (string accessToken, TrackingReminder body)
        {
            
    
            var path = "/trackingReminders";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingRemindersPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingRemindersPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20023) ApiClient.Deserialize(response.Content, typeof(InlineResponse20023), response.Headers);
        }
    
        
        /// <summary>
        /// Get TrackingReminder Get TrackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20023</returns>            
        public InlineResponse20023 TrackingRemindersIdGet (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TrackingRemindersIdGet");
            
    
            var path = "/trackingReminders/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingRemindersIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingRemindersIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20023) ApiClient.Deserialize(response.Content, typeof(InlineResponse20023), response.Headers);
        }
    
        
        /// <summary>
        /// Update TrackingReminder Update TrackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">TrackingReminder that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 TrackingRemindersIdPut (int? id, string accessToken, TrackingReminder body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TrackingRemindersIdPut");
            
    
            var path = "/trackingReminders/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingRemindersIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingRemindersIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete TrackingReminder Delete previously posted trackingReminder
        /// </summary>
        /// <param name="id">id of TrackingReminder</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 TrackingRemindersIdDelete (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TrackingRemindersIdDelete");
            
    
            var path = "/trackingReminders/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingRemindersIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrackingRemindersIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
