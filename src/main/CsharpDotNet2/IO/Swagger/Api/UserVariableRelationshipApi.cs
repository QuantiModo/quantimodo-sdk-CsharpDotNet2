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
    public interface IUserVariableRelationshipApi
    {
        
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
        /// <param name="userId">user_id</param>
        /// <param name="vote">vote</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20017</returns>
        InlineResponse20017 UserVariableRelationshipsGet (string accessToken, int? id, string confidenceLevel, double? confidenceScore, string direction, int? durationOfAction, string errorMessage, int? onsetDelay, int? outcomeVariableId, int? predictorVariableId, int? predictorUnitId, double? sinnRank, string strengthLevel, double? strengthScore, int? userId, string vote, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store UserVariableRelationship Store UserVariableRelationship
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be stored</param>
        /// <returns>InlineResponse20029</returns>
        InlineResponse20029 UserVariableRelationshipsPost (string accessToken, UserVariableRelationship body);
        
        /// <summary>
        /// Get UserVariableRelationship Get UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20029</returns>
        InlineResponse20029 UserVariableRelationshipsIdGet (int? id, string accessToken);
        
        /// <summary>
        /// Update UserVariableRelationship Update UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">UserVariableRelationship that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UserVariableRelationshipsIdPut (int? id, string accessToken, UserVariableRelationship body);
        
        /// <summary>
        /// Delete UserVariableRelationship Delete UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 UserVariableRelationshipsIdDelete (int? id, string accessToken);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserVariableRelationshipApi : IUserVariableRelationshipApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableRelationshipApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserVariableRelationshipApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserVariableRelationshipApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserVariableRelationshipApi(String basePath)
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
        /// <param name="userId">user_id</param> 
        /// <param name="vote">vote</param> 
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param> 
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20017</returns>            
        public InlineResponse20017 UserVariableRelationshipsGet (string accessToken, int? id, string confidenceLevel, double? confidenceScore, string direction, int? durationOfAction, string errorMessage, int? onsetDelay, int? outcomeVariableId, int? predictorVariableId, int? predictorUnitId, double? sinnRank, string strengthLevel, double? strengthScore, int? userId, string vote, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, int? limit, int? offset, string sort)
        {
            
    
            var path = "/userVariableRelationships";
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
             if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
             if (vote != null) queryParams.Add("vote", ApiClient.ParameterToString(vote)); // query parameter
             if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
             if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariableRelationshipsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariableRelationshipsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20017) ApiClient.Deserialize(response.Content, typeof(InlineResponse20017), response.Headers);
        }
    
        
        /// <summary>
        /// Store UserVariableRelationship Store UserVariableRelationship
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">UserVariableRelationship that should be stored</param> 
        /// <returns>InlineResponse20029</returns>            
        public InlineResponse20029 UserVariableRelationshipsPost (string accessToken, UserVariableRelationship body)
        {
            
    
            var path = "/userVariableRelationships";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariableRelationshipsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariableRelationshipsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20029) ApiClient.Deserialize(response.Content, typeof(InlineResponse20029), response.Headers);
        }
    
        
        /// <summary>
        /// Get UserVariableRelationship Get UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20029</returns>            
        public InlineResponse20029 UserVariableRelationshipsIdGet (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariableRelationshipsIdGet");
            
    
            var path = "/userVariableRelationships/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariableRelationshipsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariableRelationshipsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20029) ApiClient.Deserialize(response.Content, typeof(InlineResponse20029), response.Headers);
        }
    
        
        /// <summary>
        /// Update UserVariableRelationship Update UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">UserVariableRelationship that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UserVariableRelationshipsIdPut (int? id, string accessToken, UserVariableRelationship body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariableRelationshipsIdPut");
            
    
            var path = "/userVariableRelationships/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariableRelationshipsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariableRelationshipsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete UserVariableRelationship Delete UserVariableRelationship
        /// </summary>
        /// <param name="id">id of UserVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 UserVariableRelationshipsIdDelete (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UserVariableRelationshipsIdDelete");
            
    
            var path = "/userVariableRelationships/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariableRelationshipsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UserVariableRelationshipsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
