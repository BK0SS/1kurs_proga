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
            for (int i = 0; i < 10; i++)
            {
 
              if (i < n*m)
              {
                Console.WriteLine($"Число {i} не привосходит число {n*m}");
              }
            
            }
            for (int i = 0; i < 10; i++)
            {
                if (nod(i,n)==1)
                {
                    Console.WriteLine($"Число {i} взаимно простое с числом {n}");
                }
                if (nod(i, m) == 1)
                {
                    Console.WriteLine($"Число {i} взаимно простое с числом {m}");
                }

            }
            Console.ReadLine();
        }
    }
}


