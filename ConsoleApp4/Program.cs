using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static string Girya(int m)
        {
            int g1 = 1;
            int g2 = 2;
            int g3 = 5;
            int rznt = 0;
           
                if(g1 + g2 == m)
                {
                    Console.WriteLine($"этот способ {g1} + {g2} подошел");
                    rznt++;
                }
                if(g3-g2 == m)
                {
                Console.WriteLine($"этот способ {g3} - {g2} подошел");
                rznt++;
                }
                if (g3 + g1 == m)
                {
                    Console.WriteLine($"этот способ {g3} + {g1} подошел");
                    rznt++;

                }
                if (g2 + g3 == m)
                {
                    Console.WriteLine($"этот способ {g2} + {g3} подошел");
                    rznt++;

                }
                if (g1==m||g2 == m || g3 == m)
                {
                    Console.WriteLine("вес равен одной из гирь");
                    rznt++;

                }
                if (g1 + g2 + g3==m)
                {
                    Console.WriteLine($"этот способ {g1} + {g2} + {g3} подошел");
                    rznt++;

                }
                if (g3 - g1 + g2 == m)
                {
                    Console.WriteLine($"этот способ {g3} - {g1} + {g2} подошел");
                    rznt++;

                }
                if (g3 - g1 == m)
                {
                    Console.WriteLine($"этот способ {g3} - {g1}  подошел");
                    rznt++;

                }
                if (g3 - g2 + g1 == m)
                {
                    Console.WriteLine($"этот способ {g3} - {g1}+ {g1}  подошел");
                    rznt++;

                }

            
            return $"всего {rznt} способов";

        }
        
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(Girya(m));
            Console.ReadKey();
        }
    }
}
