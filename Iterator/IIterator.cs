using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();

        T Current();

        void Next();
    }
}