using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int cost = 50;

            while (cost > 0)
            {
                Console.WriteLine($"Amount Due: {cost}");
                Console.WriteLine("Insert Coin:");
                int coin = Convert.ToInt32(Console.ReadLine());

                if (coin == 1 || coin == 5 || coin == 10 || coin == 25)
                {
                    cost = cost - coin;
                }
                else
                {
                    Console.WriteLine("Invalid Value, Please try again");
                    coin = Convert.ToInt32(Console.ReadLine());
                }
            }
            cost = cost * -1;
            Console.WriteLine($"Change Owed: {cost}");
        }
    }
}
