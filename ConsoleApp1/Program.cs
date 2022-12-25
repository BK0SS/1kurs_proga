using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine($"Ввод числа n");

            int n = DoubleSquereFunction(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Результат функций равен = {n}");
            Console.ReadKey();
        }
        static int DoubleSquereFunction(int n)
        {
            int x = (int)Math.Pow(n, 2);

            for (int i = 1; i <= n; i++)
            {
                x += (n + i) * (n + i);
            }
            
            return x;
        }
    }
}
