namespace C_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;




            int[] transactions = { 120, -50, 300, -100, 80, -200, 500, -30, 150, -400 };


                for (int i = 0; i < transactions.Length; i++)
                {
                    if (transactions[i] < 0)
                    {
                        Console.WriteLine($" გატანა: {-transactions[i]}");
                    }
                    else
                    {
                        Console.WriteLine($" შეტანა: {transactions[i]}");
                    }
                }
                
                int totalDeposits = 0;
                int totalWithdrawals = 0;
                int totalDepositsCount = 0;
                int totalWithdrawalsCount = 0;


            for (int i = 0; i < transactions.Length; i++)
                {
                    if (transactions[i] > 0)
                    {
                        totalDeposits += transactions[i];
                        totalDepositsCount++;   
                    }
                    else
                    {
                        totalWithdrawals += -transactions[i];
                        totalWithdrawalsCount++;
                    }
                }


            Console.WriteLine($"შეტანილი თანხების რიცხვი {totalDepositsCount}");
            Console.WriteLine($"გატანილი თანხების რიცხვი {totalWithdrawalsCount}");
            Console.WriteLine($"შეტანილი თანხა {totalDeposits}");
            Console.WriteLine($"გატანილი თანხა {totalWithdrawals}");
                


                int totalBalance = 0;


                totalBalance = totalDeposits - totalWithdrawals;


            Console.WriteLine($"საბოლოო ბალანსი: {totalBalance}");


            if (totalBalance > 0)
            {
                Console.WriteLine("ანგარიშზე თანხა არის ");
            }
            else if (totalBalance < 0)
            {
                Console.WriteLine("ანგარიშზე თანხა არ არის ");
            }
            else
            {
                Console.WriteLine("ანგარიშის ბალანსი ნულია");
            }







        }
    }
}
