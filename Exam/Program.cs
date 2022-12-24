using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            IsSimple(number);
            int b;
            string multiply = $"Разложение числа {number} =";

            for (b = 2; number > 1; b++)
                if (number % b == 0)
                {
                    int x = 0;
                    while (number % b == 0)
                    {
                        number/= b;
                        x++;
                    }
                    multiply += $" {b} * {x};";
                }

            Console.WriteLine($" = {multiply}");
            Console.ReadKey();
        }
        static int IsSimple(int number)
        {
            int count = 0;
            for(int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if(count == 2) 
            { 
                Console.WriteLine($"{number} простое"); 
            }
            else
            {
                Console.WriteLine($"{number} не простое");
            }
            return 0;
        }
    }
}
