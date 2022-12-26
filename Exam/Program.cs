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
                Console.WriteLine("Введите n степень");
                int nsquere = int.Parse(Console.ReadLine());

                for (int i = 10; i < 10000000; i++)
                {
                    if (AreDigitsEqualNumber(i, nsquere))
                    {
                        Console.WriteLine($"Число {i} равно сумме квадратов его чисел");
                    }
                }
                Console.ReadKey();
            }

            static bool AreDigitsEqualNumber(int number, int nSquere)
            {
                int originalnumber = number;

                int sum_of_squeres = 0;

                bool chek = false;

                int[] temp = new int[number.ToString().Length];

                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i] = number % 10;
                    number /= 10;
                }
                Array.Reverse(temp);

                foreach (int i in temp)
                {
                    sum_of_squeres += NSquere(i, nSquere);
                }
                if (sum_of_squeres == originalnumber)
                {
                    chek = true;
                }

                return chek;
            }
            static int NSquere(int number, int nSquere)
            {
                int temp = number;
                for (int i = 1; i < nSquere; i++)
                    number *= temp;

                return number;
            }
      }
}
