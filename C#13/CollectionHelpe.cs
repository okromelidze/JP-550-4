using System;
using System.Collections.Generic;
using System.Text;

namespace C_13
{
    internal class CollectionHelpe
    {
        public static void PrintReverse<T>(List<T> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }

        
        public static T GetFirstElement<T>(List<T> list)
        {
            return list[0];
        }

        
        public static T GetLastElement<T>(List<T> list)
        {
            return list[list.Count - 1];
        }

        
        public static bool ContainsElement<T>(List<T> list, T value)
        {
            foreach (T item in list)
            {
                if (item.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        
        public static int CountElements<T>(List<T> list)
        {
            int count = 0;
            foreach (T item in list)
            {
                count++;
            }
            return count;
        }

        
        public static int FindIndex<T>(List<T> list, T value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
