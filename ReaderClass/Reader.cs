using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderClass
{
    public class Reader
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime IssueDate;
        public readonly int LTicketNumber;
        public int Period;
        public readonly DateTime ReturnDate;
        public decimal Pledge;

        public Reader(string Name, string Surname, string IssueDate, int LTicketNumber, int Period, decimal Pledge)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.IssueDate = DateTime.Parse(IssueDate);
            this.LTicketNumber = LTicketNumber;
            this.Period = Period;
            ReturnDate = DateTime.Parse(IssueDate).AddDays(Period);
            this.Pledge = Pledge;
        }

        public string GetInfo()
        {

            return $"{Name} {Surname}, читательский билет: {LTicketNumber}.Дата выдачи {IssueDate:d}, период выдачи:{Period}\n" +
                $"Дата возврата:{ReturnDate:d}. Залог: {Pledge:c}";
        }
        public void PrintInfo()
        {
            Console.WriteLine(GetInfo());
        }
    }
}
