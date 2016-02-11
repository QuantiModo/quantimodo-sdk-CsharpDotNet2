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
    public interface IVariableApi
    {
        
        /// <summary>
        /// Get all Variables Get all Variables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">id</param>
        /// <param name="clientId">The ID of the client application which last created or updated this common variable</param>
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param>
        /// <param name="name">User-defined variable display name</param>
        /// <param name="variableCategoryId">Variable category ID</param>
        /// <param name="defaultUnitId">ID of the default unit for the variable</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param>
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="_public">Is variable public</param>
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param>
        /// <param name="mostCommonValue">Most common value</param>
        /// <param name="mostCommonUnitId">Most common Unit</param>
        /// <param name="standardDeviation">Standard Deviation</param>
        /// <param name="variance">Average variance for this variable based on all user data</param>
        /// <param name="mean">Mean for this variable based on all user data</param>
        /// <param name="median">Median for this variable based on all user data</param>
        /// <param name="numberOfMeasurements">Number of measurements for this variable based on all user data</param>
        /// <param name="numberOfUniqueValues">Number of unique values for this variable based on all user data</param>
        /// <param name="skewness">Skewness for this variable based on all user data</param>
        /// <param name="kurtosis">Kurtosis for this variable based on all user data</param>
        /// <param name="status">status</param>
        /// <param name="errorMessage">error_message</param>
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="productUrl">Product URL</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="price">Price</param>
        /// <param name="numberOfUserVariables">Number of users who have data for this variable</param>
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</param>
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable based on all user data</param>
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable based on all user data</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort records by a given field name. If the field name is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20034</returns>
        InlineResponse20034 VariablesGet (string accessToken, int? id, string clientId, int? parentId, string name, int? variableCategoryId, int? defaultUnitId, string combinationOperation, double? fillingValue, double? maximumAllowedValue, double? minimumAllowedValue, int? onsetDelay, int? durationOfAction, int? _public, bool? causeOnly, double? mostCommonValue, int? mostCommonUnitId, double? standardDeviation, double? variance, double? mean, double? median, double? numberOfMeasurements, double? numberOfUniqueValues, double? skewness, double? kurtosis, string status, string errorMessage, string lastSuccessfulUpdateTime, string createdAt, string updatedAt, string productUrl, string imageUrl, double? price, int? numberOfUserVariables, bool? outcome, double? minimumRecordedValue, double? maximumRecordedValue, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store Variable Allows the client to create a new variable in the `variables` table.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be stored</param>
        /// <returns>InlineResponse20035</returns>
        InlineResponse20035 VariablesPost (string accessToken, Variable body);
        
        /// <summary>
        /// Get Variable Get Variable
        /// </summary>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20035</returns>
        InlineResponse20035 VariablesIdGet (int? id, string accessToken);
        
        /// <summary>
        /// Update Variable Update Variable
        /// </summary>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">Variable that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariablesIdPut (int? id, string accessToken, Variable body);
        
        /// <summary>
        /// Delete Variable Delete Variable
        /// </summary>
        /// <param name="id">id of Variable</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariablesIdDelete (int? id, string accessToken);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VariableApi : IVariableApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VariableApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VariableApi(String basePath)
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
        /// Get all Variables Get all Variables
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="id">id</param> 
        /// <param name="clientId">The ID of the client application which last created or updated this common variable</param> 
        /// <param name="parentId">ID of the parent variable if this variable has any parent</param> 
        /// <param name="name">User-defined variable display name</param> 
        /// <param name="variableCategoryId">Variable category ID</param> 
        /// <param name="defaultUnitId">ID of the default unit for the variable</param> 
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param> 
        /// <param name="fillingValue">Value for replacing null measurements</param> 
        /// <param name="maximumAllowedValue">Maximum reasonable value for this variable (uses default unit)</param> 
        /// <param name="minimumAllowedValue">Minimum reasonable value for this variable (uses default unit)</param> 
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param> 
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param> 
        /// <param name="_public">Is variable public</param> 
        /// <param name="causeOnly">A value of 1 indicates that this variable is generally a cause in a causal relationship.  An example of a causeOnly variable would be a variable such as Cloud Cover which would generally not be influenced by the behaviour of the user</param> 
        /// <param name="mostCommonValue">Most common value</param> 
        /// <param name="mostCommonUnitId">Most common Unit</param> 
        /// <param name="standardDeviation">Standard Deviation</param> 
        /// <param name="variance">Average variance for this variable based on all user data</param> 
        /// <param name="mean">Mean for this variable based on all user data</param> 
        /// <param name="median">Median for this variable based on all user data</param> 
        /// <param name="numberOfMeasurements">Number of measurements for this variable based on all user data</param> 
        /// <param name="numberOfUniqueValues">Number of unique values for this variable based on all user data</param> 
        /// <param name="skewness">Skewness for this variable based on all user data</param> 
        /// <param name="kurtosis">Kurtosis for this variable based on all user data</param> 
        /// <param name="status">status</param> 
        /// <param name="errorMessage">error_message</param> 
        /// <param name="lastSuccessfulUpdateTime">When this variable or its settings were last updated</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="productUrl">Product URL</param> 
        /// <param name="imageUrl">Image URL</param> 
        /// <param name="price">Price</param> 
        /// <param name="numberOfUserVariables">Number of users who have data for this variable</param> 
        /// <param name="outcome">Outcome variables (those with `outcome` == 1) are variables for which a human would generally want to identify the influencing factors.  These include symptoms of illness, physique, mood, cognitive performance, etc.  Generally correlation calculations are only performed on outcome variables.</param> 
        /// <param name="minimumRecordedValue">Minimum recorded value of this variable based on all user data</param> 
        /// <param name="maximumRecordedValue">Maximum recorded value of this variable based on all user data</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort records by a given field name. If the field name is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20034</returns>            
        public InlineResponse20034 VariablesGet (string accessToken, int? id, string clientId, int? parentId, string name, int? variableCategoryId, int? defaultUnitId, string combinationOperation, double? fillingValue, double? maximumAllowedValue, double? minimumAllowedValue, int? onsetDelay, int? durationOfAction, int? _public, bool? causeOnly, double? mostCommonValue, int? mostCommonUnitId, double? standardDeviation, double? variance, double? mean, double? median, double? numberOfMeasurements, double? numberOfUniqueValues, double? skewness, double? kurtosis, string status, string errorMessage, string lastSuccessfulUpdateTime, string createdAt, string updatedAt, string productUrl, string imageUrl, double? price, int? numberOfUserVariables, bool? outcome, double? minimumRecordedValue, double? maximumRecordedValue, int? limit, int? offset, string sort)
        {
            
    
            var path = "/variables";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
             if (clientId != null) queryParams.Add("client_id", ApiClient.ParameterToString(clientId)); // query parameter
             if (parentId != null) queryParams.Add("parent_id", ApiClient.ParameterToString(parentId)); // query parameter
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
             if (variableCategoryId != null) queryParams.Add("variable_category_id", ApiClient.ParameterToString(variableCategoryId)); // query parameter
             if (defaultUnitId != null) queryParams.Add("default_unit_id", ApiClient.ParameterToString(defaultUnitId)); // query parameter
             if (combinationOperation != null) queryParams.Add("combination_operation", ApiClient.ParameterToString(combinationOperation)); // query parameter
             if (fillingValue != null) queryParams.Add("filling_value", ApiClient.ParameterToString(fillingValue)); // query parameter
             if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
             if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
             if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
             if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
             if (_public != null) queryParams.Add("public", ApiClient.ParameterToString(_public)); // query parameter
             if (causeOnly != null) queryParams.Add("cause_only", ApiClient.ParameterToString(causeOnly)); // query parameter
             if (mostCommonValue != null) queryParams.Add("most_common_value", ApiClient.ParameterToString(mostCommonValue)); // query parameter
             if (mostCommonUnitId != null) queryParams.Add("most_common_unit_id", ApiClient.ParameterToString(mostCommonUnitId)); // query parameter
             if (standardDeviation != null) queryParams.Add("standard_deviation", ApiClient.ParameterToString(standardDeviation)); // query parameter
             if (variance != null) queryParams.Add("variance", ApiClient.ParameterToString(variance)); // query parameter
             if (mean != null) queryParams.Add("mean", ApiClient.ParameterToString(mean)); // query parameter
             if (median != null) queryParams.Add("median", ApiClient.ParameterToString(median)); // query parameter
             if (numberOfMeasurements != null) queryParams.Add("number_of_measurements", ApiClient.ParameterToString(numberOfMeasurements)); // query parameter
             if (numberOfUniqueValues != null) queryParams.Add("number_of_unique_values", ApiClient.ParameterToString(numberOfUniqueValues)); // query parameter
             if (skewness != null) queryParams.Add("skewness", ApiClient.ParameterToString(skewness)); // query parameter
             if (kurtosis != null) queryParams.Add("kurtosis", ApiClient.ParameterToString(kurtosis)); // query parameter
             if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
             if (errorMessage != null) queryParams.Add("error_message", ApiClient.ParameterToString(errorMessage)); // query parameter
             if (lastSuccessfulUpdateTime != null) queryParams.Add("last_successful_update_time", ApiClient.ParameterToString(lastSuccessfulUpdateTime)); // query parameter
             if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
             if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
             if (productUrl != null) queryParams.Add("product_url", ApiClient.ParameterToString(productUrl)); // query parameter
             if (imageUrl != null) queryParams.Add("image_url", ApiClient.ParameterToString(imageUrl)); // query parameter
             if (price != null) queryParams.Add("price", ApiClient.ParameterToString(price)); // query parameter
             if (numberOfUserVariables != null) queryParams.Add("number_of_user_variables", ApiClient.ParameterToString(numberOfUserVariables)); // query parameter
             if (outcome != null) queryParams.Add("outcome", ApiClient.ParameterToString(outcome)); // query parameter
             if (minimumRecordedValue != null) queryParams.Add("minimum_recorded_value", ApiClient.ParameterToString(minimumRecordedValue)); // query parameter
             if (maximumRecordedValue != null) queryParams.Add("maximum_recorded_value", ApiClient.ParameterToString(maximumRecordedValue)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20034) ApiClient.Deserialize(response.Content, typeof(InlineResponse20034), response.Headers);
        }
    
        
        /// <summary>
        /// Store Variable Allows the client to create a new variable in the `variables` table.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Variable that should be stored</param> 
        /// <returns>InlineResponse20035</returns>            
        public InlineResponse20035 VariablesPost (string accessToken, Variable body)
        {
            
    
            var path = "/variables";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20035) ApiClient.Deserialize(response.Content, typeof(InlineResponse20035), response.Headers);
        }
    
        
        /// <summary>
        /// Get Variable Get Variable
        /// </summary>
        /// <param name="id">id of Variable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20035</returns>            
        public InlineResponse20035 VariablesIdGet (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariablesIdGet");
            
    
            var path = "/variables/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20035) ApiClient.Deserialize(response.Content, typeof(InlineResponse20035), response.Headers);
        }
    
        
        /// <summary>
        /// Update Variable Update Variable
        /// </summary>
        /// <param name="id">id of Variable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">Variable that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 VariablesIdPut (int? id, string accessToken, Variable body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariablesIdPut");
            
    
            var path = "/variables/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete Variable Delete Variable
        /// </summary>
        /// <param name="id">id of Variable</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 VariablesIdDelete (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariablesIdDelete");
            
    
            var path = "/variables/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariablesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
