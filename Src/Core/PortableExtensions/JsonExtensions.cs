﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PortableExtensions.JsonHelpers;

namespace PortableExtensions
{
    /// <summary>
    /// Extension methods for all json related
    /// </summary>
    public static class JsonExtensions
    {
        /// <summary>
        /// Deserialises the json object to the given type
        /// </summary>
        /// <typeparam name="T">The type to deserialise</typeparam>
        /// <param name="jsobObJObject">The json object to deseialise from </param>
        /// <returns>The object of type T from the json object; if there was an exception then a default of T is returned </returns>
        public static T GetFromJson<T>(this JObject jsobObJObject)
        {
            if (jsobObJObject == null || jsobObJObject.ToString().IsNullOrEmpty())
            {
                return default(T);
            }

            var obj = JsonConvert.DeserializeObject<T>(jsobObJObject.ToString());
            return obj;
        }

        /// <summary>
        /// Deserialises the json object to the given type
        /// </summary>
        /// <typeparam name="T">The type to deserialise</typeparam>
        /// <param name="jsobObJObjects">The json objects to deseialise from </param>
        /// <returns>The object of type T from the json object; if there was an exception then a default of T is returned </returns>
        public static IEnumerable<T> GetFromJson<T>(this IEnumerable<JToken> jsobObJObjects)
        {
            var obJObjects = jsobObJObjects as JToken[] ?? jsobObJObjects.ToArray();
            if (obJObjects.IsNullOrEmpty())
            {
                return new List<T>();
            }

            var objs = obJObjects.Select(jsobObJObject => JsonConvert.DeserializeObject<T>(jsobObJObject.ToString())).ToList();
            return objs;
        }

        /// <summary>
        /// Deserialises the json object to the given type
        /// </summary>
        /// <typeparam name="T">The type to deserialise</typeparam>
        /// <param name="jsobObJObjects">The json objects to deseialise from </param>
        /// <param name="jsonMapper">The mapper to use to map from the json response to the desired poco T</param>
        /// <returns>The object of type T from the json object; if there was an exception then a default of T is returned </returns>
        public static IEnumerable<T> GetFromJson<T>(this IEnumerable<JToken> jsobObJObjects, Dictionary<string, string> jsonMapper)
        {
            var obJObjects = jsobObJObjects as JToken[] ?? jsobObJObjects.ToArray();
            if (obJObjects.IsNullOrEmpty())
            {
                return new List<T>();
            }

            var objs = obJObjects.Select(jsobObJObject =>
            {
                var settings = new JsonSerializerSettings {ContractResolver = new CustomContractResolver(jsonMapper)};
                return JsonConvert.DeserializeObject<T>(jsobObJObject.ToString(), settings);
            }).ToList();

            return objs;
        }
    }
}
