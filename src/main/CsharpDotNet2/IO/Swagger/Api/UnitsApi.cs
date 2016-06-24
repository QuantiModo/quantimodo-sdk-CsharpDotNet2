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
    public interface IUnitsApi
    {
        /// <summary>
        /// Get unit categories Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
        /// </summary>
        /// <returns>UnitCategory</returns>
        UnitCategory V1UnitCategoriesGet ();
        /// <summary>
        /// Get all available units Get all available units
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="id">Unit id</param>
        /// <param name="unitName">Unit name</param>
        /// <param name="abbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation.</param>
        /// <param name="categoryName">Restrict the results to a specific unit category by providing the unit category name.</param>
        /// <returns>List&lt;Unit&gt;</returns>
        List<Unit> V1UnitsGet (string accessToken, int? id, string unitName, string abbreviatedUnitName, string categoryName);
        /// <summary>
        /// Units for Variable Get a list of all possible units to use for a given variable
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param>
        /// <param name="unitName">Name of Unit you want to retrieve</param>
        /// <param name="abbreviatedUnitName">Abbreviated Unit Name of the unit you want</param>
        /// <param name="categoryName">Name of the category you want units for</param>
        /// <param name="variable">Name of the variable you want units for</param>
        /// <returns>List&lt;Unit&gt;</returns>
        List<Unit> V1UnitsVariableGet (string accessToken, string unitName, string abbreviatedUnitName, string categoryName, string variable);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UnitsApi : IUnitsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UnitsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UnitsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UnitsApi(String basePath)
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
        /// Get unit categories Get a list of the categories of measurement units such as &#39;Distance&#39;, &#39;Duration&#39;, &#39;Energy&#39;, &#39;Frequency&#39;, &#39;Miscellany&#39;, &#39;Pressure&#39;, &#39;Proportion&#39;, &#39;Rating&#39;, &#39;Temperature&#39;, &#39;Volume&#39;, and &#39;Weight&#39;.
        /// </summary>
        /// <returns>UnitCategory</returns>            
        public UnitCategory V1UnitCategoriesGet ()
        {
            
    
            var path = "/v1/unitCategories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling V1UnitCategoriesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UnitCategoriesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UnitCategory) ApiClient.Deserialize(response.Content, typeof(UnitCategory), response.Headers);
        }
    
        /// <summary>
        /// Get all available units Get all available units
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="id">Unit id</param> 
        /// <param name="unitName">Unit name</param> 
        /// <param name="abbreviatedUnitName">Restrict the results to a specific unit by providing the unit abbreviation.</param> 
        /// <param name="categoryName">Restrict the results to a specific unit category by providing the unit category name.</param> 
        /// <returns>List&lt;Unit&gt;</returns>            
        public List<Unit> V1UnitsGet (string accessToken, int? id, string unitName, string abbreviatedUnitName, string categoryName)
        {
            
    
            var path = "/v1/units";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (unitName != null) queryParams.Add("unitName", ApiClient.ParameterToString(unitName)); // query parameter
 if (abbreviatedUnitName != null) queryParams.Add("abbreviatedUnitName", ApiClient.ParameterToString(abbreviatedUnitName)); // query parameter
 if (categoryName != null) queryParams.Add("categoryName", ApiClient.ParameterToString(categoryName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UnitsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UnitsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Unit>) ApiClient.Deserialize(response.Content, typeof(List<Unit>), response.Headers);
        }
    
        /// <summary>
        /// Units for Variable Get a list of all possible units to use for a given variable
        /// </summary>
        /// <param name="accessToken">User&#39;s OAuth2 access token</param> 
        /// <param name="unitName">Name of Unit you want to retrieve</param> 
        /// <param name="abbreviatedUnitName">Abbreviated Unit Name of the unit you want</param> 
        /// <param name="categoryName">Name of the category you want units for</param> 
        /// <param name="variable">Name of the variable you want units for</param> 
        /// <returns>List&lt;Unit&gt;</returns>            
        public List<Unit> V1UnitsVariableGet (string accessToken, string unitName, string abbreviatedUnitName, string categoryName, string variable)
        {
            
    
            var path = "/v1/unitsVariable";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (accessToken != null) queryParams.Add("access_token", ApiClient.ParameterToString(accessToken)); // query parameter
 if (unitName != null) queryParams.Add("unitName", ApiClient.ParameterToString(unitName)); // query parameter
 if (abbreviatedUnitName != null) queryParams.Add("abbreviatedUnitName", ApiClient.ParameterToString(abbreviatedUnitName)); // query parameter
 if (categoryName != null) queryParams.Add("categoryName", ApiClient.ParameterToString(categoryName)); // query parameter
 if (variable != null) queryParams.Add("variable", ApiClient.ParameterToString(variable)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "oauth2" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UnitsVariableGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling V1UnitsVariableGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Unit>) ApiClient.Deserialize(response.Content, typeof(List<Unit>), response.Headers);
        }
    
    }
}
