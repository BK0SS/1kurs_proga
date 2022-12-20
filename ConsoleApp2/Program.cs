using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static int[,] Func(int[,] arr)
        {
            int sred = 0;
            double avg;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sred += arr[i, j];
                }
                avg = sred / arr.GetLength(0);
                Console.WriteLine($"Среднее арифмитическое строки {i}=={avg:f1}");
                sred = 0;
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Func(arr);
            Console.ReadKey();
        }
    }
}
