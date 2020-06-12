using Adapter.Images;
using System;

namespace Adapter.ThirdPartyFilters
{
    public class CaramelFilter
    {
        public void Init()
        {
        }

        public void Render(Image image)
        {
            Console.WriteLine("Applying caramel filter on image " + image.GetHashCode());
        }
    }
}