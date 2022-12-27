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
            for (int number = 2; ; number++)
            {
                if (number % 2 != 0 & IsSostavnoe(number))
                {
                    bool b = false; 
                    for (int p = 2; p <= number; p++)
                    {
                        if (IsSimple(p))
                        {

                            for (int x = 1; x <= number; x++)
                            {
                                if (p + 2 * x * x == number)
                                {
                                    b = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (b == false)
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
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
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
                    if (count == 3)
                    {
                        return true;
                        break;
                    }
                }
            }
            return false;
        }
    }
}
