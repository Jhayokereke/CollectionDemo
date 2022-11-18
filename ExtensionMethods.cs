using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    public static class ExtensionMethods
    {
        public static IEnumerable<TSource> WhereNotLinq<TSource>(this IEnumerable<TSource> source, Func<TSource,bool> selector)
        {
            IList<TSource> result = new List<TSource>();

            foreach (TSource item in source)
            {
                if (selector(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
