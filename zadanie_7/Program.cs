using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    internal class Program
    {
        static bool proverka(int m, int n) 
        {
            if (m == 0 || n == 0)
            {
                return true;

            }
            else { return false; }
        }
        static void Main(string[] args)
        {
            proverka(0, 10);
            proverka(10, 10);
            Console.ReadKey();
        }
    }
}
