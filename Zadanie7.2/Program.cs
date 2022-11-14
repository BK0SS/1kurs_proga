using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7._2
{
    internal class Program
    {
        static bool risunok1(float x, float y)
        {
            if (x > 2)
            {
                return true;
            }
            else
            {
                if (x < 2 & y > 1.5 || y < 0.5)
                {
                    return false;
                }
                else
                {
                    return true;

                }
            }
        }
        static bool risunok2(float x, float y)
        {
            if (x < -1 || x > 1.5)
            {
                return false;
            }
            else if (y < -0.5 || y > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool risunok3(float x, float y)
        {
            if (x > 1 & y < -1)
            {
                return true;
            }
            else if (x > 2 & y >= 0)
            {
                return true;
            }
            else { return false; }
        }
        static bool risunok4(float x, float y)
        {
            if (x > -2 & y < 1)
            {
                return false;
            }
            else { return true; }
        }
        static bool risunok5(float x, float y)
        {
            if (y < -2 || y > 1.5)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool risunok6(float x, float y)
        {
            if (y > 1 || y < -3)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        static bool risunok7(float x, float y)
        {
            if (y < -2)
            {
                return false;
            }
            else if (x < -1 & x > -3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}

