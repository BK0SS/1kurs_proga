using ReaderClass;

namespace Librarytest
{
    public class Tests2
    {
        static ConnstantReader TestReader;
        
        [SetUp]
        public void Setup()
        {
            TestReader = new ConnstantReader("Mike", "Tyson","Челюскинцев","+791281237", "10.02.1990", "10.02.1987", 123, 90, 99);
        }

        [Test]
        public void Test2()
        {
            Assert.That(TestReader.Name, Is.EqualTo("Mike"));
            Assert.That(TestReader.Surname, Is.EqualTo("Tyson"));
            Assert.That(TestReader.IssueDate.ToShortDateString, Is.EqualTo("10.02.1987"));
            Assert.That(TestReader.DateOfAcceptence, Is.EqualTo(DateTime.Parse("10.02.1990")));
            Assert.That(TestReader.Adress, Is.EqualTo("Челюскинцев"));
            Assert.That(TestReader.PhoneNumber, Is.EqualTo("+791281237"));
            Assert.That(TestReader.LTicketNumber, Is.EqualTo(123));
            Assert.That(TestReader.Period, Is.EqualTo(90));
            Assert.That(TestReader.Pledge, Is.EqualTo(99));
            Assert.That(TestReader.ReturnDate, Is.EqualTo(TestReader.IssueDate.AddDays(TestReader.Period)));
        }
        [Test]
        public void ConnstantReader_GetInfo_Test()
        {
            string expectedInfo = "Постоянный читатель Mike Tyson";
            expectedInfo += ", читательский билет: 123.";
            expectedInfo += "Дата выдачи 10.02.1987, период выдачи:90\n";
            expectedInfo += $"Дата возврата:11.05.1987. Залог: {TestReader.Pledge:c}";
            expectedInfo += $" Адрес Челюскинцев\n номер: +791281237, дата записи  в библиотеку 10.02.1990";

            Assert.That(TestReader.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}