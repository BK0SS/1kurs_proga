using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padanie8
{
    internal class Program
    {
        public static void xfunc(double x)
        {
            if (x < -1)
            {
                Console.WriteLine(1);
            }
            else if (x > 1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(-x);
            }
        }
        static void Main(string[] args)
        {
            xfunc(1.2);
            xfunc(-2);
            xfunc(0.5);
            Console.ReadKey();
        }
    }
}
