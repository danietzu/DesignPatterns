using System;

namespace Strategy.Compressors
{
    public class PngCompressor : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing using PNG");
        }
    }
}