using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Кот укрылся хвостом, обещая: грядут холода.");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Сыплют груши дождем и редеет листва понемногу.И беда не беда. ");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("И луна над прудом молода…"); 
            Console.ResetColor();
            Console.WriteLine("Кот укрылся хвостом, обещая: грядут холода.");
            Console.WriteLine("Сыплют груши дождем и редеет листва понемногу.И беда не беда. ");
            Console.WriteLine("И луна над прудом молода…");
            while (true) ;

        }
    }
}
