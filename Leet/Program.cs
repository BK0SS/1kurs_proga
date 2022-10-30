using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leet
{
    internal class Program
    {
       public static string perevod_v_leet(string stroka) 
        {
            stroka = stroka.ToUpper();
            return stroka.Replace("A", "4").Replace('B', '8').Replace('C', '(').Replace("D", "|)").Replace("E","3").Replace('G', '6').Replace("H", "|-|").Replace('I', '!').Replace("J",")").Replace("K","|<").Replace('L', '1').Replace("M",@"|\/|").Replace("N",@"|\|").Replace('O', '0').Replace("P","|>").Replace("Q","9").Replace("R","|2").Replace('S', '5').Replace('T', '7').Replace('Z', '2').Replace("U","|_|").Replace("V",@"\/").Replace("W",@"\/\/").Replace("X","><").Replace("Y","'/");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(perevod_v_leet("Belov"));
            Console.ReadKey();
        }
    }
}
