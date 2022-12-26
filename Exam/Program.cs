using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number_n = int.Parse(Console.ReadLine());
            while (number_n != 1)
            {
                if (number_n % 2 == 0)
                {
                    number_n /= 2;
                }
                else
                {
                    number_n = 3 * number_n + 1;
                }
                Console.Write($"{number_n}; ");
            }
            Console.ReadKey();
        }
    }        
}