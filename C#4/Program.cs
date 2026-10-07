namespace C_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;


            #region დავალება 1

            //int[] numbers = [4, 66, 3, 44, 5, 6, 67, 8, 100, 39];

            //int sum = 0;
            //foreach (int n in numbers)
            //{
            //    sum += n;
            //}
            //Console.WriteLine("ჯამი: " + sum);



            #endregion

            #region დავალება 2 

            Random rnd = new Random();
            int[] randomNumbers = new int[5];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(1, 21);
            }

            Console.WriteLine("მასივი: " + string.Join(", ", randomNumbers));

            bool allGreater = true;
            foreach (int n in randomNumbers)
            {
                if (n <= 10)
                {
                    allGreater = false;
                    break;
                }
            }

            if (allGreater)
                Console.WriteLine("ყველა ელემენტი 10-ზე მეტია.");
            else
                Console.WriteLine("ყველა ელემენტი 10-ზე მეტი არ არის.");




            #endregion

            #region დავალება 3

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            int evenCount = 0;
            int oddCount = 0;

            foreach (int n in arr)
            {
                if (n % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine("ლუწი რიცხვები: " + evenCount);
            Console.WriteLine("კენტი რიცხვები: " + oddCount);



            #endregion
        }
    }
}
