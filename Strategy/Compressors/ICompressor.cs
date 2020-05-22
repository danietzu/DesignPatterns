using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Compressors
{
    public interface ICompressor
    {
        void Compress();
    }
}