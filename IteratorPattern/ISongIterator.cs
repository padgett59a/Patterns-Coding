using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public interface ISongIterator
    {
        //Java: Iterator
        public IEnumerator createIterator();
    }
}
