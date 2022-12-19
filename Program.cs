using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prefectnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" b1:b2");
            Console.WriteLine("Enter b1");
            double min=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b2");
            double max = int.Parse(Console.ReadLine());
            Console.WriteLine("the perfect numbers are:");
            for (double i=min; i <= max; i++)
            {
                 double sum = 0;
                for (double j = 1; j < i; j++)
                {
                 
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i && sum!=0)
                    Console.WriteLine("\t" + i);
            }
            Console.ReadKey();

        }
    }
}
