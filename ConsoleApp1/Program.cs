using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double function()
        {
            double avg = 1;
            double ans;
            int i = 0;
            do
            {
                ans = double.Parse(Console.ReadLine());
                avg *= ans;
                Console.WriteLine(avg);
            }
            while (ans != 0);
          
            return Math.Pow(avg, 1 / (double)i); ;
        }
        static void Main(string[] args)
        {
          Console.WriteLine(function());
       
            
            Console.ReadKey();  
        }
    }
}
