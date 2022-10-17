using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    internal class Program
    {
        static float Untic_x(float x, float a, float b) 
        {
            return x = (float)Math.Pow((float)Math.E, -Math.Sqrt(a + Math.Pow(b, (float)Math.PI)));
        }
        static void Main(string[] args)
        {
            float y = 3;
            Console.WriteLine( Untic_x(y,2,3)+ Untic_x(y,3,5)+ Untic_x(y,5,7));
            Console.ReadKey();
        }
    }
}
