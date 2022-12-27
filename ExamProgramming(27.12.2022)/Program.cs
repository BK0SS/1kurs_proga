using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgramming_27._12._2022_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int number = 2; ; number++)
            {
                if (number % 2 != 0 & IsSostavnoe(number))
                {
                    int count = 0;
                    for (int p = 0; p <= number; p++)
                    {
                        if (IsSimple(p))
                        {
                            for (int x = 1; x <= 9; x++)
                            {
                                if (p + 2 * x * x == number)
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine($"{number} это наименьшее число, которое ломает систему");
                        break;
                    }

                }
                else { continue; }
            }
            Console.ReadKey();

        }

        //метод который находит простое число
        static bool IsSimple(int number)
        {
            bool b = false;
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                b = true;
            }
            return b;
        }

        //метод который находит составное число
        static bool IsSostavnoe(int number)
        {
            bool b = false;
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count > 2)
            {
                b = true;
            }

            return b;
        }
    }
}
