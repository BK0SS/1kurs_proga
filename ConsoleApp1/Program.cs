using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace zadanie10
{
    internal class Program
    {
        static string Print(int[] n)
        {
            string str = "";
            for (int i = 0; i < n.Length; i++)
            {
                str += $"{n[i]} ";
            }
            return Regex.Replace(str, ".{" + 20 + "}(?!$)", "$0\n");
        }

        static int[] EachFourth(int[] n)
        {
            int count = 4;
            for (int i = 0; i < n.Length; i++)
            {
                if (i == count)
                {
                    n[i] = 9 - i;
                    count += 4;
                }
            }
            return n;
        }
        static int CountM(int[] n, int m)
        {
            int count = 0;
            foreach (int i in n)
            {
                if (i >= 0 && i <= 9)
                {
                    if (i == m)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static string CountODD(int[] n)
        {
            foreach (int i in n)
            {
                if (i % 2 == 0)
                {
                    n[i] = 0;
                }
                else
                {
                    n[i] = 1;
                }
            }
            return Print(n);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = 1;
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int)Math.Abs(((Math.PI) * (c)) % 10);
                c *= 10;
            }
            Console.WriteLine(Print(arr));

            arr = EachFourth(arr);

            Console.WriteLine(Print(arr));

            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(CountM(arr, m) + " Столько раз ");
            Console.WriteLine(CountODD(arr));

            Console.ReadKey();
        }
    }
}
