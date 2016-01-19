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
    public interface IAggregatedCorrelationApi
    {
        
        /// <summary>
        /// Get all AggregatedCorrelations Get all AggregatedCorrelations
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param>
        /// <param name="causeId">Variable ID of the predictor variable for which the user desires correlations</param>
        /// <param name="effectId">Variable ID of the outcome variable for which the user desires correlations</param>
        /// <param name="onsetDelay">User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</param>
        /// <param name="durationOfAction">Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay</param>
        /// <param name="numberOfPairs">Number of predictor/outcome data points used in the analysis</param>
        /// <param name="valuePredictingHighOutcome">Predictor daily aggregated measurement value that predicts an above average effect measurement value (in default unit for predictor variable)</param>
        /// <param name="valuePredictingLowOutcome">Predictor daily aggregated measurement value that predicts a below average effect measurement value (in default unit for outcome variable)</param>
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param>
        /// <param name="numberOfUsers">Number of users whose data was used in this aggregation</param>
        /// <param name="numberOfCorrelations">Number of correlational analyses used in this aggregation</param>
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param>
        /// <param name="causeUnit">Abbreviated unit name for the predictor variable</param>
        /// <param name="causeUnitId">Unit ID for the predictor variable</param>
        /// <param name="causeChanges">Number of times that the predictor time series changes</param>
        /// <param name="effectChanges">Number of times that the predictor time series changes</param>
        /// <param name="aggregateQmScore">Aggregated QM Score which is directly proportional with the relevance of each predictor or outcome</param>
        /// <param name="createdAt">Date at which the analysis was first performed</param>
        /// <param name="updatedAt">Date at which the analysis was last updated</param>
        /// <param name="status">Indicates whether an analysis is up to date (UPDATED), needs to be updated (WAITING), or had an error (ERROR)</param>
        /// <param name="errorMessage">Message describing any problems encountered during the analysis</param>
        /// <param name="lastSuccessfulUpdateTime">Last Successful update time</param>
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param>
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param>
        /// <param name="limit">Limit the number of results returned</param>
        /// <param name="offset">Records from give Offset</param>
        /// <param name="sort">Sort records by given field</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 AggregatedCorrelationsGet (string accessToken, double? correlation, int? causeId, int? effectId, int? onsetDelay, int? durationOfAction, int? numberOfPairs, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, double? optimalPearsonProduct, int? numberOfUsers, int? numberOfCorrelations, double? statisticalSignificance, string causeUnit, int? causeUnitId, int? causeChanges, int? effectChanges, double? aggregateQmScore, string createdAt, string updatedAt, string status, string errorMessage, string lastSuccessfulUpdateTime, double? reversePearsonCorrelationCoefficient, double? predictivePearsonCorrelationCoefficient, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store AggregatedCorrelation Store AggregatedCorrelation
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be stored</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 AggregatedCorrelationsPost (string accessToken, AggregatedCorrelation body);
        
        /// <summary>
        /// Get AggregatedCorrelation Get AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 AggregatedCorrelationsIdGet (int? id, string accessToken);
        
        /// <summary>
        /// Update AggregatedCorrelation Update AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">AggregatedCorrelation that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 AggregatedCorrelationsIdPut (int? id, string accessToken, AggregatedCorrelation body);
        
        /// <summary>
        /// Delete AggregatedCorrelation Delete AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 AggregatedCorrelationsIdDelete (int? id, string accessToken);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AggregatedCorrelationApi : IAggregatedCorrelationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedCorrelationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AggregatedCorrelationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregatedCorrelationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AggregatedCorrelationApi(String basePath)
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
        /// Get all AggregatedCorrelations Get all AggregatedCorrelations
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="correlation">Pearson correlation coefficient between cause and effect measurements</param> 
        /// <param name="causeId">Variable ID of the predictor variable for which the user desires correlations</param> 
        /// <param name="effectId">Variable ID of the outcome variable for which the user desires correlations</param> 
        /// <param name="onsetDelay">User estimated (or default number of seconds) after cause measurement before a perceivable effect is observed</param> 
        /// <param name="durationOfAction">Number of seconds over which the predictor variable event is expected to produce a perceivable effect following the onset delay</param> 
        /// <param name="numberOfPairs">Number of predictor/outcome data points used in the analysis</param> 
        /// <param name="valuePredictingHighOutcome">Predictor daily aggregated measurement value that predicts an above average effect measurement value (in default unit for predictor variable)</param> 
        /// <param name="valuePredictingLowOutcome">Predictor daily aggregated measurement value that predicts a below average effect measurement value (in default unit for outcome variable)</param> 
        /// <param name="optimalPearsonProduct">Optimal Pearson Product</param> 
        /// <param name="numberOfUsers">Number of users whose data was used in this aggregation</param> 
        /// <param name="numberOfCorrelations">Number of correlational analyses used in this aggregation</param> 
        /// <param name="statisticalSignificance">A function of the effect size and sample size</param> 
        /// <param name="causeUnit">Abbreviated unit name for the predictor variable</param> 
        /// <param name="causeUnitId">Unit ID for the predictor variable</param> 
        /// <param name="causeChanges">Number of times that the predictor time series changes</param> 
        /// <param name="effectChanges">Number of times that the predictor time series changes</param> 
        /// <param name="aggregateQmScore">Aggregated QM Score which is directly proportional with the relevance of each predictor or outcome</param> 
        /// <param name="createdAt">Date at which the analysis was first performed</param> 
        /// <param name="updatedAt">Date at which the analysis was last updated</param> 
        /// <param name="status">Indicates whether an analysis is up to date (UPDATED), needs to be updated (WAITING), or had an error (ERROR)</param> 
        /// <param name="errorMessage">Message describing any problems encountered during the analysis</param> 
        /// <param name="lastSuccessfulUpdateTime">Last Successful update time</param> 
        /// <param name="reversePearsonCorrelationCoefficient">Correlation when cause and effect are reversed. For any causal relationship, the forward correlation should exceed the reverse correlation</param> 
        /// <param name="predictivePearsonCorrelationCoefficient">Predictive Pearson Correlation Coefficient</param> 
        /// <param name="limit">Limit the number of results returned</param> 
        /// <param name="offset">Records from give Offset</param> 
        /// <param name="sort">Sort records by given field</param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 AggregatedCorrelationsGet (string accessToken, double? correlation, int? causeId, int? effectId, int? onsetDelay, int? durationOfAction, int? numberOfPairs, double? valuePredictingHighOutcome, double? valuePredictingLowOutcome, double? optimalPearsonProduct, int? numberOfUsers, int? numberOfCorrelations, double? statisticalSignificance, string causeUnit, int? causeUnitId, int? causeChanges, int? effectChanges, double? aggregateQmScore, string createdAt, string updatedAt, string status, string errorMessage, string lastSuccessfulUpdateTime, double? reversePearsonCorrelationCoefficient, double? predictivePearsonCorrelationCoefficient, int? limit, int? offset, string sort)
        {
            
    
            var path = "/aggregatedCorrelations";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
             if (correlation != null) queryParams.Add("correlation", ApiClient.ParameterToString(correlation)); // query parameter
             if (causeId != null) queryParams.Add("cause_id", ApiClient.ParameterToString(causeId)); // query parameter
             if (effectId != null) queryParams.Add("effect_id", ApiClient.ParameterToString(effectId)); // query parameter
             if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
             if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
             if (numberOfPairs != null) queryParams.Add("number_of_pairs", ApiClient.ParameterToString(numberOfPairs)); // query parameter
             if (valuePredictingHighOutcome != null) queryParams.Add("value_predicting_high_outcome", ApiClient.ParameterToString(valuePredictingHighOutcome)); // query parameter
             if (valuePredictingLowOutcome != null) queryParams.Add("value_predicting_low_outcome", ApiClient.ParameterToString(valuePredictingLowOutcome)); // query parameter
             if (optimalPearsonProduct != null) queryParams.Add("optimal_pearson_product", ApiClient.ParameterToString(optimalPearsonProduct)); // query parameter
             if (numberOfUsers != null) queryParams.Add("number_of_users", ApiClient.ParameterToString(numberOfUsers)); // query parameter
             if (numberOfCorrelations != null) queryParams.Add("number_of_correlations", ApiClient.ParameterToString(numberOfCorrelations)); // query parameter
             if (statisticalSignificance != null) queryParams.Add("statistical_significance", ApiClient.ParameterToString(statisticalSignificance)); // query parameter
             if (causeUnit != null) queryParams.Add("cause_unit", ApiClient.ParameterToString(causeUnit)); // query parameter
             if (causeUnitId != null) queryParams.Add("cause_unit_id", ApiClient.ParameterToString(causeUnitId)); // query parameter
             if (causeChanges != null) queryParams.Add("cause_changes", ApiClient.ParameterToString(causeChanges)); // query parameter
             if (effectChanges != null) queryParams.Add("effect_changes", ApiClient.ParameterToString(effectChanges)); // query parameter
             if (aggregateQmScore != null) queryParams.Add("aggregate_qm_score", ApiClient.ParameterToString(aggregateQmScore)); // query parameter
             if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
             if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
             if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
             if (errorMessage != null) queryParams.Add("error_message", ApiClient.ParameterToString(errorMessage)); // query parameter
             if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        
        /// <summary>
        /// Store AggregatedCorrelation Store AggregatedCorrelation
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">AggregatedCorrelation that should be stored</param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 AggregatedCorrelationsPost (string accessToken, AggregatedCorrelation body)
        {
            
    
            var path = "/aggregatedCorrelations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        
        /// <summary>
        /// Get AggregatedCorrelation Get AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2001</returns>            
        public InlineResponse2001 AggregatedCorrelationsIdGet (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationsIdGet");
            
    
            var path = "/aggregatedCorrelations/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2001) ApiClient.Deserialize(response.Content, typeof(InlineResponse2001), response.Headers);
        }
    
        
        /// <summary>
        /// Update AggregatedCorrelation Update AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">AggregatedCorrelation that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 AggregatedCorrelationsIdPut (int? id, string accessToken, AggregatedCorrelation body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationsIdPut");
            
    
            var path = "/aggregatedCorrelations/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete AggregatedCorrelation Delete AggregatedCorrelation
        /// </summary>
        /// <param name="id">id of AggregatedCorrelation</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 AggregatedCorrelationsIdDelete (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AggregatedCorrelationsIdDelete");
            
    
            var path = "/aggregatedCorrelations/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AggregatedCorrelationsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
