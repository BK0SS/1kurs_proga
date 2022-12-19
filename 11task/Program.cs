using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11task
{
    internal class Program
    {
        static int[,] Func(int[,] arr)
        {
            for(int i = 0; i<arr.GetLength(0); i++)
            {
              for(int j = 1; j < arr.GetLength(1); j++)
                {
                    if (arr[i,i] > arr[j,j])
                    {
                        Console.WriteLine(
                            $"Эдемент массива с эти индексом {arr[i,i]} " +
                            $"Оказался больльше этого  {arr[j,j]}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Все ОК");
                    }
                }
            }
            return arr; 
        }
        static void Main(string[] args)
        {
            int[,] arr = new int[2,2];
            for(int i = 0; i < arr.GetLength(0); i++)
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
