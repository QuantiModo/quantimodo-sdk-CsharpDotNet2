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
    public interface IApplicationEndpointsApi
    {
        /// <summary>
        /// Get all Connections Get all Connections
        /// </summary>
        /// <param name="accessToken">Application&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param>
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param>
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param>
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param>
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param>
        /// <param name="updateError">Indicates if there was an error during the update.</param>
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 V2ApplicationConnectionsGet (string accessToken, int? connectorId, string connectStatus, string connectError, string updateRequestedAt, string updateStatus, string updateError, string lastSuccessfulUpdatedAt, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="accessToken">Application&#39;s OAuth2 access token</param>
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param>
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param>
        /// <param name="attrValue">Encrypted value for the attribute specified</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 V2ApplicationCredentialsGet (string accessToken, int? connectorId, string attrKey, string attrValue, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        /// <summary>
        /// Get measurements for all users using your application Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <param name="accessToken">Application&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param>
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param>
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param>
        /// <param name="sourceId">Application or device used to record the measurement values</param>
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format </param>
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param>
        /// <param name="unitId">The default unit id for the variable</param>
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param>
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param>
        /// <param name="duration">Duration of the event being measurement in seconds</param>
        /// <param name="note">An optional note the user may include with their measurement</param>
        /// <param name="latitude">Latitude at which the measurement was taken</param>
        /// <param name="longitude">Longitude at which the measurement was taken</param>
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param>
        /// <param name="error">An error message if there is a problem with the measurement</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 V2ApplicationMeasurementsGet (string accessToken, string clientId, int? connectorId, int? variableId, int? sourceId, string startTime, double? value, int? unitId, double? originalValue, int? originalUnitId, int? duration, string note, double? latitude, double? longitude, string location, string createdAt, string updatedAt, string error, int? limit, int? offset, string sort);
        /// <summary>
        /// Get tracking reminders Get the variable id, frequency, and default value for the user tracking reminders 
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this trackingReminder</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 V2ApplicationTrackingRemindersGet (string accessToken, string clientId, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        /// <summary>
        /// Get all Updates Get all Updates
        /// </summary>
        /// <param name="accessToken">Application&#39;s OAuth2 access token</param>
        /// <param name="connectorId">connector_id</param>
        /// <param name="numberOfMeasurements">number_of_measurements</param>
        /// <param name="success">success</param>
        /// <param name="message">message</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 V2ApplicationUpdatesGet (string accessToken, int? connectorId, int? numberOfMeasurements, bool? success, string message, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        /// <summary>
        /// Get all UserVariableRelationships Get all UserVariableRelationships
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param>
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="outcomeVariableId">Variable ID for the outcome variable</param>
        /// <param name="predictorVariableId">Variable ID for the predictor variable</param>
        /// <param name="predictorUnitId">ID for default unit of the predictor variable</param>
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="vote">vote</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 V2ApplicationUserVariableRelationshipsGet (string accessToken, int? id, string confidenceLevel, double? confidenceScore, string direction, int? durationOfAction, string errorMessage, int? onsetDelay, int? outcomeVariableId, int? predictorVariableId, int? predictorUnitId, double? sinnRank, string strengthLevel, double? strengthScore, string vote, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, int? limit, int? offset, string sort);
        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="variableId">ID of variable</param>
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
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param>
        /// <param name="outcome">Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</param>
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
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 V2ApplicationUserVariablesGet (string accessToken, string clientId, int? parentId, int? variableId, int? defaultUnitId, double? minimumAllowedValue, double? maximumAllowedValue, double? fillingValue, int? joinWith, int? onsetDelay, int? durationOfAction, int? variableCategoryId, int? updated, int? _public, bool? causeOnly, string fillingType, int? numberOfMeasurements, int? numberOfProcessedMeasurements, int? measurementsAtLastAnalysis, int? lastUnitId, int? lastOriginalUnitId, int? lastOriginalValue, double? lastValue, int? lastSourceId, int? numberOfCorrelations, string status, string errorMessage, string lastSuccessfulUpdateTime, double? standardDeviation, double? variance, double? minimumRecordedValue, double? maximumRecordedValue, double? mean, double? median, int? mostCommonUnitId, double? mostCommonValue, double? numberOfUniqueDailyValues, int? numberOfChanges, double? skewness, double? kurtosis, double? latitude, double? longitude, string location, string createdAt, string updatedAt, bool? outcome, string sources, int? earliestSourceTime, int? latestSourceTime, int? earliestMeasurementTime, int? latestMeasurementTime, int? earliestFillingTime, int? latestFillingTime, int? limit, int? offset, string sort);
        /// <summary>
        /// Get all VariableUserSources Get all VariableUserSources
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="variableId">ID of variable</param>
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</param>
        /// <param name="earliestMeasurementTime">Earliest measurement time</param>
        /// <param name="latestMeasurementTime">Latest measurement time</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 V2ApplicationVariableUserSourcesGet (string accessToken, int? variableId, int? timestamp, int? earliestMeasurementTime, int? latestMeasurementTime, string createdAt, string updatedAt, int? limit, int? offset, string sort);
        /// <summary>
        /// Get all Votes Get all Votes
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="clientId">The ID of the client application which last created or updated this vote</param>
        /// <param name="causeId">ID of predictor variable</param>
        /// <param name="effectId">ID of outcome variable</param>
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote.</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 V2ApplicationVotesGet (string accessToken, string clientId, int? causeId, int? effectId, int? value, string createdAt, string updatedAt, int? limit, int? offset, string sort);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ApplicationEndpointsApi : IApplicationEndpointsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationEndpointsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ApplicationEndpointsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationEndpointsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApplicationEndpointsApi(String basePath)
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
        /// Get all Connections Get all Connections
        /// </summary>
        /// <param name="accessToken">Application&#39;s OAuth2 access token</param> 
        /// <param name="connectorId">The id for the connector data source for which the connection is connected</param> 
        /// <param name="connectStatus">Indicates whether a connector is currently connected to a service for a user.</param> 
        /// <param name="connectError">Error message if there is a problem with authorizing this connection.</param> 
        /// <param name="updateRequestedAt">Time at which an update was requested by a user.</param> 
        /// <param name="updateStatus">Indicates whether a connector is currently updated.</param> 
        /// <param name="updateError">Indicates if there was an error during the update.</param> 
        /// <param name="lastSuccessfulUpdatedAt">The time at which the connector was last successfully updated.</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2003</returns>            
        public InlineResponse2003 V2ApplicationConnectionsGet (string accessToken, int? connectorId, string connectStatus, string connectError, string updateRequestedAt, string updateStatus, string updateError, string lastSuccessfulUpdatedAt, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/v2/application/connections";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
 if (connectStatus != null) queryParams.Add("connect_status", ApiClient.ParameterToString(connectStatus)); // query parameter
 if (connectError != null) queryParams.Add("connect_error", ApiClient.ParameterToString(connectError)); // query parameter
 if (updateRequestedAt != null) queryParams.Add("update_requested_at", ApiClient.ParameterToString(updateRequestedAt)); // query parameter
 if (updateStatus != null) queryParams.Add("update_status", ApiClient.ParameterToString(updateStatus)); // query parameter
 if (updateError != null) queryParams.Add("update_error", ApiClient.ParameterToString(updateError)); // query parameter
 if (lastSuccessfulUpdatedAt != null) queryParams.Add("last_successful_updated_at", ApiClient.ParameterToString(lastSuccessfulUpdatedAt)); // query parameter
 if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
 if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2", "internalApiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationConnectionsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationConnectionsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
        /// <summary>
        /// Get all Credentials Get all Credentials
        /// </summary>
        /// <param name="accessToken">Application&#39;s OAuth2 access token</param> 
        /// <param name="connectorId">The id for the connector data source from which the credential was obtained</param> 
        /// <param name="attrKey">Attribute name such as token, userid, username, or password</param> 
        /// <param name="attrValue">Encrypted value for the attribute specified</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2004</returns>            
        public InlineResponse2004 V2ApplicationCredentialsGet (string accessToken, int? connectorId, string attrKey, string attrValue, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/v2/application/credentials";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
 if (attrKey != null) queryParams.Add("attr_key", ApiClient.ParameterToString(attrKey)); // query parameter
 if (attrValue != null) queryParams.Add("attr_value", ApiClient.ParameterToString(attrValue)); // query parameter
 if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
 if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2", "internalApiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationCredentialsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationCredentialsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
        /// <summary>
        /// Get measurements for all users using your application Measurements are any value that can be recorded like daily steps, a mood rating, or apples eaten.
        /// </summary>
        /// <param name="accessToken">Application&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which originally stored the measurement</param> 
        /// <param name="connectorId">The id for the connector data source from which the measurement was obtained</param> 
        /// <param name="variableId">ID of the variable for which we are creating the measurement records</param> 
        /// <param name="sourceId">Application or device used to record the measurement values</param> 
        /// <param name="startTime">start time for the measurement event. Use ISO 8601 datetime format </param> 
        /// <param name="value">The value of the measurement after conversion to the default unit for that variable</param> 
        /// <param name="unitId">The default unit id for the variable</param> 
        /// <param name="originalValue">Unconverted value of measurement as originally posted (before conversion to default unit)</param> 
        /// <param name="originalUnitId">Unit id of the measurement as originally submitted</param> 
        /// <param name="duration">Duration of the event being measurement in seconds</param> 
        /// <param name="note">An optional note the user may include with their measurement</param> 
        /// <param name="latitude">Latitude at which the measurement was taken</param> 
        /// <param name="longitude">Longitude at which the measurement was taken</param> 
        /// <param name="location">Optional human readable name for the location where the measurement was recorded</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param> 
        /// <param name="error">An error message if there is a problem with the measurement</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2005</returns>            
        public InlineResponse2005 V2ApplicationMeasurementsGet (string accessToken, string clientId, int? connectorId, int? variableId, int? sourceId, string startTime, double? value, int? unitId, double? originalValue, int? originalUnitId, int? duration, string note, double? latitude, double? longitude, string location, string createdAt, string updatedAt, string error, int? limit, int? offset, string sort)
        {
            
    
            var path = "/v2/application/measurements";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
 if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
 if (variableId != null) queryParams.Add("variable_id", ApiClient.ParameterToString(variableId)); // query parameter
 if (sourceId != null) queryParams.Add("source_id", ApiClient.ParameterToString(sourceId)); // query parameter
 if (startTime != null) queryParams.Add("start_time", ApiClient.ParameterToString(startTime)); // query parameter
 if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
 if (unitId != null) queryParams.Add("unit_id", ApiClient.ParameterToString(unitId)); // query parameter
 if (originalValue != null) queryParams.Add("original_value", ApiClient.ParameterToString(originalValue)); // query parameter
 if (originalUnitId != null) queryParams.Add("original_unit_id", ApiClient.ParameterToString(originalUnitId)); // query parameter
 if (duration != null) queryParams.Add("duration", ApiClient.ParameterToString(duration)); // query parameter
 if (note != null) queryParams.Add("note", ApiClient.ParameterToString(note)); // query parameter
 if (latitude != null) queryParams.Add("latitude", ApiClient.ParameterToString(latitude)); // query parameter
 if (longitude != null) queryParams.Add("longitude", ApiClient.ParameterToString(longitude)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
 if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
 if (error != null) queryParams.Add("error", ApiClient.ParameterToString(error)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2", "internalApiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationMeasurementsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationMeasurementsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2005) ApiClient.Deserialize(response.Content, typeof(InlineResponse2005), response.Headers);
        }
    
        /// <summary>
        /// Get tracking reminders Get the variable id, frequency, and default value for the user tracking reminders 
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this trackingReminder</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 V2ApplicationTrackingRemindersGet (string accessToken, string clientId, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/v2/application/trackingReminders";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
 if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
 if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2", "internalApiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationTrackingRemindersGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationTrackingRemindersGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        /// <summary>
        /// Get all Updates Get all Updates
        /// </summary>
        /// <param name="accessToken">Application&#39;s OAuth2 access token</param> 
        /// <param name="connectorId">connector_id</param> 
        /// <param name="numberOfMeasurements">number_of_measurements</param> 
        /// <param name="success">success</param> 
        /// <param name="message">message</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2006</returns>            
        public InlineResponse2006 V2ApplicationUpdatesGet (string accessToken, int? connectorId, int? numberOfMeasurements, bool? success, string message, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/v2/application/updates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (connectorId != null) queryParams.Add("connector_id", ApiClient.ParameterToString(connectorId)); // query parameter
 if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
 if (success != null) queryParams.Add("success", ApiClient.ParameterToString(success)); // query parameter
 if (message != null) queryParams.Add("message", ApiClient.ParameterToString(message)); // query parameter
 if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
 if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2", "internalApiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationUpdatesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationUpdatesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2006) ApiClient.Deserialize(response.Content, typeof(InlineResponse2006), response.Headers);
        }
    
        /// <summary>
        /// Get all UserVariableRelationships Get all UserVariableRelationships
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="id">id</param> 
        /// <param name="confidenceLevel">Our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param> 
        /// <param name="confidenceScore">A quantitative representation of our confidence that a consistent predictive relationship exists based on the amount of evidence, reproducibility, and other factors</param> 
        /// <param name="direction">Direction is positive if higher predictor values generally precede higher outcome values. Direction is negative if higher predictor values generally precede lower outcome values.</param> 
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param> 
        /// <param name="errorMessage">error_message</param> 
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param> 
        /// <param name="outcomeVariableId">Variable ID for the outcome variable</param> 
        /// <param name="predictorVariableId">Variable ID for the predictor variable</param> 
        /// <param name="predictorUnitId">ID for default unit of the predictor variable</param> 
        /// <param name="sinnRank">A value representative of the relevance of this predictor relative to other predictors of this outcome.  Usually used for relevancy sorting.</param> 
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param> 
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param> 
        /// <param name="vote">vote</param> 
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param> 
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2007</returns>            
        public InlineResponse2007 V2ApplicationUserVariableRelationshipsGet (string accessToken, int? id, string confidenceLevel, double? confidenceScore, string direction, int? durationOfAction, string errorMessage, int? onsetDelay, int? outcomeVariableId, int? predictorVariableId, int? predictorUnitId, double? sinnRank, string strengthLevel, double? strengthScore, string vote, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, int? limit, int? offset, string sort)
        {
            
    
            var path = "/v2/application/userVariableRelationships";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (confidenceLevel != null) queryParams.Add("confidence_level", ApiClient.ParameterToString(confidenceLevel)); // query parameter
 if (confidenceScore != null) queryParams.Add("confidence_score", ApiClient.ParameterToString(confidenceScore)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
 if (errorMessage != null) queryParams.Add("error_message", ApiClient.ParameterToString(errorMessage)); // query parameter
 if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
 if (outcomeVariableId != null) queryParams.Add("outcome_variable_id", ApiClient.ParameterToString(outcomeVariableId)); // query parameter
 if (predictorVariableId != null) queryParams.Add("predictor_variable_id", ApiClient.ParameterToString(predictorVariableId)); // query parameter
 if (predictorUnitId != null) queryParams.Add("predictor_unit_id", ApiClient.ParameterToString(predictorUnitId)); // query parameter
 if (sinnRank != null) queryParams.Add("sinn_rank", ApiClient.ParameterToString(sinnRank)); // query parameter
 if (strengthLevel != null) queryParams.Add("strength_level", ApiClient.ParameterToString(strengthLevel)); // query parameter
 if (strengthScore != null) queryParams.Add("strength_score", ApiClient.ParameterToString(strengthScore)); // query parameter
 if (vote != null) queryParams.Add("vote", ApiClient.ParameterToString(vote)); // query parameter
 if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
 if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2", "internalApiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationUserVariableRelationshipsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationUserVariableRelationshipsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2007) ApiClient.Deserialize(response.Content, typeof(InlineResponse2007), response.Headers);
        }
    
        /// <summary>
        /// Get all UserVariables Get all UserVariables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this user variable</param> 
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param> 
        /// <param name="variableId">ID of variable</param> 
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
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param> 
        /// <param name="outcome">Outcome variables (those with &#x60;outcome&#x60; &#x3D;&#x3D; 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables</param> 
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
        /// <returns>InlineResponse2008</returns>            
        public InlineResponse2008 V2ApplicationUserVariablesGet (string accessToken, string clientId, int? parentId, int? variableId, int? defaultUnitId, double? minimumAllowedValue, double? maximumAllowedValue, double? fillingValue, int? joinWith, int? onsetDelay, int? durationOfAction, int? variableCategoryId, int? updated, int? _public, bool? causeOnly, string fillingType, int? numberOfMeasurements, int? numberOfProcessedMeasurements, int? measurementsAtLastAnalysis, int? lastUnitId, int? lastOriginalUnitId, int? lastOriginalValue, double? lastValue, int? lastSourceId, int? numberOfCorrelations, string status, string errorMessage, string lastSuccessfulUpdateTime, double? standardDeviation, double? variance, double? minimumRecordedValue, double? maximumRecordedValue, double? mean, double? median, int? mostCommonUnitId, double? mostCommonValue, double? numberOfUniqueDailyValues, int? numberOfChanges, double? skewness, double? kurtosis, double? latitude, double? longitude, string location, string createdAt, string updatedAt, bool? outcome, string sources, int? earliestSourceTime, int? latestSourceTime, int? earliestMeasurementTime, int? latestMeasurementTime, int? earliestFillingTime, int? latestFillingTime, int? limit, int? offset, string sort)
        {
            
    
            var path = "/v2/application/userVariables";
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
            String[] authSettings = new String[] { "oauth2", "internalApiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationUserVariablesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationUserVariablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2008) ApiClient.Deserialize(response.Content, typeof(InlineResponse2008), response.Headers);
        }
    
        /// <summary>
        /// Get all VariableUserSources Get all VariableUserSources
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="variableId">ID of variable</param> 
        /// <param name="timestamp">Time that this measurement occurred Uses epoch minute (epoch time divided by 60)</param> 
        /// <param name="earliestMeasurementTime">Earliest measurement time</param> 
        /// <param name="latestMeasurementTime">Latest measurement time</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2009</returns>            
        public InlineResponse2009 V2ApplicationVariableUserSourcesGet (string accessToken, int? variableId, int? timestamp, int? earliestMeasurementTime, int? latestMeasurementTime, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/v2/application/variableUserSources";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (variableId != null) queryParams.Add("variable_id", ApiClient.ParameterToString(variableId)); // query parameter
 if (timestamp != null) queryParams.Add("timestamp", ApiClient.ParameterToString(timestamp)); // query parameter
 if (earliestMeasurementTime != null) queryParams.Add("earliest_measurement_time", ApiClient.ParameterToString(earliestMeasurementTime)); // query parameter
 if (latestMeasurementTime != null) queryParams.Add("latest_measurement_time", ApiClient.ParameterToString(latestMeasurementTime)); // query parameter
 if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
 if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2", "internalApiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationVariableUserSourcesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationVariableUserSourcesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2009) ApiClient.Deserialize(response.Content, typeof(InlineResponse2009), response.Headers);
        }
    
        /// <summary>
        /// Get all Votes Get all Votes
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this vote</param> 
        /// <param name="causeId">ID of predictor variable</param> 
        /// <param name="effectId">ID of outcome variable</param> 
        /// <param name="value">Value of Vote. 1 is for upvote. 0 is for downvote.  Otherwise, there is no vote.</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format </param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format </param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20010</returns>            
        public InlineResponse20010 V2ApplicationVotesGet (string accessToken, string clientId, int? causeId, int? effectId, int? value, string createdAt, string updatedAt, int? limit, int? offset, string sort)
        {
            
    
            var path = "/v2/application/votes";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
 if (causeId != null) queryParams.Add("cause_id", ApiClient.ParameterToString(causeId)); // query parameter
 if (effectId != null) queryParams.Add("effect_id", ApiClient.ParameterToString(effectId)); // query parameter
 if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
 if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
 if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2", "internalApiKey" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationVotesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V2ApplicationVotesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20010) ApiClient.Deserialize(response.Content, typeof(InlineResponse20010), response.Headers);
        }
    
    }
}
