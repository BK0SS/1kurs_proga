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
            int a = int.Parse(Console.ReadLine());
            Console.Write(a / 100 +""+ a % 10 + ""+ a / 10 % 10);
            Console.ReadKey();
        }
    }
}
