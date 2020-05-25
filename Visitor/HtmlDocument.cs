using System.Collections.Generic;

namespace Visitor
{
    public class HtmlDocument
    {
        private readonly List<IHtmlNode> _nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node)
        {
            _nodes.Add(node);
        }

        // extensibility point
        public void Execute(IOperation operation)
        {
            foreach (var node in _nodes)
                node.Execute(operation);
        }
    }
}