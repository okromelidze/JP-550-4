using System;
using System.Collections.Generic;
using System.Text;

namespace C_10
{
    internal class Array : IOutput2, ICalc2
    {
        private int[] data;

        public Array(int[] data)
        {
            this.data = data;
        }


        public int CountDistinct()
        {
            int count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                bool alreadySeen = false;
                for (int j = 0; j < i; j++)
                {
                    if (data[i] == data[j])
                    {
                        alreadySeen = true;
                        break;
                    }
                }
                if (!alreadySeen)
                    count++;
            }
            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (int x in data)
            {
                if (x == valueToCompare)
                    count++;
            }
            return count;
        }


        public void ShowEven()
        {
            foreach (int x in data)
            {
                if (x % 2 == 0)
                    Console.WriteLine(x);
            }
        }

        public void ShowOdd()
        {
            foreach (int x in data)
            {
                if (x % 2 != 0)
                    Console.WriteLine(x);
            }
        }
    }
}
