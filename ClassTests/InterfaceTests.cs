using ReaderClass;
using System.ComponentModel;
using System.IO;
using System.Xml.Linq;

namespace Librarytest
{
    public class InterfaceTests
    {
        public Library NewLibrary;
        public List<Reader> ReadersOfLibrary1;
        public TicketSorter ticketSorter;
        [SetUp]
        public void Setup()
        {
            ticketSorter = new TicketSorter();
            var peter = new Reader("Peter", "Porker", "11.03.1999", 45, 20, 200);
            var steven = new Reader("Steven", "Porker", "9.03.1999", 49, 24, 232);
            var joe = new Reader("Joe", "Fraizer", "15.06.1988", 25, 2, 143);
            ReadersOfLibrary1 = new List<Reader>();
            ReadersOfLibrary1.Add(peter);
            ReadersOfLibrary1.Add(steven);  
            ReadersOfLibrary1.Add(joe);

            NewLibrary = new Library("Library1", "Пушкина 2",ReadersOfLibrary1);
        }
        [Test]
        public void Library_Test()
        {
            Assert.That(NewLibrary.Name, Is.EqualTo("Library1"));
            Assert.That(NewLibrary.Adress, Is.EqualTo("Пушкина 2"));

            Assert.That(NewLibrary.Count(),Is.EqualTo(3));

            int i = 0;
            foreach(Reader reader in ReadersOfLibrary1)
            {
                Assert.That(reader, Is.EqualTo(ReadersOfLibrary1[i++]));
            }
        }

        [Test]
        public void Reader_TicketSorterTest()
        {
            var FirstReader = new Reader("Артем", "Лебедев", "10.02.1987", 223, 90, 99);
            var SecondReader = new Reader("Влад", "Владисалов", "10.02.1987", 1223, 90, 99);
            var ThirdReader = new Reader("Глеб", "Вторхлор", "10.02.1987", 43, 90, 99);
            
            List<Reader> list = new List<Reader>();
            list.Add(FirstReader);
            list.Add(SecondReader);
            list.Add(ThirdReader);

            list.Sort(ticketSorter);
            Assert.That(list[0].LTicketNumber, Is.EqualTo(ThirdReader.LTicketNumber));
            Assert.That(list[2].LTicketNumber, Is.EqualTo(SecondReader.LTicketNumber));

        }
        
    }
}