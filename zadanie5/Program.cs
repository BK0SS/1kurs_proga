using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    internal class Program
    {
         static float Untic_x(float a, float b)
        {
            return (float)Math.Pow((float)Math.E, -1*Math.Sqrt(a + Math.Pow(b, 2)));
        }
        static void Main(string[] args)
        {
            float y  = Untic_x(2, 3)+Untic_x(3,5)*Untic_x(2,7);
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}
