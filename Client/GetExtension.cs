using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using WebApi.Client;

namespace WebApi
{
    public static class GetExtension
    {
        public static ApiResponse<T> GetWithHttpInfo<T> (this IApiAccessor @interface, string path)
        {

            var localVarPath = path;
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(@interface.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = @interface.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = @interface.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) @interface.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (@interface.ExceptionFactory != null)
            {
                Exception exception = @interface.ExceptionFactory(path, localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<T>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (T) @interface.Configuration.ApiClient.Deserialize(localVarResponse, typeof(T)));
        }

        public static async System.Threading.Tasks.Task<ApiResponse<T>> GetWithHttpInfoAsync<T>(this IApiAccessor @interface, string path)
        {
            var localVarPath = path;
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(@interface.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = @interface.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = @interface.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await @interface.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (@interface.ExceptionFactory != null)
            {
                Exception exception = @interface.ExceptionFactory("WeatherForecastGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<T>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (T) @interface.Configuration.ApiClient.Deserialize(localVarResponse, typeof(T)));
        }
    }
}