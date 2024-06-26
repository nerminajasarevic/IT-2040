using System;

namespace Fuel_Gauge
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            bool key = false;

            while (key == false)
            {
                Console.WriteLine("Fraction:");
                string fraction = Console.ReadLine();

                string[] collection = fraction.Split('/');

                try
                {
                    x = Int32.Parse(collection[0]);
                    y = Int32.Parse(collection[1]);

                }
                catch
                {
                    Console.WriteLine("Fraction:");
                    fraction = Console.ReadLine();

                    collection = fraction.Split('/');
                    x = Int32.Parse(collection[0]);
                    y = Int32.Parse(collection[1]);
                }

                if(x > y)
                {
                    Console.WriteLine("Fraction:");
                    fraction = Console.ReadLine();

                    collection = fraction.Split('/');
                    x = Int32.Parse(collection[0]);
                    y = Int32.Parse(collection[1]);
                }
                
                int percent = (int)Math.Round((double)(100 * x) / y);

                if(percent >= 99)
                {
                    Console.WriteLine("F");
                }
                else if (percent <= 1)
                {
                    Console.WriteLine("E");
                }
                else
                {
                    Console.WriteLine($"{percent}%");
                }
            }
        }
    }
}
