using System.Collections.Generic;

namespace Library.API.Helpers
{
    public static class ICollectionExtensions
    {
        /// <summary>
        ///     Try to remove an element in source ICollection of T if it exists
        /// </summary>
        /// <typeparam name="T">Type of ICollection</typeparam>
        /// <param name="source">Source ICollection</param>
        /// <param name="element">Element to remove</param>
        /// <returns>True if exist, false if not</returns>
        public static bool TryRemove<T>(this ICollection<T> source, T element)
        {
            if (!source.Contains(element)) return false;
            source.Remove(element);
            return true;
        }
    }
}