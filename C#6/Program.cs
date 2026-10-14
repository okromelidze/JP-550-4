namespace C_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            #region დავალება 1

            int[] arr = [20, 15, 30];

            Console.WriteLine(Sum(arr));


            int Sum(int[] x)
            {
                int sum = 0;
                foreach (var item in x)
                {
                    sum += item;
                }


                return sum;
            }



            #endregion
            #region დავალება 2

            void Text(string text1, string text2, string text3)
            {
                Console.WriteLine($"{text1} {text2} {text3}");
            }


            #endregion
            #region დავალება 3


            string[] names = ["John", "James"];


            Console.WriteLine(GetText(names));



            #endregion


        }
        public static string GetText(string[] texts)
        {

            string fullText = "";

            foreach (var item in texts)
            {
                fullText += item;
                fullText += " ";
            }


            return fullText;
        }
    }
}
