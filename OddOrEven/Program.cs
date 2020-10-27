using System;
using System.Transactions;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenOdd();
        }
        public static bool EvenOdd()
        {

            Console.WriteLine($"Enter a number to determine if it is Odd or Even");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.Write("It is even!!!");
                return true;


            }
            else
            {
                Console.Write("It is odd!!!");
                return false;

            }

        }

    }

}
