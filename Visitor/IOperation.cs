namespace Visitor
{
    public interface IOperation
    {
        void Apply(HeadingNode heading);

        void Apply(AnchorNode anchor);
    }
}