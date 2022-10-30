using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "клавиатура";
            string viara = a[3].ToString() + a[4].ToString() + a[2].ToString() + a[8].ToString() + a[2].ToString();
            string ruka = a[8].ToString() + a[7].ToString() + a[0].ToString() + a[2].ToString();
            Console.WriteLine(viara + " " + ruka);
            Console.ReadKey();
        }
    }
}
