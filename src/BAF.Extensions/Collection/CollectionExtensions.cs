using System.Collections.Generic;

namespace BAF.Extensions.Collection
{
    public static class CollectionExtensions
    {
        ///<summary>
        ///	Check if the array is null or empty
        ///</summary>
        ///<param name = "source"></param>
        ///<returns></returns>
        public static bool IsNullOrEmpty<T>(this ICollection<T> source)
        {
            return source == null || source.Count <= 0;
        }
    }
}