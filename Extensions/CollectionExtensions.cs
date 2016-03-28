using System.Collections.Generic;
using System.Linq;

namespace UniversalWindows.Extensions
{
    /// <summary>
    /// Extension methods related to collections
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>
        ///  checks if a null or is empty.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="src">The collection to act on.</param>
        /// <returns>true if a null or is t>, false if not.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> src)
        {
            return src == null || !src.Any();
        }

        /// <summary>
        /// checks if a not null or is empty.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="src">The collection to act on.</param>
        /// <returns>true if a not null or is t>, false if not.</returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> src)
        {
            return src != null && src.Any();
        }

        /// <summary>
        /// returns a black list if the list is null else the passed in list
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="src">The collection to act on.</param>
        /// <returns>blank list if null or empty else the passed in list</returns>
        public static IEnumerable<T> AlwaysList<T>(this IEnumerable<T> src)
        {
            return src ?? new List<T>();
        }
    }
}
