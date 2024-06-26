using System;
using System.Collections.Generic;

namespace Menu_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Dictionary<string, double> menu = new Dictionary<string, double>(){
                {"Baja Taco", 4.00},
                {"Burrito", 7.50},
                {"Nachos", 11.00},
                {"Quesadilla", 8.50},
                {"Super Burrito", 8.50},
                {"Super Quesadilla", 9.50},
                {"Taco", 3.00},
                {"Tortilla Salad", 8.00}
            };

            Console.WriteLine("Item:");
            string order = Console.ReadLine();

            while(order != "end")
            {
                if(menu.ContainsKey(order))
                {
                    total += menu[order];
                    Console.WriteLine($"Total: ${total}\n");
                }
                Console.WriteLine("Item:");
                order = Console.ReadLine();
            }
        }
    }
}
