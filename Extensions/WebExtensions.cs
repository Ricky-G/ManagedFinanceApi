using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using Newtonsoft.Json;

namespace Extensions
{
    /// <summary>
    /// Extension methods for all web/http related
    /// </summary>
    public static class WebExtensions
    {
        /// <summary>
        /// Calls the url and returns a given type from the json response
        /// </summary>
        /// <typeparam name="T">The type to deserialise and resturn from the json response</typeparam>
        /// <param name="url">The url to query to get the json response</param>
        /// <returns>The object of type T from the json response; if there was an exception then a default of T is returned </returns>
        public static async Task<T> GetFromJsonResponse<T>(this Uri url)
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
    }
}
