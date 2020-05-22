using System;

namespace Strategy.Filters
{
    public class HCFilter : IFilter
    {
        public void ApplyFilter()
        {
            Console.WriteLine("Applying high contrast filter");
        }
    }
}