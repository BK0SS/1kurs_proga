using ReaderClass;

namespace Librarytest
{
    public class Test3
    {
        static TemporaryReader TestReader;
        
        [SetUp]
        public void Setup()
        {
            TestReader = new TemporaryReader("Mike", "Tyson", "10.02.1987","10.07.1999" ,"������, ������",123, 90, 99);
        }

        [Test]
        public void TemporaryReader_ConstructorTest()
        {
            Assert.That(TestReader.Name, Is.EqualTo("Mike"));
            Assert.That(TestReader.Surname, Is.EqualTo("Tyson"));
            Assert.That(TestReader.IssueDate.ToShortDateString, Is.EqualTo("10.02.1987"));
            Assert.That(TestReader.EndOfAccess.ToShortDateString, Is.EqualTo("10.07.1999"));
            Assert.That(String.Join(",",TestReader.AccessableDepats), Is.EqualTo("������, ������"));
            Assert.That(TestReader.LTicketNumber, Is.EqualTo(123));
            Assert.That(TestReader.Period, Is.EqualTo(90));
            Assert.That(TestReader.Pledge, Is.EqualTo(99));
            Assert.That(TestReader.ReturnDate, Is.EqualTo(TestReader.IssueDate.AddDays(TestReader.Period)));
        }
        [Test]
        public void TemporaryReader_GetInfo_Test()
        {
            string expectedInfo = $"��������� �������� " + "Mike Tyson";
            expectedInfo += ", ������������ �����: 123.";
            expectedInfo += "���� ������ 10.02.1987, ������ ������:90\n";
            expectedInfo += $"���� ��������:11.05.1987. �����: {TestReader.Pledge:c}";
            expectedInfo += $" ����� ������� 10.07.1999\n ��������� ������� {String.Join(",", TestReader.AccessableDepats)}";


            Assert.That(TestReader.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}