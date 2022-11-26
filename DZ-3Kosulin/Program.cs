using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3Kosulin
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
          
            float x = float.Parse(Console.ReadLine());
            float y = (float)(1 + (Math.Sqrt(Math.Pow(x, 2) - 1) /Math.Sqrt(Math.Pow(x, 2) + 1)));
            Console.WriteLine("Y = " + y);

            Console.ReadKey();

            
        }
    }
}
