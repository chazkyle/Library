using System.Collections.Generic;

namespace chaz.Extensions
{
    public static class ListExtension
    {
        public static bool IsEmpty<T>(this IList<T> list)
        {
            return list == null || list.Count == 0;
        }
    }
}
