using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Zadnanie
{
    internal class Sypher
    {
        public static Dictionary<char,int> CalculateChars(string filepath)
        {
            StreamReader reader = new StreamReader(filepath);
            Dictionary<char,int> result = new Dictionary<char,int>();
            while(!reader.EndOfStream)
            {
                char c = (char)reader.Read();
                if (char.IsLetter(c))
                {
                    if (result.ContainsKey(c))
                    {
                        result[c]++;
                    }
                    else
                    {
                        result.Add(c, 1);
                    }
                }
            }
            reader.Close();     
            return result;
        }
        public static string Output(string path)
        {
            var dict = CalculateChars(path).OrderByDescending(x => x.Value).ToList();
            string answer = "Список частотного анализа\n";
            int place = 1;
            for (int i = 0; i <= 4; i++)
            {
                answer += $" Топ {place} - {dict[i]}\n";
                place++;
            }
            StreamWriter streamWriter = new StreamWriter(path,append:true);
            streamWriter.WriteLine(String.Join("\n",dict));
            streamWriter.Close();

    
            return answer;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Укажите путь к текстовому файлу");
            string FilePath = Console.ReadLine();
            
            Console.WriteLine(Output(FilePath));
            Console.Read();
        }
    }
}
