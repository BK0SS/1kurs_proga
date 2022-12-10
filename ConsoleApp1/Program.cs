using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int function(int n)
        {
            int x= (int) Math.Pow(n,2);

            for (int i = 1; i <= n; i++)
            {
                x += (int)Math.Pow(n + i, 2);
            }
            x += (int)Math.Pow(2 * n, 2);
            return x;
        }
        static void Main(string[] args)
        {
            int y = function(int.Parse(Console.ReadLine()));
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
