namespace C_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array arr = new Array(numbers);

            Console.WriteLine("ლუწი რიცხვები:");
            arr.ShowEven();

            Console.WriteLine("კენტი რიცხვები:");
            arr.ShowOdd();



            int[] test = { 1, 2, 2, 3, 3, 3, 4 };
            Array arr2 = new Array(test);

            Console.WriteLine("უნიკალური რიცხვები: " + arr2.CountDistinct());
            Console.WriteLine("რამდენჯერ არის 3: " + arr2.EqualToValue(3));
        }
    }
}
