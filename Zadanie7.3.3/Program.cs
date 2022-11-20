using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7._3._3
{
    internal class Program
    {

        //проверка позиций
        public static void proverka_position(int x, int y)
        {

            if (x > 8 || x < 1)
            {
                Console.WriteLine("Неправильная позиция");

            }
            else if (y > 8 || y < 1)
            {
                Console.WriteLine("Неправильная позиция");

            }
       
        }
        public static void igra()
        {
            int white_x = int.Parse(Console.ReadLine());
            int white_y = int.Parse(Console.ReadLine());
            proverka_position((int)white_x, (int)white_y);
            Console.WriteLine("Теперь позицию черного ферзя");
            int black_x = int.Parse(Console.ReadLine());
            int black_y = int.Parse(Console.ReadLine());
            proverka_position((int)white_x, (int)white_y);
            if (white_x == black_x & white_y == black_y)
            {
                Console.WriteLine("Невозможно");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {

                if (black_x == white_x)
                {
                    Console.WriteLine("Возможен обоюдный сруб");
                }
                else if (black_y == white_y)
                {
                    Console.WriteLine("Возможен обоюдный сруб");
                }
                else if (Math.Abs(black_x - white_x) == Math.Abs(black_y - white_y))
                {
                    if (black_x != white_x & black_y != white_y)
                    {
                        Console.WriteLine("Черный ферзь может срубить белую ладью");
                    }
                }
                else
                {
                    Console.WriteLine("Никакой сруб не возможен");
                }
            }

        }
      
   
        static bool proverka()
        {
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Щахматы\nВведите сначала позицию белой ладьи, а потом черного ферзя");
            
            igra();

            Console.ReadKey();

        }
    }
}
