using Adapter.Images;
using Adapter.MyFilters;
using Adapter.ThirdPartyFilters;

namespace Adapter.Adapters
{
    public class CaramelAdapter : IFilter
    {
        private readonly CaramelFilter _caramelFilter;

        public CaramelAdapter(CaramelFilter caramelFilter)
        {
            _caramelFilter = caramelFilter;
        }

        public void Apply(Image image)
        {
            _caramelFilter.Init();
            _caramelFilter.Render(image);
        }
    }
}