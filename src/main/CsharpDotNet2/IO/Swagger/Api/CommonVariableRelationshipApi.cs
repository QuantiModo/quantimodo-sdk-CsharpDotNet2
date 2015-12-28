using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface ICommonVariableRelationshipApi
    {
        
        /// <summary>
        /// Get all CommonVariableRelationships Get all CommonVariableRelationships
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
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param>
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param>
        /// <param name="upVotes">Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="downVotes">Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.</param>
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param>
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param>
        /// <param name="numberOfUsers">Number of users whose data was aggregated to obtain this relationship</param>
        /// <param name="dataSource">data_source</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 CommonVariableRelationshipsGet (string accessToken, int? id, string confidenceLevel, double? confidenceScore, string direction, int? durationOfAction, string errorMessage, int? onsetDelay, int? outcomeVariableId, int? predictorVariableId, int? predictorUnitId, double? sinnRank, double? strengthScore, string strengthLevel, int? upVotes, int? downVotes, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, int? numberOfUsers, string dataSource, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store CommonVariableRelationship Store CommonVariableRelationship
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be stored</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 CommonVariableRelationshipsPost (string accessToken, CommonVariableRelationship body);
        
        /// <summary>
        /// Get CommonVariableRelationship Get CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 CommonVariableRelationshipsIdGet (int? id, string accessToken);
        
        /// <summary>
        /// Update CommonVariableRelationship Update CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">CommonVariableRelationship that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CommonVariableRelationshipsIdPut (int? id, string accessToken, CommonVariableRelationship body);
        
        /// <summary>
        /// Delete CommonVariableRelationship Delete CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CommonVariableRelationshipsIdDelete (int? id, string accessToken);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CommonVariableRelationshipApi : ICommonVariableRelationshipApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonVariableRelationshipApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CommonVariableRelationshipApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonVariableRelationshipApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CommonVariableRelationshipApi(String basePath)
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
        /// <value>An instance of the ApiClient</param>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Get all CommonVariableRelationships Get all CommonVariableRelationships
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
        /// <param name="strengthScore">A value represented to the size of the effect which the predictor appears to have on the outcome.</param> 
        /// <param name="strengthLevel">Can be weak, medium, or strong based on the size of the effect which the predictor appears to have on the outcome relative to other variable relationship strength scores.</param> 
        /// <param name="upVotes">Number of users who feel that there is a plausible causal relationship between the predictor and outcome variables.</param> 
        /// <param name="downVotes">Number of users who do not feel that there is a plausible causal relationship between the predictor and outcome variables.</param> 
        /// <param name="valuePredictingHighOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes an above average outcome value</param> 
        /// <param name="valuePredictingLowOutcome">Value for the predictor variable (in it&#39;s default unit) which typically precedes a below average outcome value</param> 
        /// <param name="numberOfUsers">Number of users whose data was aggregated to obtain this relationship</param> 
        /// <param name="dataSource">data_source</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse2003</returns>            
        public InlineResponse2003 CommonVariableRelationshipsGet (string accessToken, int? id, string confidenceLevel, double? confidenceScore, string direction, int? durationOfAction, string errorMessage, int? onsetDelay, int? outcomeVariableId, int? predictorVariableId, int? predictorUnitId, double? sinnRank, double? strengthScore, string strengthLevel, int? upVotes, int? downVotes, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, int? numberOfUsers, string dataSource, int? limit, int? offset, string sort)
        {
            
    
            var path = "/commonVariableRelationships";
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
             if (strengthScore != null) queryParams.Add("strength_score", ApiClient.ParameterToString(strengthScore)); // query parameter
             if (strengthLevel != null) queryParams.Add("strength_level", ApiClient.ParameterToString(strengthLevel)); // query parameter
             if (upVotes != null) queryParams.Add("up_votes", ApiClient.ParameterToString(upVotes)); // query parameter
             if (downVotes != null) queryParams.Add("down_votes", ApiClient.ParameterToString(downVotes)); // query parameter
             if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
             if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
             if (numberOfUsers != null) queryParams.Add("number_of_users", ApiClient.ParameterToString(numberOfUsers)); // query parameter
             if (dataSource != null) queryParams.Add("data_source", ApiClient.ParameterToString(dataSource)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CommonVariableRelationshipsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommonVariableRelationshipsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
        
        /// <summary>
        /// Store CommonVariableRelationship Store CommonVariableRelationship
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">CommonVariableRelationship that should be stored</param> 
        /// <returns>InlineResponse2004</returns>            
        public InlineResponse2004 CommonVariableRelationshipsPost (string accessToken, CommonVariableRelationship body)
        {
            
    
            var path = "/commonVariableRelationships";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CommonVariableRelationshipsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommonVariableRelationshipsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
        
        /// <summary>
        /// Get CommonVariableRelationship Get CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2004</returns>            
        public InlineResponse2004 CommonVariableRelationshipsIdGet (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CommonVariableRelationshipsIdGet");
            
    
            var path = "/commonVariableRelationships/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CommonVariableRelationshipsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommonVariableRelationshipsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2004) ApiClient.Deserialize(response.Content, typeof(InlineResponse2004), response.Headers);
        }
    
        
        /// <summary>
        /// Update CommonVariableRelationship Update CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">CommonVariableRelationship that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 CommonVariableRelationshipsIdPut (int? id, string accessToken, CommonVariableRelationship body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CommonVariableRelationshipsIdPut");
            
    
            var path = "/commonVariableRelationships/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CommonVariableRelationshipsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommonVariableRelationshipsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete CommonVariableRelationship Delete CommonVariableRelationship
        /// </summary>
        /// <param name="id">id of CommonVariableRelationship</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 CommonVariableRelationshipsIdDelete (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CommonVariableRelationshipsIdDelete");
            
    
            var path = "/commonVariableRelationships/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CommonVariableRelationshipsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CommonVariableRelationshipsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
