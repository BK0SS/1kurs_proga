using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Program
    {


        static void Main(string[] args)
        {
            List<char> vowels = new List<char> {'а','о','ы','и','у','э','ё','я','е','ю'};
            string sentance = Console.ReadLine().ToLower();
            int allvowels = 0;
            
            for(int i = 0; i < vowels.Count; i++)
            {
                int vowelcount = 0;
                if (sentance.Contains(vowels[i]))
                {
                    vowelcount = sentance.Count(s => s.Equals(vowels[i]));
                    Console.WriteLine($"Буква {vowels[i]} вчтречается {vowelcount} раз");
                    allvowels++;
                }
            }
            Console.WriteLine(allvowels+" общее количество гласных");
           
                
            Console.ReadKey();
        }
    }
}
