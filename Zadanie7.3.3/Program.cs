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

        //проверка коррекстности позиций
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
        //проверка следующего хода ладьи
        static bool proverka_hoda_ladya(int first_pos, int first_posy,int second_pos, int second_posy, int ferz_x, int ferz_y)
        {
            if (first_pos == second_pos||first_posy==second_posy)
            {
                Console.WriteLine("Ход возможен");
                return false;
            }
            else if (second_pos==ferz_x&second_posy==ferz_y)
            {
                Console.WriteLine("на этом месте стоит другая фигура");
                return false;
            }
            else
            {
                Console.WriteLine("Ход невозможен");
                return true;
            }   
        }
        
        //проверка сруба
        public static void next_move_check(int white_x, int white_y,int black_x, int black_y)
        {
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

                    Console.WriteLine("Черный ферзь может срубить белую ладью");
                }
                else
                {
                    Console.WriteLine("Никакой сруб не возможен");
                }
            }
        }

        //перевод символов в числа
        static int perevod(char pos)
        {
            switch (pos)
            {
                case 'A':
                    return 1;
                    break;

                case 'B':
                    return 2;
                    break;

                case 'C':
                    return 3;
                    break;

                case 'D':
                    return 4;
                    break;

                case 'E':
                    return 5;
                    break;

                case 'F':
                    return 6;
                    break;

                case 'G':
                    return 7;
                    break;

                case 'H':
                    return 8;
                    break;
                    default: return 0;  
            }
        }
      
            
        public static void igra()
        {
            int white_x = int.Parse(Console.ReadLine());
            char white_y = char.Parse(Console.ReadLine());
           
            proverka_position((int)white_x, perevod(white_y));

            Console.WriteLine("Теперь позицию черного ферзя");
            int black_x = int.Parse(Console.ReadLine());
            char black_y = char.Parse(Console.ReadLine());

            proverka_position((int)black_x, perevod(black_y));

            Console.WriteLine("Введите следующий ход белой ладьи");

            int next_white_x = int.Parse(Console.ReadLine());
            char next_white_y = char.Parse(Console.ReadLine());

            proverka_hoda_ladya(white_x, perevod(white_y), next_white_x, perevod(next_white_y), black_x, perevod(black_y));
            next_move_check((int)next_white_x,perevod(next_white_y),black_x,perevod(black_y));

        }

    }
}
