using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderClass
{
    public class ConnstantReader : Reader
    {
        public DateTime DateOfAcceptence { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public ConnstantReader(string Name, string Surname, string Adress,string PhoneNumber, string DateOfAcceptence, string IssueDate, int LTicketNumber, int Period, decimal Pledge) : base(Name, Surname, IssueDate, LTicketNumber, Period, Pledge)
        {
            this.DateOfAcceptence = DateTime.Parse(DateOfAcceptence);
            this.Adress = Adress;
            this.PhoneNumber = PhoneNumber; 
        }

        public override string GetInfo()
        {
            return $"Постоянный читатель " + base.GetInfo() +
                $" Адрес {Adress}\n номер: {PhoneNumber}, дата записи  в библиотеку {DateOfAcceptence:d}";
        }
    }
}
