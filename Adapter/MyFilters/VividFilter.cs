using Adapter.Images;
using System;

namespace Adapter.MyFilters
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying vivid filter");
        }
    }
}