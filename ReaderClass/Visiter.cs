using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderClass
{
    public class Visiter: Reader
    {
        public DateTime EntryTime { get; set; }
        public DateTime ExitTime { get; set; }
        public string Licence;
        public string NumberOfLicence;
        public Visiter(string Name, string Surname, string EntryTime, string ExitTime, string Licence, string NumberOfLicence) : base (Name, Surname)
        {
            this.EntryTime = DateTime.Parse(EntryTime);
            this.ExitTime = DateTime.Parse(ExitTime);
            this.Licence = Licence;
            this.NumberOfLicence = NumberOfLicence;
        }
        public override string GetInfo()
        {
            return $"Визитер {Name} {Surname}\n Время входа: {EntryTime:H:mm}\nВремя выхода: {ExitTime:H:mm}\nЛицензия и ее номер: {Licence}, {NumberOfLicence}";
        }
    }
}
