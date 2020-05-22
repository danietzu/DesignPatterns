using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Application_C.Editor
{
    public class HtmlDocument
    {
        private string _content;

        public string Content { get => _content; set => _content = value; }

        public void MakeBold()
        {
            _content = $"<b>{_content}</b>";
        }
    }
}