using System;

namespace ReaderClass
{
    public class TemporaryReader : Reader
    {
        public DateTime EndOfAccess { get; set; }

        public string[] AccessableDepats = { };

        public TemporaryReader(string Name, string Surname, string IssueDate, string EndOfAccess, string Departments, int LTicketNumber, int Period, decimal Pledge) : base(Name, Surname, IssueDate, LTicketNumber, Period, Pledge)
        {
            this.EndOfAccess = DateTime.Parse(EndOfAccess);
            this.AccessableDepats = Departments.Split(',');
        }

        public override string GetInfo()
        {
            return $"Временный читатель " + base.GetInfo() + $" Конец доступа {EndOfAccess:d}\n Доступные разделы {String.Join(",", AccessableDepats)}";
        }
    }
}