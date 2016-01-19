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
    public interface ICorrelationApi
    {
        
        /// <summary>
        /// Get all Correlations Get all Correlations
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="timestamp">Time at which correlation was calculated</param>
        /// <param name="userId">ID of user that owns this correlation</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated or default time after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Time over which the cause is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of points that went into the correlation calculation</param>
        /// <param name="valuePredictingHighOutcome">cause value that predicts an above average effect value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">cause value that predicts a below average effect value (in default unit for predictor variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="vote">Vote</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Unit of the predictor variable</param>
        /// <param name="causeUnitId">Unit ID of the predictor variable</param>
        /// <param name="causeChanges">Cause changes</param>
        /// <param name="effectChanges">Effect changes</param>
        /// <param name="qmScore">QM Score</param>
        /// <param name="error">error</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record in the database was last updated. Use ISO 8601 datetime format</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 CorrelationsGet (string accessToken, int? timestamp, int? userId, double? correlation, int? causeId, int? effectId, int? onsetDelay, int? durationOfAction, int? numberOfPairs, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, double? optimalPearsonProduct, double? vote, double? statisticalSignificance, string causeUnit, int? causeUnitId, int? causeChanges, int? effectChanges, double? qmScore, string error, string createdAt, string updatedAt, double? reversePearsonCorrelationCoefficient, double? predictivePearsonCorrelationCoefficient, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Correlation Store Correlation
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be stored</param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 CorrelationsPost (string accessToken, Correlation body);
        
        /// <summary>
        /// Get Correlation Details Get Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 CorrelationsIdGet (int? id, string accessToken);
        
        /// <summary>
        /// Update Correlation Update Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Correlation that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CorrelationsIdPut (int? id, string accessToken, Correlation body);
        
        /// <summary>
        /// Delete Correlation Delete Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 CorrelationsIdDelete (int? id, string accessToken);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CorrelationApi : ICorrelationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrelationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CorrelationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrelationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CorrelationApi(String basePath)
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
        /// Get all Correlations Get all Correlations
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="timestamp">Time at which correlation was calculated</param> 
        /// <param name="userId">ID of user that owns this correlation</param> 
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param> 
        /// <param name="causeId">variable ID of the predictor variable for which the user desires correlations</param> 
        /// <param name="effectId">variable ID of the outcome variable for which the user desires correlations</param> 
        /// <param name="onsetDelay">User estimated or default time after cause measurement before a perceivable effect is observed</param> 
        /// <param name="durationOfAction">Time over which the cause is expected to produce a perceivable effect following the onset delay</param> 
        /// <param name="numberOfPairs">Number of points that went into the correlation calculation</param> 
        /// <param name="valuePredictingHighOutcome">cause value that predicts an above average effect value (in default unit for predictor variable)</param> 
        /// <param name="valuePredictingLowOutcome">cause value that predicts a below average effect value (in default unit for predictor variable)</param> 
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param> 
        /// <param name="vote">Vote</param> 
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param> 
        /// <param name="causeUnit">Unit of the predictor variable</param> 
        /// <param name="causeUnitId">Unit ID of the predictor variable</param> 
        /// <param name="causeChanges">Cause changes</param> 
        /// <param name="effectChanges">Effect changes</param> 
        /// <param name="qmScore">QM Score</param> 
        /// <param name="error">error</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record in the database was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param> 
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param> 
        /// <param name="limit">Limit the number of results returned</param> 
        /// <param name="offset">Records from give Offset</param> 
        /// <param name="sort">Sort records by given field</param> 
        /// <returns>InlineResponse2009</returns>            
        public InlineResponse2009 CorrelationsGet (string accessToken, int? timestamp, int? userId, double? correlation, int? causeId, int? effectId, int? onsetDelay, int? durationOfAction, int? numberOfPairs, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, double? optimalPearsonProduct, double? vote, double? statisticalSignificance, string causeUnit, int? causeUnitId, int? causeChanges, int? effectChanges, double? qmScore, string error, string createdAt, string updatedAt, double? reversePearsonCorrelationCoefficient, double? predictivePearsonCorrelationCoefficient, int? limit, int? offset, string sort)
        {
            
    
            var path = "/correlations";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
             if (timestamp != null) queryParams.Add("timestamp", ApiClient.ParameterToString(timestamp)); // query parameter
             if (userId != null) queryParams.Add("user_id", ApiClient.ParameterToString(userId)); // query parameter
             if (correlation != null) queryParams.Add("correlation", ApiClient.ParameterToString(correlation)); // query parameter
             if (causeId != null) queryParams.Add("cause_id", ApiClient.ParameterToString(causeId)); // query parameter
             if (effectId != null) queryParams.Add("effect_id", ApiClient.ParameterToString(effectId)); // query parameter
             if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
             if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
             if (numberOfPairs != null) queryParams.Add("number_of_pairs", ApiClient.ParameterToString(numberOfPairs)); // query parameter
             if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
             if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
             if (optimalPearsonProduct != null) queryParams.Add("optimal_pearson_product", ApiClient.ParameterToString(optimalPearsonProduct)); // query parameter
             if (vote != null) queryParams.Add("vote", ApiClient.ParameterToString(vote)); // query parameter
             if (statisticalSignificance != null) queryParams.Add("statistical_significance", ApiClient.ParameterToString(statisticalSignificance)); // query parameter
             if (causeUnit != null) queryParams.Add("cause_unit", ApiClient.ParameterToString(causeUnit)); // query parameter
             if (causeUnitId != null) queryParams.Add("cause_unit_id", ApiClient.ParameterToString(causeUnitId)); // query parameter
             if (causeChanges != null) queryParams.Add("cause_changes", ApiClient.ParameterToString(causeChanges)); // query parameter
             if (effectChanges != null) queryParams.Add("effect_changes", ApiClient.ParameterToString(effectChanges)); // query parameter
             if (qmScore != null) queryParams.Add("qm_score", ApiClient.ParameterToString(qmScore)); // query parameter
             if (error != null) queryParams.Add("error", ApiClient.ParameterToString(error)); // query parameter
             if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
             if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
             if (reversePearsonCorrelationCoefficient != null) queryParams.Add("reverse_pearson_correlation_coefficient", ApiClient.ParameterToString(reversePearsonCorrelationCoefficient)); // query parameter
             if (predictivePearsonCorrelationCoefficient != null) queryParams.Add("predictive_pearson_correlation_coefficient", ApiClient.ParameterToString(predictivePearsonCorrelationCoefficient)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2009) ApiClient.Deserialize(response.Content, typeof(InlineResponse2009), response.Headers);
        }
    
        
        /// <summary>
        /// Store Correlation Store Correlation
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Correlation that should be stored</param> 
        /// <returns>InlineResponse20010</returns>            
        public InlineResponse20010 CorrelationsPost (string accessToken, Correlation body)
        {
            
    
            var path = "/correlations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20010) ApiClient.Deserialize(response.Content, typeof(InlineResponse20010), response.Headers);
        }
    
        
        /// <summary>
        /// Get Correlation Details Get Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20010</returns>            
        public InlineResponse20010 CorrelationsIdGet (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationsIdGet");
            
    
            var path = "/correlations/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20010) ApiClient.Deserialize(response.Content, typeof(InlineResponse20010), response.Headers);
        }
    
        
        /// <summary>
        /// Update Correlation Update Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Correlation that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 CorrelationsIdPut (int? id, string accessToken, Correlation body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationsIdPut");
            
    
            var path = "/correlations/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete Correlation Delete Correlation
        /// </summary>
        /// <param name="id">id of Correlation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 CorrelationsIdDelete (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CorrelationsIdDelete");
            
    
            var path = "/correlations/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CorrelationsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
