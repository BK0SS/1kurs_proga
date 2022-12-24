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
            int number = int.Parse(Console.ReadLine());
            IsSimple(number);
            for(int i = 2; i < number; i++)
            {
                if (IsSimple(i))
                {
                    for (int j = 2; j < number; j++)
                    {
                        if (IsSimple(j))
                        {
                            if (i + j == number)
                            {
                                Console.WriteLine($"{i} + {j} = {number}");
                                break;
                            }
                        }
                    }
                }
            }
           
            Console.ReadKey();
        }
        static bool IsSimple(int number)
        {
            bool b = false;
            int count = 0;
            for(int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if(count == 2) 
            {
                b = true;
            }
            return b;
        }
    }
}
