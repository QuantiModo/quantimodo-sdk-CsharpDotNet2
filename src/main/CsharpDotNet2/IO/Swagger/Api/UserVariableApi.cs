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
    public interface IUserVariableApi
    {
        
        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="userId">User ID</param>
        /// <param name="defaultUnitId">D of unit to use for this variable</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="variableCategoryId">ID of variable category</param>
        /// <param name="updated">updated</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value</param>
        /// <param name="numberOfMeasurements">Number of measurements</param>
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements</param>
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis</param>
        /// <param name="lastUnitId">ID of last Unit</param>
        /// <param name="lastOriginalUnitId">ID of last original Unit</param>
        /// <param name="lastOriginalValue">Last original value which is stored</param>
        /// <param name="lastValue">Last Value</param>
        /// <param name="lastOriginalValue2">Last original value which is stored</param>
        /// <param name="lastSourceId">ID of last source</param>
        /// <param name="numberOfCorrelations">Number of correlations for this variable</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="standardDeviation">Standard deviation</param>
        /// <param name="variance">Variance</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable</param>
        /// <param name="mean">Mean</param>
        /// <param name="median">Median</param>
        /// <param name="mostCommonUnitId">Most common Unit ID</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values</param>
        /// <param name="numberOfChanges">Number of changes</param>
        /// <param name="skewness">Skewness</param>
        /// <param name="kurtosis">Kurtosis</param>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        /// <param name="location">Location</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</param>
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources</param>
        /// <param name="earliestSourceTime">Earliest source time</param>
        /// <param name="latestSourceTime">Latest source time</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="earliestFillingTime">Earliest filling time</param>
        /// <param name="latestFillingTime">Latest filling time</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 UserVariablesGet (string accessToken, string clientId, int? parentId, int? variableId, int? userId, int? defaultUnitId, double? minimumAllowedValue, double? maximumAllowedValue, double? fillingValue, int? joinWith, int? onsetDelay, int? durationOfAction, int? variableCategoryId, int? updated, int? _public, bool? causeOnly, string fillingType, int? numberOfMeasurements, int? numberOfProcessedMeasurements, int? measurementsAtLastAnalysis, int? lastUnitId, int? lastOriginalUnitId, int? lastOriginalValue, double? lastValue, double? lastOriginalValue2, int? lastSourceId, int? numberOfCorrelations, string status, string errorMessage, string lastSuccessfulUpdateTime, double? standardDeviation, double? variance, double? minimumRecordedValue, double? maximumRecordedValue, double? mean, double? median, int? mostCommonUnitId, double? mostCommonValue, double? numberOfUniqueDailyValues, int? numberOfChanges, double? skewness, double? kurtosis, double? latitude, double? longitude, string location, string createdAt, string updatedAt, bool? outcome, string sources, int? earliestSourceTime, int? latestSourceTime, int? earliestMeasurementTime, int? latestMeasurementTime, int? earliestFillingTime, int? latestFillingTime, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store UserVariable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be stored</param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 UserVariablesPost (string accessToken, UserVariable body);
        
        /// <summary>
        /// Get UserVariable Get UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 UserVariablesIdGet (int? id, string accessToken);
        
        /// <summary>
        /// Update UserVariable Update UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariable that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UserVariablesIdPut (int? id, string accessToken, UserVariable body);
        
        /// <summary>
        /// Delete UserVariable Delete UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UserVariablesIdDelete (int? id, string accessToken);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserVariableApi : IUserVariableApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserVariableApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserVariableApi(String basePath)
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
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param> 
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param> 
        /// <param name="variableId">ID of variable</param> 
        /// <param name="userId">User ID</param> 
        /// <param name="defaultUnitId">D of unit to use for this variable</param> 
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param> 
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param> 
        /// <param name="fillingValue">Value for replacing null measurements</param> 
        /// <param name="joinWith">The Variable this Variable should be joined with. If the variable is joined with some other variable then it is not shown to user in the list of variables</param> 
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param> 
        /// <param name="durationOfAction">Estimated duration of time following the onset delay in which a stimulus produces a perceivable effect</param> 
        /// <param name="variableCategoryId">ID of variable category</param> 
        /// <param name="updated">updated</param> 
        /// <param name="_public">Is variable public</param> 
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param> 
        /// <param name="fillingType">0 -&gt; No filling, 1 -&gt; Use filling-value</param> 
        /// <param name="numberOfMeasurements">Number of measurements</param> 
        /// <param name="numberOfProcessedMeasurements">Number of processed measurements</param> 
        /// <param name="measurementsAtLastAnalysis">Number of measurements at last analysis</param> 
        /// <param name="lastUnitId">ID of last Unit</param> 
        /// <param name="lastOriginalUnitId">ID of last original Unit</param> 
        /// <param name="lastOriginalValue">Last original value which is stored</param> 
        /// <param name="lastValue">Last Value</param> 
        /// <param name="lastOriginalValue2">Last original value which is stored</param> 
        /// <param name="lastSourceId">ID of last source</param> 
        /// <param name="numberOfCorrelations">Number of correlations for this variable</param> 
        /// <param name="status">status</param> 
        /// <param name="errorMessage">error_message</param> 
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param> 
        /// <param name="standardDeviation">Standard deviation</param> 
        /// <param name="variance">Variance</param> 
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable</param> 
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable</param> 
        /// <param name="mean">Mean</param> 
        /// <param name="median">Median</param> 
        /// <param name="mostCommonUnitId">Most common Unit ID</param> 
        /// <param name="mostCommonValue">Most common value</param> 
        /// <param name="numberOfUniqueDailyValues">Number of unique daily values</param> 
        /// <param name="numberOfChanges">Number of changes</param> 
        /// <param name="skewness">Skewness</param> 
        /// <param name="kurtosis">Kurtosis</param> 
        /// <param name="latitude">Latitude</param> 
        /// <param name="longitude">Longitude</param> 
        /// <param name="location">Location</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</param> 
        /// <param name="sources">Comma-separated list of source names to limit variables to those sources</param> 
        /// <param name="earliestSourceTime">Earliest source time</param> 
        /// <param name="latestSourceTime">Latest source time</param> 
        /// <param name="earliestMeasurementTime">Earliest measurement time</param> 
        /// <param name="latestMeasurementTime">Latest measurement time</param> 
        /// <param name="earliestFillingTime">Earliest filling time</param> 
        /// <param name="latestFillingTime">Latest filling time</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2009</returns>            
        public InlineResponse2009 UserVariablesGet (string accessToken, string clientId, int? parentId, int? variableId, int? userId, int? defaultUnitId, double? minimumAllowedValue, double? maximumAllowedValue, double? fillingValue, int? joinWith, int? onsetDelay, int? durationOfAction, int? variableCategoryId, int? updated, int? _public, bool? causeOnly, string fillingType, int? numberOfMeasurements, int? numberOfProcessedMeasurements, int? measurementsAtLastAnalysis, int? lastUnitId, int? lastOriginalUnitId, int? lastOriginalValue, double? lastValue, double? lastOriginalValue2, int? lastSourceId, int? numberOfCorrelations, string status, string errorMessage, string lastSuccessfulUpdateTime, double? standardDeviation, double? variance, double? minimumRecordedValue, double? maximumRecordedValue, double? mean, double? median, int? mostCommonUnitId, double? mostCommonValue, double? numberOfUniqueDailyValues, int? numberOfChanges, double? skewness, double? kurtosis, double? latitude, double? longitude, string location, string createdAt, string updatedAt, bool? outcome, string sources, int? earliestSourceTime, int? latestSourceTime, int? earliestMeasurementTime, int? latestMeasurementTime, int? earliestFillingTime, int? latestFillingTime, int? limit, int? offset, string sort)
        {
            
    
            var path = "/userVariables";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
             if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
             if (parentId != null) queryParams.Add("parent_id", ApiClient.ParameterToString(parentId)); // query parameter
             if (variableId != null) queryParams.Add("variable_id", ApiClient.ParameterToString(variableId)); // query parameter
             if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
             if (defaultUnitId != null) queryParams.Add("default_unit_id", ApiClient.ParameterToString(defaultUnitId)); // query parameter
             if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
             if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
             if (fillingValue != null) queryParams.Add("filling_value", ApiClient.ParameterToString(fillingValue)); // query parameter
             if (joinWith != null) queryParams.Add("join_with", ApiClient.ParameterToString(joinWith)); // query parameter
             if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
             if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
             if (variableCategoryId != null) queryParams.Add("variable_category_id", ApiClient.ParameterToString(variableCategoryId)); // query parameter
             if (updated != null) queryParams.Add("updated", ApiClient.ParameterToString(updated)); // query parameter
             if (_public != null) queryParams.Add("public", ApiClient.ParameterToString(_public)); // query parameter
             if (causeOnly != null) queryParams.Add("cause_only", ApiClient.ParameterToString(causeOnly)); // query parameter
             if (fillingType != null) queryParams.Add("filling_type", ApiClient.ParameterToString(fillingType)); // query parameter
             if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
             if (numberOfProcessedMeasurements != null) queryParams.Add("number_of_processed_measurements", ApiClient.ParameterToString(numberOfProcessedMeasurements)); // query parameter
             if (measurementsAtLastAnalysis != null) queryParams.Add("measurements_at_last_analysis", ApiClient.ParameterToString(measurementsAtLastAnalysis)); // query parameter
             if (lastUnitId != null) queryParams.Add("last_unit_id", ApiClient.ParameterToString(lastUnitId)); // query parameter
             if (lastOriginalUnitId != null) queryParams.Add("last_original_unit_id", ApiClient.ParameterToString(lastOriginalUnitId)); // query parameter
             if (lastOriginalValue != null) queryParams.Add("last_original_value", ApiClient.ParameterToString(lastOriginalValue)); // query parameter
             if (lastValue != null) queryParams.Add("last_value", ApiClient.ParameterToString(lastValue)); // query parameter
             if (lastOriginalValue2 != null) queryParams.Add("last_original_value", ApiClient.ParameterToString(lastOriginalValue2)); // query parameter
             if (lastSourceId != null) queryParams.Add("last_source_id", ApiClient.ParameterToString(lastSourceId)); // query parameter
             if (numberOfCorrelations != null) queryParams.Add("number_of_correlations", ApiClient.ParameterToString(numberOfCorrelations)); // query parameter
             if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
             if (errorMessage != null) queryParams.Add("error_message", ApiClient.ParameterToString(errorMessage)); // query parameter
             if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
             if (standardDeviation != null) queryParams.Add("standard_deviation", ApiClient.ParameterToString(standardDeviation)); // query parameter
             if (variance != null) queryParams.Add("variance", ApiClient.ParameterToString(variance)); // query parameter
             if (minimumRecordedValue != null) queryParams.Add("minimum_recorded_value", ApiClient.ParameterToString(minimumRecordedValue)); // query parameter
             if (maximumRecordedValue != null) queryParams.Add("maximum_recorded_value", ApiClient.ParameterToString(maximumRecordedValue)); // query parameter
             if (mean != null) queryParams.Add("mean", ApiClient.ParameterToString(mean)); // query parameter
             if (median != null) queryParams.Add("median", ApiClient.ParameterToString(median)); // query parameter
             if (mostCommonUnitId != null) queryParams.Add("most_common_unit_id", ApiClient.ParameterToString(mostCommonUnitId)); // query parameter
             if (mostCommonValue != null) queryParams.Add("most_common_value", ApiClient.ParameterToString(mostCommonValue)); // query parameter
             if (numberOfUniqueDailyValues != null) queryParams.Add("number_of_unique_daily_values", ApiClient.ParameterToString(numberOfUniqueDailyValues)); // query parameter
             if (numberOfChanges != null) queryParams.Add("number_of_changes", ApiClient.ParameterToString(numberOfChanges)); // query parameter
             if (skewness != null) queryParams.Add("skewness", ApiClient.ParameterToString(skewness)); // query parameter
             if (kurtosis != null) queryParams.Add("kurtosis", ApiClient.ParameterToString(kurtosis)); // query parameter
             if (latitude != null) queryParams.Add("latitude", ApiClient.ParameterToString(latitude)); // query parameter
             if (longitude != null) queryParams.Add("longitude", ApiClient.ParameterToString(longitude)); // query parameter
             if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
             if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
             if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
             if (outcome != null) queryParams.Add("outcome", ApiClient.ParameterToString(outcome)); // query parameter
             if (sources != null) queryParams.Add("sources", ApiClient.ParameterToString(sources)); // query parameter
             if (earliestSourceTime != null) queryParams.Add("earliest_source_time", ApiClient.ParameterToString(earliestSourceTime)); // query parameter
             if (latestSourceTime != null) queryParams.Add("latest_source_time", ApiClient.ParameterToString(latestSourceTime)); // query parameter
             if (earliestMeasurementTime != null) queryParams.Add("earliest_measurement_time", ApiClient.ParameterToString(earliestMeasurementTime)); // query parameter
             if (latestMeasurementTime != null) queryParams.Add("latest_measurement_time", ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
             if (earliestFillingTime != null) queryParams.Add("earliest_filling_time", ApiClient.ParameterToString(earliestFillingTime)); // query parameter
             if (latestFillingTime != null) queryParams.Add("latest_filling_time", ApiClient.ParameterToString(latestFillingTime)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2009) ApiClient.Deserialize(response.Content, typeof(InlineResponse2009), response.Headers);
        }
    
        
        /// <summary>
        /// Store UserVariable Users can change things like the display name for a variable. They can also change the parameters used in analysis of that variable such as the expected duration of action for a variable to have an effect, the estimated delay before the onset of action. In order to filter out erroneous data, they are able to set the maximum and minimum reasonable daily values for a variable.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">UserVariable that should be stored</param> 
        /// <returns>InlineResponse20030</returns>            
        public InlineResponse20030 UserVariablesPost (string accessToken, UserVariable body)
        {
            
    
            var path = "/userVariables";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20030) ApiClient.Deserialize(response.Content, typeof(InlineResponse20030), response.Headers);
        }
    
        
        /// <summary>
        /// Get UserVariable Get UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20030</returns>            
        public InlineResponse20030 UserVariablesIdGet (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariablesIdGet");
            
    
            var path = "/userVariables/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20030) ApiClient.Deserialize(response.Content, typeof(InlineResponse20030), response.Headers);
        }
    
        
        /// <summary>
        /// Update UserVariable Update UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">UserVariable that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UserVariablesIdPut (int? id, string accessToken, UserVariable body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariablesIdPut");
            
    
            var path = "/userVariables/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete UserVariable Delete UserVariable
        /// </summary>
        /// <param name="id">id of UserVariable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UserVariablesIdDelete (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariablesIdDelete");
            
    
            var path = "/userVariables/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariablesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
