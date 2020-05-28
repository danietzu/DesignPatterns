namespace SOLID.OCP
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}