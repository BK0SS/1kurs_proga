using ReaderClass;
using System.ComponentModel;
using System.IO;
using System.Xml.Linq;

namespace Librarytest
{
    public class Test4
    {
        
        static Visiter TestReader;
        [SetUp]
        public void Setup()
        {
            TestReader = new Visiter("Mike","Tyson","10:20","10:30","Паспорт","92309324");
        }
        [Test]
        public void Test2()
        {
            Assert.That(TestReader.Name, Is.EqualTo("Mike"));
            Assert.That(TestReader.Surname, Is.EqualTo("Tyson"));
            Assert.That(TestReader.EntryTime, Is.EqualTo(DateTime.Parse("10:20")));
            Assert.That(TestReader.ExitTime, Is.EqualTo(DateTime.Parse("10:30")));
            Assert.That(TestReader.Licence, Is.EqualTo("Паспорт"));
            Assert.That(TestReader.NumberOfLicence, Is.EqualTo("92309324"));
        }
        public void Visiter_GetInfo_Test()
        {
            string expeted = $"Визитер {TestReader.Name} {TestReader.Surname}\n Время входа: {TestReader.EntryTime:H:mm}\nВремя выхода: {TestReader.ExitTime:H:mm}\nЛицензия и ее номер: {TestReader.Licence}, {TestReader.NumberOfLicence}";
            Assert.That(expeted, Is.EqualTo(TestReader.GetInfo()));
        }
    }
}