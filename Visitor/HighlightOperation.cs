using System;

namespace Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Highlight heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Highlight anchor");
        }
    }
}