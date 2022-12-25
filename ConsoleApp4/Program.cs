using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static int Dumbell(int kg)
        {
            string answer = "";
            for(int i = 1; i < kg; i++)
            {  
                    if (kg % i == 0) 
                    {
                        if (i == 1 | i == 2 | i == 5)
                        {
                            answer += $"{kg} = {kg / i} гирь по {i} кг\n";
                        }
                    }         
            }
            Console.WriteLine(answer);
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес гири");
            
            int number = Dumbell(int.Parse(Console.ReadLine()));
     
            Console.ReadKey();
        }
    }
}
