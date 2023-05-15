using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderClass
{
    public class TicketSorter: IComparer<Reader>
    {

        public int Compare(Reader x, Reader y)
        {
            if (x.LTicketNumber > y.LTicketNumber)
            {
                return 1;
            }
            else if (x.LTicketNumber < y.LTicketNumber)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
