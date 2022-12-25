using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static int nod(int a, int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string output = "";
         
            for (int i = 0; i <= n * m; i++)
            {
               if(nod(i,n) == 1 & nod(i, m) == 1)
                {
                    output += $"{i}; ";
                }
            }
            Console.WriteLine($"Эти числа взаимно простые с {n} И {m}:\n{output}");
            Console.ReadKey();
        }
    }
}


