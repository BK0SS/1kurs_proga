using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_Kosulin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dlina_1 = double.Parse(Console.ReadLine());
            double dlina_2 = double.Parse(Console.ReadLine());    
            double dlina_3 = double.Parse(Console.ReadLine());
            //Это медиана для 3 стороны то есть для dlina_3
            Console.WriteLine(Math.Sqrt(2*Math.Pow(dlina_1,2)+ 2*Math.Pow(dlina_2,2)+Math.Pow(dlina_3,2) /4));
            Console.ReadKey() ;
        }
    }
}
