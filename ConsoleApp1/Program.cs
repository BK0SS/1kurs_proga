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
        static double Function()
        {
            double avg = 1;
          
            int i = 0;
            while (true)
            {
                double ans = double.Parse(Console.ReadLine());
                if (ans == 0)
                {
                    avg = Math.Pow(avg, 1 / (double)i); 
                    Console.WriteLine($"Конец ввода.\nСреднее геометрическое = {avg}");
                    break;
                }
                else
                {
                    Console.WriteLine("Продолжайте ввод");
                    i++;
                    avg *= ans;
                }
            }

            return avg;
        }
        static void Main(string[] args)
        {
            Function();
            Console.ReadKey();
        }
    }
}
