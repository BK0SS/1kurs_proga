using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padanie8
{
    internal class Program
    {
        static double Xfunc(double x)
        {
            if (x < -1)
            {
                x = 1;
            }
            else if (x > 1)
            {
                x = -1;
            }
            else
            {
                x = -x;
            }
            return x;
        }
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            x = Xfunc(x);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
