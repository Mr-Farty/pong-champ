using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong3.Patterns.Iterator
{
    public interface IIterableCollection
    {
        IIterator CreateIterator();
    }
}
