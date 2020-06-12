using Adapter.Images;

namespace Adapter.MyFilters
{
    public interface IFilter
    {
        void Apply(Image image);
    }
}