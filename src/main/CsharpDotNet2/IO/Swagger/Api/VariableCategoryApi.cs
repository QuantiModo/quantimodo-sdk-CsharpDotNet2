using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    public interface IVariableCategoryApi
    {
        
        /// <summary>
        /// Get all VariableCategories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="name">Name of the category</param>
        /// <param name="fillingValue">Value for replacing null measurements</param>
        /// <param name="maximumAllowedValue">Maximum recorded value of this category</param>
        /// <param name="minimumAllowedValue">Minimum recorded value of this category</param>
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param>
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param>
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param>
        /// <param name="updated">updated</param>
        /// <param name="causeOnly">A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user</param>
        /// <param name="_public">Is category public</param>
        /// <param name="outcome">outcome</param>
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param>
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param>
        /// <param name="imageUrl">Image URL</param>
        /// <param name="defaultUnitId">ID of the default unit for the category</param>
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param>
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param>
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param>
        /// <returns>InlineResponse20031</returns>
        InlineResponse20031 VariableCategoriesGet (string accessToken, string name, double? fillingValue, double? maximumAllowedValue, double? minimumAllowedValue, int? durationOfAction, int? onsetDelay, string combinationOperation, int? updated, bool? causeOnly, int? _public, bool? outcome, string createdAt, string updatedAt, string imageUrl, int? defaultUnitId, int? limit, int? offset, string sort);
        
        /// <summary>
        /// Store VariableCategory Store VariableCategory
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be stored</param>
        /// <returns>InlineResponse20032</returns>
        InlineResponse20032 VariableCategoriesPost (string accessToken, VariableCategory body);
        
        /// <summary>
        /// Get VariableCategory Get VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse20032</returns>
        InlineResponse20032 VariableCategoriesIdGet (int? id, string accessToken);
        
        /// <summary>
        /// Update VariableCategory Update VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="body">VariableCategory that should be updated</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariableCategoriesIdPut (int? id, string accessToken, VariableCategory body);
        
        /// <summary>
        /// Delete VariableCategory Delete VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 VariableCategoriesIdDelete (int? id, string accessToken);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VariableCategoryApi : IVariableCategoryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableCategoryApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VariableCategoryApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableCategoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VariableCategoryApi(String basePath)
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
        /// Get all VariableCategories The variable categories include Activity, Causes of Illness, Cognitive Performance, Conditions, Environment, Foods, Location, Miscellaneous, Mood, Nutrition, Physical Activity, Physique, Sleep, Social Interactions, Symptoms, Treatments, Vital Signs, and Work.
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="name">Name of the category</param> 
        /// <param name="fillingValue">Value for replacing null measurements</param> 
        /// <param name="maximumAllowedValue">Maximum recorded value of this category</param> 
        /// <param name="minimumAllowedValue">Minimum recorded value of this category</param> 
        /// <param name="durationOfAction">Estimated number of seconds following the onset delay in which a stimulus produces a perceivable effect</param> 
        /// <param name="onsetDelay">Estimated number of seconds that pass before a stimulus produces a perceivable effect</param> 
        /// <param name="combinationOperation">How to combine values of this variable (for instance, to see a summary of the values over a month) SUM or MEAN</param> 
        /// <param name="updated">updated</param> 
        /// <param name="causeOnly">A value of 1 indicates that this category is generally a cause in a causal relationship.  An example of a causeOnly category would be a category such as Work which would generally not be influenced by the behaviour of the user</param> 
        /// <param name="_public">Is category public</param> 
        /// <param name="outcome">outcome</param> 
        /// <param name="createdAt">When the record was first created. Use ISO 8601 datetime format</param> 
        /// <param name="updatedAt">When the record was last updated. Use ISO 8601 datetime format</param> 
        /// <param name="imageUrl">Image URL</param> 
        /// <param name="defaultUnitId">ID of the default unit for the category</param> 
        /// <param name="limit">The LIMIT is used to limit the number of results returned. So if you have 1000 results, but only want to the first 10, you would set this to 10 and offset to 0. The maximum limit is 200 records.</param> 
        /// <param name="offset">OFFSET says to skip that many rows before beginning to return rows to the client. OFFSET 0 is the same as omitting the OFFSET clause. If both OFFSET and LIMIT appear, then OFFSET rows are skipped before starting to count the LIMIT rows that are returned.</param> 
        /// <param name="sort">Sort by given field. If the field is prefixed with &#39;-&#39;, it will sort in descending order.</param> 
        /// <returns>InlineResponse20031</returns>            
        public InlineResponse20031 VariableCategoriesGet (string accessToken, string name, double? fillingValue, double? maximumAllowedValue, double? minimumAllowedValue, int? durationOfAction, int? onsetDelay, string combinationOperation, int? updated, bool? causeOnly, int? _public, bool? outcome, string createdAt, string updatedAt, string imageUrl, int? defaultUnitId, int? limit, int? offset, string sort)
        {
            
    
            var path = "/variableCategories";
            path = path.Replace("{format}", "json");
            
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
             if (fillingValue != null) queryParams.Add("filling_value", ApiClient.ParameterToString(fillingValue)); // query parameter
             if (maximumAllowedValue != null) queryParams.Add("maximum_allowed_value", ApiClient.ParameterToString(maximumAllowedValue)); // query parameter
             if (minimumAllowedValue != null) queryParams.Add("minimum_allowed_value", ApiClient.ParameterToString(minimumAllowedValue)); // query parameter
             if (durationOfAction != null) queryParams.Add("duration_of_action", ApiClient.ParameterToString(durationOfAction)); // query parameter
             if (onsetDelay != null) queryParams.Add("onset_delay", ApiClient.ParameterToString(onsetDelay)); // query parameter
             if (combinationOperation != null) queryParams.Add("combination_operation", ApiClient.ParameterToString(combinationOperation)); // query parameter
             if (updated != null) queryParams.Add("updated", ApiClient.ParameterToString(updated)); // query parameter
             if (causeOnly != null) queryParams.Add("cause_only", ApiClient.ParameterToString(causeOnly)); // query parameter
             if (_public != null) queryParams.Add("public", ApiClient.ParameterToString(_public)); // query parameter
             if (outcome != null) queryParams.Add("outcome", ApiClient.ParameterToString(outcome)); // query parameter
             if (createdAt != null) queryParams.Add("created_at", ApiClient.ParameterToString(createdAt)); // query parameter
             if (updatedAt != null) queryParams.Add("updated_at", ApiClient.ParameterToString(updatedAt)); // query parameter
             if (imageUrl != null) queryParams.Add("image_url", ApiClient.ParameterToString(imageUrl)); // query parameter
             if (defaultUnitId != null) queryParams.Add("default_unit_id", ApiClient.ParameterToString(defaultUnitId)); // query parameter
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
             if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
             if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "quantimodo_oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20031) ApiClient.Deserialize(response.Content, typeof(InlineResponse20031), response.Headers);
        }
    
        
        /// <summary>
        /// Store VariableCategory Store VariableCategory
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">VariableCategory that should be stored</param> 
        /// <returns>InlineResponse20032</returns>            
        public InlineResponse20032 VariableCategoriesPost (string accessToken, VariableCategory body)
        {
            
    
            var path = "/variableCategories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20032) ApiClient.Deserialize(response.Content, typeof(InlineResponse20032), response.Headers);
        }
    
        
        /// <summary>
        /// Get VariableCategory Get VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse20032</returns>            
        public InlineResponse20032 VariableCategoriesIdGet (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableCategoriesIdGet");
            
    
            var path = "/variableCategories/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20032) ApiClient.Deserialize(response.Content, typeof(InlineResponse20032), response.Headers);
        }
    
        
        /// <summary>
        /// Update VariableCategory Update VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="body">VariableCategory that should be updated</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 VariableCategoriesIdPut (int? id, string accessToken, VariableCategory body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableCategoriesIdPut");
            
    
            var path = "/variableCategories/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
        /// <summary>
        /// Delete VariableCategory Delete VariableCategory
        /// </summary>
        /// <param name="id">id of VariableCategory</param> 
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 VariableCategoriesIdDelete (int? id, string accessToken)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling VariableCategoriesIdDelete");
            
    
            var path = "/variableCategories/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VariableCategoriesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        
    }
    
}
