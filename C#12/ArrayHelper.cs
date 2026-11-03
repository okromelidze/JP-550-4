using System;
using System.Collections.Generic;
using System.Text;

namespace C_12
{
    internal class ArrayHelper
    {
        public void PrintReverse<T>(T[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        
        public T GetFirstElement<T>(T[] array)
        {
            return array[0];
        }

        
        public T GetLastElement<T>(T[] array)
        {
            return array[array.Length - 1];
        }

        
        public bool ContainsElement<T>(T[] array, T value)
        {
            foreach (T item in array)
            {
                if (EqualityComparer<T>.Default.Equals(item, value))
                {
                    return true;
                }
            }
            return false;
        }

        
        public int CountElements<T>(T[] array)
        {
            int count = 0;
            foreach (T item in array)
            {
                count++;
            }
            return count;
        }

        
        public int FindIndex<T>(T[] array, T value)
        {
            int index = 0;
            foreach (T item in array)
            {
                if (EqualityComparer<T>.Default.Equals(item, value))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        
        public void Swap<T>(T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
