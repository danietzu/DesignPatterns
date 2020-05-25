namespace Visitor
{
    internal class Program
    {
        private static void Main()
        {
            var document = new HtmlDocument();

            document.Add(new HeadingNode());
            document.Add(new AnchorNode());

            document.Execute(new HighlightOperation());
            document.Execute(new PlainTextOperation());
        }
    }
}