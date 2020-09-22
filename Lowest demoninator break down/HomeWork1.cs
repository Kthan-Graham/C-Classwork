using System;
using System.Threading;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int TempAmount = 0;
            
            Console.Write("Please enter Dollar Amount:");
            int Amount = int.Parse(Console.ReadLine());


            int Count20 = 0;
            while (TempAmount <= Amount)
            {
                TempAmount = (TempAmount) + 20;
                Count20++;
            }
            TempAmount = TempAmount - 20;

            int Count10 = 0;
            while (TempAmount <= Amount)
            {
                TempAmount = TempAmount + 10;
                Count10++;
            }
            TempAmount = TempAmount - 10;

            int Count5 = 0;
            while (TempAmount <= Amount)
            {
                TempAmount = TempAmount + 5;
                Count5++;
            }
            TempAmount = TempAmount - 5;

            int Count1 = 0;
            while (TempAmount <= Amount)
            {
                TempAmount = TempAmount + 1;
                Count1++;
            }
            TempAmount = TempAmount - 1;


            {
                Console.WriteLine("For your amount: " + Amount + " you will have;");
                Console.WriteLine(Count20-1 + " 20 Dollar bills");
                Console.WriteLine(Count10-1 + " 10 Dollar bills");
                Console.WriteLine(Count5-1 + " 5 Dollar bills");
                Console.WriteLine(Count1-1 + " 1 Dollar bills");
                Console.ReadLine();
            }
        }
    }
}