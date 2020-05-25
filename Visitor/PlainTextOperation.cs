using System;

namespace Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("Extract plain text from heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("Extract plain text from anchor");
        }
    }
}