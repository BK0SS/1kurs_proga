using ReaderClass;

namespace Librarytest
{
    public class Tests
    {
        static Reader TestReader;

        [SetUp]
        public void Setup()
        {
            TestReader = new Reader("Mike", "Tyson", "10.02.1987", 123, 90, 99);
        }

        [Test]
        public void Test1()
        {
            Assert.That(TestReader.Name, Is.EqualTo("Mike"));
            Assert.That(TestReader.Surname, Is.EqualTo("Tyson"));
            Assert.That(TestReader.IssueDate.ToShortDateString, Is.EqualTo("10.02.1987"));
            Assert.That(TestReader.LTicketNumber, Is.EqualTo(123));
            Assert.That(TestReader.Period, Is.EqualTo(90));
            Assert.That(TestReader.Pledge, Is.EqualTo(99));
            Assert.That(TestReader.ReturnDate, Is.EqualTo(TestReader.IssueDate.AddDays(TestReader.Period)));
        }
        [Test]
        public void Reader_GetInfo_Test()
        {
            string expectedInfo = "Mike Tyson";
            expectedInfo += ", читательский билет: 123.";
            expectedInfo += "Дата выдачи 10.02.1987, период выдачи:90\n";
            expectedInfo += $"Дата возврата:11.05.1987. Залог: {TestReader.Pledge:c}";

            Assert.That(TestReader.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}
