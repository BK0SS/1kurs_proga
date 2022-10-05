using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш стих");
            Random rnd = new Random();

            string input = Console.ReadLine();
            String[] strings = input.Split(' ', '-', ';', ',');

            foreach (string i in strings)
            {
                int a = rnd.Next(1, 3);
                if (a == 1) { Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(i + ' '); }
                if (a == 2) { Console.ForegroundColor = ConsoleColor.Red; Console.Write(i + ' '); }
                if (a == 3) { Console.ForegroundColor = ConsoleColor.Blue; Console.Write(i + ' '); }

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(input);
            while (true) ;


        }
    }
}
