using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderClass
{
    public class Library: IEnumerable<Reader>
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public readonly int NumberOfReaders;
        private List<Reader> Readers;    
        public Library(string name, string adress, IEnumerable<Reader> readers)
        {
            Name = name;
            Adress = adress;
           
            Readers = new List<Reader>(readers.Distinct());
            NumberOfReaders = readers.Count();
        }
        public IEnumerator<Reader> GetEnumerator()=> Readers.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
