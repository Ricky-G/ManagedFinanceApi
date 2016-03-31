using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Windows.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UniversalWindows.Extensions.JsonHelpers;

namespace UniversalWindows.Extensions
{
    /// <summary>
    /// Extension methods for all web/http related
    /// </summary>
    public static class WebExtensions
    {
        /// <summary>
        /// Calls the url and returns a string response
        /// </summary>
        /// <param name="url">The url to query </param>
        /// <returns>The response</returns>
        public static async Task<string> GetResponseAsync(this Uri url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                return response;
            }
        }

        /// <summary>
        /// Calls the url and returns a given type from the json response
        /// </summary>
        /// <typeparam name="T">The type to deserialise and resturn from the json response</typeparam>
        /// <param name="url">The url to query to get the json response</param>
        /// <returns>The object of type T from the json response; if there was an exception then a default of T is returned </returns>
        public static async Task<T> GetFromJsonResponseAsync<T>(this Uri url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(url);
                if (response.IsNullOrEmpty())
                {
                    return default(T);
                }

                var obj = JsonConvert.DeserializeObject<T>(response);
                return obj;
            }
        }

        /// <summary>
        /// Calls the url and returns a given type from the json response
        /// </summary>
        /// <typeparam name="T">The type to deserialise and resturn from the json response</typeparam>
        /// <param name="url">The url to query to get the json response</param>
        /// <param name="jsonMapper">The mapper to use to map from the json response to the desired poco T</param>
        /// <returns>The object of type T from the json response; if there was an exception then a default of T is returned </returns>
        public static async Task<T> GetFromJsonResponseAsync<T>(this Uri url, Dictionary<string, string> jsonMapper)
        {
            var response = await GetResponseAsync(url);
            if (response.IsNullOrEmpty())
            {
                return default(T);
            }

            var reader = new CustomJsonReader(new StringReader(response), jsonMapper);
            var obj = JsonSerializer.Create().Deserialize<T>(reader);

            return obj;
        }

        /// <summary>
        /// Calls the url and returns a json object
        /// </summary>
        /// <param name="url">The url to query to get the json response</param>
        public static async Task<JObject> GetAnnonymousTypeFromJsonResponseAsync(this Uri url)
        {
            var response = await GetResponseAsync(url);
            var jsonObject = JObject.Parse(response);

            return jsonObject;
        }
    }
}
