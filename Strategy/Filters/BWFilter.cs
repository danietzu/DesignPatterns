using System;

namespace Strategy.Filters
{
    public class BWFilter : IFilter
    {
        public void ApplyFilter()
        {
            Console.WriteLine("Applying B&W filter");
        }
    }
}