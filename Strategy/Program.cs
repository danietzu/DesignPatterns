using Strategy.Compressors;
using Strategy.Filters;

namespace Strategy
{
    internal class Program
    {
        private static void Main()
        {
            var storage = new ImageStorage(new JpegCompressor(), new HCFilter());

            storage.Store();
        }
    }
}