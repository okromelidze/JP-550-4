using System;
using System.Collections.Generic;
using System.Text;

namespace C_14
{
    internal static class Generic
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();

            foreach (T item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }


        public static T FirstOrDefault<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return default(T);
        }


        public static bool Any<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    return true;
                }
            }

            return false;
        }


        public static bool All<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T item in source)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }

            return true;
        }


        public static int Count<T>(this IEnumerable<T> source)
        {
            int count = 0;

            foreach (T item in source)
            {
                count++;
            }

            return count;
        }


        public static int Count<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            int count = 0;

            foreach (T item in source)
            {
                if (predicate(item))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
