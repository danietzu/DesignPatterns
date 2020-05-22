using System;

namespace Strategy.Compressors
{
    public class JpegCompressor : ICompressor
    {
        public void Compress()
        {
            Console.WriteLine("Compressing using JPEG");
        }
    }
}