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
            double gipotin = Math.Sqrt(Math.Pow(dlina_1,2) + Math.Pow(dlina_2,2));
            double meiana1, mediana2, mediana3;
            meiana1 = Math.Sqrt(2 * Math.Pow(dlina_1, 2) + 2 * Math.Pow(dlina_2, 2) + Math.Pow(gipotin, 2) / 4);
            mediana2 =  Math.Sqrt(2 * Math.Pow(dlina_2, 2) + 2 * Math.Pow(gipotin, 2) + Math.Pow(dlina_1, 2) / 4);
            mediana3 = Math.Sqrt(2 * Math.Pow(dlina_1, 2) + 2 * Math.Pow(gipotin, 2) + Math.Pow(dlina_2, 2) / 4);
            Console.ReadKey();
            Console.ReadKey() ;
        }
    }
}
