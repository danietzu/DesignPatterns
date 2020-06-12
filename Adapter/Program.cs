using Adapter.Adapters;
using Adapter.Images;
using Adapter.MyFilters;
using Adapter.ThirdPartyFilters;

namespace Adapter
{
    internal class Program
    {
        private static void Main()
        {
            var imageView = new ImageView(new Image());
            imageView.Apply(new VividFilter());
            imageView.Apply(new CaramelAdapter(new CaramelFilter()));
        }
    }
}