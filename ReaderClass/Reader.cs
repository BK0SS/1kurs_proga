using System;

namespace ReaderClass
{
    public class Reader : IComparable<Reader>
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

        public Reader(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
        }

        public int CompareTo(Reader other)
        {
            if (this.Surname != other.Surname)
            {
                return this.Surname.CompareTo(other.Surname);
            }
            else
            {
                return this.Name.CompareTo(other.Name);
            }
        }

        public virtual string GetInfo()
        {
            return $"{Name} {Surname}, читательский билет: {LTicketNumber}.Дата выдачи {IssueDate:d}, период выдачи:{Period}\n" +
                $"Дата возврата:{ReturnDate:d}. Залог: {Pledge:c}";
        }
    }
}