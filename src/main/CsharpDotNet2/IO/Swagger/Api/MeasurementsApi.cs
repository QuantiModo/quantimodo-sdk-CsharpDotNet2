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
    public interface IMeasurementsApi
    {
        /// <summary>
        /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
        /// </summary>
        /// <returns>MeasurementSource</returns>
        MeasurementSource V1MeasurementSourcesGet ();
        /// <summary>
        /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </summary>
        /// <param name="body">An array of names of data sources you want to add.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns></returns>
        void V1MeasurementSourcesPost (MeasurementSource body, string accessToken);
        /// <summary>
        /// Get daily measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="abbreviatedUnitName">The unit your want the measurements in</param>
        /// <param name="startTime">The lower limit of measurements returned (Iso8601)</param>
        /// <param name="endTime">The upper limit of measurements returned (Iso8601)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order.</param>
        /// <returns>Measurement</returns>
        Measurement V1MeasurementsDailyGet (string variableName, string accessToken, string abbreviatedUnitName, string startTime, string endTime, int? groupingWidth, string groupingTimezone, int? limit, int? offset, int? sort);
        /// <summary>
        /// Delete a measurement Delete a previously submitted measurement
        /// </summary>
        /// <param name="body">The startTime and variableId of the measurement to be deleted.</param>
        /// <returns>CommonResponse</returns>
        CommonResponse V1MeasurementsDeletePost (MeasurementDelete body);
        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="variableName">Name of the variable you want measurements for</param>
        /// <param name="variableCategoryName">Name of the variable category you want measurements for</param>
        /// <param name="source">Name of the source you want measurements for (supports exact name match only)</param>
        /// <param name="value">Value of measurement</param>
        /// <param name="lastUpdated">The time that this measurement was created or last updated in the format \&quot;YYYY-MM-DDThh:mm:ss\&quot;</param>
        /// <param name="unit">The unit you want the measurements returned in</param>
        /// <param name="startTime">The lower limit of measurements returned (Epoch)</param>
        /// <param name="createdAt">The time the measurement record was first created in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local.</param>
        /// <param name="updatedAt">The time the measurement record was last changed in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local.</param>
        /// <param name="endTime">The upper limit of measurements returned (Epoch)</param>
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param>
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order.</param>
        /// <returns>Measurement</returns>
        Measurement V1MeasurementsGet (string accessToken, string variableName, string variableCategoryName, string source, string value, string lastUpdated, string unit, string startTime, string createdAt, string updatedAt, string endTime, int? groupingWidth, string groupingTimezone, int? limit, int? offset, int? sort);
        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;startTime\&quot;:1439389320,\&quot;value\&quot;:\&quot;3\&quot;}, {\&quot;startTime\&quot;:1439389319,\&quot;value\&quot;:\&quot;2\&quot;}],\&quot;name\&quot;:\&quot;Acne (out of 5)\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </summary>
        /// <param name="body">An array of measurements you want to insert.</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns></returns>
        void V1MeasurementsPost (MeasurementSet body, string accessToken);
        /// <summary>
        /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </summary>
        /// <param name="sources">Enter source name to limit to specific source (varchar)</param>
        /// <param name="user">If not specified, uses currently logged in user (bigint)</param>
        /// <returns>MeasurementRange</returns>
        MeasurementRange V1MeasurementsRangeGet (string sources, int? user);
        /// <summary>
        /// Get Measurements CSV Download a CSV containing all user measurements
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream V2MeasurementsCsvGet (string accessToken);
        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 V2MeasurementsIdDelete (int? id, string accessToken);
        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 V2MeasurementsIdGet (int? id, string accessToken);
        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Measurement that should be updated</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 V2MeasurementsIdPut (int? id, string accessToken, Measurement body);
        /// <summary>
        /// Post Request for Measurements CSV Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>int?</returns>
        int? V2MeasurementsRequestCsvPost (string accessToken);
        /// <summary>
        /// Post Request for Measurements PDF Use this endpoint to schedule a PDF export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>int?</returns>
        int? V2MeasurementsRequestPdfPost (string accessToken);
        /// <summary>
        /// Post Request for Measurements XLS Use this endpoint to schedule a XLS export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>int?</returns>
        int? V2MeasurementsRequestXlsPost (string accessToken);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MeasurementsApi : IMeasurementsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MeasurementsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MeasurementsApi(String basePath)
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
        /// Get measurement sources Returns a list of all the apps from which measurement data is obtained.
        /// </summary>
        /// <returns>MeasurementSource</returns>            
        public MeasurementSource V1MeasurementSourcesGet ()
        {
            
    
            var path = "/v1/measurementSources";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementSourcesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementSourcesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MeasurementSource) ApiClient.Deserialize(response.Content, typeof(MeasurementSource), response.Headers);
        }
    
        /// <summary>
        /// Add a data source Add a life-tracking app or device to the QuantiModo list of data sources.
        /// </summary>
        /// <param name="body">An array of names of data sources you want to add.</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns></returns>            
        public void V1MeasurementSourcesPost (MeasurementSource body, string accessToken)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1MeasurementSourcesPost");
            
    
            var path = "/v1/measurementSources";
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementSourcesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementSourcesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get daily measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="variableName">Name of the variable you want measurements for</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="abbreviatedUnitName">The unit your want the measurements in</param> 
        /// <param name="startTime">The lower limit of measurements returned (Iso8601)</param> 
        /// <param name="endTime">The upper limit of measurements returned (Iso8601)</param> 
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together</param> 
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param> 
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order.</param> 
        /// <returns>Measurement</returns>            
        public Measurement V1MeasurementsDailyGet (string variableName, string accessToken, string abbreviatedUnitName, string startTime, string endTime, int? groupingWidth, string groupingTimezone, int? limit, int? offset, int? sort)
        {
            
            // verify the required parameter 'variableName' is set
            if (variableName == null) throw new ApiException(400, "Missing required parameter 'variableName' when calling V1MeasurementsDailyGet");
            
    
            var path = "/v1/measurements/daily";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (variableName != null) queryParams.Add("variableName", ApiClient.ParameterToString(variableName)); // query parameter
 if (abbreviatedUnitName != null) queryParams.Add("abbreviatedUnitName", ApiClient.ParameterToString(abbreviatedUnitName)); // query parameter
 if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
 if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
 if (groupingWidth != null) queryParams.Add("groupingWidth", ApiClient.ParameterToString(groupingWidth)); // query parameter
 if (groupingTimezone != null) queryParams.Add("groupingTimezone", ApiClient.ParameterToString(groupingTimezone)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsDailyGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsDailyGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Measurement) ApiClient.Deserialize(response.Content, typeof(Measurement), response.Headers);
        }
    
        /// <summary>
        /// Delete a measurement Delete a previously submitted measurement
        /// </summary>
        /// <param name="body">The startTime and variableId of the measurement to be deleted.</param> 
        /// <returns>CommonResponse</returns>            
        public CommonResponse V1MeasurementsDeletePost (MeasurementDelete body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1MeasurementsDeletePost");
            
    
            var path = "/v1/measurements/delete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsDeletePost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsDeletePost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CommonResponse) ApiClient.Deserialize(response.Content, typeof(CommonResponse), response.Headers);
        }
    
        /// <summary>
        /// Get measurements for this user Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten. &lt;br&gt;Supported filter parameters:&lt;br&gt;&lt;ul&gt;&lt;li&gt;&lt;b&gt;value&lt;/b&gt; - Value of measurement&lt;/li&gt;&lt;li&gt;&lt;b&gt;lastUpdated&lt;/b&gt; - The time that this measurement was created or last updated in the UTC format \&quot;YYYY-MM-DDThh:mm:ss\&quot;&lt;/li&gt;&lt;/ul&gt;&lt;br&gt;
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="variableName">Name of the variable you want measurements for</param> 
        /// <param name="variableCategoryName">Name of the variable category you want measurements for</param> 
        /// <param name="source">Name of the source you want measurements for (supports exact name match only)</param> 
        /// <param name="value">Value of measurement</param> 
        /// <param name="lastUpdated">The time that this measurement was created or last updated in the format \&quot;YYYY-MM-DDThh:mm:ss\&quot;</param> 
        /// <param name="unit">The unit you want the measurements returned in</param> 
        /// <param name="startTime">The lower limit of measurements returned (Epoch)</param> 
        /// <param name="createdAt">The time the measurement record was first created in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local.</param> 
        /// <param name="updatedAt">The time the measurement record was last changed in the format YYYY-MM-DDThh:mm:ss. Time zone should be UTC and not local.</param> 
        /// <param name="endTime">The upper limit of measurements returned (Epoch)</param> 
        /// <param name="groupingWidth">The time (in seconds) over which measurements are grouped together</param> 
        /// <param name="groupingTimezone">The time (in seconds) over which measurements are grouped together</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0.</param> 
        /// <param name="offset">Now suppose you wanted to show results 11-20. You&#39;d set the offset to 10 and the limit to 10.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#x60;-, it will sort in descending order.</param> 
        /// <returns>Measurement</returns>            
        public Measurement V1MeasurementsGet (string accessToken, string variableName, string variableCategoryName, string source, string value, string lastUpdated, string unit, string startTime, string createdAt, string updatedAt, string endTime, int? groupingWidth, string groupingTimezone, int? limit, int? offset, int? sort)
        {
            
    
            var path = "/v1/measurements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (variableName != null) queryParams.Add("variableName", ApiClient.ParameterToString(variableName)); // query parameter
 if (variableCategoryName != null) queryParams.Add("variableCategoryName", ApiClient.ParameterToString(variableCategoryName)); // query parameter
 if (source != null) queryParams.Add("source", ApiClient.ParameterToString(source)); // query parameter
 if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
 if (lastUpdated != null) queryParams.Add("lastUpdated", ApiClient.ParameterToString(lastUpdated)); // query parameter
 if (unit != null) queryParams.Add("unit", ApiClient.ParameterToString(unit)); // query parameter
 if (startTime != null) queryParams.Add("startTime", ApiClient.ParameterToString(startTime)); // query parameter
 if (createdAt != null) queryParams.Add("createdAt", ApiClient.ParameterToString(createdAt)); // query parameter
 if (updatedAt != null) queryParams.Add("updatedAt", ApiClient.ParameterToString(updatedAt)); // query parameter
 if (endTime != null) queryParams.Add("endTime", ApiClient.ParameterToString(endTime)); // query parameter
 if (groupingWidth != null) queryParams.Add("groupingWidth", ApiClient.ParameterToString(groupingWidth)); // query parameter
 if (groupingTimezone != null) queryParams.Add("groupingTimezone", ApiClient.ParameterToString(groupingTimezone)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Measurement) ApiClient.Deserialize(response.Content, typeof(Measurement), response.Headers);
        }
    
        /// <summary>
        /// Post a new set or update existing measurements to the database You can submit or update multiple measurements in a \&quot;measurements\&quot; sub-array.  If the variable these measurements correspond to does not already exist in the database, it will be automatically added.  The request body should look something like [{\&quot;measurements\&quot;:[{\&quot;startTime\&quot;:1439389320,\&quot;value\&quot;:\&quot;3\&quot;}, {\&quot;startTime\&quot;:1439389319,\&quot;value\&quot;:\&quot;2\&quot;}],\&quot;name\&quot;:\&quot;Acne (out of 5)\&quot;,\&quot;source\&quot;:\&quot;QuantiModo\&quot;,\&quot;category\&quot;:\&quot;Symptoms\&quot;,\&quot;combinationOperation\&quot;:\&quot;MEAN\&quot;,\&quot;unit\&quot;:\&quot;/5\&quot;}]
        /// </summary>
        /// <param name="body">An array of measurements you want to insert.</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns></returns>            
        public void V1MeasurementsPost (MeasurementSet body, string accessToken)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling V1MeasurementsPost");
            
    
            var path = "/v1/measurements";
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get measurements range for this user Get Unix time-stamp (epoch time) of the user&#39;s first and last measurements taken.
        /// </summary>
        /// <param name="sources">Enter source name to limit to specific source (varchar)</param> 
        /// <param name="user">If not specified, uses currently logged in user (bigint)</param> 
        /// <returns>MeasurementRange</returns>            
        public MeasurementRange V1MeasurementsRangeGet (string sources, int? user)
        {
            
    
            var path = "/v1/measurementsRange";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sources != null) queryParams.Add("sources", ApiClient.ParameterToString(sources)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsRangeGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1MeasurementsRangeGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (MeasurementRange) ApiClient.Deserialize(response.Content, typeof(MeasurementRange), response.Headers);
        }
    
        /// <summary>
        /// Get Measurements CSV Download a CSV containing all user measurements
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream V2MeasurementsCsvGet (string accessToken)
        {
            
    
            var path = "/v2/measurements/csv";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsCsvGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsCsvGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Delete Measurement Delete Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20012</returns>            
        public InlineResponse20012 V2MeasurementsIdDelete (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling V2MeasurementsIdDelete");
            
    
            var path = "/v2/measurements/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response.Content, typeof(InlineResponse20012), response.Headers);
        }
    
        /// <summary>
        /// Get Measurement Get Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20011</returns>            
        public InlineResponse20011 V2MeasurementsIdGet (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling V2MeasurementsIdGet");
            
    
            var path = "/v2/measurements/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        /// <summary>
        /// Update Measurement Update Measurement
        /// </summary>
        /// <param name="id">id of Measurement</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Measurement that should be updated</param> 
        /// <returns>InlineResponse20012</returns>            
        public InlineResponse20012 V2MeasurementsIdPut (int? id, string accessToken, Measurement body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling V2MeasurementsIdPut");
            
    
            var path = "/v2/measurements/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response.Content, typeof(InlineResponse20012), response.Headers);
        }
    
        /// <summary>
        /// Post Request for Measurements CSV Use this endpoint to schedule a CSV export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>int?</returns>            
        public int? V2MeasurementsRequestCsvPost (string accessToken)
        {
            
    
            var path = "/v2/measurements/request_csv";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsRequestCsvPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsRequestCsvPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        /// Post Request for Measurements PDF Use this endpoint to schedule a PDF export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>int?</returns>            
        public int? V2MeasurementsRequestPdfPost (string accessToken)
        {
            
    
            var path = "/v2/measurements/request_pdf";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsRequestPdfPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsRequestPdfPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
        /// <summary>
        /// Post Request for Measurements XLS Use this endpoint to schedule a XLS export containing all user measurements to be emailed to the user within 24 hours.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>int?</returns>            
        public int? V2MeasurementsRequestXlsPost (string accessToken)
        {
            
    
            var path = "/v2/measurements/request_xls";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsRequestXlsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2MeasurementsRequestXlsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (int?) ApiClient.Deserialize(response.Content, typeof(int?), response.Headers);
        }
    
    }
}
