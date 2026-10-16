namespace C_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;




            filmebi movie1 = new filmebi();

            movie1.Name = "Inception";
            movie1.Director = "Christopher Nolan";
            movie1.Year = 2010;
            movie1.Genre = "Science Fiction";
            movie1.Rating = 8.8;


            filmebi movie2 = new filmebi();

            movie2.Name = "The Godfather";
            movie2.Director = "Francis Ford Coppola";
            movie2.Year = 1972;
            movie2.Genre = "Crime";
            movie2.Rating = 9.2;



            movie1.PrintInfo();
            Console.WriteLine($"ასაკი: {movie1.GetAge()}");
            Console.WriteLine($"კლასიკურია: {movie1.IsClassic()}");
            Console.WriteLine("-----------------------------");

            movie2.PrintInfo();
            Console.WriteLine($"ასაკი: {movie2.GetAge()}");
            Console.WriteLine($"კლასიკურია: {movie2.IsClassic()}");
            Console.WriteLine("-----------------------------");







        }
    }
}
