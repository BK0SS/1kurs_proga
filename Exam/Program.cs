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
                
                if (number%2 != 0 & IsSostavnoe(number))
                {
                    int count = 0;
                    for (int i = 0; i < number; i++)
                    {
                        if (IsSimple(i))
                        {
                            for(int x = 1;x <= 9; x++)
                            {
                                if(i + 2*(x*x) == number)
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
